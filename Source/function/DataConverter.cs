using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows;
using System.Drawing;
namespace MisakiEQ
{
    class DataConverter
    {
        private bool GetTimeErrorException=false;
        public enum EQType{
            ScalePrompt = 1,
            Destination = 2,
            ScaleAndDestination = 3,
            DetailScale = 4,
            Foreign = 5,
            Other = -1,
            Error = -32768
        }
        public enum DomesticTsunami
        {
            Error = 0,
            None =1,
            Unknown =2,
            Checking =3,
            NonEffective =4,
            Watch=5,
            Warning=6,
            
        }
        public int GetEQInfomationType(string name)
        {
            if (name == "ScalePrompt") return 1;
            if (name == "Destination") return 2;
            if (name == "ScaleAndDestination") return 3;
            if (name == "DetailScale") return 4;
            if (name == "Foreign") return 5;
            if (name == "Other") return -1;
            return -32768;
        }
        //None(なし), Unknown(不明), Checking(調査中), NonEffective(若干の海面変動が予想されるが、被害の心配なし), 
        //Watch(津波注意報), Warning(津波予報(種類不明))
        public int GetDomesticTsunami(string name)
        {
            if (name =="None")return 1 ;
            if (name =="Unknown")return 2 ;
            if (name =="Checking")return 3 ;
            if (name =="NonEffective") return 4 ;
            if (name =="Watch") return 5 ;
            if (name =="Warning") return 6 ;
            return 0;
        }
        public string EQTsunamiTextJP(int type)
        {
            switch (type)
            {
                case 1:
                    return "津波の心配はありません。";
                case 2:
                    return "津波情報は不明です。";
                case 3:
                    return "津波は現在調査中です。";
                case 4:
                    return "若干の海面変動があります。";
                case 5:
                    return "津波注意報が発令されています。";
                case 6:
                    return "津波予報が発令されています。";
                default:
                    return "津波情報を取得できませんでした。";
            }
        }
        public DateTime GetTime(string name)
        {
            GetTimeErrorException = false;
            DateTime ret = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            String format = "yyyy/MM/dd HH:mm:ss.fff";
            if (DateTime.TryParseExact(name, format, null, DateTimeStyles.AssumeLocal, out ret))return ret;
            format = "yyyy/MM/dd HH:mm:ss";
            if (DateTime.TryParseExact(name, format, null, DateTimeStyles.AssumeLocal, out ret))return ret;
            GetTimeErrorException = true;
            return ret;//エラーの場合0年1月1日 0:00:00.000が返される。
        }
        public bool GetTimeError()
        {
            return GetTimeErrorException;
        }
        public string DeepString(int value)
        {
            if (value == -1) return "不明";
            if (value == 0) return "ごく浅い";
            return value.ToString() + " km";
        }
        public string ScaleString(int value)
        {
            switch (value)
            {
                case -1:
                    return "なし";
                case 10:
                    return "１";
                case 20:
                    return "２";
                case 30:
                    return "３";
                case 40:
                    return "４";
                case 45:
                    return "５弱";
                case 46:
                    return "５弱以上";
                case 50:
                    return "５強";
                case 55:
                    return "６弱";
                case 60:
                    return "６強";
                case 70:
                    return "７";
                default:
                    return "不明";
            }
        }
        public string KyoshinShindoToString(double value)
        {
            if (value >= 7)return "7";
            if (value >= 6.5)return "6+";
            if (value >= 6)return "6-";
            if (value >= 5.5) return "5+";
            if (value >= 5) return "5-";
            if (value >= 4) return "4";
            if (value >= 3) return "3";
            if (value >= 2) return "2";
            if (value >= 1) return "1";
            if (value >= 0.1) return "0";
            return "-";

        }
        public int ScaleValue(string name)
        {
            if (name == "1") return 1;
            if (name == "2") return 2;
            if (name == "3") return 3;
            if (name == "4") return 4;
            if (name == "5-") return 5;
            if (name == "5+") return 6;
            if (name == "6-") return 7;
            if (name == "6+") return 8;
            if (name == "7") return 9;
            return 0;

        }
        public string EasyScaleToString(int value)
        {
            switch (value)
            {
                case 0:
                    return "なし";
                case 1:
                    return "１";
                case 2:
                    return "２";
                case 3:
                    return "３";
                case 4:
                    return "４";
                case 5:
                    return "５弱";
                case 6:
                    return "５強";
                case 7:
                    return "６弱";
                case 8:
                    return "６強";
                case 9:
                    return "７";
                default:
                    return "不明";
            }
        }
        public string ASCIIScaleString(int value)
        {
            switch (value)
            {
                case -1:
                    return "0";
                case 10:
                    return "1";
                case 20:
                    return "2";
                case 30:
                    return "3";
                case 40:
                    return "4";
                case 45:
                    return "5-";
                case 46:
                    return "5-";
                case 50:
                    return "5+";
                case 55:
                    return "6-";
                case 60:
                    return "6+";
                case 70:
                    return "7";
                default:
                    return "-";
            }
        }
        public int ScaleToValue(int value)
        {
            switch (value)
            {
                case -1:
                    return 0;
                case 10:
                    return 1;
                case 20:
                    return 2;
                case 30:
                    return 3;
                case 40:
                    return 4;
                case 45:
                    return 5;
                case 50:
                    return 6;
                case 55:
                    return 7;
                case 60:
                    return 8;
                case 70:
                    return 9;
                default:
                    return -1;
            }
        }
        public int AreaToValue(string name)
        {
            if(name=="北海道")return 1;
            if(name=="青森県")return 2;
            if(name=="岩手県")return 3;
            if(name=="宮城県")return 4;
            if(name=="秋田県")return 5;
            if(name=="山形県")return 6;
            if(name=="福島県")return 7;
            if(name=="茨城県")return 8;
            if(name=="栃木県")return 9;
            if(name=="群馬県")return 10;
            if(name=="埼玉県")return 11;
            if(name=="千葉県")return 12;
            if(name=="東京都")return 13;
            if(name=="神奈川県")return 14;
            if(name=="新潟県")return 15;
            if(name=="富山県")return 16;
            if(name=="石川県")return 17;
            if(name=="福井県")return 18;
            if(name=="山梨県")return 19;
            if(name=="長野県")return 20;
            if(name=="岐阜県")return 21;
            if(name=="静岡県")return 22;
            if(name=="愛知県")return 23;
            if(name=="三重県")return 24;
            if(name=="滋賀県")return 25;
            if(name=="京都府")return 26;
            if(name=="大阪府")return 27;
            if(name=="兵庫県")return 28;
            if(name=="奈良県")return 29;
            if(name=="和歌山県")return 30;
            if(name=="鳥取県")return 31;
            if(name=="島根県")return 32;
            if(name=="岡山県")return 33;
            if(name=="広島県")return 34;
            if(name=="山口県")return 35;
            if(name=="徳島県")return 36;
            if(name=="香川県")return 37;
            if(name=="愛媛県")return 38;
            if(name=="高知県")return 39;
            if(name=="福岡県")return 40;
            if(name=="佐賀県")return 41;
            if(name=="長崎県")return 42;
            if(name=="熊本県")return 43;
            if(name=="大分県")return 44;
            if(name=="宮崎県")return 45;
            if(name=="鹿児島県")return 46;
            if (name == "沖縄県")return 47;
            return 0;
        }
        public string ValueToAreaShort(int value)
        {
            if (value == 1) return "北海道";
            if (value == 2) return "青森";
            if (value == 3) return "岩手";
            if (value == 4) return "宮城";
            if (value == 5) return "秋田";
            if (value == 6) return "山形";
            if (value == 7) return "福島";
            if (value == 8) return "茨城";
            if (value == 9) return "栃木";
            if (value == 10) return "群馬";
            if (value == 11) return "埼玉";
            if (value == 12) return "千葉";
            if (value == 13) return "東京";
            if (value == 14) return "神奈川";
            if (value == 15) return "新潟";
            if (value == 16) return "富山";
            if (value == 17) return "石川";
            if (value == 18) return "福井";
            if (value == 19) return "山梨";
            if (value == 20) return "長野";
            if (value == 21) return "岐阜";
            if (value == 22) return "静岡";
            if (value == 23) return "愛知";
            if (value == 24) return "三重";
            if (value == 25) return "滋賀";
            if (value == 26) return "京都";
            if (value == 27) return "大阪";
            if (value == 28) return "兵庫";
            if (value == 29) return "奈良";
            if (value == 30) return "和歌山";
            if (value == 31) return "鳥取";
            if (value == 32) return "島根";
            if (value == 33) return "岡山";
            if (value == 34) return "広島";
            if (value == 35) return "山口";
            if (value == 36) return "徳島";
            if (value == 37) return "香川";
            if (value == 38) return "愛媛";
            if (value == 39) return "高知";
            if (value == 40) return "福岡";
            if (value == 41) return "佐賀";
            if (value == 42) return "長崎";
            if (value == 43) return "熊本";
            if (value == 44) return "大分";
            if (value == 45) return "宮崎";
            if (value == 46) return "鹿児島";
            if (value == 47) return "沖縄";
            return "不明";
        }
        public string TsunamiTypeValueToString(int a)
        {
            switch (a)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Watch";
                case 2:
                    return "Warning";
                case 3:
                    return "MajorWarning";
                default:
                    return "";

            }
        }
        public int TsunamiTypeStringToValue(string a)
        {
            if (a == "Unknown") return 0;
            if (a == "Watch") return 1;
            if (a == "Warning") return 2;
            if (a == "MajorWarning") return 3;
            return -1;
        }
        public string TsunamiTypeStringJP(int type,bool immediate)
        {
            if (immediate)
            {
                switch (type)
                {
                    case 0:
                        return "不明";
                    case 1:
                        return "津波注意報(すぐに到達)";
                    case 2:
                        return "⚠津波警報(すぐに到達)";
                    case 3:
                        return "⚠⚠大津波警報(⚠今すぐ避難)";
                }
            }
            else
            {
                switch (type)
                {
                    case 0:
                        return "不明";
                    case 1:
                        return "津波注意報";
                    case 2:
                        return "⚠津波警報";
                    case 3:
                        return "⚠⚠大津波警報";
                }
            }
            return "不明";
        }

