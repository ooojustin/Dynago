namespace /*rnd*/DynagoStub/*rnd*/ 
{

    using System;
    using System.Linq;
    using System.Net;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.IO;
    using System.Diagnostics;

    class Program
    {
        /*junk_method*/
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int var_Key);
        /*junk_method*/
        public static int
            /*rnd*/var_LocalPlayer/*rnd*/ = 0,
            /*rnd*/var_LocalPlayer_Team/*rnd*/  = 0,
            /*rnd*/var_LocalPlayer_Health/*rnd*/  = 0,
            /*rnd*/var_LocalPlayer_WeaponEntity/*rnd*/  = 0,
            /*rnd*/var_LocalPlayer_WeaponIndex/*rnd*/  = 0;
        public static bool
            /*rnd*/var_LocalPlayer_Alive/*rnd*/  = false;
        /*weapon_type_lists*/
        private static bool
            /*rnd*/var_LocalPlayer_HasPistol/*rnd*/ = false,
            /*rnd*/var_LocalPlayer_HasSniper/*rnd*/ = false;
        private static int[] /*rnd*/var_PistolList/*rnd*/ = { /*order-start*/
            /*order-*/1,/*order-*/ /*order-*/2,/*order-*/ /*order-*/3,/*order-*/ /*order-*/4,/*order-*/ /*order-*/30,/*order-*/ /*order-*/32,/*order-*/ /*order-*/36,/*order-*/ /*order-*/61,/*order-*/ /*order-*/63,/*order-*//*order-end*/ };
        private static int[] /*rnd*/var_SniperList/*rnd*/ = { /*order-start*//*order-*/9,/*order-*/ /*order-*/11,/*order-*/ /*order-*/38,/*order-*/ /*order-*/40,/*order-*//*order-end*/ };
        /*weapon_type_lists*/
        /*feature_aimbot*/
        /*order-start*/
        /*order-*/static int /*rnd*/var_AimbotGeneral_Key/*rnd*/ = /*setting_aimbot_general_key*/0/*setting_aimbot_general_key*/, /*rnd*/var_AimbotGeneral_Bone/*rnd*/ = /*setting_aimbot_general_bone*/0/*setting_aimbot_general_bone*/;/*order-*/
        /*order-*/static float /*rnd*/var_AimbotGeneral_FOV/*rnd*/ = /*setting_aimbot_general_fov*/0.1f/*setting_aimbot_general_fov*/, /*rnd*/var_AimbotGeneral_Smooth/*rnd*/ = /*setting_aimbot_general_smooth*/1.0f/*setting_aimbot_general_smooth*/;/*order-*/
        /*order-*/static bool /*rnd*/var_AimbotGeneral_RCS/*rnd*/ = /*setting_aimbot_general_rcs*/false/*setting_aimbot_general_rcs*/, /*rnd*/var_AimbotGeneral_Enemy/*rnd*/ = /*setting_aimbot_general_enemy*/false/*setting_aimbot_general_enemy*/, /*rnd*/var_AimbotGeneral_Team/*rnd*/ = /*setting_aimbot_general_team*/false/*setting_aimbot_general_team*/;/*order-*/
        /*order-*/static int /*rnd*/var_AimbotPistol_Key/*rnd*/ = /*setting_aimbot_pistols_key*/0/*setting_aimbot_pistols_key*/, /*rnd*/var_AimbotPistol_Bone/*rnd*/ = /*setting_aimbot_pistols_bone*/0/*setting_aimbot_pistols_bone*/;/*order-*/
        /*order-*/static float /*rnd*/var_AimbotPistol_FOV/*rnd*/ = /*setting_aimbot_pistols_fov*/0.1f/*setting_aimbot_pistols_fov*/, /*rnd*/var_AimbotPistol_Smooth/*rnd*/ = /*setting_aimbot_pistols_smooth*/1.0f/*setting_aimbot_pistols_smooth*/;/*order-*/
        /*order-*/static bool /*rnd*/var_AimbotPistol_RCS/*rnd*/ = /*setting_aimbot_pistols_rcs*/false/*setting_aimbot_pistols_rcs*/, /*rnd*/var_AimbotPistol_Enemy/*rnd*/ = /*setting_aimbot_pistols_enemy*/false/*setting_aimbot_pistols_enemy*/, /*rnd*/var_AimbotPistol_Team/*rnd*/ = /*setting_aimbot_pistols_team*/false/*setting_aimbot_pistols_team*/;/*order-*/
        /*order-*/static int /*rnd*/var_AimbotSniper_Key/*rnd*/ = /*setting_aimbot_snipers_key*/0/*setting_aimbot_snipers_key*/, /*rnd*/var_AimbotSniper_Bone/*rnd*/ = /*setting_aimbot_snipers_bone*/0/*setting_aimbot_snipers_bone*/;/*order-*/
        /*order-*/static float /*rnd*/var_AimbotSniper_FOV/*rnd*/ = /*setting_aimbot_snipers_fov*/0.1f/*setting_aimbot_snipers_fov*/, /*rnd*/var_AimbotSniper_Smooth/*rnd*/ = /*setting_aimbot_snipers_smooth*/1.0f/*setting_aimbot_snipers_smooth*/;/*order-*/
        /*order-*/static bool /*rnd*/var_AimbotSniper_RCS/*rnd*/ = /*setting_aimbot_snipers_rcs*/false/*setting_aimbot_snipers_rcs*/, /*rnd*/var_AimbotSniper_Enemy/*rnd*/ = /*setting_aimbot_snipers_enemy*/false/*setting_aimbot_snipers_enemy*/, /*rnd*/var_AimbotSniper_Team/*rnd*/ = /*setting_aimbot_snipers_team*/false/*setting_aimbot_snipers_team*/;/*order-*/
        /*order-end*/
        /*feature_aimbot*/
        /*feature_triggerbot*/
        /*order-start*/
        /*order-*/static int /*rnd*/var_TriggerbotGeneral_Key/*rnd*/ = /*setting_triggerbot_general_key*/0/*setting_triggerbot_general_key*/, /*rnd*/var_TriggerbotGeneral_Delay/*rnd*/ = /*setting_triggerbot_general_delay*/0/*setting_triggerbot_general_delay*/, /*rnd*/var_TriggerbotGeneral_Overshoot/*rnd*/ = /*setting_triggerbot_general_overshoot*/0/*setting_triggerbot_general_overshoot*/, /*rnd*/var_TriggerbotGeneral_MagnetBone/*rnd*/ = /*setting_triggerbot_general_magnetbone*/0/*setting_triggerbot_general_magnetbone*/;/*order-*/
        /*order-*/static bool /*rnd*/var_TriggerbotGeneral_Enemy/*rnd*/ = /*setting_triggerbot_general_enemy*/false/*setting_triggerbot_general_enemy*/, /*rnd*/var_TriggerbotGeneral_Team/*rnd*/ = /*setting_triggerbot_general_team*/false/*setting_triggerbot_general_team*/, /*rnd*/var_TriggerbotGeneral_Magnetic/*rnd*/ = /*setting_triggerbot_general_magnetic*/false/*setting_triggerbot_general_magnetic*/;/*order-*/
        /*order-*/static float /*rnd*/var_TriggerbotGeneral_MagnetFOV/*rnd*/ = /*setting_triggerbot_general_magnetfov*/0.1f/*setting_triggerbot_general_magnetfov*/, /*rnd*/var_TriggerbotGeneral_MagnetSmooth/*rnd*/ = /*setting_triggerbot_general_magnetsmooth*/1.0f/*setting_triggerbot_general_magnetsmooth*/;/*order-*/
        /*order-*/static int /*rnd*/var_TriggerbotPistol_Key/*rnd*/ = /*setting_triggerbot_pistols_key*/0/*setting_triggerbot_pistols_key*/, /*rnd*/var_TriggerbotPistol_Delay/*rnd*/ = /*setting_triggerbot_pistols_delay*/0/*setting_triggerbot_pistols_delay*/, /*rnd*/var_TriggerbotPistol_Overshoot/*rnd*/ = /*setting_triggerbot_pistols_overshoot*/0/*setting_triggerbot_pistols_overshoot*/, /*rnd*/var_TriggerbotPistol_MagnetBone/*rnd*/ = /*setting_triggerbot_pistols_magnetbone*/0/*setting_triggerbot_pistols_magnetbone*/;/*order-*/
        /*order-*/static bool /*rnd*/var_TriggerbotPistol_Enemy/*rnd*/ = /*setting_triggerbot_pistols_enemy*/false/*setting_triggerbot_pistols_enemy*/, /*rnd*/var_TriggerbotPistol_Team/*rnd*/ = /*setting_triggerbot_pistols_team*/false/*setting_triggerbot_pistols_team*/, /*rnd*/var_TriggerbotPistol_Magnetic/*rnd*/ = /*setting_triggerbot_pistols_magnetic*/false/*setting_triggerbot_pistols_magnetic*/;/*order-*/
        /*order-*/static float /*rnd*/var_TriggerbotPistol_MagnetFOV/*rnd*/ = /*setting_triggerbot_pistols_magnetfov*/0.1f/*setting_triggerbot_pistols_magnetfov*/, /*rnd*/var_TriggerbotPistol_MagnetSmooth/*rnd*/ = /*setting_triggerbot_pistols_magnetsmooth*/1.0f/*setting_triggerbot_pistols_magnetsmooth*/;/*order-*/
        /*order-*/static int /*rnd*/var_TriggerbotSniper_Key/*rnd*/ = /*setting_triggerbot_snipers_key*/0/*setting_triggerbot_snipers_key*/, /*rnd*/var_TriggerbotSniper_Delay/*rnd*/ = /*setting_triggerbot_snipers_delay*/0/*setting_triggerbot_snipers_delay*/, /*rnd*/var_TriggerbotSniper_Overshoot/*rnd*/ = /*setting_triggerbot_snipers_overshoot*/0/*setting_triggerbot_snipers_overshoot*/, /*rnd*/var_TriggerbotSniper_MagnetBone/*rnd*/ = /*setting_triggerbot_snipers_magnetbone*/0/*setting_triggerbot_snipers_magnetbone*/;/*order-*/
        /*order-*/static bool /*rnd*/var_TriggerbotSniper_Enemy/*rnd*/ = /*setting_triggerbot_snipers_enemy*/false/*setting_triggerbot_snipers_enemy*/, /*rnd*/var_TriggerbotSniper_Team/*rnd*/ = /*setting_triggerbot_snipers_team*/false/*setting_triggerbot_snipers_team*/, /*rnd*/var_TriggerbotSniper_Magnetic/*rnd*/ = /*setting_triggerbot_snipers_magnetic*/false/*setting_triggerbot_snipers_magnetic*/;/*order-*/
        /*order-*/static float /*rnd*/var_TriggerbotSniper_MagnetFOV/*rnd*/ = /*setting_triggerbot_snipers_magnetfov*/0.1f/*setting_triggerbot_snipers_magnetfov*/, /*rnd*/var_TriggerbotSniper_MagnetSmooth/*rnd*/ = /*setting_triggerbot_snipers_magnetsmooth*/1.0f/*setting_triggerbot_snipers_magnetsmooth*/;/*order-*/
        /*order-end*/
        /*feature_triggerbot*/
        /*junk_method*/
        static void Main(string[] args)
        {
            /*junk_line*/
            Console.Title = "/*setting_window_title*/-/*setting_window_title*/";
            /*junk_line*/
            Console.ForegroundColor = ConsoleColor.Cyan;
            /*junk_line*/
            Console.WriteLine("Welcome to Dynago!");
            /*junk_line*/
            Console.Write("Build Version: ");
            /*junk_line*/
            Console.ForegroundColor = ConsoleColor.Green;
            /*junk_line*/
            Console.Write("/*dynago_version*/-/*dynago_version*/\n");
            /*junk_line*/
            Console.ForegroundColor = ConsoleColor.Cyan;
            /*junk_line*/
            Console.Write("Generated by: ");
            /*junk_line*/
            Console.ForegroundColor = ConsoleColor.Green;
            /*junk_line*/
            Console.Write("/*dynago_user*/-/*dynago_user*/\n");
            /*junk_line*/
            Console.ForegroundColor = ConsoleColor.Yellow;
            /*junk_line*/
            Console.WriteLine("Searching for csgo...");
            /*junk_line*/
            System.Diagnostics.Process /*rnd*/var_CSGO/*rnd*/ = null;
            /*junk_line*/
            while (/*rnd*/var_CSGO/*rnd*/ == null) {
                /*junk_line*/
                /*rnd*/var_CSGO/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_InitializeCSGO/*rnd*/();
                Thread.Sleep(/*number*/500/*number*/);
            }
            /*junk_line*/
            Console.Beep(2000, 500);
            /*junk_line*/
            Console.ForegroundColor = ConsoleColor.Green;
            /*junk_line*/
            Console.WriteLine("CSGO Found!");
            /*junk_line*/
            new Thread(() => {
                /*junk_line*/
                while (true)
                {
                    /*rnd*/var_LocalPlayer/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/cl_Memory/*rnd*/./*rnd*/var_ClientAddress/*rnd*/  + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_LocalPlayer/*rnd*/);
                    /*rnd*/var_LocalPlayer_Team/*rnd*/  = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_Team/*rnd*/);
                    /*rnd*/var_LocalPlayer_Health/*rnd*/  = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_Health/*rnd*/);
                    /*rnd*/var_LocalPlayer_Alive/*rnd*/  = (/*rnd*/var_LocalPlayer_Team/*rnd*/  == /*number*/2/*number*/ || /*rnd*/var_LocalPlayer_Team/*rnd*/  == /*number*/3/*number*/) && 
                    /*rnd*/var_LocalPlayer_Health/*rnd*/  > 1 && /*rnd*/var_LocalPlayer_Health/*rnd*/  <= (/*number*/1337/*number*/);
                    int /*rnd*/var_ActiveWeapon/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ActiveWeapon/*rnd*/);
                    /*rnd*/var_LocalPlayer_WeaponEntity/*rnd*/  = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/cl_Memory/*rnd*/./*rnd*/var_ClientAddress/*rnd*/  + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_EntityList/*rnd*/ + ((/*rnd*/var_ActiveWeapon/*rnd*/ & 0xFFF) - 1) * 0x10);
                    /*rnd*/var_LocalPlayer_WeaponIndex/*rnd*/  = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_LocalPlayer_WeaponEntity/*rnd*/  + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ItemDefinitionIndex/*rnd*/);
                    /*weapon_type_lists*/
                    /*rnd*/var_LocalPlayer_HasPistol/*rnd*/ = /*rnd*/var_PistolList/*rnd*/.Contains(/*rnd*/var_LocalPlayer_WeaponIndex/*rnd*/);
                    /*rnd*/var_LocalPlayer_HasSniper/*rnd*/ = /*rnd*/var_SniperList/*rnd*/.Contains(/*rnd*/var_LocalPlayer_WeaponIndex/*rnd*/);
                    /*weapon_type_lists*/
                    Thread.Sleep(/*number*/100/*number*/);
                }
            }).Start();
            /*junk_line*/
            /*order-start*/
            /*order-*/
            /*feature_noflash*/
            new Thread(() =>
            {
                /*junk_line*/
                float /*rnd*/var_FlashMaxAlpha/*rnd*/  = /*setting_noflash_percent*/0/*setting_noflash_percent*/ * 2.55f;
                /*junk_line*/
                while (true)
                {
                    if (/*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_FlashMaxAlpha/*rnd*/ ) != /*rnd*/var_FlashMaxAlpha/*rnd*/ )
                        /*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<float>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_FlashMaxAlpha/*rnd*/ , /*rnd*/var_FlashMaxAlpha/*rnd*/ );
                    Thread.Sleep(/*number*/100/*number*/);
                }
            }).Start();
            /*feature_noflash*/
            /*order-*/
            /*junk_line*/
            /*order-*/
            /*feature_bhop*/
            new Thread(() => {
                /*junk_line*/
                while (true)
                {
                    if (/*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/cl_Memory/*rnd*/./*rnd*/var_ClientAddress/*rnd*/  + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ForceJump/*rnd*/) == 5)
                    {
                        while (GetAsyncKeyState(/*number*//*setting_bhop_key*/32/*setting_bhop_key*//*number*/) != 0)
                        {
                            int /*rnd*/var_LocalPlayer_Flags/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_Flags/*rnd*/);
                            if (/*rnd*/var_LocalPlayer_Flags/*rnd*/ == (/*number*/257/*number*/) || /*rnd*/var_LocalPlayer_Flags/*rnd*/ == (/*number*/263/*number*/))
                            {
                                /*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<int>(/*rnd*/cl_Memory/*rnd*/./*rnd*/var_ClientAddress/*rnd*/  + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ForceJump/*rnd*/, /*number*/5/*number*/);
                                Thread.Sleep(/*number*/10/*number*/);
                                /*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<int>(/*rnd*/cl_Memory/*rnd*/./*rnd*/var_ClientAddress/*rnd*/  + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ForceJump/*rnd*/, /*number*/4/*number*/);
                            }
                        }
                    }
                    Thread.Sleep(1);
                }
            }).Start();
            /*feature_bhop*/
            /*order-*/
            /*junk_line*/
            /*order-*/
            /*feature_triggerbot*/
            new Thread(() => {
                /*junk_line*/
                while (true)
                {
                    if (/*rnd*/var_LocalPlayer_HasPistol/*rnd*/ && /*rnd*/var_TriggerbotPistol_Key/*rnd*/ != -1 && GetAsyncKeyState(/*rnd*/var_TriggerbotPistol_Key/*rnd*/) == 0) goto /*rnd*/LABEL_Trigger_END/*rnd*/;
                    if (/*rnd*/var_LocalPlayer_HasSniper/*rnd*/ && /*rnd*/var_TriggerbotSniper_Key/*rnd*/ != -1 && GetAsyncKeyState(/*rnd*/var_TriggerbotSniper_Key/*rnd*/) == 0) goto /*rnd*/LABEL_Trigger_END/*rnd*/;
                    if (!/*rnd*/var_LocalPlayer_HasPistol/*rnd*/ && !/*rnd*/var_LocalPlayer_HasSniper/*rnd*/ && /*rnd*/var_TriggerbotGeneral_Key/*rnd*/ != -1 && GetAsyncKeyState(/*rnd*/var_TriggerbotGeneral_Key/*rnd*/) == 0) goto /*rnd*/LABEL_Trigger_END/*rnd*/;
                    if (!/*rnd*/var_LocalPlayer_Alive/*rnd*/ ) goto /*rnd*/LABEL_Trigger_END/*rnd*/ ;

                    if (/*rnd*/var_LocalPlayer_HasPistol/*rnd*/) /*rnd*/met_TriggerBot/*rnd*/(/*rnd*/var_TriggerbotPistol_Overshoot/*rnd*/, /*rnd*/var_TriggerbotPistol_Delay/*rnd*/, /*rnd*/var_TriggerbotPistol_Enemy/*rnd*/, /*rnd*/var_TriggerbotPistol_Team/*rnd*/, /*rnd*/var_TriggerbotPistol_Magnetic/*rnd*/, /*rnd*/var_TriggerbotPistol_MagnetBone/*rnd*/, /*rnd*/var_TriggerbotPistol_MagnetSmooth/*rnd*/, /*rnd*/var_TriggerbotPistol_MagnetFOV/*rnd*/);
                    else if (/*rnd*/var_LocalPlayer_HasSniper/*rnd*/)/*rnd*/met_TriggerBot/*rnd*/(/*rnd*/var_TriggerbotSniper_Overshoot/*rnd*/, /*rnd*/var_TriggerbotSniper_Delay/*rnd*/, /*rnd*/var_TriggerbotSniper_Enemy/*rnd*/, /*rnd*/var_TriggerbotSniper_Team/*rnd*/, /*rnd*/var_TriggerbotSniper_Magnetic/*rnd*/, /*rnd*/var_TriggerbotSniper_MagnetBone/*rnd*/, /*rnd*/var_TriggerbotSniper_MagnetSmooth/*rnd*/, /*rnd*/var_TriggerbotSniper_MagnetFOV/*rnd*/);
                    else /*rnd*/met_TriggerBot/*rnd*/(/*rnd*/var_TriggerbotGeneral_Overshoot/*rnd*/, /*rnd*/var_TriggerbotGeneral_Delay/*rnd*/, /*rnd*/var_TriggerbotGeneral_Enemy/*rnd*/, /*rnd*/var_TriggerbotGeneral_Team/*rnd*/, /*rnd*/var_TriggerbotGeneral_Magnetic/*rnd*/, /*rnd*/var_TriggerbotGeneral_MagnetBone/*rnd*/, /*rnd*/var_TriggerbotGeneral_MagnetSmooth/*rnd*/, /*rnd*/var_TriggerbotGeneral_MagnetFOV/*rnd*/);

                    /*rnd*/LABEL_Trigger_END/*rnd*/ : 
                    /*feature_triggerbot_delay*/Thread.Sleep(/*number*//*setting_trigger_thread_delay*/0/*setting_trigger_thread_delay*//*number*/);/*feature_triggerbot_delay*/
                    continue;
                }
            }).Start();
            /*feature_triggerbot*/
            /*order-*/
            /*junk_line*/
            /*order-*/
            /*feature_visuals*/
            new Thread(() =>
            {
                /*junk_line*/
                while (true)
                {
                    int /*rnd*/var_GlowObject/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>((int)/*rnd*/cl_Memory/*rnd*/./*rnd*/var_ClientAddress/*rnd*/  + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_GlowObject/*rnd*/);
                    for (int i = 0; i < 64; i++)
                    {
                        int /*rnd*/var_DetectedPlayerV/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/cl_Memory/*rnd*/./*rnd*/var_ClientAddress/*rnd*/  + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_EntityList/*rnd*/ + i * 0x10);
                        if (/*rnd*/var_DetectedPlayerV/*rnd*/ == 0) continue;
                        if (/*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<bool>(/*rnd*/var_DetectedPlayerV/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_Dormant/*rnd*/)) continue;
                        int /*rnd*/var_DetectedPlayerV_Team/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerV/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_Team/*rnd*/);
                        int /*rnd*/var_GlowIndex/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerV/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_GlowIndex/*rnd*/);
                        int /*rnd*/var_GlowEntityBase/*rnd*/ = /*rnd*/var_GlowIndex/*rnd*/ * (/*number*/56/*number*/) + /*rnd*/var_GlowObject/*rnd*/;
                        /*order-start*/
                        /*order-*//*feature_visuals_enemy*/
                        if (/*rnd*/var_DetectedPlayerV_Team/*rnd*/ != /*rnd*/var_LocalPlayer_Team/*rnd*/ )
                        {
                            int[] /*rnd*/var_ESPColor/*rnd*/ = new int[] { /*setting_visuals_enemy_color_r*/255/*setting_visuals_enemy_color_r*/, /*setting_visuals_enemy_color_g*/0/*setting_visuals_enemy_color_g*/, /*setting_visuals_enemy_color_b*/0/*setting_visuals_enemy_color_b*/,  /*setting_visuals_enemy_alpha*/175/*setting_visuals_enemy_alpha*/};
                            /*feature_enemy_healthbased*/
                            int /*rnd*/var_Health/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerV/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_Health/*rnd*/);
                            /*rnd*/var_ESPColor/*rnd*/ = /*rnd*/met_ColorFromHealth/*rnd*/(/*rnd*/var_Health/*rnd*/);
                            /*rnd*/var_ESPColor/*rnd*/[3] = /*setting_visuals_enemy_alpha*/175/*setting_visuals_enemy_alpha*/;
                            /*feature_enemy_healthbased*/
                            /*order-start*/
                            /*feature_visuals_enemy_chams_enabled*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerV/*rnd*/ + /*number*/112/*number*/, /*rnd*/var_ESPColor/*rnd*/[0]);/*order-*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerV/*rnd*/ + /*number*/113/*number*/, /*rnd*/var_ESPColor/*rnd*/[1]);/*order-*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerV/*rnd*/ + /*number*/114/*number*/, /*rnd*/var_ESPColor/*rnd*/[2]);/*order-*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerV/*rnd*/ + /*number*/115/*number*/, /*number*/255/*number*/);/*order-*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<bool>(/*rnd*/var_GlowEntityBase/*rnd*/ + (/*number*/44/*number*/), true);/*order-*/
                            /*feature_visuals_enemy_chams_enabled*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<float>(/*rnd*/var_GlowEntityBase/*rnd*/ + (/*number*/4/*number*/), /*rnd*/var_ESPColor/*rnd*/[0] / 255.0f);/*order-*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<float>(/*rnd*/var_GlowEntityBase/*rnd*/ + (/*number*/8/*number*/), /*rnd*/var_ESPColor/*rnd*/[1] / 255.0f);/*order-*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<float>(/*rnd*/var_GlowEntityBase/*rnd*/ + (/*number*/12/*number*/), /*rnd*/var_ESPColor/*rnd*/[2] / 255.0f);/*order-*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<float>(/*rnd*/var_GlowEntityBase/*rnd*/ + (/*number*/16/*number*/), /*rnd*/var_ESPColor/*rnd*/[3] / 255.0f);/*order-*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<bool>(/*rnd*/var_GlowEntityBase/*rnd*/ + (/*number*/36/*number*/), true);/*order-*/
                            /*feature_visuals_enemy_chams_disabled*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<bool>(/*rnd*/var_GlowEntityBase/*rnd*/ + (/*number*/37/*number*/), false);/*order-*/
                            /*feature_visuals_enemy_chams_disabled*/
                            /*order-end*/
                        }
                        /*feature_visuals_enemy*//*order-*/
                        /*order-*//*feature_visuals_teammate*/
                        if (/*rnd*/var_DetectedPlayerV_Team/*rnd*/ == /*rnd*/var_LocalPlayer_Team/*rnd*/ )
                        {
                            int[] /*rnd*/var_ESPColor/*rnd*/ = new int[] { /*setting_visuals_teammate_color_r*/255/*setting_visuals_teammate_color_r*/, /*setting_visuals_teammate_color_g*/0/*setting_visuals_teammate_color_g*/, /*setting_visuals_teammate_color_b*/0/*setting_visuals_teammate_color_b*/,  /*setting_visuals_teammate_alpha*/175/*setting_visuals_teammate_alpha*/};
                            /*feature_teammate_healthbased*/
                            int /*rnd*/var_Health/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerV/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_Health/*rnd*/);
                            /*rnd*/var_ESPColor/*rnd*/ = /*rnd*/met_ColorFromHealth/*rnd*/(/*rnd*/var_Health/*rnd*/);
                            /*rnd*/var_ESPColor/*rnd*/[3] = /*setting_visuals_teammate_alpha*/175/*setting_visuals_teammate_alpha*/;
                            /*feature_teammate_healthbased*/
                            /*order-start*/
                            /*feature_visuals_teammate_chams_enabled*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerV/*rnd*/ + /*number*/112/*number*/, /*rnd*/var_ESPColor/*rnd*/[0]);/*order-*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerV/*rnd*/ + /*number*/113/*number*/, /*rnd*/var_ESPColor/*rnd*/[1]);/*order-*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerV/*rnd*/ + /*number*/114/*number*/, /*rnd*/var_ESPColor/*rnd*/[2]);/*order-*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerV/*rnd*/ + /*number*/115/*number*/, /*number*/255/*number*/);/*order-*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<bool>(/*rnd*/var_GlowEntityBase/*rnd*/ + (/*number*/44/*number*/), true);/*order-*/
                            /*feature_visuals_teammate_chams_enabled*/
                            /*order-end*/
                            /*order-start*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<float>(/*rnd*/var_GlowEntityBase/*rnd*/ + (/*number*/4/*number*/), /*rnd*/var_ESPColor/*rnd*/[0] / 255.0f);/*order-*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<float>(/*rnd*/var_GlowEntityBase/*rnd*/ + (/*number*/8/*number*/), /*rnd*/var_ESPColor/*rnd*/[1] / 255.0f);/*order-*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<float>(/*rnd*/var_GlowEntityBase/*rnd*/ + (/*number*/12/*number*/), /*rnd*/var_ESPColor/*rnd*/[2] / 255.0f);/*order-*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<float>(/*rnd*/var_GlowEntityBase/*rnd*/ + (/*number*/16/*number*/), /*rnd*/var_ESPColor/*rnd*/[3] / 255.0f);/*order-*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<bool>(/*rnd*/var_GlowEntityBase/*rnd*/ + (/*number*/36/*number*/), true);/*order-*/
                            /*feature_visuals_teammate_chams_disabled*/
                            /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<bool>(/*rnd*/var_GlowEntityBase/*rnd*/ + (/*number*/37/*number*/), false);/*order-*/
                            /*feature_visuals_teammate_chams_disabled*/
                            /*order-end*/
                        }
                        /*feature_visuals_teammate*//*order-*/
                        /*order-end*/
                    }
                    /*feature_visuals_thread_delay*/
                    Thread.Sleep(/*number*//*setting_visuals_thread_delay*/1/*setting_visuals_thread_delay*//*number*/);
                    /*feature_visuals_thread_delay*/
                }
            }).Start();
            /*feature_visuals*/
            /*order-*/
            /*junk_line*/
            /*order-*/
            /*feature_rcs*/
            new Thread(() =>
            {
                float
                    /*rnd*/var_OldAimPunch_X/*rnd*/ = 0,
                    /*rnd*/var_OldAimPunch_Y/*rnd*/ = 0;
                while (true)
                {
                    if (GetAsyncKeyState(1) != 0 && /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ShotsFired/*rnd*/) > 1)
                    {
                        int /*rnd*/var_ClientState/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/cl_Memory/*rnd*/./*rnd*/var_EngineAddress/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ClientState/*rnd*/);
                        /*order-start*/
                        /*order-*/float /*rnd*/var_ViewAngle_X/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_ClientState/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ViewAngles/*rnd*/);/*order-*/
                        /*order-*/float /*rnd*/var_ViewAngle_Y/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_ClientState/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ViewAngles/*rnd*/ + (/*number*/4/*number*/));/*order-*/
                        /*order-*/float /*rnd*/var_AimPunch_X/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_AimPunch/*rnd*/);/*order-*/
                        /*order-*/float /*rnd*/var_AimPunch_Y/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_AimPunch/*rnd*/ + (/*number*/4/*number*/));/*order-*/
                        /*order-end*/
                        /*order-start*/
                        /*order-*/float /*rnd*/var_FinalX/*rnd*/ = /*rnd*/var_ViewAngle_X/*rnd*/ - (/*rnd*/var_AimPunch_X/*rnd*/ - /*rnd*/var_OldAimPunch_X/*rnd*/) * /*setting_rcs_scale_x*/2.0f/*setting_rcs_scale_x*/;/*order-*/
                        /*order-*/float /*rnd*/var_FinalY/*rnd*/ = /*rnd*/var_ViewAngle_Y/*rnd*/ - (/*rnd*/var_AimPunch_Y/*rnd*/ - /*rnd*/var_OldAimPunch_Y/*rnd*/) * /*setting_rcs_scale_y*/2.0f/*setting_rcs_scale_y*/;/*order-*/
                        /*order-end*/
                        /*order-start*/
                        /*order-*/
                        if (/*rnd*/var_FinalX/*rnd*/ > 89.0f) /*rnd*/var_FinalX/*rnd*/ = 89.0f;
                        else if (/*rnd*/var_FinalX/*rnd*/ < -89.0f) /*rnd*/var_FinalX/*rnd*/ = -89.0f;
                        /*order-*//*order-*/
                        if (/*rnd*/var_FinalY/*rnd*/ > 180.0f) /*rnd*/var_FinalY/*rnd*/ = 180.0f;
                        else if (/*rnd*/var_FinalY/*rnd*/ < -180.0f) /*rnd*/var_FinalY/*rnd*/ = -180.0f;
                        /*order-*/
                        /*order-end*/
                        /*order-start*/
                        /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<float>(/*rnd*/var_ClientState/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ViewAngles/*rnd*/, /*rnd*/var_FinalX/*rnd*/);/*order-*/
                        /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<float>(/*rnd*/var_ClientState/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ViewAngles/*rnd*/ + (/*number*/4/*number*/), /*rnd*/var_FinalY/*rnd*/);/*order-*/
                        /*order-end*/
                        /*order-start*/
                        /*order-*//*rnd*/var_OldAimPunch_X/*rnd*/ = /*rnd*/var_AimPunch_X/*rnd*/;/*order-*/
                        /*order-*//*rnd*/var_OldAimPunch_Y/*rnd*/ = /*rnd*/var_AimPunch_Y/*rnd*/;/*order-*/
                        /*order-end*/
                    }
                    else
                    {
                        /*rnd*/var_OldAimPunch_X/*rnd*/ = 0;
                        /*rnd*/var_OldAimPunch_Y/*rnd*/ = 0;
                    }
                    Thread.Sleep(1);
                }
            }).Start();
            /*feature_rcs*/
            /*order-*/
            /*junk_line*/
            /*order-*/
            /*feature_aimbot*/
            new Thread(() => {
                while (true) {
                    /*rnd*/LABEL_Aimbot_START/*rnd*/:
                    if (/*rnd*/var_LocalPlayer_HasPistol/*rnd*/ && /*rnd*/var_AimbotPistol_Key/*rnd*/ != -1 && GetAsyncKeyState(/*rnd*/var_AimbotPistol_Key/*rnd*/) == 0) goto /*rnd*/LABEL_Aimbot_END/*rnd*/;
                    if (/*rnd*/var_LocalPlayer_HasSniper/*rnd*/ && /*rnd*/var_AimbotSniper_Key/*rnd*/ != -1 && GetAsyncKeyState(/*rnd*/var_AimbotSniper_Key/*rnd*/) == 0) goto /*rnd*/LABEL_Aimbot_END/*rnd*/;
                    if (!/*rnd*/var_LocalPlayer_HasPistol/*rnd*/ && !/*rnd*/var_LocalPlayer_HasSniper/*rnd*/ && /*rnd*/var_AimbotGeneral_Key/*rnd*/ != -1 && GetAsyncKeyState(/*rnd*/var_AimbotGeneral_Key/*rnd*/) == 0) goto /*rnd*/LABEL_Aimbot_END/*rnd*/;
                    bool /*rnd*/var_Result/*rnd*/ = false;
                    if (/*rnd*/var_LocalPlayer_HasPistol/*rnd*/) /*rnd*/var_Result/*rnd*/ = /*rnd*/met_AimAtBest/*rnd*/(/*rnd*/var_AimbotPistol_Bone/*rnd*/, /*rnd*/var_AimbotPistol_FOV/*rnd*/, /*rnd*/var_AimbotPistol_Smooth/*rnd*/, /*rnd*/var_AimbotPistol_RCS/*rnd*/, /*rnd*/var_AimbotPistol_Enemy/*rnd*/, /*rnd*/var_AimbotPistol_Team/*rnd*/);
                    else if (/*rnd*/var_LocalPlayer_HasSniper/*rnd*/) /*rnd*/var_Result/*rnd*/ = /*rnd*/met_AimAtBest/*rnd*/(/*rnd*/var_AimbotSniper_Bone/*rnd*/, /*rnd*/var_AimbotSniper_FOV/*rnd*/, /*rnd*/var_AimbotSniper_Smooth/*rnd*/, /*rnd*/var_AimbotSniper_RCS/*rnd*/, /*rnd*/var_AimbotSniper_Enemy/*rnd*/, /*rnd*/var_AimbotSniper_Team/*rnd*/);
                    else /*rnd*/var_Result/*rnd*/ = /*rnd*/met_AimAtBest/*rnd*/(/*rnd*/var_AimbotGeneral_Bone/*rnd*/, /*rnd*/var_AimbotGeneral_FOV/*rnd*/, /*rnd*/var_AimbotGeneral_Smooth/*rnd*/, /*rnd*/var_AimbotGeneral_RCS/*rnd*/, /*rnd*/var_AimbotGeneral_Enemy/*rnd*/, /*rnd*/var_AimbotGeneral_Team/*rnd*/);
                    if (/*rnd*/var_Result/*rnd*/)
                    goto /*rnd*/LABEL_Aimbot_START/*rnd*/;
                    else goto /*rnd*/LABEL_Aimbot_END/*rnd*/;
                    /*rnd*/LABEL_Aimbot_END/*rnd*/: Thread.Sleep(/*number*//*setting_aimbot_thread_delay*/10/*setting_aimbot_thread_delay*//*number*/);
                }
            }).Start();
            /*feature_aimbot*/
            /*order-*/
            /*junk_line*/
            /*order-*/
            /*feature_radar*/
            new Thread(() => {
                while (true) {
                    for (int i = 0; i < 64; i++) {
                        int /*rnd*/var_DetectedPlayerR/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/cl_Memory/*rnd*/./*rnd*/var_ClientAddress/*rnd*/  + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_EntityList/*rnd*/ + i * 0x10);
                        if (/*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerR/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_Spotted/*rnd*/) == 0) {
                            if (/*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<bool>(/*rnd*/var_DetectedPlayerR/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_Dormant/*rnd*/)) continue;
                            if (/*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerR/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_Health/*rnd*/) <= 0) continue;
                            /*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerR/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_Spotted/*rnd*/, 1);
                        }
                    }
                    Thread.Sleep(/*number*/100/*number*/);
                }
            }).Start();
            /*feature_radar*/
            /*order-*/
            /*junk_line*/
            /*order-*/
            /*feature_fov_changer*/
            new Thread(() => {
                while (true) {
                    int /*rnd*/var_IsScoped/*rnd*/  = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_IsScoped/*rnd*/);
                    int /*rnd*/var_ZoomLevel/*rnd*/  = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_LocalPlayer_WeaponEntity/*rnd*/  + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ZoomLevel/*rnd*/);
                    int /*rnd*/var_SetFOV/*rnd*/  = 0;
                    if (/*rnd*/var_ZoomLevel/*rnd*/  == 2 && /*rnd*/var_IsScoped/*rnd*/  == 1)
                        /*rnd*/var_SetFOV/*rnd*/  = 10;
                    else if ((/*rnd*/var_ZoomLevel/*rnd*/  == 1) && (/*rnd*/var_IsScoped/*rnd*/  == 1))
                        /*rnd*/var_SetFOV/*rnd*/  = 40;
                    else
                        /*rnd*/var_SetFOV/*rnd*/  = /*setting_custom_fov*/110/*setting_custom_fov*/;
                    /*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<int>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_FOV/*rnd*/, /*rnd*/var_SetFOV/*rnd*/ );
                    Thread.Sleep(1);
                }
            }).Start();
            /*feature_fov_changer*/
            /*order-*/
            /*junk_line*/
            /*order-*/
            /*feature_skinchanger*/
            new Thread(() => {
                /*junk_line*/
                using (WebClient /*rnd*/var_Web/*rnd*/ = new WebClient()) {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Injecting Skin Changer feature...");
                    try {
                    /*junk_line*/
                    /*order-start*/
                    /*order-*/string /*rnd*/var_dllPath/*rnd*/ = Path.GetTempFileName();/*order-*/
                    /*junk_line*/
                    /*order-*/string /*rnd*/var_exePath/*rnd*/ = Path.GetTempFileName() + ".exe";/*order-*/
                    /*junk_line*/
                    /*order-*/string /*rnd*/var_batPath/*rnd*/ = "/*setting_skinchanger_bat*/-/*setting_skinchanger_bat*/";/*order-*/
                    /*junk_line*/
                    /*order-end*/
                    /*order-start*/
                    /*order-*/
                    /*rnd*/var_Web/*rnd*/.Headers.Add("user-agent", "Dynago");
                    /*rnd*/var_Web/*rnd*/.DownloadFile("/*setting_skinchanger_download*/-/*setting_skinchanger_download*/", /*rnd*/var_dllPath/*rnd*/);
                    /*order-*/
                    /*junk_line*/
                    /*junk_line*/
                    /*order-*/
                    /*rnd*/var_Web/*rnd*/.Headers.Add("user-agent", "Dynago");
                    /*rnd*/var_Web/*rnd*/.DownloadFile("/*setting_injector_download*/-/*setting_injector_download*/", /*rnd*/var_exePath/*rnd*/);
                    /*order-*/
                    /*order-end*/
                    /*junk_line*/
                    string /*rnd*/var_Command/*rnd*/ = "\"" + /*rnd*/var_exePath/*rnd*/ + "\" manual-mapping csgo \"" + /*rnd*/var_dllPath/*rnd*/ + "\"";
                    /*junk_line*/
                    File.WriteAllText(/*rnd*/var_batPath/*rnd*/, /*rnd*/var_Command/*rnd*/);
                    ProcessStartInfo /*rnd*/var_StartInfo/*rnd*/ = new ProcessStartInfo();
                    /*junk_line*/
                    /*rnd*/var_StartInfo/*rnd*/.FileName = /*rnd*/var_batPath/*rnd*/;
                    /*junk_line*/
                    /*rnd*/var_StartInfo/*rnd*/.UseShellExecute = false;
                    /*junk_line*/
                    /*rnd*/var_StartInfo/*rnd*/.RedirectStandardOutput = true;
                    /*junk_line*/
                    /*rnd*/var_StartInfo/*rnd*/.WindowStyle = ProcessWindowStyle.Hidden;
                    Process /*rnd*/var_Injection/*rnd*/ = Process.Start(/*rnd*/var_StartInfo/*rnd*/);
                    /*rnd*/var_Injection/*rnd*/.WaitForExit();
                    /*order-start*/
                    /*order-*/File.Delete(/*rnd*/var_dllPath/*rnd*/);/*order-*/
                    /*junk_line*/
                    /*order-*/File.Delete(/*rnd*/var_exePath/*rnd*/);/*order-*/
                    /*junk_line*/
                    /*order-*/File.Delete(/*rnd*/var_batPath/*rnd*/);/*order-*/
                    /*junk_line*/
                    /*order-*/File.Delete(/*rnd*/var_exePath/*rnd*/.Substring(0, /*rnd*/var_exePath/*rnd*/.Length - 4));/*order-*/
                    /*order-end*/
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Skin Changer injected successfully.");
                    /*junk_line*/
                    } catch (Exception) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Failed to inject Skin Changer.");
                    } 
                    /*junk_line*/
                }
                /*junk_line*/
            }).Start();
            /*feature_skinchanger*/
            /*order-*/
            /*order-end*/
            /*junk_line*/
        }
        /*junk_method*/
        /*feature_aimbot/magnet*/
        private static bool /*rnd*/met_AimAtBest/*rnd*/(int /*rnd*/var_Bone/*rnd*/, float /*rnd*/var_FOV/*rnd*/, float /*rnd*/var_Smooth/*rnd*/, bool /*rnd*/var_RCS/*rnd*/, bool /*rnd*/var_Enemies/*rnd*/, bool /*rnd*/var_Teammates/*rnd*/) {
            int /*rnd*/var_ClientState/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/cl_Memory/*rnd*/./*rnd*/var_EngineAddress/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ClientState/*rnd*/);
            /*order-start*/
            /*order-*//*rnd*/cl_AimbotMath/*rnd*/./*rnd*/str_Vector3/*rnd*/  /*rnd*/var_EyePosition/*rnd*/ = new /*rnd*/cl_AimbotMath/*rnd*/./*rnd*/str_Vector3/*rnd*/ ();/*order-*/
            /*order-*//*rnd*/cl_AimbotMath/*rnd*/./*rnd*/str_Vector3/*rnd*/  /*rnd*/var_ViewAngles/*rnd*/ = new /*rnd*/cl_AimbotMath/*rnd*/./*rnd*/str_Vector3/*rnd*/ ();/*order-*/
            /*order-*//*rnd*/cl_AimbotMath/*rnd*/./*rnd*/str_Vector3/*rnd*/  /*rnd*/var_LocalPlayerPosition/*rnd*/ = new /*rnd*/cl_AimbotMath/*rnd*/./*rnd*/str_Vector3/*rnd*/ ();/*order-*/
            /*order-end*/
            /*order-start*/
            /*order-*//*rnd*/var_EyePosition/*rnd*/./*rnd*/var_Xc/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_VectorView/*rnd*/) + /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_VectorOrigin/*rnd*/);/*order-*/
            /*order-*//*rnd*/var_EyePosition/*rnd*/./*rnd*/var_Yc/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_VectorView/*rnd*/ + (/*number*/4/*number*/)) + /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_VectorOrigin/*rnd*/ + (/*number*/4/*number*/));/*order-*/
            /*order-*//*rnd*/var_EyePosition/*rnd*/./*rnd*/var_Zc/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_VectorView/*rnd*/ + (/*number*/8/*number*/)) + /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_VectorOrigin/*rnd*/ + (/*number*/8/*number*/));/*order-*/
            /*order-*//*rnd*/var_ViewAngles/*rnd*/./*rnd*/var_Xc/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_ClientState/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ViewAngles/*rnd*/);/*order-*/
            /*order-*//*rnd*/var_ViewAngles/*rnd*/./*rnd*/var_Yc/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_ClientState/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ViewAngles/*rnd*/ + (/*number*/4/*number*/));/*order-*/
            /*order-*//*rnd*/var_ViewAngles/*rnd*/./*rnd*/var_Zc/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_ClientState/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ViewAngles/*rnd*/ + (/*number*/8/*number*/));/*order-*/
            /*order-*//*rnd*/var_LocalPlayerPosition/*rnd*/./*rnd*/var_Xc/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_VectorOrigin/*rnd*/);/*order-*/
            /*order-*//*rnd*/var_LocalPlayerPosition/*rnd*/./*rnd*/var_Yc/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_VectorOrigin/*rnd*/ + (/*number*/4/*number*/));/*order-*/
            /*order-*//*rnd*/var_LocalPlayerPosition/*rnd*/./*rnd*/var_Zc/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_VectorOrigin/*rnd*/ + (/*number*/8/*number*/));/*order-*/
            /*order-end*/
            for (int /*rnd*/var_Index/*rnd*/ = 0; /*rnd*/var_Index/*rnd*/ < 64; /*rnd*/var_Index/*rnd*/++) {
                int /*rnd*/var_DetectedPlayerA/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/cl_Memory/*rnd*/./*rnd*/var_ClientAddress/*rnd*/  + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_EntityList/*rnd*/ + /*rnd*/var_Index/*rnd*/ * 0x10);
                if (/*rnd*/var_DetectedPlayerA/*rnd*/ == /*rnd*/var_LocalPlayer/*rnd*/) continue;
                if (/*rnd*/var_DetectedPlayerA/*rnd*/ == 0) continue;
                if (/*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<bool>(/*rnd*/var_DetectedPlayerA/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_Dormant/*rnd*/)) continue;
                int /*rnd*/var_DetectedPlayerA_Team/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerA/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_Team/*rnd*/);
                int /*rnd*/var_DetectedPlayerA_Health/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerA/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_Health/*rnd*/);
                bool /*rnd*/var_IsAlive/*rnd*/ = /*rnd*/var_DetectedPlayerA_Health/*rnd*/ > 0;
                bool /*rnd*/var_IsTarget/*rnd*/ = false;
                /*order-start*/
                /*order-*/if (/*rnd*/var_DetectedPlayerA_Team/*rnd*/ != /*rnd*/var_LocalPlayer_Team/*rnd*/ && /*rnd*/var_Enemies/*rnd*/) /*rnd*/var_IsTarget/*rnd*/ = true;/*order-*/
                /*order-*/if (/*rnd*/var_DetectedPlayerA_Team/*rnd*/ == /*rnd*/var_LocalPlayer_Team/*rnd*/ && /*rnd*/var_Teammates/*rnd*/) /*rnd*/var_IsTarget/*rnd*/ = true;/*order-*/
                /*order-end*/
                if (/*rnd*/var_DetectedPlayerA_Team/*rnd*/ <= 1) continue;
                bool /*rnd*/var_IsSpotted/*rnd*/ = (/*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<bool>(/*rnd*/var_DetectedPlayerA/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_Spotted/*rnd*/));
                if (/*rnd*/var_IsTarget/*rnd*/ && /*rnd*/var_IsSpotted/*rnd*/ && /*rnd*/var_IsAlive/*rnd*/) {
                    /*rnd*/cl_AimbotMath/*rnd*/./*rnd*/str_Vector3/*rnd*/  /*rnd*/var_EnemyBone/*rnd*/ = /*rnd*/cl_AimbotMath/*rnd*/./*rnd*/met_GetBonePos/*rnd*/(/*rnd*/var_DetectedPlayerA/*rnd*/, /*rnd*/var_Bone/*rnd*/);
                    /*rnd*/cl_AimbotMath/*rnd*/./*rnd*/str_Vector3/*rnd*/  /*rnd*/var_Destination/*rnd*/ = /*rnd*/cl_AimbotMath/*rnd*/./*rnd*/met_CalculateAngle/*rnd*/(/*rnd*/var_EyePosition/*rnd*/, /*rnd*/var_EnemyBone/*rnd*/, /*rnd*/var_RCS/*rnd*/);
                    /*rnd*/cl_AimbotMath/*rnd*/./*rnd*/str_Vector3/*rnd*/  /*rnd*/var_EnemyPosition/*rnd*/ = new /*rnd*/cl_AimbotMath/*rnd*/./*rnd*/str_Vector3/*rnd*/();
                    /*order-start*/
                    /*order-*//*rnd*/var_EnemyPosition/*rnd*/./*rnd*/var_Xc/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_DetectedPlayerA/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_VectorOrigin/*rnd*/);/*order-*/
                    /*order-*//*rnd*/var_EnemyPosition/*rnd*/./*rnd*/var_Yc/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_DetectedPlayerA/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_VectorOrigin/*rnd*/ + (/*number*/4/*number*/));/*order-*/
                    /*order-*//*rnd*/var_EnemyPosition/*rnd*/./*rnd*/var_Zc/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_DetectedPlayerA/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_VectorOrigin/*rnd*/ + (/*number*/8/*number*/));/*order-*/
                    /*order-end*/
                    float /*rnd*/var_PlayerFOV/*rnd*/ = /*rnd*/cl_AimbotMath/*rnd*/./*rnd*/met_CalculateFOV/*rnd*/(/*rnd*/var_ViewAngles/*rnd*/, /*rnd*/var_Destination/*rnd*/, /*rnd*/cl_AimbotMath/*rnd*/.met_VectorDistance(/*rnd*/var_LocalPlayerPosition/*rnd*/, /*rnd*/var_EnemyPosition/*rnd*/) / 10.0f);
                    if (/*rnd*/var_PlayerFOV/*rnd*/ <= /*rnd*/var_FOV/*rnd*/) {
                        /*rnd*/cl_AimbotMath/*rnd*/./*rnd*/str_Vector3/*rnd*/ /*rnd*/var_ToNormalize/*rnd*/ = new /*rnd*/cl_AimbotMath/*rnd*/./*rnd*/str_Vector3/*rnd*/ ();
                        /*order-start*/
                        /*order-*//*rnd*/var_ToNormalize/*rnd*/./*rnd*/var_Xc/*rnd*/ = /*rnd*/var_ViewAngles/*rnd*/./*rnd*/var_Xc/*rnd*/ - /*rnd*/var_Destination/*rnd*/./*rnd*/var_Xc/*rnd*/;/*order-*/
                        /*order-*//*rnd*/var_ToNormalize/*rnd*/./*rnd*/var_Yc/*rnd*/ = /*rnd*/var_ViewAngles/*rnd*/./*rnd*/var_Yc/*rnd*/ - /*rnd*/var_Destination/*rnd*/./*rnd*/var_Yc/*rnd*/;/*order-*/
                        /*order-end*/
                        /*rnd*/cl_AimbotMath/*rnd*/./*rnd*/str_Vector3/*rnd*/  /*rnd*/var_DeltaView/*rnd*/ = /*rnd*/cl_AimbotMath/*rnd*/./*rnd*/met_NormalizeDelta/*rnd*/(/*rnd*/var_ToNormalize/*rnd*/);
                        /*order-start*/
                        /*order-*/float /*rnd*/var_FinalX/*rnd*/ = /*rnd*/var_ViewAngles/*rnd*/./*rnd*/var_Xc/*rnd*/ - (/*rnd*/var_DeltaView/*rnd*/./*rnd*/var_Xc/*rnd*/ / /*rnd*/var_Smooth/*rnd*/);/*order-*/
                        /*order-*/float /*rnd*/var_FinalY/*rnd*/ = /*rnd*/var_ViewAngles/*rnd*/./*rnd*/var_Yc/*rnd*/ - (/*rnd*/var_DeltaView/*rnd*/./*rnd*/var_Yc/*rnd*/ / /*rnd*/var_Smooth/*rnd*/);/*order-*/
                        /*order-end*/
                        /*order-start*/
                        /*order-*/
                        if (/*rnd*/var_FinalX/*rnd*/ > 89.0f) /*rnd*/var_FinalX/*rnd*/ = 89.0f;
                        else if (/*rnd*/var_FinalX/*rnd*/ < -89.0f) /*rnd*/var_FinalX/*rnd*/ = -89.0f;
                        /*order-*//*order-*/
                        if (/*rnd*/var_FinalY/*rnd*/ > 180.0f) /*rnd*/var_FinalY/*rnd*/ = 180.0f;
                        else if (/*rnd*/var_FinalY/*rnd*/ < -180.0f) /*rnd*/var_FinalY/*rnd*/ = -180.0f;
                        /*order-*/
                        /*order-end*/
                        /*order-start*/
                        /*order-*/if (Math.Abs(/*rnd*/var_ViewAngles/*rnd*/./*rnd*/var_Xc/*rnd*/ - /*rnd*/var_FinalX/*rnd*/) > /*rnd*/var_FOV/*rnd*/) return false;/*order-*/
                        /*order-*/if (Math.Abs(/*rnd*/var_ViewAngles/*rnd*/./*rnd*/var_Yc/*rnd*/ - /*rnd*/var_FinalY/*rnd*/) > /*rnd*/var_FOV/*rnd*/) return false;/*order-*/
                        /*order-end*/
                        /*order-start*/
                        /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<float>(/*rnd*/var_ClientState/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ViewAngles/*rnd*/, /*rnd*/var_FinalX/*rnd*/);/*order-*/
                        /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<float>(/*rnd*/var_ClientState/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ViewAngles/*rnd*/ + (/*number*/4/*number*/), /*rnd*/var_FinalY/*rnd*/);/*order-*/
                        /*order-*//*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<float>(/*rnd*/var_ClientState/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ViewAngles/*rnd*/ + (/*number*/8/*number*/), 0.0f);/*order-*/
                        /*order-end*/
                        /*rnd*/var_Index/*rnd*/ = 0;
                        Thread.Sleep(/*number*//*setting_aimbot_thread_delay*/10/*setting_aimbot_thread_delay*//*number*/);
                        return true;
                    }
                }
            }
            return false;
        }
        /*junk_method*/
        /*feature_aimbot/magnet*/
        /*junk_method*/
        /*feature_triggerbot*/
        private static void /*rnd*/met_TriggerBot/*rnd*/(int /*rnd*/var_Overshoot/*rnd*/, int /*rnd*/var_Delay/*rnd*/, bool /*rnd*/var_Enemies/*rnd*/, bool /*rnd*/var_Teammates/*rnd*/, bool /*rnd*/var_Magnet/*rnd*/, int /*rnd*/var_MagnetBone/*rnd*/, float /*rnd*/var_MagnetSmooth/*rnd*/, float /*rnd*/var_MagnetFOV/*rnd*/) {
            /*feature_aimbot/magnet*/if (/*rnd*/var_Magnet/*rnd*/) /*rnd*/met_AimAtBest/*rnd*/(/*rnd*/var_MagnetBone/*rnd*/, /*rnd*/var_MagnetFOV/*rnd*/, /*rnd*/var_MagnetSmooth/*rnd*/, false, /*rnd*/var_Enemies/*rnd*/, /*rnd*/var_Teammates/*rnd*/);/*feature_aimbot/magnet*/
            int /*rnd*/var_CrosshairID/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_CrosshairID/*rnd*/);
            if (/*rnd*/var_CrosshairID/*rnd*/ > 0 && /*rnd*/var_CrosshairID/*rnd*/ <= /*number*/64/*number*/)
            {
                int /*rnd*/var_DetectedPlayerT/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/cl_Memory/*rnd*/./*rnd*/var_ClientAddress/*rnd*/  + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_EntityList/*rnd*/ + (/*rnd*/var_CrosshairID/*rnd*/ - 1) * (/*number*/0x10/*number*/));
                int /*rnd*/var_DetectedPlayerT_Team/*rnd*/  = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_DetectedPlayerT/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_Team/*rnd*/);
                if (/*rnd*/var_DetectedPlayerT_Team/*rnd*/ == /*rnd*/var_LocalPlayer_Team/*rnd*/ && !/*rnd*/var_Teammates/*rnd*/) return;
                if (/*rnd*/var_DetectedPlayerT_Team/*rnd*/ != /*rnd*/var_LocalPlayer_Team/*rnd*/ && !/*rnd*/var_Enemies/*rnd*/) return;
                Thread.Sleep(/*rnd*/var_Delay/*rnd*/);
                /*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<int>(/*rnd*/cl_Memory/*rnd*/./*rnd*/var_ClientAddress/*rnd*/  + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ForceAttack/*rnd*/, 1);
                Thread.Sleep(10 + /*rnd*/var_Overshoot/*rnd*/);
                /*rnd*/cl_Memory/*rnd*/./*rnd*/met_WriteMemory/*rnd*/<int>(/*rnd*/cl_Memory/*rnd*/./*rnd*/var_ClientAddress/*rnd*/  + /*rnd*/cl_Offsets/*rnd*/./*rnd*/var_offset_ForceAttack/*rnd*/, /*number*/4/*number*/);
            }
        }
        /*junk_method*/
        /*feature_triggerbot*/
        /*feature_healthbased*/
        private static int[] /*rnd*/met_ColorFromHealth/*rnd*/(int /*rnd*/var_Health/*rnd*/) {
            if (/*rnd*/var_Health/*rnd*/ > 100) return new int[] { 255, 0, 255, 0 };
            float /*rnd*/var_Factor/*rnd*/ = /*rnd*/var_Health/*rnd*/ * 2.55f;
            /*order-start*/
            /*order-*/int /*rnd*/var_Red/*rnd*/ = Convert.ToInt32(255 - /*rnd*/var_Factor/*rnd*/);/*order-*/
            /*order-*/int /*rnd*/var_Green/*rnd*/ = Convert.ToInt32(/*rnd*/var_Factor/*rnd*/);/*order-*/
            /*order-end*/
            return new int[] { /*rnd*/var_Red/*rnd*/, /*rnd*/var_Green/*rnd*/, 0, 255 };
        }
        /*junk_method*/
        /*feature_healthbased*/
    }
}