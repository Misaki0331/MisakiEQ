using System;
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
    public partial class EEW_Infomation : Form
    {
        private bool IsDisplaying;
        private string EEW_Index;
        private string EEW_Description;
        private string EEW_GraphText;
        public EEW_Infomation()
        {
            InitializeComponent();
            this.Visible = false;
        }
        public void SetVisible(bool IsVisible)
        {
            if (IsVisible)
            {
                Point a = new Point((Screen.PrimaryScreen.Bounds.Width - 1218) / 2, Screen.PrimaryScreen.Bounds.Height-496);
                
                this.Location = a;
                Description.Text = EEW_Description;
                if (EEW_Description == null) Description.Text = "データを取得できませんでした。";
                Index.Text = EEW_Index;
                if(EEW_Index==null)Index.Text= "データを取得できませんでした。";
                GraphText.Text = EEW_GraphText;
                IsDisplaying = true;
                this.Visible = true;
            }
            else
            {
                this.Visible = false;
                IsDisplaying = false;
            }
        }
        public bool GetVisible()
        {
            return IsDisplaying;
        }
        public void SetIndex(string str)
        {
            EEW_Index = str;
            Index.Text = EEW_Index;
            if (EEW_Index == null) Index.Text = "データを取得できませんでした。";
        }
        public void SetDescription(string str)
        {
            EEW_Description = str;
            Description.Text = EEW_Description;
            if (EEW_Description == null) Description.Text = "データを取得できませんでした。";
        }
        public void SetGraphText(string str)
        {
            EEW_GraphText = str;
            GraphText.Text = EEW_GraphText;
        }
        public string GetGraphText()
        {
            return EEW_GraphText;
        }
        public string GetIndex()
        {
            return EEW_Index;
        }
        public string GetDescription()
        {
            return EEW_Description;
        }

        private void EEW_Infomation_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

    }
}
