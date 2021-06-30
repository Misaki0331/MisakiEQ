
namespace MisakiEQ.Setting
{
    partial class MapSettingForm
    {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapSettingForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Button_Up = new System.Windows.Forms.Button();
            this.Button_Right = new System.Windows.Forms.Button();
            this.Button_Down = new System.Windows.Forms.Button();
            this.Button_Left = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(277, 415);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 2;
            this.Confirm.Text = "決定";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(196, 415);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "キャンセル";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            this.Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cancel_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(252, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Button_Up
            // 
            this.Button_Up.Location = new System.Drawing.Point(196, 335);
            this.Button_Up.Name = "Button_Up";
            this.Button_Up.Size = new System.Drawing.Size(23, 23);
            this.Button_Up.TabIndex = 3;
            this.Button_Up.Text = "↑";
            this.Button_Up.UseVisualStyleBackColor = true;
            this.Button_Up.Click += new System.EventHandler(this.Button_Up_Click);
            // 
            // Button_Right
            // 
            this.Button_Right.Location = new System.Drawing.Point(218, 356);
            this.Button_Right.Name = "Button_Right";
            this.Button_Right.Size = new System.Drawing.Size(23, 23);
            this.Button_Right.TabIndex = 5;
            this.Button_Right.Text = "→";
            this.Button_Right.UseVisualStyleBackColor = true;
            this.Button_Right.Click += new System.EventHandler(this.Button_Right_Click);
            // 
            // Button_Down
            // 
            this.Button_Down.Location = new System.Drawing.Point(196, 377);
            this.Button_Down.Name = "Button_Down";
            this.Button_Down.Size = new System.Drawing.Size(23, 23);
            this.Button_Down.TabIndex = 6;
            this.Button_Down.Text = "↓";
            this.Button_Down.UseVisualStyleBackColor = true;
            this.Button_Down.Click += new System.EventHandler(this.Button_Down_Click);
            // 
            // Button_Left
            // 
            this.Button_Left.Location = new System.Drawing.Point(174, 356);
            this.Button_Left.Name = "Button_Left";
            this.Button_Left.Size = new System.Drawing.Size(23, 23);
            this.Button_Left.TabIndex = 4;
            this.Button_Left.Text = "←";
            this.Button_Left.UseVisualStyleBackColor = true;
            this.Button_Left.Click += new System.EventHandler(this.Button_Left_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(164, 329);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 71);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(134, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "---.----E\r\n--.----N";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MapSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(352, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Left);
            this.Controls.Add(this.Button_Down);
            this.Controls.Add(this.Button_Right);
            this.Controls.Add(this.Button_Up);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapSettingForm";
            this.ShowInTaskbar = false;
            this.Text = "座標を選択...";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MapSettingForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Button_Up;
        private System.Windows.Forms.Button Button_Right;
        private System.Windows.Forms.Button Button_Down;
        private System.Windows.Forms.Button Button_Left;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}