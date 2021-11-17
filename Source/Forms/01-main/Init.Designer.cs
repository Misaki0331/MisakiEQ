namespace MisakiEQ
{
    partial class Init
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
            this.InitText = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.Index = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // InitText
            // 
            this.InitText.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InitText.Location = new System.Drawing.Point(1, 104);
            this.InitText.Name = "InitText";
            this.InitText.Size = new System.Drawing.Size(453, 27);
            this.InitText.TabIndex = 0;
            this.InitText.Text = "MisakiEQは起動処理をしています...";
            this.InitText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(1, 160);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(453, 24);
            this.progress.TabIndex = 1;
            // 
            // Index
            // 
            this.Index.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Index.Location = new System.Drawing.Point(-1, 131);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(455, 26);
            this.Index.TabIndex = 2;
            this.Index.Text = "詳細情報";
            this.Index.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logo.Image = global::MisakiEQ.Properties.Resources.header_logo;
            this.logo.Location = new System.Drawing.Point(-9, -1);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(475, 102);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(455, 185);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.InitText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Init";
            this.Text = "Please wait...";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Init_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InitText;
        public System.Windows.Forms.ProgressBar progress;
        public System.Windows.Forms.Label Index;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox logo;
    }
}