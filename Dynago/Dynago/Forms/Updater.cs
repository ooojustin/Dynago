using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynago.Forms {
    public partial class Updater : Form {

        private void lblJustinOOO_Click(object sender, EventArgs e) { System.Diagnostics.Process.Start("https://justin.ooo/"); }
        private void Updater_FormClosing(object sender, FormClosingEventArgs e) { Application.Exit(); }

        public Updater(string url) {
            InitializeComponent();
            this.LockSize();
            Control.CheckForIllegalCrossThreadCalls = false;
            Text = Text.Replace("[0.0]", Program.currentVersion);
            txtUpgrading.Text = $"Upgrading Dynago from v{Program.currentVersion} to v{Program.newestVersion}!";
            this.CenterAlign(lblBytes);
            new Thread(() => {
                using (WebClient web = new WebClient()) {
                    try {
                        web.DownloadProgressChanged += (s, e) => {
                            long i = e.BytesReceived;
                            long o = e.TotalBytesToReceive;
                            int p = e.ProgressPercentage;
                            pb.Value = p;
                            lblBytes.Text = $"Downloading bytes - [{i}/{o}] - {p}%";
                        };
                        web.DownloadDataCompleted += (s, e) => {
                            try {
                                Thread.Sleep(500);
                                lblBytes.Text = "Download completed! Restarting...";
                                Thread.Sleep(500);
                                string file = $"Dynago {Program.newestVersion}.exe";
                                File.WriteAllBytes(file, e.Result);
                                Process.Start(file);
                                Program.DeleteSelf();
                            } catch (Exception) {
                                MessageBox.Show("Update failed.\nProcess will now close.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Application.Exit();
                            }
                        };
                        web.Headers.Add("user-agent", "Dynago");
                        web.NullifyProxy();
                        web.DownloadDataAsync(new Uri(url));
                    } catch (Exception) {
                        MessageBox.Show("Update failed.\nProcess will now close.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Exit();
                    }
                }
            }).Start();
        }

    }
}
