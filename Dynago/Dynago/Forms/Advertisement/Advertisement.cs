
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*

    NOTES REGARDING ADS:
        When changing the domain
            - Update cron job which clears shortened urls
            - Update script which clears shortened urls (check if x link contains x domain)
            - Update generate script which creates a unique link with a random id (dynago.xyz/ad/auth.php?id=xxx)
        When changing adfly stuff
            - Change site keys in generating script
            - Change site keys in link clearing script
            - Change site keys in auth script

*/
namespace Dynago.Forms {
    public partial class Advertisement : Form {

        private CopyURL copyURL = null;
        private bool OpenOther = false;
        private void Advertisement_FormClosing(object sender, FormClosingEventArgs e) { if (!OpenOther) Application.Exit(); }
        private void lblRemoveAds_CLICK(object sender, EventArgs e) { Process.Start("https://selly.gg/p/4e4b5f82"); }

        public Advertisement() {
            InitializeComponent();
            this.LockSize();
            Text = Text.Replace("[0.0]", Program.currentVersion);
            lblRemoveAds.OnHover(Color.White);
        }

        private string adURL = string.Empty;
        private bool checkerRunning = false;

        private void OpenAdvertisement(object sender, EventArgs e) {
            try { Process.Start(adURL); } 
            catch (Exception) {
                copyURL = new CopyURL(adURL);
                copyURL.Show();
            }
            if (!checkerRunning) {
                checkerRunning = true;
                pb.Visible = true;
                this.ChangeSize(389, 245);
                adChecker.Start();
            }
            if (!copyURL.IsNull())
                copyURL.Activate();
        }

        int timesExecuted = 0;
        private void adCheck_Tick(object sender, EventArgs e) {
            if (timesExecuted < 30) {
                if (timesExecuted < 25) pb.Value += 4;
                timesExecuted++;
                return;
            }
            try {
                string adCheck = string.Empty;
                using (WebClient web = new WebClient()) {
                    web.Headers.Add("user-agent", "Dynago");
                    web.NullifyProxy();
                    adCheck = web.DownloadString(Program.url_adCheck + adURL);
                }
                adCheck = adCheck.Substring(4, adCheck.Length - 12);
                adCheck = adCheck.Reverse();
                adCheck = Encoding.UTF8.GetString(Convert.FromBase64String(adCheck));
                if (adCheck == adURL) {
                    OpenOther = true;
                    new Main().Show();
                    if (!copyURL.IsNull())
                        copyURL.Close();
                    Close();
                }
            } catch (Exception) { }
            timesExecuted = 0;
            pb.Value = 0;
        }

        private void Advertisement_Load(object sender, EventArgs e) {
            try {
                lblEarned.Text = "$" + Networking.GetData("adfly_monthly_earnings");
                lblPreEarned.Left -= lblEarned.Width / 2;
                lblEarned.Left = lblPreEarned.Right;

                using (WebClient web = new WebClient()) {
                    web.Headers.Add("user-agent", "Dynago");
                    web.NullifyProxy();
                    adURL = web.DownloadString(Program.url_adGenerate);
                }
                if (adURL == "failed") {
                    MessageBox.Show("Advertisement failed.\nIt's on our end, try again later!", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                btnOpen.Enabled = true;
            } catch (Exception) {
                MessageBox.Show("Advertisement failed for an unknown reason.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
