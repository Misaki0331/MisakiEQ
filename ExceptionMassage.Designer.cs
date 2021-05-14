namespace MisakiEQ
{
    partial class ExceptionMassage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorIndex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserReport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RestartButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(43, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "MisakiEQは問題が発生したため\r\n終了する必要があります。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "エラーが発生した手順を踏まえて、バグを報告して頂けると嬉しいです。\r\n「なんか知らないけどバグった」という理由はNGです。\r\n";
            // 
            // ErrorIndex
            // 
            this.ErrorIndex.Location = new System.Drawing.Point(0, 250);
            this.ErrorIndex.MaxLength = 65535;
            this.ErrorIndex.Multiline = true;
            this.ErrorIndex.Name = "ErrorIndex";
            this.ErrorIndex.ReadOnly = true;
            this.ErrorIndex.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ErrorIndex.Size = new System.Drawing.Size(696, 176);
            this.ErrorIndex.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "お役立ちリンク";
            // 
            // UserReport
            // 
            this.UserReport.Location = new System.Drawing.Point(0, 104);
            this.UserReport.MaxLength = 65535;
            this.UserReport.Multiline = true;
            this.UserReport.Name = "UserReport";
            this.UserReport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.UserReport.Size = new System.Drawing.Size(696, 126);
            this.UserReport.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "レポート";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "開発者TwitterのDMに送信";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "エラー詳細情報";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(534, 428);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(78, 23);
            this.RestartButton.TabIndex = 9;
            this.RestartButton.Text = "再起動";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "終了";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExceptionMassage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserReport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ErrorIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExceptionMassage";
            this.Text = "エラー - MisakiEQ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExceptionMassage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ErrorIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button button2;
    }
}