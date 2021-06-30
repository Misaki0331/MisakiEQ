using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Diagnostics;
using MisakiEQ.Mini_Window;
using MisakiEQ.Audio;
using SharpDX.XAudio2;
using SharpDX.Multimedia;
namespace MisakiEQ
{
    
    public partial class Form1 : Form //このフォームは設定画面です。
    {
        
        public static int P2P_MaxRequest = 20;
        private static int IntervalEQ = 5;
        private static int IntervalTsunami = 10;
        private static long Tweet_LastID=0;
        //private static bool IsGettingID = false;
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
        public bool IsApplicationShutDown = false;
        private bool IsFailTsunamiInit = true;
        private bool IsTsunamiStatusOK = true;
        private string TsunamiJsonFile = "";
        private string Tsunami_Index_text = "";
        private bool IsEQProtoGetTweetID = false;
        private long EQProtoGetTweetID = 0;
        private long ReplySetTweetID = 0;
        private bool IsTweetedEEW = false;
        private bool IsKyoshinInited = false;
        private DateTime KyoshinLatest;
        private Form2 EEWNotificationWindow;

        private EEW_Infomation EEWInfomationWindow;
        private bool IsEEWSoundFinished = true;
        Twitter TwiCliant;// = new Twitter();
        private string UserNameID;

        private bool WillDisplayEEWNotification;
        private bool WillDisplayEEWInfomation;
        private string EEWText_Description;
        private string EEWText_Index;
        private string EEWText_Graph;
        private int EEWDisplayTimer = 0;
        Image KyoshinEx_Image=null;
        private bool IsFirstEEW = false;
        private int EEWAreaCount = 0;
        Init InitWindow;
        private index TextBoxWindow=null;
        KyoshinEx KyoshinMonitor = new KyoshinEx();
        private bool IsKyoshinUpdated;
        TwitterAuthWindow AuthWindow=null;
        private TabbedThumbnail customThumbnail;
        Stopwatch KyoshinUpdateTimer;
        int KyoshinTempTimer = 0;
        bool IsKyoshinWorking = false;
        MisakiEQ.Mini_Window.KyoshinEx MiniKyoshinWindow;
        MisakiEQDeskBand wdb;
        Point UserLocation = new Point(224, 258);
        Point UserLocationTemp = new Point(224, 258);

        Sound sound=new Sound();
        MisakiEQSound SEData = new MisakiEQSound();

        
        bool IsDisconnectedHost = true; //ホストが切断時、もしくは自分がホストの時にtrue
        bool IsDiconnectedTmp = true;
        string TweetWatch_Type="";
        bool TweetWatch_CheckBox = false;
        string TweetWatch_Address = "";

        bool CheckedStillRunPC = false;
        string CheckedPCLastError = "";
        struct _EEWDisplayData
        {
            public bool Updated;
            public string Type;
            public string OriginTime;
            public string HypoCenter;
            public string AnnounceTime;
            public int Serial;
            public bool IsFinal;
            public string Magnitude;
            public string Depth;
            public string Index;
            public string MaxScale;
            public string AreaScale;
            public double AreaScaleDetail;
        }
        _EEWDisplayData EEWDisplayData = new _EEWDisplayData();
        
