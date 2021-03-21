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
    public partial class Form2 : Form //このフォームは緊急地震速報の文字スーパーです。
    {
        private static bool IsDisplaying = false;
        public Form2()
        {
            InitializeComponent();
            this.Visible = false;
        }
        public void SetVisible(bool IsVisible)
        {
            if (IsVisible)
            {
                Point a = new Point((Screen.PrimaryScreen.Bounds.Width-547)/2, 20);
                this.Location = a;
                this.Visible = true;
                IsDisplaying = true;
            }
            else
            {
                this.Visible = false;
                IsDisplaying = false;
            }
        }
        public bool GetVisible()
        {
            return IsDisplaying;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
    
    
}
