using System.Drawing;
using System.Windows.Forms;
namespace MisakiEQ.Mini_Window
{
    public partial class KyoshinWindow : Form
    {
        Image Temp;
        public KyoshinWindow()
        {
            Initialize();
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

        private void Initialize()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KyoshinWindow));
            this.SuspendLayout();
            // 
            // KyoshinWindow
            // 
            this.Location = new Point(0, 0);
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Icon = Properties.Resources.mainico;
            this.Name = "KyoshinWindow";
            this.ResumeLayout(false);

        }
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MisakiEQ.Properties.Resources.Kyoshin_Basemap;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // KyoshinWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(352, 400);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(368, 439);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(368, 439);
            this.Name = "KyoshinWindow";
            this.ShowInTaskbar = false;
            this.Text = "強震モニタ";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KyoshinWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
