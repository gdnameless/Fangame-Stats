using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Fangame_Stats
{
    public partial class Stats : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        Settings Options = new Settings();
        int LastTick, Interval;
        
        K3 k3 = new K3();
        IWCTBG1 iwctbg1 = new IWCTBG1();
        Kaenbyou1 kaenbyou1 = new Kaenbyou1();

        public Stats()
        {
            InitializeComponent();
            /*Options.ShowDialog();
            ForeColor = Options.CText;
            BackColor = Options.CBackground;
            Font = new Font(FontFamily.GenericMonospace, 14, FontStyle.Bold);*/
            LastTick = Environment.TickCount;
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            Interval = Environment.TickCount - LastTick;
            LastTick = Environment.TickCount;
            if (Fangames.kaenbyou1.EnsureGame())
            {
                string s;
                s = Fangames.kaenbyou1.CurrentStatus;
                s += Environment.NewLine;
                s += Fangames.kaenbyou1.GetInformationFromTitle();
                s += Environment.NewLine;
                s += "Elapsed Time: " + Interval + "ms";
                Status.Text = s;
            }
            else
            {
                Status.Text = Fangames.kaenbyou1.CurrentStatus;
            }
            /*if (k3.EnsureGame())
            {
                string s;
                s = k3.CurrentStatus;
                s += Environment.NewLine;
                s += k3.GetInformationFromTitle();
                Status.Text = s;
            }
            else
            {
                Status.Text = k3.CurrentStatus;
            }*/
        }
    }
}
