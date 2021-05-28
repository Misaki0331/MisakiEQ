﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisakiEQ
{
    public partial class index : Form
    {
        public index(string title,string index)
        {
            InitializeComponent();
            this.Text = title;
            string[] result = index.Split(new char[] { '\n' });
            
            this.Box.Lines = result;
        }

        private void index_SizeChanged(object sender, EventArgs e)
        {
            Size a = new Size(Size.Width - 16, Size.Height - 39);
            Box.Size = a;
        }
    }
}
