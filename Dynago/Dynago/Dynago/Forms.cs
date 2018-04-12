using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


/*
    This class functions as a vertical tab control.
    Each tab consists of a panel and a label (for the button) and a panel for the general components.
    When each button is drawn, a custom border will be added. If it is hovered, the color will change.
    When a button is selected, the width increases so the right hand side is aligned with the panel.
    The panel is moved over the right hand side of the button, and a custom border is drawn on the panel.
    A line maching the color of the panel/selected tab background is drawn over the part where the border meets the button.
    This effect causes the panel to appear to be attatched to the button.
*/
public enum PanelTabType {
    ButtonBased,
    VerticalAttatched
};

public class PanelTabControl {
    private static Color Color_PanelOutline = Color.FromArgb(100, 100, 100);
    private static Color Color_PanelBackground = Color.FromArgb(40, 40, 40);
    private static Color Color_ButtonBackgroundHovered = Color.FromArgb(45, 45, 45);
    private static Color Color_ButtonBackground = Color.FromArgb(35, 35, 35);
    private static Color Color_ButtonText = Color.FromArgb(255, 255, 255);
    private static Color Color_ButtonTextHovered = Color.FromArgb(230, 230, 230);
    private static Color Color_ButtonTextSelected = Color.FromArgb(51, 153, 255);
    private static Color Color_ButtonOutline = Color.FromArgb(19, 19, 19);
    private static Color Color_ButtonOutlineSelected = Color_PanelOutline; // Usually the same.

    public event EventHandler TabChanged;
    private List<PanelTab> tabs = new List<PanelTab>();
    public PanelTab SelectedTab { get; set; }
    public PanelTabType type;
    PanelTabControl parent; // only used if type == buttonbased
    Timer hoverChecker; // only used it hoverCheck == true
    bool drawBorders;
    public PanelTabControl(PanelTabType type, PanelTabControl parent = null, bool hoverCheck = true, bool drawBorders = true) {
        this.type = type;
        this.parent = parent;
        this.drawBorders = drawBorders;
        if (hoverCheck) {
            hoverChecker = new Timer();
            hoverChecker.Tick += (s, e) => UpdateHovers();
            hoverChecker.Interval = 10;
            hoverChecker.Start();
        }
    }

    protected virtual void OnTabChanged(EventArgs e) {
        if (TabChanged != null)
            TabChanged(this, e);
    }

    public void AddTab(PanelTab tab)
    {
        tabs.Add(tab);
        tab.lblButton.Click += (s, e) => SelectTab(tab, e);
        tab.pnlButton.Click += (s, e) => SelectTab(tab, e);
        tab.pnlButton.Paint += (s, e) => DrawButton(s, e);
        tab.pnlBox.Paint    += (s, e) => DrawPanel(s, e);
    }

    public void DrawPanel(object sender, PaintEventArgs e)
    {
        Panel p = (Panel)sender;
        if (p == null) return;
        PanelTab modifying = tabs.Find(tab => tab.pnlBox == p);
        int panelY = modifying.pnlBox.Location.Y;
        Pen myPen = new Pen(Color_PanelBackground);
        if (drawBorders)
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color_PanelOutline, ButtonBorderStyle.Solid);

