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
            none
        };
        public Image byteArrayToImage(byte[] bytesArr)//インターネットからダウンロードするときに必要
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
        private string GetTypeToURL(KyoshinType type,bool IsBour)
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
                default:
                    TypeName = "";
                    break;

            }
            
            if (TypeName != "")
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
                    KImage = byteArrayToImage(Network.GetData("http://www.kmoni.bosai.go.jp/data/map_img/EstShindoImg/eew/" + time.ToString("yyyyMMdd") + "/" + time.ToString("yyyyMMddHHmmss") + ".eew.gif"));
                    EEWShindo = KImage;
                    if (KImage != null)
                    {
                        graphics.DrawImage(KImage, new Point(0, 0));
                        KImage.Dispose();
                    }
                }
                KImage = null;
                if (TypeName != "")
                {
                    KImage = byteArrayToImage(Network.GetData("http://www.kmoni.bosai.go.jp/data/map_img/RealTimeImg/" + TypeName + "/" + time.ToString("yyyyMMdd") + "/" + time.ToString("yyyyMMddHHmmss") + "." + TypeName + ".gif"));
                    
                    if (KImage != null)
                    {
                        graphics.DrawImage(KImage, new Point(0, 0));
                        KImage.Dispose();
                    }
                }
                KImage = null;
                if (IsPSV)
                {

                    KImage = byteArrayToImage(Network.GetData("http://www.kmoni.bosai.go.jp/data/map_img/PSWaveImg/eew/" + time.ToString("yyyyMMdd") + "/" + time.ToString("yyyyMMddHHmmss") + ".eew.gif"));
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
