using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;
using System.Reflection;

namespace Dynago.Forms {

    public partial class Main : Form {
        public Main() {
            InitializeComponent();
            this.LockSize();
            txtLog.MouseDown += (s, e) => FormMethod.HideCaret(txtLog.Handle);
            Text = Text.Replace("[0.0]", Program.currentVersion);
            // Custom.NET vertical tab control using default components.
            // I might've been able to do this better...
            pTabMain = new PanelTabControl(PanelTabType.VerticalAttatched);
            pTabMain.AddTab(new PanelTab(tabValues, lblValues, pnlValues));
            pTabMain.AddTab(new PanelTab(tabAimbot, lblAimbot, pnlAimbot));
            pTabMain.AddTab(new PanelTab(tabTriggerbot, lblTriggerbot, pnlTriggerbot));
            pTabMain.AddTab(new PanelTab(tabVisuals, lblVisuals, pnlVisuals));
            pTabMain.AddTab(new PanelTab(tabMisc, lblMisc, pnlMisc));
            pTabMain.AddTab(new PanelTab(tabCompile, lblCompile, pnlCompile));
            pTabMain.SelectTab(0);
            pTabValues = new PanelTabControl(PanelTabType.VerticalAttatched);
            pTabValues.AddTab(new PanelTab(tabOffsets, lblOffsets, pnlOffsets));
            pTabValues.AddTab(new PanelTab(tabBones, lblBones, pnlBones));
            pTabValues.AddTab(new PanelTab(tabValShare, lblValShare, pnlValShare));
            pTabValues.TabChanged += (s, e) => updateOffsetInformation();
            pTabValues.SelectTab(0);
            pTabMisc = new PanelTabControl(PanelTabType.ButtonBased, pTabMain);
            pTabMisc.AddTab(new PanelTab(tabFeatures, lblFeatures, pnlFeatures));
            pTabMisc.AddTab(new PanelTab(tabConfig, lblConfig, pnlConfig));
            pTabMisc.AddTab(new PanelTab(tabAccount, lblAccount, pnlAccount));
            pTabMisc.SelectTab(0);
            cmb_config_source.SelectedIndex = 0;
            cmb_scrape_offsets.SelectedIndex = 0;
            cmb_scrape_bones.SelectedIndex = 0;
            cmb_aimbot_bone.SelectedIndex = 0;
            cmb_obfuscation_preset.SelectedIndex = 0;
            cmb_aimbot_type.SelectedIndex = 0;
            cmb_triggerbot_type.SelectedIndex = 0;
            cmb_trigger_magnet_bone.SelectedIndex = 0;
            txt_build_path.Text = "dynago.exe";
            OffsetList.Initialize();
            OffsetList.RefreshOffsets(lbOffsets);
            BoneList.Initialize();
            BoneList.RefreshBones(lbBones);
            KeyManagement.InitializeKeys();
            CheckForIllegalCrossThreadCalls = false;
            if (Program.currentUser.ToLower() != "justin")
                cb_obfuscation_enabled.Required();
            lblCustomizeTriggerMagnetic.OnHover(Color.White);
            lblBackToTrigger.OnHover(Color.White);

            // account stuff
            lblLoggedIn.Text = Program.currentUser;
            lblAdvertisements.Text = Program.currentUserAds ? "Active" : "Removed";
            lblAdvertisements.ForeColor = Program.currentUserAds ? Color.Red : Color.Green;
            lblLoggedIn.Left = lblPreLoggedIn.Right;
            lblAdvertisements.Left = lblPreAdvertisements.Right;
            lblRemoveAds.OnHover(Color.FromArgb(51, 153, 255));
            lblRemoveAds.Left = lblAdvertisements.Right;
            lblRemoveAds.Visible = Program.currentUserAds;

            // weapon config stuff (yikes?)
            general_settings = new WeaponSettings(this);
            pistol_settings = new WeaponSettings(this);
            sniper_settings = new WeaponSettings(this);
        }

