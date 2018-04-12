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

namespace Dynago.Forms
{
    public partial class ChangeOffsetsText : Form
    {
        private List<Offset> offsets;
        private ListBox listBox;
        public ChangeOffsetsText(ListBox listBox, List<Offset> offsets)
        {
            InitializeComponent();
            this.offsets = offsets;
            this.listBox = listBox;
            foreach (Offset offset in offsets)
                txtOffsets.AppendText(offset.GetName() + ": 0x" + offset.GetValue().ToString("X") + "\n");
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            int valid = 0;
            string offsetData = txtOffsets.Text;
            foreach (Offset offset in offsets)
            {
                Regex regex = new Regex(offset.GetName() + ":.*");
                Match m = regex.Match(offsetData);
                if (!m.Success) goto offset_not_found;
                string data = m.Value.Split(' ').GetValue(1).ToString();
                if (data.Length < 1) goto offset_not_found;
                bool hexadecimal = false;
                try
                {
                    hexadecimal = data.Substring(0, 2).ToLower() == "0x";
                } catch (Exception) { } // Don't handle it, we'll just assume it's not hexadecimal...
                if (hexadecimal)
                {
                    // Using hexadecimal.
                    try
                    {
                        int value = Convert.ToInt32(data, 16);
                        offset.SetValue(value);
                        valid++;
                        continue;
                    }
                    catch (System.FormatException) { goto offset_error_converting; }
                    catch (Exception) { goto offset_error_unknown; }
                } else
                {
                    // Using decimal.
                    try
                    {
                        int value = Convert.ToInt32(data);
                        offset.SetValue(value);
                        valid++;
                        continue;
                    }
                    catch (System.FormatException) { goto offset_error_converting; }
                    catch (Exception) { goto offset_error_unknown; }
                }
                offset_not_found:
                MessageBox.Show("An error has occurred while finding " + offset.GetName() + ".", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                continue;
                offset_error_converting:
                MessageBox.Show("An error has occurred while converting " + offset.GetName() + ".", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                continue;
                offset_error_unknown:
                MessageBox.Show("An unknown error has occurred while parsing data from " + offset.GetName() + ".", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                continue;
            }
            OffsetList.RefreshOffsets(listBox);
            Hide();
            MessageBox.Show(valid + "/" + offsets.Count + " offsets were parsed and replaced successfully.", "Dynago", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
