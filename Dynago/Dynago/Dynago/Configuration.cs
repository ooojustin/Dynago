using Dynago.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

// Used to manage settings and configs inside of Dynago.
public static class Configuration {

    // Use when converting floats/decimals.
    private static NumberFormatInfo format = new System.Globalization.NumberFormatInfo() { NumberGroupSeparator = "." };

    public static void SaveConfig(this Main f, string file) {
        try {
            string configData = f.GenerateConfig();
            File.WriteAllText(file, configData);
            MessageBox.Show("Successfully saved your settings to " + Path.GetFileName(file) + ".", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } catch (Exception ex) {
            MessageBox.Show("Failed to save your settings: " + ex.Message, "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    public static void LoadConfigFile(this Main f, string file) {
        try {
            string configData = File.ReadAllText(file);
            f.LoadConfig(configData);
            MessageBox.Show("Successfully loaded settings from " + Path.GetFileName(file) + ".", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } catch (Exception ex) {
            MessageBox.Show("Failed to load selected settings: " + ex.Message, "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    public static string GenerateConfig(this Main f) {
        Dictionary<string, string> settings = new Dictionary<string, string>();

        // Aimbot settings
        settings["aimbot_enabled"] = f.cb_aimbot_enabled.Checked.ToString();
        settings["aimbot_thread_delay"] = f.nud_aimbot_thread_delay.Value.ToString();
        for (int i = 0; i < f.cmb_aimbot_type.Items.Count; i++) {
            string typeName = f.cmb_aimbot_type.Items[i].ToString();
            WeaponSettings type = null;
            switch (typeName) {
                case "general": type = f.general_settings; break;
                case "pistols": type = f.pistol_settings; break;
                case "snipers": type = f.sniper_settings; break;
            }
            settings[$"aimbot_{typeName}_onkey"] = type.aimbot_on_key.ToString();
            settings[$"aimbot_{typeName}_key"] = type.aimbot_key_txt;
            settings[$"aimbot_{typeName}_bone"] = type.aimbot_bone_index.ToString();
            settings[$"aimbot_{typeName}_fov"] = type.aimbot_fov.ToString(format);
            settings[$"aimbot_{typeName}_smooth"] = type.aimbot_smooth.ToString(format);
            settings[$"aimbot_{typeName}_rcs"] = type.aimbot_control_recoil.ToString();
            settings[$"aimbot_{typeName}_shoot_team"] = type.aimbot_shoot_teammates.ToString();
            settings[$"aimbot_{typeName}_enemy"] = type.aimbot_shoot_enemies.ToString();
        }

        // Triggerbot settings
        settings["trigger_enabled"] = f.cb_trigger_enabled.Checked.ToString();
        settings["trigger_thread_delay"] = f.nud_trigger_thread_delay.Value.ToString();
        for (int i = 0; i < f.cmb_triggerbot_type.Items.Count; i++) {
            string typeName = f.cmb_triggerbot_type.Items[i].ToString();
            WeaponSettings type = null;
            switch (typeName) {
                case "general": type = f.general_settings; break;
                case "pistols": type = f.pistol_settings; break;
                case "snipers": type = f.sniper_settings; break;
            }
            settings[$"trigger_{typeName}_onkey"] = type.trigger_on_key.ToString();
            settings[$"trigger_{typeName}_key"] = type.trigger_key_txt;
            settings[$"trigger_{typeName}_delay"] = type.trigger_delay.ToString();
            settings[$"trigger_{typeName}_overshoot"] = type.trigger_overshoot.ToString();
            settings[$"trigger_{typeName}_shoot_team"] = type.trigger_shoot_teammates.ToString();
            settings[$"trigger_{typeName}_shoot_enemy"] = type.trigger_shoot_enemies.ToString();
            settings[$"trigger_{typeName}_magnetic"] = type.trigger_magnetic.ToString();
            settings[$"trigger_{typeName}_magnetic_bone"] = type.trigger_magnet_bone_index.ToString();
            settings[$"trigger_{typeName}_magnetic_fov"] = type.trigger_magnet_fov.ToString(format);
            settings[$"trigger_{typeName}_magnetic_smooth"] = type.trigger_magnet_smooth.ToString(format);
        }

        // Visual settings
        settings["visuals_enabled"] = f.cb_visuals_enabled.Checked.ToString();
        settings["visuals_thread_delay"] = f.nud_visuals_thread_delay.Value.ToString();
        settings["visuals_team_enabled"] = f.cb_visuals_teammates_enabled.Checked.ToString();
        settings["visuals_team_visibleonly"] = f.cb_visuals_teammates_visibleonly.Checked.ToString();
        settings["visuals_team_healthbased"] = f.cb_visuals_teammates_healthbased.Checked.ToString();
        settings["visuals_team_color_r"] = f.lbl_visuals_teammates_color.BackColor.R.ToString();
        settings["visuals_team_color_g"] = f.lbl_visuals_teammates_color.BackColor.G.ToString();
        settings["visuals_team_color_b"] = f.lbl_visuals_teammates_color.BackColor.B.ToString();
        settings["visuals_team_alpha"] = f.nud_visuals_teammates_glowalpha.Value.ToString();
        settings["visuals_enemy_enabled"] = f.cb_visuals_enemies_enabled.Checked.ToString();
        settings["visuals_enemy_visibleonly"] = f.cb_visuals_enemies_visibleonly.Checked.ToString();
        settings["visuals_enemy_healthbased"] = f.cb_visuals_enemies_healthbased.Checked.ToString();
        settings["visuals_enemy_color_r"] = f.lbl_visuals_enemies_color.BackColor.R.ToString();
        settings["visuals_enemy_color_g"] = f.lbl_visuals_enemies_color.BackColor.G.ToString();
        settings["visuals_enemy_color_b"] = f.lbl_visuals_enemies_color.BackColor.B.ToString();
        settings["visuals_enemy_alpha"] = f.nud_visuals_enemies_glowalpha.Value.ToString();

        // Misc settings
        settings["bhop_enabled"] = f.cb_bhop_enabled.Checked.ToString();
        settings["bhop_key"] = f.txt_bhop_key.Text;
        settings["rcs_enabled"] = f.cb_rcs_enabled.Checked.ToString();
        settings["rcs_factor_x"] = f.nud_rcs_x_percent.Value.ToString();
        settings["rcs_factor_y"] = f.nud_rcs_y_percent.Value.ToString();
        settings["noflash_enabled"] = f.cb_noflash_enabled.Checked.ToString();
        settings["noflash_factor"] = f.nud_noflash_percent.Value.ToString();
        settings["radar_enabled"] = f.cb_radar_enabled.Checked.ToString();
        settings["skinchanger_enabled"] = f.cb_skinchanger_enabled.Checked.ToString();
        settings["obfuscation_enabled"] = f.cb_obfuscation_enabled.Checked.ToString();
        settings["obfuscation_preset"] = f.cmb_obfuscation_preset.SelectedIndex.ToString();
        settings["fov_changer_enabled"] = f.cb_fov_changer.Checked.ToString();
        settings["fov_changer_value"] = f.nud_fov_changer.Value.ToString();

        // Save to file
        string data = string.Empty;
        foreach (KeyValuePair<string, string> setting in settings)
            data += setting.Key + "=\"" + setting.Value + "\"" + Environment.NewLine;
        return data;
    }

    public static void LoadConfig(this Main f, string data) {
        Dictionary<string, string> settings = new Dictionary<string, string>();
        Regex reg = new Regex(".*=\".*\"");

        // Read data from file
        string[] lines = data.Split(new[] { '\r', '\n' });
        foreach (string line in lines) {
            Match m = reg.Match(line);
            if (m.Success) {
                string key = m.Value.Split('=').GetValue(0).ToString();
                string value = m.Value.Split('"').GetValue(1).ToString();
                settings[key] = value;
            }
        }

        // Aimbot settings
        f.cb_aimbot_enabled.Checked = Convert.ToBoolean(settings["aimbot_enabled"]);
        f.nud_aimbot_thread_delay.Value = Convert.ToDecimal(settings["aimbot_thread_delay"]);
        for (int i = 0; i < f.cmb_aimbot_type.Items.Count; i++) {
            string typeName = f.cmb_aimbot_type.Items[i].ToString();
            WeaponSettings type = null;
            switch (typeName) {
                case "general": type = f.general_settings; break;
                case "pistols": type = f.pistol_settings; break;
                case "snipers": type = f.sniper_settings; break;
            }
            type.aimbot_on_key = Convert.ToBoolean(settings[$"aimbot_{typeName}_onkey"]);
            type.aimbot_key_txt = settings[$"aimbot_{typeName}_key"];
            type.aimbot_bone_index = Convert.ToInt32(settings[$"aimbot_{typeName}_bone"]);
            type.aimbot_fov = Convert.ToSingle(settings[$"aimbot_{typeName}_fov"], format);
            type.aimbot_smooth = Convert.ToSingle(settings[$"aimbot_{typeName}_smooth"], format);
            type.aimbot_control_recoil = Convert.ToBoolean(settings[$"aimbot_{typeName}_rcs"]);
            type.aimbot_shoot_teammates = Convert.ToBoolean(settings[$"aimbot_{typeName}_shoot_team"]);
            type.aimbot_shoot_enemies = Convert.ToBoolean(settings[$"aimbot_{typeName}_enemy"]);
        }
        WeaponSettings.RefreshAimSettings(f);

        // Triggerbot settings
        f.cb_trigger_enabled.Checked = Convert.ToBoolean(settings["trigger_enabled"]);
        f.nud_trigger_thread_delay.Value = Convert.ToDecimal(settings["trigger_thread_delay"]);
        for (int i = 0; i < f.cmb_triggerbot_type.Items.Count; i++) {
            string typeName = f.cmb_triggerbot_type.Items[i].ToString();
            WeaponSettings type = null;
            switch (typeName) {
                case "general": type = f.general_settings; break;
                case "pistols": type = f.pistol_settings; break;
                case "snipers": type = f.sniper_settings; break;
            }
            type.trigger_on_key = Convert.ToBoolean(settings[$"trigger_{typeName}_onkey"]);
            type.trigger_key_txt = settings[$"trigger_{typeName}_key"];
            type.trigger_delay = Convert.ToInt32(settings[$"trigger_{typeName}_delay"]);
            type.trigger_overshoot = Convert.ToInt32(settings[$"trigger_{typeName}_overshoot"]);
            type.trigger_shoot_teammates = Convert.ToBoolean(settings[$"trigger_{typeName}_shoot_team"]);
            type.trigger_shoot_enemies = Convert.ToBoolean(settings[$"trigger_{typeName}_shoot_enemy"]);
            type.trigger_magnetic = Convert.ToBoolean(settings[$"trigger_{typeName}_magnetic"]);
            type.trigger_magnet_bone_index = Convert.ToInt32(settings[$"trigger_{typeName}_magnetic_bone"]);
            type.trigger_magnet_fov = Convert.ToSingle(settings[$"trigger_{typeName}_magnetic_fov"]);
            type.trigger_magnet_smooth = Convert.ToSingle(settings[$"trigger_{typeName}_magnetic_smooth"]);
        }
        WeaponSettings.RefreshTriggerSettings(f);

        // Visual settings
        f.cb_visuals_enabled.Checked = Convert.ToBoolean(settings["visuals_enabled"]);
        f.nud_visuals_thread_delay.Value = Convert.ToDecimal(settings["visuals_thread_delay"]);
        f.cb_visuals_teammates_enabled.Checked = Convert.ToBoolean(settings["visuals_team_enabled"]);
        f.cb_visuals_teammates_visibleonly.Checked = Convert.ToBoolean(settings["visuals_team_visibleonly"]);
        f.cb_visuals_teammates_healthbased.Checked = Convert.ToBoolean(settings["visuals_team_healthbased"]);
        f.lbl_visuals_teammates_color.BackColor = Color.FromArgb(
            Convert.ToInt32(settings["visuals_team_color_r"]),
            Convert.ToInt32(settings["visuals_team_color_g"]),
            Convert.ToInt32(settings["visuals_team_color_b"]));
        f.nud_visuals_teammates_glowalpha.Value = Convert.ToDecimal(settings["visuals_team_alpha"]);
        f.cb_visuals_enemies_enabled.Checked = Convert.ToBoolean(settings["visuals_enemy_enabled"]);
        f.cb_visuals_enemies_visibleonly.Checked = Convert.ToBoolean(settings["visuals_enemy_visibleonly"]);
        f.cb_visuals_enemies_healthbased.Checked = Convert.ToBoolean(settings["visuals_enemy_healthbased"]);
        f.lbl_visuals_enemies_color.BackColor = Color.FromArgb(
            Convert.ToInt32(settings["visuals_enemy_color_r"]),
            Convert.ToInt32(settings["visuals_enemy_color_g"]),
            Convert.ToInt32(settings["visuals_enemy_color_b"]));
        f.nud_visuals_enemies_glowalpha.Value = Convert.ToDecimal(settings["visuals_enemy_alpha"]);

        // Misc settings
        f.cb_bhop_enabled.Checked = Convert.ToBoolean(settings["bhop_enabled"]);
        f.txt_bhop_key.Text = settings["bhop_key"];
        f.cb_rcs_enabled.Checked = Convert.ToBoolean(settings["rcs_enabled"]);
        f.nud_rcs_x_percent.Value = Convert.ToDecimal(settings["rcs_factor_x"]);
        f.nud_rcs_y_percent.Value = Convert.ToDecimal(settings["rcs_factor_y"]);
        f.cb_noflash_enabled.Checked = Convert.ToBoolean(settings["noflash_enabled"]);
        f.nud_noflash_percent.Value = Convert.ToDecimal(settings["noflash_factor"]);
        f.cb_radar_enabled.Checked = Convert.ToBoolean(settings["radar_enabled"]);
        f.cb_skinchanger_enabled.Checked = Convert.ToBoolean(settings["skinchanger_enabled"]);
        f.cb_obfuscation_enabled.Checked = Convert.ToBoolean(settings["obfuscation_enabled"]);
        f.cmb_obfuscation_preset.SelectedIndex = Convert.ToInt32(settings["obfuscation_preset"]);
        f.cb_fov_changer.Checked = Convert.ToBoolean(settings["fov_changer_enabled"]);
        f.nud_fov_changer.Value = Convert.ToDecimal(settings["fov_changer_value"]);
    }

}