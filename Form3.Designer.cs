namespace MisakiEQ
{
    partial class TwitterAuthWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.PinBox = new System.Windows.Forms.TextBox();
            this.AuthEnter = new System.Windows.Forms.Button();
            this.DisplayPin = new System.Windows.Forms.Button();
            this.DisplayPassword = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "認証時に表示されるPINコードを入力...";
            // 
            // PinBox
            // 
            this.PinBox.Font = new System.Drawing.Font("OCRA", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinBox.Location = new System.Drawing.Point(2, 15);
            this.PinBox.MaxLength = 7;
            this.PinBox.Name = "PinBox";
            this.PinBox.PasswordChar = '*';
            this.PinBox.Size = new System.Drawing.Size(192, 51);
            this.PinBox.TabIndex = 1;
            // 
            // AuthEnter
            // 
            this.AuthEnter.Location = new System.Drawing.Point(201, 45);
            this.AuthEnter.Name = "AuthEnter";
            this.AuthEnter.Size = new System.Drawing.Size(70, 21);
            this.AuthEnter.TabIndex = 2;
            this.AuthEnter.Text = "認証";
            this.AuthEnter.UseVisualStyleBackColor = true;
            this.AuthEnter.Click += new System.EventHandler(this.AuthEnter_Click);
            // 
            // DisplayPin
            // 
            this.DisplayPin.Location = new System.Drawing.Point(201, 16);
            this.DisplayPin.Name = "DisplayPin";
            this.DisplayPin.Size = new System.Drawing.Size(70, 23);
            this.DisplayPin.TabIndex = 3;
            this.DisplayPin.Text = "PIN再表示";
            this.DisplayPin.UseVisualStyleBackColor = true;
            this.DisplayPin.Click += new System.EventHandler(this.DisplayPin_Click);
            // 
            // DisplayPassword
            // 
            this.DisplayPassword.Interval = 5000;
            this.DisplayPassword.Tick += new System.EventHandler(this.DisplayPassword_Tick);
            // 
            // TwitterAuthWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 70);
            this.Controls.Add(this.DisplayPin);
            this.Controls.Add(this.AuthEnter);
            this.Controls.Add(this.PinBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TwitterAuthWindow";
            this.Text = "Twitter認証";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TwitterAuthWindow_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PinBox;
        private System.Windows.Forms.Button AuthEnter;
        private System.Windows.Forms.Button DisplayPin;
        private System.Windows.Forms.Timer DisplayPassword;
    }
}