using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.IO;
using System.Threading;
using MisakiEQ.log;
namespace MisakiEQ.Net
{
    class GetJsonFile
    {
        private string Error="";
        private string ThreadURL = "";
        private string ThreadData = "";
        private bool IsThreadRun = false;

        private void GetPrivateJson()
        {
            try
            {
                if (ThreadURL == "")
                {
                    log.Logger log = Logger.GetInstance();
                    log.Info($"URLが指定されていません。");
                    IsThreadRun = false;
                    return;
                }
                using (WebClient webClient = new WebClient())
                {
                    webClient.Encoding = System.Text.Encoding.UTF8;
                    ThreadData = webClient.DownloadString(ThreadURL);
                    IsThreadRun = false;
                }
            }
            catch (WebException e)
            {
                Error = e.Message;
                IsThreadRun = false;
                //return;
            }
            finally
            {
                IsThreadRun = false;
            }
        }
        public string GetJson(string URL)
        {
            try
            {
                if (URL == "")
                {
                    log.Logger log = Logger.GetInstance();
                    log.Info($"URLが指定されていません。");
                    return null;
                }
                using (WebClient webClient = new WebClient())
                {
                    webClient.Encoding = System.Text.Encoding.UTF8;
                    return webClient.DownloadString(URL);
                }
            }
            catch(WebException e)
            {
                Error = e.Message;
                return null;
            }

        }
        public void GetStartThreadJson(string URL)
        {
            if (IsThreadRun) throw null;
            IsThreadRun = true;
            ThreadURL = URL;
            //GetPrivateJson();
            Thread t = new Thread(new ThreadStart(GetPrivateJson));
            t.Start();
            return;
        }
        public bool GetThreadStillRunning()
        {
            return IsThreadRun;
        }
        public string GetThreadJson()
        {
            if (IsThreadRun) throw null;
            return ThreadData; 
        }
        public byte[] GetData(string URL)
        {
            try
            {
                if (URL == "")
                {
                    log.Logger log = Logger.GetInstance();
                    log.Info($"URLが指定されていません。");
                    return null;
                }
                using (WebClient webClient = new WebClient())
                {
                    
                    return webClient.DownloadData(URL);
                }
            }
            catch(WebException e)
            {
                log.Logger log = Logger.GetInstance();
                log.Error($"Web例外エラー:{e.Message}\nリクエストしたURL:{URL}");
                Error = e.Message;
                return null;
            }
        }
        public string GetLastErrorStatus()
        {
            return Error;
        }
    }
}