        PanelTabControl pTabMain, pTabValues, pTabMisc;
        NumberFormatInfo format = new System.Globalization.NumberFormatInfo() { NumberGroupSeparator = "." };
        public WeaponSettings general_settings, pistol_settings, sniper_settings;
        public bool RefreshingTriggerSettings = false;
        public bool RefreshingAimSettings = false;
        private bool OpenOther = false;
        private bool BuildInProgress = false;
        private void Main_FormClosing(object sender, FormClosingEventArgs e) { if (!OpenOther) Application.Exit(); }
        private void ComboDrawItem(object sender, DrawItemEventArgs e) { FormMethod.DrawComboBoxCentered(sender, e); }
        private void btnCompile_Click(object sender, EventArgs e) { CompileCheat(); }
        private void lbOffsets_DoubleClick(object sender, EventArgs e) { btnChangeSelectedOffset_Click(sender, e); }
        private void lbBones_DoubleClick(object sender, EventArgs e) { btnChangeSelectedBone_Click(sender, e); }
        private void btnManuallyModifyOffsets_Click(object sender, EventArgs e) { new ChangeOffsetsText(lbOffsets, OffsetList.List).Show(); }
        private void btnManuallyModifyBones_Click(object sender, EventArgs e) { new ChangeBonesText(lbBones, BoneList.List).Show(); }
        private void btnScrapeOffsets_Click(object sender, EventArgs e) { lbOffsets.ScrapeOffsets(cmb_scrape_offsets.SelectedIndex); }
        private void btnScrapeBones_Click(object sender, EventArgs e) { lbBones.ScrapeBones(cmb_scrape_bones.SelectedIndex); }
        private void txtTriggerKey_MouseClick(object sender, MouseEventArgs e) { txt_trigger_key.ChangeKey(txtDummy, e); }
        private void txtBhopKey_MouseClick(object sender, MouseEventArgs e) { txt_bhop_key.ChangeKey(txtDummy, e); }
        private void txt_aimbot_key_MouseClick(object sender, MouseEventArgs e) { txt_aimbot_key.ChangeKey(txtDummy, e); }
        private void cb_visuals_teammates_color_Click(object sender, EventArgs e) { lbl_visuals_teammates_color.UseColorDialog(cd); }
        private void cb_visuals_enemies_color_Click(object sender, EventArgs e) { lbl_visuals_enemies_color.UseColorDialog(cd); }
        private void lblJustinSoftware_Click(object sender, EventArgs e) { Process.Start("https://justin.ooo/"); }
        private void cb_trigger_magnetic_CheckedChanged(object sender, EventArgs e) { lblCustomizeTriggerMagnetic.Visible = cb_trigger_magnetic.Checked; }
        private void lblCustomizeTriggerMagnetic_Click(object sender, EventArgs e) { pnlTrigger2.BringToFront(); }
        private void lblBackToTrigger_Click(object sender, EventArgs e) { pnlTrigger1.BringToFront(); }
        private void btnUploadValues_Click(object sender, EventArgs e) { Sharing.UploadValues(txtUploadID); }
        private void btnDownloadValues_Click(object sender, EventArgs e) { Sharing.DownloadValues(txtDownloadID, new Action(updateOffsetInformation)); }
        private void btnSelectConfigFile_Click(object sender, EventArgs e) { sfd.SaveFile(txtConfigFileSave, "Dynago Files (*.dgo)|*.dgo"); }
        private void btnSaveConfigFile_Click(object sender, EventArgs e) { this.SaveConfig(txtConfigFileSave.Text); }
        private void btnSelectConfigFileLoad_Click(object sender, EventArgs e) { ofd.OpenFile(txtConfigFileLoad, "Dynago Files (*.dgo)|*.dgo"); }
        private void btnLoadConfigFile_Click(object sender, EventArgs e) { this.LoadConfigFile(txtConfigFileLoad.Text); }
        private void btnUploadConfig_Click(object sender, EventArgs e) { this.UploadConfig(txtUploadConfig); }
        private void btnDownloadConfig_Click(object sender, EventArgs e) { this.DownloadConfig(txtDownloadConfig); }
        private void lblRemoveAds_Click(object sender, EventArgs e) { Process.Start("https://selly.gg/p/4e4b5f82"); }
        private void btnLogout_Click(object sender, EventArgs e) { Process.Start(Program.path); Application.Exit(); }

