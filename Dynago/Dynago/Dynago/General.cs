using Dynago;
using Dynago.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

/*
    This file includes the following classes:
        -> General              (Contains methods that don't fall under a specific category)
        -> Randomize            (Misc methods that have a factor of randomness)
        -> StringExtension      (General extensions to string type variable)
        -> KeyManagement        (Manage and use key objects in winforms)
        -> JunkGenerator        (Generate random junk code and replace it in a source)
        -> Confuser             (Functions to help manage obfuscation process)
        -> WeaponSettings       (Class to manage settings for different weapon types)
        -> Sharing              (Used to allow users to upload/download information used in the program)
*/

static class General {

    public static string ReplaceComment(this string source, string setting, string value) {
        Regex regex = new Regex(@"/\*" + setting + @"\*/.*?/\*" + setting + @"\*/", RegexOptions.Singleline);
        MatchCollection collection = regex.Matches(source);
        foreach (Match match in collection)
            source = source.Replace(match.ToString(), value);
        return source;
    }

    public static string EraseComment(this string source, string setting) {
        return source.ReplaceComment(setting, string.Empty);
    }
  
    public static void NullifyProxy(this System.Net.WebClient web) {
        web.Proxy = null;
    }

    public static string Reverse(this string s) {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public static string DecodeB64(this string s) {
        byte[] b = Convert.FromBase64String(s);
        return Encoding.UTF8.GetString(b);
    }

    public static void Required(this CheckBox b) {
        b.CheckedChanged += (s, e) => {
            if (!b.Checked) {
                b.Checked = true;
                MessageBox.Show("This feature can not be disabled in the current version.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        };
    }

    public static bool IsNull(this object T) {
        return T == null ? true : false;
    }

}

static class Randomize {

    public static string String(int min = 8, int max = 16) {
        Random random = new Random(Guid.NewGuid().GetHashCode());
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        return chars[random.Next(chars.Length - 10)] + new string(Enumerable.Repeat(chars, random.Next(min, max))
         .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public static bool Boolean() {
        Random random = new Random(Guid.NewGuid().GetHashCode());
        return random.Next(1) == 1;
    }

    public static int Number(int min = 0, int max = 0) {
        Random random = new Random(Guid.NewGuid().GetHashCode());
        return random.Next(min, max + 1);
    }

    public static string Code(string element, string source) {
        Regex regex = new Regex(@"/\*" + element + @"\*/.*?/\*" + element + @"\*/");
        MatchCollection collection = regex.Matches(source);
        foreach (Match match in collection) {
            string random = Randomize.String();
            source = source.Replace(match.ToString(), random);
        }
        return source;
    }
    
    public static string ReplaceNumbers(string source) {
        // NOTE: All hexadecimal numbers MUST begin with 0x to be randomized properly.
        Regex regex = new Regex(@"/\*number\*/.*?/\*number\*/");
        MatchCollection collection = regex.Matches(source);
        foreach (Match match in collection) {

            string strOriginal = match.ToString().Replace("/*number*/", "");
            bool hexadecimal = strOriginal.Length >= 2 && strOriginal.Substring(0, 2).ToLower() == "0x";
            int numBase = (hexadecimal) ? 16 : 10; // Hexadecimal or decimal?
            int original = Convert.ToInt32(strOriginal, numBase);
            if (original == 0 || original == 1) continue; // No point.-.
            if (original < 0) continue; // Don't handle negative numbers
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int mode = random.Next(1, 4); // Second number is exclusive, duh...
            switch (mode) {
                case 1: // Subtraction
                    int subRnd = random.Next(1, original);
                    int subTemp = original + subRnd;
                    source = source.ReplaceFirst(match.ToString(), subTemp + " - " + subRnd);
                    break;
                case 2: // Addition
                    int addRnd = random.Next(1, original);
                    int addTemp = original - addRnd;
                    source = source.ReplaceFirst(match.ToString(), addTemp + " + " + addRnd);
                    break;
                case 3: // Divison
                    int divRnd = random.Next(2, 10);
                    int divTemp = original * divRnd;
                    source = source.ReplaceFirst(match.ToString(), divTemp + " / " + divRnd);
                    break;
                    // Not adding multiplication. (Due to potential data loss.) 
            }
        }
        return source;
    }

    /*
        The following method is one of the strangest (and poorly written), most confusing methods I've ever written.
        If I had a more complex understanding of regex, or more experience, I likely could've done this a lot better.
        Due to this, I'm going to comment the whole thing...
    */  
    public static string RandomizeOrders(string source) {
        // It's recursive, so the following line is our kill switch.
        if (source.NumberOf("/*order-start*/") == 0) return source;
        // Let us make temporary changes to the string we're modifying.
        string working = source;
        // Initialize some variables we'll use later.
        string newSource = string.Empty;
        List<string> Items = new List<string>();
        Match orderMatch = null;
        // Start with the smallest (? = lazy) match that begins with order-start and ends with order-end.
        Regex orderRegex = new Regex(@"/\*order-start\*/.*?/\*order-end\*/", RegexOptions.Singleline);
        // Set label for us to return to after making modifications to our temporary source variable.
        start_loop:
        // Loop through every occurance of order-start/ends.
        foreach (Match m in orderRegex.Matches(working)) {
            // If it contains order-start more than once, we don't want to work with it.
            // This means there's another match inside of it. We need to change that first.
            if (m.ToString().NumberOf("/*order-start*/") > 1) {
                // Erase the first order-start so we can modify the smallest ones first.
                working = working.EraseFirst("/*order-start*/");
                // Restart the foreach statement with our new temporary source data.
                goto start_loop;
            }
            // If we only have 1 order-start, we have the smallest possible order list.
            else orderMatch = m;
        }
        // We're not working with the smallest order we've found.
        // Get each order inside of the list.
        Regex orderItemRegex = new Regex(@"/\*order-\*/.*?/\*order-\*/", RegexOptions.Singleline);
        MatchCollection orderItemList = orderItemRegex.Matches(orderMatch.ToString());
        // Add them all to a list of strings.
        foreach (Match item in orderItemList) Items.Add(item.ToString().Replace("/*order-*/", ""));
        // Randomize the order of the list. (That's the point of this method, at least)
        if (Items.Count > 1) Items.Shuffle();
        // Append original source pieces to blank string in our new random order.
        foreach (string srcItem in Items) newSource += srcItem + Environment.NewLine;
        // This method now calls itself, replacing the original data with new data in a randomized order.
        return RandomizeOrders(source.Replace(orderMatch.ToString(), newSource));
    }

    // Credits: https://stackoverflow.com/a/1262619/5699643
    public static void Shuffle<T>(this IList<T> list) {
        RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
        int n = list.Count;
        while (n > 1) {
            byte[] box = new byte[1];
            do provider.GetBytes(box);
            while (!(box[0] < n * (Byte.MaxValue / n)));
            int k = (box[0] % n);
            n--;
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

}

public static class StringExtension {
    public static string ReplaceFirst(this string text, string search, string replace) {
        int pos = text.IndexOf(search);
        if (pos < 0) return text;
        return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
    }

    public static string EraseFirst(this string text, string search) {
        return text.ReplaceFirst(search, "");
    }

    public static int NumberOf(this string haystack, string needle) {
        return new Regex(Regex.Escape(needle)).Matches(haystack).Count;
    }
}

public static class KeyManagement {
    // pInvoke GetAsyncKeyState from user32.dll so we can check user input...
    [DllImport("user32.dll")]
    static extern short GetAsyncKeyState(int vKey);

    public static void KeyThread(ref TextBox txt) {
        while (GetPressedKey() != -1) Thread.Sleep(1);
        int PressedKey = -1;
        while (PressedKey == -1) PressedKey = GetPressedKey();
        txt.Text = GetKeyString(PressedKey);
    }

    private static int GetPressedKey() {
        for (int i = 1; i < 255; i++)
            if (GetAsyncKeyState(i) != 0)
                return i;
        return -1;
    }

    public static int KeyFromText(string text) {
        try {
            string[] split = text.Split(new char[] { '[', ']' });
            return Convert.ToInt32(split[1], 16);
        } catch (Exception) { return -1; }
    }

    private static string GetKeyString(int key) {
        string keyString = string.Empty;
        string hexValue = "0x" + key.ToString("X").ToUpper();
        foreach (Tuple<int, string> currentKey in KeyList) if (currentKey.Item1 == key) keyString = currentKey.Item2;
        if (!string.IsNullOrEmpty(keyString)) keyString += " [" + hexValue + "]";
        else keyString = "Unknown [" + hexValue + "]";
        return keyString;
    }

    private static List<Tuple<int, string>> KeyList = new List<Tuple<int, string>>();
    public static void InitializeKeys() {
        KeyList.Add(new Tuple<int, string>(32, "Space"));
        KeyList.Add(new Tuple<int, string>(8, "BackSpace"));
        KeyList.Add(new Tuple<int, string>(18, "Alt"));
        KeyList.Add(new Tuple<int, string>(164, "Left Alt"));
        KeyList.Add(new Tuple<int, string>(165, "Right Alt"));
        KeyList.Add(new Tuple<int, string>(1, "Mouse 1"));
        KeyList.Add(new Tuple<int, string>(2, "Mouse 2"));
        KeyList.Add(new Tuple<int, string>(4, "Middle Mouse"));
        KeyList.Add(new Tuple<int, string>(5, "Mouse 4"));
        KeyList.Add(new Tuple<int, string>(6, "Mouse 5"));
        KeyList.Add(new Tuple<int, string>(16, "Shift"));
        KeyList.Add(new Tuple<int, string>(160, "Left Shift"));
        KeyList.Add(new Tuple<int, string>(161, "Right Shift"));
        KeyList.Add(new Tuple<int, string>(65, "A"));
        KeyList.Add(new Tuple<int, string>(66, "B"));
        KeyList.Add(new Tuple<int, string>(67, "C"));
        KeyList.Add(new Tuple<int, string>(68, "D"));
        KeyList.Add(new Tuple<int, string>(69, "E"));
        KeyList.Add(new Tuple<int, string>(70, "F"));
        KeyList.Add(new Tuple<int, string>(71, "G"));
        KeyList.Add(new Tuple<int, string>(72, "H"));
        KeyList.Add(new Tuple<int, string>(73, "I"));
        KeyList.Add(new Tuple<int, string>(74, "J"));
        KeyList.Add(new Tuple<int, string>(75, "K"));
        KeyList.Add(new Tuple<int, string>(76, "L"));
        KeyList.Add(new Tuple<int, string>(77, "M"));
        KeyList.Add(new Tuple<int, string>(78, "N"));
        KeyList.Add(new Tuple<int, string>(79, "O"));
        KeyList.Add(new Tuple<int, string>(80, "P"));
        KeyList.Add(new Tuple<int, string>(81, "Q"));
        KeyList.Add(new Tuple<int, string>(82, "R"));
        KeyList.Add(new Tuple<int, string>(83, "S"));
        KeyList.Add(new Tuple<int, string>(84, "T"));
        KeyList.Add(new Tuple<int, string>(85, "U"));
        KeyList.Add(new Tuple<int, string>(86, "V"));
        KeyList.Add(new Tuple<int, string>(87, "W"));
        KeyList.Add(new Tuple<int, string>(88, "X"));
        KeyList.Add(new Tuple<int, string>(89, "Y"));
        KeyList.Add(new Tuple<int, string>(90, "Z"));
    }
}

public static class JunkGenerator {

    public static string Junkify(this string source) {
        string finalSource = string.Empty;
        string[] lines = source.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        foreach (string line in lines) {
            if (line.Contains("junk_method"))
                finalSource += GenerateMethod() + "\n";
            else if (line.Contains("junk_line"))
                finalSource += GenerateLine() + "\n";
            else finalSource += line + "\n";
        }
        return finalSource;
    }

    private static string GenerateMethod() {
        string finalMethod = string.Empty;
        string returnValue = string.Empty;
        string returnType = "void";
        string methodName = Randomize.String();
        int returnTypeIndex = Randomize.Number(max: 3);
        switch (returnTypeIndex) {
            case 1:
                returnType = "string";
                returnValue = $"\"{Randomize.String()}\"";
                break;
            case 2:
                returnType = "int";
                returnValue = Randomize.Number(11111, 99999).ToString();
                break;
            case 3:
                returnType = "float";
                returnValue = $"{Randomize.Number(11111, 99999)}.{Randomize.Number(max: 99)}f";
                break;
        }
        finalMethod += $"public static {returnType} {methodName}() {{\n";
        for (int i = 0; i < Randomize.Number(5, 30); i++)
            finalMethod += GenerateLine();
        if (returnTypeIndex > 0)
            finalMethod += $"return {returnValue};\n";
        return finalMethod + "}";
    }

    private static string GenerateLine() {
        string finalLine = string.Empty;
        string randomNumber = string.Empty;
        string variableName = Randomize.String();
        switch (Randomize.Number(max: 2)) {
            case 0:
                finalLine += $"string {variableName} = \"{Randomize.String()}\";\n";
                finalLine += $"{variableName} += \"{Randomize.String(4, 8)}\";\n";
                return finalLine;
            case 1:
                finalLine += $"int {variableName} = {Randomize.Number(1111, 9999)};\n";
                randomNumber = Randomize.Number(500, 1000).ToString();
                break;
            case 2:
                finalLine += $"float {variableName} = {Randomize.Number(1111, 9999)}.{Randomize.Number(max: 99)}f;\n";
                randomNumber = Randomize.Number(500, 1000) + "." + Randomize.Number(max: 99) + "f";
                break;
        }
        switch (Randomize.Number(max: 2)) {
            case 0: finalLine += $"{variableName} += {randomNumber};\n"; break;
            case 1: finalLine += $"{variableName} -= {randomNumber};\n"; break;
            case 2: finalLine += $"{variableName} *= {randomNumber};\n"; break;
        }
        return finalLine;
    }
}

public static class Confuser {

    public static string Obfuscate(string obf, string path, string preset) {
        string crDirectory = new FileInfo(path).Directory.FullName;
        string crFile = path;
        string crPreset = preset;
        string crProj = EstablishCRPROJ(crDirectory, crFile, crPreset);
        string crProjFile = Randomize.String() + ".crproj";
        File.WriteAllText(obf + "\\" + crProjFile, crProj);
        File.WriteAllText(obf + "\\run.bat", "cd \"" + obf + "\"\nConfuser.CLI " + crProjFile);
        Process obfuscationProcess = BatchFile(obf + "\\run.bat");
        obfuscationProcess.Start();
        string confuserOutput = obfuscationProcess.StandardOutput.ReadToEnd();
        obfuscationProcess.WaitForExit();
        File.Delete(obf + "\\" + crProjFile);
        Directory.Delete(obf, true);
        return confuserOutput;
    }
    
    public static void Install(string confuserDir) {
        if (!Directory.Exists(confuserDir)) {
            DirectoryInfo di = Directory.CreateDirectory(confuserDir);
            di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
        }
        string confuserZip = confuserDir + "\\confuser.zip";
        Networking.DownloadFile(Program.url_confuser, confuserZip);
        ZipFile.ExtractToDirectory(confuserZip, confuserDir);
        File.Delete(confuserZip);
    }
    
    private static Process BatchFile(string path) {
        Process p = new Process();
        p.StartInfo.UseShellExecute = false;
        p.StartInfo.RedirectStandardOutput = true;
        p.StartInfo.FileName = path;
        p.StartInfo.CreateNoWindow = true;
        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
        p.StartInfo.Verb = "runas";
        return p;
    }
    
    private static string EstablishCRPROJ(string directory, string file, string preset) {
        string crProj = Dynago.Properties.Resources.CRproj;
        crProj = crProj.Replace("[directory]", directory);
        crProj = crProj.Replace("[filename]", file);
        crProj = crProj.Replace("[preset]", preset);
        return crProj;
    }

}

public class WeaponSettings {

    public static List<WeaponSettings> types = new List<WeaponSettings>();
    // index 0 = rifles, 1 = pistols, 2 = snipers

    private static int indexTracker = 0;
    public int index;

    // trigger weapon settings
    public bool trigger_on_key = false;
    public string trigger_key_txt = "Mouse 5 [0x6]";
    public int trigger_delay = 0;
    public int trigger_overshoot = 0;
    public bool trigger_shoot_teammates = false;
    public bool trigger_shoot_enemies = false;
    public bool trigger_magnetic = false;
    public int trigger_magnet_bone_index = 0;
    public float trigger_magnet_fov = 0.1f;
    public float trigger_magnet_smooth = 1.0f;

    // aim weapon settings
    public bool aimbot_on_key = false;
    public string aimbot_key_txt = "Mouse 1 [0x1]";
    public int aimbot_bone_index = 0;
    public float aimbot_fov = 0.1f;
    public float aimbot_smooth = 1.0f;
    public bool aimbot_control_recoil = false;
    public bool aimbot_shoot_teammates = false;
    public bool aimbot_shoot_enemies = false;

    public WeaponSettings(Dynago.Forms.Main parent) {
        index = indexTracker;
        indexTracker++;

        // trigger init
        parent.cmb_triggerbot_type.SelectedIndexChanged += (s, e) => WeaponSettings.RefreshTriggerSettings(parent);
        parent.cb_trigger_onkey.CheckedChanged += (s, e) => WeaponSettings.UpdateTriggerSettings(parent);
        parent.txt_trigger_key.TextChanged += (s, e) => WeaponSettings.UpdateTriggerSettings(parent);
        parent.nud_trigger_delay.ValueChanged += (s, e) => WeaponSettings.UpdateTriggerSettings(parent);
        parent.nud_trigger_overshoot.ValueChanged += (s, e) => WeaponSettings.UpdateTriggerSettings(parent);
        parent.cb_trigger_shoot_teammates.CheckedChanged += (s, e) => WeaponSettings.UpdateTriggerSettings(parent);
        parent.cb_trigger_shoot_enemies.CheckedChanged += (s, e) => WeaponSettings.UpdateTriggerSettings(parent);
        parent.cb_trigger_magnetic.CheckedChanged += (s, e) => WeaponSettings.UpdateTriggerSettings(parent);
        parent.cmb_trigger_magnet_bone.SelectedIndexChanged += (s, e) => WeaponSettings.UpdateTriggerSettings(parent);
        parent.nud_trigger_magnet_fov.ValueChanged += (s, e) => WeaponSettings.UpdateTriggerSettings(parent);
        parent.nud_trigger_magnet_smooth.ValueChanged += (s, e) => WeaponSettings.UpdateTriggerSettings(parent);

        // aimbot init
        parent.cmb_aimbot_type.SelectedIndexChanged += (s, e) => WeaponSettings.RefreshAimSettings(parent);
        parent.cb_aimbot_onkey.CheckedChanged += (s, e) => WeaponSettings.UpdateAimSettings(parent);
        parent.txt_aimbot_key.TextChanged += (s, e) => WeaponSettings.UpdateAimSettings(parent);
        parent.cmb_aimbot_bone.SelectedIndexChanged += (s, e) => WeaponSettings.UpdateAimSettings(parent);
        parent.nud_aimbot_fov.ValueChanged += (s, e) => WeaponSettings.UpdateAimSettings(parent);
        parent.nud_aimbot_smooth.ValueChanged += (s, e) => WeaponSettings.UpdateAimSettings(parent);
        parent.cb_aimbot_rcs.CheckedChanged += (s, e) => WeaponSettings.UpdateAimSettings(parent);
        parent.cb_aimbot_target_teammates.CheckedChanged += (s, e) => WeaponSettings.UpdateAimSettings(parent);
        parent.cb_aimbot_target_enemies.CheckedChanged += (s, e) => WeaponSettings.UpdateAimSettings(parent);

        types.Add(this);
    }

    public static WeaponSettings Selected(ComboBox c) { return Selected(c.SelectedIndex); }
    public static WeaponSettings Selected(int index) { return types.Find(i => i.index == index); }

    public static void RefreshAimSettings(Dynago.Forms.Main main) {
        main.RefreshingAimSettings = true;
        WeaponSettings settings = Selected(main.cmb_aimbot_type);
        main.cb_aimbot_onkey.Checked = settings.aimbot_on_key;
        main.txt_aimbot_key.Text = settings.aimbot_key_txt;
        main.cmb_aimbot_bone.SelectedIndex = settings.aimbot_bone_index;
        main.nud_aimbot_fov.Value = Convert.ToDecimal(settings.aimbot_fov);
        main.nud_aimbot_smooth.Value = Convert.ToDecimal(settings.aimbot_smooth);
        main.cb_aimbot_rcs.Checked = settings.aimbot_control_recoil;
        main.cb_aimbot_target_teammates.Checked = settings.aimbot_shoot_teammates;
        main.cb_aimbot_target_enemies.Checked = settings.aimbot_shoot_enemies; 
        main.RefreshingAimSettings = false;
        main.txtDummy.Focus();
    }

    public static void UpdateAimSettings(Dynago.Forms.Main main) {
        if (main.RefreshingAimSettings) return;
        WeaponSettings settings = Selected(main.cmb_aimbot_type);
        settings.aimbot_on_key = main.cb_aimbot_onkey.Checked;
        settings.aimbot_key_txt = main.txt_aimbot_key.Text;
        settings.aimbot_bone_index = main.cmb_aimbot_bone.SelectedIndex;
        settings.aimbot_fov = Convert.ToSingle(main.nud_aimbot_fov.Value);
        settings.aimbot_smooth = Convert.ToSingle(main.nud_aimbot_smooth.Value);
        settings.aimbot_control_recoil = main.cb_aimbot_rcs.Checked;
        settings.aimbot_shoot_teammates = main.cb_aimbot_target_teammates.Checked;
        settings.aimbot_shoot_enemies = main.cb_aimbot_target_enemies.Checked;
    }

    public static void RefreshTriggerSettings(Dynago.Forms.Main main) {
        main.RefreshingTriggerSettings = true;
        WeaponSettings settings = Selected(main.cmb_triggerbot_type);
        main.cb_trigger_onkey.Checked = settings.trigger_on_key;
        main.txt_trigger_key.Text = settings.trigger_key_txt;
        main.nud_trigger_delay.Value = Convert.ToDecimal(settings.trigger_delay);
        main.nud_trigger_overshoot.Value = Convert.ToDecimal(settings.trigger_overshoot);
        main.cb_trigger_shoot_teammates.Checked = settings.trigger_shoot_teammates;
        main.cb_trigger_shoot_enemies.Checked = settings.trigger_shoot_enemies;
        main.cb_trigger_magnetic.Checked = settings.trigger_magnetic;
        main.cmb_trigger_magnet_bone.SelectedIndex = settings.trigger_magnet_bone_index;
        main.nud_trigger_magnet_fov.Value = Convert.ToDecimal(settings.trigger_magnet_fov);
        main.nud_trigger_magnet_smooth.Value = Convert.ToDecimal(settings.trigger_magnet_smooth);
        main.RefreshingTriggerSettings = false;
        main.txtDummy.Focus();
    }

    public static void UpdateTriggerSettings(Dynago.Forms.Main main) {
        if (main.RefreshingTriggerSettings) return;
        WeaponSettings settings = Selected(main.cmb_triggerbot_type);
        settings.trigger_on_key = main.cb_trigger_onkey.Checked;
        settings.trigger_key_txt = main.txt_trigger_key.Text;
        settings.trigger_delay = Convert.ToInt32(main.nud_trigger_delay.Value);
        settings.trigger_overshoot = Convert.ToInt32(main.nud_trigger_overshoot.Value);
        settings.trigger_shoot_teammates = main.cb_trigger_shoot_teammates.Checked;
        settings.trigger_shoot_enemies = main.cb_trigger_shoot_enemies.Checked;
        settings.trigger_magnetic = main.cb_trigger_magnetic.Checked;
        settings.trigger_magnet_bone_index = main.cmb_trigger_magnet_bone.SelectedIndex;
        settings.trigger_magnet_fov = Convert.ToSingle(main.nud_trigger_magnet_fov.Value);
        settings.trigger_magnet_smooth = Convert.ToSingle(main.nud_trigger_magnet_smooth.Value);
    }

}

static class Sharing {

    public static void UploadValues(TextBox txt) {
        string uploadData = string.Empty;
        List<Offset> offsets = OffsetList.List;
        List<Bone> bones = BoneList.List;
        foreach (Offset offset in offsets)
            if (offset.GetValue() > 0)
                uploadData += "public const Int32 " + offset.GetName() + " = 0x" + offset.GetValue().ToString("X") + ";\n";
        foreach (Bone bone in bones)
            if (bone.GetValue() > 0)
                uploadData += bone.GetName() + "=\"" + bone.GetValue() + "\"\n";
        string result = Networking.ShareUpload("values", uploadData);
        if (string.IsNullOrEmpty(result)) {
            txt.Text = "ERROR";
            MessageBox.Show("An error has occurred while uploading your values.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        txt.Text = result;
        bool copied = false;
        try {
            Clipboard.SetText(result);
            copied = true;
        } catch (Exception) { }
        string successText = "Values uploaded successfully.\nGenerated ID: " + result;
        if (copied) successText += "\nID copied to clipboard.";
        MessageBox.Show(successText, "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static void DownloadValues(TextBox txt, Action update) {
        string id = txt.Text;
        if (id.Length != 8) {
            MessageBox.Show("Invalid ID detected.\nPlease ensure your ID is correct and try again.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        string result = Networking.ShareDownload("values", id);
        if (string.IsNullOrEmpty(result)) {
            MessageBox.Show("An error has occurred.\nUnable to download values from ID: " + id + "\nPlease ensure your ID is correct and try again.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        int validOffsets = 0, validBones = 0;
        OffsetList.ParseOffsets(OffsetList.List, result, ref validOffsets);
        BoneList.ParseBones(BoneList.List, result, ref validBones);
        MessageBox.Show("Values downloaded and parsed successfully!\n" +
            "Valid Offsets: " + validOffsets + "/" + OffsetList.List.Count + "\n" +
            "Valid Bones: " + validBones + "/" + BoneList.List.Count,
            "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Information);
        txt.Clear();
        update();
    }

    public static void UploadConfig(this Main f, TextBox txt) {
        string uploadData = f.GenerateConfig();
        string result = Networking.ShareUpload("config", uploadData);
        if (string.IsNullOrEmpty(result)) {
            txt.Text = "ERROR";
            MessageBox.Show("An error has occurred while uploading your config.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        txt.Text = result;
        bool copied = false;
        try {
            Clipboard.SetText(result);
            copied = true;
        } catch (Exception) { }
        string successText = "Config uploaded successfully.\nGenerated ID: " + result;
        if (copied) successText += "\nID copied to clipboard.";
        MessageBox.Show(successText, "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static void DownloadConfig(this Main f, TextBox txt) {
        string id = txt.Text;
        if (id.Length != 8) {
            MessageBox.Show("Invalid ID detected.\nPlease ensure your ID is correct and try again.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        string result = Networking.ShareDownload("config", id);
        if (string.IsNullOrEmpty(result)) {
            MessageBox.Show("An error has occurred.\nUnable to download config from ID: " + id + "\nPlease ensure your ID is correct and try again.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        try {
            f.LoadConfig(result);
            MessageBox.Show("Config downloaded and parsed successfully!", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } catch (Exception) {
            MessageBox.Show("Failed to parse/load configuration data.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        txt.Clear();
    }

}