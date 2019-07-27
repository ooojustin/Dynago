using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Globalization;
using System.Security.Principal;

// Virtualize every function in this application :)
[assembly: Obfuscation(Feature = "Apply to type *: apply to member * when method or constructor: virtualization", Exclude = false)]

namespace Dynago {
    static class Program {
        public static string path = Assembly.GetExecutingAssembly().Location;
        public static string directory = Path.GetDirectoryName(path);
        public const string currentVersion = "4.1";
        public static string newestVersion = string.Empty;
        public static string registeredMembers = string.Empty;
        public static string currentUser = string.Empty;
        public static bool currentUserAds = true;

        private static NumberFormatInfo format = new System.Globalization.NumberFormatInfo() { NumberGroupSeparator = "." };
        private static string base_url = "https://justin-login.online/Dynago1.8+";
        private static string base_url_justin = "https://host.justin.ooo";
        public static string url_data = base_url + "/data.php";
        public static string url_login = base_url + "/login.php";
        public static string url_register = base_url + "/register.php";
        public static string url_notify = base_url + "/notify.php";
        public static string url_adGenerate = base_url + "/ad/generate.php";
        public static string url_adCheck = base_url + "/ad/check.php?link=";
        public static string url_confuser = base_url + "/confuser.zip";
        public static string url_share_upload = base_url + "/share/upload.php";
        public static string url_share_download = base_url + "/share/download.php";
        public static string url_skinchanger_download = base_url + "/skinchanger.dll";
        public static string url_injector_download = base_url_justin + "/inject/ju$tInject.exe";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // DISABLE WHEN TESTING
            KillSteam();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!IsAdministrator()) {
                MessageBox.Show("Application must be executed as administrator.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(0);
            }
            /*Program.newestVersion = Networking.GetData("newest_version");
            bool isUpdating = false;
            if (Convert.ToSingle(Program.newestVersion, format) > Convert.ToSingle(Program.currentVersion, format)) {
                DialogResult result = DialogResult.None;
                bool forceUpdate = Convert.ToBoolean(Networking.GetData("force_update"));
                if (forceUpdate) {
                    result = DialogResult.Yes;
                    MessageBox.Show($"An update is required.\nVersion {Program.currentVersion} will be upgraded to version {Program.newestVersion} automatically.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else result = MessageBox.Show($"An update is available!\nWould you like to upgrade from version {Program.currentVersion} to version {Program.newestVersion}?", "Dynago", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes) {
                    string url = Networking.GetData("newest_version_download");
                    new Forms.Updater(url).Show();
                    isUpdating = true;
                }
            }
            Console.WriteLine(directory);
            if (!isUpdating) new Forms.Login().Show();*/
            new Forms.Main().Show();
            Application.Run();
        }

        public static bool IsAdministrator() {  return (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator);}

        public static void DeleteSelf() {
            ProcessStartInfo Info = new ProcessStartInfo {
                Arguments = "/C choice /C Y /N /D Y /T & Del \"" + Program.path + "\"",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                FileName = "cmd.exe",
                Verb = "runas"
            };
            Process.Start(Info);
            KillProcess(Path.GetFileNameWithoutExtension(Program.path));
        }

        private static void KillSteam()
        {
            int killSteam = KillProcess("Steam");
            int killCSGO  = KillProcess("csgo");
            if (killSteam > 0 || killCSGO > 0)
                MessageBox.Show("Steam has been closed for security reasons.", "Process Killed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        private static int KillProcess(string processName)
        {
            int i = 0;
            foreach (Process p in Process.GetProcessesByName(processName))
            {
                p.Kill();
                i++;
            }
            return i;
        }
    }
}
