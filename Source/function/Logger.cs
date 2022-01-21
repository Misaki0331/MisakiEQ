using MisakiEQ.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MisakiEQ.log
{
    class Logger
    {
        bool IS_LOGFILE = true;
        int LOG_LEVEL = 3;
        string LOGDIR_PATH = "./logs/";
        string LOGFILE_NAME = "console";
        long LOGFILE_MAXSIZE = 10485760;
        int LOGFILE_PERIOD = 30;

        /// <summary>
        /// ログレベル
        /// </summary>
        private enum LogLevel
        {
            ERROR,
            WARN,
            INFO,
            DEBUG,
            FATAL
        }

        private static Logger singleton = null;
        private readonly string logFilePath = null;
        private readonly object lockObj = new object();
        private StreamWriter stream = null;

        /// <summary>
        /// インスタンスを生成する
        /// </summary>
        public static Logger GetInstance()
        {
            if (singleton == null)
            {
                singleton = new Logger();
            }
            return singleton;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private Logger()
        {
            this.logFilePath = LOGDIR_PATH + LOGFILE_NAME + ".log";

            // ログファイルを生成する
            CreateLogfile(new FileInfo(logFilePath));
        }

        /// <summary>
        /// ERRORレベルのログを出力する
        /// </summary>
        /// <param name="msg">メッセージ</param>
        public void Error(string msg, [CallerMemberName] string callerMethodName = "")
        {
            if ((int)LogLevel.ERROR <= LOG_LEVEL)
            {
                Out(LogLevel.ERROR, msg, callerMethodName);
            }
        }

        /// <summary>
        /// ERRORレベルのスタックトレースログを出力する
        /// </summary>
        /// <param name="ex">例外オブジェクト</param>
        public void Error(Exception ex, [CallerMemberName] string callerMethodName = "",
            [CallerFilePath] string callerFilePath = "",
            [CallerLineNumber] int callerLineNumber = -1)
        {
            if ((int)LogLevel.ERROR <= LOG_LEVEL)
            {
                Out(LogLevel.ERROR, ex.Message + Environment.NewLine 
                    + $"{callerFilePath} - {callerLineNumber}行目" + Environment.NewLine 
                    + ex.GetType().ToString() + Environment.NewLine 
                    + ex.Message + Environment.NewLine 
                    + ex.StackTrace, callerMethodName);
            }
        }

        /// <summary>
        /// FATALレベルのスタックトレースログを出力する
        /// </summary>
        /// <param name="ex">例外オブジェクト</param>
        public void Fatal(Exception ex, [CallerMemberName] string callerMethodName = "", 
            [CallerFilePath] string callerFilePath = "",
            [CallerLineNumber] int callerLineNumber = -1)
        {
            if ((int)LogLevel.FATAL <= LOG_LEVEL)
            {
                Out(LogLevel.FATAL, ex.Message + Environment.NewLine 
                    + $"{callerFilePath} - {callerLineNumber}行目" + Environment.NewLine 
                    + ex.GetType().ToString() + Environment.NewLine 
                    + ex.Message + Environment.NewLine 
                    + ex.StackTrace, callerMethodName);
            }
        }

        /// <summary>
        /// FATALレベルのログを出力する
        /// </summary>
        /// <param name="msg">メッセージ</param>
        public void Fatal(string msg, [CallerMemberName] string callerMethodName = "")
        {
            if ((int)LogLevel.FATAL <= LOG_LEVEL)
            {
                Out(LogLevel.FATAL, msg, callerMethodName);
            }
        }

        /// <summary>
        /// WARNレベルのログを出力する
        /// </summary>
        /// <param name="msg">メッセージ</param>
        public void Warn(string msg, [CallerMemberName] string callerMethodName = "")
        {
            if ((int)LogLevel.WARN <= LOG_LEVEL)
            {
                Out(LogLevel.WARN, msg, callerMethodName);
            }
        }

        /// <summary>
        /// INFOレベルのログを出力する
        /// </summary>
        /// <param name="msg">メッセージ</param>
        public void Info(string msg, [CallerMemberName] string callerMethodName = "")
        {
            if ((int)LogLevel.INFO <= LOG_LEVEL)
            {
                Out(LogLevel.INFO, msg, callerMethodName);
            }
        }

        /// <summary>
        /// DEBUGレベルのログを出力する
        /// </summary>
        /// <param name="msg">メッセージ</param>
        public void Debug(string msg, [CallerMemberName] string callerMethodName = "")
        {
            if ((int)LogLevel.DEBUG <= LOG_LEVEL)
            {
                Out(LogLevel.DEBUG, msg, callerMethodName);
            }
        }

        /// <summary>
        /// ログを出力する
        /// </summary>
        /// <param name="level">ログレベル</param>
        /// <param name="msg">メッセージ</param>
        private void Out(LogLevel level, string msg,string calledMethodName)
        {
            int tid = System.Threading.Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}][{tid.ToString().PadLeft(5, ' ')}][{level.ToString().PadRight(5, ' ')}] [{calledMethodName.PadRight(16, ' ').Substring(0, 16)}]: {msg}");
            if (IS_LOGFILE)
            {
                msg = msg.Replace("\n", "\n\t");
                string fullMsg = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}][{tid.ToString().PadLeft(5,' ')}][{level.ToString().PadRight(5,' ')}] [{calledMethodName.PadRight(16, ' ').Substring(0,16)}]: {msg}";
                
                lock (this.lockObj)
                {
                    this.stream.WriteLine(fullMsg);

                    FileInfo logFile = new FileInfo(this.logFilePath);
                    if (LOGFILE_MAXSIZE < logFile.Length)
                    {
                        // ログファイルを圧縮する
                        CompressLogFile();

                        // 古いログファイルを削除する
                        DeleteOldLogFile();
                    }
                }
            }
        }

        /// <summary>
        /// ログファイルを生成する
        /// </summary>
        /// <param name="logFile">ファイル情報</param>
        private void CreateLogfile(FileInfo logFile)
        {
            if (!Directory.Exists(logFile.DirectoryName))
            {
                Directory.CreateDirectory(logFile.DirectoryName);
            }

            this.stream = new StreamWriter(logFile.FullName, true, Encoding.UTF8)
            {
                AutoFlush = true
            };
        }

        /// <summary>
        /// ログファイルを圧縮する
        /// </summary>
        private void CompressLogFile()
        {
            this.stream.Close();
            string oldFilePath = LOGDIR_PATH + LOGFILE_NAME + "_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            File.Move(this.logFilePath, oldFilePath + ".log");

            FileStream inStream = new FileStream(oldFilePath + ".log", FileMode.Open, FileAccess.Read);
            FileStream outStream = new FileStream(oldFilePath + ".gz", FileMode.Create, FileAccess.Write);
            GZipStream gzStream = new GZipStream(outStream, CompressionMode.Compress);

            int size = 0;
            byte[] buffer = new byte[LOGFILE_MAXSIZE + 1000];
            while (0 < (size = inStream.Read(buffer, 0, buffer.Length)))
            {
                gzStream.Write(buffer, 0, size);
            }

            inStream.Close();
            gzStream.Close();
            outStream.Close();

            File.Delete(oldFilePath + ".log");
            CreateLogfile(new FileInfo(this.logFilePath));
        }

        /// <summary>
        /// 古いログファイルを削除する
        /// </summary>
        private void DeleteOldLogFile()
        {
            Regex regex = new Regex(LOGFILE_NAME + @"_(\d{14}).*\.gz");
            DateTime retentionDate = DateTime.Today.AddDays(-LOGFILE_PERIOD);
            string[] filePathList = Directory.GetFiles(LOGDIR_PATH, LOGFILE_NAME + "_*.gz", SearchOption.TopDirectoryOnly);
            foreach (string filePath in filePathList)
            {
                Match match = regex.Match(filePath);
                if (match.Success)
                {
                    DateTime logCreatedDate = DateTime.ParseExact(match.Groups[1].Value.ToString(), "yyyyMMddHHmmss", null);
                    if (logCreatedDate < retentionDate)
                    {
                        File.Delete(filePath);
                    }
                }
            }
        }
    }
}
/*
        public static void debug([CallerMemberName] string callerMethodName = "",
            [CallerFilePath] string callerFilePath = "",
            [CallerLineNumber] int callerLineNumber = -1)
        {*/