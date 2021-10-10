using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MisakiEQ.Config
{
    public class IndexConfig
    {

        public Index._COM SerialPort=new Index._COM();
        public Index._TimeStamp TimeStamp=new Index._TimeStamp();
        public Index._Notification Notification=new Index._Notification();
        public Index._AreaSetting AreaSetting = new Index._AreaSetting();

    }
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

        IndexConfig config=new IndexConfig();
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
                            config.AreaSetting.AreaPosX = StringToValue.ToInt(args[1]);
                            break;
                        case "UserPos.Y":
                            config.AreaSetting.AreaPosY = StringToValue.ToInt(args[1]);
                            break;
                        case "SerialEnabled":
                            config.SerialPort.SerialEnabled = StringToValue.ToBool(args[1]);
                            break;
                        case "SerialSpeed":
                            config.SerialPort.SerialSpeed = StringToValue.ToInt(args[1]);
                            break;
                        case "SerialPort":
                            config.SerialPort.SerialPort = StringToValue.ToInt(args[1]);
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
   
}
namespace MisakiEQ.Config.Index
{
    
    public class _COM
    {
        public bool SerialEnabled { get; set; }
        public int SerialPort { get; set; }
        public int SerialSpeed { get; set; }

        public bool IsEnabledEEW { get; set; } 
        public bool IsEnabledEEWAny { get; set; }
        
    }
    public class _TimeStamp
    {
        public bool EnabledEventLog { get; set; }

    }
    public class _Notification
    {
        public int MinLevel { get; set; }
        public double MinMagnitude { get; set; }
        public bool IsOnlyEEWWarn { get; set; }

    }

    public class _AreaSetting
    {
        public double longitude { get; set; }
        public double latitude { get; set; }

        public int AreaPosX { get; set; }
        public int AreaPosY { get; set; }
    }
}