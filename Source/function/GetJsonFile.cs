using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.IO;

namespace MisakiEQ
{
    class GetJsonFile
    {
        private string Error="";
        public string GetJson(string URL)
        {
            try
            {
                if (URL == "")
                {
                    Error = "URLが指定されていません。";
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
        public byte[] GetData(string URL)
        {
            try
            {
                if (URL == "")
                {
                    Error = "URLが指定されていません。";
                    return null;
                }
                using (WebClient webClient = new WebClient())
                {
                    
                    return webClient.DownloadData(URL);
                }
            }
            catch(WebException e)
            {
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