        if (type == PanelTabType.VerticalAttatched) {
            // simple attatched appearance
            e.Graphics.DrawLine(myPen, 0, modifying.pnlButton.Top - (panelY - 1), 0, modifying.pnlButton.Bottom - (panelY + 2));
        } else if (type == PanelTabType.ButtonBased) {
            // simply remove the line at the top
            if (!parent.IsNull() && parent.type == PanelTabType.VerticalAttatched) {
                e.Graphics.DrawLine(myPen, 1, 0, modifying.pnlBox.Width - 1, 0);
                // if it has a parent which is a vertical type, handle attatched appearance
                PanelTab parentModifying = parent.SelectedTab;
                int parentPanelY = parentModifying.pnlBox.Location.Y;
                int topY = parentModifying.pnlButton.Top - (parentPanelY - 1) - panelY;
                int bottomY = parentModifying.pnlButton.Bottom - (parentPanelY + 2) - panelY;
                e.Graphics.DrawLine(myPen, 0, topY, 0, bottomY);
            }
        }
    }

    public void DrawButton(object sender, PaintEventArgs e)
    {
        Panel p = (Panel)sender;
        if (p == null) return;
        PanelTab modifying = tabs.Find(tab => tab.pnlButton == p);
        if (modifying == SelectedTab) {
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color_ButtonOutlineSelected, ButtonBorderStyle.Solid);
            return;
        }
        if (modifying.isHovered) {
            p.BackColor = Color_ButtonBackgroundHovered;
            modifying.lblButton.ForeColor = Color_ButtonTextHovered;
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color_ButtonOutlineSelected, ButtonBorderStyle.Solid);
        } else {
            p.BackColor = Color_ButtonBackground;
            modifying.lblButton.ForeColor = Color_ButtonText;
            ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color_ButtonOutline, ButtonBorderStyle.Solid);
        }
    }

    public void SelectTab(PanelTab tab, EventArgs e = null)
    {
        if (e != null && ((MouseEventArgs)e).Button != MouseButtons.Left) return;
        if (SelectedTab == tab) return;
        foreach (PanelTab ctab in tabs)
        {
            if (ctab == tab) continue;
            ctab.pnlBox.Visible = false;

            if (type == PanelTabType.VerticalAttatched)
                ctab.pnlButton.Size = new Size(tab.btnOriginalWidth, ctab.pnlButton.Size.Height);

            ctab.pnlButton.BackColor = Color_ButtonBackground;
            ctab.lblButton.ForeColor = Color_ButtonText;
        }
        tab.pnlBox.Visible = true;

        if (type == PanelTabType.VerticalAttatched)
            tab.pnlButton.Size = new Size(tab.btnOriginalWidth + (tab.pnlBox.Location.X - tab.pnlButton.Right) + 1, tab.pnlButton.Size.Height);

        tab.pnlButton.BackColor = Color_PanelBackground;
        tab.lblButton.ForeColor = Color_ButtonTextSelected;
        tab.pnlButton.BringToFront();
        tab.pnlBox.BringToFront();
        SelectedTab = tab;
        OnTabChanged(new EventArgs());
    }

    public void SelectTab(int tab)
    {
        SelectTab(tabs[tab]);
    }

    public void UpdateHovers()
    {
        foreach (PanelTab tab in tabs) {
            try { tab.UpdateHover(); } 
            catch (System.ObjectDisposedException) {
                hoverChecker.Stop();
                return;
            }
        }
    }

}

public class PanelTab {
    public Panel pnlButton;
    public Label lblButton;
    public Panel pnlBox;
    public int btnOriginalWidth;
    public bool isHovered;
    private bool old_isHovered;
    public PanelTab(Panel pnlButton, Label lblButton, Panel pnlBox)
    {
        this.pnlButton = pnlButton;
        this.lblButton = lblButton;
        this.pnlBox = pnlBox;
        btnOriginalWidth = pnlButton.Size.Width;
    }

    public void UpdateHover()
    {
        isHovered = pnlButton.ClientRectangle.Contains(pnlButton.PointToClient(Control.MousePosition));
        if (isHovered != old_isHovered) pnlButton.Refresh();
        old_isHovered = isHovered;
    }
}

public static class FormMethod
{

    [DllImport("user32.dll", EntryPoint = "ShowCaret")] public static extern long ShowCaret(IntPtr hwnd);
    [DllImport("user32.dll", EntryPoint = "HideCaret")] public static extern long HideCaret(IntPtr hwnd);

    public static void OpenFile(this OpenFileDialog ofd, TextBox txt, string filter) {
        ofd.Filter = filter;
        if (ofd.ShowDialog() == DialogResult.OK) txt.Text = ofd.FileName;
    }

    public static void SaveFile(this SaveFileDialog sfd, TextBox txt, string filter) {
        sfd.Filter = filter;
        if (sfd.ShowDialog() == DialogResult.OK) txt.Text = sfd.FileName;
    }

