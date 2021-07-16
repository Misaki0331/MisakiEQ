using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisakiEQ.Mini_Window
{
    public struct EEWDetails
    {
        public string SignalType;       //警報/予報/キャンセル
        public int SignalCount;         //報数
        public bool IsFinal;            //最終報 
        public string Hypocenter;       //震源地
        public string OriginTime;     //発生時刻
        public string Magnitude;        //地震の規模
        public string Depth;               //震源の深さ
        public string MaxIntensity;     //最大震度
        public string AreaIntensity;    //地域震度


    }
    public partial class EEWDetail : Form
    {
        public EEWDetail()
        {
            InitializeComponent();
            Hide();
        }
        public void reset()
        {
            EEWDetails d = new EEWDetails();
            SetStatus(d);
        }
        public void SetStatus(EEWDetails details)
        {
            SignalType.Size = new Size(319, 40);
            switch (details.SignalType)
            {
                case "警報":
                    SignalType.Text = "緊急地震速報 (警報)";
                    SignalType.BackColor = Color.OrangeRed;
                    SignalCount.BackColor = Color.OrangeRed;
                    DepthLabel.Text = "深さ";

                    break;
                case "予報":
                    SignalType.Text = "緊急地震速報 (予報)";
                    SignalType.BackColor = Color.DarkOrange;
                    SignalCount.BackColor = Color.DarkOrange;
                    DepthLabel.Text = "深さ";
                    break;
                case "キャンセル":
                    SignalType.Text = "キャンセルされました";
                    SignalType.BackColor = Color.Gray;
                    SignalCount.BackColor = Color.Gray;
                    DepthLabel.Text = "深さ";
                    break;
                default:
                    SignalType.Text = "現在緊急地震速報は発表されていません。";
                    SignalType.Size = new Size(610, 40);
                    SignalType.BackColor = Color.Teal;
                    SignalCount.BackColor = Color.Teal;
                    DepthLabel.Text = "";
                    break;
            }
            Color MaxIntensityColor;
            SignalCount.Text = $"第 {details.SignalCount} 報";
            if (details.IsFinal) SignalCount.Text += " (最終報)";
            Hypocenter.Text = details.Hypocenter;
            Magnitude.Text = details.Magnitude;
            OriginTime.Text = details.OriginTime;
            switch (details.MaxIntensity)
            {
                case "0":
                    MaxIntensityColor = Color.Gray;
                    break;
                case "1":
                    MaxIntensityColor = Color.Gray;
                    break;
                case "2":
                    MaxIntensityColor = Color.RoyalBlue;
                    break;
                case "3":
                    MaxIntensityColor = Color.SeaGreen;
                    break;
                case "4":
                    MaxIntensityColor = Color.FromArgb(255, 191, 191, 15);
                    break;
                case "5-":
                    MaxIntensityColor = Color.OrangeRed;
                    break;
                case "5+":
                    MaxIntensityColor = Color.OrangeRed;
                    break;
                case "6-":
                    MaxIntensityColor = Color.Pink;
                    break;
                case "6+":
                    MaxIntensityColor = Color.Pink;
                    break;
                case "7":
                    MaxIntensityColor = Color.Purple;
                    break;
                case "-":
                    MaxIntensityColor = Color.Gray;
                    break;
                default:
                    MaxIntensityColor = Color.Teal;
                    break;
            }
            MaxIntensity.Text = details.MaxIntensity;
            Hypocenter.BackColor = MaxIntensityColor;
            OriginTime.BackColor = MaxIntensityColor;
            Magnitude.BackColor = MaxIntensityColor;
            Depth.BackColor = MaxIntensityColor;
            DepthLabel.BackColor = MaxIntensityColor;
            MaxIntensity.BackColor = MaxIntensityColor;
            MaxIntensityLabel.BackColor = MaxIntensityColor;
            if (details.MaxIntensity == "6-" || details.MaxIntensity == "6+")
            {
                MaxIntensityColor = Color.Red;
            }
            else
            {
                MaxIntensityColor = Color.White;
            }
            Hypocenter.ForeColor = MaxIntensityColor;
            OriginTime.ForeColor = MaxIntensityColor;
            Magnitude.ForeColor = MaxIntensityColor;
            Depth.ForeColor = MaxIntensityColor;
            DepthLabel.ForeColor = MaxIntensityColor;
            MaxIntensity.ForeColor = MaxIntensityColor;
            MaxIntensityLabel.ForeColor = MaxIntensityColor;
            switch (details.AreaIntensity)
            {
                case "0":
                    MaxIntensityColor = Color.Gray;
                    break;
                case "1":
                    MaxIntensityColor = Color.Gray;
                    break;
                case "2":
                    MaxIntensityColor = Color.RoyalBlue;
                    break;
                case "3":
                    MaxIntensityColor = Color.SeaGreen;
                    break;
                case "4":
                    MaxIntensityColor = Color.FromArgb(255, 191, 191, 15);
                    break;
                case "5-":
                    MaxIntensityColor = Color.OrangeRed;
                    break;
                case "5+":
                    MaxIntensityColor = Color.OrangeRed;
                    break;
                case "6-":
                    MaxIntensityColor = Color.Pink;
                    break;
                case "6+":
                    MaxIntensityColor = Color.Pink;
                    break;
                case "7":
                    MaxIntensityColor = Color.Purple;
                    break;
                case "-":
                    MaxIntensityColor = Color.Gray;
                    break;
                default:
                    MaxIntensityColor = Color.Teal;
                    break;
            }
            AreaIntensity.Text = details.AreaIntensity;
            AreaIntensity.BackColor = MaxIntensityColor;
            AreaIntensityLabel.BackColor = MaxIntensityColor;
            Depth.Text = details.Depth;
            if (details.AreaIntensity == "6-" || details.AreaIntensity == "6+")
            {
                MaxIntensityColor = Color.Red;
            }
            else
            {
                MaxIntensityColor = Color.White;
            }
            AreaIntensity.ForeColor = MaxIntensityColor;
            AreaIntensityLabel.ForeColor = MaxIntensityColor;
        }

        private void EEWDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
