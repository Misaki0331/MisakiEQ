using System.Drawing;
namespace MisakiEQ.Mini_Window
{
    partial class EEWDetail
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
            this.SignalType = new System.Windows.Forms.Label();
            this.MaxIntensity = new System.Windows.Forms.Label();
            this.MaxIntensityLabel = new System.Windows.Forms.Label();
            this.SignalCount = new System.Windows.Forms.Label();
            this.Magnitude = new System.Windows.Forms.Label();
            this.Hypocenter = new System.Windows.Forms.Label();
            this.Depth = new System.Windows.Forms.Label();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.OriginTime = new System.Windows.Forms.Label();
            this.AreaIntensityLabel = new System.Windows.Forms.Label();
            this.AreaIntensity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignalType
            // 
            this.SignalType.BackColor = System.Drawing.Color.Teal;
            this.SignalType.Font = new System.Drawing.Font("Meiryo UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SignalType.ForeColor = System.Drawing.Color.White;
            this.SignalType.Location = new System.Drawing.Point(0, 0);
            this.SignalType.Name = "SignalType";
            this.SignalType.Size = new System.Drawing.Size(610, 40);
            this.SignalType.TabIndex = 2;
            this.SignalType.Text = "現在緊急地震速報は発表されていません。";
            // 
            // MaxIntensity
            // 
            this.MaxIntensity.BackColor = System.Drawing.Color.Teal;
            this.MaxIntensity.Font = new System.Drawing.Font("MS UI Gothic", 62.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaxIntensity.ForeColor = System.Drawing.Color.White;
            this.MaxIntensity.Location = new System.Drawing.Point(1, 41);
            this.MaxIntensity.Name = "MaxIntensity";
            this.MaxIntensity.Size = new System.Drawing.Size(122, 138);
            this.MaxIntensity.TabIndex = 3;
            this.MaxIntensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxIntensityLabel
            // 
            this.MaxIntensityLabel.BackColor = System.Drawing.Color.Teal;
            this.MaxIntensityLabel.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaxIntensityLabel.ForeColor = System.Drawing.Color.White;
            this.MaxIntensityLabel.Location = new System.Drawing.Point(2, 41);
            this.MaxIntensityLabel.Name = "MaxIntensityLabel";
            this.MaxIntensityLabel.Size = new System.Drawing.Size(121, 27);
            this.MaxIntensityLabel.TabIndex = 4;
            this.MaxIntensityLabel.Text = "最大震度";
            this.MaxIntensityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignalCount
            // 
            this.SignalCount.BackColor = System.Drawing.Color.Gray;
            this.SignalCount.Font = new System.Drawing.Font("Meiryo UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SignalCount.ForeColor = System.Drawing.Color.White;
            this.SignalCount.Location = new System.Drawing.Point(0, 0);
            this.SignalCount.Name = "SignalCount";
            this.SignalCount.Size = new System.Drawing.Size(610, 40);
            this.SignalCount.TabIndex = 5;
            this.SignalCount.Text = "第 255 報 (最終報)";
            this.SignalCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Magnitude
            // 
            this.Magnitude.BackColor = System.Drawing.Color.Teal;
            this.Magnitude.Font = new System.Drawing.Font("Meiryo UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Magnitude.Location = new System.Drawing.Point(209, 115);
            this.Magnitude.Name = "Magnitude";
            this.Magnitude.Size = new System.Drawing.Size(170, 46);
            this.Magnitude.TabIndex = 7;
            this.Magnitude.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Hypocenter
            // 
            this.Hypocenter.BackColor = System.Drawing.Color.Teal;
            this.Hypocenter.Font = new System.Drawing.Font("Meiryo UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Hypocenter.Location = new System.Drawing.Point(124, 41);
            this.Hypocenter.Name = "Hypocenter";
            this.Hypocenter.Size = new System.Drawing.Size(486, 42);
            this.Hypocenter.TabIndex = 10;
            this.Hypocenter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Depth
            // 
            this.Depth.BackColor = System.Drawing.Color.Teal;
            this.Depth.Font = new System.Drawing.Font("Meiryo UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depth.Location = new System.Drawing.Point(431, 115);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(179, 46);
            this.Depth.TabIndex = 11;
            this.Depth.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // DepthLabel
            // 
            this.DepthLabel.BackColor = System.Drawing.Color.Teal;
            this.DepthLabel.Font = new System.Drawing.Font("Meiryo UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DepthLabel.Location = new System.Drawing.Point(366, 115);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(81, 46);
            this.DepthLabel.TabIndex = 12;
            this.DepthLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // OriginTime
            // 
            this.OriginTime.BackColor = System.Drawing.Color.Teal;
            this.OriginTime.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OriginTime.Location = new System.Drawing.Point(209, 74);
            this.OriginTime.Name = "OriginTime";
            this.OriginTime.Size = new System.Drawing.Size(399, 46);
            this.OriginTime.TabIndex = 13;
            this.OriginTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AreaIntensityLabel
            // 
            this.AreaIntensityLabel.BackColor = System.Drawing.Color.Teal;
            this.AreaIntensityLabel.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AreaIntensityLabel.ForeColor = System.Drawing.Color.White;
            this.AreaIntensityLabel.Location = new System.Drawing.Point(124, 84);
            this.AreaIntensityLabel.Name = "AreaIntensityLabel";
            this.AreaIntensityLabel.Size = new System.Drawing.Size(84, 21);
            this.AreaIntensityLabel.TabIndex = 15;
            this.AreaIntensityLabel.Text = "地域震度";
            this.AreaIntensityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AreaIntensity
            // 
            this.AreaIntensity.BackColor = System.Drawing.Color.Teal;
            this.AreaIntensity.Font = new System.Drawing.Font("MS UI Gothic", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AreaIntensity.ForeColor = System.Drawing.Color.White;
            this.AreaIntensity.Location = new System.Drawing.Point(124, 103);
            this.AreaIntensity.Name = "AreaIntensity";
            this.AreaIntensity.Size = new System.Drawing.Size(84, 58);
            this.AreaIntensity.TabIndex = 14;
            this.AreaIntensity.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // EEWDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(608, 161);
            this.Controls.Add(this.Hypocenter);
            this.Controls.Add(this.AreaIntensityLabel);
            this.Controls.Add(this.AreaIntensity);
            this.Controls.Add(this.OriginTime);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.Depth);
            this.Controls.Add(this.Magnitude);
            this.Controls.Add(this.MaxIntensityLabel);
            this.Controls.Add(this.MaxIntensity);
            this.Controls.Add(this.SignalType);
            this.Controls.Add(this.SignalCount);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EEWDetail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MisakiEQ 緊急地震速報";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EEWDetail_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label SignalType;
        private System.Windows.Forms.Label MaxIntensity;
        private System.Windows.Forms.Label MaxIntensityLabel;
        private System.Windows.Forms.Label SignalCount;
        private System.Windows.Forms.Label Magnitude;
        private System.Windows.Forms.Label Hypocenter;
        private System.Windows.Forms.Label Depth;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label OriginTime;
        private System.Windows.Forms.Label AreaIntensityLabel;
        private System.Windows.Forms.Label AreaIntensity;
    }
}