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
        DataConverter converter = new DataConverter();
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
            g.DrawLine(Pens.Red, new Point(check.X - 5, check.Y - 5), new Point(check.X + 5, check.Y + 5));
            g.DrawLine(Pens.Red, new Point(check.X - 5, check.Y + 5), new Point(check.X + 5, check.Y - 5));
            pictureBox1.Image = canvas;
            g.Dispose();
            ZoomDraw(check);
            // Pos.X = 127.21225 + Map.X * 0.05075;//-0.7
            // Pos.Y = 46.12000 - Map.Y * 0.04;
            System.Windows.Point LAL = DataConverter.KyoshinMapToLAL(check);
            label1.Text = $"{LAL.X}E\n{LAL.Y}N";
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
            if (Temp.X >= 0 && Temp.X < 352 && Temp.Y >= 0 && Temp.Y < 400)
            {
                *ConfirmPos = Temp;
                IsConfirmed = true;
                Close();
            }
            else
            {
                Hide();
                throw new IndexOutOfRangeException("不正な座標です。");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {

            PosUpdate();
            timer1.Start();
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
            
        }
        void PosUpdate()
        {
            Point sp = Cursor.Position;
            // クライアント座標に変換
            Point cp = this.PointToClient(sp);
            Draw(cp);
            Temp = cp;
            ButtonEnable(Temp);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            PosUpdate();
        }

        
        void ButtonUpdate()
        {
 
            Button_Up.Enabled =Temp.Y>0;
            Button_Right.Enabled =Temp.X<351;
            Button_Down.Enabled =Temp.Y<399;
            Button_Left.Enabled =Temp.X>0;
        }
        private void Button_Up_Click(object sender, EventArgs e)
        {
            if (Temp.Y > 0)Temp.Y--;
            Draw(Temp);
            ButtonEnable(Temp);
        }

        private void Button_Right_Click(object sender, EventArgs e)
        {
            if (Temp.X < 351)Temp.X++;
            Draw(Temp);
            ButtonEnable(Temp);
        }

        private void Button_Down_Click(object sender, EventArgs e)
        {
            if (Temp.Y < 399)Temp.Y++;
            Draw(Temp);
            ButtonEnable(Temp);
        }

        private void Button_Left_Click(object sender, EventArgs e)
        {
            if (Temp.X > 0)Temp.X--;
            Draw(Temp);
            ButtonEnable(Temp);
            
        }
        void ButtonEnable(Point cs)
        {
            if (IsRand(cs))
            {
                Confirm.Enabled = true;
                Confirm.Text = "決定";
            }
            else
            {
                Confirm.Enabled = false;
                Confirm.Text = "指定不可";
            }
            ButtonUpdate();
        }

        private void MapSettingForm_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
            
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            PosUpdate();
            timer1.Stop();
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            


        }

        private void pictureBox1_DragLeave(object sender, EventArgs e)
        {
            
        }
    }
}
