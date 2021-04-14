using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisakiEQ
{
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
        }
        public void SetInfo(int percent,string text)
        {
            if (percent < 0) percent = 0;
            if (percent > 100) percent = 100;
            progress.Value = percent;
            Index.Text = text;
            Application.DoEvents();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
