using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MisakiEQ
{
    public partial class TwitterAuthWindow : Form
    {
#if DEBUG || ADMIN
        TwiClient.Twitter twi = new TwiClient.Twitter();
#endif
        public string LastError="";
        public bool isLastUpdated = false;
        public bool isTwitterUpdate = false;
        public TwitterAuthWindow()
        {
            InitializeComponent();
#if DEBUG || ADMIN
            Icon = Properties.Resources.mainico; 
            twi.OpenAuthURL();
            Show();
#else
            Close();
#endif
        }
        private void DisplayPin_Click(object sender, EventArgs e)
        {
            DisplayPassword.Start();
            PinBox.PasswordChar = '\0';
            DisplayPin.Enabled = false;
            DisplayPin.Text = "PIN表示中";
        }

        private void DisplayPassword_Tick(object sender, EventArgs e)
        {
            DisplayPassword.Stop();
            PinBox.PasswordChar = '*';
            DisplayPin.Enabled = true;
            DisplayPin.Text = "PIN再表示";
        }

        private void AuthEnter_Click(object sender, EventArgs e)
        {
#if DEBUG || ADMIN
            twi.EnterAuth(PinBox.Text);
            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            if (twi.GetAccessToken() != null)
            {
                // （1）テキストファイルを開いて（なければ作って）StreamWriterオブジェクトを得る
                using (StreamWriter writer = new StreamWriter("TwiSession.dat", false, sjisEnc))
                {
                    // （2）ファイルにテキストを書き込む
                    writer.WriteLine(twi.GetAccessToken() + "\n" + twi.GetAccessTokenSecret());

                } // （3）usingブロックを抜けるときにファイルが閉じられる
                LastError = "Twitterの認証に成功。" + twi.GetStringName() + " (@" + twi.GetScreenName() + ")";
                isLastUpdated = true;
                isTwitterUpdate = true;
            }
            else
            {
                LastError = "Twitterの認証に失敗しました。";
                isLastUpdated = true;
            }            
            
            Visible = false;
#endif
        }

        private void TwitterAuthWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
                LastError = "Twitterの認証を中止しました。";
                isLastUpdated = true;
        }
    }
}
