﻿using System.Collections.Generic;
using Sandbox.Game.Entities;
using StarCore.FusionSystems.Communication;
using VRage.Game.ModAPI;

namespace StarCore.FusionSystems.HeatParts
{
    internal class GridHeatManager
    {
        private const float BaseHeatCapacityModifier = 0.25f;
        private const float BaseHeatDissipationModifier = 1 / 1800f;
        private readonly Dictionary<int, HeatSystem> _heatSystems = new Dictionary<int, HeatSystem>();

        private int _ticks;
        public float BaseHeatCapacity;
        public float BaseHeatDissipation;
        public float HeatCapacity = 0;

        public float HeatDissipation = 0;

        public float HeatGeneration;

        public float HeatRatio = float.PositiveInfinity;

        public float HeatStored;

        public GridHeatManager(IMyCubeGrid grid)
        {
            Grid = (MyCubeGrid)grid;
        }

        private static ModularDefinitionApi ModularApi => ModularDefinition.ModularApi;

        public MyCubeGrid Grid { get; }

        public float GrossHeatDissipation => (HeatDissipation + BaseHeatDissipation) * HeatRatio;

        public void UpdateTick()
        {
            if (_ticks % 15 == 0)
                Update15Tick();
            _ticks++;

            if (HeatCapacity + BaseHeatCapacity == 0)
            {
                HeatRatio = 1;
                HeatStored = 0;
                return;
            }

            HeatStored += (HeatGeneration - GrossHeatDissipation) / 60;
            if (HeatStored < 0)
                HeatStored = 0;
            else if (HeatStored > HeatCapacity + BaseHeatCapacity)
                HeatStored = HeatCapacity + BaseHeatCapacity;

            HeatRatio = HeatStored / (HeatCapacity + BaseHeatCapacity);
        }

        private void Update15Tick()
        {
            var gridSize = (Grid.Max - Grid.Min) * Grid.GridSize;

            BaseHeatCapacity = Grid.BlocksCount * BaseHeatCapacityModifier;
            BaseHeatDissipation = 2 * (gridSize.X * gridSize.Y + gridSize.Y * gridSize.Z + gridSize.Z * gridSize.X) *
                                  BaseHeatDissipationModifier;

            HeatGeneration = 0;
            foreach (var assemblyId in ModularApi.GetGridAssemblies(Grid))
                HeatGeneration +=
                    ModularApi.GetAssemblyProperty<float>(assemblyId,
                        "HeatGeneration"); // Can pull from all heat sources
        }

        public void Unload()
        {
            foreach (var system in _heatSystems.Values)
                system.OnClose();
        }

        public void OnPartAdd(int assemblyId, IMyCubeBlock block, bool isBaseBlock)
        {
            if (!_heatSystems.ContainsKey(assemblyId)) _heatSystems[assemblyId] = new HeatSystem(assemblyId, this);

            _heatSystems[assemblyId].OnPartAdd(block);
        }

        public void OnPartRemove(int assemblyId, IMyCubeBlock block, bool isBaseBlock)
        {
            var system = _heatSystems[assemblyId];
            system.OnPartRemove(block);

            if (system.BlockCount <= 0)
            {
                system.OnClose();
                _heatSystems.Remove(assemblyId);
            }
        }
    }
}