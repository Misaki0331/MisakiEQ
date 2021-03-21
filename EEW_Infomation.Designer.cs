namespace MisakiEQ
{
    partial class EEW_Infomation
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
            this.EEW_Image = new System.Windows.Forms.PictureBox();
            this.Description = new System.Windows.Forms.Label();
            this.Index = new System.Windows.Forms.Label();
            this.GraphText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EEW_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // EEW_Image
            // 
            this.EEW_Image.Image = global::MisakiEQ.Properties.Resources.EEW;
            this.EEW_Image.Location = new System.Drawing.Point(0, 0);
            this.EEW_Image.Name = "EEW_Image";
            this.EEW_Image.Size = new System.Drawing.Size(1206, 431);
            this.EEW_Image.TabIndex = 1;
            this.EEW_Image.TabStop = false;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(115)))), ((int)(((byte)(202)))));
            this.Description.Cursor = System.Windows.Forms.Cursors.Default;
            this.Description.Font = new System.Drawing.Font("HGPｺﾞｼｯｸM", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Description.ForeColor = System.Drawing.Color.Yellow;
            this.Description.Location = new System.Drawing.Point(336, 101);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(244, 48);
            this.Description.TabIndex = 2;
            this.Description.Text = "Description";
            // 
            // Index
            // 
            this.Index.AutoSize = true;
            this.Index.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(115)))), ((int)(((byte)(202)))));
            this.Index.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Index.ForeColor = System.Drawing.Color.White;
            this.Index.Location = new System.Drawing.Point(342, 162);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(731, 64);
            this.Index.TabIndex = 3;
            this.Index.Text = "神奈川 福島 北海道 東京";
            // 
            // GraphText
            // 
            this.GraphText.AutoSize = true;
            this.GraphText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(91)))), ((int)(((byte)(145)))));
            this.GraphText.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GraphText.ForeColor = System.Drawing.Color.White;
            this.GraphText.Location = new System.Drawing.Point(12, 20);
            this.GraphText.Name = "GraphText";
            this.GraphText.Size = new System.Drawing.Size(281, 380);
            this.GraphText.TabIndex = 4;
            this.GraphText.Text = "規模 : M7.2\r\n深さ : 50 km\r\n最大震度 : ６強\r\n\r\n2021/03/21 \r\n23:59:59発生\r\n\r\n第369報(最終)\r\n\r\n0:01:" +
    "24発表";
            // 
            // EEW_Infomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 427);
            this.Controls.Add(this.GraphText);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.EEW_Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EEW_Infomation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EEW_Infomation";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EEW_Infomation_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.EEW_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox EEW_Image;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Index;
        private System.Windows.Forms.Label GraphText;
    }
}