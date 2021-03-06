using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MisakiEQ
{
    public partial class Init : Form
    {
        bool still = true;
        private void thread()
        {
            while (true)
            {
                Application.DoEvents();
                
                Thread.Sleep(1);
                if (!still) break;
            }
        }
        public Init()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.mainico;
            this.StartPosition = FormStartPosition.CenterScreen;
            ControlBox = false;
            Thread t = new Thread(new ThreadStart(thread));
            t.Start();
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
            Close();
        }

        private void Init_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = still;
        }
        public void Done()
        {
            still = false;
            this.Text = "Done.";
            timer1.Start();
        }
    }
}
