using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;

static class OffsetList
{
    public static List<Offset> List = new List<Offset>();

    public static void Initialize()
    {
        List.Add(new Offset("m_bDormant", 0xE9));
        List.Add(new Offset("m_zoomLevel", 0x3340));
        List.Add(new Offset("m_iFOV", 0x31D4));
        List.Add(new Offset("dwLocalPlayer"));
        List.Add(new Offset("m_iHealth"));
        List.Add(new Offset("m_iTeamNum"));
        List.Add(new Offset("m_flFlashMaxAlpha"));
        List.Add(new Offset("m_iCrosshairId"));
        List.Add(new Offset("m_bIsScoped"));
        List.Add(new Offset("dwEntityList"));
        List.Add(new Offset("dwForceAttack"));
        List.Add(new Offset("dwForceJump"));
        List.Add(new Offset("dwGlowObjectManager"));
        List.Add(new Offset("m_iGlowIndex"));
        List.Add(new Offset("m_fFlags"));
        List.Add(new Offset("m_aimPunchAngle"));
        List.Add(new Offset("dwClientState"));
        List.Add(new Offset("dwClientState_ViewAngles"));
        List.Add(new Offset("m_iShotsFired"));
        List.Add(new Offset("m_dwBoneMatrix"));
        List.Add(new Offset("m_vecOrigin"));
        List.Add(new Offset("m_vecViewOffset"));
        List.Add(new Offset("m_bSpotted"));
        List.Add(new Offset("m_hActiveWeapon"));
        List.Add(new Offset("m_iItemDefinitionIndex"));
    }

    public static void RefreshOffsets(this ListBox listBox)
    {
        listBox.Items.Clear();
        foreach (Offset o in OffsetList.List)
            listBox.Items.Add(o.GetName() + ": 0x" + o.GetValue().ToString("X"));
    }

    public static string ReplaceOffsets(string source)
    {
        source = source.ReplaceComment("offset_Dormant", "0x" + List[0].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_ZoomLevel", "0x" + List[1].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_FOV", "0x" + List[2].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_LocalPlayer", "0x" + List[3].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_Health", "0x" + List[4].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_Team", "0x" + List[5].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_FlashMaxAlpha", "0x" + List[6].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_CrosshairID", "0x" + List[7].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_IsScoped", "0x" + List[8].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_EntityList", "0x" + List[9].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_ForceAttack", "0x" + List[10].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_ForceJump", "0x" + List[11].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_GlowObject", "0x" + List[12].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_GlowIndex", "0x" + List[13].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_Flags", "0x" + List[14].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_AimPunch", "0x" + List[15].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_ClientState", "0x" + List[16].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_ViewAngles", "0x" + List[17].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_ShotsFired", "0x" + List[18].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_BoneMatrix", "0x" + List[19].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_VectorOrigin", "0x" + List[20].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_VectorView", "0x" + List[21].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_Spotted", "0x" + List[22].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_ActiveWeapon", "0x" + List[23].GetValue().ToString("X"));
        source = source.ReplaceComment("offset_ItemDefinitionIndex", "0x" + List[24].GetValue().ToString("X"));
        return source;
    }

    public static void ScrapeOffsets(this ListBox listBox, int mode)
    {
        if (mode < 0) goto invalid_mode;
        string offsetData = string.Empty;
        int valid = 0;
        switch  (mode)
        {
            case 0:
                try {
                    using (WebClient web = new WebClient()) {
                        web.Headers.Add("user-agent", "Dynago");
                        offsetData = web.DownloadString("https://justin-login.online/offsets/latest.php");
                    }
                } catch (Exception) { goto web_exception; }
                break;
            case 1:
                try {
                    using (WebClient web = new WebClient()) {
                        web.Headers.Add("user-agent", "Dynago");
                        offsetData = web.DownloadString("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.cs");
                    }
                } catch (Exception) { goto web_exception; }
                break;
            default: goto invalid_mode;
        }
        ParseOffsets(List, offsetData, ref valid);
        RefreshOffsets(listBox);
        MessageBox.Show(valid + "/" + List.Count + " offsets were parsed and replaced successfully.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
        invalid_mode:
        MessageBox.Show("Please select a valid destination to scrape from.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
        web_exception:
        MessageBox.Show("An error has occurred while downloading offset data.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    public static void ParseOffsets(List<Offset> offsets, string data, ref int valid) {
        foreach (Offset offset in List) {
            Regex regex = new Regex($"public const Int32 {offset.GetName()} = 0x.*?;");
            Match m = regex.Match(data);
            if (!m.Success) {
                //MessageBox.Show("An error has occurred while finding " + offset.GetName() + ".", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                continue;
            }
            string strValue = m.Value.Split('=').GetValue(1).ToString().Replace(" ", "").Replace(";", "");
            int value = Convert.ToInt32(strValue, 16);
            valid++;
            offset.SetValue(value);
        }
    }

}

public class Offset
{
    private string name;
    private int value;

    public Offset(string name, int value = 0)
    {
        this.name = name;
        this.value = value;
    }

    public void SetValue(int value)
    {
        this.value = value;
    }

    public int GetValue()
    {
        return this.value;
    }

    public string GetName()
    {
        return this.name;
    }
}