    public static void LockSize(this Form form)
    {
        Size toSet = form.Size;
        form.MinimumSize = toSet;
        form.MaximumSize = toSet;
    }

    public static void UnlockSize(this Form form) {
        Size toSet = new Size(0, 0);
        form.MinimumSize = toSet;
        form.MaximumSize = toSet;
    }

    public static void ChangeSize(this Form form, int w, int h) {
        form.UnlockSize();
        Size toSet = new Size(w, h);
        form.MinimumSize = toSet;
        form.MaximumSize = toSet;
        form.LockSize();
    }

    public static void CenterAlign(this Form f, Label l) {
        l.SizeChanged += (s, e) => {
            l.Left = (f.ClientSize.Width - l.Size.Width) / 2;
        };
    }

    public static void ApplyPlaceholder(this TextBox txt, string ph, Color phColor, Color normalColor, string passwordChar = null)
    {
        txt.ForeColor = phColor;
        txt.Text = ph;
        txt.PasswordChar = char.Parse("\0");
        bool isPassword = !string.IsNullOrEmpty(passwordChar);
        txt.GotFocus += (s, e) => { if (txt.Text == ph) { txt.Text = ""; txt.ForeColor = normalColor; if (isPassword) txt.PasswordChar = char.Parse(passwordChar); } };
        txt.LostFocus += (s, e) => { if (txt.Text == "") { txt.Text = ph; txt.ForeColor = phColor; txt.PasswordChar = char.Parse("\0"); } };
    }

    // Credits: https://stackoverflow.com/a/1926822/5699643
    public static void AppendText(this RichTextBox box, string text, Color color)
    {
        box.SelectionStart = box.TextLength;
        box.SelectionLength = 0;
        box.SelectionColor = color;
        box.AppendText(text);
        box.SelectionColor = box.ForeColor;
    }

    public static void Log(this RichTextBox box, string text, Color color)
    {
        string dateStr = DateTime.Now.ToString("h:mm:ss tt");
        box.AppendText($" [{dateStr}]: ", Color.FromArgb(51, 153, 255));
        box.AppendText(text + Environment.NewLine, color);
        box.SelectionStart = box.Text.Length;
        box.ScrollToCaret();
        FormMethod.HideCaret(box.Handle);
    }

    public static void Log(this RichTextBox box, string text)
    {
        Log(box, text, Color.White);
    }

    // Credits: https://stackoverflow.com/a/21605647/5699643
    public static void DrawComboBoxCentered(object sender, DrawItemEventArgs e)
    {
        ComboBox combo = (ComboBox)sender;
        if (combo == null) return;
        e.DrawBackground();
        if (e.Index >= 0) {
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            Brush brush = new SolidBrush(combo.ForeColor);
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                brush = SystemBrushes.HighlightText;
            e.Graphics.DrawString(combo.Items[e.Index].ToString(), combo.Font, brush, e.Bounds, sf);
        }
    }

    public static void UseColorDialog(this Label lbl, ColorDialog cd)
    {
        cd.Color = lbl.BackColor;
        if (cd.ShowDialog() == DialogResult.OK)
            lbl.BackColor = cd.Color;
    }

    public static void ChangeKey(this TextBox textBox, TextBox textDummy, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;
        textDummy.Select();
        textDummy.Focus();
        textBox.Text = "Waiting for key...";
        System.Threading.Thread KeyThread = new System.Threading.Thread(() => KeyManagement.KeyThread(ref textBox));
        KeyThread.IsBackground = true;
        KeyThread.Start();
    }

    public static void OnHover(this Label l, Color color) {
        Color originalColor = l.ForeColor;
        Cursor originalCursor = l.Cursor;
        l.MouseEnter += (s, e) => {
            l.ForeColor = color;
            l.Cursor = Cursors.Hand;
        };
        l.MouseLeave += (s, e) => {
            l.ForeColor = originalColor;
            l.Cursor = originalCursor;
        };
    }

}