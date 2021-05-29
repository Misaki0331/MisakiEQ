﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Management;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Interop;
using System.Management;
namespace MisakiEQ
{
    public partial class ExceptionMassage : Form
    {
        
        string index;
        public ExceptionMassage(string str)
        {
            InitializeComponent();
            //Misaki_Image.Controls.Add(label4);
            string[] result = str.Split(new char[] { '\n' });
            this.ErrorIndex.Lines = result;
            index = str;
            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);
            g.DrawIcon(SystemIcons.Error, 0, 0);
            g.Dispose();

            //PictureBox1に表示する
            pictureBox1.Image = canvas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SpecText="";
            System.Management.ManagementClass mc = new System.Management.ManagementClass("Win32_OperatingSystem");
            System.Management.ManagementObjectCollection moc = mc.GetInstances();

            foreach (System.Management.ManagementObject mo in moc)
            {
                // OSの情報
                // エディション
                SpecText="エディション : " + mo["Caption"].ToString()+"\n";

                // バージョン
                SpecText+="バージョン : " + mo["Version"].ToString()+"\n";

                // ビルド番号
                SpecText += "ビルド番号 : " + mo["BuildNumber"].ToString()+"\n";


                // メモリー情報

                SpecText += "空き物理メモリ : " + (Convert.ToInt32(mo["FreePhysicalMemory"]) / 1024 ).ToString()
                    + " MB / "+ (Convert.ToInt32(mo["TotalVisibleMemorySize"]) / 1024).ToString()+" MB\n";
                SpecText += "空き仮想メモリ : " + (Convert.ToInt32(mo["FreeVirtualMemory"]) / 1024).ToString()
                    + " MB / " + (Convert.ToInt32(mo["TotalVirtualMemorySize"]) / 1024).ToString() + " MB\n";
                
            }
            SpecText += "\n";
            mc = new ManagementClass("Win32_ComputerSystemProduct");
            // CPU一覧を取得
            moc = mc.GetInstances();

            foreach (var mo in moc)
            {
                SpecText += "製造会社名 : " + mo.Properties["Vendor"].Value + "\n";
                SpecText += "モデル名 : " + mo.Properties["Name"].Value + "\n";
                SpecText += "モデルバージョン : " + mo.Properties["Version"].Value + "\n";
                SpecText += "PCの概要 : " + mo.Properties["Caption"].Value + "\n";
                mo.Dispose();
            }

            
            SpecText += "\n";
            mc = new ManagementClass("CIM_System");
            // CPU一覧を取得
            moc = mc.GetInstances();
            foreach (var mo in moc)
            {
                SpecText += "ドメイン : " + mo.Properties["Domain"].Value + "\n";
                SpecText += "PCの名称 : " + mo.Properties["Vendor"].Value + "\n";
                SpecText += "管理者 : " + mo.Properties["PrimaryOwnerName"].Value + "\n";
                mo.Dispose();
            }
                
            SpecText += "使用ユーザー : " + Environment.UserName+"\n";
            SpecText += "\n";
            // クラスを取得
            mc = new ManagementClass("Win32_Processor");
            // CPU一覧を取得
            moc = mc.GetInstances();

            //Console.WriteLine("-------------------------");
            // CPU情報を一つずつ取り出す
            SpecText += "\nCPU情報\n-------------------------\n";
            foreach (ManagementObject mo in moc)
            {
                SpecText += "デバイスID : " + mo["DeviceID"]+ "\n" ;
                SpecText += "CPU型番 : " + mo["Name"] + "\n";
                SpecText += "最大クロック周波数 : " + mo["MaxClockSpeed"] + " MHz\n";
                //SpecText += "L1キャッシュサイズ : " + mo["L1CacheSize"] + " KB\n";
                SpecText += "L2キャッシュサイズ : " + mo["L2CacheSize"] + " KB\n";
                //SpecText += "L3キャッシュサイズ : " + mo["L3CacheSize"] + " KB\n";
                SpecText += "-------------------------\n";
            }
            string UserReportStr = String.Join("\n", UserReport.Text);
            if(UserReportStr == "")UserReportStr = "[未入力]\n";
            

           string link = HttpUtility.UrlEncode("----------ユーザー報告----------\n"+
                String.Join("\n", UserReport.Text) +
                "\n----------エラーの内容----------\n" + index+"\n----------ユーザー環境----------\n"+SpecText);
            //https://twitter.com/messages/compose?recipient_id=1129403055374340101&text=
            System.Diagnostics.Process.Start("https://twitter.com/messages/compose?recipient_id=1129403055374340101&text="+link);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void ExceptionMassage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(-1);
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(-1);
        }
    }
}