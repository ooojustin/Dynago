using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynago.Forms
{
    public partial class ChangeOffset : Form
    {
        private Offset offset;
        private ListBox listBox;

        public ChangeOffset(ListBox listBox, Offset offset)
        {
            InitializeComponent();
            this.offset = offset;
            this.listBox = listBox;
            Text = offset.GetName();
            txtValue.ApplyPlaceholder(offset.GetName(), Color.DarkGray, Color.FromArgb(255, 51, 153, 255));
            if (offset.GetValue() > 0) // Use existing value, if it's been set.
            {
                txtValue.Text = "0x" + offset.GetValue().ToString("X");
                txtValue.ForeColor = Color.FromArgb(255, 51, 153, 255); // Force the color.
            }
        }

        private void btnChangeValue_Click(object sender, EventArgs e)
        {
            bool base16 = rbHexadecimal.Checked;
            if (base16)
            {
                // Using hexadecimal.
                try
                {
                    int value = Convert.ToInt32(txtValue.Text, 16);
                    offset.SetValue(value);
                    OffsetList.RefreshOffsets(listBox);
                    Hide();
                    MessageBox.Show("Offset value changed!\n" + offset.GetName() + " is now equal to 0x" + value.ToString("X") + ".", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Invalid hexadecimal value detected.\nThat couldn't be converted to an integer.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occurred while converting value.\n" + ex.Message, "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                // Using decimal.
                try
                {
                    int value = Convert.ToInt32(txtValue.Text);
                    offset.SetValue(value);
                    OffsetList.RefreshOffsets(listBox);
                    Hide();
                    MessageBox.Show("Offset value changed!\n" + offset.GetName() + " is now equal to 0x" + value.ToString("X") + ".", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Invalid decimal value detected.\nThat couldn't be converted to an integer.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error has occurred while converting value.\n" + ex.Message, "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }
    }
}
