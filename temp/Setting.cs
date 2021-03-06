using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Globalization;
using System.Threading;

namespace MisakiEQ
{
    
    public partial class Form1 : Form
    {
        public static int P2P_MaxRequest = 20;
        private static int IntervalEQ = 5;
        private static int IntervalTsunami = 10;
        private static long Tweet_LastID=0;
        private static bool IsGettingID = false;
        string TweetText = "";
        string EQJsonFile = "";
        string TestString = "Test Label";
        private DateTime EQLastUpdated;
        private DateTime TsunamiLastUpdated;
        private string NotificationName;
        private string NotificationIndex;
        private int NotificationIcon;
        private bool IsDisplayNotification;
        private static int DisplayingNotificationTime=10000;
        private long Count_Request = 0;
        private static bool IsEQRun=false;
        private string[] TweetData = new string[10];
        private bool isTweet = false;
        private bool isTweeting = false;
        private string EEWJsonFile = "";
        private long EEWLatestUNIXTime = 0;
        private bool isFailEQInit = true;
        private bool isFailEEWInit = true;
        private bool isEEWRun=false;
        private string EQ_IndexText = "";
        private string EEW_IndexText = "";
        private bool IsTsunamiRun = false;
        private bool EEW_TweetMode = false;
        private string EEW_EventID;
        private long EEW_LastTweetID = 0;
        private int EEW_SerialCountTemp = -1;
        private bool IsEQStatusOK = false;
        private bool IsEEWStatusOK = false;

        private bool IsFailTsunamiInit = true;
        private bool IsTsunamiStatusOK = true;
        private string TsunamiJsonFile = "";
        private string Tsunami_Index_text = "";
        private bool IsEQProtoGetTweetID = false;
        private long EQProtoGetTweetID = 0;
        private long ReplySetTweetID = 0;
        private bool IsTweetedEEW = false;
        //private Twitter TwiCliant;