        void SoundInit()
        {
            sound.GetStream(Properties.Resources.SND_Earthquake_Break, ref SEData.SE.Earthquake_Break);
            sound.GetStream(Properties.Resources.SND_Earthquake_Small, ref SEData.SE.Earthquake_Small);
            sound.GetStream(Properties.Resources.SND_Earthquake_Mid, ref SEData.SE.Earthquake_Mid);
            sound.GetStream(Properties.Resources.SND_EEW_Info, ref SEData.SE.EEW_Info);
            sound.GetStream(Properties.Resources.SND_EEW_Warn, ref SEData.SE.EEW_Warn);
            sound.GetStream(Properties.Resources.SND_Tsunami_Alert, ref SEData.SE.Tsunami_Alert);
            sound.GetStream(Properties.Resources.SND_Tsunami_Update, ref SEData.SE.Tsunami_Update);
        }
        public Form1()
        {
            //throw null;
            InitWindow = new Init();
            InitWindow.Location = new Point(0, 0);
            InitWindow.Show();
            InitWindow.SetInfo(0, "コンポーネントを読み込み中です...");
            
            InitializeComponent();
#if !DEBUG
            TestButton.Visible = false;
            TestLabel.Visible = false;
            TestButton.Enabled = false;
#endif
            this.Icon = Properties.Resources.mainico;
            notification.Icon= Properties.Resources.mainico;
            InitWindow.SetInfo(10, "音声ファイル読み込み中です...");
            sound.SetMasterVolume(0);
            SoundInit();
            VersionName.Text = "MisakiEQ For Windows Version 0.2.0\n非公開ベータ版\n\n";
#if ADMIN || DEBUG
            try
            {
                InitWindow.SetInfo(30, "Twitterの情報を取得中です...");
                Twitter TwiCliant = new Twitter();


                //this.Twitter_Author.Text="投稿者 : " + TwiCliant.GetScreenName();
                this.P2P_Interval_EarthQuake.Value = IntervalEQ;
                this.P2P_Interval_Tsunami.Value = IntervalTsunami;
                P2P_Request_Changed();
                wdb = new MisakiEQ.MisakiEQDeskBand();
                if (File.Exists("TwiSession.dat"))
                {
                    try
                    {
                        List<CoreTweet.Status> TwiList = TwiCliant.GetTweetUser(TwiCliant.GetScreenName(), 1);
                        this.UserName.Text = TwiCliant.GetScreenName();
                        Twitter_Author.Text = "投稿 : " + TwiCliant.GetStringName();
                        if (TwiList != null)
                        {
                            if (TwiList.Count > 0) this.Tweet_Index.Text = TwiList[0].Text;
                            if (TwiList.Count > 0) Tweet_LastID = TwiCliant.GetLatestTweetID();
                        }
                        UserNameID = TwiCliant.GetScreenName();
                        TwiCliant.Test();
                    }
                    catch
                    {

                    }
                }
            }
            catch
            {
               // throw new System.Net.WebException("Twitter API認証中にエラーが発生しました。\n接続を確認してください。");
            }
            Point a = new Point(816,540);
            Size = (System.Drawing.Size)a;
            InitWindow.SetInfo(20, "緊急地震速報のウィンドウを作成中です...");
            EEWNotificationWindow = new Form2();
            EEWNotificationWindow.Show();
            EEWInfomationWindow = new EEW_Infomation();
            EEWInfomationWindow.Show();
            EEWNotificationWindow.SetVisible(false);
            EEWInfomationWindow.SetVisible(false);
            
#else
            InitWindow.SetInfo(30, "ビルド設定による機能の制限化を実行中...");
            //Point b = new Point(404, 492);
            //Size = (System.Drawing.Size)b;
            textBox1.Visible=false;
            button1.Visible=false;
            label2.Visible=false;
            Twitter_Author.Visible=false;
            UserName.Visible=false;
            Tweet_Index.Visible=false;
            Twitter_Update.Visible=false;
            Twitter_isReply.Visible=false;
            SettingTab.TabPages.Remove(TwitterSettings);
            P2P_Request_Changed();
#endif

            InitWindow.SetInfo(60, "インターネットから現在の地震情報を取得中です...");
            GetEQHashs(true);

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            Hide();

            this.MaximizeBox = false;
            InitWindow.SetInfo(90, "自動更新の設定中です...");
            Timer_EarthQuake.Start();
            Timer_EEW.Start();
            Timer_Tsunami.Start();
            InitWindow.SetInfo(91, "他PCの監視情報を取得中です...");
            string line;
            int counter = 0;
            try
            {
                System.IO.StreamReader file =
                        new System.IO.StreamReader("TwiWatch.dat");
                while ((line = file.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    counter++;
                    switch (counter)
                    {
                        case 1:
                            TweetWatch_Type = line;

                            break;
                        case 2:

                            if (line == "true")
                            {
                                TweetWatch_CheckBox = true;
                            }
                            else
                            {
                                TweetWatch_CheckBox = false;
                            }
                            break;
                        case 3:
                            TweetWatch_Address = line;
                            break;

                    }
                }
                file.Close();
            }
            catch
            {

            }
            OtherPCWatchingTimer.Start();
            Tweet_isHost.Text = TweetWatch_Type;
            Tweet_checkBox.Checked = TweetWatch_CheckBox;
            Tweet_textbox.Text = TweetWatch_Address;

            MiniKyoshinWindow = new Mini_Window.KyoshinEx();
            MiniKyoshinWindow.UpdateWindow(false);
            InitWindow.SetInfo(95, "強震モニタの情報を取得中です...");
            KyoshinLatest = KyoshinMonitor.GetLatestUpdateTime();
            Console.WriteLine(KyoshinLatest.ToString("強震モニタ:yyyy/MM/dd HH:mm:ss最終更新"));
            KyoshinUpdateTimer = new Stopwatch();
            if (KyoshinLatest != new DateTime(2000, 1, 1, 0, 0, 0))
            {

                IsKyoshinInited = true;
                Timer_KyoshinEx.Start();
                KyoshinUpdateTimer.Reset();
                KyoshinUpdateTimer.Start();
                Timer_AdjustKyoshinEx.Start();
                KyoshinTempTimer = 0;
                Console.WriteLine("強震モニタ起動成功！");
            }
            else
            {
                Console.WriteLine("強震モニタ起動失敗...");
            }

            if (File.Exists("UserConfig.dat"))
            {
                try
                {
                    int cnt = 0;
                    string len;

                    // Read the file and display it line by line.  
                    System.IO.StreamReader file =
                        new System.IO.StreamReader("UserConfig.dat");
                    while ((len = file.ReadLine()) != null)
                    {
                        string[] ConfigString = len.Split('=');
                        if (ConfigString.Length == 2)
                        {
                            switch (ConfigString[0])
                            {
                                case "UserLocation.X":
                                    UserLocation.X = int.Parse(ConfigString[1]);
                                    break;
                                case "UserLocation.Y":
                                    UserLocation.Y = int.Parse(ConfigString[1]);
                                    break;
                            }
                        }

                    }
                    file.Close();
                }
                catch
                {

                }
            }
#if DEBUG
            this.Text = "設定 - MisakiEQ (Debug)";

#endif
            sound.SetMasterVolume(1);
            if (Environment.UserName == "Misaki")
            {
                InitWindow.SetInfo(100, "おかえりなさい " + Environment.UserName + " 様");
            }
            else
            {
                InitWindow.SetInfo(100, "ようこそ " + Environment.UserName + " 様");
            }
            KyoshinImage.Image = KyoshinEx_Image;
            //customThumbnail = new TabbedThumbnail(this.Handle, this.Handle);
            VersionName.Text = Properties.Resources.Version;
            Copyright_Label.Text = Properties.Resources.Misaki_License;
            InitWindow.Done();
            UIUpdate.Start();
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
#if DEBUG || ADMIN
            TweetText = this.textBox1.Text;
#endif
        }

        private void button1_Click(object sender, EventArgs e)
        {
#if DEBUG || ADMIN
            Twitter TwiCliant = new Twitter();
            if (this.Twitter_isReply.Checked)
            {
                TwiCliant.Reply(Tweet_LastID,TweetText);
            }
            else
            {
                TwiCliant.Tweet(TweetText);
            }
            List<CoreTweet.Status> TwiList = TwiCliant.GetTweetUser(TwiCliant.GetScreenName(), 1);
            Twitter_Author.Text = "投稿 : " + TwiCliant.GetStringName();
            this.UserName.Text = TwiCliant.GetScreenName();
            if (TwiList.Count > 0) this.Tweet_Index.Text = TwiList[0].Text;
            Tweet_LastID = TwiCliant.GetLatestTweetID();
            //Tweet_LastID = 
#endif
        }

        private void Twitter_Author_Click(object sender, EventArgs e)
        {
            
        }

        private void Twitter_Update_Click(object sender, EventArgs e)

        {
#if DEBUG || ADMIN
            Twitter TwiCliant = new Twitter();
            List<CoreTweet.Status> TwiList=TwiCliant.GetTweetUser(TwiCliant.GetScreenName(), 1);
            if (TwiList.Count > 0)
            {
                this.UserName.Text = TwiCliant.GetScreenName();
                this.Tweet_Index.Text = TwiList[0].Text;
                Twitter_Author.Text = "投稿 : " + TwiCliant.GetStringName();
                Tweet_LastID = TwiCliant.GetLatestTweetID();
            }
#endif
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsApplicationShutDown)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                Hide();
            }
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
                    InitWindow.SetInfo(65, "地震情報を取得中...");
                    NetFile.GetStartThreadJson("https://api.p2pquake.net/v2/jma/quake?limit=10&order=-1");
                    while (NetFile.GetThreadStillRunning())
                    {
                        InitWindow.Update();
                        Application.DoEvents();
                    }
                    EQJsonFile = NetFile.GetThreadJson();
                    ///EQJsonFile = await NetFile.GetJson("https://api.p2pquake.net/v2/jma/quake?limit=10&order=-1");
                    InitWindow.SetInfo(67, "地震情報を解析中...");
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
                    InitWindow.SetInfo(70, "緊急地震速報を取得中...");
                    NetFile.GetStartThreadJson("https://api.iedred7584.com/eew/json/");
                    while (NetFile.GetThreadStillRunning())
                    {
                        InitWindow.Update();
                        Application.DoEvents();
                    }
                    EEWJsonFile = NetFile.GetThreadJson();
                    InitWindow.SetInfo(72, "緊急地震速報を解析中...");
                }
                DataConverter converter = new DataConverter();
                EEWRoot eew = JsonConvert.DeserializeObject<EEWRoot>(EEWJsonFile);
                EEWDisplayData.Serial = eew.Serial;
                EEWDisplayData.IsFinal = eew.Type.Code == 9;
                EEWDisplayData.HypoCenter = eew.Hypocenter.Name;
                EEWDisplayData.AnnounceTime = converter.GetTime(eew.AnnouncedTime.String).ToString("yyyy/MM/dd HH:mm:ss");
                EEWDisplayData.OriginTime = converter.GetTime(eew.OriginTime.String).ToString("yyyy/MM/dd HH:mm:ss");
                EEWDisplayData.MaxScale = eew.MaxIntensity.To;
                EEWDisplayData.Magnitude = eew.Hypocenter.Magnitude.Float.ToString("F1");
                EEWDisplayData.Index = "---\n";
                EEWDisplayData.Depth = converter.DeepString(eew.Hypocenter.Location.Depth.Int);
                if (eew.Warn)
                {
                    EEWDisplayData.Type = "警報";
                }
                else
                {
                    EEWDisplayData.Type = "予報";
                }
                EEWDisplayData.Updated = true;
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
                    InitWindow.SetInfo(75, "津波情報を取得中...");
                    NetFile.GetStartThreadJson("https://api.p2pquake.net/v2/jma/tsunami?limit=10&order=-1");
                    while (NetFile.GetThreadStillRunning())
                    {
                        InitWindow.Update();
                        Application.DoEvents();
                    }
                    TsunamiJsonFile = NetFile.GetThreadJson();
                    InitWindow.SetInfo(77, "津波情報を解析中...");
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
                    //if (AreaData[0] == null) ;
                    time = converter.GetTime(data.earthquake.time);
                    if (converter.GetTimeError()) return;
                    EQ_IndexText = "震度速報\n"+time.ToString("yyyy年MM月dd日 H時mm分頃") + "\n震度" + converter.ScaleString(data.earthquake.maxScale) + "を観測する地震がありました。\n" +
                        "この地震による" + converter.EQTsunamiTextJP(converter.GetDomesticTsunami(data.earthquake.domesticTsunami)) + "\n観測した地域は以下の通りです。\n\n" + ShindoText;
                    sound.Play(ref SEData.SE.Earthquake_Mid);
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
                    //if (AreaData[0] == null) ;
                    time = converter.GetTime(data.earthquake.time);
                    if (converter.GetTimeError()) return;
                    EQ_IndexText = time.ToString("yyyy年MM月dd日 H時mm分頃") + "\n\n" + data.earthquake.hypocenter.name + "で地震が発生しました。\n" +
                        "地震の規模：M" + data.earthquake.hypocenter.magnitude.ToString("F1") + "\n" +
                        "震源の深さ：" + converter.DeepString(data.earthquake.hypocenter.depth) + "\n" +
                        "最大震度：" + converter.ScaleString(data.earthquake.maxScale) + "\n" +
                        "この地震による" + converter.EQTsunamiTextJP(converter.GetDomesticTsunami(data.earthquake.domesticTsunami))+"\n\n"+ShindoText;
                    JMAEQData_Shingen.Text = data.earthquake.hypocenter.name;
                    JMAEQData_Time.Text = time.ToString("yyyy/MM/dd H:mm頃");
                    JMAEQData_km.Text = converter.DeepString(data.earthquake.hypocenter.depth);
                    JMAEQData_Tsunami.Text = converter.EQTsunamiTextJP(converter.GetDomesticTsunami(data.earthquake.domesticTsunami));
                    JMAEQData_M.Text = data.earthquake.hypocenter.magnitude.ToString("F1");
                    JMAEQData_Max.Text = converter.ASCIIScaleString(data.earthquake.maxScale);
                    string[] result = ShindoText.Split(new char[] { '\n' });
                    
