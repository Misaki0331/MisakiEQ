using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Newtonsoft.Json;
using System.IO;
using System.Globalization;
namespace MisakiEQ
{
    class KyoshinEx
    {

        private string LastErrorStatus;
        private bool IsLastError;
        private Image EEWCircle;
        private Image EEWShindo;
        public enum KyoshinType{
            RealTime_Shindo,            //リアルタイム震度
            PGA,                        //最大加速度
            PGV,                        //最大速度
            PGD,                        //最大変位
            Response_0125,              //0.125Hz応答
            Response_0250,              //0.25Hz応答
            Response_0500,              //0.5Hz応答
            Response_1000,              //1Hz応答
            Response_2000,              //2Hz応答
            Response_4000,              //4Hz応答
            EEW_EST,
            EEW_Circle,
            none
        };
        public static Image byteArrayToImage(byte[] bytesArr)//インターネットからダウンロードするときに必要
        {
            try
            {
                using (MemoryStream memstr = new MemoryStream(bytesArr))
                {
                    Image img = Image.FromStream(memstr);
                    return img;
                }
            }
            catch
            {
                return null;
            }
        
        }
        private static string GetTypeToURL(KyoshinType type, bool IsBour)
        {
            string TypeName = "";
            switch (type)
            {
                case KyoshinType.RealTime_Shindo:
                    TypeName = "jma";
                    break;
                case KyoshinType.PGA:
                    TypeName = "acmap";
                    break;
                case KyoshinType.PGV:
                    TypeName = "vcmap";
                    break;
                case KyoshinType.PGD:
                    TypeName = "dcmap";
                    break;
                case KyoshinType.Response_0125:
                    TypeName = "rsp0125";
                    break;
                case KyoshinType.Response_0250:
                    TypeName = "rsp0250";
                    break;
                case KyoshinType.Response_0500:
                    TypeName = "rsp0500";
                    break;
                case KyoshinType.Response_1000:
                    TypeName = "rsp1000";
                    break;
                case KyoshinType.Response_2000:
                    TypeName = "rsp2000";
                    break;
                case KyoshinType.Response_4000:
                    TypeName = "rsp4000";
                    break;
                case KyoshinType.EEW_EST:
                    TypeName = "eew";
                    break;
                case KyoshinType.EEW_Circle:
                    TypeName = "eew";
                    break;
                default:
                    TypeName = "";
                    break;

            }

            if (TypeName != "" && TypeName != "eew")
            {
                if (IsBour)
                {
                    TypeName += "_b";
                }
                else
                {
                    TypeName += "_s";
                }

            }
            return TypeName;
        }//これは表示種類と地中か地表かをURLにすぐに出してくれる関数
        private static string GetTypeToLURL(KyoshinType type,bool IsBour)
        {
            string TypeName = "";
            switch (type)
            {
                case KyoshinType.RealTime_Shindo:
                    TypeName = "RealTimeImg/jma";
                    break;
                case KyoshinType.PGA:
                    TypeName = "RealTimeImg/acmap";
                    break;
                case KyoshinType.PGV:
                    TypeName = "RealTimeImg/vcmap";
                    break;
                case KyoshinType.PGD:
                    TypeName = "RealTimeImg/dcmap";
                    break;
                case KyoshinType.Response_0125:
                    TypeName = "RealTimeImg/rsp0125";
                    break;
                case KyoshinType.Response_0250:
                    TypeName = "RealTimeImg/rsp0250";
                    break;
                case KyoshinType.Response_0500:
                    TypeName = "RealTimeImg/rsp0500";
                    break;
                case KyoshinType.Response_1000:
                    TypeName = "RealTimeImg/rsp1000";
                    break;
                case KyoshinType.Response_2000:
                    TypeName = "RealTimeImg/rsp2000";
                    break;
                case KyoshinType.Response_4000:
                    TypeName = "RealTimeImg/rsp4000";
                    break;
                case KyoshinType.EEW_EST:
                    TypeName = "EstShindoImg/eew";
                    break;
                case KyoshinType.EEW_Circle:
                    TypeName = "PSWaveImg/eew";
                    break;
                default:
                    TypeName = "";
                    break;

            }
            
            if (TypeName != ""&&TypeName!= "EstShindoImg/eew"&&TypeName!= "PSWaveImg/eew")
            {
                if (IsBour)
                {
                    TypeName += "_b";
                }
                else
                {
                    TypeName += "_s";
                }
               
            }
            return TypeName;
        }//これは表示種類と地中か地表かをURLにすぐに出してくれる関数
        static bool IsEEW(KyoshinType type)
        {
            if (type == KyoshinType.EEW_EST || type == KyoshinType.EEW_Circle)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Image CompImageEx(Image[] CompImages)//地図付きで強震モニタの画像を合成
        {
            Image BG = new Bitmap(352, 400);
            Graphics graphics;
            graphics = Graphics.FromImage(BG);
            graphics.DrawImage(Properties.Resources.Kyoshin_Basemap, new Point(0, 0));
            for (int i = 0; i < CompImages.Count(); i++)
            {
                graphics.DrawImage(CompImages[i], new Point(0, 0));
                
            }
            graphics.Dispose();
            for(int i = CompImages.Count(); i >= 0; i--) CompImages[i].Dispose();
            return BG;
            
        }
        async Task<Image> GetKyoshinImage(DateTime time, KyoshinType type)
        {
            try { 
            GetJsonFile Network = new GetJsonFile();
            string a = "";
            if (IsEEW(type)) a = ".eew";
            Image Result = byteArrayToImage(Network.GetData("http://www.kmoni.bosai.go.jp/data/map_img/" + GetTypeToLURL(type, false) + "/" + time.ToString("yyyyMMdd") + "/" + time.ToString("yyyyMMddHHmmss") + "."+ GetTypeToURL(type, false) + ".gif"));
            return Result;
            }
            catch (Exception e)
            {
                Console.WriteLine($"強震モニタのデータをダウンロードする際に例外エラー\n理由 : {e.Message}");
            }
            return null;
}
        async Task<Image> GetKyoshinImage(DateTime time,KyoshinType type,bool isbool)
        {
            try
            {
                GetJsonFile Network = new GetJsonFile();
                string a = "";
                if (IsEEW(type)) a = ".eew";
                return byteArrayToImage(Network.GetData("http://www.kmoni.bosai.go.jp/data/map_img/" + GetTypeToLURL(type, isbool) + "/" + time.ToString("yyyyMMdd") + "/" + time.ToString("yyyyMMddHHmmss") +"." +GetTypeToURL(type, isbool) + ".gif"));
            }
            catch (Exception e)
            {
                Console.WriteLine($"強震モニタのデータをダウンロードする際に例外エラー\n理由 : {e.Message}");
            }
            return null;
        }

        public Image GetFastImage(DateTime time, KyoshinType type, bool IsBour,bool IsESTShindo,bool IsPSV,bool NoneBG=false)//直接データが欲しい場合 (時間,表示タイプ,地中フラグ,予測震度表示,予測円表示)
        {
            try
            {
                GetJsonFile Network = new GetJsonFile();
                string TypeName = GetTypeToURL(type, IsBour);

                //ImageオブジェクトのGraphicsオブジェクトを作成する

                Image BG = new Bitmap(352, 400);
                Graphics graphics;
                graphics = Graphics.FromImage(BG);
                Task<Image> ESTImg = null;
                Task<Image> RealTimeImg =null;
                Task<Image> CircleImg =null;



                if(IsESTShindo)ESTImg = Task.Run<Image>(() => { return GetKyoshinImage(time, KyoshinType.EEW_EST); });
                RealTimeImg = Task.Run<Image>(() => { return GetKyoshinImage(time, type,IsBour); });
                if(IsPSV)CircleImg = Task.Run<Image>(() => { return GetKyoshinImage(time, KyoshinType.EEW_Circle); });
                
                
                
                if (!NoneBG)
                {
                    graphics.DrawImage(Properties.Resources.Kyoshin_Basemap,new Point(0,0));
                    
                }
                else
                {
                    graphics.Clear(Color.FromArgb(0, 0, 0, 0));
                }
                Image KImage = null;
                if (IsESTShindo)
                {
                    ESTImg.Wait();
                    KImage = ESTImg.Result;

                    if (KImage != null) { EEWShindo = (Image)KImage.Clone(); } else
                    {
                        
                        EEWShindo = null;
                    }
                    
                    if (KImage != null)
                    {
                        graphics.DrawImage(KImage, new Point(0, 0));
                        KImage.Dispose();
                    }
                }
                KImage = null;
                if (TypeName != "")
                {
                    RealTimeImg.Wait();
                    KImage = RealTimeImg.Result;
                    //KImage = byteArrayToImage(Network.GetData("http://www.kmoni.bosai.go.jp/data/map_img/RealTimeImg/" + TypeName + "/" + time.ToString("yyyyMMdd") + "/" + time.ToString("yyyyMMddHHmmss") + "." + TypeName + ".gif"));
                    
                    if (KImage != null)
                    {
                        graphics.DrawImage(KImage, new Point(0, 0));
                        KImage.Dispose();
                    }
                }
                KImage = null;
                if (IsPSV)
                {
                    CircleImg.Wait();
                    KImage = CircleImg.Result;
                    //KImage = byteArrayToImage(Network.GetData("http://www.kmoni.bosai.go.jp/data/map_img/PSWaveImg/eew/" + time.ToString("yyyyMMdd") + "/" + time.ToString("yyyyMMddHHmmss") + ".eew.gif"));
                    EEWCircle = KImage;
                    if (KImage != null)
                    {
                        graphics.DrawImage(KImage, new Point(0, 0));
                        KImage.Dispose();
                    }
                }
                KImage = null;
                graphics.Dispose();
                graphics = null;
                IsLastError = false;
                return BG;
            }
            catch
            {
                IsLastError = true;
                LastErrorStatus = "デバッグ操作中にエラー";
                return null;
            }
        }
        public double GetEEWAreaShindo(Point Pos)
        {
            try{
                List<KyoshinShindoColor> color = JsonConvert.DeserializeObject<List<KyoshinShindoColor>>(Properties.Resources.KyoshinColor);
                if (EEWShindo == null) return 0;
                if (EEWShindo.Width != 352 && EEWShindo.Height != 400) return 0;
                Color col = ((Bitmap)EEWShindo).GetPixel((int)Pos.X, (int)Pos.Y);
                if (col.A == 0) return 0;
                for (int i = color.Count - 1; color[i].Intensity >= 0; i--)
                {
                    if (col.R == color[i].R && col.G == color[i].G && col.B == color[i].B)
                    {
                        return color[i].Intensity;
                    }
                }
            }
            catch
            {
                IsLastError = true ;
                LastErrorStatus = "強震モニタの震度情報読み取りに失敗";
            }
            return 0;

        } 
        public bool GetErrorFlg()
        {
            return IsLastError;
        }
        public string GetLastError()
        {
            if (IsLastError) return LastErrorStatus;
            return "正常に処理が終了しました。";
        }
        public DateTime GetLatestUpdateTime()//強震モニタの最新更新時間を取得
        {
            try {
                GetJsonFile NetworkFile = new GetJsonFile();
                LatestKyoshinRoot latest = JsonConvert.DeserializeObject<LatestKyoshinRoot>(NetworkFile.GetJson("http://www.kmoni.bosai.go.jp/webservice/server/pros/latest.json"));
                DateTime ret = new DateTime(2000, 1, 1, 0, 0, 0);
                IsLastError = true;
                if (DateTime.TryParseExact(latest.latest_time, "yyyy/MM/dd HH:mm:ss", null, DateTimeStyles.AssumeLocal, out ret)) return ret;
                IsLastError = false;
                LastErrorStatus = "正常に取得できませんでした。(GetLatestUpdateTime関数内)";
                return new DateTime(2000, 1, 1, 0, 0, 0);
            }
            catch
            {
                IsLastError = true;
                LastErrorStatus = "予期しないエラー(GetLatestUpdateTime関数内)";
                return new DateTime(2000, 1, 1, 0, 0, 0);
            }
        }
    }
}
