using System.Drawing;
using System.Windows.Forms;

namespace Dynago.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabValues = new System.Windows.Forms.Panel();
            this.lblValues = new System.Windows.Forms.Label();
            this.tabTriggerbot = new System.Windows.Forms.Panel();
            this.lblTriggerbot = new System.Windows.Forms.Label();
            this.tabVisuals = new System.Windows.Forms.Panel();
            this.lblVisuals = new System.Windows.Forms.Label();
            this.tabMisc = new System.Windows.Forms.Panel();
            this.lblMisc = new System.Windows.Forms.Label();
            this.tabCompile = new System.Windows.Forms.Panel();
            this.lblCompile = new System.Windows.Forms.Label();
            this.pnlValues = new System.Windows.Forms.Panel();
            this.pnlValShare = new System.Windows.Forms.Panel();
            this.label71 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.txtUploadID = new System.Windows.Forms.TextBox();
            this.btnUploadValues = new System.Windows.Forms.Button();
            this.label70 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.txtDownloadID = new System.Windows.Forms.TextBox();
            this.btnDownloadValues = new System.Windows.Forms.Button();
            this.label67 = new System.Windows.Forms.Label();
            this.lblBonesSet = new System.Windows.Forms.Label();
            this.lblOffsetsSet = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.pnlOffsets = new System.Windows.Forms.Panel();
            this.lbOffsets = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManuallyModifyOffsets = new System.Windows.Forms.Button();
            this.btnChangeSelectedOffset = new System.Windows.Forms.Button();
            this.cmb_scrape_offsets = new System.Windows.Forms.ComboBox();
            this.btnScrapeOffsets = new System.Windows.Forms.Button();
            this.tabValShare = new System.Windows.Forms.Panel();
            this.lblValShare = new System.Windows.Forms.Label();
            this.pnlBones = new System.Windows.Forms.Panel();
            this.lbBones = new System.Windows.Forms.ListBox();
            this.label51 = new System.Windows.Forms.Label();
            this.btnManuallyModifyBones = new System.Windows.Forms.Button();
            this.btnChangeSelectedBone = new System.Windows.Forms.Button();
            this.cmb_scrape_bones = new System.Windows.Forms.ComboBox();
            this.btnScrapeBones = new System.Windows.Forms.Button();
            this.tabBones = new System.Windows.Forms.Panel();
            this.lblBones = new System.Windows.Forms.Label();
            this.tabOffsets = new System.Windows.Forms.Panel();
            this.lblOffsets = new System.Windows.Forms.Label();
            this.pnlTriggerbot = new System.Windows.Forms.Panel();
            this.pnlTrigger1 = new System.Windows.Forms.Panel();
            this.lblCustomizeTriggerMagnetic = new System.Windows.Forms.Label();
            this.cb_trigger_magnetic = new System.Windows.Forms.CheckBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_trigger_shoot_enemies = new System.Windows.Forms.CheckBox();
            this.txt_trigger_key = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_trigger_shoot_teammates = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_trigger_onkey = new System.Windows.Forms.CheckBox();
            this.nud_trigger_overshoot = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nud_trigger_delay = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlTrigger2 = new System.Windows.Forms.Panel();
            this.cmb_trigger_magnet_bone = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            this.nud_trigger_magnet_smooth = new System.Windows.Forms.NumericUpDown();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.nud_trigger_magnet_fov = new System.Windows.Forms.NumericUpDown();
            this.label61 = new System.Windows.Forms.Label();
            this.lblBackToTrigger = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_trigger_thread_delay = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.cb_trigger_enabled = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmb_triggerbot_type = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlVisuals = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.nud_visuals_thread_delay = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.cb_visuals_enemies_healthbased = new System.Windows.Forms.CheckBox();
            this.nud_visuals_enemies_glowalpha = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.lbl_visuals_enemies_color = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cb_visuals_enemies_visibleonly = new System.Windows.Forms.CheckBox();
            this.label80 = new System.Windows.Forms.Label();
            this.cb_visuals_enemies_enabled = new System.Windows.Forms.CheckBox();
            this.label81 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label59 = new System.Windows.Forms.Label();
            this.cb_visuals_teammates_healthbased = new System.Windows.Forms.CheckBox();
            this.nud_visuals_teammates_glowalpha = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_visuals_teammates_color = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cb_visuals_teammates_visibleonly = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_visuals_teammates_enabled = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_visuals_enabled = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMisc = new System.Windows.Forms.Panel();
            this.pnlFeatures = new System.Windows.Forms.Panel();
            this.cb_skinchanger_enabled = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.nud_fov_changer = new System.Windows.Forms.NumericUpDown();
            this.label58 = new System.Windows.Forms.Label();
            this.cb_fov_changer = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.cb_rcs_enabled = new System.Windows.Forms.CheckBox();
            this.nud_rcs_x_percent = new System.Windows.Forms.NumericUpDown();
            this.cmb_obfuscation_preset = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.cb_obfuscation_enabled = new System.Windows.Forms.CheckBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.nud_rcs_y_percent = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.txt_bhop_key = new System.Windows.Forms.TextBox();
            this.cb_radar_enabled = new System.Windows.Forms.CheckBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.cb_bhop_enabled = new System.Windows.Forms.CheckBox();
            this.nud_noflash_percent = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.cb_noflash_enabled = new System.Windows.Forms.CheckBox();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.lblRemoveAds = new System.Windows.Forms.Label();
            this.lblAdvertisements = new System.Windows.Forms.Label();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblPreAdvertisements = new System.Windows.Forms.Label();
            this.lblPreLoggedIn = new System.Windows.Forms.Label();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.pnlConfigID = new System.Windows.Forms.Panel();
            this.btnDownloadConfig = new System.Windows.Forms.Button();
            this.label76 = new System.Windows.Forms.Label();
            this.txtDownloadConfig = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.txtUploadConfig = new System.Windows.Forms.TextBox();
            this.btnUploadConfig = new System.Windows.Forms.Button();
            this.label79 = new System.Windows.Forms.Label();
            this.pnlConfigFile = new System.Windows.Forms.Panel();
            this.btnLoadConfigFile = new System.Windows.Forms.Button();
            this.btnSelectConfigFileLoad = new System.Windows.Forms.Button();
            this.btnSaveConfigFile = new System.Windows.Forms.Button();
            this.label72 = new System.Windows.Forms.Label();
            this.txtConfigFileLoad = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.txtConfigFileSave = new System.Windows.Forms.TextBox();
            this.btnSelectConfigFileSave = new System.Windows.Forms.Button();
            this.label75 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.cmb_config_source = new System.Windows.Forms.ComboBox();
            this.tabConfig = new System.Windows.Forms.Panel();
            this.lblConfig = new System.Windows.Forms.Label();
            this.tabAccount = new System.Windows.Forms.Panel();
            this.lblAccount = new System.Windows.Forms.Label();
            this.tabFeatures = new System.Windows.Forms.Panel();
            this.lblFeatures = new System.Windows.Forms.Label();
            this.pnlCompile = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnCompile = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_build_path = new System.Windows.Forms.TextBox();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.txtDummy = new System.Windows.Forms.TextBox();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.tabAimbot = new System.Windows.Forms.Panel();
            this.lblAimbot = new System.Windows.Forms.Label();
            this.pnlAimbot = new System.Windows.Forms.Panel();
            this.label39 = new System.Windows.Forms.Label();
            this.nud_aimbot_thread_delay = new System.Windows.Forms.NumericUpDown();
            this.label40 = new System.Windows.Forms.Label();
            this.cb_aimbot_enabled = new System.Windows.Forms.CheckBox();
            this.label41 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.cmb_aimbot_type = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.cmb_aimbot_bone = new System.Windows.Forms.ComboBox();
            this.label50 = new System.Windows.Forms.Label();
            this.cb_aimbot_rcs = new System.Windows.Forms.CheckBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.cb_aimbot_target_enemies = new System.Windows.Forms.CheckBox();
            this.txt_aimbot_key = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.cb_aimbot_target_teammates = new System.Windows.Forms.CheckBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.cb_aimbot_onkey = new System.Windows.Forms.CheckBox();
            this.nud_aimbot_smooth = new System.Windows.Forms.NumericUpDown();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.nud_aimbot_fov = new System.Windows.Forms.NumericUpDown();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tabValues.SuspendLayout();
            this.tabTriggerbot.SuspendLayout();
            this.tabVisuals.SuspendLayout();
            this.tabMisc.SuspendLayout();
            this.tabCompile.SuspendLayout();
            this.pnlValues.SuspendLayout();
            this.pnlValShare.SuspendLayout();
            this.pnlOffsets.SuspendLayout();
            this.tabValShare.SuspendLayout();
            this.pnlBones.SuspendLayout();
            this.tabBones.SuspendLayout();
            this.tabOffsets.SuspendLayout();
            this.pnlTriggerbot.SuspendLayout();
            this.pnlTrigger1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_overshoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_delay)).BeginInit();
            this.pnlTrigger2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_magnet_smooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_magnet_fov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_thread_delay)).BeginInit();
            this.panel5.SuspendLayout();
            this.pnlVisuals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_visuals_thread_delay)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_visuals_enemies_glowalpha)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_visuals_teammates_glowalpha)).BeginInit();
            this.pnlMisc.SuspendLayout();
            this.pnlFeatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fov_changer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rcs_x_percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rcs_y_percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_noflash_percent)).BeginInit();
            this.pnlAccount.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            this.pnlConfigID.SuspendLayout();
            this.pnlConfigFile.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.tabFeatures.SuspendLayout();
            this.pnlCompile.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tabAimbot.SuspendLayout();
            this.pnlAimbot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_aimbot_thread_delay)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_aimbot_smooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_aimbot_fov)).BeginInit();
            this.SuspendLayout();
            // 
            // tabValues
            // 
            this.tabValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabValues.Controls.Add(this.lblValues);
            this.tabValues.Location = new System.Drawing.Point(12, 12);
            this.tabValues.Name = "tabValues";
            this.tabValues.Size = new System.Drawing.Size(136, 40);
            this.tabValues.TabIndex = 0;
            // 
            // lblValues
            // 
            this.lblValues.AutoSize = true;
            this.lblValues.BackColor = System.Drawing.Color.Transparent;
            this.lblValues.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValues.ForeColor = System.Drawing.Color.White;
            this.lblValues.Location = new System.Drawing.Point(33, 9);
            this.lblValues.Name = "lblValues";
            this.lblValues.Size = new System.Drawing.Size(70, 22);
            this.lblValues.TabIndex = 0;
            this.lblValues.Text = "Values";
            // 
            // tabTriggerbot
            // 
            this.tabTriggerbot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabTriggerbot.Controls.Add(this.lblTriggerbot);
            this.tabTriggerbot.Location = new System.Drawing.Point(12, 104);
            this.tabTriggerbot.Name = "tabTriggerbot";
            this.tabTriggerbot.Size = new System.Drawing.Size(136, 40);
            this.tabTriggerbot.TabIndex = 1;
            // 
            // lblTriggerbot
            // 
            this.lblTriggerbot.AutoSize = true;
            this.lblTriggerbot.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriggerbot.ForeColor = System.Drawing.Color.White;
            this.lblTriggerbot.Location = new System.Drawing.Point(13, 9);
            this.lblTriggerbot.Name = "lblTriggerbot";
            this.lblTriggerbot.Size = new System.Drawing.Size(110, 22);
            this.lblTriggerbot.TabIndex = 1;
            this.lblTriggerbot.Text = "Triggerbot";
            // 
            // tabVisuals
            // 
            this.tabVisuals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabVisuals.Controls.Add(this.lblVisuals);
            this.tabVisuals.Location = new System.Drawing.Point(12, 150);
            this.tabVisuals.Name = "tabVisuals";
            this.tabVisuals.Size = new System.Drawing.Size(136, 40);
            this.tabVisuals.TabIndex = 2;
            // 
            // lblVisuals
            // 
            this.lblVisuals.AutoSize = true;
            this.lblVisuals.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisuals.ForeColor = System.Drawing.Color.White;
            this.lblVisuals.Location = new System.Drawing.Point(28, 9);
            this.lblVisuals.Name = "lblVisuals";
            this.lblVisuals.Size = new System.Drawing.Size(80, 22);
            this.lblVisuals.TabIndex = 2;
            this.lblVisuals.Text = "Visuals";
            // 
            // tabMisc
            // 
            this.tabMisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabMisc.Controls.Add(this.lblMisc);
            this.tabMisc.Location = new System.Drawing.Point(12, 196);
            this.tabMisc.Name = "tabMisc";
            this.tabMisc.Size = new System.Drawing.Size(136, 40);
            this.tabMisc.TabIndex = 3;
            // 
            // lblMisc
            // 
            this.lblMisc.AutoSize = true;
            this.lblMisc.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisc.ForeColor = System.Drawing.Color.White;
            this.lblMisc.Location = new System.Drawing.Point(43, 9);
            this.lblMisc.Name = "lblMisc";
            this.lblMisc.Size = new System.Drawing.Size(50, 22);
            this.lblMisc.TabIndex = 2;
            this.lblMisc.Text = "Misc";
            // 
            // tabCompile
            // 
            this.tabCompile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabCompile.Controls.Add(this.lblCompile);
            this.tabCompile.Location = new System.Drawing.Point(12, 242);
            this.tabCompile.Name = "tabCompile";
            this.tabCompile.Size = new System.Drawing.Size(136, 40);
            this.tabCompile.TabIndex = 4;
            // 
            // lblCompile
            // 
            this.lblCompile.AutoSize = true;
            this.lblCompile.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompile.ForeColor = System.Drawing.Color.White;
            this.lblCompile.Location = new System.Drawing.Point(28, 9);
            this.lblCompile.Name = "lblCompile";
            this.lblCompile.Size = new System.Drawing.Size(80, 22);
            this.lblCompile.TabIndex = 2;
            this.lblCompile.Text = "Compile";
            // 
            // pnlValues
            // 
            this.pnlValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlValues.Controls.Add(this.pnlValShare);
            this.pnlValues.Controls.Add(this.pnlOffsets);
            this.pnlValues.Controls.Add(this.tabValShare);
            this.pnlValues.Controls.Add(this.pnlBones);
            this.pnlValues.Controls.Add(this.tabBones);
            this.pnlValues.Controls.Add(this.tabOffsets);
            this.pnlValues.Location = new System.Drawing.Point(154, 12);
            this.pnlValues.Name = "pnlValues";
            this.pnlValues.Size = new System.Drawing.Size(448, 270);
            this.pnlValues.TabIndex = 5;
            // 
            // pnlValShare
            // 
            this.pnlValShare.Controls.Add(this.label71);
            this.pnlValShare.Controls.Add(this.label69);
            this.pnlValShare.Controls.Add(this.txtUploadID);
            this.pnlValShare.Controls.Add(this.btnUploadValues);
            this.pnlValShare.Controls.Add(this.label70);
            this.pnlValShare.Controls.Add(this.label68);
            this.pnlValShare.Controls.Add(this.txtDownloadID);
            this.pnlValShare.Controls.Add(this.btnDownloadValues);
            this.pnlValShare.Controls.Add(this.label67);
            this.pnlValShare.Controls.Add(this.lblBonesSet);
            this.pnlValShare.Controls.Add(this.lblOffsetsSet);
            this.pnlValShare.Controls.Add(this.label65);
            this.pnlValShare.Controls.Add(this.label66);
            this.pnlValShare.Location = new System.Drawing.Point(108, 0);
            this.pnlValShare.Name = "pnlValShare";
            this.pnlValShare.Size = new System.Drawing.Size(340, 270);
            this.pnlValShare.TabIndex = 108;
            // 
            // label71
            // 
            this.label71.BackColor = System.Drawing.Color.Transparent;
            this.label71.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.ForeColor = System.Drawing.Color.White;
            this.label71.Location = new System.Drawing.Point(14, 64);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(315, 82);
            this.label71.TabIndex = 25;
            this.label71.Text = "This section allows you to share offsets and bones with other users. When uploadi" +
    "ng, you\'ll be given an ID to give to other users. They can use that ID to import" +
    " your currently set values.";
            this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.BackColor = System.Drawing.Color.Transparent;
            this.label69.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.Color.White;
            this.label69.Location = new System.Drawing.Point(15, 239);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(28, 14);
            this.label69.TabIndex = 24;
            this.label69.Text = "ID:";
            // 
            // txtUploadID
            // 
            this.txtUploadID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtUploadID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUploadID.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUploadID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtUploadID.Location = new System.Drawing.Point(45, 236);
            this.txtUploadID.Name = "txtUploadID";
            this.txtUploadID.ReadOnly = true;
            this.txtUploadID.Size = new System.Drawing.Size(205, 20);
            this.txtUploadID.TabIndex = 22;
            this.txtUploadID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUploadValues
            // 
            this.btnUploadValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUploadValues.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadValues.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadValues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnUploadValues.Location = new System.Drawing.Point(256, 234);
            this.btnUploadValues.Name = "btnUploadValues";
            this.btnUploadValues.Size = new System.Drawing.Size(70, 24);
            this.btnUploadValues.TabIndex = 23;
            this.btnUploadValues.Text = "GO";
            this.btnUploadValues.UseVisualStyleBackColor = false;
            this.btnUploadValues.Click += new System.EventHandler(this.btnUploadValues_Click);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.BackColor = System.Drawing.Color.Transparent;
            this.label70.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label70.Location = new System.Drawing.Point(14, 212);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(126, 19);
            this.label70.TabIndex = 21;
            this.label70.Text = "Upload Values";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.BackColor = System.Drawing.Color.Transparent;
            this.label68.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.Color.White;
            this.label68.Location = new System.Drawing.Point(15, 183);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(28, 14);
            this.label68.TabIndex = 20;
            this.label68.Text = "ID:";
            // 
            // txtDownloadID
            // 
            this.txtDownloadID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtDownloadID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDownloadID.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownloadID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtDownloadID.Location = new System.Drawing.Point(45, 180);
            this.txtDownloadID.Name = "txtDownloadID";
            this.txtDownloadID.Size = new System.Drawing.Size(205, 20);
            this.txtDownloadID.TabIndex = 18;
            this.txtDownloadID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDownloadValues
            // 
            this.btnDownloadValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDownloadValues.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDownloadValues.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadValues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDownloadValues.Location = new System.Drawing.Point(256, 178);
            this.btnDownloadValues.Name = "btnDownloadValues";
            this.btnDownloadValues.Size = new System.Drawing.Size(70, 24);
            this.btnDownloadValues.TabIndex = 19;
            this.btnDownloadValues.Text = "GO";
            this.btnDownloadValues.UseVisualStyleBackColor = false;
            this.btnDownloadValues.Click += new System.EventHandler(this.btnDownloadValues_Click);
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.BackColor = System.Drawing.Color.Transparent;
            this.label67.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label67.Location = new System.Drawing.Point(14, 156);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(144, 19);
            this.label67.TabIndex = 17;
            this.label67.Text = "Download Values";
            // 
            // lblBonesSet
            // 
            this.lblBonesSet.AutoSize = true;
            this.lblBonesSet.BackColor = System.Drawing.Color.Transparent;
            this.lblBonesSet.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonesSet.ForeColor = System.Drawing.Color.White;
            this.lblBonesSet.Location = new System.Drawing.Point(133, 38);
            this.lblBonesSet.Name = "lblBonesSet";
            this.lblBonesSet.Size = new System.Drawing.Size(36, 19);
            this.lblBonesSet.TabIndex = 16;
            this.lblBonesSet.Text = "0/0";
            // 
            // lblOffsetsSet
            // 
            this.lblOffsetsSet.AutoSize = true;
            this.lblOffsetsSet.BackColor = System.Drawing.Color.Transparent;
            this.lblOffsetsSet.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffsetsSet.ForeColor = System.Drawing.Color.White;
            this.lblOffsetsSet.Location = new System.Drawing.Point(133, 13);
            this.lblOffsetsSet.Name = "lblOffsetsSet";
            this.lblOffsetsSet.Size = new System.Drawing.Size(36, 19);
            this.lblOffsetsSet.TabIndex = 15;
            this.lblOffsetsSet.Text = "0/0";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.Color.Transparent;
            this.label65.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label65.Location = new System.Drawing.Point(32, 38);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(99, 19);
            this.label65.TabIndex = 14;
            this.label65.Text = "Bones Set:";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.BackColor = System.Drawing.Color.Transparent;
            this.label66.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label66.Location = new System.Drawing.Point(14, 11);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(117, 19);
            this.label66.TabIndex = 13;
            this.label66.Text = "Offsets Set:";
            // 
            // pnlOffsets
            // 
            this.pnlOffsets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlOffsets.Controls.Add(this.lbOffsets);
            this.pnlOffsets.Controls.Add(this.label1);
            this.pnlOffsets.Controls.Add(this.btnManuallyModifyOffsets);
            this.pnlOffsets.Controls.Add(this.btnChangeSelectedOffset);
            this.pnlOffsets.Controls.Add(this.cmb_scrape_offsets);
            this.pnlOffsets.Controls.Add(this.btnScrapeOffsets);
            this.pnlOffsets.Location = new System.Drawing.Point(108, 0);
            this.pnlOffsets.Name = "pnlOffsets";
            this.pnlOffsets.Size = new System.Drawing.Size(340, 270);
            this.pnlOffsets.TabIndex = 106;
            // 
            // lbOffsets
            // 
            this.lbOffsets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lbOffsets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbOffsets.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOffsets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lbOffsets.FormattingEnabled = true;
            this.lbOffsets.ItemHeight = 14;
            this.lbOffsets.Location = new System.Drawing.Point(11, 39);
            this.lbOffsets.Name = "lbOffsets";
            this.lbOffsets.Size = new System.Drawing.Size(317, 156);
            this.lbOffsets.TabIndex = 0;
            this.lbOffsets.TabStop = false;
            this.lbOffsets.DoubleClick += new System.EventHandler(this.lbOffsets_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 101;
            this.label1.Text = "Scrape:";
            // 
            // btnManuallyModifyOffsets
            // 
            this.btnManuallyModifyOffsets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnManuallyModifyOffsets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManuallyModifyOffsets.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManuallyModifyOffsets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnManuallyModifyOffsets.Location = new System.Drawing.Point(11, 236);
            this.btnManuallyModifyOffsets.Name = "btnManuallyModifyOffsets";
            this.btnManuallyModifyOffsets.Size = new System.Drawing.Size(317, 23);
            this.btnManuallyModifyOffsets.TabIndex = 105;
            this.btnManuallyModifyOffsets.Text = "Manually Modify Offsets";
            this.btnManuallyModifyOffsets.UseVisualStyleBackColor = false;
            this.btnManuallyModifyOffsets.Click += new System.EventHandler(this.btnManuallyModifyOffsets_Click);
            // 
            // btnChangeSelectedOffset
            // 
            this.btnChangeSelectedOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnChangeSelectedOffset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeSelectedOffset.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSelectedOffset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnChangeSelectedOffset.Location = new System.Drawing.Point(11, 207);
            this.btnChangeSelectedOffset.Name = "btnChangeSelectedOffset";
            this.btnChangeSelectedOffset.Size = new System.Drawing.Size(317, 23);
            this.btnChangeSelectedOffset.TabIndex = 104;
            this.btnChangeSelectedOffset.Text = "Change Selected Offset";
            this.btnChangeSelectedOffset.UseVisualStyleBackColor = false;
            this.btnChangeSelectedOffset.Click += new System.EventHandler(this.btnChangeSelectedOffset_Click);
            // 
            // cmb_scrape_offsets
            // 
            this.cmb_scrape_offsets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_scrape_offsets.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_scrape_offsets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_scrape_offsets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_scrape_offsets.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_scrape_offsets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cmb_scrape_offsets.FormattingEnabled = true;
            this.cmb_scrape_offsets.Items.AddRange(new object[] {
            "justin/offsets",
            "github/hazedumper"});
            this.cmb_scrape_offsets.Location = new System.Drawing.Point(70, 11);
            this.cmb_scrape_offsets.Name = "cmb_scrape_offsets";
            this.cmb_scrape_offsets.Size = new System.Drawing.Size(180, 21);
            this.cmb_scrape_offsets.TabIndex = 102;
            this.cmb_scrape_offsets.TabStop = false;
            this.cmb_scrape_offsets.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboDrawItem);
            // 
            // btnScrapeOffsets
            // 
            this.btnScrapeOffsets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnScrapeOffsets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScrapeOffsets.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScrapeOffsets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnScrapeOffsets.Location = new System.Drawing.Point(256, 10);
            this.btnScrapeOffsets.Name = "btnScrapeOffsets";
            this.btnScrapeOffsets.Size = new System.Drawing.Size(72, 23);
            this.btnScrapeOffsets.TabIndex = 103;
            this.btnScrapeOffsets.Text = "Go";
            this.btnScrapeOffsets.UseVisualStyleBackColor = false;
            this.btnScrapeOffsets.Click += new System.EventHandler(this.btnScrapeOffsets_Click);
            // 
            // tabValShare
            // 
            this.tabValShare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabValShare.Controls.Add(this.lblValShare);
            this.tabValShare.Location = new System.Drawing.Point(7, 181);
            this.tabValShare.Name = "tabValShare";
            this.tabValShare.Size = new System.Drawing.Size(93, 83);
            this.tabValShare.TabIndex = 3;
            // 
            // lblValShare
            // 
            this.lblValShare.AutoSize = true;
            this.lblValShare.BackColor = System.Drawing.Color.Transparent;
            this.lblValShare.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValShare.ForeColor = System.Drawing.Color.White;
            this.lblValShare.Location = new System.Drawing.Point(16, 30);
            this.lblValShare.Name = "lblValShare";
            this.lblValShare.Size = new System.Drawing.Size(60, 22);
            this.lblValShare.TabIndex = 0;
            this.lblValShare.Text = "Share";
            // 
            // pnlBones
            // 
            this.pnlBones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlBones.Controls.Add(this.lbBones);
            this.pnlBones.Controls.Add(this.label51);
            this.pnlBones.Controls.Add(this.btnManuallyModifyBones);
            this.pnlBones.Controls.Add(this.btnChangeSelectedBone);
            this.pnlBones.Controls.Add(this.cmb_scrape_bones);
            this.pnlBones.Controls.Add(this.btnScrapeBones);
            this.pnlBones.Location = new System.Drawing.Point(108, 0);
            this.pnlBones.Name = "pnlBones";
            this.pnlBones.Size = new System.Drawing.Size(340, 270);
            this.pnlBones.TabIndex = 107;
            // 
            // lbBones
            // 
            this.lbBones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lbBones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBones.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lbBones.FormattingEnabled = true;
            this.lbBones.ItemHeight = 14;
            this.lbBones.Location = new System.Drawing.Point(11, 39);
            this.lbBones.Name = "lbBones";
            this.lbBones.Size = new System.Drawing.Size(317, 156);
            this.lbBones.TabIndex = 0;
            this.lbBones.TabStop = false;
            this.lbBones.DoubleClick += new System.EventHandler(this.lbBones_DoubleClick);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.White;
            this.label51.Location = new System.Drawing.Point(8, 13);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(56, 15);
            this.label51.TabIndex = 101;
            this.label51.Text = "Scrape:";
            // 
            // btnManuallyModifyBones
            // 
            this.btnManuallyModifyBones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnManuallyModifyBones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManuallyModifyBones.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManuallyModifyBones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnManuallyModifyBones.Location = new System.Drawing.Point(11, 236);
            this.btnManuallyModifyBones.Name = "btnManuallyModifyBones";
            this.btnManuallyModifyBones.Size = new System.Drawing.Size(317, 23);
            this.btnManuallyModifyBones.TabIndex = 105;
            this.btnManuallyModifyBones.Text = "Manually Modify Bones";
            this.btnManuallyModifyBones.UseVisualStyleBackColor = false;
            this.btnManuallyModifyBones.Click += new System.EventHandler(this.btnManuallyModifyBones_Click);
            // 
            // btnChangeSelectedBone
            // 
            this.btnChangeSelectedBone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnChangeSelectedBone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeSelectedBone.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSelectedBone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnChangeSelectedBone.Location = new System.Drawing.Point(11, 207);
            this.btnChangeSelectedBone.Name = "btnChangeSelectedBone";
            this.btnChangeSelectedBone.Size = new System.Drawing.Size(317, 23);
            this.btnChangeSelectedBone.TabIndex = 104;
            this.btnChangeSelectedBone.Text = "Change Selected Bone";
            this.btnChangeSelectedBone.UseVisualStyleBackColor = false;
            this.btnChangeSelectedBone.Click += new System.EventHandler(this.btnChangeSelectedBone_Click);
            // 
            // cmb_scrape_bones
            // 
            this.cmb_scrape_bones.AutoCompleteCustomSource.AddRange(new string[] {
            "justin/bones"});
            this.cmb_scrape_bones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_scrape_bones.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_scrape_bones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_scrape_bones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_scrape_bones.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_scrape_bones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cmb_scrape_bones.FormattingEnabled = true;
            this.cmb_scrape_bones.Items.AddRange(new object[] {
            "justin/bones"});
            this.cmb_scrape_bones.Location = new System.Drawing.Point(70, 11);
            this.cmb_scrape_bones.Name = "cmb_scrape_bones";
            this.cmb_scrape_bones.Size = new System.Drawing.Size(180, 21);
            this.cmb_scrape_bones.TabIndex = 102;
            this.cmb_scrape_bones.TabStop = false;
            this.cmb_scrape_bones.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboDrawItem);
            // 
            // btnScrapeBones
            // 
            this.btnScrapeBones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnScrapeBones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScrapeBones.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScrapeBones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnScrapeBones.Location = new System.Drawing.Point(256, 10);
            this.btnScrapeBones.Name = "btnScrapeBones";
            this.btnScrapeBones.Size = new System.Drawing.Size(72, 23);
            this.btnScrapeBones.TabIndex = 103;
            this.btnScrapeBones.Text = "Go";
            this.btnScrapeBones.UseVisualStyleBackColor = false;
            this.btnScrapeBones.Click += new System.EventHandler(this.btnScrapeBones_Click);
            // 
            // tabBones
            // 
            this.tabBones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabBones.Controls.Add(this.lblBones);
            this.tabBones.Location = new System.Drawing.Point(7, 94);
            this.tabBones.Name = "tabBones";
            this.tabBones.Size = new System.Drawing.Size(93, 83);
            this.tabBones.TabIndex = 2;
            // 
            // lblBones
            // 
            this.lblBones.AutoSize = true;
            this.lblBones.BackColor = System.Drawing.Color.Transparent;
            this.lblBones.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBones.ForeColor = System.Drawing.Color.White;
            this.lblBones.Location = new System.Drawing.Point(16, 30);
            this.lblBones.Name = "lblBones";
            this.lblBones.Size = new System.Drawing.Size(60, 22);
            this.lblBones.TabIndex = 0;
            this.lblBones.Text = "Bones";
            // 
            // tabOffsets
            // 
            this.tabOffsets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabOffsets.Controls.Add(this.lblOffsets);
            this.tabOffsets.Location = new System.Drawing.Point(7, 7);
            this.tabOffsets.Name = "tabOffsets";
            this.tabOffsets.Size = new System.Drawing.Size(93, 83);
            this.tabOffsets.TabIndex = 1;
            // 
            // lblOffsets
            // 
            this.lblOffsets.AutoSize = true;
            this.lblOffsets.BackColor = System.Drawing.Color.Transparent;
            this.lblOffsets.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffsets.ForeColor = System.Drawing.Color.White;
            this.lblOffsets.Location = new System.Drawing.Point(7, 30);
            this.lblOffsets.Name = "lblOffsets";
            this.lblOffsets.Size = new System.Drawing.Size(80, 22);
            this.lblOffsets.TabIndex = 0;
            this.lblOffsets.Text = "Offsets";
            // 
            // pnlTriggerbot
            // 
            this.pnlTriggerbot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlTriggerbot.Controls.Add(this.pnlTrigger1);
            this.pnlTriggerbot.Controls.Add(this.pnlTrigger2);
            this.pnlTriggerbot.Controls.Add(this.label2);
            this.pnlTriggerbot.Controls.Add(this.nud_trigger_thread_delay);
            this.pnlTriggerbot.Controls.Add(this.label27);
            this.pnlTriggerbot.Controls.Add(this.cb_trigger_enabled);
            this.pnlTriggerbot.Controls.Add(this.label28);
            this.pnlTriggerbot.Controls.Add(this.panel5);
            this.pnlTriggerbot.Location = new System.Drawing.Point(154, 12);
            this.pnlTriggerbot.Name = "pnlTriggerbot";
            this.pnlTriggerbot.Size = new System.Drawing.Size(448, 270);
            this.pnlTriggerbot.TabIndex = 6;
            // 
            // pnlTrigger1
            // 
            this.pnlTrigger1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlTrigger1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTrigger1.Controls.Add(this.lblCustomizeTriggerMagnetic);
            this.pnlTrigger1.Controls.Add(this.cb_trigger_magnetic);
            this.pnlTrigger1.Controls.Add(this.label60);
            this.pnlTrigger1.Controls.Add(this.label7);
            this.pnlTrigger1.Controls.Add(this.cb_trigger_shoot_enemies);
            this.pnlTrigger1.Controls.Add(this.txt_trigger_key);
            this.pnlTrigger1.Controls.Add(this.label13);
            this.pnlTrigger1.Controls.Add(this.cb_trigger_shoot_teammates);
            this.pnlTrigger1.Controls.Add(this.label12);
            this.pnlTrigger1.Controls.Add(this.label6);
            this.pnlTrigger1.Controls.Add(this.label10);
            this.pnlTrigger1.Controls.Add(this.cb_trigger_onkey);
            this.pnlTrigger1.Controls.Add(this.nud_trigger_overshoot);
            this.pnlTrigger1.Controls.Add(this.label8);
            this.pnlTrigger1.Controls.Add(this.label11);
            this.pnlTrigger1.Controls.Add(this.nud_trigger_delay);
            this.pnlTrigger1.Controls.Add(this.label9);
            this.pnlTrigger1.Location = new System.Drawing.Point(65, 89);
            this.pnlTrigger1.Name = "pnlTrigger1";
            this.pnlTrigger1.Size = new System.Drawing.Size(319, 166);
            this.pnlTrigger1.TabIndex = 19;
            // 
            // lblCustomizeTriggerMagnetic
            // 
            this.lblCustomizeTriggerMagnetic.AutoSize = true;
            this.lblCustomizeTriggerMagnetic.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomizeTriggerMagnetic.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomizeTriggerMagnetic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblCustomizeTriggerMagnetic.Location = new System.Drawing.Point(133, 145);
            this.lblCustomizeTriggerMagnetic.Name = "lblCustomizeTriggerMagnetic";
            this.lblCustomizeTriggerMagnetic.Size = new System.Drawing.Size(73, 13);
            this.lblCustomizeTriggerMagnetic.TabIndex = 107;
            this.lblCustomizeTriggerMagnetic.Text = "[CUSTOMIZE]";
            this.lblCustomizeTriggerMagnetic.Visible = false;
            this.lblCustomizeTriggerMagnetic.Click += new System.EventHandler(this.lblCustomizeTriggerMagnetic_Click);
            // 
            // cb_trigger_magnetic
            // 
            this.cb_trigger_magnetic.AutoSize = true;
            this.cb_trigger_magnetic.Location = new System.Drawing.Point(117, 145);
            this.cb_trigger_magnetic.Name = "cb_trigger_magnetic";
            this.cb_trigger_magnetic.Size = new System.Drawing.Size(15, 14);
            this.cb_trigger_magnetic.TabIndex = 19;
            this.cb_trigger_magnetic.UseVisualStyleBackColor = true;
            this.cb_trigger_magnetic.CheckedChanged += new System.EventHandler(this.cb_trigger_magnetic_CheckedChanged);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.White;
            this.label60.Location = new System.Drawing.Point(57, 145);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(55, 13);
            this.label60.TabIndex = 18;
            this.label60.Text = "Magnetic";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(68, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "On Key";
            // 
            // cb_trigger_shoot_enemies
            // 
            this.cb_trigger_shoot_enemies.AutoSize = true;
            this.cb_trigger_shoot_enemies.Location = new System.Drawing.Point(117, 126);
            this.cb_trigger_shoot_enemies.Name = "cb_trigger_shoot_enemies";
            this.cb_trigger_shoot_enemies.Size = new System.Drawing.Size(15, 14);
            this.cb_trigger_shoot_enemies.TabIndex = 17;
            this.cb_trigger_shoot_enemies.UseVisualStyleBackColor = true;
            // 
            // txt_trigger_key
            // 
            this.txt_trigger_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_trigger_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_trigger_key.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_trigger_key.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trigger_key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txt_trigger_key.Location = new System.Drawing.Point(118, 26);
            this.txt_trigger_key.Name = "txt_trigger_key";
            this.txt_trigger_key.ReadOnly = true;
            this.txt_trigger_key.ShortcutsEnabled = false;
            this.txt_trigger_key.Size = new System.Drawing.Size(130, 20);
            this.txt_trigger_key.TabIndex = 2;
            this.txt_trigger_key.TabStop = false;
            this.txt_trigger_key.Text = "Mouse 5 [0x6]";
            this.txt_trigger_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_trigger_key.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTriggerKey_MouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(26, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Shoot Enemies\r\n";
            // 
            // cb_trigger_shoot_teammates
            // 
            this.cb_trigger_shoot_teammates.AutoSize = true;
            this.cb_trigger_shoot_teammates.Location = new System.Drawing.Point(117, 107);
            this.cb_trigger_shoot_teammates.Name = "cb_trigger_shoot_teammates";
            this.cb_trigger_shoot_teammates.Size = new System.Drawing.Size(15, 14);
            this.cb_trigger_shoot_teammates.TabIndex = 15;
            this.cb_trigger_shoot_teammates.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(15, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Shoot Teammates";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(87, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Key";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(254, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "(ms)";
            // 
            // cb_trigger_onkey
            // 
            this.cb_trigger_onkey.AutoSize = true;
            this.cb_trigger_onkey.Location = new System.Drawing.Point(117, 6);
            this.cb_trigger_onkey.Name = "cb_trigger_onkey";
            this.cb_trigger_onkey.Size = new System.Drawing.Size(15, 14);
            this.cb_trigger_onkey.TabIndex = 7;
            this.cb_trigger_onkey.UseVisualStyleBackColor = true;
            // 
            // nud_trigger_overshoot
            // 
            this.nud_trigger_overshoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_trigger_overshoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_trigger_overshoot.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_trigger_overshoot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nud_trigger_overshoot.Location = new System.Drawing.Point(118, 81);
            this.nud_trigger_overshoot.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_trigger_overshoot.Name = "nud_trigger_overshoot";
            this.nud_trigger_overshoot.Size = new System.Drawing.Size(130, 20);
            this.nud_trigger_overshoot.TabIndex = 12;
            this.nud_trigger_overshoot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(75, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Delay";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(51, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Overshoot";
            // 
            // nud_trigger_delay
            // 
            this.nud_trigger_delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_trigger_delay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_trigger_delay.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_trigger_delay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nud_trigger_delay.Location = new System.Drawing.Point(118, 53);
            this.nud_trigger_delay.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nud_trigger_delay.Name = "nud_trigger_delay";
            this.nud_trigger_delay.Size = new System.Drawing.Size(130, 20);
            this.nud_trigger_delay.TabIndex = 9;
            this.nud_trigger_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(254, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "(ms)";
            // 
            // pnlTrigger2
            // 
            this.pnlTrigger2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlTrigger2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTrigger2.Controls.Add(this.cmb_trigger_magnet_bone);
            this.pnlTrigger2.Controls.Add(this.label62);
            this.pnlTrigger2.Controls.Add(this.nud_trigger_magnet_smooth);
            this.pnlTrigger2.Controls.Add(this.label63);
            this.pnlTrigger2.Controls.Add(this.label64);
            this.pnlTrigger2.Controls.Add(this.nud_trigger_magnet_fov);
            this.pnlTrigger2.Controls.Add(this.label61);
            this.pnlTrigger2.Controls.Add(this.lblBackToTrigger);
            this.pnlTrigger2.Location = new System.Drawing.Point(65, 89);
            this.pnlTrigger2.Name = "pnlTrigger2";
            this.pnlTrigger2.Size = new System.Drawing.Size(319, 166);
            this.pnlTrigger2.TabIndex = 108;
            // 
            // cmb_trigger_magnet_bone
            // 
            this.cmb_trigger_magnet_bone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_trigger_magnet_bone.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_trigger_magnet_bone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_trigger_magnet_bone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_trigger_magnet_bone.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_trigger_magnet_bone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cmb_trigger_magnet_bone.FormattingEnabled = true;
            this.cmb_trigger_magnet_bone.Items.AddRange(new object[] {
            "head",
            "neck",
            "upper chest",
            "middle chest",
            "lower chest"});
            this.cmb_trigger_magnet_bone.Location = new System.Drawing.Point(121, 56);
            this.cmb_trigger_magnet_bone.Name = "cmb_trigger_magnet_bone";
            this.cmb_trigger_magnet_bone.Size = new System.Drawing.Size(131, 21);
            this.cmb_trigger_magnet_bone.TabIndex = 115;
            this.cmb_trigger_magnet_bone.TabStop = false;
            this.cmb_trigger_magnet_bone.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboDrawItem);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.Color.White;
            this.label62.Location = new System.Drawing.Point(65, 58);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(49, 15);
            this.label62.TabIndex = 114;
            this.label62.Text = "Target";
            // 
            // nud_trigger_magnet_smooth
            // 
            this.nud_trigger_magnet_smooth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_trigger_magnet_smooth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_trigger_magnet_smooth.DecimalPlaces = 1;
            this.nud_trigger_magnet_smooth.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_trigger_magnet_smooth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nud_trigger_magnet_smooth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_trigger_magnet_smooth.Location = new System.Drawing.Point(121, 107);
            this.nud_trigger_magnet_smooth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_trigger_magnet_smooth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nud_trigger_magnet_smooth.Name = "nud_trigger_magnet_smooth";
            this.nud_trigger_magnet_smooth.Size = new System.Drawing.Size(131, 20);
            this.nud_trigger_magnet_smooth.TabIndex = 113;
            this.nud_trigger_magnet_smooth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_trigger_magnet_smooth.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.White;
            this.label63.Location = new System.Drawing.Point(90, 86);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(25, 13);
            this.label63.TabIndex = 110;
            this.label63.Text = "FOV";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.White;
            this.label64.Location = new System.Drawing.Point(72, 111);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(43, 13);
            this.label64.TabIndex = 112;
            this.label64.Text = "Smooth";
            // 
            // nud_trigger_magnet_fov
            // 
            this.nud_trigger_magnet_fov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_trigger_magnet_fov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_trigger_magnet_fov.DecimalPlaces = 1;
            this.nud_trigger_magnet_fov.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_trigger_magnet_fov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nud_trigger_magnet_fov.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_trigger_magnet_fov.Location = new System.Drawing.Point(121, 82);
            this.nud_trigger_magnet_fov.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.nud_trigger_magnet_fov.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_trigger_magnet_fov.Name = "nud_trigger_magnet_fov";
            this.nud_trigger_magnet_fov.Size = new System.Drawing.Size(131, 20);
            this.nud_trigger_magnet_fov.TabIndex = 111;
            this.nud_trigger_magnet_fov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_trigger_magnet_fov.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.Transparent;
            this.label61.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label61.Location = new System.Drawing.Point(86, 29);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(144, 19);
            this.label61.TabIndex = 109;
            this.label61.Text = "Magnet Settings";
            // 
            // lblBackToTrigger
            // 
            this.lblBackToTrigger.AutoSize = true;
            this.lblBackToTrigger.BackColor = System.Drawing.Color.Transparent;
            this.lblBackToTrigger.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackToTrigger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblBackToTrigger.Location = new System.Drawing.Point(5, 5);
            this.lblBackToTrigger.Name = "lblBackToTrigger";
            this.lblBackToTrigger.Size = new System.Drawing.Size(43, 13);
            this.lblBackToTrigger.TabIndex = 108;
            this.lblBackToTrigger.Text = "[BACK]";
            this.lblBackToTrigger.Click += new System.EventHandler(this.lblBackToTrigger_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(230, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "(ms)";
            // 
            // nud_trigger_thread_delay
            // 
            this.nud_trigger_thread_delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_trigger_thread_delay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_trigger_thread_delay.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_trigger_thread_delay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nud_trigger_thread_delay.Location = new System.Drawing.Point(144, 27);
            this.nud_trigger_thread_delay.Name = "nud_trigger_thread_delay";
            this.nud_trigger_thread_delay.Size = new System.Drawing.Size(80, 20);
            this.nud_trigger_thread_delay.TabIndex = 23;
            this.nud_trigger_thread_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_trigger_thread_delay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(59, 31);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(79, 13);
            this.label27.TabIndex = 22;
            this.label27.Text = "Thread Delay";
            // 
            // cb_trigger_enabled
            // 
            this.cb_trigger_enabled.AutoSize = true;
            this.cb_trigger_enabled.Location = new System.Drawing.Point(114, 12);
            this.cb_trigger_enabled.Name = "cb_trigger_enabled";
            this.cb_trigger_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_trigger_enabled.TabIndex = 21;
            this.cb_trigger_enabled.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(59, 12);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(49, 13);
            this.label28.TabIndex = 20;
            this.label28.Text = "Enabled";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.cmb_triggerbot_type);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Location = new System.Drawing.Point(65, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 32);
            this.panel5.TabIndex = 18;
            // 
            // cmb_triggerbot_type
            // 
            this.cmb_triggerbot_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_triggerbot_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_triggerbot_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_triggerbot_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_triggerbot_type.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_triggerbot_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cmb_triggerbot_type.FormattingEnabled = true;
            this.cmb_triggerbot_type.Items.AddRange(new object[] {
            "general",
            "pistols",
            "snipers"});
            this.cmb_triggerbot_type.Location = new System.Drawing.Point(150, 3);
            this.cmb_triggerbot_type.Name = "cmb_triggerbot_type";
            this.cmb_triggerbot_type.Size = new System.Drawing.Size(131, 21);
            this.cmb_triggerbot_type.TabIndex = 106;
            this.cmb_triggerbot_type.TabStop = false;
            this.cmb_triggerbot_type.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboDrawItem);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label19.Location = new System.Drawing.Point(34, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 22);
            this.label19.TabIndex = 0;
            this.label19.Text = "Triggerbot";
            // 
            // pnlVisuals
            // 
            this.pnlVisuals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlVisuals.Controls.Add(this.label26);
            this.pnlVisuals.Controls.Add(this.nud_visuals_thread_delay);
            this.pnlVisuals.Controls.Add(this.label22);
            this.pnlVisuals.Controls.Add(this.panel3);
            this.pnlVisuals.Controls.Add(this.panel4);
            this.pnlVisuals.Controls.Add(this.panel2);
            this.pnlVisuals.Controls.Add(this.panel1);
            this.pnlVisuals.Controls.Add(this.cb_visuals_enabled);
            this.pnlVisuals.Controls.Add(this.label3);
            this.pnlVisuals.Location = new System.Drawing.Point(154, 12);
            this.pnlVisuals.Name = "pnlVisuals";
            this.pnlVisuals.Size = new System.Drawing.Size(448, 270);
            this.pnlVisuals.TabIndex = 6;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(192, 33);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(31, 13);
            this.label26.TabIndex = 18;
            this.label26.Text = "(ms)";
            // 
            // nud_visuals_thread_delay
            // 
            this.nud_visuals_thread_delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_visuals_thread_delay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_visuals_thread_delay.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_visuals_thread_delay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nud_visuals_thread_delay.Location = new System.Drawing.Point(106, 31);
            this.nud_visuals_thread_delay.Name = "nud_visuals_thread_delay";
            this.nud_visuals_thread_delay.Size = new System.Drawing.Size(80, 20);
            this.nud_visuals_thread_delay.TabIndex = 17;
            this.nud_visuals_thread_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_visuals_thread_delay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(21, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "Thread Delay";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.cb_visuals_enemies_healthbased);
            this.panel3.Controls.Add(this.nud_visuals_enemies_glowalpha);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.lbl_visuals_enemies_color);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.cb_visuals_enemies_visibleonly);
            this.panel3.Controls.Add(this.label80);
            this.panel3.Controls.Add(this.cb_visuals_enemies_enabled);
            this.panel3.Controls.Add(this.label81);
            this.panel3.Location = new System.Drawing.Point(227, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 164);
            this.panel3.TabIndex = 15;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(29, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "Glow Color";
            // 
            // cb_visuals_enemies_healthbased
            // 
            this.cb_visuals_enemies_healthbased.AutoSize = true;
            this.cb_visuals_enemies_healthbased.Location = new System.Drawing.Point(102, 71);
            this.cb_visuals_enemies_healthbased.Name = "cb_visuals_enemies_healthbased";
            this.cb_visuals_enemies_healthbased.Size = new System.Drawing.Size(15, 14);
            this.cb_visuals_enemies_healthbased.TabIndex = 26;
            this.cb_visuals_enemies_healthbased.UseVisualStyleBackColor = true;
            // 
            // nud_visuals_enemies_glowalpha
            // 
            this.nud_visuals_enemies_glowalpha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_visuals_enemies_glowalpha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_visuals_enemies_glowalpha.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_visuals_enemies_glowalpha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nud_visuals_enemies_glowalpha.Location = new System.Drawing.Point(102, 116);
            this.nud_visuals_enemies_glowalpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_visuals_enemies_glowalpha.Name = "nud_visuals_enemies_glowalpha";
            this.nud_visuals_enemies_glowalpha.Size = new System.Drawing.Size(80, 20);
            this.nud_visuals_enemies_glowalpha.TabIndex = 25;
            this.nud_visuals_enemies_glowalpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_visuals_enemies_glowalpha.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(29, 120);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "Glow Alpha";
            // 
            // lbl_visuals_enemies_color
            // 
            this.lbl_visuals_enemies_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_visuals_enemies_color.Location = new System.Drawing.Point(103, 94);
            this.lbl_visuals_enemies_color.Name = "lbl_visuals_enemies_color";
            this.lbl_visuals_enemies_color.Size = new System.Drawing.Size(12, 12);
            this.lbl_visuals_enemies_color.TabIndex = 23;
            this.lbl_visuals_enemies_color.Click += new System.EventHandler(this.cb_visuals_enemies_color_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(17, 71);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(79, 13);
            this.label25.TabIndex = 22;
            this.label25.Text = "Health Based";
            // 
            // cb_visuals_enemies_visibleonly
            // 
            this.cb_visuals_enemies_visibleonly.AutoSize = true;
            this.cb_visuals_enemies_visibleonly.Location = new System.Drawing.Point(102, 49);
            this.cb_visuals_enemies_visibleonly.Name = "cb_visuals_enemies_visibleonly";
            this.cb_visuals_enemies_visibleonly.Size = new System.Drawing.Size(15, 14);
            this.cb_visuals_enemies_visibleonly.TabIndex = 21;
            this.cb_visuals_enemies_visibleonly.UseVisualStyleBackColor = true;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.ForeColor = System.Drawing.Color.White;
            this.label80.Location = new System.Drawing.Point(17, 49);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(79, 13);
            this.label80.TabIndex = 20;
            this.label80.Text = "Visible Only";
            // 
            // cb_visuals_enemies_enabled
            // 
            this.cb_visuals_enemies_enabled.AutoSize = true;
            this.cb_visuals_enemies_enabled.Location = new System.Drawing.Point(102, 26);
            this.cb_visuals_enemies_enabled.Name = "cb_visuals_enemies_enabled";
            this.cb_visuals_enemies_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_visuals_enemies_enabled.TabIndex = 19;
            this.cb_visuals_enemies_enabled.UseVisualStyleBackColor = true;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.ForeColor = System.Drawing.Color.White;
            this.label81.Location = new System.Drawing.Point(47, 26);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(49, 13);
            this.label81.TabIndex = 18;
            this.label81.Text = "Enabled";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(227, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 32);
            this.panel4.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label15.Location = new System.Drawing.Point(60, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 22);
            this.label15.TabIndex = 0;
            this.label15.Text = "Enemies";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(21, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 32);
            this.panel2.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(50, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "Teammates";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label59);
            this.panel1.Controls.Add(this.cb_visuals_teammates_healthbased);
            this.panel1.Controls.Add(this.nud_visuals_teammates_glowalpha);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.lbl_visuals_teammates_color);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.cb_visuals_teammates_visibleonly);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.cb_visuals_teammates_enabled);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(21, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 164);
            this.panel1.TabIndex = 7;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.White;
            this.label59.Location = new System.Drawing.Point(29, 94);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(67, 13);
            this.label59.TabIndex = 17;
            this.label59.Text = "Glow Color";
            // 
            // cb_visuals_teammates_healthbased
            // 
            this.cb_visuals_teammates_healthbased.AutoSize = true;
            this.cb_visuals_teammates_healthbased.Location = new System.Drawing.Point(102, 71);
            this.cb_visuals_teammates_healthbased.Name = "cb_visuals_teammates_healthbased";
            this.cb_visuals_teammates_healthbased.Size = new System.Drawing.Size(15, 14);
            this.cb_visuals_teammates_healthbased.TabIndex = 16;
            this.cb_visuals_teammates_healthbased.UseVisualStyleBackColor = true;
            // 
            // nud_visuals_teammates_glowalpha
            // 
            this.nud_visuals_teammates_glowalpha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_visuals_teammates_glowalpha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_visuals_teammates_glowalpha.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_visuals_teammates_glowalpha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nud_visuals_teammates_glowalpha.Location = new System.Drawing.Point(102, 116);
            this.nud_visuals_teammates_glowalpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_visuals_teammates_glowalpha.Name = "nud_visuals_teammates_glowalpha";
            this.nud_visuals_teammates_glowalpha.Size = new System.Drawing.Size(80, 20);
            this.nud_visuals_teammates_glowalpha.TabIndex = 14;
            this.nud_visuals_teammates_glowalpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_visuals_teammates_glowalpha.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(29, 120);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "Glow Alpha";
            // 
            // lbl_visuals_teammates_color
            // 
            this.lbl_visuals_teammates_color.BackColor = System.Drawing.Color.Lime;
            this.lbl_visuals_teammates_color.Location = new System.Drawing.Point(103, 94);
            this.lbl_visuals_teammates_color.Name = "lbl_visuals_teammates_color";
            this.lbl_visuals_teammates_color.Size = new System.Drawing.Size(12, 12);
            this.lbl_visuals_teammates_color.TabIndex = 12;
            this.lbl_visuals_teammates_color.Click += new System.EventHandler(this.cb_visuals_teammates_color_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(17, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Health Based";
            // 
            // cb_visuals_teammates_visibleonly
            // 
            this.cb_visuals_teammates_visibleonly.AutoSize = true;
            this.cb_visuals_teammates_visibleonly.Location = new System.Drawing.Point(102, 49);
            this.cb_visuals_teammates_visibleonly.Name = "cb_visuals_teammates_visibleonly";
            this.cb_visuals_teammates_visibleonly.Size = new System.Drawing.Size(15, 14);
            this.cb_visuals_teammates_visibleonly.TabIndex = 10;
            this.cb_visuals_teammates_visibleonly.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(17, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Visible Only";
            // 
            // cb_visuals_teammates_enabled
            // 
            this.cb_visuals_teammates_enabled.AutoSize = true;
            this.cb_visuals_teammates_enabled.Location = new System.Drawing.Point(102, 26);
            this.cb_visuals_teammates_enabled.Name = "cb_visuals_teammates_enabled";
            this.cb_visuals_teammates_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_visuals_teammates_enabled.TabIndex = 8;
            this.cb_visuals_teammates_enabled.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(47, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Enabled";
            // 
            // cb_visuals_enabled
            // 
            this.cb_visuals_enabled.AutoSize = true;
            this.cb_visuals_enabled.Location = new System.Drawing.Point(76, 15);
            this.cb_visuals_enabled.Name = "cb_visuals_enabled";
            this.cb_visuals_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_visuals_enabled.TabIndex = 6;
            this.cb_visuals_enabled.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enabled";
            // 
            // pnlMisc
            // 
            this.pnlMisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlMisc.Controls.Add(this.pnlFeatures);
            this.pnlMisc.Controls.Add(this.pnlAccount);
            this.pnlMisc.Controls.Add(this.pnlConfig);
            this.pnlMisc.Controls.Add(this.tabConfig);
            this.pnlMisc.Controls.Add(this.tabAccount);
            this.pnlMisc.Controls.Add(this.tabFeatures);
            this.pnlMisc.Location = new System.Drawing.Point(154, 12);
            this.pnlMisc.Name = "pnlMisc";
            this.pnlMisc.Size = new System.Drawing.Size(448, 270);
            this.pnlMisc.TabIndex = 6;
            // 
            // pnlFeatures
            // 
            this.pnlFeatures.Controls.Add(this.cb_skinchanger_enabled);
            this.pnlFeatures.Controls.Add(this.label24);
            this.pnlFeatures.Controls.Add(this.label57);
            this.pnlFeatures.Controls.Add(this.nud_fov_changer);
            this.pnlFeatures.Controls.Add(this.label58);
            this.pnlFeatures.Controls.Add(this.cb_fov_changer);
            this.pnlFeatures.Controls.Add(this.label29);
            this.pnlFeatures.Controls.Add(this.label35);
            this.pnlFeatures.Controls.Add(this.cb_rcs_enabled);
            this.pnlFeatures.Controls.Add(this.nud_rcs_x_percent);
            this.pnlFeatures.Controls.Add(this.cmb_obfuscation_preset);
            this.pnlFeatures.Controls.Add(this.label34);
            this.pnlFeatures.Controls.Add(this.label54);
            this.pnlFeatures.Controls.Add(this.label36);
            this.pnlFeatures.Controls.Add(this.cb_obfuscation_enabled);
            this.pnlFeatures.Controls.Add(this.label37);
            this.pnlFeatures.Controls.Add(this.label55);
            this.pnlFeatures.Controls.Add(this.nud_rcs_y_percent);
            this.pnlFeatures.Controls.Add(this.label33);
            this.pnlFeatures.Controls.Add(this.txt_bhop_key);
            this.pnlFeatures.Controls.Add(this.cb_radar_enabled);
            this.pnlFeatures.Controls.Add(this.label38);
            this.pnlFeatures.Controls.Add(this.label52);
            this.pnlFeatures.Controls.Add(this.label4);
            this.pnlFeatures.Controls.Add(this.label32);
            this.pnlFeatures.Controls.Add(this.label53);
            this.pnlFeatures.Controls.Add(this.label30);
            this.pnlFeatures.Controls.Add(this.cb_bhop_enabled);
            this.pnlFeatures.Controls.Add(this.nud_noflash_percent);
            this.pnlFeatures.Controls.Add(this.label31);
            this.pnlFeatures.Controls.Add(this.cb_noflash_enabled);
            this.pnlFeatures.Location = new System.Drawing.Point(0, 46);
            this.pnlFeatures.Name = "pnlFeatures";
            this.pnlFeatures.Size = new System.Drawing.Size(448, 224);
            this.pnlFeatures.TabIndex = 109;
            // 
            // cb_skinchanger_enabled
            // 
            this.cb_skinchanger_enabled.AutoSize = true;
            this.cb_skinchanger_enabled.Location = new System.Drawing.Point(329, 48);
            this.cb_skinchanger_enabled.Name = "cb_skinchanger_enabled";
            this.cb_skinchanger_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_skinchanger_enabled.TabIndex = 111;
            this.cb_skinchanger_enabled.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(246, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 13);
            this.label24.TabIndex = 110;
            this.label24.Text = "Skin Changer";
            this.tip.SetToolTip(this.label24, "FSkinChanger - by FuckFace32\r\njustInject - by ju$tin\r\nPress [HOME] in game to cha" +
        "nge keys.");
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.Color.Transparent;
            this.label57.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label57.Location = new System.Drawing.Point(245, 157);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(108, 19);
            this.label57.TabIndex = 106;
            this.label57.Text = "FOV Changer";
            // 
            // nud_fov_changer
            // 
            this.nud_fov_changer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_fov_changer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_fov_changer.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_fov_changer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nud_fov_changer.Location = new System.Drawing.Point(320, 181);
            this.nud_fov_changer.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_fov_changer.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_fov_changer.Name = "nud_fov_changer";
            this.nud_fov_changer.Size = new System.Drawing.Size(89, 20);
            this.nud_fov_changer.TabIndex = 109;
            this.nud_fov_changer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_fov_changer.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.White;
            this.label58.Location = new System.Drawing.Point(246, 184);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(49, 13);
            this.label58.TabIndex = 107;
            this.label58.Text = "Enabled";
            // 
            // cb_fov_changer
            // 
            this.cb_fov_changer.AutoSize = true;
            this.cb_fov_changer.Location = new System.Drawing.Point(299, 184);
            this.cb_fov_changer.Name = "cb_fov_changer";
            this.cb_fov_changer.Size = new System.Drawing.Size(15, 14);
            this.cb_fov_changer.TabIndex = 108;
            this.cb_fov_changer.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label29.Location = new System.Drawing.Point(8, 3);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(90, 19);
            this.label29.TabIndex = 0;
            this.label29.Text = "Bunny Hop";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(9, 83);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 13);
            this.label35.TabIndex = 9;
            this.label35.Text = "Enabled";
            // 
            // cb_rcs_enabled
            // 
            this.cb_rcs_enabled.AutoSize = true;
            this.cb_rcs_enabled.Location = new System.Drawing.Point(62, 83);
            this.cb_rcs_enabled.Name = "cb_rcs_enabled";
            this.cb_rcs_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_rcs_enabled.TabIndex = 10;
            this.cb_rcs_enabled.UseVisualStyleBackColor = true;
            // 
            // nud_rcs_x_percent
            // 
            this.nud_rcs_x_percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_rcs_x_percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_rcs_x_percent.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_rcs_x_percent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nud_rcs_x_percent.Location = new System.Drawing.Point(85, 102);
            this.nud_rcs_x_percent.Name = "nud_rcs_x_percent";
            this.nud_rcs_x_percent.Size = new System.Drawing.Size(89, 20);
            this.nud_rcs_x_percent.TabIndex = 11;
            this.nud_rcs_x_percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_rcs_x_percent.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // cmb_obfuscation_preset
            // 
            this.cmb_obfuscation_preset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_obfuscation_preset.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_obfuscation_preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_obfuscation_preset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_obfuscation_preset.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_obfuscation_preset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cmb_obfuscation_preset.FormattingEnabled = true;
            this.cmb_obfuscation_preset.Items.AddRange(new object[] {
            "maximum",
            "aggressive",
            "normal",
            "minimum"});
            this.cmb_obfuscation_preset.Location = new System.Drawing.Point(249, 120);
            this.cmb_obfuscation_preset.Name = "cmb_obfuscation_preset";
            this.cmb_obfuscation_preset.Size = new System.Drawing.Size(150, 21);
            this.cmb_obfuscation_preset.TabIndex = 105;
            this.cmb_obfuscation_preset.TabStop = false;
            this.cmb_obfuscation_preset.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboDrawItem);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(178, 105);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(25, 13);
            this.label34.TabIndex = 24;
            this.label34.Text = "(%)";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.Transparent;
            this.label54.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label54.Location = new System.Drawing.Point(245, 75);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(108, 19);
            this.label54.TabIndex = 33;
            this.label54.Text = "Obfuscation";
            this.tip.SetToolTip(this.label54, "Obfuscation provided by ConfuserEx.");
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(20, 106);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(61, 13);
            this.label36.TabIndex = 25;
            this.label36.Text = "Adjust X:";
            // 
            // cb_obfuscation_enabled
            // 
            this.cb_obfuscation_enabled.AutoSize = true;
            this.cb_obfuscation_enabled.Checked = true;
            this.cb_obfuscation_enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_obfuscation_enabled.Location = new System.Drawing.Point(299, 100);
            this.cb_obfuscation_enabled.Name = "cb_obfuscation_enabled";
            this.cb_obfuscation_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_obfuscation_enabled.TabIndex = 35;
            this.tip.SetToolTip(this.cb_obfuscation_enabled, "This feature is currently required.");
            this.cb_obfuscation_enabled.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(20, 132);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(61, 13);
            this.label37.TabIndex = 26;
            this.label37.Text = "Adjust Y:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.White;
            this.label55.Location = new System.Drawing.Point(246, 100);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(49, 13);
            this.label55.TabIndex = 34;
            this.label55.Text = "Enabled";
            // 
            // nud_rcs_y_percent
            // 
            this.nud_rcs_y_percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_rcs_y_percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_rcs_y_percent.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_rcs_y_percent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nud_rcs_y_percent.Location = new System.Drawing.Point(85, 128);
            this.nud_rcs_y_percent.Name = "nud_rcs_y_percent";
            this.nud_rcs_y_percent.Size = new System.Drawing.Size(89, 20);
            this.nud_rcs_y_percent.TabIndex = 27;
            this.nud_rcs_y_percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_rcs_y_percent.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label33.Location = new System.Drawing.Point(245, 3);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(63, 19);
            this.label33.TabIndex = 30;
            this.label33.Text = "Random";
            // 
            // txt_bhop_key
            // 
            this.txt_bhop_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_bhop_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bhop_key.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_bhop_key.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bhop_key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txt_bhop_key.Location = new System.Drawing.Point(83, 25);
            this.txt_bhop_key.Name = "txt_bhop_key";
            this.txt_bhop_key.ReadOnly = true;
            this.txt_bhop_key.ShortcutsEnabled = false;
            this.txt_bhop_key.Size = new System.Drawing.Size(120, 20);
            this.txt_bhop_key.TabIndex = 3;
            this.txt_bhop_key.TabStop = false;
            this.txt_bhop_key.Text = "Space [0x20]";
            this.txt_bhop_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_bhop_key.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBhopKey_MouseClick);
            // 
            // cb_radar_enabled
            // 
            this.cb_radar_enabled.AutoSize = true;
            this.cb_radar_enabled.Location = new System.Drawing.Point(287, 28);
            this.cb_radar_enabled.Name = "cb_radar_enabled";
            this.cb_radar_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_radar_enabled.TabIndex = 32;
            this.cb_radar_enabled.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(178, 131);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(25, 13);
            this.label38.TabIndex = 28;
            this.label38.Text = "(%)";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(246, 28);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(37, 13);
            this.label52.TabIndex = 31;
            this.label52.Text = "Radar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enabled";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(175, 186);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(25, 13);
            this.label32.TabIndex = 24;
            this.label32.Text = "(%)";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label53.Location = new System.Drawing.Point(8, 58);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(135, 19);
            this.label53.TabIndex = 29;
            this.label53.Text = "Recoil Control";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label30.Location = new System.Drawing.Point(8, 161);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(81, 19);
            this.label30.TabIndex = 0;
            this.label30.Text = "No Flash";
            // 
            // cb_bhop_enabled
            // 
            this.cb_bhop_enabled.AutoSize = true;
            this.cb_bhop_enabled.Location = new System.Drawing.Point(62, 28);
            this.cb_bhop_enabled.Name = "cb_bhop_enabled";
            this.cb_bhop_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_bhop_enabled.TabIndex = 10;
            this.cb_bhop_enabled.UseVisualStyleBackColor = true;
            // 
            // nud_noflash_percent
            // 
            this.nud_noflash_percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_noflash_percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_noflash_percent.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_noflash_percent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nud_noflash_percent.Location = new System.Drawing.Point(82, 183);
            this.nud_noflash_percent.Name = "nud_noflash_percent";
            this.nud_noflash_percent.Size = new System.Drawing.Size(89, 20);
            this.nud_noflash_percent.TabIndex = 11;
            this.nud_noflash_percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_noflash_percent.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(9, 186);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(49, 13);
            this.label31.TabIndex = 9;
            this.label31.Text = "Enabled";
            // 
            // cb_noflash_enabled
            // 
            this.cb_noflash_enabled.AutoSize = true;
            this.cb_noflash_enabled.Location = new System.Drawing.Point(62, 186);
            this.cb_noflash_enabled.Name = "cb_noflash_enabled";
            this.cb_noflash_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_noflash_enabled.TabIndex = 10;
            this.cb_noflash_enabled.UseVisualStyleBackColor = true;
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.lblRemoveAds);
            this.pnlAccount.Controls.Add(this.lblAdvertisements);
            this.pnlAccount.Controls.Add(this.lblLoggedIn);
            this.pnlAccount.Controls.Add(this.btnLogout);
            this.pnlAccount.Controls.Add(this.lblPreAdvertisements);
            this.pnlAccount.Controls.Add(this.lblPreLoggedIn);
            this.pnlAccount.Location = new System.Drawing.Point(0, 46);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(448, 224);
            this.pnlAccount.TabIndex = 109;
            // 
            // lblRemoveAds
            // 
            this.lblRemoveAds.AutoSize = true;
            this.lblRemoveAds.BackColor = System.Drawing.Color.Transparent;
            this.lblRemoveAds.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveAds.ForeColor = System.Drawing.Color.White;
            this.lblRemoveAds.Location = new System.Drawing.Point(187, 48);
            this.lblRemoveAds.Name = "lblRemoveAds";
            this.lblRemoveAds.Size = new System.Drawing.Size(55, 13);
            this.lblRemoveAds.TabIndex = 9;
            this.lblRemoveAds.Text = "[REMOVE]";
            this.lblRemoveAds.Click += new System.EventHandler(this.lblRemoveAds_Click);
            // 
            // lblAdvertisements
            // 
            this.lblAdvertisements.AutoSize = true;
            this.lblAdvertisements.BackColor = System.Drawing.Color.Transparent;
            this.lblAdvertisements.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertisements.ForeColor = System.Drawing.Color.White;
            this.lblAdvertisements.Location = new System.Drawing.Point(167, 45);
            this.lblAdvertisements.Name = "lblAdvertisements";
            this.lblAdvertisements.Size = new System.Drawing.Size(18, 19);
            this.lblAdvertisements.TabIndex = 8;
            this.lblAdvertisements.Text = "-";
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.BackColor = System.Drawing.Color.Transparent;
            this.lblLoggedIn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedIn.ForeColor = System.Drawing.Color.White;
            this.lblLoggedIn.Location = new System.Drawing.Point(121, 15);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(18, 19);
            this.lblLoggedIn.TabIndex = 7;
            this.lblLoggedIn.Text = "-";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnLogout.Location = new System.Drawing.Point(24, 76);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(219, 27);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblPreAdvertisements
            // 
            this.lblPreAdvertisements.AutoSize = true;
            this.lblPreAdvertisements.BackColor = System.Drawing.Color.Transparent;
            this.lblPreAdvertisements.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreAdvertisements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblPreAdvertisements.Location = new System.Drawing.Point(23, 45);
            this.lblPreAdvertisements.Name = "lblPreAdvertisements";
            this.lblPreAdvertisements.Size = new System.Drawing.Size(144, 19);
            this.lblPreAdvertisements.TabIndex = 2;
            this.lblPreAdvertisements.Text = "Advertisements:";
            // 
            // lblPreLoggedIn
            // 
            this.lblPreLoggedIn.AutoSize = true;
            this.lblPreLoggedIn.BackColor = System.Drawing.Color.Transparent;
            this.lblPreLoggedIn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreLoggedIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblPreLoggedIn.Location = new System.Drawing.Point(23, 15);
            this.lblPreLoggedIn.Name = "lblPreLoggedIn";
            this.lblPreLoggedIn.Size = new System.Drawing.Size(99, 19);
            this.lblPreLoggedIn.TabIndex = 1;
            this.lblPreLoggedIn.Text = "Logged in:";
            // 
            // pnlConfig
            // 
            this.pnlConfig.Controls.Add(this.pnlConfigID);
            this.pnlConfig.Controls.Add(this.pnlConfigFile);
            this.pnlConfig.Controls.Add(this.label56);
            this.pnlConfig.Controls.Add(this.cmb_config_source);
            this.pnlConfig.Location = new System.Drawing.Point(0, 46);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(448, 224);
            this.pnlConfig.TabIndex = 113;
            // 
            // pnlConfigID
            // 
            this.pnlConfigID.Controls.Add(this.btnDownloadConfig);
            this.pnlConfigID.Controls.Add(this.label76);
            this.pnlConfigID.Controls.Add(this.txtDownloadConfig);
            this.pnlConfigID.Controls.Add(this.label77);
            this.pnlConfigID.Controls.Add(this.label78);
            this.pnlConfigID.Controls.Add(this.txtUploadConfig);
            this.pnlConfigID.Controls.Add(this.btnUploadConfig);
            this.pnlConfigID.Controls.Add(this.label79);
            this.pnlConfigID.Location = new System.Drawing.Point(12, 52);
            this.pnlConfigID.Name = "pnlConfigID";
            this.pnlConfigID.Size = new System.Drawing.Size(424, 146);
            this.pnlConfigID.TabIndex = 106;
            // 
            // btnDownloadConfig
            // 
            this.btnDownloadConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnDownloadConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDownloadConfig.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDownloadConfig.Location = new System.Drawing.Point(322, 103);
            this.btnDownloadConfig.Name = "btnDownloadConfig";
            this.btnDownloadConfig.Size = new System.Drawing.Size(45, 22);
            this.btnDownloadConfig.TabIndex = 35;
            this.btnDownloadConfig.Text = "Go";
            this.btnDownloadConfig.UseVisualStyleBackColor = false;
            this.btnDownloadConfig.Click += new System.EventHandler(this.btnDownloadConfig_Click);
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.BackColor = System.Drawing.Color.Transparent;
            this.label76.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.ForeColor = System.Drawing.Color.White;
            this.label76.Location = new System.Drawing.Point(58, 106);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(28, 14);
            this.label76.TabIndex = 32;
            this.label76.Text = "ID:";
            // 
            // txtDownloadConfig
            // 
            this.txtDownloadConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtDownloadConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDownloadConfig.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownloadConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtDownloadConfig.Location = new System.Drawing.Point(87, 104);
            this.txtDownloadConfig.Name = "txtDownloadConfig";
            this.txtDownloadConfig.Size = new System.Drawing.Size(229, 20);
            this.txtDownloadConfig.TabIndex = 30;
            this.txtDownloadConfig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.BackColor = System.Drawing.Color.Transparent;
            this.label77.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label77.Location = new System.Drawing.Point(57, 82);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(144, 19);
            this.label77.TabIndex = 29;
            this.label77.Text = "Download Config";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.BackColor = System.Drawing.Color.Transparent;
            this.label78.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.ForeColor = System.Drawing.Color.White;
            this.label78.Location = new System.Drawing.Point(58, 39);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(28, 14);
            this.label78.TabIndex = 28;
            this.label78.Text = "ID:";
            // 
            // txtUploadConfig
            // 
            this.txtUploadConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtUploadConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUploadConfig.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUploadConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtUploadConfig.Location = new System.Drawing.Point(87, 37);
            this.txtUploadConfig.Name = "txtUploadConfig";
            this.txtUploadConfig.ReadOnly = true;
            this.txtUploadConfig.Size = new System.Drawing.Size(229, 20);
            this.txtUploadConfig.TabIndex = 26;
            this.txtUploadConfig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUploadConfig
            // 
            this.btnUploadConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUploadConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadConfig.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnUploadConfig.Location = new System.Drawing.Point(322, 36);
            this.btnUploadConfig.Name = "btnUploadConfig";
            this.btnUploadConfig.Size = new System.Drawing.Size(45, 22);
            this.btnUploadConfig.TabIndex = 27;
            this.btnUploadConfig.Text = "Go";
            this.btnUploadConfig.UseVisualStyleBackColor = false;
            this.btnUploadConfig.Click += new System.EventHandler(this.btnUploadConfig_Click);
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.BackColor = System.Drawing.Color.Transparent;
            this.label79.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label79.Location = new System.Drawing.Point(57, 15);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(126, 19);
            this.label79.TabIndex = 25;
            this.label79.Text = "Upload Config";
            // 
            // pnlConfigFile
            // 
            this.pnlConfigFile.Controls.Add(this.btnLoadConfigFile);
            this.pnlConfigFile.Controls.Add(this.btnSelectConfigFileLoad);
            this.pnlConfigFile.Controls.Add(this.btnSaveConfigFile);
            this.pnlConfigFile.Controls.Add(this.label72);
            this.pnlConfigFile.Controls.Add(this.txtConfigFileLoad);
            this.pnlConfigFile.Controls.Add(this.label73);
            this.pnlConfigFile.Controls.Add(this.label74);
            this.pnlConfigFile.Controls.Add(this.txtConfigFileSave);
            this.pnlConfigFile.Controls.Add(this.btnSelectConfigFileSave);
            this.pnlConfigFile.Controls.Add(this.label75);
            this.pnlConfigFile.Location = new System.Drawing.Point(12, 52);
            this.pnlConfigFile.Name = "pnlConfigFile";
            this.pnlConfigFile.Size = new System.Drawing.Size(424, 146);
            this.pnlConfigFile.TabIndex = 105;
            // 
            // btnLoadConfigFile
            // 
            this.btnLoadConfigFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnLoadConfigFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadConfigFile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadConfigFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnLoadConfigFile.Location = new System.Drawing.Point(344, 102);
            this.btnLoadConfigFile.Name = "btnLoadConfigFile";
            this.btnLoadConfigFile.Size = new System.Drawing.Size(58, 24);
            this.btnLoadConfigFile.TabIndex = 36;
            this.btnLoadConfigFile.Text = "Load";
            this.btnLoadConfigFile.UseVisualStyleBackColor = false;
            this.btnLoadConfigFile.Click += new System.EventHandler(this.btnLoadConfigFile_Click);
            // 
            // btnSelectConfigFileLoad
            // 
            this.btnSelectConfigFileLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSelectConfigFileLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectConfigFileLoad.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectConfigFileLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnSelectConfigFileLoad.Location = new System.Drawing.Point(301, 103);
            this.btnSelectConfigFileLoad.Name = "btnSelectConfigFileLoad";
            this.btnSelectConfigFileLoad.Size = new System.Drawing.Size(37, 22);
            this.btnSelectConfigFileLoad.TabIndex = 35;
            this.btnSelectConfigFileLoad.Text = "...";
            this.btnSelectConfigFileLoad.UseVisualStyleBackColor = false;
            this.btnSelectConfigFileLoad.Click += new System.EventHandler(this.btnSelectConfigFileLoad_Click);
            // 
            // btnSaveConfigFile
            // 
            this.btnSaveConfigFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSaveConfigFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveConfigFile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConfigFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnSaveConfigFile.Location = new System.Drawing.Point(344, 35);
            this.btnSaveConfigFile.Name = "btnSaveConfigFile";
            this.btnSaveConfigFile.Size = new System.Drawing.Size(58, 24);
            this.btnSaveConfigFile.TabIndex = 34;
            this.btnSaveConfigFile.Text = "Save";
            this.btnSaveConfigFile.UseVisualStyleBackColor = false;
            this.btnSaveConfigFile.Click += new System.EventHandler(this.btnSaveConfigFile_Click);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.BackColor = System.Drawing.Color.Transparent;
            this.label72.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.ForeColor = System.Drawing.Color.White;
            this.label72.Location = new System.Drawing.Point(23, 107);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(42, 14);
            this.label72.TabIndex = 32;
            this.label72.Text = "File:";
            // 
            // txtConfigFileLoad
            // 
            this.txtConfigFileLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtConfigFileLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfigFileLoad.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfigFileLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtConfigFileLoad.Location = new System.Drawing.Point(66, 104);
            this.txtConfigFileLoad.Name = "txtConfigFileLoad";
            this.txtConfigFileLoad.ReadOnly = true;
            this.txtConfigFileLoad.Size = new System.Drawing.Size(229, 20);
            this.txtConfigFileLoad.TabIndex = 30;
            this.txtConfigFileLoad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.BackColor = System.Drawing.Color.Transparent;
            this.label73.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label73.Location = new System.Drawing.Point(22, 80);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(108, 19);
            this.label73.TabIndex = 29;
            this.label73.Text = "Load Config";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.BackColor = System.Drawing.Color.Transparent;
            this.label74.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.ForeColor = System.Drawing.Color.White;
            this.label74.Location = new System.Drawing.Point(23, 40);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(42, 14);
            this.label74.TabIndex = 28;
            this.label74.Text = "File:";
            // 
            // txtConfigFileSave
            // 
            this.txtConfigFileSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtConfigFileSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfigFileSave.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfigFileSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtConfigFileSave.Location = new System.Drawing.Point(66, 37);
            this.txtConfigFileSave.Name = "txtConfigFileSave";
            this.txtConfigFileSave.ReadOnly = true;
            this.txtConfigFileSave.Size = new System.Drawing.Size(229, 20);
            this.txtConfigFileSave.TabIndex = 26;
            this.txtConfigFileSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSelectConfigFileSave
            // 
            this.btnSelectConfigFileSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSelectConfigFileSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectConfigFileSave.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectConfigFileSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnSelectConfigFileSave.Location = new System.Drawing.Point(301, 36);
            this.btnSelectConfigFileSave.Name = "btnSelectConfigFileSave";
            this.btnSelectConfigFileSave.Size = new System.Drawing.Size(37, 22);
            this.btnSelectConfigFileSave.TabIndex = 27;
            this.btnSelectConfigFileSave.Text = "...";
            this.btnSelectConfigFileSave.UseVisualStyleBackColor = false;
            this.btnSelectConfigFileSave.Click += new System.EventHandler(this.btnSelectConfigFile_Click);
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.BackColor = System.Drawing.Color.Transparent;
            this.label75.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label75.Location = new System.Drawing.Point(22, 13);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(108, 19);
            this.label75.TabIndex = 25;
            this.label75.Text = "Save Config";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.White;
            this.label56.Location = new System.Drawing.Point(105, 29);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(56, 15);
            this.label56.TabIndex = 103;
            this.label56.Text = "Source:";
            // 
            // cmb_config_source
            // 
            this.cmb_config_source.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_config_source.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_config_source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_config_source.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_config_source.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_config_source.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cmb_config_source.FormattingEnabled = true;
            this.cmb_config_source.Items.AddRange(new object[] {
            "online id",
            "config file"});
            this.cmb_config_source.Location = new System.Drawing.Point(164, 26);
            this.cmb_config_source.Name = "cmb_config_source";
            this.cmb_config_source.Size = new System.Drawing.Size(180, 21);
            this.cmb_config_source.TabIndex = 104;
            this.cmb_config_source.TabStop = false;
            this.cmb_config_source.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboDrawItem);
            this.cmb_config_source.SelectedIndexChanged += new System.EventHandler(this.cmb_config_source_SelectedIndexChanged);
            // 
            // tabConfig
            // 
            this.tabConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabConfig.Controls.Add(this.lblConfig);
            this.tabConfig.Location = new System.Drawing.Point(155, 10);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Size = new System.Drawing.Size(138, 30);
            this.tabConfig.TabIndex = 112;
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.BackColor = System.Drawing.Color.Transparent;
            this.lblConfig.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfig.ForeColor = System.Drawing.Color.White;
            this.lblConfig.Location = new System.Drawing.Point(38, 5);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(63, 19);
            this.lblConfig.TabIndex = 0;
            this.lblConfig.Text = "Config";
            // 
            // tabAccount
            // 
            this.tabAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabAccount.Controls.Add(this.lblAccount);
            this.tabAccount.Location = new System.Drawing.Point(299, 10);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Size = new System.Drawing.Size(138, 30);
            this.tabAccount.TabIndex = 111;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.White;
            this.lblAccount.Location = new System.Drawing.Point(33, 5);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(72, 19);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "Account";
            // 
            // tabFeatures
            // 
            this.tabFeatures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabFeatures.Controls.Add(this.lblFeatures);
            this.tabFeatures.Location = new System.Drawing.Point(11, 10);
            this.tabFeatures.Name = "tabFeatures";
            this.tabFeatures.Size = new System.Drawing.Size(138, 30);
            this.tabFeatures.TabIndex = 110;
            // 
            // lblFeatures
            // 
            this.lblFeatures.AutoSize = true;
            this.lblFeatures.BackColor = System.Drawing.Color.Transparent;
            this.lblFeatures.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeatures.ForeColor = System.Drawing.Color.White;
            this.lblFeatures.Location = new System.Drawing.Point(29, 5);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(81, 19);
            this.lblFeatures.TabIndex = 0;
            this.lblFeatures.Text = "Features";
            // 
            // pnlCompile
            // 
            this.pnlCompile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlCompile.Controls.Add(this.panel11);
            this.pnlCompile.Controls.Add(this.btnCompile);
            this.pnlCompile.Controls.Add(this.btnSelectFile);
            this.pnlCompile.Controls.Add(this.label5);
            this.pnlCompile.Controls.Add(this.txt_build_path);
            this.pnlCompile.Location = new System.Drawing.Point(154, 12);
            this.pnlCompile.Name = "pnlCompile";
            this.pnlCompile.Size = new System.Drawing.Size(448, 270);
            this.pnlCompile.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.txtLog);
            this.panel11.Location = new System.Drawing.Point(10, 10);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(428, 193);
            this.panel11.TabIndex = 104;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(426, 191);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // btnCompile
            // 
            this.btnCompile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCompile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompile.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCompile.Location = new System.Drawing.Point(9, 239);
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(428, 21);
            this.btnCompile.TabIndex = 103;
            this.btnCompile.Text = "Compile Build";
            this.btnCompile.UseVisualStyleBackColor = false;
            this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectFile.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnSelectFile.Location = new System.Drawing.Point(391, 213);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(46, 21);
            this.btnSelectFile.TabIndex = 102;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 101;
            this.label5.Text = "Build Path:";
            // 
            // txt_build_path
            // 
            this.txt_build_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_build_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_build_path.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_build_path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txt_build_path.Location = new System.Drawing.Point(97, 213);
            this.txt_build_path.Name = "txt_build_path";
            this.txt_build_path.ReadOnly = true;
            this.txt_build_path.Size = new System.Drawing.Size(288, 20);
            this.txt_build_path.TabIndex = 2;
            this.txt_build_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sfd
            // 
            this.sfd.Filter = "*.exe |.exe";
            // 
            // txtDummy
            // 
            this.txtDummy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtDummy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDummy.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDummy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtDummy.Location = new System.Drawing.Point(-2, -26);
            this.txtDummy.Name = "txtDummy";
            this.txtDummy.ReadOnly = true;
            this.txtDummy.Size = new System.Drawing.Size(10, 20);
            this.txtDummy.TabIndex = 8;
            this.txtDummy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabAimbot
            // 
            this.tabAimbot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabAimbot.Controls.Add(this.lblAimbot);
            this.tabAimbot.Location = new System.Drawing.Point(12, 58);
            this.tabAimbot.Name = "tabAimbot";
            this.tabAimbot.Size = new System.Drawing.Size(136, 40);
            this.tabAimbot.TabIndex = 2;
            // 
            // lblAimbot
            // 
            this.lblAimbot.AutoSize = true;
            this.lblAimbot.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAimbot.ForeColor = System.Drawing.Color.White;
            this.lblAimbot.Location = new System.Drawing.Point(33, 9);
            this.lblAimbot.Name = "lblAimbot";
            this.lblAimbot.Size = new System.Drawing.Size(70, 22);
            this.lblAimbot.TabIndex = 1;
            this.lblAimbot.Text = "Aimbot";
            // 
            // pnlAimbot
            // 
            this.pnlAimbot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlAimbot.Controls.Add(this.label39);
            this.pnlAimbot.Controls.Add(this.nud_aimbot_thread_delay);
            this.pnlAimbot.Controls.Add(this.label40);
            this.pnlAimbot.Controls.Add(this.cb_aimbot_enabled);
            this.pnlAimbot.Controls.Add(this.label41);
            this.pnlAimbot.Controls.Add(this.panel15);
            this.pnlAimbot.Controls.Add(this.panel16);
            this.pnlAimbot.Location = new System.Drawing.Point(154, 12);
            this.pnlAimbot.Name = "pnlAimbot";
            this.pnlAimbot.Size = new System.Drawing.Size(448, 270);
            this.pnlAimbot.TabIndex = 25;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(338, 13);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(31, 13);
            this.label39.TabIndex = 24;
            this.label39.Text = "(ms)";
            // 
            // nud_aimbot_thread_delay
            // 
            this.nud_aimbot_thread_delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_aimbot_thread_delay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_aimbot_thread_delay.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_aimbot_thread_delay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nud_aimbot_thread_delay.Location = new System.Drawing.Point(252, 10);
            this.nud_aimbot_thread_delay.Name = "nud_aimbot_thread_delay";
            this.nud_aimbot_thread_delay.Size = new System.Drawing.Size(80, 20);
            this.nud_aimbot_thread_delay.TabIndex = 23;
            this.nud_aimbot_thread_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_aimbot_thread_delay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(154, 12);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(91, 13);
            this.label40.TabIndex = 22;
            this.label40.Text = "| Thread Delay";
            // 
            // cb_aimbot_enabled
            // 
            this.cb_aimbot_enabled.AutoSize = true;
            this.cb_aimbot_enabled.Location = new System.Drawing.Point(133, 12);
            this.cb_aimbot_enabled.Name = "cb_aimbot_enabled";
            this.cb_aimbot_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_aimbot_enabled.TabIndex = 21;
            this.cb_aimbot_enabled.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(78, 12);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(49, 13);
            this.label41.TabIndex = 20;
            this.label41.Text = "Enabled";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel15.Controls.Add(this.cmb_aimbot_type);
            this.panel15.Controls.Add(this.label42);
            this.panel15.Location = new System.Drawing.Point(65, 37);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(319, 32);
            this.panel15.TabIndex = 18;
            // 
            // cmb_aimbot_type
            // 
            this.cmb_aimbot_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_aimbot_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_aimbot_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_aimbot_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_aimbot_type.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_aimbot_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cmb_aimbot_type.FormattingEnabled = true;
            this.cmb_aimbot_type.Items.AddRange(new object[] {
            "general",
            "pistols",
            "snipers"});
            this.cmb_aimbot_type.Location = new System.Drawing.Point(130, 3);
            this.cmb_aimbot_type.Name = "cmb_aimbot_type";
            this.cmb_aimbot_type.Size = new System.Drawing.Size(131, 21);
            this.cmb_aimbot_type.TabIndex = 105;
            this.cmb_aimbot_type.TabStop = false;
            this.cmb_aimbot_type.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboDrawItem);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label42.Location = new System.Drawing.Point(54, 3);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(70, 22);
            this.label42.TabIndex = 0;
            this.label42.Text = "Aimbot";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.cmb_aimbot_bone);
            this.panel16.Controls.Add(this.label50);
            this.panel16.Controls.Add(this.cb_aimbot_rcs);
            this.panel16.Controls.Add(this.label47);
            this.panel16.Controls.Add(this.label43);
            this.panel16.Controls.Add(this.cb_aimbot_target_enemies);
            this.panel16.Controls.Add(this.txt_aimbot_key);
            this.panel16.Controls.Add(this.label44);
            this.panel16.Controls.Add(this.cb_aimbot_target_teammates);
            this.panel16.Controls.Add(this.label45);
            this.panel16.Controls.Add(this.label46);
            this.panel16.Controls.Add(this.cb_aimbot_onkey);
            this.panel16.Controls.Add(this.nud_aimbot_smooth);
            this.panel16.Controls.Add(this.label48);
            this.panel16.Controls.Add(this.label49);
            this.panel16.Controls.Add(this.nud_aimbot_fov);
            this.panel16.Location = new System.Drawing.Point(65, 71);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(319, 191);
            this.panel16.TabIndex = 19;
            // 
            // cmb_aimbot_bone
            // 
            this.cmb_aimbot_bone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmb_aimbot_bone.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_aimbot_bone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_aimbot_bone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_aimbot_bone.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_aimbot_bone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cmb_aimbot_bone.FormattingEnabled = true;
            this.cmb_aimbot_bone.Items.AddRange(new object[] {
            "head",
            "neck",
            "upper chest",
            "middle chest",
            "lower chest"});
            this.cmb_aimbot_bone.Location = new System.Drawing.Point(118, 51);
            this.cmb_aimbot_bone.Name = "cmb_aimbot_bone";
            this.cmb_aimbot_bone.Size = new System.Drawing.Size(131, 21);
            this.cmb_aimbot_bone.TabIndex = 104;
            this.cmb_aimbot_bone.TabStop = false;
            this.cmb_aimbot_bone.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboDrawItem);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(62, 53);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(49, 15);
            this.label50.TabIndex = 103;
            this.label50.Text = "Target";
            // 
            // cb_aimbot_rcs
            // 
            this.cb_aimbot_rcs.AutoSize = true;
            this.cb_aimbot_rcs.Location = new System.Drawing.Point(117, 129);
            this.cb_aimbot_rcs.Name = "cb_aimbot_rcs";
            this.cb_aimbot_rcs.Size = new System.Drawing.Size(15, 14);
            this.cb_aimbot_rcs.TabIndex = 21;
            this.cb_aimbot_rcs.UseVisualStyleBackColor = true;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.White;
            this.label47.Location = new System.Drawing.Point(20, 129);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(91, 13);
            this.label47.TabIndex = 20;
            this.label47.Text = "Control Recoil";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(68, 6);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(43, 13);
            this.label43.TabIndex = 6;
            this.label43.Text = "On Key";
            // 
            // cb_aimbot_target_enemies
            // 
            this.cb_aimbot_target_enemies.AutoSize = true;
            this.cb_aimbot_target_enemies.Location = new System.Drawing.Point(117, 169);
            this.cb_aimbot_target_enemies.Name = "cb_aimbot_target_enemies";
            this.cb_aimbot_target_enemies.Size = new System.Drawing.Size(15, 14);
            this.cb_aimbot_target_enemies.TabIndex = 17;
            this.cb_aimbot_target_enemies.UseVisualStyleBackColor = true;
            // 
            // txt_aimbot_key
            // 
            this.txt_aimbot_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_aimbot_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_aimbot_key.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_aimbot_key.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_aimbot_key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txt_aimbot_key.Location = new System.Drawing.Point(118, 26);
            this.txt_aimbot_key.Name = "txt_aimbot_key";
            this.txt_aimbot_key.ReadOnly = true;
            this.txt_aimbot_key.ShortcutsEnabled = false;
            this.txt_aimbot_key.Size = new System.Drawing.Size(131, 20);
            this.txt_aimbot_key.TabIndex = 2;
            this.txt_aimbot_key.TabStop = false;
            this.txt_aimbot_key.Text = "Mouse 1 [0x1]";
            this.txt_aimbot_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_aimbot_key.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_aimbot_key_MouseClick);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(14, 149);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(97, 13);
            this.label44.TabIndex = 16;
            this.label44.Text = "Shoot Teammates";
            // 
            // cb_aimbot_target_teammates
            // 
            this.cb_aimbot_target_teammates.AutoSize = true;
            this.cb_aimbot_target_teammates.Location = new System.Drawing.Point(117, 149);
            this.cb_aimbot_target_teammates.Name = "cb_aimbot_target_teammates";
            this.cb_aimbot_target_teammates.Size = new System.Drawing.Size(15, 14);
            this.cb_aimbot_target_teammates.TabIndex = 15;
            this.cb_aimbot_target_teammates.UseVisualStyleBackColor = true;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(26, 170);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(85, 13);
            this.label45.TabIndex = 14;
            this.label45.Text = "Shoot Enemies";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(87, 29);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(25, 13);
            this.label46.TabIndex = 5;
            this.label46.Text = "Key";
            // 
            // cb_aimbot_onkey
            // 
            this.cb_aimbot_onkey.AutoSize = true;
            this.cb_aimbot_onkey.Location = new System.Drawing.Point(117, 6);
            this.cb_aimbot_onkey.Name = "cb_aimbot_onkey";
            this.cb_aimbot_onkey.Size = new System.Drawing.Size(15, 14);
            this.cb_aimbot_onkey.TabIndex = 7;
            this.cb_aimbot_onkey.UseVisualStyleBackColor = true;
            // 
            // nud_aimbot_smooth
            // 
            this.nud_aimbot_smooth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_aimbot_smooth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_aimbot_smooth.DecimalPlaces = 1;
            this.nud_aimbot_smooth.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_aimbot_smooth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nud_aimbot_smooth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_aimbot_smooth.Location = new System.Drawing.Point(118, 102);
            this.nud_aimbot_smooth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_aimbot_smooth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nud_aimbot_smooth.Name = "nud_aimbot_smooth";
            this.nud_aimbot_smooth.Size = new System.Drawing.Size(131, 20);
            this.nud_aimbot_smooth.TabIndex = 12;
            this.nud_aimbot_smooth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_aimbot_smooth.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.White;
            this.label48.Location = new System.Drawing.Point(87, 81);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(25, 13);
            this.label48.TabIndex = 8;
            this.label48.Text = "FOV";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(69, 106);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(43, 13);
            this.label49.TabIndex = 11;
            this.label49.Text = "Smooth";
            // 
            // nud_aimbot_fov
            // 
            this.nud_aimbot_fov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.nud_aimbot_fov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_aimbot_fov.DecimalPlaces = 1;
            this.nud_aimbot_fov.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_aimbot_fov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nud_aimbot_fov.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_aimbot_fov.Location = new System.Drawing.Point(118, 77);
            this.nud_aimbot_fov.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.nud_aimbot_fov.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_aimbot_fov.Name = "nud_aimbot_fov";
            this.nud_aimbot_fov.Size = new System.Drawing.Size(131, 20);
            this.nud_aimbot_fov.TabIndex = 9;
            this.nud_aimbot_fov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_aimbot_fov.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // tip
            // 
            this.tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tip.IsBalloon = true;
            // 
            // ofd
            // 
            this.ofd.Filter = "*.dgo |.dgo";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(614, 292);
            this.Controls.Add(this.pnlVisuals);
            this.Controls.Add(this.pnlMisc);
            this.Controls.Add(this.pnlValues);
            this.Controls.Add(this.pnlAimbot);
            this.Controls.Add(this.pnlTriggerbot);
            this.Controls.Add(this.pnlCompile);
            this.Controls.Add(this.tabAimbot);
            this.Controls.Add(this.txtDummy);
            this.Controls.Add(this.tabCompile);
            this.Controls.Add(this.tabMisc);
            this.Controls.Add(this.tabVisuals);
            this.Controls.Add(this.tabTriggerbot);
            this.Controls.Add(this.tabValues);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynago v[0.0] - Public Release";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.tabValues.ResumeLayout(false);
            this.tabValues.PerformLayout();
            this.tabTriggerbot.ResumeLayout(false);
            this.tabTriggerbot.PerformLayout();
            this.tabVisuals.ResumeLayout(false);
            this.tabVisuals.PerformLayout();
            this.tabMisc.ResumeLayout(false);
            this.tabMisc.PerformLayout();
            this.tabCompile.ResumeLayout(false);
            this.tabCompile.PerformLayout();
            this.pnlValues.ResumeLayout(false);
            this.pnlValShare.ResumeLayout(false);
            this.pnlValShare.PerformLayout();
            this.pnlOffsets.ResumeLayout(false);
            this.pnlOffsets.PerformLayout();
            this.tabValShare.ResumeLayout(false);
            this.tabValShare.PerformLayout();
            this.pnlBones.ResumeLayout(false);
            this.pnlBones.PerformLayout();
            this.tabBones.ResumeLayout(false);
            this.tabBones.PerformLayout();
            this.tabOffsets.ResumeLayout(false);
            this.tabOffsets.PerformLayout();
            this.pnlTriggerbot.ResumeLayout(false);
            this.pnlTriggerbot.PerformLayout();
            this.pnlTrigger1.ResumeLayout(false);
            this.pnlTrigger1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_overshoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_delay)).EndInit();
            this.pnlTrigger2.ResumeLayout(false);
            this.pnlTrigger2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_magnet_smooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_magnet_fov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_trigger_thread_delay)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlVisuals.ResumeLayout(false);
            this.pnlVisuals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_visuals_thread_delay)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_visuals_enemies_glowalpha)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_visuals_teammates_glowalpha)).EndInit();
            this.pnlMisc.ResumeLayout(false);
            this.pnlFeatures.ResumeLayout(false);
            this.pnlFeatures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fov_changer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rcs_x_percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rcs_y_percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_noflash_percent)).EndInit();
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfig.PerformLayout();
            this.pnlConfigID.ResumeLayout(false);
            this.pnlConfigID.PerformLayout();
            this.pnlConfigFile.ResumeLayout(false);
            this.pnlConfigFile.PerformLayout();
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            this.tabFeatures.ResumeLayout(false);
            this.tabFeatures.PerformLayout();
            this.pnlCompile.ResumeLayout(false);
            this.pnlCompile.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.tabAimbot.ResumeLayout(false);
            this.tabAimbot.PerformLayout();
            this.pnlAimbot.ResumeLayout(false);
            this.pnlAimbot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_aimbot_thread_delay)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_aimbot_smooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_aimbot_fov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tabValues;
        private System.Windows.Forms.Panel tabTriggerbot;
        private System.Windows.Forms.Panel tabVisuals;
        private System.Windows.Forms.Panel tabMisc;
        private System.Windows.Forms.Panel tabCompile;
        private System.Windows.Forms.Label lblValues;
        private System.Windows.Forms.Label lblTriggerbot;
        private System.Windows.Forms.Label lblVisuals;
        private System.Windows.Forms.Label lblMisc;
        private System.Windows.Forms.Label lblCompile;
        private System.Windows.Forms.Panel pnlValues;
        private System.Windows.Forms.Panel pnlTriggerbot;
        private System.Windows.Forms.Panel pnlVisuals;
        private System.Windows.Forms.Panel pnlMisc;
        private System.Windows.Forms.Panel pnlCompile;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TextBox txt_build_path;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnCompile;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.ListBox lbOffsets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_scrape_offsets;
        private System.Windows.Forms.Button btnScrapeOffsets;
        private Button btnChangeSelectedOffset;
        private Button btnManuallyModifyOffsets;
        public TextBox txt_trigger_key;
        private Label label6;
        public CheckBox cb_trigger_onkey;
        private Label label7;
        private Label label8;
        public NumericUpDown nud_trigger_delay;
        private Label label9;
        private Label label10;
        public NumericUpDown nud_trigger_overshoot;
        private Label label11;
        public CheckBox cb_trigger_shoot_teammates;
        private Label label12;
        public CheckBox cb_trigger_shoot_enemies;
        private Label label13;
        public CheckBox cb_visuals_enabled;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label label14;
        private Panel panel4;
        private Label label15;
        public CheckBox cb_visuals_teammates_enabled;
        private Label label16;
        public CheckBox cb_visuals_teammates_visibleonly;
        private Label label17;
        private Label label18;
        public Label lbl_visuals_teammates_color;
        private Label label20;
        public NumericUpDown nud_visuals_teammates_glowalpha;
        private Panel panel3;
        private ColorDialog cd;
        private Panel panel5;
        private Label label19;
        private Panel pnlTrigger1;
        private Label label26;
        public NumericUpDown nud_visuals_thread_delay;
        private Label label22;
        private Label label2;
        public NumericUpDown nud_trigger_thread_delay;
        private Label label27;
        public CheckBox cb_trigger_enabled;
        private Label label28;
        public TextBox txt_bhop_key;
        private Label label29;
        public CheckBox cb_bhop_enabled;
        private Label label4;
        private Panel panel11;
        private Label label38;
        public NumericUpDown nud_rcs_y_percent;
        private Label label37;
        private Label label36;
        private Label label34;
        public NumericUpDown nud_rcs_x_percent;
        public CheckBox cb_rcs_enabled;
        private Label label35;
        private Label label30;
        private Label label32;
        public NumericUpDown nud_noflash_percent;
        public CheckBox cb_noflash_enabled;
        private Label label31;
        private Panel tabAimbot;
        private Label lblAimbot;
        private Panel pnlAimbot;
        private Label label39;
        public NumericUpDown nud_aimbot_thread_delay;
        private Label label40;
        public CheckBox cb_aimbot_enabled;
        private Label label41;
        private Panel panel15;
        private Label label42;
        private Panel panel16;
        private Label label43;
        public CheckBox cb_aimbot_target_enemies;
        public TextBox txt_aimbot_key;
        private Label label44;
        public CheckBox cb_aimbot_target_teammates;
        private Label label45;
        public CheckBox cb_aimbot_onkey;
        public NumericUpDown nud_aimbot_smooth;
        private Label label48;
        private Label label49;
        public NumericUpDown nud_aimbot_fov;
        public CheckBox cb_aimbot_rcs;
        private Label label47;
        public ComboBox cmb_aimbot_bone;
        private Label label50;
        private Panel pnlOffsets;
        private Panel tabBones;
        private Label lblBones;
        private Panel tabOffsets;
        private Label lblOffsets;
        private Panel pnlBones;
        private ListBox lbBones;
        private Label label51;
        private Button btnManuallyModifyBones;
        private Button btnChangeSelectedBone;
        private ComboBox cmb_scrape_bones;
        private Button btnScrapeBones;
        private Label label53;
        private Label label54;
        private Label label33;
        public CheckBox cb_radar_enabled;
        private Label label52;
        public ComboBox cmb_obfuscation_preset;
        private ToolTip tip;
        private OpenFileDialog ofd;
        public CheckBox cb_obfuscation_enabled;
        private Label label55;
        private Panel pnlFeatures;
        private Panel tabFeatures;
        private Label lblFeatures;
        private Panel pnlAccount;
        private Label label46;
        public ComboBox cmb_aimbot_type;
        public ComboBox cmb_triggerbot_type;
        public CheckBox cb_trigger_magnetic;
        private Label label60;
        private Label lblCustomizeTriggerMagnetic;
        private Panel pnlTrigger2;
        private Label lblBackToTrigger;
        public ComboBox cmb_trigger_magnet_bone;
        private Label label62;
        public NumericUpDown nud_trigger_magnet_smooth;
        private Label label63;
        private Label label64;
        public NumericUpDown nud_trigger_magnet_fov;
        private Label label61;
        public TextBox txtDummy;
        private Panel tabValShare;
        private Label lblValShare;
        private Panel pnlValShare;
        private Label lblBonesSet;
        private Label lblOffsetsSet;
        private Label label65;
        private Label label66;
        private Label label67;
        private Label label69;
        private TextBox txtUploadID;
        private Button btnUploadValues;
        private Label label70;
        private Label label68;
        private TextBox txtDownloadID;
        private Button btnDownloadValues;
        private Label label71;
        private Panel tabConfig;
        private Label lblConfig;
        private Panel tabAccount;
        private Label lblAccount;
        private Panel pnlConfig;
        private Label label57;
        public NumericUpDown nud_fov_changer;
        private Label label58;
        public CheckBox cb_fov_changer;
        private Label label56;
        private ComboBox cmb_config_source;
        private Panel pnlConfigFile;
        private Label label72;
        private TextBox txtConfigFileLoad;
        private Label label73;
        private Label label74;
        private TextBox txtConfigFileSave;
        private Button btnSelectConfigFileSave;
        private Label label75;
        private Button btnSaveConfigFile;
        private Button btnLoadConfigFile;
        private Button btnSelectConfigFileLoad;
        private Panel pnlConfigID;
        private Button btnDownloadConfig;
        private Label label76;
        private TextBox txtDownloadConfig;
        private Label label77;
        private Label label78;
        private TextBox txtUploadConfig;
        private Button btnUploadConfig;
        private Label label79;
        private Label lblPreAdvertisements;
        private Label lblPreLoggedIn;
        private Button btnLogout;
        private Label lblLoggedIn;
        private Label lblAdvertisements;
        private Label lblRemoveAds;
        private Label label21;
        public CheckBox cb_visuals_enemies_healthbased;
        public NumericUpDown nud_visuals_enemies_glowalpha;
        private Label label23;
        public Label lbl_visuals_enemies_color;
        private Label label25;
        public CheckBox cb_visuals_enemies_visibleonly;
        private Label label80;
        public CheckBox cb_visuals_enemies_enabled;
        private Label label81;
        private Label label59;
        public CheckBox cb_visuals_teammates_healthbased;
        public CheckBox cb_skinchanger_enabled;
        private Label label24;
    }
}