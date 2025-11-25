using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Proyect_Sencom_Form.Business
{//clase encargada del modo oscuro
    public enum AppTheme { Light, Dark }

    public static class ThemeManager
    {
        private static readonly string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "theme.txt");
        public static AppTheme CurrentTheme { get; private set; } = AppTheme.Light;

        public static void LoadTheme()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    var t = File.ReadAllText(_filePath).Trim().ToLower();
                    CurrentTheme = t == "dark" ? AppTheme.Dark : AppTheme.Light;
                }
            }
            catch { CurrentTheme = AppTheme.Light; }
        }

        public static void SaveTheme()
        {
            try { File.WriteAllText(_filePath, CurrentTheme == AppTheme.Dark ? "dark" : "light"); } catch { }
        }

        public static void ToggleTheme()
        {
            CurrentTheme = CurrentTheme == AppTheme.Dark ? AppTheme.Light : AppTheme.Dark;
            SaveTheme();
            ApplyThemeToAllOpenForms();
        }

        public static void ApplyThemeToAllOpenForms()
        {
            foreach (Form f in Application.OpenForms)
                ApplyTheme(f);
        }

        public static void ApplyTheme(Form form)
        {
            if (form == null) return;
            bool dark = CurrentTheme == AppTheme.Dark;

            form.BackColor = dark ? Color.FromArgb(45, 45, 48) : Color.Gainsboro;
            Color panelColor = dark ? Color.FromArgb(55, 55, 58) : Color.WhiteSmoke;
            Color headerColor = dark ? Color.FromArgb(30, 30, 32) : Color.SteelBlue;
            Color textColor = dark ? Color.WhiteSmoke : Color.Black;
            Color primaryBtn = dark ? Color.FromArgb(0, 90, 170) : Color.SteelBlue;
            Color secondaryBtn = dark ? Color.FromArgb(80, 80, 85) : Color.DimGray;
            Color inputBack = dark ? Color.FromArgb(30, 30, 32) : SystemColors.Window;
            Color gridBack = dark ? Color.FromArgb(40, 40, 43) : SystemColors.Window;

            Action<Control> applyRecursive = null;
            applyRecursive = c =>
            {
                if (c is Panel p)
                {
                    // header heuristic: has label with large font or name contains "header"
                    if (p.Name.ToLower().Contains("header")) p.BackColor = headerColor; else p.BackColor = panelColor;
                }
                else if (c is Label lbl)
                {
                    lbl.ForeColor = textColor;
                }
                else if (c is Button b)
                {
                    b.FlatStyle = FlatStyle.Flat;
                    b.ForeColor = Color.White;
                    b.BackColor = (b.BackColor == Color.SteelBlue || b.Text.ToLower().Contains("generar") || b.Text.ToLower().Contains("iniciar")) ? primaryBtn : secondaryBtn;
                }
                else if (c is TextBox tb)
                {
                    tb.BackColor = inputBack;
                    tb.ForeColor = textColor;
                    tb.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (c is DataGridView gv)
                {
                    gv.BackgroundColor = gridBack;
                    gv.ForeColor = textColor;
                    gv.EnableHeadersVisualStyles = false;
                    gv.ColumnHeadersDefaultCellStyle.BackColor = dark ? Color.FromArgb(25, 25, 28) : SystemColors.Control;
                    gv.ColumnHeadersDefaultCellStyle.ForeColor = textColor;
                    gv.DefaultCellStyle.BackColor = gridBack;
                    gv.DefaultCellStyle.ForeColor = textColor;
                    gv.GridColor = dark ? Color.FromArgb(70, 70, 73) : SystemColors.ControlDark;
                }

                foreach (Control child in c.Controls)
                    applyRecursive(child);
            };

            applyRecursive(form);
        }
    }
}
