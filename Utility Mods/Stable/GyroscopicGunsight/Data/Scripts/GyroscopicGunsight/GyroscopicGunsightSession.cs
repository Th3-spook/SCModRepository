﻿using System;
using System.Collections.Generic;
using System.Linq;
using Sandbox.ModAPI;
using Sandbox.ModAPI.Interfaces;
using SC.GyroscopicGunsight.API.CoreSystems;
using VRage.Game;
using VRage.Game.Components;
using VRage.Game.Entity;
using VRage.Game.ModAPI;
using VRage.Utils;
using VRageMath;

namespace SC.GyroscopicGunsight
{
    [MySessionComponentDescriptor(MyUpdateOrder.NoUpdate)]
    internal class GyroscopicGunsightSession : MySessionComponentBase
    {
        public WcApi WcApi = new WcApi();

        private MyStringId _gunsightTexture = MyStringId.GetOrCompute("GyroGunsight");
        private Vector4 _gunsightColor = new Vector4(1, 1, 1, 1);
        Vector3D currentPos;
        Vector3D vectorToTarget;
        public double distanceToTarget;
        Vector3D prevPosition;
        Vector3D velocity;

        public double deflectionX;
        public double deflectionY;
        public double xRate;
        public double yRate;
        public double muzzleVelocity = 2000;
        public double range;

        /// <summary>
        /// Distance from the camera to the billboard.
        /// Ideally, this should be as low as possible.
        /// </summary>
        private const float NearDistance = 4f;
        /// <summary>
        /// Size in meters of the billboard.
        /// Seems to have a lower cap of 0.05?
        /// </summary>
        private const float SightSize = 0.1f;

        public override void LoadData()
        {
            WcApi.Load();
        }

        private float i = 0;
        public override void Draw()
        {
            if (MyAPIGateway.Utilities.IsDedicated || !(WcApi?.IsReady ?? false))
                return;

            try
            {
                // Look for the grid the player is in
                var currentGrid = (MyAPIGateway.Session.Player.Controller.ControlledEntity as IMyCockpit)?.CubeGrid;
                if (currentGrid == null)
                    return;

                var target = WcApi.GetAiFocus((MyEntity) currentGrid);
                if (target == null)
                {
                    MyAPIGateway.Utilities.ShowNotification("No Target!", 1000/60);
                    return;
                }

                // Grab fixed guns
                var fixedWeapons = currentGrid.GetFatBlocks<IMyConveyorSorter>().Where(b => WcApi.HasCoreWeapon((MyEntity) b) && (b.GetProperty("Target Group")?.AsFloat()?.GetValue(b) ?? 0) != 0);
                MyAPIGateway.Utilities.ShowNotification("Fixed Guns: " + fixedWeapons.Count(), 1000/60);


                // actual calculations
                HashSet<string> drawnSubtypes = new HashSet<string>();
                foreach (var weapon in fixedWeapons)
                {
                    if (!drawnSubtypes.Add(weapon.BlockDefinition.SubtypeId))
                        continue;

                    Vector3D dynamicPosition = CalculateDeflection(weapon, target as IMyCubeGrid);
                    DrawGunsight(dynamicPosition);
                }
                
            }
            catch (Exception ex)
            {
                MyLog.Default.WriteLine(ex);
            }
        }

        /// <summary>
        /// Squid's fancy leading math
        /// </summary>
        /// <param name="thisWeapon"></param>
        /// <param name="targetGrid"></param>
        public Vector3D CalculateDeflection(IMyCubeBlock thisWeapon, IMyCubeGrid targetGrid)
        {
            if (thisWeapon == null || targetGrid == null)
            {
                MyLog.Default.WriteLine("CalculateDeflection error: thisWeapon or targetGrid is null");
                return Vector3D.Zero; // Return a default value to avoid breaking
            }

            // It shouldn't matter if an NRE gets thrown here, it's caught elsewhere, and it would be an Actual Problem:tm:
            //var shipAngularVelocity = thisWeapon.CubeGrid.Physics.AngularVelocity;
            var weaponAngularVelocity = thisWeapon.CubeGrid.Physics.GetVelocityAtPoint(thisWeapon.WorldMatrix.Translation) - thisWeapon.CubeGrid.LinearVelocity;
            Vector3D targetPos = targetGrid.GetPosition();
            Vector3D myPos = thisWeapon.CubeGrid.GetPosition();


            range = Vector3.Distance(myPos, targetPos);

            deflectionX = (range / muzzleVelocity) * weaponAngularVelocity.X;
            deflectionY = (range / muzzleVelocity) * weaponAngularVelocity.Y;


            MatrixD cameraMatrix = MatrixD.Identity; // pretend this is filled out


            Vector3D offsetVec = new Vector3D(deflectionX, deflectionY, 0); // Full trailing reticle

            return targetPos + Vector3D.Transform(offsetVec, cameraMatrix.GetOrientation());
        }

        /// <summary>
        /// Aristeas's unfancy texture math
        /// </summary>
        /// <param name="Position"></param>
        public void DrawGunsight(Vector3D Position)
        {
            try
            {
                var camera = MyAPIGateway.Session.Camera;
                Vector3D offsetPosition = (Position - camera.Position).Normalized() * NearDistance + camera.Position;

                MySimpleObjectDraw.DrawLine(offsetPosition + camera.WorldMatrix.Left * SightSize, offsetPosition + camera.WorldMatrix.Right * SightSize, _gunsightTexture, ref _gunsightColor, SightSize);
            }
            catch (Exception ex)
            {
                MyLog.Default.WriteLine(ex);
            }
        }
    }
}
