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
    public partial class Preview : Form
    {
        public Preview(Color Text, Color Background)
        {
            InitializeComponent();
            label1.ForeColor = Text;
            BackColor = Background;
        }
    }
}
