using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisakiEQ.Setting
{
    
    public unsafe partial class MapSettingForm : Form
    {
        unsafe Point* ConfirmPos;
        public bool IsClosed;
        public bool IsConfirmed;
        Point Temp;
        Bitmap canvas;
        Bitmap check;
        Bitmap Zoom;
        public MapSettingForm(Point* Confirming,Point WindowPos)
        {
            
            Init();
            if (WindowPos != null)this.Location = WindowPos;
            
            this.ConfirmPos =  Confirming;
            Draw(*ConfirmPos);
            Temp = *ConfirmPos;
            Show();
        }
        void Init()
        {
            InitializeComponent();
            canvas = new Bitmap(352, 400);
            Zoom = new Bitmap(25, 25);
            check = new Bitmap(352, 400);
            Graphics g = Graphics.FromImage(check);
            g.DrawImage(Properties.Resources.basemap_shadow, new Point(0, 0));
            g.Dispose();
        }
        void Draw(Point check)
        {
            ZoomDraw(check);

            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);
            g.Clear(Color.Black);
            g.DrawImage(Properties.Resources.basemap_Alpha, new Point(0, 0));
            g.DrawLine(Pens.Red, new Point(check.X - 3, check.Y), new Point(check.X + 3, check.Y));
            g.DrawLine(Pens.Red, new Point(check.X, check.Y - 3), new Point(check.X, check.Y + 3));
            pictureBox1.Image = canvas;
            g.Dispose();
            ZoomDraw(check);
            //canvas.Dispose();
        }
        void ZoomDraw(Point check)
        {
            Graphics g = Graphics.FromImage(Zoom);
            g.Clear(Color.Black);
            g.DrawImage(Properties.Resources.basemap_Alpha, new Point(-check.X+12,-check.Y+12));
            g.DrawLine(Pens.Red, new Point(12, 11),new Point(12,13));
            g.DrawLine(Pens.Red, new Point(11, 12),new Point(13,12));
            pictureBox2.Image = Zoom;
            g.Dispose();


        }
            private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private bool IsRand(Point Pos)
        {
            try
            {
                Color col = check.GetPixel(Temp.X, Temp.Y);

                if (col.R == 0 && col.G == 0 && col.B == 0)
                {
                    return false;

                }
                else
                {
                    return true;

                }
            }
            catch
            {
                return false;
            }

        }
        private void Confirm_Click(object sender, EventArgs e)
        {
            *ConfirmPos = Temp;
            IsConfirmed = true;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MapSettingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClosed = true;
            canvas.Dispose();
            this.Dispose();
        }

        private void Cancel_MouseDown(object sender, MouseEventArgs e)
        {
            PosUpdate();
            timer1.Start();
        }
        void PosUpdate()
        {
            Point sp = Cursor.Position;
            // クライアント座標に変換
            Point cp = this.PointToClient(sp);
            Draw(cp);
        Temp = cp;
            if (IsRand(cp))
            {
                Confirm.Enabled = true;
                Confirm.Text = "決定";
            }
            else
            {
                Confirm.Enabled = false;
                Confirm.Text = "指定不可";
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            PosUpdate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            PosUpdate();
            timer1.Stop();
        }
    }
}
