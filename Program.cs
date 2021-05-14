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
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new
         ThreadExceptionEventHandler(Application_ThreadException);

            // UnhandledExceptionイベント・ハンドラを登録する
            Thread.GetDomain().UnhandledException += new
            UnhandledExceptionEventHandler(Application_UnhandledException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
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
            Application.Run(new ExceptionMassage(extraMessage + " \n" +
              
              "【例外が発生したメゾット】\n" + ex.TargetSite + "\n\n" +
              "【例外が発生したソース】\n" + ex.Source + "\n\n"+
              "【エラー内容】\n" + ex.Message +"\n"+ ex.HelpLink+ "\n\n" +
              "【スタックトレース】\n" + ex.StackTrace)
              ) ; 
            
        }
    }
}
