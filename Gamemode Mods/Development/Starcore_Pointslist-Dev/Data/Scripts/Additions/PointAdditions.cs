﻿using Sandbox.ModAPI;
using VRage.Game;
using VRage.Game.Components;

namespace ShipPoints
{
    [MySessionComponentDescriptor(MyUpdateOrder.NoUpdate)]
    class PointAdditions : MySessionComponentBase
    {
        public override void Init(MyObjectBuilder_SessionComponent sessionComponent)
        {
            MyAPIGateway.Utilities.SendModMessage(2546247, MyAPIGateway.Utilities.SerializeToBinary(@"
				LargeBlockBatteryBlock@14;
                EmitterL@50;
                EmitterLA@50;
                LargeShieldModulator@50;
                LargeEnhancer@50;
                LargeBlockSmallGenerator@17;
                LargeBlockLargeGenerator@300;
		        LargeLargeBlockUpgrade@100;
				SmallLargeBlockUpgrade@20;
				DampeningEnhancer_x2_Large@100;
                LargeWarhead@100;
                LargeDecoy@4;
                LargeDecoy_MetalFoam@50;
                LargeStator@5;
                LargeAdvancedStator@5;
                LargeHinge@5;
                LargePistonBase@5;
				LargeRotor@5;
				LargeAdvancedRotor@5;
				LargeHingeHead@5;
                MA_Buster_ArmorBlock@3;
                MA_Buster_Window@3;
                MA_Buster_Camera@10;
                LargeBlockRemoteControl@100;
                LargeProgrammableBlock@100;
				LargeProgrammableBlockReskin@100;
				6SidePB@100;
				RailgunxTurretS@100;
				C100mmTurret@100;
				MA_T2PDX@150;
				MA_T2PDX_Slope@150;
				MA_T2PDX_Slope2@150;
				MA_Gimbal_Laser_T2@150;
				MA_Gimbal_Laser_T2_Armored@150;
				MA_Gimbal_Laser_T2_Armored_Slope@150;
				MA_Gimbal_Laser_T2_Armored_Slope2@150;
				MA_Gimbal_Laser_T2_Armored_Slope45@150;
				PlasmaCannonLB@200;
				MXA_CoilgunL@100;
				RailgunxTurretM@165;
				MA_AC150@125;
				MA_AC150_30@125;
				MA_AC150_45@125;
				MA_AC150_45_Gantry@125;
				MA_AC150_Gantry@125;
				K_SA_Gauss_APC@150;
				K_SA_Gauss_AMS@200;
				K_SA_Gauss_ERC@370;
				MXA_CoilgunH@180;
				MXA_SoFCoilgun@250;
				RailgunxTurret@250;
				MA_Gladius@390;
				MXA_BreakWater@10;
				MA_EMP@200;
				PGIFlareLauncherLarge@10;
				MA_PDX@50;
				MA_Gimbal_Laser@50;
				MA_Gimbal_Laser_Armored@50;
				MA_Gimbal_Laser_Armored_Slope@50;
				MA_Gimbal_Laser_Armored_Slope2@50;
				MA_Gimbal_Laser_Armored_Slope45@50;
				MA_PDT@50;
				CIWS@75;
				AMSlaser@50;
				MCRNRightRetractPDC@75;
				MCRNLeftRetractPDC@75;
				MCRNTopRetractPDC@75;
				MCRNPDCTurretLB@75;
				MXA_CoilgunPD@125;
				MXA_Rampart2@100;
				Railgunx@100;
				MA_Fixed_000@50;
				MA_Fixed_001@50;
				MA_Fixed_002@50;
				MA_Fixed_007@50;
				MA_Fixed_003@50;
				MA_Fixed_004@50;
				MA_Fixed_005@50;
				MA_Fixed_006@50;
				MXA_MACL@1100;
				MXA_SMAC@500;
				MXA_M2MAC@800;
				ARYXGaussCannon@1250;
				SC_AR_Aries@1250;
				K_SA_Launcher_FixedMount@275;
				AWGGG@150;
				GravityGenerator@0;
				MA_Afterburner_Large@200;
				MA_Afterburner_Large_small@50;
				MA_Afterburner_Large_5x@250;
				Afterburner_LG_Ion_Large@150;
				AncientAfterburnerT40@50;
				AncientAfterburnerT41@50;
				AncientAfterburnerT42@150;
				AncientAfterburnerT42L@150;
				AncientAfterburnerT43@200;
				AncientAfterburnerT44@250;
				MA_Tiger@125;
				MA_Crouching_Tiger@125;

				LargeHydrogenTank@30;
					LargeHydrogenTankIndustrial@30;
				LargeHydrogenTankSmall@30;

				LargeBlockLargeHydrogenThrust@50;
					AQD_LG_HydroThrusterL_ArmoredSlope@50;
					AQD_LG_HydroThrusterL_Armored@50;
					LargeBlockLargeHydrogenThrustIndustrial@50;
				LargeBlockSmallHydrogenThrust@15;
					AQD_LG_HydroThrusterS_ArmoredSlope@15;
					AQD_LG_HydroThrusterS_Armored@15;
					LargeBlockSmallHydrogenThrustIndustrial@15;
				HugeHydrogenThruster@200;

				LargeBlockLargeThrust@20;
					AQD_LG_IonThrusterL_ArmoredSlope@20;
					AQD_LG_IonThrusterL_Armored@20;
					LargeBlockLargeThrustSciFi@20;
					LargeBlockLargeModularThruster@20;
				LargeBlockSmallThrust@4;
					AQD_LG_IonThrusterS_Armored@4;
					AQD_LG_IonThrusterS_ArmoredSlope@4;				
					LargeBlockSmallThrustScifi@4;
					SmallThrustSciFi@4;
					LargeBlockSmallModularThruster@4;
				AWGFocusDrive@100;
				IonHeavyCovered@100;

				AQD_LG_AtmoThrusterS_ArmoredSlopeRev@3;
				AQD_LG_AtmoThrusterS_ArmoredSlope@3;
				AQD_LG_AtmoThrusterS_Armored@3;
				AQD_LG_AtmoThrusterL_ArmoredSlopeRev@3;
				AQD_LG_AtmoThrusterL_ArmoredSlope@3;
				AQD_LG_AtmoThrusterL_Armored@3;
				LargeBlockLargeAtmosphericThrust@3;
				LargeBlockSmallAtmosphericThrust@3;
				LargeBlockLargeAtmosphericThrustSciFi@3;
				LargeBlockSmallAtmosphericThrustSciFi@3;

				ARYXMagnetarCannon@450;
				ARYXPlasmaPulser@275;
				ARYXLargeRadar@10;
				ARYXBurstTurret@250;
				ARYXBurstTurretSlanted@250;
				SC_AR_CataclysmicVariable@450;
				SC_AR_Phaethon@275;
				SC_AR_Afflictor@250;
				SC_AR_Afflictor_Slanted@250;
				MA_Designator@50;
                BattleshipCannon@100;
                BattleshipCannonMK2@170;
                BattleshipCannonMK22@170;
                BattleshipCannonMK3@350;
				StaticBattery1@150;
				StaticBattery1Stack@150;
                M1Torpedo@190;
                M8Launcher@300;
				BFG_M@425;
				BFTriCannon@225;
				DSControlTable@50;
				DSControlLarge@50;
				K_SA_HeavyMetal_Gauss_ERII@900;
				K_SA_HeavyMetal_Gauss_ERIIRF@99999;
				K_SA_Launcher_FixedMountv2@500;
				ARYXTempestCannon@350;
				SC_AR_Tumult@350;
				ARYXLightCoilgun@700;
				SC_AR_Forager@700;
				SpaceBallLarge@42069;
				MA_Fixed_T2@150;
				MA_Fixed_T2_Naked@150;
				MA_Fixed_T3@120;
				ARYXRailgun@400;
				SC_AR_Nimrod@400;
				K_SA_LoW_CapitalSpinalA@650;
				Static150mm@50;
				ARYXFocusLance@500;
				SC_AR_LocusGleam@500;
				MediumFocusLance@125;
				MA_Designator_sm@50;
				MA_SideBooster_Small@100;
				SmallBlockBatteryBlock@15;
				SmallBlockSmallGenerator@1;
                SmallBlockLargeGenerator@15;
				PlasmaCannonSB@200;
				SmallGatlingTurret@75;
				MA_PDX_sm@200;
				MCRNPDCTurretSB@150;
				MCRNTopRetractPDCSB@150;
				MCRNLeftRetractPDCSB@150;
				MA_PDT_sm@75;
				MCRNRightRetractPDCSB@151;
				MXA_CoilgunPD_S@125;
				MXA_Rampart2_S@100;
				Railgunx75f@75;
				Railgunx150f@110;
				MXA_Sabre_Coilgun@50;
				MXA_Sabre_E_Coilgun@50;
				RotaryCannon@75;
				203mmHowitzer@100;
				MA_Fixed_sb_000@50;
				MA_Fixed_sb_001@50;
				MA_Fixed_sb_002@50;
				MA_Fixed_sb_003@50;
				MA_Fixed_sb_005@50;
				MA_Fixed_sb_006@50;
				MA_Fixed_sb_007@50;
				MA_Tiger_sm@150;
				MA_Tiger_30_sm@50;
				MXA_MACL_S@1000;
				MXA_M58ArcherPods_S@500;
				MXA_M2MAC_S@1000;
				SmallMissileTurret@75;
				SmallRocketLauncherReload@50;
				SmallMissileLauncher@50;
				SmallGatlingGun@50;
				PGIFlareLauncherSmall@300;
				SmallWarhead@50;
				MA_Gimbal_Laser_Armored_sb@70;
				MA_Gimbal_Laser_Armored_Slope_sb@70;
				MA_Gimbal_Laser_Armored_Slope2_sb@70;
				MA_Gimbal_Laser_Armored_Slope45_sb@70;
				MA_Gimbal_Laser_sb@70;
				MA_Blister@100;
				MA_Blister45@100;
				MA_Blister30@100;
				MA_Blister32@100;
				MA_Meatball@200;
				VirtualMassSmall@50;
				SmallHydrogenEngine@1;
				SmallBlockBatteryBlock@4;
				SmallBlockSmallBatteryBlock@1;
				SmallProgrammableBlock@50;
				SmallBlockRemoteControl@50;
				SmallDecoy@10;
				SmallStator@10;
				SmallAdvancedStator@10;
				MediumHinge@10;
				SmallHinge@10;
				SmallPistonBase@10;
				MyObjectBuilder_SmallMissileLauncher@50;
				MA_SideBooster_Small@100;
				Static30mm@100;
				M12Swarm@100;
				M2Destroyer@140;
				DSControlSmall@50;
				SmallShieldModulator@50;
				EmitterS@50;
				EmitterSA@50;
				SmallEnhancer@50;

				SpaceBallSmall@50;
				MA_Fixed_T2_sb@150;
				MA_Fixed_T2_Naked_sb@150;
				SCSmallJumpDrive@250;
				LargeBlockConveyorSorterIndustrial@0;
				MediumBlockConveyorSorter@0;
				LargeBlockConveyor@2;
				ConveyorTube@0;
				ConveyorTubeCurved@0;
				MA_Buster_Conveyor@3;
				LargeBlockConveyorPipeEnd@0;
				LargeBlockConveyorSorterIndustrial@0;
				LargeBlockConveyorPipeSeamless@0;
				LargeBlockConveyorPipeCorner@0;
				LargeBlockConveyorPipeJunction@2;
				LargeBlockConveyorPipeIntersection@1;
				LargeBlockConveyorPipeFlange@0;
				LargeBlockConveyorPipeEnd@0;
				AQD_LG_ConveyorTArmored@0;
				AQD_LG_ConveyorXArmored@1;
				AQD_LG_ConveyorEndcap@0;
				AQD_LG_ConveyorAccess@0;
				AQD_LG_ConveyorVent@0;
				AQD_LG_ConveyorCornerArmored@0;
				AQD_LG_ConveyorStraightArmored@0;
				AQD_LG_ConveyorStraight5x1@0;
				AQD_LG_ConveyorJunctionTubes@1;
				LargeBlockGyro@1;
				AQD_LG_LargeGyro@10;
				AQD_LG_GyroBooster@3;
				AQD_LG_GyroUpgrade@10;
				K_SA_HeavyMetal_Gauss_ERFM@400;
				K_SA_HeavyMetal_Gauss_A@300;
				K_SA_HeavyMetal_Gauss_PGBC@900;
				Starcore_PPC_Block@350;
				Starcore_AMS_II_Block@175;
				MA_Derecho@225;
				MA_Buster_Passage@3;
				MA_Buster_Passage_Crossing@3;
				OffroadWheel1x1@35000;
				OffroadWheel3x3@35000;
				OffroadWheel5x5@35000;
				OffroadWheel5x5@35000;
				Wheel5x5@35000;
				Wheel3x3@35000;
				Wheel1x1@35000;
				K_SA_Gauss_AMSIIC@350;
				SA_HMI_Erebos@250;
				HAS_Thanatos@350;
               	HAS_Alecto@400;
           		HAS_Assault@250;
           		HAS_Nyx@250;
     			HAS_Mammon@450;
				LargeBlockRadioAntenna@5;
				LargeBlockRadioAntennaDish@5;
				SC1x1Antenna@5;
				C500mmTurret@300;
				C300mmTurret@275;
				C200mmTurret@160;
				C400mmTurret@300;
				LargeBlockSmallGeneratorWarfare2@17;
				LargeBlockBatteryBlockWarfare2@14;
				LargeBlockLargeGeneratorWarfare2@300;
				LargeTurretControlBlock@200;
				ARYXRailgunTurret@350;
				SC_AR_Resheph@350;
				MCRNRailgunLB@1250;
				MAR_1x1x1_AR_DualHead_Rotor@5;
				MAR_1x1x1_AR_DualHead_Stator@5;
				MAR_1x1x1_AR_DualHead_Rotor_forLG@5;
				MAR_1x1x1_AR_Rotor_forLG@5;
				MAR_1x1x1_AR_Half_Rotor_forLG@5;
				MAR_1x1x1_AR_Rotor@5;
				MAR_1x1x1_AR_Stator@5;
				MAR_2x1x1_AR_Stator_ADJ@5;
				MAR_1x1x1_AR_Half_Rotor@5;
				MAR_1x1x1_AR_Half_Stator@5;
				MAR_LG_1x1x1_AR_DualHead_Rotor@5;
				MAR_LG_1x1x1_AR_DualHead_Stator@5;
				MAR_LG_1x1x1_AR_Rotor@5;
				MAR_LG_1x1x1_AR_Stator@5;
				MAR_LG_1x1x1_AR_Half_Rotor@5;
				MAR_LG_1x1x1_AR_Half_Stator@5;
				MAR_LG_2x1x1_AR_Stator_ADJ@5;
				MAR_LG_2x1x1_AR_Dualhead_Stator_ADJ@5;
				TRR_5x5x1_TR_Rotor@50;
				TRR_5x5x1_TR_Stator@50;
				TRR_7x7x1_TR_Rotor@60;
				TRR_7x7x1_TR_Stator@60;
				TRR_9x9x1_TR_Rotor@70;
				TRR_9x9x1_TR_Stator@70;
				TRR_11x11x1_TR_Rotor@80;
				TRR_11x11x1_TR_Stator@80;
				TRR_LG_5x5x1_TR_Rotor@50;
				TRR_LG_5x5x1_TR_Stator@50;
				TRR_LG_7x7x1_TR_Rotor@60;
				TRR_LG_7x7x1_TR_Stator@60;
				TRR_LG_9x9x1_TR_Rotor@70;
				TRR_LG_9x9x1_TR_Stator@70;
				TRR_LG_11x11x1_TR_Rotor@80;
				TRR_LG_11x11x1_TR_Stator@80;
				K_SA_HeavyMetal_Spinal_Rotary@1000;
				K_SA_HeavyMetal_Spinal_Rotary_Reskin@1000;
				MetalStorm@125;
				Odin_Rail_2@300;
				Odin_Rail_1@200;

				MCRN_Heavy_Torpedo@350;
				OPA_Heavy_Torpedo@200;
				OPA_Light_Missile@150;
				UNN_Heavy_Torpedo@125;
				UNN_Light_Torpedo@200;
				Starcore_Fixed_Coil_Cannon@400;
				Starcore_AMS_I_Block@125;
				Starcore_AMS_Comm_Block@100;
				Odin_Torpedo@220;
				Odin_Missile_Battery@200;
				K_SA_Launcher_VIV@350;
				K_SA_Launcher_VI@350;
				Starcore_SSRM_Block@250;
				ModularSRM8@250;
				Starcore_MRM_Block@300;
				Starcore_MRM45_Block@300;
				ModularMRM10@60;
				ModularMiddleMRM10@60;
				ModularMRM10Angled@60;
				ModularMRM10AngledReversed@60;
				Starcore_LRM_Block@225;
				Starcore_LRM45_Block@225;
				ModularLRM5@40;
				ModularLRM5Angled@40;
				ModularMiddleLRM5@40;
				ModularLRM5AngledReversed@40;
				Starcore_Arrow_Block@300;
				SC_Flare@50;

				Odin_Laser_Fixed@350;
				Odin_Autocannon_Fixed@350;
				Odin_PDC@100;
				Odin_Defense_1x2@100;
				Odin_Gatling_Laser@275;
				Odin_5x5_Cannon@450;
				BlinkDriveLarge@500;
				Chet_Flak_Cannon@99999;
				Odin_PDC@100;
				Odin_PDC_45_Slope@100;
				Odin_PDC_Half_Slope_Tip@100;
				Odin_PDC_Half@100;
				Odin_PDC_Half_Slope_Top@100;
				Odin_CoilCannon@450;
				Odin_Autocannon_2@250;
				Starcore_M_Laser_Block@75;
				Starcore_L_Laser_Block@150;
				Starcore_Basic_Warhead@5;
				Odin_7x7_Battleshipcannon@550;
				Odin_7x7_Battleshipcannon_Surface@550;
				Odin_5x5_Battleshipcannon@225;
				Odin_5x5_Battleshipcannon_Surface@225;
				Odin_3x3_Battleshipcannon@175;
				Odin_3x3_Battleshipcannon_Surface@175;

				StealthHeatSink@50;
				StealthDrive@500;
				JN_175Fixed@1350;
				AMP_ArcMelee@100;
				AMP_ArcMeleeReskin@100;
				AMP_FlameThrower@55;
				AMP_CryoShotgun@60;
				Hexcannon@500;
				HakkeroBeam@400;
				HakkeroProjectile@400;
				HAS_Esper@625;
				MADAR@0;
				HAS_Vulcan@1000;

				SC_Coil_Cannon@450;
				NHI_PD_Turret@100;
				NHI_PD_Turret_Half@100;
				NHI_PD_Turret_Half_Slope_Top@100;
				NHI_PD_Turret_Half_Slope_Tip@100;
				NHI_PD_Turret_45_Slope@100;
				NHI_Light_Autocannon_Turret@100;
				NHI_Autocannon_Turret@250;
				NHI_Gatling_Laser_Turret@250;
				NHI_Light_Railgun_Turret@200;
				NHI_Heavy_Gun_Turret@300;
				NHI_Mk3_Cannon_Turret@650;
				NHI_Mk3_Cannon_Surface_Turret@650;
				NHI_Mk2_Cannon_Turret@350;
				NHI_Mk2_Cannon_Surface_Turret@350;
				NHI_Mk1_Cannon_Turret@200;
				NHI_Mk1_Cannon_Surface_Turret@200;
				NHI_Fixed_Autocannon@225;
				NHI_Fixed_Gatling_Laser@225;
				NHI_Kinetic_Cannon_Turret@300;

				DETPAK@1;
				DETPAK_3x1@1;
				DETPAK_1x1@1;
				CLB2X@500;
				SELtdLargeNanobotBuildAndRepairSystem@50;
				ERPPC@350;
				SC_COV_Plasma_Turret@300;
				banshee@300;
				TaiidanHangarHuge@1000;
				TaiidanHangar@750;
				TaiidanHangarCompact@500;
				NHI_Fixed_Missile_Battery@400;
				HakkeroProjectileMini@400;
				HakkeroBeamMini@400;
				banshee@500;
				SLAM@800;
				TaiidanRailFighter@700;
				TaiidanRailBomber@700;
				TaiidanHangarFighter@800; 
				TaiidanHangarBomber@800;
				TaiidanHangarBomberMedium@800;				
				TaiidanSingleHangar@100;

				MA_Guardian@700; 
				PM_LG_BLASTPLATE_BLASTPLATE@100; 

				381mmDualR@250;
                381mmDualNR@250;
                380mmMLE1935@400;
                15cmSKC28R@125;
                15cmSKC28NR@125;
                128mmL45@200;
                128mmSKC34@250;
                127mmMk12@175;
                127mmMk24@175;
                127mmMk32@250;
                127mmMk56@350;
                105mmTwin@100;
                PomPomMain@175;
                150mmCasemate@100;
                150mmCasemateTwin@125;
                BoforTwinRemodel@95;
                BoforSingleRemodel@75;
                QuadBofor@150;
                TorpTestBuidl@350;
                16InchTriple@400;
                15cmTbtsKC36T@100;
                15cmTbtsKC36@100;
                203mmTwin@165;
                203mmQuad@325;
                TorpBarbette@500;
                406alternate@400;
                Mk25Rangefinder@50;
                6InchTriple@200;

                Null_Point_Jump_Disruptor_Large@99999;
				LargeGatlingTurret_SC@125;
				LargeMissileTurret_SC@155;
				LargeBlockMediumCalibreTurret_SC@250;
				LargeCalibreTurret_SC@250;
				LargeRailgun_SC@165;
				LargeBlockLargeCalibreGun_SC@250;
				LargeMissileLauncher_SC@250;

				Starcore_RWR_Projectiles@5;
				NID_Pyroacid@300;
				NID_HeavyPyroacid@500;
				NID_Bioplasma@300;
				NID_Hivedrone@350;
				NID_BioplasmaHivedrone@400;
				NID_Leap@50;
				LightParticleWhip@200;
				ParticleWhip@400;
				NovaCannon@800;
				longsword@400;
				65_Launcher_FixedMount@350;
				Hellfire_Laser_Block@666;
				EventControllerLarge@5;
				EventControllerSmall@5;				
				LargeFlightMovement@5;
				LargeDefensiveCombat@5;
				LargeOffensiveCombat@5;
				LargeBasicMission@5;
				PathRecorderBlock@5;
				SmallFlightMovement@5;
				SmallDefensiveCombat@5;
				SmallOffensiveCombat@5;
				SmallBasicMission@5;
				SmallPathRecorderBlock@5;
				HAS_Cyclops@350;
				HAS_Crossfield@250;
				AMP_HealGenerator@400;
				CapacitorLarge@400;

				GoalieCasemate@250; 
				KreegMagnetarCannon@450; 
				Thagomizer@750; 
				Thagomizer_Flipped@750; 
				Thagomizer_Angled@750; 
				Thagomizer_Angled_Flipped@750; 
				SC_Radome@10; 
				APE_Strong@150; 
				Devastator_Torp@700; 
				Priest_Block@150; 
				PriestReskin_Block@150; 
				Fixed_Rockets@250; 
				Type18_Artillery@270; 
				Type21_Artillery@540; 
				Type24_Artillery@770; 
				Type19_Driver@350; 
				Type22_Driver@675; 
				Type25_Driver@1000; 
				Reaver_Coilgun@120; 
				Assault_Coil_Turret@120;
				Type17_BeamLance@6942069; 
				HeavyCarronade_5x5_Turret@400; 
				X4_7x7_HeavyTurret@300; 
				UnguidedRocketTurret@100; 
				DrunkRocketTurret@400; 
				DualSnubLaserTurret@150; 
				DualPulseLaserTurret@150; 
				HeavyLanceBattery@1000;
				HadeanPlasmaBlastgun@900; 
				VindicatorKineticLance@700; 
				HeavyFighterBay@300; 

				SI_Field_Gen@450;
				MA_Laser_Armor01@1;
				MA_Laser_Armor02@1;
				MA_Laser_Armor03@1;
				MA_Laser_Armor04@1;
				MA_Laser_Armor05@1;
				MA_Laser_Armor06@1;
				MA_Laser_Armor07@1;
				MA_Laser_Armor08@1;
				MA_Laser_Armor09@1;
				MA_Laser_Armor10@1;
				MA_Laser_Armor11@1;
				MA_Laser_Armor12@1;
				MA_Laser_Armor13@1;
				MA_Laser_Armor14@1;
				MA_Laser_Armor15@1;
				MA_Laser_Armor16@1;





            "));
        }
    }
}
