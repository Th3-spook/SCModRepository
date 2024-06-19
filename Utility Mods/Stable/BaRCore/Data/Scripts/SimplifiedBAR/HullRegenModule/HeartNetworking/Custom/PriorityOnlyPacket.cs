﻿using System;
using ProtoBuf;
using Sandbox.ModAPI;

namespace StarCore.RepairModule.Networking.Custom
{
    [ProtoContract]
    public class PriorityOnlyPacket : PacketBase
    {
        [ProtoMember(8)] private bool priorityOnly;
        [ProtoMember(9)] private long entityId;

        public override void Received(ulong SenderSteamId)
        {
            Log.Info("Recieved Terminal Controls Update Request. Contents:\n    PriorityOnly: " + priorityOnly);

            RepairModule.GetLogic<RepairModule>(entityId).PriorityOnly = priorityOnly;
        }

        public static void UpdatePriorityOnly(long entityID )
        {
            try
            {
                PriorityOnlyPacket packet = new PriorityOnlyPacket
                {
                    priorityOnly = RepairModule.GetLogic<RepairModule>(entityID).PriorityOnly,
                    entityId = entityID,
                };

                Log.Info("Sending Terminal Controls Update. Contents:\n    SubsystemPriority: " + packet.priorityOnly);

                if (MyAPIGateway.Session.IsServer)
                    HeartNetwork.I.SendToEveryone(packet);
                else
                    HeartNetwork.I.SendToServer(packet);
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
}
    }
}