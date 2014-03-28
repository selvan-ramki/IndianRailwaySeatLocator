using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IndianRailwaySeatLocator.Widgets
{
    public partial class SleeperWidget : UserControl
    {
        public SleeperWidget()
        {
            InitializeComponent();
        }

        public int No
        {
            set
            {
                if (value <= 0)
                    return;

                // Clear all highlight.
                ClearAllHighlight();

                // Highlight seat.
                int mod = value % 8;

                if (mod == 0)
                    mod = 8;

                // Highlight control.
                HighlightControl(mod, value);
            }
        }

        private void ClearAllHighlight()
        {
            lbl1.Text = string.Empty;
            lbl2.Text = string.Empty;
            lbl3.Text = string.Empty;
            lbl4.Text = string.Empty;
            lbl5.Text = string.Empty;
            lbl6.Text = string.Empty;
            lbl7.Text = string.Empty;
            lbl8.Text = string.Empty;

            lbl1.BackColor = Color.WhiteSmoke;
            lbl2.BackColor = Color.WhiteSmoke;
            lbl3.BackColor = Color.WhiteSmoke;
            lbl4.BackColor = Color.WhiteSmoke;
            lbl5.BackColor = Color.WhiteSmoke;
            lbl6.BackColor = Color.WhiteSmoke;
            lbl7.BackColor = Color.WhiteSmoke;
            lbl8.BackColor = Color.WhiteSmoke;
        }

        private void HighlightControl(int id, int value)
        {
            Label lbl = this.Controls.Find("lbl" + id, true).FirstOrDefault() as Label;
            if (lbl == null)
                return;

            lbl.BackColor = Color.Gray;
            lbl.Text = value.ToString() + " - " + GetBerthType(id);
        }

        private string GetBerthType(int id)
        {
            if (id == 1 || id == 4)
                return "L";
            else if (id == 2 || id == 5)
                return "M";
            else if (id == 3 || id == 6)
                return "U";
            else if (id == 7)
                return "SL";
            else if (id == 8)
                return "SU";
            else
                return string.Empty;
        }
    }
}