        private static void GetLastID(ref long ID)
        {

        }
        public Form1()
        {
            InitializeComponent();
            Twitter TwiCliant = new Twitter();
            this.Twitter_Author.Text="投稿者 : " + TwiCliant.GetScreenName();
            this.P2P_Interval_EarthQuake.Value = IntervalEQ;
            this.P2P_Interval_Tsunami.Value = IntervalTsunami;
            P2P_Request_Changed();

            List<CoreTweet.Status> TwiList = TwiCliant.GetTweetUser("0x7FF", 1);
            this.UserName.Text = TwiList[0].User.ScreenName;
            this.Tweet_Index.Text = TwiList[0].Text;
            Tweet_LastID = TwiList[0].Id;
            GetEQHashs(true);
            Timer_EarthQuake.Start();
            Timer_EEW.Start();
            Timer_Tsunami.Start();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }
        private void P2P_Request_Changed()
        {
            double RequestValue = (60f / IntervalEQ) + (60f / IntervalTsunami);
            this.P2P_Request_Usage.Text = RequestValue.ToString("F2");
            this.P2P_Request_Max.Text = ((int)P2P_MaxRequest).ToString();
            this.P2P_Progress_Usage.Minimum = 0;
            this.P2P_Progress_Usage.Maximum = (int)(P2P_MaxRequest)*100;
            

            if (P2P_MaxRequest < RequestValue)
            {
                this.P2P_ErrorMassage.Visible = true;
                string MassageText = "注意：毎分 ";
                MassageText += P2P_MaxRequest.ToString();
                MassageText += " リクエスト以上は指定することはできません。";
                this.P2P_ErrorMassage.Text = MassageText;
                this.P2P_Conform.Visible = false;
                this.P2P_Request_Usage.ForeColor = Color.Red;
                this.P2P_Progress_Usage.Value = P2P_MaxRequest * 100;
            }
            else
            {
                this.P2P_Progress_Usage.Value = (int)(RequestValue*100);
                this.P2P_ErrorMassage.Text = "";
                this.P2P_ErrorMassage.Visible = false;
                this.P2P_Conform.Visible = true;
                this.P2P_Request_Usage.ForeColor = Color.Black;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void P2P_ErrorMassage_Click(object sender, EventArgs e)
        {

        }

        private void P2P_Interval_EarthQuake_ValueChanged(object sender, EventArgs e)
        {
            IntervalEQ = (int)this.P2P_Interval_EarthQuake.Value;
            P2P_Request_Changed();
        }
        

        private void P2P_Interval_Tsunami_ValueChanged(object sender, EventArgs e)
        {
            IntervalTsunami = (int)this.P2P_Interval_Tsunami.Value;
            P2P_Request_Changed();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TweetText = this.textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Twitter TwiCliant = new Twitter();
            if (this.Twitter_isReply.Checked)
            {
                TwiCliant.Reply(Tweet_LastID,TweetText);
            }
            else
            {
                TwiCliant.Tweet(TweetText);
            }
            List<CoreTweet.Status> TwiList = TwiCliant.GetTweetUser("0x7FF", 1);
            this.UserName.Text = TwiList[0].User.ScreenName;
            this.Tweet_Index.Text = TwiList[0].Text;
            Tweet_LastID = TwiList[0].Id;
            //Tweet_LastID = 
        }

        private void Twitter_Author_Click(object sender, EventArgs e)
        {
            
        }

        private void Twitter_Update_Click(object sender, EventArgs e)
        {
            Twitter TwiCliant = new Twitter();
            List<CoreTweet.Status> TwiList=TwiCliant.GetTweetUser("0x7FF", 1);
            this.UserName.Text = TwiList[0].User.ScreenName;
            this.Tweet_Index.Text = TwiList[0].Text;
            Tweet_LastID = TwiList[0].Id;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }
        private void P2P_Conform_Click(object sender, EventArgs e)
        {
            this.Timer_EarthQuake.Interval = (int)P2P_Interval_EarthQuake.Value * 1000;
            this.Timer_Tsunami.Interval = (int)P2P_Interval_Tsunami.Value * 1000;
        }
        private void GetEQHashs(bool getFromWeb)
        {
            TestString = "";
            GetJsonFile NetFile;
            NetFile = new GetJsonFile();
            try
            {
                if (getFromWeb || EQJsonFile == "")
                {
                    EQJsonFile = NetFile.GetJson("https://api.p2pquake.net/v2/jma/quake?limit=10&order=-1");
                }
                List<EQRoot> JsonData = JsonConvert.DeserializeObject<List<EQRoot>>(EQJsonFile);

                //TestString = "Time : " + JsonData[0].created_at;
                DateTime created_at;
                DataConverter converter = new DataConverter();
                created_at = converter.GetTime(JsonData[0].created_at);
                if (!converter.GetTimeError())
                {
                    EQLastUpdated = created_at;
                    LoadEQData(JsonData[0], false);
                    isFailEQInit = false;
                }
            }
            catch
            {
                isFailEQInit = true;
            }
            try
            {
                if (getFromWeb || EEWJsonFile == "")
                {
                    EEWJsonFile = NetFile.GetJson("https://api.iedred7584.com/eew/json/");
                }
                EEWRoot eew = JsonConvert.DeserializeObject<EEWRoot>(EEWJsonFile);
                EEWLatestUNIXTime = eew.AnnouncedTime.UnixTime;
                if (EEWLatestUNIXTime != 0)
                {
                    isFailEEWInit = false;
                    EEW_SerialCountTemp = eew.Serial;
                }
            }
            catch
            {
                isFailEEWInit = true;
            }
            try
            {
                if(getFromWeb || TsunamiJsonFile == "")
                {
                    TsunamiJsonFile = NetFile.GetJson("https://api.p2pquake.net/v2/jma/tsunami?limit=10&order=-1");
                }
                List<TsunamiRoot> tsunami = JsonConvert.DeserializeObject<List<TsunamiRoot>>(TsunamiJsonFile);
                DateTime created_at;
                DataConverter converter = new DataConverter();
                created_at = converter.GetTime(tsunami[0].created_at);
                if (!converter.GetTimeError())
                {
                    TsunamiLastUpdated = created_at;
                    LoadTsunamiData(tsunami[0],false);
                    IsFailTsunamiInit = false;
                }

            }
            catch
            {
                IsFailTsunamiInit = true;
            }
        }
        
        
        private void LoadEQData(EQRoot data, bool tweet)
        {
            DataConverter converter = new DataConverter();
            DateTime time = new DateTime();
            bool[] Area = new bool[48];
            string[] AreaData = new string[20];
            int StringCount = 0;
            String ShindoText = "";
            switch ( converter.GetEQInfomationType(data.issue.type))
            {
                case 1://震度速報
                    


                    for (int shindo = 9; shindo > 0; shindo--)
                    {
                        int tc = 0;//都道府県のカウント数
                        bool IsNew = false;
                        for (int c = 0; c < data.points.Count; c++)
                        {
                            if (converter.ScaleToValue(data.points[c].scale) == shindo)
                            {
                                if (Area[converter.AreaToValue(data.points[c].pref)] == false)
                                {
                                    Area[converter.AreaToValue(data.points[c].pref)] = true;
                                    if (!IsNew)
                                    {
                                        AreaData[StringCount] = "震度" + converter.EasyScaleToString(shindo) + "：" + converter.ValueToAreaShort(converter.AreaToValue(data.points[c].pref));
                                        tc++;
                                        IsNew = true;
                                    }
                                    else if (tc == 6)
                                    {
                                        tc = 0;
                                        StringCount++;
                                        if (shindo >= 5 && shindo < 9)
                                        {
                                            AreaData[StringCount] = "　　　　　" + converter.ValueToAreaShort(converter.AreaToValue(data.points[c].pref));
                                        }
                                        else
                                        {
                                            AreaData[StringCount] = "　　　　" + converter.ValueToAreaShort(converter.AreaToValue(data.points[c].pref));
                                        }
                                        tc++;
                                    }
                                    else
                                    {
                                        AreaData[StringCount] += " " + converter.ValueToAreaShort(converter.AreaToValue(data.points[c].pref));
                                        tc++;
                                    }
                                }
                            }
                        }
                        if (tc != 0)
                        {
                            StringCount++;
                        }
                    }
                    
                    for (int i = 0; AreaData[i] != null; i++)
                    {
                        ShindoText += AreaData[i] + "\n";
                    }
                    if (AreaData[0] == null) ;
                    time = converter.GetTime(data.earthquake.time);
                    if (converter.GetTimeError()) return;
                    EQ_IndexText = "震度速報\n"+time.ToString("yyyy年MM月dd日 H時mm分頃") + "\n震度" + converter.ScaleString(data.earthquake.maxScale) + "を観測する地震がありました。\n" +
                        "この地震による" + converter.EQTsunamiTextJP(converter.GetDomesticTsunami(data.earthquake.domesticTsunami)) + "\n観測した地域は以下の通りです。\n\n" + ShindoText;

                    if (tweet)
                    {
                        TweetData[0] = "震度速報\n" + time.ToString("yyyy年MM月dd日 H時mm分頃") + "\n震度" + converter.ScaleString(data.earthquake.maxScale) + "を観測する地震がありました。\n" +
                        "この地震による" + converter.EQTsunamiTextJP(converter.GetDomesticTsunami(data.earthquake.domesticTsunami));
                        if (AreaData[0] !=null)
                        {
                            TweetData[0] += "\n観測した地域は以下の通りです。\n\n";
                        }
                        else
                        {
                            TweetData[0] += "\n地域震度は現在調査中です。\n\n";
                        }
                        
                        int j = 0;
                        int len = 0;
                        Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                        len = sjisEnc.GetByteCount(TweetData[0]);
                        for (int i = 0; AreaData[i] != null; i++)
                        {
                            
                            int num = sjisEnc.GetByteCount(AreaData[i]) + 1;
                            if (len + num > 250)
                            {
                               
                                len = 0;
                                j++;
                            }
                            TweetData[j] += AreaData[i] + "\n";
                            len += num;
                        }
                        TweetData[0] += "#MisakiEQ #地震 #震度速報";
                        IsEQProtoGetTweetID = true;
                        isTweet = true;

                        NotificationName = "震度速報(" + time.ToString("yyyy/MM/dd H:mm") + ")";
                        NotificationIndex =  AreaData[0] + 
                            "\n" + converter.EQTsunamiTextJP(converter.GetDomesticTsunami(data.earthquake.domesticTsunami));
                        DisplayingNotificationTime = 2147483647;
                        NotificationIcon = 2;
                        IsDisplayNotification = true;
                    }
                    break;
                case 2://震源に関する情報
                    break;
                case 3://震度・震源に関する情報
                    break;
                case 4://各地の震度に関する情報
                   
                    

                    
                    for(int shindo = 9; shindo > 0; shindo--)
                    {
                        int tc = 0;//都道府県のカウント数
                        bool IsNew = false;
                        for(int c = 0; c < data.points.Count; c++)
                        {
                            if (converter.ScaleToValue(data.points[c].scale) == shindo)
                            {
                                if (Area[converter.AreaToValue(data.points[c].pref)] == false)
                                {
                                    Area[converter.AreaToValue(data.points[c].pref)] = true;
                                    if (!IsNew) {
                                        AreaData[StringCount] = "震度" + converter.EasyScaleToString(shindo) + "：" + converter.ValueToAreaShort(converter.AreaToValue(data.points[c].pref));
                                        tc++;
                                        IsNew = true;
                                    }
                                    else if(tc==6)
                                    {
                                        tc = 0;
                                        StringCount++;
                                        if (shindo >= 5 && shindo < 9)
                                        {
                                            AreaData[StringCount] = "　　　　　" + converter.ValueToAreaShort(converter.AreaToValue(data.points[c].pref));
                                        }
                                        else
                                        {
                                            AreaData[StringCount] = "　　　　" + converter.ValueToAreaShort(converter.AreaToValue(data.points[c].pref));
                                        }
                                        tc++;
                                    }
                                    else
                                    {
                                        AreaData[StringCount] += " " + converter.ValueToAreaShort(converter.AreaToValue(data.points[c].pref));
                                        tc++;
                                    }
                                }
                            }
                        }
                        if (tc != 0)
                        {
                            StringCount++;
                        }
                    }
                    
                    for(int i = 0; AreaData[i] != null; i++)
                    {
                        ShindoText += AreaData[i]+"\n";
                    }
                    if (AreaData[0] == null) ;
                    time = converter.GetTime(data.earthquake.time);
                    if (converter.GetTimeError()) return;
                    EQ_IndexText = time.ToString("yyyy年MM月dd日 H時mm分頃") + "\n\n" + data.earthquake.hypocenter.name + "で地震が発生しました。\n" +
                        "地震の規模：M" + data.earthquake.hypocenter.magnitude.ToString("F1") + "\n" +
                        "震源の深さ：" + converter.DeepString(data.earthquake.hypocenter.depth) + "\n" +
                        "最大震度：" + converter.ScaleString(data.earthquake.maxScale) + "\n" +
                        "この地震による" + converter.EQTsunamiTextJP(converter.GetDomesticTsunami(data.earthquake.domesticTsunami))+"\n\n"+ShindoText;
                    if ((data.earthquake.hypocenter.magnitude >= 4||converter.ScaleToValue(data.earthquake.maxScale)>=3)||IsTweetedEEW)
                    {
                        if (tweet)
                        {

                            TweetData[0] = time.ToString("yyyy年MM月dd日 H時mm分頃") + "\n\n" + data.earthquake.hypocenter.name + "で地震が発生しました。\n" +
                            "地震の規模：M " + data.earthquake.hypocenter.magnitude.ToString("F1") + "\n" +
                            "震源の深さ：" + converter.DeepString(data.earthquake.hypocenter.depth) + "\n" +
                            "最大震度：" + converter.ScaleString(data.earthquake.maxScale) + "\n" +
                            "この地震による" + converter.EQTsunamiTextJP(converter.GetDomesticTsunami(data.earthquake.domesticTsunami)) + "\n";
                            if (AreaData[0] == null)
                            {
                                TweetData[0] += "震度情報はありません。\n#MisakiEQ #地震";
                            }
                            else if (AreaData[1] == null)
                            {
                                TweetData[0] += AreaData[0] + "\n#MisakiEQ #地震";
                            }
                            else
                            {
                                TweetData[0] += "各地の地域震度は以下の通りです。\n#MisakiEQ #地震 ";
                                int j = 1;
                                int len = 0;
                                for (int i = 0; AreaData[i] != null; i++)
                                {
                                    Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                                    int num = sjisEnc.GetByteCount(AreaData[i]) + 1;
                                    if (len + num > 270)
                                    {
                                        len = 0;
                                        j++;
                                    }
                                    TweetData[j] += AreaData[i] + "\n";
                                    len += num;
                                }
                            }
                            ReplySetTweetID = EQProtoGetTweetID;
                            EQProtoGetTweetID = 0;
                            isTweet = true;
                            IsTweetedEEW = false;

                        }
                    }
                    if (tweet)
                    {
                        NotificationName = "地震情報(" + time.ToString("yyyy/MM/dd H:mm") + ")";
                        NotificationIndex = data.earthquake.hypocenter.name + " M " + data.earthquake.hypocenter.magnitude.ToString("F1") +
                            " " + converter.DeepString(data.earthquake.hypocenter.depth) + " 最大:" + converter.ScaleString(data.earthquake.maxScale) +
                            "\nこの地震による" + converter.EQTsunamiTextJP(converter.GetDomesticTsunami(data.earthquake.domesticTsunami));
                        DisplayingNotificationTime = 2147483647;
                        NotificationIcon = 1;
                        IsDisplayNotification = true;
                        
                    }
                    break;
                case 5://遠地地震に関する情報
                    break;
                default:
                    return;
            }
        }
        private void LoadTsunamiData(TsunamiRoot tsunami, bool tweet)
        {
            string[] vs=new string[30];
            int maxType = 0;
            DateTime time;
            DataConverter converter = new DataConverter();
            time = converter.GetTime(tsunami.time);
            vs[0] = "🟡🟡⚠津波情報";
            if (converter.GetTimeError())
            {
                vs[1] = "時刻取得エラー\n";
            }
            else {
                vs[1] = time.ToString("yyyy年MM月dd日 H時mm分現在");
            }
            vs[2] = " ";
            int line = 4;
            if (tsunami.cancelled)
            {
                vs[3] = "全ての津波予報が解除されました。";

            }

            else
            {
                vs[3] = "現在以下の地域に津波予報が発令されています。";
                vs[line] = " ";
                line++;
                int len = 0;
                bool IsFirst = false;
                for(int type = 3; type >= 0; type--)
                {
                    for(int i = 0; i < tsunami.areas.Count; i++)
                    {
                        if (type == converter.TsunamiTypeStringToValue(tsunami.areas[i].grade)&&tsunami.areas[i].immediate){
                            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                            int num = sjisEnc.GetByteCount(tsunami.areas[i].name) + 1;
                            if (maxType < type) maxType = type;
                            if (!IsFirst)
                            {
                                IsFirst = true;
                                vs[line] = converter.TsunamiTypeStringJP(type, true);
                                line++;
                                vs[line] += tsunami.areas[i].name;
                                len += num - 1;
                            }
                            else
                            {


                                if (len + num > 36 && len != 0)
                                {
                                    len = 0;
                                    line++;
                                    len += num - 1;
                                    vs[line] = tsunami.areas[i].name;
                                }
                                else
                                {
                                    vs[line] += " " + tsunami.areas[i].name;
                                    len += num;
                                }
                            }
                            

                        }
                    }

                    if (IsFirst)
                    {
                        line++;
                        vs[line] = " ";
                        line++;
                    }
                        IsFirst = false;
                    len = 0;
                    for (int i = 0; i < tsunami.areas.Count; i++)
                    {
                        if (type == converter.TsunamiTypeStringToValue(tsunami.areas[i].grade) && !(tsunami.areas[i].immediate))
                        {
                            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                            int num = sjisEnc.GetByteCount(tsunami.areas[i].name) + 1;
                            if (maxType < type) maxType = type;
                            if (!IsFirst)
                            {
                                IsFirst = true;
                                vs[line] = converter.TsunamiTypeStringJP(type, false);
                                line++;
                                vs[line] += tsunami.areas[i].name;
                                len += num-1;
                            }
                            else
                            {

                                if (len + num > 36 && len != 0)
                                {
                                    len = 0;
                                    line++;
                                    len += num - 1;
                                    vs[line] = tsunami.areas[i].name;
                                }
                                else
                                {
                                    vs[line] += " " + tsunami.areas[i].name;
                                    len += num;
                                }
                            }
                        }
                    }
                    if (IsFirst)
                    {
                        line++;
                        vs[line] = " ";
                        line++;
                    }
                    IsFirst = false;
                }
            }
            //vs[line] = "- 情報終わり";
            Tsunami_Index_text = vs[1];
            for(int i = 2; vs[i] != null; i++)
            {
                Tsunami_Index_text += "\n" + vs[i];
            }
            if (tweet)
            {
                int page = 0;
                TweetData[0] = vs[0];
                Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                int len = sjisEnc.GetByteCount(vs[0]) + 1;
                int num = 0;
                for(int i = 1; vs[i] != null; i++)
                {
                    num = sjisEnc.GetByteCount(vs[i]) + 1;
                    if (len + num > 240)
                    {
                        len = 0;
                        TweetData[page] += "\n";
                        page++;
                        if (page > 10) break;

                    }
                    TweetData[page] += "\n"+vs[i];
                    len += num;
                }
                TweetData[0] += "#MisakiEQ #地震 #津波 ";
                isTweet = true;

                NotificationName = "津波情報(" + time.ToString("yyyy/MM/dd H:mm現在") + ")";
                if (tsunami.cancelled) {
                    NotificationIndex = "全ての津波予報は解除されました。";
                    NotificationIcon = 1;
                }
                else
                {
                    bool isFirst = false;
                    NotificationIndex = "以下の地域で"+converter.TsunamiTypeStringJP(maxType, false)+"発令中\n";
                    for(int i=0; i < tsunami.areas.Count; i++)
                    {
                        if(maxType == converter.TsunamiTypeStringToValue(tsunami.areas[i].grade))
                        {
                            if (!isFirst)
                            {
                                isFirst = true;
                                NotificationIndex += tsunami.areas[i].name;
                            }
                            else
                            {
                                NotificationIndex +=" "+ tsunami.areas[i].name;
                            }
                        }
                    }
                    NotificationIcon = 2;
                }
                DisplayingNotificationTime = 2147483647;
               
                IsDisplayNotification = true;
            }
        }
        private void TweetThread()
        {
            try
            {
                /*int pc = 0;
                for(int i=0; TweetData[i] != "" && i < 10; i++)
                {
                    pc++;
                }*/
                long TweetID = 0;
                Twitter TwiCliant = new Twitter();
                
                for (int i = 0; TweetData[i] != "" && i < 10; i++)
                {
                    if (i == 0&&ReplySetTweetID==0)
                    {
                        /*if (pc != 1)
                        {
                            TwiCliant.Tweet(TweetData[0] + "(" + (i + 1).ToString() + "/" + pc.ToString() + ")");
                        }
                        else
                        {*/
                            TwiCliant.Tweet(TweetData[0]);
                        //}

                    }
                    else
                    {
                        if (ReplySetTweetID != 0)
                        {

                            TwiCliant.Reply(ReplySetTweetID, TweetData[i]);// + "(" + (i + 1).ToString() + "/" + pc.ToString() + ")");
                            ReplySetTweetID = 0;
                        }
                        else
                        {
                            TwiCliant.Reply(TweetID, TweetData[i]);// + "(" + (i + 1).ToString() + "/" + pc.ToString() + ")");
                        }
                    }
                    TweetID = TwiCliant.GetLatestTweetID();
                    if (IsEQProtoGetTweetID)
                    {
                        EQProtoGetTweetID = TweetID;
                        IsEQProtoGetTweetID = false;
                    }
                }

            }
            catch
            {
            }
            finally
            {
                
                for(int i = 0; i < 10; i++)
                {
                    TweetData[i] = null;
                }
                isTweeting = false;
                isTweet = false;
            }
        }
        private void GetEQJson()
        {
            try
            {
                GetJsonFile NetFile;
                NetFile = new GetJsonFile();
                EQJsonFile = NetFile.GetJson("https://api.p2pquake.net/v2/jma/quake?limit=10&order=-1");
                Count_Request++;



                //EQJsonFile = ConvertUTF8(EQJsonFile);
                List<EQRoot> JsonData = JsonConvert.DeserializeObject<List<EQRoot>>(EQJsonFile);



                //LoadEQData(JsonData[0]);
                //TestString ="Time : "+JsonData[0].created_at;
                DateTime created_at;

                for (int i = JsonData.Count-1; i >= 0; i--)
                {
                    DataConverter converter = new DataConverter();
                    created_at = converter.GetTime(JsonData[i].created_at);

                    if (!converter.GetTimeError())
                    {
                        if (created_at > EQLastUpdated)
                        {
                            EQLastUpdated = created_at;
                            LoadEQData(JsonData[i],true);

                        }

                    }
                }
                IsEQStatusOK = true ;
            }
            catch
            {
                IsEQStatusOK = false;
            }
            finally
            {
                IsEQRun = false;
            }
            //JsonData.Count();
        }
        private void GetEEWJson()
        {
            try
            {
               
                GetJsonFile NetFile;
                NetFile = new GetJsonFile();
                EEWJsonFile = NetFile.GetJson("https://api.iedred7584.com/eew/json/");

                EEWRoot eew = JsonConvert.DeserializeObject<EEWRoot>(EEWJsonFile);
                Count_Request++;
                long UnixNowTime = eew.AnnouncedTime.UnixTime;
                if (eew.ParseStatus != "Success") return;
                if (UnixNowTime > EEWLatestUNIXTime|| EEW_SerialCountTemp!=eew.Serial)
                {
                    if (UnixNowTime > EEWLatestUNIXTime + 300)
                    {
                        EEW_TweetMode = false ;
                    }
                    EEW_SerialCountTemp = eew.Serial;
                    DataConverter converter = new DataConverter();
                    if (eew.EventID != EEW_EventID)
                    {
                        EEW_EventID = eew.EventID;
                        EEW_TweetMode = false;
                    }
                    bool cancel = false;
                    EEWLatestUNIXTime = UnixNowTime;
                    if (eew.Warn)
                    {
                        EEW_IndexText = "🔴🔴⚠緊急地震速報(警報)⚠🔴🔴";
                    }
                    else
                    {
                        EEW_IndexText = "緊急地震速報(予報) ";
                    }
                    EEW_IndexText += "第 " + eew.Serial.ToString() + " 報";
                    string line = eew.OriginalText;
                    string[] EEWData = line.Split(' ');
                    if (eew.Type.Code==9) EEW_IndexText += "(最終報)";
                    EEW_IndexText += "\n";
                    switch (int.Parse(eew.Status.Code))
                    {
                        case 0:
                            break;
                        case 1:
                            EEW_IndexText += "訓練\n";
                            return;
                        case 10:
                            EEW_IndexText += "キャンセル報\nこの緊急地震速報は取り消されました。\n";
                            cancel = true;
                            break;
                        case 11:
                            EEW_IndexText += "訓練キャンセル\n";
                            return;
                        case 20:
                            EEW_IndexText += "参考もしくはテスト電文\n";
                            return;
                        case 30:
                            EEW_IndexText += "気象庁の配信テスト\n";
                            return;
                    }
                    if (!cancel)
                    {
                        
                        if (eew.Hypocenter.isSea && eew.Hypocenter.Magnitude.Float >= 5.5) EEW_IndexText += "🔴⚠津波発生の恐れがあります。\n";
                        EEW_IndexText += eew.Hypocenter.Name + " 深さ:" + converter.DeepString(eew.Hypocenter.Location.Depth.Int) +
                            " M" + eew.Hypocenter.Magnitude.Float.ToString("F1") + "\n"+
                            "最大震度:"+eew.MaxIntensity.String+"\n"
                            +"発生時刻:"+ converter.GetTime(eew.OriginTime.String).ToString("M/dd H:mm:ss") + "\n";
                       
                        
                        if (eew.Warn)
                        {
                            EEW_IndexText += "以下の地域は強い揺れに警戒してください。\n";
                            for(int i = 0; i < eew.WarnForecast.LocalAreas.Count; i++)
                            {
                                EEW_IndexText+= eew.WarnForecast.LocalAreas[i];
                                if (eew.WarnForecast.LocalAreas.Count - 1 != i) EEW_IndexText += " ";
                            }
                            EEW_IndexText += "\n";

                        }
                        EEW_IndexText += "\n";
                        EEW_IndexText += converter.GetTime(eew.AnnouncedTime.String).ToString("M/dd H:mm:ss発表")+"\n";

                    }
                    if(eew.Hypocenter.Magnitude.Float >= 4 ||converter.ScaleValue(eew.MaxIntensity.To)>=3|| EEW_TweetMode)
                    {

                        IsTweetedEEW = true;
                        string tweetText = EEW_IndexText += "\n#MisakiEQ #地震 #緊急地震速報";
                        Twitter TwiCliant = new Twitter();
                        if (!EEW_TweetMode)
                        {
                            TwiCliant.Tweet(tweetText);
                        }
                        else
                        {
                            TwiCliant.Reply(EEW_LastTweetID, tweetText);
                        }
                        EEW_LastTweetID = TwiCliant.GetLatestTweetID();

                        EEW_TweetMode = true;
                        
                    }
                    if (eew.Warn)
                    {
                        NotificationName = "⚠緊急地震速報(警報)";
                    }
                    else
                    {
                        NotificationName = "緊急地震速報(予報)";
                    }
                    NotificationName += " 第 "+eew.Serial.ToString() + " 報";
                    if (eew.Type.Code == 9) NotificationName += "(最終報)";
                    if (!cancel)
                    {
                        NotificationIndex = eew.Hypocenter.Name + " 深さ:" + converter.DeepString(eew.Hypocenter.Location.Depth.Int) +
                                " M" + eew.Hypocenter.Magnitude.Float.ToString("F1") + "\n" +
                                "最大震度:" + eew.MaxIntensity.String;
                        DisplayingNotificationTime = 2147483647;
                        if (eew.Hypocenter.isSea && eew.Hypocenter.Magnitude.Float > 5) NotificationIndex += " 津波発生の可能性あり";

                    }
                    else
                    {
                        NotificationIndex = "キャンセル報\n緊急地震速報は取り消されました。";
                        IsTweetedEEW = false;
                    }
                    NotificationIcon = 2;
                    IsDisplayNotification = true;
                }
                IsEEWStatusOK = true;

            }
            catch
            {
                IsEEWStatusOK = false;
            }
            finally
            {
                isEEWRun = false;
            }

        }

        private void GetTsunamiJson()
        {
            try
            {
                GetJsonFile NetFile;
                NetFile = new GetJsonFile();
                TsunamiJsonFile = NetFile.GetJson("https://api.p2pquake.net/v2/jma/tsunami?limit=10&order=-1");
                List<TsunamiRoot> tsunami = JsonConvert.DeserializeObject<List<TsunamiRoot>>(TsunamiJsonFile);
                Count_Request++;
                DateTime t;
                for (int i = tsunami.Count - 1; i >= 0; i--)
                {
                    DataConverter converter = new DataConverter();
                    t = converter.GetTime(tsunami[i].created_at);

                    if (!converter.GetTimeError())
                    {
                        if (t > TsunamiLastUpdated)
                        {
                            TsunamiLastUpdated = t;
                            LoadTsunamiData(tsunami[i], true);

                        }

                    }
                }
                IsTsunamiStatusOK = true;
            }
            catch
            {
                IsTsunamiStatusOK = false;
            }
            finally
            {
                IsTsunamiRun = false;
            }
        }
        private void Update_Tick(object sender, EventArgs e)
        {
            //Test_Label.Text = TestString;
            EQ_Index.Text = EQ_IndexText;
            EEW_Index.Text = EEW_IndexText;
            Tsunami_Index.Text = Tsunami_Index_text;
            if (isFailEEWInit) {
                EEWInitOKLabel.Text = "初期化 : 失敗";
            }
            else
            {
                if (IsEEWStatusOK)
                {
                    EEWInitOKLabel.Text = "取得 : 成功";
                }
                else
                {
                    EEWInitOKLabel.Text = "取得 : 失敗";
                }
                
            }
            if (isFailEQInit)
            {
                EQInitOKLabel.Text = "初期化 : 失敗";
            }
            else
            {
                if (IsEQStatusOK)
                {
                    EQInitOKLabel.Text = "取得 : 成功";
                }
                else
                {
                    EQInitOKLabel.Text = "取得 : 失敗";
                }
            }
            if (IsFailTsunamiInit)
            {
                TsunamiInitOKLabel.Text = "初期化 : 失敗";
            }
            else
            {
                if (IsTsunamiStatusOK)
                {
                    TsunamiInitOKLabel.Text = "取得 : 成功";
                }
                else
                {
                    TsunamiInitOKLabel.Text = "取得 : 失敗";
                }
            }
            RequestedCount.Text = "累計リクエスト数 : " + Count_Request.ToString();
            if (IsDisplayNotification)
            {
                IsDisplayNotification = false;
                switch (NotificationIcon)
                {
                    case 1:
                        this.notification.BalloonTipIcon = ToolTipIcon.Info;
                        break;
                    case 2:
                        this.notification.BalloonTipIcon = ToolTipIcon.Warning;
                        break;
                    case 3:
                        this.notification.BalloonTipIcon = ToolTipIcon.Error;
                        break;
                    default:
                        this.notification.BalloonTipIcon = ToolTipIcon.None;
                        break;
                }

                
                this.notification.BalloonTipTitle = NotificationName;
                this.notification.BalloonTipText = NotificationIndex;
                this.notification.ShowBalloonTip(DisplayingNotificationTime); 

            }
            if (isTweet)
            {
                isTweet = false;
                isTweeting = true;
                Thread t = new Thread(new ThreadStart(TweetThread));
                t.Start();
            }
            if (isFailEEWInit)
            {
                
                try
                {
                    Count_Request++;
                    GetJsonFile NetFile;
                    NetFile = new GetJsonFile();
                    EQJsonFile = NetFile.GetJson("https://api.p2pquake.net/v2/jma/quake?limit=10&order=-1");

                    List<EQRoot> JsonData = JsonConvert.DeserializeObject<List<EQRoot>>(EQJsonFile);

                    //TestString = "Time : " + JsonData[0].created_at;
                    DateTime created_at;
                    DataConverter converter = new DataConverter();
                    created_at = converter.GetTime(JsonData[0].created_at);
                    if (!converter.GetTimeError())
                    {
                        EQLastUpdated = created_at;
                        isFailEQInit = false;
                    }
                }
                catch
                {
                    isFailEQInit = true;
                }

            }
            if (isFailEQInit)
            {
                try
                {
                    Count_Request++;
                    GetJsonFile NetFile;
                    NetFile = new GetJsonFile();
                    EEWJsonFile = NetFile.GetJson("https://api.iedred7584.com/eew/json/");
                    EEWRoot eew = JsonConvert.DeserializeObject<EEWRoot>(EEWJsonFile);
                    EEWLatestUNIXTime = eew.AnnouncedTime.UnixTime;
                    if (EEWLatestUNIXTime != 0) isFailEEWInit = false;
                }
                catch
                {
                    isFailEEWInit = true;
                }
            }
        }

        private void Timer_EarthQuake_Tick(object sender, EventArgs e)
        {
            if (!isFailEQInit)
            {
                if (!IsEQRun)
                {
                    IsEQRun = true;
                    Thread t = new Thread(new ThreadStart(GetEQJson));
                    t.Start();
                }
            }
            
        }

        private void Timer_Tsunami_Tick(object sender, EventArgs e)
        {
            if (!IsFailTsunamiInit)
            {
                if (!IsTsunamiRun)
                {
                    IsTsunamiRun = true;
                    Thread t = new Thread(new ThreadStart(GetTsunamiJson));
                    t.Start();
                }
            }
        }

        private void Timer_EEW_Tick(object sender, EventArgs e)
        {
            if (!isFailEEWInit)
            {
                if (!isEEWRun)
                {
                    isEEWRun = true;
                    Thread t = new Thread(new ThreadStart(GetEEWJson));
                    t.Start();
                }
            }
        }
    }
}
