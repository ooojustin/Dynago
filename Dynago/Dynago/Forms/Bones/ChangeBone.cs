using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynago.Forms {
    public partial class ChangeBone : Form {
        private Bone bone;
        private ListBox listBox;

        public ChangeBone(ListBox listBox, Bone bone) {
            InitializeComponent();
            this.bone = bone;
            this.listBox = listBox;
            Text = bone.GetName();
            txtValue.ApplyPlaceholder(bone.GetName(), Color.DarkGray, Color.FromArgb(255, 51, 153, 255));
            if (bone.GetValue() > 0) // Use existing value, if it's been set.
            {
                txtValue.Text = bone.GetValue().ToString();
                txtValue.ForeColor = Color.FromArgb(255, 51, 153, 255); // Force the color.
            }
        }

        private void btnChangeValue_Click(object sender, EventArgs e) {
            try {
                int value = Convert.ToInt32(txtValue.Text);
                bone.SetValue(value);
                BoneList.RefreshBones(listBox);
                Hide();
                MessageBox.Show("Bone value changed!\n" + bone.GetName() + " is now equal to " + value.ToString() + ".", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            } catch (System.FormatException) {
                MessageBox.Show("Invalid decimal value detected.\nThat couldn't be converted to an integer.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } catch (Exception ex) {
                MessageBox.Show("An error has occurred while converting value.\n" + ex.Message, "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
