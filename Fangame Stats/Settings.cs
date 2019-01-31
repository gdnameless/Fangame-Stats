using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fangame_Stats
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            colorDialog1.FullOpen = true;
        }

        public Color CText = Color.Black, CBackground = Color.FromArgb(0, 160, 255);
        Preview PreviewWindow;

        private void SelectTextColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = CText;
            colorDialog1.ShowDialog();
            CText = colorDialog1.Color;
        }

        private void SelectBackgroundColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = CBackground;
            colorDialog1.ShowDialog();
            CBackground = colorDialog1.Color;
        }

        private void Preview_Click(object sender, EventArgs e)
        {
            PreviewWindow = new Preview(CText, CBackground);
            PreviewWindow.ShowDialog();
        }
    }
}
