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
        static MainForm MainForm;
#if !DEBUG
        static System.Threading.Mutex mutex;
#endif
        static bool hasHandle = false;
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
#if ADMIN
            string mutexName = "MisakiEQ(Admin Mode)";
#else
            string mutexName = "MisakiEQ";
#endif
            //Mutexオブジェクトを作成する
            mutex = new System.Threading.Mutex(false, mutexName);

            
            try
            {
                //ミューテックスの所有権を要求する
                hasHandle = mutex.WaitOne(0, false);
            }
            //.NET Framework 2.0以降の場合
            catch (System.Threading.AbandonedMutexException)
            {
                //別のアプリケーションがミューテックスを解放しないで終了した時
                hasHandle = true;
            }
            //ミューテックスを得られたか調べる
            if (hasHandle == false)
            {
                //得られなかった場合は、すでに起動していると判断して終了
                MessageBox.Show("MisakiEQは多重起動できません。\nもし表示されない場合はタスクトレイをチェックしてください。","MisakiEQ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

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

            MainForm = new MainForm();
            Application.Run(MainForm);
#if !DEBUG
            if (hasHandle)
            {
                //ミューテックスを解放する
                mutex.ReleaseMutex();
            }
#endif

        }
        public static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ShowErrorMessage(e.Exception, "スレッドによる例外エラー")
                ;
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
            if (MainForm != null)
            {
                MainForm.IsApplicationShutDown = true;
                MainForm.Hide();
                MainForm.notification.Visible = false;
            } 
            string ErrorString = "";
            ErrorString += extraMessage + " \n";
            ErrorString += "【例外エラー名】\n" + ex.GetType().ToString() + "\n\n";
            ErrorString += "【例外が発生したメゾット】\n" + ex.TargetSite + "\n\n";
            ErrorString += "【例外が発生したソース】\n" + ex.Source + "\n\n";
            ErrorString += "【エラー内容】\n" + ex.Message + "\n\n";
            ErrorString += "【スタックトレース】\n" + ex.StackTrace;
            ExceptionMassage err = new ExceptionMassage(ErrorString, ErrorCount, 
              ex.TargetSite+"")
               ;
            //Application.Run(err);
#if !DEBUG
            if (hasHandle)
            {
                //ミューテックスを解放する
                mutex.ReleaseMutex();
            }
#endif
            err.Show();
            
        }
    }
}
