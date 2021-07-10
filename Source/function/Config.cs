using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MisakiEQ.Config
{
    class Data
    {
        Variation _var;
        void LoadString(string str)
        {
            string[] args;
            args=str.Split('=');
            if (args.Length == 2)
            {
                try
                {
                    switch (args[0])
                    {
                        case "UserPos.X":
                            _var.UserPos.X = int.Parse(args[1]);
                            break;
                    }
                }catch (Exception what)
                {
                    throw new Exception($"Config解析中にエラー\n理由 : {what.Message}", what.InnerException);
                }
            }
            else
            {
                throw new ArgumentException($"'='は必ず 1 つでなければなりません。\nデータ文 : {str}\n引数の数 : {args.Length}");
            }
        }
    }
    public struct Variation
    {
        public Point UserPos;
        public bool EnableSerial;
        public int SerialPort;
        public string SerialSpeed;
    }
}
