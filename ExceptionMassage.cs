using System;
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

namespace MisakiEQ
{
    public partial class ExceptionMassage : Form
    {
        
        string index;
        public ExceptionMassage(string str)
        {
            InitializeComponent();
            string[] result = str.Split(new char[] { '\n' });
            this.ErrorIndex.Lines = result;
            index = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SpecText="";
            int nVal;
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
                // 合計物理メモリー
                nVal = Convert.ToInt32(mo["TotalVisibleMemorySize"]) / 1024;    // 単位 KB -> MB
                SpecText += "合計物理メモリ : " + nVal.ToString()+" MB\n";

                // 利用可能な物理メモリー
                nVal = Convert.ToInt32(mo["FreePhysicalMemory"]) / 1024;    // 単位 KB -> MB
                SpecText+="利用可能な物理メモリ : " + nVal.ToString()+" MB\n";

                // 合計仮想メモリー
                nVal = Convert.ToInt32(mo["TotalVirtualMemorySize"]) / 1024;    // 単位 KB -> MB
                SpecText+="合計仮想メモリ : " + nVal.ToString()+" MB\n";

                // 利用可能な仮想メモリー
                nVal = Convert.ToInt32(mo["FreeVirtualMemory"]) / 1024;    // 単位 KB -> MB
                SpecText+="利用可能な仮想メモリ : " + nVal.ToString()+" MB\n";
            }
            string UserReportStr = String.Join("\n", UserReport.Text);
            if(UserReportStr == "")
            {
                UserReportStr = "［未入力］\n";
            }
           string link = HttpUtility.UrlEncode("----------ユーザー報告----------\n"+
                String.Join("\n", UserReport.Text) +
                "\n----------エラーの内容----------\n" + index+"\n----------ユーザー環境----------\n"+SpecText);
            //https://twitter.com/messages/compose?recipient_id=1129403055374340101&text=
            System.Diagnostics.Process.Start("https://twitter.com/messages/compose?recipient_id=1129403055374340101&text="+link);

        }
    }
}
