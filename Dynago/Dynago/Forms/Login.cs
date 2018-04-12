using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynago.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.LockSize();
            Text = Text.Replace("[0.0]", Program.currentVersion);
            lblCurrentVersion.Text = "Current Version: " + Program.currentVersion;
            lblNewestVersion.Text = "Newest Version: " + Program.newestVersion;
            lblRegisteredUsers.Text = "Registered Users: " + Networking.GetData("registered_user_count");
            txtChangelog.Text = Networking.GetData("changelog");
            CenterLabel(lblCurrentVersion); CenterLabel(lblNewestVersion); CenterLabel(lblRegisteredUsers);
            txtUsername.ApplyPlaceholder("username", Color.DarkGray, Color.FromArgb(255, 51, 153, 255));
            txtPassword.ApplyPlaceholder("password", Color.DarkGray, Color.FromArgb(255, 51, 153, 255), "*");
            PanelTabControl pTab = new PanelTabControl(PanelTabType.ButtonBased, drawBorders: false);
            LoginTab = new PanelTab(tabLogin, lblLogin, pnlLogin);
            ChangelogTab = new PanelTab(tabChangelog, lblChangelog, pnlChangelog);
            pTab.AddTab(LoginTab);
            pTab.AddTab(ChangelogTab);
            pTab.TabChanged += (s, e) => tabChanged(s, e);
            pTab.SelectTab(0);
        }

        private bool OpenOther = false;
        private void Login_FormClosing(object sender, FormClosingEventArgs e) { if (!OpenOther) Application.Exit(); }
        private void CenterLabel(Label lbl) { lbl.Left = (ClientSize.Width - lbl.Width) / 2; }
        private void lblJustinOOO_Click(object sender, EventArgs e) { System.Diagnostics.Process.Start("https://justin.ooo/"); }

        PanelTab LoginTab;
        PanelTab ChangelogTab;
        private void tabChanged(object s, EventArgs e) {
            PanelTabControl ptc = (PanelTabControl) s;
            if (ptc.IsNull()) return;
            PanelTab selected = ptc.SelectedTab;
            if (selected.IsNull()) return;
            if (selected == ChangelogTab) {
                this.ChangeSize(468, 482);
                lblPoweredBy.Location = new Point(148, 422);
                lblJustinOOO.Location = new Point(214, 422);
            } else if (selected == LoginTab) {
                this.ChangeSize(468, 337);
                lblPoweredBy.Location = new Point(148, 278);
                lblJustinOOO.Location = new Point(214, 278);
            }
            lblPoweredBy.BringToFront();
            lblJustinOOO.BringToFront();
            CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            dynamic LoginResult = Networking.Login(username, txtPassword.Text);
            try {
                switch ((string)LoginResult.status)
                {
                    case "successful":
                        if (LoginResult.username == username)
                        {
                            Program.currentUserAds = (string)LoginResult.ads != "<false3";
                            MessageBox.Show($"Welcome to Dynago v{Program.currentVersion}, {username}!", "Logged in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Program.currentUser = username;
                            OpenOther = true;
                            if (Program.currentUserAds) new Advertisement().Show();
                            else {
                                if (!Properties.Settings.Default.adsRemovedThanks) {
                                    MessageBox.Show($"Thank for paying to remove ads, {username}!\nI appreciate the support :)", "Dynago <3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Properties.Settings.Default.adsRemovedThanks = true;
                                    Properties.Settings.Default.Save();
                                }
                                new Main().Show();
                            }
                            Close();
                        } else {
                            MessageBox.Show($"Incorrect username or password.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        return;
                    case "connection error":
                        MessageBox.Show($"Connection error.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    case "no account":
                        MessageBox.Show($"User not found.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    case "wrong password":
                        MessageBox.Show($"Incorrect username or password.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    default:
                        MessageBox.Show($"Incorrect username or password.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
            } catch (Exception) {
                MessageBox.Show($"An unknown error has occurred.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCreateAnAccount_Click(object sender, EventArgs e)
        {
            OpenOther = true;
            new Register().Show();
            Close();
        }
    }
}
