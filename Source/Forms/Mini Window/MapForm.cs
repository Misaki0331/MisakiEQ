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
    public partial class MapForm : Form
    {
        MisakiEQ.Map.MapDrawing _Map = new Map.MapDrawing();
        bool IsDraging = false;
        Point MousePoint;

        public MapForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.mainico;
            pictureBox1.Size = new Size(Size.Width - 7, Size.Height - 27);
            _Map.ReSize(Size.Width - 7, Size.Height - 27);
            this.pictureBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseWheel);
            LoadImage();
        }
        void LoadImage()
        {
                if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
                pictureBox1.Image = _Map.GetMapImage();
            
        }
        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
           
        }

        private void MapForm_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(Size.Width - 7, Size.Height - 27);
            _Map.ReSize(Size.Width - 7, Size.Height - 27);
            LoadImage();
        }

        private void MapForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Map.Dispose();
        }
        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            _Map.Zoom(_Map.GetZoom() + (e.Delta * SystemInformation.MouseWheelScrollLines / 60));
            Application.DoEvents();
            LoadImage();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MousePoint = Cursor.Position;
            IsDraging = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsDraging = false;
            Point t = Cursor.Position;
            _Map.Draging(new Point(t.X - MousePoint.X, t.Y - MousePoint.Y));
            MousePoint = t;
            LoadImage();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDraging)
            {
                Point t = Cursor.Position;
                
                _Map.Draging(new Point(t.X - MousePoint.X, t.Y - MousePoint.Y));
                MousePoint = t;
                Application.DoEvents();
                LoadImage();
            }
        }
    }
}
