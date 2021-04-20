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
            this.SuspendLayout();
            // 
            // InitText
            // 
            this.InitText.AutoSize = true;
            this.InitText.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InitText.Location = new System.Drawing.Point(0, 0);
            this.InitText.Name = "InitText";
            this.InitText.Size = new System.Drawing.Size(275, 19);
            this.InitText.TabIndex = 0;
            this.InitText.Text = "MisakiEQは起動処理をしています...";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(0, 44);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(282, 20);
            this.progress.TabIndex = 1;
            // 
            // Index
            // 
            this.Index.AutoSize = true;
            this.Index.Location = new System.Drawing.Point(2, 29);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(53, 12);
            this.Index.TabIndex = 2;
            this.Index.Text = "詳細情報";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 64);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.InitText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Init";
            this.Text = "Please wait...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Init_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InitText;
        public System.Windows.Forms.ProgressBar progress;
        public System.Windows.Forms.Label Index;
        private System.Windows.Forms.Timer timer1;
    }
}