using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MisakiEQ.Config
{
    class StringToValue
    {
        public static int ToInt(string str)
        {
            return int.Parse(str);
        }
        public static bool ToBool(string str)
        {
            switch (str)
            {
                case "true":
                    return true;
                case "false":
                    return false;
                case "True":
                    return true;
                case "False":
                    return false;
                case "TRUE":
                    return true;
                case "FALSE":
                    return false;
                default:
                    throw new ArgumentException($"Bool値の取得に失敗しました。渡された値 : {str}");
            }
        }
        public static double Todouble(string str)
        {
            return double.Parse(str);
        }
    }
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
                            _var.UserPos.X = StringToValue.ToInt(args[1]);
                            break;
                        case "UserPos.Y":
                            _var.UserPos.Y = StringToValue.ToInt(args[1]);
                            break;
                        case "SerialEnabled":
                            _var.EnableSerial = StringToValue.ToBool(args[1]);
                            break;
                        case "SerialSpeed":
                            _var.SerialSpeed = StringToValue.ToInt(args[1]);
                            break;
                        case "SerialPort":
                            _var.SerialPort = StringToValue.ToInt(args[1]);
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
        public int SerialSpeed;
    }
}
