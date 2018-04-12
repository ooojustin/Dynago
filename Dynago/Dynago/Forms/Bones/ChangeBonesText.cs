using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynago.Forms {
    public partial class ChangeBonesText : Form {
        private List<Bone> bones;
        private ListBox listBox;
        public ChangeBonesText(ListBox listBox, List<Bone> bones) {
            InitializeComponent();
            this.bones = bones;
            this.listBox = listBox;
            foreach (Bone bone in bones)
                txtBones.AppendText(bone.GetName() + ": " + bone.GetValue().ToString() + "\n");
        }

        private void btnSaveChanges_Click(object sender, EventArgs e) {
            int valid = 0;
            string boneData = txtBones.Text;
            foreach (Bone bone in bones) {
                Regex regex = new Regex(bone.GetName() + ":.*");
                Match m = regex.Match(boneData);
                if (!m.Success) goto bone_not_found;
                string data = m.Value.Split(':').GetValue(1).ToString();
                data = data.Trim();
                if (data.Length < 1) goto bone_not_found;
                try {
                    int value = Convert.ToInt32(data);
                    bone.SetValue(value);
                    valid++;
                    continue;
                } catch (System.FormatException) { goto bone_error_converting; } catch (Exception) { goto bone_error_unknown; }
                bone_not_found:
                MessageBox.Show("An error has occurred while finding " + bone.GetName() + ".", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                continue;
                bone_error_converting:
                MessageBox.Show("An error has occurred while converting " + bone.GetName() + ".", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                continue;
                bone_error_unknown:
                MessageBox.Show("An unknown error has occurred while parsing data from " + bone.GetName() + ".", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                continue;
            }
            BoneList.RefreshBones(listBox);
            Hide();
            MessageBox.Show(valid + "/" + bones.Count + " bones were parsed and replaced successfully.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