        public System.Windows.Point KyoshinMapToLAL(System.Drawing.Point Map)
        {
            //if (Map.X < 0 || Map.Y < 0 || Map.X >= 352 || Map.Y >= 400) 
              //  throw new IndexOutOfRangeException("地図は(0,0)から(351,399)の範囲で指定しなければなりません。");
            bool IsExtend=false;
            if (Map.Y > 38 && Map.Y < 208 && Map.X >= 0 && Map.X <= 110) IsExtend = true;
            else if (Map.Y > 38 && Map.Y < 135 && Map.X >= 110 && Map.X < 172) IsExtend = true;
            else if ((Map.X > 110 && Map.X < 172 && Map.Y >= 135 && Map.Y < 208) &&
                (Map.X-110) * 72 / 61 < (73-(Map.Y - 135))) IsExtend = true;
            System.Windows.Point Pos=new System.Windows.Point(0,0);
            if (IsExtend)
            {
                Pos.X = 122.52675 + Map.X * 0.04930;
                Pos.Y = 32.11100 - Map.Y * 0.04065;
            }
            else
            {
                Pos.X = 128.62400 + Map.X * 0.04930;//-0.7
                Pos.Y = 46.19100 - Map.Y * 0.04065;
            }
            return Pos;
            

        }
        
    }
}
