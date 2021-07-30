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
        public static int GetEQInfomationType(string name)
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
        public static int GetDomesticTsunami(string name)
        {
            if (name =="None")return 1 ;
            if (name =="Unknown")return 2 ;
            if (name =="Checking")return 3 ;
            if (name =="NonEffective") return 4 ;
            if (name =="Watch") return 5 ;
            if (name =="Warning") return 6 ;
            return 0;
        }
        public static string EQTsunamiTextJP(int type)
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
        public static DateTime GetTime(string name)
        {
            DateTime ret = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            String format = "yyyy/MM/dd HH:mm:ss.fff";
            if (DateTime.TryParseExact(name, format, null, DateTimeStyles.AssumeLocal, out ret))return ret;
            format = "yyyy/MM/dd HH:mm:ss";
            if (DateTime.TryParseExact(name, format, null, DateTimeStyles.AssumeLocal, out ret))return ret;
            return ret;//エラーの場合0年1月1日 0:00:00.000が返される。
        }
        public static bool IsTimeFail(DateTime dt)
        {
            if (dt == new DateTime(0, 1, 1, 0, 0, 0, 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string DeepString(int value)
        {
            if (value == -1) return "不明";
            if (value == 0) return "ごく浅い";
            return value.ToString() + " km";
        }
        public static string ScaleString(int value)
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
        public static string KyoshinShindoToString(double value)
        {
            if (value >= 6.5)return "7";
            if (value >= 6.0)return "6+";
            if (value >= 5.5)return "6-";
            if (value >= 5.0) return "5+";
            if (value >= 4.5) return "5-";
            if (value >= 3.5) return "4";
            if (value >= 2.5) return "3";
            if (value >= 1.5) return "2";
            if (value >= 0.5) return "1";
            if (value >= 0.1) return "0";
            return "-";

        }
        public static string ShindoJpnToEasy(string value)
        {
            switch (value)
            {
                case "5弱":
                    return "5-";
                case "5強":
                    return "5+";
                case "6弱":
                    return "6-";
                case "6強":
                    return "6+";
                case "不明":
                    return "-";
                default:
                    return value;
            }
        }

        public static int ScaleValue(string name)
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
        public static string EasyScaleToString(int value)
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
        public static string ValueScaleString(int value)
        {
            switch (value)
            {
                case 0:
                    return "0";
                case 1:
                    return "1";
                case 2:
                    return "2";
                case 3:
                    return "3";
                case 4:
                    return "4";
                case 5:
                    return "5-";
                case 6:
                    return "5+";
                case 7:
                    return "6-";
                case 8:
                    return "6+";
                case 9:
                    return "7";
                default:
                    return "-";
            }
        }
        public static string ASCIIScaleString(int value)
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
        public static int ScaleToValue(int value)
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
        public static int AreaToValue(string name)
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
        public static string ValueToAreaShort(int value)
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
        public static string TsunamiTypeValueToString(int a)
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
        public static int TsunamiTypeStringToValue(string a)
        {
            if (a == "Unknown") return 0;
            if (a == "Watch") return 1;
            if (a == "Warning") return 2;
            if (a == "MajorWarning") return 3;
            return -1;
        }
        public static string TsunamiTypeStringJP(int type,bool immediate)
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

        public static System.Windows.Point KyoshinMapToLAL(System.Drawing.Point Map)
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
        public static int HypoCenterIDtoCOMPointer(int origin)
        {
            switch (origin)
            {
                case 11: return 0; //北海道地方
                case 12: return 1; //東北地方
                case 13: return 2; //北陸地方
                case 14: return 3; //関東甲信地方
                case 15: return 4; //小笠原地方
                case 16: return 5; //東海地方
                case 17: return 6; //近畿地方
                case 18: return 7; //中国地方
                case 19: return 8; //四国地方
                case 20: return 9; //九州地方
                case 21: return 10; //沖縄地方
                case 100: return 11; //石狩地方北部
                case 101: return 12; //石狩地方中部
                case 102: return 13; //石狩地方南部
                case 105: return 14; //渡島地方北部
                case 106: return 15; //渡島地方東部
                case 107: return 16; //渡島地方西部
                case 110: return 17; //檜山地方
                case 115: return 18; //後志地方北部
                case 116: return 19; //後志地方東部
                case 117: return 20; //後志地方西部
                case 120: return 21; //空知地方北部
                case 121: return 22; //空知地方中部
                case 122: return 23; //空知地方南部
                case 125: return 24; //上川地方北部
                case 126: return 25; //上川地方中部
                case 127: return 26; //上川地方南部
                case 130: return 27; //留萌地方中北部
                case 131: return 28; //留萌地方南部
                case 135: return 29; //宗谷地方北部
                case 136: return 30; //宗谷地方南部
                case 140: return 31; //網走地方
                case 141: return 32; //北見地方
                case 142: return 33; //紋別地方
                case 145: return 34; //胆振地方西部
                case 146: return 35; //胆振地方中東部
                case 150: return 36; //日高地方西部
                case 151: return 37; //日高地方中部
                case 152: return 38; //日高地方東部
                case 155: return 39; //十勝地方北部
                case 156: return 40; //十勝地方中部
                case 157: return 41; //十勝地方南部
                case 160: return 42; //釧路地方北部
                case 161: return 43; //釧路地方中南部
                case 165: return 44; //根室地方北部
                case 166: return 45; //根室地方中部
                case 167: return 46; //根室地方南部
                case 180: return 47; //北海道南西沖
                case 181: return 48; //北海道西方沖
                case 182: return 49; //石狩湾
                case 183: return 50; //北海道北西沖
                case 184: return 51; //宗谷海峡
                case 186: return 53; //国後島付近
                case 187: return 54; //択捉島付近
                case 188: return 55; //北海道東方沖
                case 189: return 56; //根室半島南東沖
                case 190: return 57; //釧路沖
                case 191: return 58; //十勝沖
                case 192: return 59; //浦河沖
                case 193: return 60; //苫小牧沖
                case 194: return 61; //内浦湾
                case 195: return 62; //宗谷東方沖
                case 196: return 63; //網走沖
                case 197: return 64; //択捉島南東沖
                case 200: return 65; //青森県津軽北部
                case 201: return 66; //青森県津軽南部
                case 202: return 67; //青森県三八上北地方
                case 203: return 68; //青森県下北地方
                case 210: return 69; //岩手県沿岸北部
                case 211: return 70; //岩手県沿岸南部
                case 212: return 71; //岩手県内陸北部
                case 213: return 72; //岩手県内陸南部
                case 220: return 73; //宮城県北部
                case 221: return 74; //宮城県南部
                case 222: return 75; //宮城県中部
                case 230: return 76; //秋田県沿岸北部
                case 231: return 77; //秋田県沿岸南部
                case 232: return 78; //秋田県内陸北部
                case 233: return 79; //秋田県内陸南部
                case 240: return 80; //山形県庄内地方
                case 241: return 81; //山形県最上地方
                case 242: return 82; //山形県村山地方
                case 243: return 83; //山形県置賜地方
                case 250: return 84; //福島県中通り
                case 251: return 85; //福島県浜通り
                case 252: return 86; //福島県会津
                case 280: return 87; //津軽海峡
                case 281: return 88; //山形県沖
                case 282: return 89; //秋田県沖
                case 283: return 90; //青森県西方沖
                case 284: return 91; //陸奥湾
                case 285: return 92; //青森県東方沖
                case 286: return 93; //岩手県沖
                case 287: return 94; //宮城県沖
                case 288: return 95; //三陸沖
                case 289: return 96; //福島県沖
                case 300: return 98; //茨城県北部
                case 301: return 99; //茨城県南部
                case 309: return 100; //千葉県南東沖
                case 310: return 101; //栃木県北部
                case 311: return 102; //栃木県南部
                case 320: return 103; //群馬県北部
                case 321: return 104; //群馬県南部
                case 330: return 105; //埼玉県北部
                case 331: return 106; //埼玉県南部
                case 332: return 107; //埼玉県秩父地方
                case 340: return 108; //千葉県北東部
                case 341: return 109; //千葉県北西部
                case 342: return 110; //千葉県南部
                case 349: return 111; //房総半島南方沖
                case 350: return 112; //東京都２３区
                case 351: return 113; //東京都多摩東部
                case 352: return 114; //東京都多摩西部
                case 360: return 115; //神奈川県東部
                case 361: return 116; //神奈川県西部
                case 370: return 117; //新潟県上越地方
                case 371: return 118; //新潟県中越地方
                case 372: return 119; //新潟県下越地方
                case 378: return 120; //新潟県下越沖
                case 379: return 121; //新潟県上中越沖
                case 380: return 122; //富山県東部
                case 381: return 123; //富山県西部
                case 390: return 124; //石川県能登地方
                case 391: return 125; //石川県加賀地方
                case 400: return 126; //福井県嶺北
                case 401: return 127; //福井県嶺南
                case 411: return 129; //山梨県中・西部
                case 412: return 130; //山梨県東部・富士五湖
                case 420: return 131; //長野県北部
                case 421: return 132; //長野県中部
                case 422: return 133; //長野県南部
                case 430: return 134; //岐阜県飛騨地方
                case 431: return 135; //岐阜県美濃東部
                case 432: return 136; //岐阜県美濃中西部
                case 440: return 137; //静岡県伊豆地方
                case 441: return 138; //静岡県東部
                case 442: return 139; //静岡県中部
                case 443: return 140; //静岡県西部
                case 450: return 141; //愛知県東部
                case 451: return 142; //愛知県西部
                case 460: return 143; //三重県北部
                case 461: return 144; //三重県中部
                case 462: return 145; //三重県南部
                case 469: return 146; //三重県南東沖
                case 471: return 148; //茨城県沖
                case 472: return 149; //関東東方沖
                case 473: return 150; //千葉県東方沖
                case 475: return 152; //八丈島東方沖
                case 476: return 153; //八丈島近海
                case 477: return 154; //東京湾
                case 478: return 155; //相模湾
                case 480: return 157; //伊豆大島近海
                case 481: return 158; //伊豆半島東方沖
                case 482: return 159; //三宅島近海
                case 483: return 160; //新島・神津島近海
                case 485: return 162; //駿河湾
                case 486: return 163; //駿河湾南方沖
                case 487: return 164; //遠州灘
                case 489: return 166; //三河湾
                case 490: return 167; //伊勢湾
                case 492: return 169; //若狭湾
                case 493: return 170; //福井県沖
                case 494: return 171; //石川県西方沖
                case 495: return 172; //能登半島沖
                case 497: return 174; //富山湾
                case 498: return 175; //佐渡付近
                case 499: return 176; //東海道南方沖
                case 500: return 177; //滋賀県北部
                case 501: return 178; //滋賀県南部
                case 510: return 179; //京都府北部
                case 511: return 180; //京都府南部
                case 520: return 181; //大阪府北部
                case 521: return 182; //大阪府南部
                case 530: return 183; //兵庫県北部
                case 531: return 184; //兵庫県南東部
                case 532: return 185; //兵庫県南西部
                case 540: return 186; //奈良県
                case 550: return 187; //和歌山県北部
                case 551: return 188; //和歌山県南部
                case 560: return 189; //鳥取県東部
                case 562: return 191; //鳥取県中部
                case 563: return 192; //鳥取県西部
                case 570: return 193; //島根県東部
                case 571: return 194; //島根県西部
                case 580: return 195; //岡山県北部
                case 581: return 196; //岡山県南部
                case 590: return 197; //広島県北部
                case 591: return 198; //広島県南東部
                case 592: return 199; //広島県南西部
                case 600: return 200; //徳島県北部
                case 601: return 201; //徳島県南部
                case 610: return 202; //香川県東部
                case 611: return 203; //香川県西部
                case 620: return 204; //愛媛県東予
                case 621: return 205; //愛媛県中予
                case 622: return 206; //愛媛県南予
                case 630: return 207; //高知県東部
                case 631: return 208; //高知県中部
                case 632: return 209; //高知県西部
                case 673: return 213; //土佐湾
                case 674: return 214; //紀伊水道
                case 675: return 215; //大阪湾
                case 676: return 216; //播磨灘
                case 677: return 217; //瀬戸内海中部
                case 678: return 218; //安芸灘
                case 679: return 219; //周防灘
                case 680: return 220; //伊予灘
                case 681: return 221; //豊後水道
                case 682: return 222; //山口県北西沖
                case 683: return 223; //島根県沖
                case 684: return 224; //鳥取県沖
                case 685: return 225; //隠岐島近海
                case 686: return 226; //兵庫県北方沖
                case 687: return 227; //京都府沖
                case 688: return 228; //淡路島付近
                case 689: return 229; //和歌山県南方沖
                case 700: return 230; //山口県北部
                case 702: return 232; //山口県西部
                case 703: return 233; //山口県東部
                case 704: return 234; //山口県中部
                case 710: return 235; //福岡県福岡地方
                case 711: return 236; //福岡県北九州地方
                case 712: return 237; //福岡県筑豊地方
                case 713: return 238; //福岡県筑後地方
                case 720: return 239; //佐賀県北部
                case 721: return 240; //佐賀県南部
                case 730: return 241; //長崎県北部
                case 731: return 242; //長崎県南西部
                case 732: return 243; //長崎県島原半島
                case 740: return 244; //熊本県阿蘇地方
                case 741: return 245; //熊本県熊本地方
                case 742: return 246; //熊本県球磨地方
                case 743: return 247; //熊本県天草・芦北地方
                case 750: return 248; //大分県北部
                case 751: return 249; //大分県中部
                case 752: return 250; //大分県南部
                case 753: return 251; //大分県西部
                case 760: return 252; //宮崎県北部平野部
                case 761: return 253; //宮崎県北部山沿い
                case 762: return 254; //宮崎県南部平野部
                case 763: return 255; //宮崎県南部山沿い
                case 770: return 256; //鹿児島県薩摩地方
                case 771: return 257; //鹿児島県大隅地方
                case 783: return 261; //五島列島近海
                case 784: return 262; //天草灘
                case 785: return 263; //有明海
                case 786: return 264; //橘湾
                case 787: return 265; //鹿児島湾
                case 790: return 268; //種子島近海
                case 791: return 269; //日向灘
                case 793: return 271; //奄美大島近海
                case 795: return 273; //壱岐・対馬近海
                case 796: return 274; //福岡県北西沖
                case 797: return 275; //薩摩半島西方沖
                case 798: return 276; //トカラ列島近海
                case 799: return 277; //奄美大島北西沖
                case 820: return 278; //大隅半島東方沖
                case 821: return 279; //九州地方南東沖
                case 822: return 280; //種子島南東沖
                case 823: return 281; //奄美大島北東沖
                case 850: return 282; //沖縄本島近海
                case 851: return 283; //南大東島近海
                case 852: return 284; //沖縄本島南方沖
                case 853: return 285; //宮古島近海
                case 854: return 286; //石垣島近海
                case 855: return 287; //石垣島南方沖
                case 856: return 288; //西表島付近
                case 857: return 289; //与那国島近海
                case 858: return 290; //沖縄本島北西沖
                case 859: return 291; //宮古島北西沖
                case 860: return 292; //石垣島北西沖
                case 900: return 293; //台湾付近
                case 901: return 294; //東シナ海
                case 902: return 295; //四国沖
                case 903: return 296; //鳥島近海
                case 904: return 297; //鳥島東方沖
                case 905: return 298; //オホーツク海南部
                case 906: return 299; //サハリン西方沖
                case 907: return 300; //日本海北部
                case 908: return 301; //日本海中部
                case 909: return 302; //日本海西部
                case 911: return 304; //父島近海
                case 912: return 305; //千島列島
                case 913: return 306; //千島列島南東沖
                case 914: return 307; //北海道南東沖
                case 915: return 308; //東北地方東方沖
                case 916: return 309; //小笠原諸島西方沖
                case 917: return 310; //硫黄島近海
                case 918: return 311; //小笠原諸島東方沖
                case 919: return 312; //南海道南方沖
                case 920: return 313; //薩南諸島東方沖
                case 921: return 314; //本州南方沖
                case 922: return 315; //サハリン南部付近
                case 930: return 316; //北西太平洋
                case 932: return 318; //マリアナ諸島
                case 933: return 319; //黄海
                case 934: return 320; //朝鮮半島南部
                case 935: return 321; //朝鮮半島北部
                case 936: return 322; //中国東北部
                case 937: return 323; //ウラジオストク付近
                case 938: return 324; //シベリア南部
                case 939: return 325; //サハリン近海
                case 940: return 326; //アリューシャン列島
                case 941: return 327; //カムチャツカ半島付近
                case 942: return 328; //北米西部
                case 943: return 329; //北米中部
                case 944: return 330; //北米東部
                case 945: return 331; //中米
                case 946: return 332; //南米西部
                case 947: return 333; //南米中部
                case 948: return 334; //南米東部
                case 949: return 335; //北東太平洋
                case 950: return 336; //南太平洋
                case 951: return 337; //インドシナ半島付近
                case 952: return 338; //フィリピン付近
                case 953: return 339; //インドネシア付近
                case 954: return 340; //グアム付近
                case 955: return 341; //ニューギニア付近
                case 956: return 342; //ニュージーランド付近
                case 957: return 343; //オーストラリア付近
                case 958: return 344; //シベリア付近
                case 959: return 345; //ロシア西部
                case 960: return 346; //ロシア中部
                case 961: return 347; //ロシア東部
                case 962: return 348; //中央アジア
                case 963: return 349; //中国西部
                case 964: return 350; //中国中部
                case 965: return 351; //中国東部
                case 966: return 352; //インド付近
                case 967: return 353; //インド洋
                case 968: return 354; //中東
                case 969: return 355; //ヨーロッパ西部
                case 970: return 356; //ヨーロッパ中部
                case 971: return 357; //ヨーロッパ東部
                case 972: return 358; //地中海
                case 973: return 359; //アフリカ西部
                case 974: return 360; //アフリカ中部
                case 975: return 361; //アフリカ東部
                case 976: return 362; //北大西洋
                case 977: return 363; //南大西洋
                case 978: return 364; //北極付近
                case 979: return 365; //南極付近
                default: return 399;
            }
        }
    }
}