        private void updateOffsetInformation() {
            int offsetsCountSet = 0, bonesCountSet = 0;
            List<Offset> offsets = OffsetList.List;
            List<Bone> bones = BoneList.List;
            foreach (Offset offset in offsets) 
                if (offset.GetValue() > 0) offsetsCountSet++;
            foreach (Bone bone in bones)
                if (bone.GetValue() > 0) bonesCountSet++;
            lblOffsetsSet.Text = offsetsCountSet + "/" + offsets.Count;
            lblBonesSet.Text = bonesCountSet + "/" + bones.Count;
            OffsetList.RefreshOffsets(lbOffsets);
            BoneList.RefreshBones(lbBones);
        }

        private void cmb_config_source_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cmb_config_source.SelectedIndex) {
                case 0: pnlConfigID.BringToFront(); break;
                case 1: pnlConfigFile.BringToFront(); break;
            }
            txtDummy.Focus();
        }

        private void btnChangeSelectedOffset_Click(object sender, EventArgs e) {
            if (lbOffsets.SelectedIndex < 0) {
                MessageBox.Show("Please select an offset to change.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new ChangeOffset(lbOffsets, OffsetList.List[lbOffsets.SelectedIndex]).Show();
        }

        private void btnChangeSelectedBone_Click(object sender, EventArgs e) {
            if (lbBones.SelectedIndex < 0) {
                MessageBox.Show("Please select a bone to change.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new ChangeBone(lbBones, BoneList.List[lbBones.SelectedIndex]).Show();
        }

        private void btnSelectFile_Click(object sender, EventArgs e) {
            sfd.Filter = "Executable File (*.exe)|*.exe";
            if (sfd.ShowDialog() == DialogResult.OK)
                txt_build_path.Text = sfd.FileName;
        }

        
        private void CompileCheat() {
            if (BuildInProgress) {
                txtLog.Log("Build already in progress.", Color.Yellow);
                return;
            }
            BuildInProgress = true;
        
            
            string sourceMemory = Properties.Resources.Memory;
            string sourceOffsets = Properties.Resources.Offsets;
            string sourceProgram = Properties.Resources.Program;
            string sourceAimbotMath = Properties.Resources.AimbotMath;
            
            // Temporarily getting cheat source from local files, replace before release.
            /*
            string sourceMemory = File.ReadAllText(@"C:\Users\Justin\Documents\Programming\Programs\Applications\Dynago\Dynago Stub\Dynago Stub\Memory.cs");
            string sourceOffsets = File.ReadAllText(@"C:\Users\Justin\Documents\Programming\Programs\Applications\Dynago\Dynago Stub\Dynago Stub\Offsets.cs");
            string sourceProgram = File.ReadAllText(@"C:\Users\Justin\Documents\Programming\Programs\Applications\Dynago\Dynago Stub\Dynago Stub\Program.cs");
            string sourceAimbotMath = File.ReadAllText(@"C:\Users\Justin\Documents\Programming\Programs\Applications\Dynago\Dynago Stub\Dynago Stub\AimbotMath.cs");
            */
            
            string sourceFinal = sourceMemory + sourceOffsets + sourceProgram;
            txtLog.Log("Initialized original cheat source.");

            #region settings
            // Note: use.ToString(format) when converting floats/decimals.
            #region aimbot settings
            bool aimbot_required = cb_aimbot_enabled.Checked || general_settings.trigger_magnetic || pistol_settings.trigger_magnetic || sniper_settings.trigger_magnetic;
            if (aimbot_required) sourceFinal += sourceAimbotMath;
            for (int i = 0; i < cmb_aimbot_type.Items.Count; i++) {
                string typeName = cmb_aimbot_type.Items[i].ToString();
                WeaponSettings type = null;
                switch (typeName) {
                    case "general": type = general_settings; break;
                    case "pistols": type = pistol_settings; break;
                    case "snipers": type = sniper_settings; break;
                }
                if (type.aimbot_on_key) sourceFinal = sourceFinal.ReplaceComment($"setting_aimbot_{typeName}_key", KeyManagement.KeyFromText(type.aimbot_key_txt).ToString());
                else sourceFinal = sourceFinal.ReplaceComment($"setting_aimbot_{typeName}_key", "-1");
                sourceFinal = sourceFinal.ReplaceComment($"setting_aimbot_{typeName}_bone", BoneList.GetBone((cmb_aimbot_bone.Items[type.aimbot_bone_index]).ToString()).ToString());
                sourceFinal = sourceFinal.ReplaceComment($"setting_aimbot_{typeName}_fov", type.aimbot_fov.ToString(format) + "f");
                sourceFinal = sourceFinal.ReplaceComment($"setting_aimbot_{typeName}_smooth", type.aimbot_smooth.ToString(format) + "f");
                sourceFinal = sourceFinal.ReplaceComment($"setting_aimbot_{typeName}_rcs", type.aimbot_control_recoil.ToString().ToLower());
                sourceFinal = sourceFinal.ReplaceComment($"setting_aimbot_{typeName}_enemy", type.aimbot_shoot_enemies.ToString().ToLower());
                sourceFinal = sourceFinal.ReplaceComment($"setting_aimbot_{typeName}_team", type.aimbot_shoot_teammates.ToString().ToLower());
            }
            sourceFinal = sourceFinal.ReplaceComment("setting_aimbot_thread_delay", Convert.ToInt32(nud_aimbot_thread_delay.Value).ToString());
            if (!cb_aimbot_enabled.Checked) sourceFinal = sourceFinal.EraseComment("feature_aimbot");
            if (!aimbot_required) sourceFinal = sourceFinal.EraseComment("feature_aimbot/magnet");
            #endregion
            #region trigger settings
            for (int i = 0; i < cmb_triggerbot_type.Items.Count; i++) {
                string typeName = cmb_triggerbot_type.Items[i].ToString();
                WeaponSettings type = null;
                switch (typeName) {
                    case "general": type = general_settings; break;
                    case "pistols": type = pistol_settings; break;
                    case "snipers": type = sniper_settings; break;
                }
                if (type.trigger_on_key) sourceFinal = sourceFinal.ReplaceComment($"setting_triggerbot_{typeName}_key", KeyManagement.KeyFromText(type.trigger_key_txt).ToString());
                else sourceFinal = sourceFinal.ReplaceComment($"setting_triggerbot_{typeName}_key", "-1");
                sourceFinal = sourceFinal.ReplaceComment($"setting_triggerbot_{typeName}_magnetbone", BoneList.GetBone((cmb_trigger_magnet_bone.Items[type.trigger_magnet_bone_index]).ToString()).ToString());
                sourceFinal = sourceFinal.ReplaceComment($"setting_triggerbot_{typeName}_magnetfov", type.trigger_magnet_fov.ToString(format) + "f");
                sourceFinal = sourceFinal.ReplaceComment($"setting_triggerbot_{typeName}_magnetsmooth", type.trigger_magnet_smooth.ToString(format) + "f");
                sourceFinal = sourceFinal.ReplaceComment($"setting_triggerbot_{typeName}_magnetic", type.trigger_magnetic.ToString().ToLower());
                sourceFinal = sourceFinal.ReplaceComment($"setting_triggerbot_{typeName}_enemy", type.trigger_shoot_enemies.ToString().ToLower());
                sourceFinal = sourceFinal.ReplaceComment($"setting_triggerbot_{typeName}_team", type.trigger_shoot_teammates.ToString().ToLower());
                sourceFinal = sourceFinal.ReplaceComment($"setting_triggerbot_{typeName}_delay", type.trigger_delay.ToString());
                sourceFinal = sourceFinal.ReplaceComment($"setting_triggerbot_{typeName}_overshoot", type.trigger_overshoot.ToString());
            }
            if (nud_trigger_thread_delay.Value > 0) sourceFinal = sourceFinal.ReplaceComment("setting_trigger_thread_delay", Convert.ToInt32(nud_trigger_thread_delay.Value).ToString());
            if (!cb_trigger_enabled.Checked) sourceFinal = sourceFinal.EraseComment("feature_triggerbot");
            #endregion
            #region visual settings
            // Teammate settings
            sourceFinal = sourceFinal.ReplaceComment("setting_visuals_teammate_color_r", lbl_visuals_teammates_color.BackColor.R.ToString());
            sourceFinal = sourceFinal.ReplaceComment("setting_visuals_teammate_color_g", lbl_visuals_teammates_color.BackColor.G.ToString());
            sourceFinal = sourceFinal.ReplaceComment("setting_visuals_teammate_color_b", lbl_visuals_teammates_color.BackColor.B.ToString());
            sourceFinal = sourceFinal.ReplaceComment("setting_visuals_teammate_alpha", Convert.ToInt32(nud_visuals_teammates_glowalpha.Value).ToString());
            if (!cb_visuals_teammates_visibleonly.Checked) sourceFinal = sourceFinal.EraseComment("feature_visuals_teammate_chams_enabled");
            else sourceFinal = sourceFinal.EraseComment("feature_visuals_teammate_chams_disabled");
            if (!cb_visuals_teammates_healthbased.Checked) sourceFinal = sourceFinal.EraseComment("feature_teammate_healthbased");
            if (!cb_visuals_teammates_enabled.Checked) sourceFinal = sourceFinal.EraseComment("feature_visuals_teammate");
            // Enemy settings
            sourceFinal = sourceFinal.ReplaceComment("setting_visuals_enemy_color_r", lbl_visuals_enemies_color.BackColor.R.ToString());
            sourceFinal = sourceFinal.ReplaceComment("setting_visuals_enemy_color_g", lbl_visuals_enemies_color.BackColor.G.ToString());
            sourceFinal = sourceFinal.ReplaceComment("setting_visuals_enemy_color_b", lbl_visuals_enemies_color.BackColor.B.ToString());
            sourceFinal = sourceFinal.ReplaceComment("setting_visuals_enemy_alpha", Convert.ToInt32(nud_visuals_enemies_glowalpha.Value).ToString());
            if (!cb_visuals_enemies_visibleonly.Checked) sourceFinal = sourceFinal.EraseComment("feature_visuals_enemy_chams_enabled");
            else sourceFinal = sourceFinal.EraseComment("feature_visuals_enemy_chams_disabled");
            if (!cb_visuals_enemies_healthbased.Checked) sourceFinal = sourceFinal.EraseComment("feature_enemy_healthbased");
            if (!cb_visuals_enemies_enabled.Checked) sourceFinal = sourceFinal.EraseComment("feature_visuals_enemy");
            // Settings that apply to both
            if (!cb_visuals_teammates_healthbased.Checked && !cb_visuals_enemies_healthbased.Checked) sourceFinal = sourceFinal.EraseComment("feature_healthbased");
            if (nud_visuals_thread_delay.Value > 0) sourceFinal = sourceFinal.ReplaceComment("setting_visuals_thread_delay", Convert.ToInt32(nud_visuals_thread_delay.Value).ToString());
            else sourceFinal = sourceFinal.EraseComment("feature_visuals_thread_delay");
            if (!cb_visuals_enabled.Checked) sourceFinal = sourceFinal.EraseComment("feature_visuals");
            #endregion
            #region misc settings
            // Bunny hop
            sourceFinal = sourceFinal.ReplaceComment("setting_bhop_key", KeyManagement.KeyFromText(txt_bhop_key.Text).ToString());
            if (!cb_bhop_enabled.Checked) sourceFinal = sourceFinal.EraseComment("feature_bhop");
            // No flash
            sourceFinal = sourceFinal.ReplaceComment("setting_noflash_percent", nud_noflash_percent.Value.ToString());
            if (!cb_noflash_enabled.Checked) sourceFinal = sourceFinal.EraseComment("feature_noflash");
            // Recoil control
            sourceFinal = sourceFinal.ReplaceComment("setting_rcs_scale_x", ((float)nud_rcs_x_percent.Value * 0.02f).ToString(format) + "f");
            sourceFinal = sourceFinal.ReplaceComment("setting_rcs_scale_y", ((float)nud_rcs_y_percent.Value * 0.02f).ToString(format) + "f");
            if (!cb_rcs_enabled.Checked) sourceFinal = sourceFinal.EraseComment("feature_rcs");
            // Radar
            if (!cb_radar_enabled.Checked) sourceFinal = sourceFinal.EraseComment("feature_radar");
            // FOV Changer
            sourceFinal = sourceFinal.ReplaceComment("setting_custom_fov", nud_fov_changer.Value.ToString());
            if (!cb_fov_changer.Checked) sourceFinal = sourceFinal.EraseComment("feature_fov_changer");
            // Skin Changer
            sourceFinal = sourceFinal.ReplaceComment("setting_skinchanger_bat", Randomize.String() + ".bat");
            sourceFinal = sourceFinal.ReplaceComment("setting_skinchanger_download", Program.url_skinchanger_download);
            sourceFinal = sourceFinal.ReplaceComment("setting_injector_download", Program.url_injector_download);
            if (!cb_skinchanger_enabled.Checked) sourceFinal = sourceFinal.EraseComment("feature_skinchanger");
            #endregion
            #region removals
            if (!cb_aimbot_enabled.Checked && !cb_trigger_enabled.Checked) sourceFinal = sourceFinal.EraseComment("weapon_type_lists");
            #endregion
            #endregion

            txtLog.Log("Implemented selected settings.");
            sourceFinal = Randomize.RandomizeOrders(sourceFinal);
            txtLog.Log("Randomized order of code.");
            sourceFinal = Randomize.Code("rnd", sourceFinal);
            txtLog.Log("Randomized class names.");
            txtLog.Log("Randomized variable names.");
            txtLog.Log("Randomized namespace names.");
            txtLog.Log("Randomized method names.");
            txtLog.Log("Randomized goto labels.");
            sourceFinal = OffsetList.ReplaceOffsets(sourceFinal);
            txtLog.Log("Replaced offset variables.");
            sourceFinal = Randomize.ReplaceNumbers(sourceFinal);
            //txtLog.Log("Replaced numbers with new sigs."); // Does nothing so excluding from logs for now.
            sourceFinal = sourceFinal.Junkify();
            txtLog.Log("Distributed randomized junk code.");
            sourceFinal = sourceFinal.ReplaceComment("setting_window_title", Randomize.String(16, 32));
            sourceFinal = sourceFinal.ReplaceComment("dynago_version", Program.currentVersion);
            sourceFinal = sourceFinal.ReplaceComment("dynago_user", Program.currentUser);
            txtLog.Log("Replaced dynamic build strings.");

            // ENABLE WHEN TESTING
            // Clipboard.SetText(sourceFinal);

            new Thread(() => {
                List<string> errors = Compiler.Compile(sourceFinal, txt_build_path.Text);
                bool success = errors.Count == 0;
                if (success) {
                    txtLog.Log("Compiled cheat to " + Path.GetFileName(txt_build_path.Text));

                    // Credits to ConfuserEx (https://yck1509.github.io/ConfuserEx/)
                    // Works by using the Confuser CLI obfuscate an assembly with settings from a .crproj file.
                    if (cb_obfuscation_enabled.Checked) {
                        txtLog.Log("Beginning obfuscation process...");
                        txtLog.Log("Installing obfuscation dependencies...");
                        string obf = Program.directory + "\\" + Randomize.String();
                        Confuser.Install(obf);
                        string confuserPreset = cmb_obfuscation_preset.SelectedItem.ToString();
                        txtLog.Log("Running obfuscation file...");
                        string confuserOutput = Confuser.Obfuscate(obf, txt_build_path.Text, confuserPreset);
                        Regex completionCheck = new Regex("Finished at.* elapsed.");
                        Match completionMatch = completionCheck.Match(confuserOutput);
                        if (completionMatch.Success) txtLog.Log("Build obfuscated successfully.");
                        else txtLog.Log("Build obfuscation failed & skipped.", Color.Yellow);
                    }

                    DialogResult result = MessageBox.Show("Cheat compiled successfully.\nWould you like to run it now?", "Dynago", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    try {
                        if (result == DialogResult.Yes) {
                            ProcessStartInfo info = new ProcessStartInfo(txt_build_path.Text);
                            info.UseShellExecute = true;
                            info.Verb = "runas";
                            Process.Start(info);
                        }
                    } catch (Exception) {
                        MessageBox.Show("Failed to run the cheat.\nPlease launch Dynago manually.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } else {
                    txtLog.Log("Oh no! There were " + errors.Count + " errors.", Color.Yellow);
                    foreach (string err in errors)
                        txtLog.Log(err, Color.Red);
                    // upload sourcefinal + error log to server???
                    string result = Networking.ShareUpload("error", sourceFinal + Environment.NewLine + txtLog.Text);
                    if (string.IsNullOrEmpty(result)) result = "[FAILED]";
                    txtLog.Log("Error log ID: " + result, Color.Yellow);
                    txtLog.Log("[Please give that to justin ^^^]", Color.Green);
                    MessageBox.Show("Build failed!\nWe found some errors :(", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }).Start();
            BuildInProgress = false;
        }

    }
}