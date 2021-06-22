using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MisakiEQ
{
    static class Program
    {
        private static int ErrorCount = 0;
        static Form1 MainForm;
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

#if !DEBUG
            Application.ThreadException += new
         ThreadExceptionEventHandler(Application_ThreadException);
            // UnhandledExceptionイベント・ハンドラを登録する
            Thread.GetDomain().UnhandledException += new
            UnhandledExceptionEventHandler(Application_UnhandledException);
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            for (int i = 0; args.Count() > i; i++)
            {
                if (args[i].StartsWith("ErrorFlg="))
                {
                    ErrorCount=int.Parse(args[i].Remove(0, 9));
                }
            }

            MainForm = new Form1();
            Application.Run(MainForm);
            
        }
        public static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ShowErrorMessage(e.Exception, "スレッドによる例外エラー");
        }

        // 未処理例外をキャッチするイベント・ハンドラ
        // （主にコンソール・アプリケーション用）
        public static void Application_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            if (ex != null)
            {
                ShowErrorMessage(ex, "ハンドルされていない例外エラー");
            }
        }

        // ユーザー・フレンドリなダイアログを表示するメソッド
        public static void ShowErrorMessage(Exception ex, string extraMessage)
        {
            if(MainForm!=null)MainForm.IsApplicationShutDown = true;
            string ErrorString = "";
            ErrorString += extraMessage + " \n";
            ErrorString += "【例外が発生したメゾット】\n" + ex.TargetSite + "\n\n";
            ErrorString += "【例外が発生したソース】\n" + ex.Source + "\n\n";
            ErrorString += "【エラー内容】\n" + ex.Message + "\n\n";
            ErrorString += "【スタックトレース】\n" + ex.StackTrace;
            ExceptionMassage err = new ExceptionMassage(ErrorString, ErrorCount, 
              ex.TargetSite+"")
               ;
            //Application.Run(err);
            err.Show();
            if (MainForm != null) MainForm.Hide();
        }
    }
}
