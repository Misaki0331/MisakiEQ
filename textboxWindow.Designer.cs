namespace MisakiEQ
{
    partial class index
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
            this.Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Location = new System.Drawing.Point(0, 0);
            this.Box.Multiline = true;
            this.Box.Name = "Box";
            this.Box.ReadOnly = true;
            this.Box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Box.Size = new System.Drawing.Size(464, 321);
            this.Box.TabIndex = 0;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "index";
            this.Text = "textbox";
            this.SizeChanged += new System.EventHandler(this.index_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Box;
    }
}