                        sound.Play(ref SEData.SE.Earthquake_Small);
                    
                    
                    JMAEQData_ShindoInfo.Lines = result;
                    //if ((data.earthquake.hypocenter.magnitude >= 0.0||converter.ScaleToValue(data.earthquake.maxScale)>=1)||IsTweetedEEW)
                    if (true)
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
                sound.Play(ref SEData.SE.Tsunami_Update);
            }
          
                
            

            else
            {
                vs[3] = "現在以下の地域に津波予報が発令されています。";
                sound.Play(ref SEData.SE.Tsunami_Alert);
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
                TweetData[0] += "\n#MisakiEQ #地震 #津波 ";
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
#if DEBUG || ADMIN
            try
            {
                /*int pc = 0;
                for(int i=0; TweetData[i] != "" && i < 10; i++)
                {
                    pc++;
                }*/
                long TweetID = 0;

                TwiCliant = new Twitter();
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
                            if(IsDisconnectedHost)TwiCliant.Tweet(TweetData[0]);
                        //}

                    }
                    else
                    {
                        if (ReplySetTweetID != 0)
                        {

                            if (IsDisconnectedHost) TwiCliant.Reply(ReplySetTweetID, TweetData[i]);// + "(" + (i + 1).ToString() + "/" + pc.ToString() + ")");
                            ReplySetTweetID = 0;
                        }
                        else
                        {
                            if (IsDisconnectedHost) TwiCliant.Reply(TweetID, TweetData[i]);// + "(" + (i + 1).ToString() + "/" + pc.ToString() + ")");
                        }
                    }
                    TweetID = TwiCliant.GetLatestTweetID(UserNameID);
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
#endif
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
                    EEWDisplayData.Index = "";
                    if (eew.Warn)
                    {
                        
                        EEW_IndexText = "🔴🔴⚠緊急地震速報(警報)⚠🔴🔴";
                        sound.Stop(ref SEData.SE.EEW_Info);
                        sound.Stop(ref SEData.SE.EEW_Warn);
                        sound.Play(ref SEData.SE.EEW_Warn);
                        if (!IsFirstEEW||EEWAreaCount<eew.WarnForecast.LocalAreas.Count)
                        {
                            EEWAreaCount = eew.WarnForecast.LocalAreas.Count;
                            EEW_SEND();
                            
                            IsFirstEEW = true;
                        }
                        EEWDisplayTimer = 600;

                        EEWText_Index = "";
                        Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                        
                        int len = 0;
                        for (int i = 0; i < eew.WarnForecast.District.Count; i++)
                        {
                            int num = sjisEnc.GetByteCount(eew.WarnForecast.District[i]) + 1;
                            if (len + num > 24)
                            {
                                EEWText_Index += "\n";
                            }
                            else
                            {
                                EEWText_Index += eew.WarnForecast.District[i]+" ";
                            }
                            len += num+1;
                            
                        }
                        string EEWIndex = "";
                        for(int i = 0; i < eew.Forecast.Count; i++)
                        {
                            if (eew.Forecast[i].Warn)
                            {
                                EEWIndex += "[警報]";
                            }
                            else
                            {
                                EEWIndex += "      ";
                            }
                            if (eew.Forecast[i].Arrival.Flag)
                            {
                                EEWIndex += "[到達済と予想]";
                            }
                            else
                            {
                                int hikaku1 = KyoshinLatest.Hour * 3600 + KyoshinLatest.Minute * 60 + KyoshinLatest.Second;
                                DateTime ret;
                                DateTime.TryParseExact(eew.Forecast[i].Arrival.Time, "H:mm:ss", null, DateTimeStyles.AssumeLocal, out ret);
                                int hikaku2 = ret.Hour * 3600 + ret.Minute * 60 + ret.Second;
                                int left = hikaku2 - hikaku1;
                                if (left >= 43200) left -= 86400;
                                if (left <= -43200) left += 86400;
                                if (left < -99) left = -99;
                                if (left > 999) left = 999;
                                EEWIndex += ""+eew.Forecast[i].Arrival.Time.PadLeft(8)+"("+left.ToString().PadLeft(3)+"s)";
                            }
                            EEWIndex += " 震度" +　eew.Forecast[i].Intensity.To.PadLeft(2)+" ";
                            EEWIndex += eew.Forecast[i].Intensity.Name;
                            EEWIndex += "\n";
                        }
                        EEWDisplayData.Index = EEWIndex;
                        EEWDisplayData.Index = EEWText_Index;
                        EEWText_Description = eew.Hypocenter.Name + "で地震 強い揺れに警戒";
                        EEWText_Graph ="規模 : M"+ eew.Hypocenter.Magnitude.Float.ToString("F1") + "\n" +
                            "深さ : " + converter.DeepString(eew.Hypocenter.Location.Depth.Int)+ "\n" +
                            "最大震度:" + eew.MaxIntensity.String + "\n"+
                            converter.GetTime(eew.OriginTime.String).ToString("yyyy/MM/dd\nH:mm:ss発生") + "\n\n"+
                            "第"+ eew.Serial.ToString() + "報";
                        if (eew.Type.Code == 9) EEWText_Graph += "(最終)";
                        EEWText_Graph += "\n\n"+ converter.GetTime(eew.AnnouncedTime.String).ToString("H:mm:ss発表");

                        EEWDisplayData.Type = "警報";
                    }
                    else
                    {
                        sound.Stop(ref SEData.SE.EEW_Info);
                        sound.Play(ref SEData.SE.EEW_Info);
                        EEW_IndexText = "緊急地震速報(予報) ";
                        EEWDisplayData.Type = "予報";
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
                        

                        if (eew.Hypocenter.isSea && eew.Hypocenter.Magnitude.Float >= 6 && eew.Hypocenter.Location.Depth.Int<80) EEW_IndexText += "🔴⚠津波発生の恐れがあります。\n";
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
                        EEW_IndexText += converter.GetTime(eew.AnnouncedTime.String).ToString("M/dd H:mm:ss発表") + "\n";
                        if (SettingKyoshinExDisplayEEW.Checked)
                        {
                            MiniKyoshinWindow.UpdateWindow(false);
                            MiniKyoshinWindow.UpdateWindow(true);
                            MiniKyoshinWindow.Location(new Point(0, 0));
                            MiniKyoshinWindow.Activate();
                        }

                        EEWDisplayData.Serial = eew.Serial;
                        EEWDisplayData.IsFinal = eew.Type.Code == 9;
                        EEWDisplayData.HypoCenter = eew.Hypocenter.Name;
                        EEWDisplayData.AnnounceTime = converter.GetTime(eew.AnnouncedTime.String).ToString("yyyy/MM/dd HH:mm:ss");
                        EEWDisplayData.OriginTime = converter.GetTime(eew.OriginTime.String).ToString("yyyy/MM/dd HH:mm:ss");
                        EEWDisplayData.MaxScale = eew.MaxIntensity.To;
                        EEWDisplayData.Magnitude = eew.Hypocenter.Magnitude.Float.ToString("F1");
                        EEWDisplayData.Depth = converter.DeepString(eew.Hypocenter.Location.Depth.Int);
                        EEWDisplayData.Updated = true;
                    }
                    if (cancel)
                    {
                        if (SettingKyoshinExDisplayEEW.Checked)MiniKyoshinWindow.UpdateWindow(false);
                    }
#if DEBUG || ADMIN
                    if(cancel&& EEW_TweetMode)
                    {
                        IsTweetedEEW = true;
                        
                        Twitter TwiCliant = new Twitter();
                        EEW_IndexText += "\n";
                        EEW_IndexText += converter.GetTime(eew.AnnouncedTime.String).ToString("M/dd H:mm:ss発表") + "\n";
                        string tweetText = EEW_IndexText + "\n#MisakiEQ #地震 #緊急地震速報";

                        TwiCliant.Reply(EEW_LastTweetID, tweetText);
                        EEW_LastTweetID = TwiCliant.GetLatestTweetID(UserNameID);
                        EEW_TweetMode = false;

                    }

//if(eew.Hypocenter.Magnitude.Float >= 4 ||converter.ScaleValue(eew.MaxIntensity.To)>=3|| EEW_TweetMode)
                    if(true)
                    {

                        IsTweetedEEW = true;
                        string tweetText = EEW_IndexText + "\n#MisakiEQ #地震 #緊急地震速報";
                        Twitter TwiCliant = new Twitter();
                        if (IsDisconnectedHost)
                        {
                            if (!EEW_TweetMode)
                            {
                                TwiCliant.Tweet(tweetText);
                            }
                            else
                            {
                                TwiCliant.Reply(EEW_LastTweetID, tweetText);
                            }
                            EEW_LastTweetID = TwiCliant.GetLatestTweetID(UserNameID);

                            EEW_TweetMode = true;
                        }
                        
                    }
#endif
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
                        if (eew.Hypocenter.isSea && eew.Hypocenter.Magnitude.Float >= 6&& eew.Hypocenter.Location.Depth.Int < 80) NotificationIndex += " 津波発生の可能性あり";

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

            if (KyoshinEx_Image != null)
            {

                
                KyoshinImage.Image = KyoshinEx_Image;
                MiniKyoshinWindow.UpdateKyoshin(ref KyoshinEx_Image);
                //if(TaskbarManager.Instance.TabbedThumbnail.IsThumbnailPreviewAdded(customThumbnail))TaskbarManager.Instance.TabbedThumbnail.RemoveThumbnailPreview(customThumbnail);
                //customThumbnail.SetImage((Bitmap)KyoshinEx_Image);
                //TaskbarManager.Instance.TabbedThumbnail.AddThumbnailPreview(customThumbnail);


                /*TabbedThumbnail preview = new TabbedThumbnail(Handle, Handle);
                if(TaskbarManager.Instance.TabbedThumbnail.IsThumbnailPreviewAdded(preview))TaskbarManager.Instance.TabbedThumbnail.RemoveThumbnailPreview(preview);
                TaskbarManager.Instance.TabbedThumbnail.AddThumbnailPreview(preview);

                preview.ClippingRectangle = new Rectangle(new Point(0, 0), new Size(200, 108));
                preview.SetImage((Bitmap)KyoshinEx_Image);
                */
                //KyoshinEx_Image.Dispose();
                KyoshinEx_Image = null;

            }
            
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
            if (!IsKyoshinInited)
            {
                KyoshinLatest = KyoshinMonitor.GetLatestUpdateTime();
                if (KyoshinLatest!=new DateTime(2000,1,1,0,0,0))
                {
                    IsKyoshinInited = true;
                    Timer_KyoshinEx.Start();
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
            if (EEWDisplayData.Updated)
            {
                EEWDisplayData.Updated = false;
                EEWDisplay_Type.Text = EEWDisplayData.Type;
                if (EEWDisplayData.Type == "予報")
                {
                    EEWDisplay_Type.BackColor = Color.Blue;
                    EEWDisplay_Type.ForeColor = Color.White;
                }
                else if(EEWDisplayData.Type=="警報")
                {
                    EEWDisplay_Type.BackColor = Color.Red;
                    EEWDisplay_Type.ForeColor = Color.White;
                }
                else
                {
                    EEWDisplay_Type.BackColor = SystemColors.Control;
                    EEWDisplay_Type.ForeColor = SystemColors.WindowText;
                }
                    EEWDisplay_OriginTime.Text = EEWDisplayData.OriginTime;
                EEWDisplay_AnnounceTime.Text = EEWDisplayData.AnnounceTime;
                EEWDisplay_Serial.Text = EEWDisplayData.Serial.ToString();
                EEWDisplay_IsFinalSerial.Checked = EEWDisplayData.IsFinal;
                EEWDisplay_Hypocenter.Text = EEWDisplayData.HypoCenter;
                if (EEWDisplayData.MaxScale == "不明")
                {
                    EEWDisplay_MaxScale.Text = "-";
                }
                else
                {
                    EEWDisplay_MaxScale.Text = EEWDisplayData.MaxScale;
                }
                EEWDisplay_Magnitude.Text = EEWDisplayData.Magnitude;
                EEWDisplay_Depth.Text = EEWDisplayData.Depth;
                string[] result = EEWDisplayData.Index.Split(new char[] { '\n' });

                EEWDisplay_WarnForecast.Lines = result;

                EEWDisplay_AreaShindo.Text = EEWDisplayData.AreaScale;
                EEWDisplay_AreaShindoLabel.Text = "推定 : "+EEWDisplayData.AreaScaleDetail.ToString("F1");
            }
#if DEBUG || ADMIN
            if (isTweet)
            {
                isTweet = false;
                isTweeting = true;
                Thread t = new Thread(new ThreadStart(TweetThread));
                t.Start();
            }
            if (AuthWindow != null)
            {
                if (AuthWindow.isLastUpdated)
                {
                    AuthWindow.isLastUpdated = false;
                    StatusMassage.Text = AuthWindow.LastError;
                }
                if (AuthWindow.isTwitterUpdate)
                {
                    AuthWindow.isTwitterUpdate = false;
                    Twitter TwiCliant = new Twitter();
                    List<CoreTweet.Status> TwiList = TwiCliant.GetTweetUser(TwiCliant.GetScreenName(), 1);
                    if (TwiList.Count > 0)
                    {
                        this.UserName.Text = TwiCliant.GetScreenName();
                        this.Tweet_Index.Text = TwiList[0].Text;
                        Twitter_Author.Text = "投稿 : " + TwiCliant.GetStringName();
                        Tweet_LastID = TwiCliant.GetLatestTweetID();
                    }

                }
            }
            label21.Text = CheckedPCLastError;
            if (IsDiconnectedTmp != IsDisconnectedHost)
            {
                IsDiconnectedTmp = IsDisconnectedHost;
                if (IsDisconnectedHost)
                {
                    NotificationName = "Host Connection Lost";
                    NotificationIndex = "ホストから切断されました。\n権限はこのPCに移行されました。";
                    DisplayingNotificationTime = 2147483647;
                    NotificationIcon = 2;
                    IsDisplayNotification = true;
                }
                else
                {
                    NotificationName = "Host Connected";
                    NotificationIndex = "ホストに接続されました。\n権限はホストに移行されます。";
                    DisplayingNotificationTime = 2147483647;
                    NotificationIcon = 1;
                    IsDisplayNotification = true;
                }
            }
#endif
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
            if (EEWInfomationWindow == null)
            {
                EEWInfomationWindow = new EEW_Infomation();
                EEWInfomationWindow.Show();
                EEWInfomationWindow.SetVisible(false);
            }
            if (EEWNotificationWindow == null)
            {
                EEWNotificationWindow = new Form2();
                EEWNotificationWindow.Show();
                EEWNotificationWindow.SetVisible(false);
            }
            if (WillDisplayEEWInfomation != EEWInfomationWindow.GetVisible())
            {
                EEWInfomationWindow.SetVisible(WillDisplayEEWInfomation);
            }
            if (WillDisplayEEWNotification != EEWNotificationWindow.GetVisible())
            {
                EEWNotificationWindow.SetVisible(WillDisplayEEWNotification);
            }
            if (EEWText_Index != EEWInfomationWindow.GetIndex())
            {
                EEWInfomationWindow.SetIndex(EEWText_Index);
            }
            if(EEWText_Description != EEWInfomationWindow.GetDescription())
            {
                EEWInfomationWindow.SetDescription(EEWText_Description);
            }
            if (EEWText_Graph != EEWInfomationWindow.GetGraphText())
            {
                EEWInfomationWindow.SetGraphText(EEWText_Graph);
            }
            if (EEWDisplayTimer > 0)
            {
                EEWDisplayTimer--;
            }
            else
            {
                WillDisplayEEWInfomation = false;
                IsFirstEEW = false;
                EEWAreaCount = 0;
            }
            if (TextBoxWindow!=null&&!TextBoxWindow.Visible)
            {
                TextBoxWindow.Close();
                TextBoxWindow = null;
            }
            if (UserLocation != UserLocationTemp)
            {
                UserLocationTemp = UserLocation;
                Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                using (StreamWriter writer = new StreamWriter("UserConfig.dat", false, sjisEnc))
                {
                    // （2）ファイルにテキストを書き込む
                    writer.WriteLine("UserLocation.X="+UserLocation.X.ToString());
                    writer.WriteLine("UserLocation.Y="+UserLocation.Y.ToString());

                } // （3）usingブロックを抜けるときにファイルが閉じられる

                TestLabel.Text = "Point(" + UserLocation.X.ToString() + "," + UserLocation.Y.ToString() + ")";
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

        private void EEW_SEND()
        {
            if (IsEEWSoundFinished)
            {
                if (EEWInfomationWindow.GetVisible())
                {

                    IsEEWSoundFinished = false;
                    Task t = Task.Run(() => EEW_Display(true));
                }
                else
                {


                    IsEEWSoundFinished = false;
                    Task t = Task.Run(() => EEW_Display(false));
                }
            }
        }
        private void EEW_Display(bool sndonly)
        {
            try
            {
                /*private bool WillDisplayEEWNotification;
                private bool WillDisplayEEWInfomation;
                private string EEWText_Description;
                private string EEWText_Index;
                */
#if ADMIN || DEBUG
                System.Media.SoundPlayer EEW_Warning = null;
                System.IO.Stream strm2 = Properties.Resources.Warn;
                EEW_Warning = new System.Media.SoundPlayer(strm2);
                //EEW_Warning.SoundLocation = Directory.GetCurrentDirectory() + "\\data\\SE\\Warn.wav";
                if (!sndonly)
                {
                    System.Media.SoundPlayer EEW_First = null;
                    System.IO.Stream strm = Properties.Resources.First;
                    EEW_First = new System.Media.SoundPlayer(strm);
                    //EEW_First.SoundLocation = Directory.GetCurrentDirectory() + "\\data\\SE\\First.wav";
                    WillDisplayEEWNotification = true;
                    EEW_First.PlaySync();
                    Thread.Sleep(100);
                    WillDisplayEEWNotification = false;
                    Thread.Sleep(100);
                }
                EEWDisplayTimer = 600;
                WillDisplayEEWInfomation = true;
                EEW_Warning.PlaySync();
                EEW_Warning.PlaySync();
#endif
            }
            catch
            {

            }
            finally
            {
                IsEEWSoundFinished = true;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                Hide();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.TwitterLink);
        }

        private void LinkLicense_Click(object sender, EventArgs e)
        {
            if (TextBoxWindow == null)
            {
                TextBoxWindow = new index("ライセンス - License", Properties.Resources.License);
                TextBoxWindow.Show();
            }
        }

        private void LinkAbout_Click(object sender, EventArgs e)
        {
            if (TextBoxWindow == null)
            {
                TextBoxWindow = new index("MisakiEQについて - About MisakiEQ", Properties.Resources.About);
                TextBoxWindow.Show();
            }
        }

        private void LinkDonate_Click(object sender, EventArgs e)
        {
            if (TextBoxWindow == null)
            {
                TextBoxWindow = new index("寄付 - Donate", Properties.Resources.Donate);
                TextBoxWindow.Show();
            }
        }

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            IsApplicationShutDown = true;
            this.Close();
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (GetDataPauseButton.Text == "データ取得の一時停止")
            {
                GetDataPauseButton.Text = "データ取得の再開";
                Timer_EarthQuake.Stop();
                Timer_Tsunami.Stop();
                Timer_EEW.Stop();
                TaskStatus.Text = "停止中";
                TaskStatus.ForeColor = Color.Red;
            }
            else
            {
                GetDataPauseButton.Text = "データ取得の一時停止";
                Timer_EarthQuake.Start();
                Timer_Tsunami.Start();
                Timer_EEW.Start();
                TaskStatus.Text = "準備OK";
                TaskStatus.ForeColor = Color.Black;
            }
        }

        private void ReAuth_Click(object sender, EventArgs e)
        {
            if (AuthWindow!=null&&AuthWindow.Visible == false) AuthWindow = null;
            if (AuthWindow == null)
            {
                AuthWindow = new TwitterAuthWindow();
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            DateTime temp= KyoshinMonitor.GetLatestUpdateTime();
            
            Console.WriteLine(temp.ToString("強震モニタ:yyyy/MM/dd HH:mm:ss最終更新"));
            if (KyoshinLatest != new DateTime(2000, 1, 1, 0, 0, 0))
            {
                Console.WriteLine("強震モニタ更新成功！");
                StatusMassage.Text = "強震モニタ時刻調整成功！";
                KyoshinUpdateTimer.Reset();
                if (!KyoshinUpdateTimer.IsRunning) KyoshinUpdateTimer.Start();
                
                Timer_KyoshinEx.Start();
                KyoshinTempTimer = 0;
                KyoshinLatest = temp;

                Timer_AdjustKyoshinEx.Stop();
                Timer_AdjustKyoshinEx.Start();
            }
            else
            {
                Console.WriteLine("強震モニタ更新失敗...");
                StatusMassage.Text = "強震モニタ時刻調整失敗...";
            }
        }
        void KyoshinUpdate()
        {
            KyoshinEx_Image= KyoshinMonitor.GetFastImage(KyoshinLatest, MisakiEQ.KyoshinEx.KyoshinType.RealTime_Shindo, false, true, true, false);
            IsKyoshinUpdated = KyoshinEx_Image!=null;
            double detail = KyoshinMonitor.GetEEWAreaShindo(UserLocation);
            if (EEWDisplayData.AreaScaleDetail != detail)
            {
                EEWDisplayData.AreaScaleDetail = detail;
                EEWDisplayData.Updated = true;
                DataConverter d = new DataConverter();
                EEWDisplayData.AreaScale=d.KyoshinShindoToString(detail);
            }
            if(KyoshinEx_Image==null) Console.WriteLine("Error!画像を入手できませんでした 理由:"+KyoshinMonitor.GetLastError());
            IsKyoshinWorking = false;
        }
        private void Timer_KyoshinEx_Tick(object sender, EventArgs e)
        {
            
            
            if (KyoshinUpdateTimer.ElapsedMilliseconds / 1000 - KyoshinTempTimer > 0)
            {
                
                KyoshinTempTimer =(int)((long)KyoshinUpdateTimer.ElapsedMilliseconds / 1000);
                KyoshinLatest = KyoshinLatest.AddSeconds(1);
                KyoshinDateTime.Value = KyoshinLatest;
                if (!IsKyoshinWorking)
                {
                    IsKyoshinWorking = true;
                    //KyoshinEx_Image = new Bitmap(352,400);
                    Thread t = new Thread(new ThreadStart(KyoshinUpdate));
                    t.Start();
                }
            }
            
        }

        private void Link_VersionHistory_Click(object sender, EventArgs e)
        {
            if (TextBoxWindow == null)
            {
                TextBoxWindow = new index("更新履歴 - Update History", Properties.Resources.Update_History);
                TextBoxWindow.Show();
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want crash application?\nWarning: This command is test only.\nIf you choose \"Yes\", MisakiEQ has will be doesn't work." + "\n\n注意:このコマンドは試験的機能であり、意図的に強制終了させます。\nこの操作をするとMisakiEQの動作が不安定になります。\n\nそれでも実行しますか?",
            "Question - MisakiEQ",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button2);

            //何が選択されたか調べる
            if (result == DialogResult.Yes)
            {
                MisakiEQ.app.Abort D = new app.Abort();
                D.Application_was_crashed_by_user();
            }
        }

        private void DisplayKyoshinEx_Click(object sender, EventArgs e)
        {
            MiniKyoshinWindow.UpdateWindow(true);
            MiniKyoshinWindow.Location(new Point(0, 0));
            MiniKyoshinWindow.Activate();
        }

        private void notification_MouseClick_1(object sender, MouseEventArgs e)
        {
            Show();

            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;

            Activate();
        }

        private void MisakiEQTwitterLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Resources.MisakiEQTwitterLink);
        }

        private void Timer_AdjustKyoshinEx_Tick(object sender, EventArgs e)
        {
            DateTime temp = KyoshinMonitor.GetLatestUpdateTime();
            temp = temp.AddSeconds((int)-SettingKyoshinExUpdateDelayValue.Value);
            Console.WriteLine(temp.ToString("強震モニタ:yyyy/MM/dd HH:mm:ss最終更新"));
            if (KyoshinLatest != new DateTime(2000, 1, 1, 0, 0, 0))
            {
                Console.WriteLine("強震モニタ更新成功！");
                StatusMassage.Text = "強震モニタ時刻調整成功！";
                KyoshinUpdateTimer.Reset();
                if (!KyoshinUpdateTimer.IsRunning) KyoshinUpdateTimer.Start();

                Timer_KyoshinEx.Start();
                KyoshinTempTimer = 0;
                KyoshinLatest = temp;
            }
            else
            {
                Console.WriteLine("強震モニタ更新失敗...");
                StatusMassage.Text = "強震モニタ時刻調整失敗...";
            }
        }

        private void SettingKyoshinExUpdateTimerValue_ValueChanged(object sender, EventArgs e)
        {
            Timer_AdjustKyoshinEx.Interval = (int)SettingKyoshinExUpdateTimerValue.Value * 1000 * 60;
        }

        private void Tweet_isHost_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tweet_textbox.Enabled = true;
            Tweet_checkBox.Enabled = true;
            Tweet_textbox.Text = "";
            if (Tweet_isHost.Text == "Host")
            {
                Tweet_checkBox.Text = "監視状態を試験停止";
                Tweet_AddressName.Text = "このPCから発信するアドレス";
            }
            else if(Tweet_isHost.Text == "Client")
            {
                Tweet_checkBox.Text = "強制的にツイートを実行";
                Tweet_AddressName.Text = "別のPCから取得するアドレス";
            }
            else
            {
                Tweet_textbox.Enabled = false;
                Tweet_checkBox.Enabled = false;
                Tweet_AddressName.Text = "";
                Tweet_checkBox.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TweetWatch_Type = Tweet_isHost.Text;
            TweetWatch_CheckBox = Tweet_checkBox.Checked;
            TweetWatch_Address = Tweet_textbox.Text;
            try
            {
                Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                using (StreamWriter writer = new StreamWriter("TwiWatch.dat", false, sjisEnc))
                {
                    // （2）ファイルにテキストを書き込む
                    writer.WriteLine(TweetWatch_Type + "\n" + (TweetWatch_CheckBox ? "true" : "false") + "\n" + TweetWatch_Address);

                }
                StatusMassage.Text = "Bot監視の構成ファイルを保存しました。";

            }
            catch
            {
                StatusMassage.Text = "Bot監視の構成ファイルの保存中にエラーが発生しました。";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Tweet_isHost.Text = TweetWatch_Type;
            Tweet_checkBox.Checked = TweetWatch_CheckBox;
            Tweet_textbox.Text = TweetWatch_Address;

        }
        
        private void CheckOtherPC()
        {
            CheckedStillRunPC = true;
            if (TweetWatch_Type == "Host")
            {
                IsDisconnectedHost = true;
                try
                {
                    Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                    using (StreamWriter writer = new StreamWriter(TweetWatch_Address, false, sjisEnc))
                    {
                        // （2）ファイルにテキストを書き込む
                        if (TweetWatch_CheckBox)
                        {
                            writer.WriteLine("STOP");
                        }
                        else
                        {
                            writer.WriteLine("OK");
                        }


                    }
                }
                catch { }
            }
            else if (TweetWatch_Type == "Client")
            {
                try
                {
                    // Read the file and display it line by line.  
                    System.IO.StreamReader file =
                        new System.IO.StreamReader(TweetWatch_Address);

                    string line = file.ReadLine();
                    System.Console.WriteLine(line);
                    if (line == "OK")
                    {
                        IsDisconnectedHost = false;
                        CheckedPCLastError = "接続されています。";
                        if (TweetWatch_CheckBox)
                        {
                            IsDisconnectedHost = true;
                        }
                    }
                    else
                    {
                        IsDisconnectedHost = true;
                        CheckedPCLastError = "切断されています。";
                    }
                    file.Close();

                }
                catch
                {
                    IsDisconnectedHost = true;
                    CheckedPCLastError = "接続エラー(認識不可)";
                }
            }
            else
            {
                IsDisconnectedHost = true;
            }
            CheckedStillRunPC = false;
        }
        private void OtherPCWatchingTimer_Tick(object sender, EventArgs e)
        {
            if (!CheckedStillRunPC)
            {
                Thread t = new Thread(new ThreadStart(CheckOtherPC));
                t.Start();
            }
        }
        
        MisakiEQ.Setting.MapSettingForm MapSet;
        private void TestButton_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SEData.AllDispose();
        }

        private void Setting_AreaSetup_Click(object sender, EventArgs e)
        {
            if (MapSet != null)
            {
                if (MapSet.IsClosed)
                {
                    MapSet.Dispose();
                    MapSet = null;
                }
                else
                {
                    return;
                }
            }
            unsafe
            {
                fixed (Point* PosP = &UserLocation)
                {
                    MapSet = new Setting.MapSettingForm(PosP, Location);
                }
            }
        }
    }
}
