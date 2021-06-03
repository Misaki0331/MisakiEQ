using System.Drawing;
using System.Windows.Forms;
namespace MisakiEQ.Mini_Window
{
    public partial class KyoshinWindow : Form
    {
        Image Temp;
        public KyoshinWindow()
        {
            InitializeComponent();
        }
        public void UpdateKyoshin(ref Image Data)
        {
            if (this.Enabled)
            {
                pictureBox1.Image = Data;
            }
            else
            {
                Temp = Data;
            }
        }
        public void UpdateWindow(bool status)
        {
            if (status)
            {
                Enabled = true;
                Visible = true;
                Show();
                if (Temp != null) pictureBox1.Image = Temp;
                Temp = null;
            }
            else
            {
                Enabled = false;
                Visible = false;
                Hide();
            }
        }

        private void KyoshinWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            UpdateWindow(false);
        }
    }
}
