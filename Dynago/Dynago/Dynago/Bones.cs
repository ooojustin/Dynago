using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;

static class BoneList {

    public static List<Bone> List = new List<Bone>();

    public static void Initialize() {
        List.Add(new Bone("Head"));
        List.Add(new Bone("Neck"));
        List.Add(new Bone("Upper Chest"));
        List.Add(new Bone("Middle Chest"));
        List.Add(new Bone("Lower Chest"));
    }

    public static int GetBone(string name) {
        try {
            Bone bone = List.Find(item => item.GetName().ToLower() == name.ToLower());
            return bone.GetValue();
        } catch (Exception) {
            return -1;
        }   
    }

    public static void RefreshBones(this ListBox listBox) {
        listBox.Items.Clear();
        foreach (Bone b in BoneList.List)
            listBox.Items.Add(b.GetName() + ": " + b.GetValue());
    }

    public static void ScrapeBones(this ListBox listBox, int mode) {
        if (mode < 0) goto invalid_mode;
        string boneData = string.Empty;
        int valid = 0;
        switch (mode) {
            case 0:
                try {
                    using (WebClient web = new WebClient()) {
                        web.Headers.Add("user-agent", "Dynago");
                        boneData = web.DownloadString("https://pastebin.com/raw/dwt2YAe5");
                    }
                } catch (Exception) { goto web_exception; }
                break;
            default: goto invalid_mode;
        }
        ParseBones(List, boneData, ref valid);
        RefreshBones(listBox);
        MessageBox.Show(valid + "/" + List.Count + " bones were parsed and replaced successfully.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
        invalid_mode:
        MessageBox.Show("Please select a valid destination to scrape from.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
        web_exception:
        MessageBox.Show("An error has occurred while downloading bone data.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    public static void ParseBones(List<Bone> bones, string data, ref int valid) {
        foreach (Bone bone in bones) {
            Regex regex = new Regex(bone.GetName() + "=\".*?\"");
            Match m = regex.Match(data);
            if (!m.Success) {
                //MessageBox.Show("An error has occurred while finding " + bone.GetName() + ".", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                continue;
            }
            string strValue = m.Value.Split('"').GetValue(1).ToString();
            int value = Convert.ToInt32(strValue);
            valid++;
            bone.SetValue(value);
        }
    }
}

public class Bone {
    private string name;
    private int value;

    public Bone(string name, int value = 0) {
        this.name = name;
        this.value = value;
    }

    public void SetValue(int value) {
        this.value = value;
    }

    public int GetValue() {
        return this.value;
    }

    public string GetName() {
        return this.name;
    }
}