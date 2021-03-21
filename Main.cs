using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace MisakiEQ
{
    
    class Main
    {
        public static int LoopTime = (int)1000 / 60;
        public static int getEQSleepTime = 10000;
        public static int getTsunamiSleepTime = 30000;

        private static int clockTime = 0;
        private static bool isRun = false;
        public static void Run()
        {
            Init();
            isRun = true;
            while (isRun)
            {
                Loop();
                System.Threading.Thread.Sleep(LoopTime);
                clockTime += LoopTime;
            }
            
        }
        private static void Init()
        {

        }
        private static void Loop()
        {

        }
        public static void Stop()
        {
            isRun = false;
        }
    }
    class getNetworkFile
    {
        public static string URL = "";
        private static int ErrorCode = 0;
        public static void SetURL(string Text)
        {
            URL = Text;
        }
    }
}

