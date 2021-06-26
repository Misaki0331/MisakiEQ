namespace MisakiEQ
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.P2P_Interval_EarthQuake = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.P2P_Request_Max = new System.Windows.Forms.Label();
            this.P2P_Request_Usage = new System.Windows.Forms.Label();
            this.P2P_Conform = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.P2P_Interval_Tsunami = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.P2P_Progress_Usage = new System.Windows.Forms.ProgressBar();
            this.P2P_ErrorMassage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RequestedCount = new System.Windows.Forms.Label();
            this.notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Twitter_Author = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.Tweet_Index = new System.Windows.Forms.Label();
            this.Twitter_Update = new System.Windows.Forms.Button();
            this.Twitter_isReply = new System.Windows.Forms.CheckBox();
            this.Timer_EarthQuake = new System.Windows.Forms.Timer(this.components);
            this.Timer_Tsunami = new System.Windows.Forms.Timer(this.components);
            this.UIUpdate = new System.Windows.Forms.Timer(this.components);
            this.Timer_EEW = new System.Windows.Forms.Timer(this.components);
            this.Test_Label = new System.Windows.Forms.Label();
            this.EarthquakeTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EEW_Index = new System.Windows.Forms.Label();
            this.EEWInitOKLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.EQ_Index = new System.Windows.Forms.Label();
            this.EQInitOKLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TsunamiInitOKLabel = new System.Windows.Forms.Label();
            this.Tsunami_Index = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MisakiEQ_Infomation = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.MisakiEQ_LatestData = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.JMAEQData_M = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.JMAEQData_Time = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.JMAEQData_Tsunami = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.JMAEQData_ShindoInfo = new System.Windows.Forms.TextBox();
            this.JMAEQData_Max = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.JMAEQData_km = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.JMAEQData_Shingen = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.KyoshinEx = new System.Windows.Forms.TabPage();
            this.EEWDisplay_OriginTime = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.EEWDisplay_WarnForecast = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.EEWDisplay_MaxScale = new System.Windows.Forms.TextBox();
            this.EEWDisplay_Depth = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.EEWDisplay_Magnitude = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.EEWDisplay_Hypocenter = new System.Windows.Forms.TextBox();
            this.EEWDisplay_IsFinalSerial = new System.Windows.Forms.CheckBox();
            this.EEWDisplay_Serial = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.EEWDisplay_AnnounceTime = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.EEWDisplay_Type = new System.Windows.Forms.TextBox();
            this.DisplayKyoshinEx = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.KyoshinDateTime = new System.Windows.Forms.DateTimePicker();
            this.KyoshinImage = new System.Windows.Forms.PictureBox();
            this.MisakiEQ_Status = new System.Windows.Forms.TabPage();
            this.MisakiEQ_Settings = new System.Windows.Forms.TabPage();
            this.SettingTab = new System.Windows.Forms.TabControl();
            this.DataUpdateSettings = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SettingKyoshinExDisplayEEW = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SettingKyoshinExUpdateDelayValue = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SettingKyoshinExUpdateTimerValue = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.ComputerSettings = new System.Windows.Forms.TabPage();
            this.CSettingEventlogEEW = new System.Windows.Forms.CheckBox();
            this.CSettingEventlog = new System.Windows.Forms.CheckBox();
            this.TwitterSettings = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Tweet_isHost = new System.Windows.Forms.ComboBox();
            this.Tweet_checkBox = new System.Windows.Forms.CheckBox();
            this.Tweet_AddressName = new System.Windows.Forms.Label();
            this.Tweet_textbox = new System.Windows.Forms.TextBox();
            this.ReAuth = new System.Windows.Forms.Button();
            this.SettingsAbout = new System.Windows.Forms.TabPage();
            this.MisakiEQTwitterLink = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MisakiEQIcon = new System.Windows.Forms.PictureBox();
            this.Copyright_Label = new System.Windows.Forms.Label();
            this.Link_VersionHistory = new System.Windows.Forms.Button();
            this.LinkDonate = new System.Windows.Forms.Button();
            this.LinkAbout = new System.Windows.Forms.Button();
            this.LinkLicense = new System.Windows.Forms.Button();
            this.LinkTwitter = new System.Windows.Forms.Button();
            this.VersionName = new System.Windows.Forms.Label();
            this.SettingClose = new System.Windows.Forms.TabPage();
            this.TestButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GetDataPauseButton = new System.Windows.Forms.Button();
            this.CloseApplication = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.TaskStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TaskProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.TaskProgressText = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusMassage = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer_KyoshinEx = new System.Windows.Forms.Timer(this.components);
            this.Timer_AdjustKyoshinEx = new System.Windows.Forms.Timer(this.components);
            this.OtherPCWatchingTimer = new System.Windows.Forms.Timer(this.components);
            this.TestLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.P2P_Interval_EarthQuake)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P2P_Interval_Tsunami)).BeginInit();
            this.EarthquakeTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.MisakiEQ_Infomation.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.MisakiEQ_LatestData.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.KyoshinEx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KyoshinImage)).BeginInit();
            this.MisakiEQ_Status.SuspendLayout();
            this.MisakiEQ_Settings.SuspendLayout();
            this.SettingTab.SuspendLayout();
            this.DataUpdateSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingKyoshinExUpdateDelayValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingKyoshinExUpdateTimerValue)).BeginInit();
            this.ComputerSettings.SuspendLayout();
            this.TwitterSettings.SuspendLayout();
            this.SettingsAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MisakiEQIcon)).BeginInit();
            this.SettingClose.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "地震情報";
            // 
            // P2P_Interval_EarthQuake
            // 
            this.P2P_Interval_EarthQuake.Location = new System.Drawing.Point(104, 18);
            this.P2P_Interval_EarthQuake.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.P2P_Interval_EarthQuake.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.P2P_Interval_EarthQuake.Name = "P2P_Interval_EarthQuake";
            this.P2P_Interval_EarthQuake.Size = new System.Drawing.Size(35, 19);
            this.P2P_Interval_EarthQuake.TabIndex = 1;
            this.P2P_Interval_EarthQuake.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.P2P_Interval_EarthQuake.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.P2P_Interval_EarthQuake.ValueChanged += new System.EventHandler(this.P2P_Interval_EarthQuake_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.P2P_Request_Max);
            this.groupBox1.Controls.Add(this.P2P_Request_Usage);
            this.groupBox1.Controls.Add(this.P2P_Conform);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.P2P_Interval_Tsunami);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.P2P_Progress_Usage);
            this.groupBox1.Controls.Add(this.P2P_ErrorMassage);
            this.groupBox1.Controls.Add(this.P2P_Interval_EarthQuake);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "P2P取得インターバル設定";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "/";
            // 
            // P2P_Request_Max
            // 
            this.P2P_Request_Max.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.P2P_Request_Max.AutoSize = true;
            this.P2P_Request_Max.Location = new System.Drawing.Point(102, 112);
            this.P2P_Request_Max.Name = "P2P_Request_Max";
            this.P2P_Request_Max.Size = new System.Drawing.Size(17, 12);
            this.P2P_Request_Max.TabIndex = 8;
            this.P2P_Request_Max.Text = "20";
            this.P2P_Request_Max.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // P2P_Request_Usage
            // 
            this.P2P_Request_Usage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.P2P_Request_Usage.AutoSize = true;
            this.P2P_Request_Usage.Location = new System.Drawing.Point(63, 112);
            this.P2P_Request_Usage.Name = "P2P_Request_Usage";
            this.P2P_Request_Usage.Size = new System.Drawing.Size(17, 12);
            this.P2P_Request_Usage.TabIndex = 8;
            this.P2P_Request_Usage.Text = "20";
            this.P2P_Request_Usage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // P2P_Conform
            // 
            this.P2P_Conform.Location = new System.Drawing.Point(251, 152);
            this.P2P_Conform.Name = "P2P_Conform";
            this.P2P_Conform.Size = new System.Drawing.Size(66, 21);
            this.P2P_Conform.TabIndex = 5;
            this.P2P_Conform.Text = "適用";
            this.P2P_Conform.UseVisualStyleBackColor = true;
            this.P2P_Conform.Visible = false;
            this.P2P_Conform.Click += new System.EventHandler(this.P2P_Conform_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "秒/回";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "秒/回";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "使用状況";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // P2P_Interval_Tsunami
            // 
            this.P2P_Interval_Tsunami.Location = new System.Drawing.Point(104, 40);
            this.P2P_Interval_Tsunami.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.P2P_Interval_Tsunami.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.P2P_Interval_Tsunami.Name = "P2P_Interval_Tsunami";
            this.P2P_Interval_Tsunami.Size = new System.Drawing.Size(35, 19);
            this.P2P_Interval_Tsunami.TabIndex = 5;
            this.P2P_Interval_Tsunami.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.P2P_Interval_Tsunami.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.P2P_Interval_Tsunami.ValueChanged += new System.EventHandler(this.P2P_Interval_Tsunami_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "津波情報";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // P2P_Progress_Usage
            // 
            this.P2P_Progress_Usage.Location = new System.Drawing.Point(0, 127);
            this.P2P_Progress_Usage.MarqueeAnimationSpeed = 0;
            this.P2P_Progress_Usage.Name = "P2P_Progress_Usage";
            this.P2P_Progress_Usage.Size = new System.Drawing.Size(316, 25);
            this.P2P_Progress_Usage.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.P2P_Progress_Usage.TabIndex = 3;
            this.P2P_Progress_Usage.Value = 99;
            // 
            // P2P_ErrorMassage
            // 
            this.P2P_ErrorMassage.AutoSize = true;
            this.P2P_ErrorMassage.Location = new System.Drawing.Point(8, 152);
            this.P2P_ErrorMassage.Name = "P2P_ErrorMassage";
            this.P2P_ErrorMassage.Size = new System.Drawing.Size(279, 12);
            this.P2P_ErrorMassage.TabIndex = 2;
            this.P2P_ErrorMassage.Text = "注意：毎分 20 リクエスト以上は指定することはできません。";
            this.P2P_ErrorMassage.Click += new System.EventHandler(this.P2P_ErrorMassage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "累計稼働時間";
            this.label4.Visible = false;
            // 
            // RequestedCount
            // 
            this.RequestedCount.AutoSize = true;
            this.RequestedCount.Location = new System.Drawing.Point(3, 4);
            this.RequestedCount.Name = "RequestedCount";
            this.RequestedCount.Size = new System.Drawing.Size(82, 12);
            this.RequestedCount.TabIndex = 4;
            this.RequestedCount.Text = "累計リクエスト数";
            // 
            // notification
            // 
            this.notification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notification.BalloonTipText = "1";
            this.notification.BalloonTipTitle = "2";
            this.notification.Text = "MisakiEQ";
            this.notification.Visible = true;
            this.notification.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notification_MouseClick_1);
            this.notification.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 19);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "ツイート";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "ツイートテスト(beta)";
            // 
            // Twitter_Author
            // 
            this.Twitter_Author.AutoSize = true;
            this.Twitter_Author.Location = new System.Drawing.Point(109, 7);
            this.Twitter_Author.Name = "Twitter_Author";
            this.Twitter_Author.Size = new System.Drawing.Size(59, 12);
            this.Twitter_Author.TabIndex = 8;
            this.Twitter_Author.Text = "投稿 : Null";
            this.Twitter_Author.Click += new System.EventHandler(this.Twitter_Author_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(6, 64);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(58, 12);
            this.UserName.TabIndex = 9;
            this.UserName.Text = "UserName";
            // 
            // Tweet_Index
            // 
            this.Tweet_Index.AutoSize = true;
            this.Tweet_Index.Location = new System.Drawing.Point(6, 76);
            this.Tweet_Index.Name = "Tweet_Index";
            this.Tweet_Index.Size = new System.Drawing.Size(63, 12);
            this.Tweet_Index.TabIndex = 10;
            this.Tweet_Index.Text = "TweetIndex";
            // 
            // Twitter_Update
            // 
            this.Twitter_Update.Location = new System.Drawing.Point(8, 42);
            this.Twitter_Update.Name = "Twitter_Update";
            this.Twitter_Update.Size = new System.Drawing.Size(57, 23);
            this.Twitter_Update.TabIndex = 11;
            this.Twitter_Update.Text = "更新";
            this.Twitter_Update.UseVisualStyleBackColor = true;
            this.Twitter_Update.Click += new System.EventHandler(this.Twitter_Update_Click);
            // 
            // Twitter_isReply
            // 
            this.Twitter_isReply.AutoSize = true;
            this.Twitter_isReply.Location = new System.Drawing.Point(259, 3);
            this.Twitter_isReply.Name = "Twitter_isReply";
            this.Twitter_isReply.Size = new System.Drawing.Size(114, 16);
            this.Twitter_isReply.TabIndex = 12;
            this.Twitter_isReply.Text = "前ツイートにリプライ";
            this.Twitter_isReply.UseVisualStyleBackColor = true;
            this.Twitter_isReply.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Timer_EarthQuake
            // 
            this.Timer_EarthQuake.Interval = 5000;
            this.Timer_EarthQuake.Tick += new System.EventHandler(this.Timer_EarthQuake_Tick);
            // 
            // Timer_Tsunami
            // 
            this.Timer_Tsunami.Interval = 10000;
            this.Timer_Tsunami.Tick += new System.EventHandler(this.Timer_Tsunami_Tick);
            // 
            // UIUpdate
            // 
            this.UIUpdate.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // Timer_EEW
            // 
            this.Timer_EEW.Interval = 1000;
            this.Timer_EEW.Tick += new System.EventHandler(this.Timer_EEW_Tick);
            // 
            // Test_Label
            // 
            this.Test_Label.AutoSize = true;
            this.Test_Label.Location = new System.Drawing.Point(403, 154);
            this.Test_Label.Name = "Test_Label";
            this.Test_Label.Size = new System.Drawing.Size(0, 12);
            this.Test_Label.TabIndex = 13;
            // 
            // EarthquakeTab
            // 
            this.EarthquakeTab.Controls.Add(this.tabPage1);
            this.EarthquakeTab.Controls.Add(this.tabPage2);
            this.EarthquakeTab.Controls.Add(this.tabPage3);
            this.EarthquakeTab.Location = new System.Drawing.Point(3, 6);
            this.EarthquakeTab.Name = "EarthquakeTab";
            this.EarthquakeTab.SelectedIndex = 0;
            this.EarthquakeTab.Size = new System.Drawing.Size(334, 220);
            this.EarthquakeTab.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EEW_Index);
            this.tabPage1.Controls.Add(this.EEWInitOKLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(326, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "緊急地震速報";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // EEW_Index
            // 
            this.EEW_Index.AutoSize = true;
            this.EEW_Index.Location = new System.Drawing.Point(3, 3);
            this.EEW_Index.Name = "EEW_Index";
            this.EEW_Index.Size = new System.Drawing.Size(35, 12);
            this.EEW_Index.TabIndex = 17;
            this.EEW_Index.Text = "label5";
            // 
            // EEWInitOKLabel
            // 
            this.EEWInitOKLabel.AutoSize = true;
            this.EEWInitOKLabel.Location = new System.Drawing.Point(3, 179);
            this.EEWInitOKLabel.Name = "EEWInitOKLabel";
            this.EEWInitOKLabel.Size = new System.Drawing.Size(87, 12);
            this.EEWInitOKLabel.TabIndex = 16;
            this.EEWInitOKLabel.Text = "初期化 : 未実施";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.EQ_Index);
            this.tabPage2.Controls.Add(this.EQInitOKLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(326, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "地震情報";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // EQ_Index
            // 
            this.EQ_Index.AutoSize = true;
            this.EQ_Index.Location = new System.Drawing.Point(3, 3);
            this.EQ_Index.Name = "EQ_Index";
            this.EQ_Index.Size = new System.Drawing.Size(35, 12);
            this.EQ_Index.TabIndex = 18;
            this.EQ_Index.Text = "label5";
            // 
            // EQInitOKLabel
            // 
            this.EQInitOKLabel.AutoSize = true;
            this.EQInitOKLabel.Location = new System.Drawing.Point(3, 179);
            this.EQInitOKLabel.Name = "EQInitOKLabel";
            this.EQInitOKLabel.Size = new System.Drawing.Size(87, 12);
            this.EQInitOKLabel.TabIndex = 17;
            this.EQInitOKLabel.Text = "初期化 : 未実施";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TsunamiInitOKLabel);
            this.tabPage3.Controls.Add(this.Tsunami_Index);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(326, 194);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "津波情報";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TsunamiInitOKLabel
            // 
            this.TsunamiInitOKLabel.AutoSize = true;
            this.TsunamiInitOKLabel.Location = new System.Drawing.Point(3, 179);
            this.TsunamiInitOKLabel.Name = "TsunamiInitOKLabel";
            this.TsunamiInitOKLabel.Size = new System.Drawing.Size(35, 12);
            this.TsunamiInitOKLabel.TabIndex = 1;
            this.TsunamiInitOKLabel.Text = "label9";
            // 
            // Tsunami_Index
            // 
            this.Tsunami_Index.AutoSize = true;
            this.Tsunami_Index.Location = new System.Drawing.Point(3, 3);
            this.Tsunami_Index.Name = "Tsunami_Index";
            this.Tsunami_Index.Size = new System.Drawing.Size(35, 12);
            this.Tsunami_Index.TabIndex = 0;
            this.Tsunami_Index.Text = "label5";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MisakiEQ_Infomation);
            this.tabControl1.Controls.Add(this.MisakiEQ_Status);
            this.tabControl1.Controls.Add(this.MisakiEQ_Settings);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 456);
            this.tabControl1.TabIndex = 15;
            // 
            // MisakiEQ_Infomation
            // 
            this.MisakiEQ_Infomation.Controls.Add(this.tabControl3);
            this.MisakiEQ_Infomation.Location = new System.Drawing.Point(4, 22);
            this.MisakiEQ_Infomation.Name = "MisakiEQ_Infomation";
            this.MisakiEQ_Infomation.Padding = new System.Windows.Forms.Padding(3);
            this.MisakiEQ_Infomation.Size = new System.Drawing.Size(792, 430);
            this.MisakiEQ_Infomation.TabIndex = 0;
            this.MisakiEQ_Infomation.Text = "地震データ";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.MisakiEQ_LatestData);
            this.tabControl3.Controls.Add(this.tabPage4);
            this.tabControl3.Controls.Add(this.KyoshinEx);
            this.tabControl3.Location = new System.Drawing.Point(-4, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(800, 434);
            this.tabControl3.TabIndex = 0;
            // 
            // MisakiEQ_LatestData
            // 
            this.MisakiEQ_LatestData.Controls.Add(this.EarthquakeTab);
            this.MisakiEQ_LatestData.Location = new System.Drawing.Point(4, 22);
            this.MisakiEQ_LatestData.Name = "MisakiEQ_LatestData";
            this.MisakiEQ_LatestData.Padding = new System.Windows.Forms.Padding(3);
            this.MisakiEQ_LatestData.Size = new System.Drawing.Size(792, 408);
            this.MisakiEQ_LatestData.TabIndex = 0;
            this.MisakiEQ_LatestData.Text = "受信データ(仮)";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.JMAEQData_M);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.JMAEQData_Time);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.JMAEQData_Tsunami);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.JMAEQData_ShindoInfo);
            this.tabPage4.Controls.Add(this.JMAEQData_Max);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.JMAEQData_km);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.JMAEQData_Shingen);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 408);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "地震情報";
            // 
            // JMAEQData_M
            // 
            this.JMAEQData_M.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JMAEQData_M.Location = new System.Drawing.Point(142, 83);
            this.JMAEQData_M.Name = "JMAEQData_M";
            this.JMAEQData_M.ReadOnly = true;
            this.JMAEQData_M.Size = new System.Drawing.Size(42, 31);
            this.JMAEQData_M.TabIndex = 3;
            this.JMAEQData_M.Text = "-.-";
            this.JMAEQData_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label28.Location = new System.Drawing.Point(118, 85);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 24);
            this.label28.TabIndex = 14;
            this.label28.Text = "M";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(59, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 13;
            this.label20.Text = "発生時刻";
            // 
            // JMAEQData_Time
            // 
            this.JMAEQData_Time.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JMAEQData_Time.Location = new System.Drawing.Point(118, 15);
            this.JMAEQData_Time.Name = "JMAEQData_Time";
            this.JMAEQData_Time.ReadOnly = true;
            this.JMAEQData_Time.Size = new System.Drawing.Size(231, 31);
            this.JMAEQData_Time.TabIndex = 12;
            this.JMAEQData_Time.Text = "20xx/xx/xx xx:xx頃";
            this.JMAEQData_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(36, 225);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 11;
            this.label19.Text = "震度情報";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // JMAEQData_Tsunami
            // 
            this.JMAEQData_Tsunami.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JMAEQData_Tsunami.Location = new System.Drawing.Point(38, 177);
            this.JMAEQData_Tsunami.Name = "JMAEQData_Tsunami";
            this.JMAEQData_Tsunami.ReadOnly = true;
            this.JMAEQData_Tsunami.Size = new System.Drawing.Size(311, 31);
            this.JMAEQData_Tsunami.TabIndex = 10;
            this.JMAEQData_Tsunami.Text = "情報を取得できませんでした。";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(36, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 9;
            this.label18.Text = "津波情報";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // JMAEQData_ShindoInfo
            // 
            this.JMAEQData_ShindoInfo.Location = new System.Drawing.Point(38, 240);
            this.JMAEQData_ShindoInfo.Multiline = true;
            this.JMAEQData_ShindoInfo.Name = "JMAEQData_ShindoInfo";
            this.JMAEQData_ShindoInfo.ReadOnly = true;
            this.JMAEQData_ShindoInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.JMAEQData_ShindoInfo.Size = new System.Drawing.Size(311, 162);
            this.JMAEQData_ShindoInfo.TabIndex = 8;
            this.JMAEQData_ShindoInfo.Text = "準備中";
            // 
            // JMAEQData_Max
            // 
            this.JMAEQData_Max.Font = new System.Drawing.Font("MS UI Gothic", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JMAEQData_Max.Location = new System.Drawing.Point(285, 86);
            this.JMAEQData_Max.Name = "JMAEQData_Max";
            this.JMAEQData_Max.ReadOnly = true;
            this.JMAEQData_Max.Size = new System.Drawing.Size(64, 63);
            this.JMAEQData_Max.TabIndex = 7;
            this.JMAEQData_Max.Text = "-";
            this.JMAEQData_Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(231, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 6;
            this.label17.Text = "最大震度";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(53, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 5;
            this.label16.Text = "震源の深さ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // JMAEQData_km
            // 
            this.JMAEQData_km.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JMAEQData_km.Location = new System.Drawing.Point(118, 118);
            this.JMAEQData_km.Name = "JMAEQData_km";
            this.JMAEQData_km.ReadOnly = true;
            this.JMAEQData_km.Size = new System.Drawing.Size(82, 31);
            this.JMAEQData_km.TabIndex = 4;
            this.JMAEQData_km.Text = "N/A";
            this.JMAEQData_km.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 24);
            this.label15.TabIndex = 2;
            this.label15.Text = "地震の規模\r\n(マグニチュード)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // JMAEQData_Shingen
            // 
            this.JMAEQData_Shingen.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.JMAEQData_Shingen.Location = new System.Drawing.Point(118, 49);
            this.JMAEQData_Shingen.Name = "JMAEQData_Shingen";
            this.JMAEQData_Shingen.ReadOnly = true;
            this.JMAEQData_Shingen.Size = new System.Drawing.Size(231, 31);
            this.JMAEQData_Shingen.TabIndex = 1;
            this.JMAEQData_Shingen.Text = "N/A";
            this.JMAEQData_Shingen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(71, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "震源地";
            // 
            // KyoshinEx
            // 
            this.KyoshinEx.BackColor = System.Drawing.SystemColors.Control;
            this.KyoshinEx.Controls.Add(this.EEWDisplay_OriginTime);
            this.KyoshinEx.Controls.Add(this.label33);
            this.KyoshinEx.Controls.Add(this.label32);
            this.KyoshinEx.Controls.Add(this.EEWDisplay_WarnForecast);
            this.KyoshinEx.Controls.Add(this.label31);
            this.KyoshinEx.Controls.Add(this.EEWDisplay_MaxScale);
            this.KyoshinEx.Controls.Add(this.EEWDisplay_Depth);
            this.KyoshinEx.Controls.Add(this.label30);
            this.KyoshinEx.Controls.Add(this.EEWDisplay_Magnitude);
            this.KyoshinEx.Controls.Add(this.label29);
            this.KyoshinEx.Controls.Add(this.label27);
            this.KyoshinEx.Controls.Add(this.label26);
            this.KyoshinEx.Controls.Add(this.EEWDisplay_Hypocenter);
            this.KyoshinEx.Controls.Add(this.EEWDisplay_IsFinalSerial);
            this.KyoshinEx.Controls.Add(this.EEWDisplay_Serial);
            this.KyoshinEx.Controls.Add(this.label25);
            this.KyoshinEx.Controls.Add(this.label24);
            this.KyoshinEx.Controls.Add(this.EEWDisplay_AnnounceTime);
            this.KyoshinEx.Controls.Add(this.label23);
            this.KyoshinEx.Controls.Add(this.label22);
            this.KyoshinEx.Controls.Add(this.EEWDisplay_Type);
            this.KyoshinEx.Controls.Add(this.DisplayKyoshinEx);
            this.KyoshinEx.Controls.Add(this.button2);
            this.KyoshinEx.Controls.Add(this.KyoshinDateTime);
            this.KyoshinEx.Controls.Add(this.KyoshinImage);
            this.KyoshinEx.Location = new System.Drawing.Point(4, 22);
            this.KyoshinEx.Name = "KyoshinEx";
            this.KyoshinEx.Padding = new System.Windows.Forms.Padding(3);
            this.KyoshinEx.Size = new System.Drawing.Size(792, 408);
            this.KyoshinEx.TabIndex = 1;
            this.KyoshinEx.Text = "強震モニタ";
            // 
            // EEWDisplay_OriginTime
            // 
            this.EEWDisplay_OriginTime.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EEWDisplay_OriginTime.Location = new System.Drawing.Point(73, 80);
            this.EEWDisplay_OriginTime.Name = "EEWDisplay_OriginTime";
            this.EEWDisplay_OriginTime.ReadOnly = true;
            this.EEWDisplay_OriginTime.Size = new System.Drawing.Size(184, 26);
            this.EEWDisplay_OriginTime.TabIndex = 24;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(18, 88);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(53, 12);
            this.label33.TabIndex = 23;
            this.label33.Text = "発生時刻";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(8, 238);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(201, 12);
            this.label32.TabIndex = 22;
            this.label32.Text = "警報対象地域(予報では表示されません)";
            // 
            // EEWDisplay_WarnForecast
            // 
            this.EEWDisplay_WarnForecast.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EEWDisplay_WarnForecast.Location = new System.Drawing.Point(10, 253);
            this.EEWDisplay_WarnForecast.Multiline = true;
            this.EEWDisplay_WarnForecast.Name = "EEWDisplay_WarnForecast";
            this.EEWDisplay_WarnForecast.ReadOnly = true;
            this.EEWDisplay_WarnForecast.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EEWDisplay_WarnForecast.Size = new System.Drawing.Size(424, 149);
            this.EEWDisplay_WarnForecast.TabIndex = 21;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(320, 153);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 12);
            this.label31.TabIndex = 20;
            this.label31.Text = "最大震度";
            // 
            // EEWDisplay_MaxScale
            // 
            this.EEWDisplay_MaxScale.Font = new System.Drawing.Font("ＭＳ ゴシック", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EEWDisplay_MaxScale.Location = new System.Drawing.Point(377, 110);
            this.EEWDisplay_MaxScale.Name = "EEWDisplay_MaxScale";
            this.EEWDisplay_MaxScale.ReadOnly = true;
            this.EEWDisplay_MaxScale.Size = new System.Drawing.Size(57, 60);
            this.EEWDisplay_MaxScale.TabIndex = 19;
            this.EEWDisplay_MaxScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EEWDisplay_Depth
            // 
            this.EEWDisplay_Depth.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EEWDisplay_Depth.Location = new System.Drawing.Point(73, 190);
            this.EEWDisplay_Depth.Name = "EEWDisplay_Depth";
            this.EEWDisplay_Depth.ReadOnly = true;
            this.EEWDisplay_Depth.Size = new System.Drawing.Size(95, 34);
            this.EEWDisplay_Depth.TabIndex = 18;
            this.EEWDisplay_Depth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(8, 206);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 12);
            this.label30.TabIndex = 17;
            this.label30.Text = "震源の深さ";
            // 
            // EEWDisplay_Magnitude
            // 
            this.EEWDisplay_Magnitude.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EEWDisplay_Magnitude.Location = new System.Drawing.Point(101, 150);
            this.EEWDisplay_Magnitude.Name = "EEWDisplay_Magnitude";
            this.EEWDisplay_Magnitude.ReadOnly = true;
            this.EEWDisplay_Magnitude.Size = new System.Drawing.Size(41, 34);
            this.EEWDisplay_Magnitude.TabIndex = 15;
            this.EEWDisplay_Magnitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label29.Location = new System.Drawing.Point(74, 153);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(33, 27);
            this.label29.TabIndex = 16;
            this.label29.Text = "M";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(8, 166);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 12);
            this.label27.TabIndex = 14;
            this.label27.Text = "地震の規模";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(30, 126);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 12);
            this.label26.TabIndex = 13;
            this.label26.Text = "震源地";
            // 
            // EEWDisplay_Hypocenter
            // 
            this.EEWDisplay_Hypocenter.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EEWDisplay_Hypocenter.Location = new System.Drawing.Point(73, 110);
            this.EEWDisplay_Hypocenter.Name = "EEWDisplay_Hypocenter";
            this.EEWDisplay_Hypocenter.ReadOnly = true;
            this.EEWDisplay_Hypocenter.Size = new System.Drawing.Size(291, 34);
            this.EEWDisplay_Hypocenter.TabIndex = 12;
            // 
            // EEWDisplay_IsFinalSerial
            // 
            this.EEWDisplay_IsFinalSerial.AutoSize = true;
            this.EEWDisplay_IsFinalSerial.Enabled = false;
            this.EEWDisplay_IsFinalSerial.Location = new System.Drawing.Point(356, 79);
            this.EEWDisplay_IsFinalSerial.Name = "EEWDisplay_IsFinalSerial";
            this.EEWDisplay_IsFinalSerial.Size = new System.Drawing.Size(60, 16);
            this.EEWDisplay_IsFinalSerial.TabIndex = 11;
            this.EEWDisplay_IsFinalSerial.Text = "最終報";
            this.EEWDisplay_IsFinalSerial.UseVisualStyleBackColor = true;
            // 
            // EEWDisplay_Serial
            // 
            this.EEWDisplay_Serial.Location = new System.Drawing.Point(322, 77);
            this.EEWDisplay_Serial.Name = "EEWDisplay_Serial";
            this.EEWDisplay_Serial.ReadOnly = true;
            this.EEWDisplay_Serial.Size = new System.Drawing.Size(28, 19);
            this.EEWDisplay_Serial.TabIndex = 10;
            this.EEWDisplay_Serial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(263, 80);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 12);
            this.label25.TabIndex = 9;
            this.label25.Text = "情報番号";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 31);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(111, 12);
            this.label24.TabIndex = 8;
            this.label24.Text = "緊急地震速報の状態";
            // 
            // EEWDisplay_AnnounceTime
            // 
            this.EEWDisplay_AnnounceTime.Location = new System.Drawing.Point(322, 56);
            this.EEWDisplay_AnnounceTime.Name = "EEWDisplay_AnnounceTime";
            this.EEWDisplay_AnnounceTime.ReadOnly = true;
            this.EEWDisplay_AnnounceTime.Size = new System.Drawing.Size(112, 19);
            this.EEWDisplay_AnnounceTime.TabIndex = 7;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(263, 59);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 6;
            this.label23.Text = "発表時刻";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 56);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 12);
            this.label22.TabIndex = 5;
            this.label22.Text = "情報の種類";
            // 
            // EEWDisplay_Type
            // 
            this.EEWDisplay_Type.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EEWDisplay_Type.Location = new System.Drawing.Point(73, 43);
            this.EEWDisplay_Type.Name = "EEWDisplay_Type";
            this.EEWDisplay_Type.ReadOnly = true;
            this.EEWDisplay_Type.Size = new System.Drawing.Size(114, 34);
            this.EEWDisplay_Type.TabIndex = 4;
            this.EEWDisplay_Type.Text = "発表なし";
            // 
            // DisplayKyoshinEx
            // 
            this.DisplayKyoshinEx.Location = new System.Drawing.Point(277, 31);
            this.DisplayKyoshinEx.Name = "DisplayKyoshinEx";
            this.DisplayKyoshinEx.Size = new System.Drawing.Size(91, 19);
            this.DisplayKyoshinEx.TabIndex = 3;
            this.DisplayKyoshinEx.Text = "強震モニタ表示";
            this.DisplayKyoshinEx.UseVisualStyleBackColor = true;
            this.DisplayKyoshinEx.Click += new System.EventHandler(this.DisplayKyoshinEx_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 19);
            this.button2.TabIndex = 2;
            this.button2.Text = "時刻調整";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // KyoshinDateTime
            // 
            this.KyoshinDateTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.KyoshinDateTime.Enabled = false;
            this.KyoshinDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.KyoshinDateTime.Location = new System.Drawing.Point(277, 6);
            this.KyoshinDateTime.Name = "KyoshinDateTime";
            this.KyoshinDateTime.Size = new System.Drawing.Size(157, 19);
            this.KyoshinDateTime.TabIndex = 1;
            // 
            // KyoshinImage
            // 
            this.KyoshinImage.Location = new System.Drawing.Point(440, 3);
            this.KyoshinImage.Name = "KyoshinImage";
            this.KyoshinImage.Size = new System.Drawing.Size(352, 400);
            this.KyoshinImage.TabIndex = 0;
            this.KyoshinImage.TabStop = false;
            // 
            // MisakiEQ_Status
            // 
            this.MisakiEQ_Status.Controls.Add(this.RequestedCount);
            this.MisakiEQ_Status.Controls.Add(this.label4);
            this.MisakiEQ_Status.Location = new System.Drawing.Point(4, 22);
            this.MisakiEQ_Status.Name = "MisakiEQ_Status";
            this.MisakiEQ_Status.Padding = new System.Windows.Forms.Padding(3);
            this.MisakiEQ_Status.Size = new System.Drawing.Size(792, 430);
            this.MisakiEQ_Status.TabIndex = 1;
            this.MisakiEQ_Status.Text = "ステータス";
            // 
            // MisakiEQ_Settings
            // 
            this.MisakiEQ_Settings.Controls.Add(this.SettingTab);
            this.MisakiEQ_Settings.Location = new System.Drawing.Point(4, 22);
            this.MisakiEQ_Settings.Name = "MisakiEQ_Settings";
            this.MisakiEQ_Settings.Size = new System.Drawing.Size(792, 430);
            this.MisakiEQ_Settings.TabIndex = 2;
            this.MisakiEQ_Settings.Text = "設定";
            // 
            // SettingTab
            // 
            this.SettingTab.Controls.Add(this.DataUpdateSettings);
            this.SettingTab.Controls.Add(this.ComputerSettings);
            this.SettingTab.Controls.Add(this.TwitterSettings);
            this.SettingTab.Controls.Add(this.SettingsAbout);
            this.SettingTab.Controls.Add(this.SettingClose);
            this.SettingTab.Location = new System.Drawing.Point(0, 0);
            this.SettingTab.Name = "SettingTab";
            this.SettingTab.SelectedIndex = 0;
            this.SettingTab.Size = new System.Drawing.Size(796, 434);
            this.SettingTab.TabIndex = 0;
            // 
            // DataUpdateSettings
            // 
            this.DataUpdateSettings.Controls.Add(this.groupBox2);
            this.DataUpdateSettings.Controls.Add(this.groupBox1);
            this.DataUpdateSettings.Location = new System.Drawing.Point(4, 22);
            this.DataUpdateSettings.Name = "DataUpdateSettings";
            this.DataUpdateSettings.Padding = new System.Windows.Forms.Padding(3);
            this.DataUpdateSettings.Size = new System.Drawing.Size(788, 408);
            this.DataUpdateSettings.TabIndex = 0;
            this.DataUpdateSettings.Text = "データ更新頻度";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SettingKyoshinExDisplayEEW);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.SettingKyoshinExUpdateDelayValue);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.SettingKyoshinExUpdateTimerValue);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(329, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "強震モニタ設定";
            // 
            // SettingKyoshinExDisplayEEW
            // 
            this.SettingKyoshinExDisplayEEW.AutoSize = true;
            this.SettingKyoshinExDisplayEEW.Checked = true;
            this.SettingKyoshinExDisplayEEW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SettingKyoshinExDisplayEEW.Location = new System.Drawing.Point(6, 72);
            this.SettingKyoshinExDisplayEEW.Name = "SettingKyoshinExDisplayEEW";
            this.SettingKyoshinExDisplayEEW.Size = new System.Drawing.Size(211, 16);
            this.SettingKyoshinExDisplayEEW.TabIndex = 15;
            this.SettingKyoshinExDisplayEEW.Text = "緊急地震速報発表時にポップアップする";
            this.SettingKyoshinExDisplayEEW.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(122, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "秒";
            // 
            // SettingKyoshinExUpdateDelayValue
            // 
            this.SettingKyoshinExUpdateDelayValue.Location = new System.Drawing.Point(72, 47);
            this.SettingKyoshinExUpdateDelayValue.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.SettingKyoshinExUpdateDelayValue.Name = "SettingKyoshinExUpdateDelayValue";
            this.SettingKyoshinExUpdateDelayValue.Size = new System.Drawing.Size(49, 19);
            this.SettingKyoshinExUpdateDelayValue.TabIndex = 13;
            this.SettingKyoshinExUpdateDelayValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "遅延";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(122, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "分/回";
            // 
            // SettingKyoshinExUpdateTimerValue
            // 
            this.SettingKyoshinExUpdateTimerValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SettingKyoshinExUpdateTimerValue.Location = new System.Drawing.Point(72, 22);
            this.SettingKyoshinExUpdateTimerValue.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.SettingKyoshinExUpdateTimerValue.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.SettingKyoshinExUpdateTimerValue.Name = "SettingKyoshinExUpdateTimerValue";
            this.SettingKyoshinExUpdateTimerValue.Size = new System.Drawing.Size(49, 19);
            this.SettingKyoshinExUpdateTimerValue.TabIndex = 10;
            this.SettingKyoshinExUpdateTimerValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SettingKyoshinExUpdateTimerValue.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.SettingKyoshinExUpdateTimerValue.ValueChanged += new System.EventHandler(this.SettingKyoshinExUpdateTimerValue_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "時刻補正";
            // 
            // ComputerSettings
            // 
            this.ComputerSettings.Controls.Add(this.CSettingEventlogEEW);
            this.ComputerSettings.Controls.Add(this.CSettingEventlog);
            this.ComputerSettings.Location = new System.Drawing.Point(4, 22);
            this.ComputerSettings.Name = "ComputerSettings";
            this.ComputerSettings.Padding = new System.Windows.Forms.Padding(3);
            this.ComputerSettings.Size = new System.Drawing.Size(788, 408);
            this.ComputerSettings.TabIndex = 4;
            this.ComputerSettings.Text = "コンピューターの設定";
            this.ComputerSettings.UseVisualStyleBackColor = true;
            // 
            // CSettingEventlogEEW
            // 
            this.CSettingEventlogEEW.AutoSize = true;
            this.CSettingEventlogEEW.Enabled = false;
            this.CSettingEventlogEEW.Location = new System.Drawing.Point(28, 50);
            this.CSettingEventlogEEW.Name = "CSettingEventlogEEW";
            this.CSettingEventlogEEW.Size = new System.Drawing.Size(190, 16);
            this.CSettingEventlogEEW.TabIndex = 1;
            this.CSettingEventlogEEW.Text = "緊急地震速報の取得時も含める。";
            this.CSettingEventlogEEW.UseVisualStyleBackColor = true;
            // 
            // CSettingEventlog
            // 
            this.CSettingEventlog.AutoSize = true;
            this.CSettingEventlog.Enabled = false;
            this.CSettingEventlog.Location = new System.Drawing.Point(6, 28);
            this.CSettingEventlog.Name = "CSettingEventlog";
            this.CSettingEventlog.Size = new System.Drawing.Size(302, 16);
            this.CSettingEventlog.TabIndex = 0;
            this.CSettingEventlog.Text = "地震情報取得時、コンピューターのイベントログに記録する。";
            this.CSettingEventlog.UseVisualStyleBackColor = true;
            // 
            // TwitterSettings
            // 
            this.TwitterSettings.AutoScroll = true;
            this.TwitterSettings.Controls.Add(this.label21);
            this.TwitterSettings.Controls.Add(this.button5);
            this.TwitterSettings.Controls.Add(this.button4);
            this.TwitterSettings.Controls.Add(this.Tweet_isHost);
            this.TwitterSettings.Controls.Add(this.Tweet_checkBox);
            this.TwitterSettings.Controls.Add(this.Tweet_AddressName);
            this.TwitterSettings.Controls.Add(this.Tweet_textbox);
            this.TwitterSettings.Controls.Add(this.ReAuth);
            this.TwitterSettings.Controls.Add(this.label2);
            this.TwitterSettings.Controls.Add(this.textBox1);
            this.TwitterSettings.Controls.Add(this.Tweet_Index);
            this.TwitterSettings.Controls.Add(this.Twitter_Update);
            this.TwitterSettings.Controls.Add(this.button1);
            this.TwitterSettings.Controls.Add(this.UserName);
            this.TwitterSettings.Controls.Add(this.Twitter_isReply);
            this.TwitterSettings.Controls.Add(this.Twitter_Author);
            this.TwitterSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.TwitterSettings.Location = new System.Drawing.Point(4, 22);
            this.TwitterSettings.Name = "TwitterSettings";
            this.TwitterSettings.Padding = new System.Windows.Forms.Padding(3);
            this.TwitterSettings.Size = new System.Drawing.Size(788, 408);
            this.TwitterSettings.TabIndex = 1;
            this.TwitterSettings.Text = "Twitter";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(395, 206);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 12);
            this.label21.TabIndex = 17;
            this.label21.Text = "Test";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(516, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "戻す";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(597, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "適用";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Tweet_isHost
            // 
            this.Tweet_isHost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tweet_isHost.FormattingEnabled = true;
            this.Tweet_isHost.Items.AddRange(new object[] {
            "None",
            "Host",
            "Client"});
            this.Tweet_isHost.Location = new System.Drawing.Point(368, 21);
            this.Tweet_isHost.Name = "Tweet_isHost";
            this.Tweet_isHost.Size = new System.Drawing.Size(121, 20);
            this.Tweet_isHost.TabIndex = 19;
            this.Tweet_isHost.SelectedIndexChanged += new System.EventHandler(this.Tweet_isHost_SelectedIndexChanged);
            // 
            // Tweet_checkBox
            // 
            this.Tweet_checkBox.AutoSize = true;
            this.Tweet_checkBox.Location = new System.Drawing.Point(524, 45);
            this.Tweet_checkBox.Name = "Tweet_checkBox";
            this.Tweet_checkBox.Size = new System.Drawing.Size(148, 16);
            this.Tweet_checkBox.TabIndex = 18;
            this.Tweet_checkBox.Text = "このPCの監視を試験停止";
            this.Tweet_checkBox.UseVisualStyleBackColor = true;
            // 
            // Tweet_AddressName
            // 
            this.Tweet_AddressName.AutoSize = true;
            this.Tweet_AddressName.Location = new System.Drawing.Point(366, 47);
            this.Tweet_AddressName.Name = "Tweet_AddressName";
            this.Tweet_AddressName.Size = new System.Drawing.Size(124, 12);
            this.Tweet_AddressName.TabIndex = 15;
            this.Tweet_AddressName.Text = "状態監視アドレス(ホスト)";
            // 
            // Tweet_textbox
            // 
            this.Tweet_textbox.Location = new System.Drawing.Point(368, 61);
            this.Tweet_textbox.Name = "Tweet_textbox";
            this.Tweet_textbox.Size = new System.Drawing.Size(304, 19);
            this.Tweet_textbox.TabIndex = 14;
            // 
            // ReAuth
            // 
            this.ReAuth.Location = new System.Drawing.Point(0, 352);
            this.ReAuth.Name = "ReAuth";
            this.ReAuth.Size = new System.Drawing.Size(61, 21);
            this.ReAuth.TabIndex = 13;
            this.ReAuth.Text = "再認証";
            this.ReAuth.UseVisualStyleBackColor = true;
            this.ReAuth.Click += new System.EventHandler(this.ReAuth_Click);
            // 
            // SettingsAbout
            // 
            this.SettingsAbout.Controls.Add(this.MisakiEQTwitterLink);
            this.SettingsAbout.Controls.Add(this.label5);
            this.SettingsAbout.Controls.Add(this.MisakiEQIcon);
            this.SettingsAbout.Controls.Add(this.Copyright_Label);
            this.SettingsAbout.Controls.Add(this.Link_VersionHistory);
            this.SettingsAbout.Controls.Add(this.LinkDonate);
            this.SettingsAbout.Controls.Add(this.LinkAbout);
            this.SettingsAbout.Controls.Add(this.LinkLicense);
            this.SettingsAbout.Controls.Add(this.LinkTwitter);
            this.SettingsAbout.Controls.Add(this.VersionName);
            this.SettingsAbout.Location = new System.Drawing.Point(4, 22);
            this.SettingsAbout.Name = "SettingsAbout";
            this.SettingsAbout.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsAbout.Size = new System.Drawing.Size(788, 408);
            this.SettingsAbout.TabIndex = 2;
            this.SettingsAbout.Text = "バージョン";
            // 
            // MisakiEQTwitterLink
            // 
            this.MisakiEQTwitterLink.Location = new System.Drawing.Point(671, 233);
            this.MisakiEQTwitterLink.Name = "MisakiEQTwitterLink";
            this.MisakiEQTwitterLink.Size = new System.Drawing.Size(109, 23);
            this.MisakiEQTwitterLink.TabIndex = 10;
            this.MisakiEQTwitterLink.Text = "公式Twitter";
            this.MisakiEQTwitterLink.UseVisualStyleBackColor = true;
            this.MisakiEQTwitterLink.Click += new System.EventHandler(this.MisakiEQTwitterLink_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "MisakiEQのイメージキャラクター：水咲ちゃん\r\nCV. 麻桧 羽結(あさひ うゆ)";
            // 
            // MisakiEQIcon
            // 
            this.MisakiEQIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MisakiEQIcon.Image = global::MisakiEQ.Properties.Resources.main_big;
            this.MisakiEQIcon.Location = new System.Drawing.Point(0, 0);
            this.MisakiEQIcon.Name = "MisakiEQIcon";
            this.MisakiEQIcon.Size = new System.Drawing.Size(256, 256);
            this.MisakiEQIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MisakiEQIcon.TabIndex = 8;
            this.MisakiEQIcon.TabStop = false;
            // 
            // Copyright_Label
            // 
            this.Copyright_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Copyright_Label.AutoSize = true;
            this.Copyright_Label.Location = new System.Drawing.Point(3, 378);
            this.Copyright_Label.Name = "Copyright_Label";
            this.Copyright_Label.Size = new System.Drawing.Size(260, 24);
            this.Copyright_Label.TabIndex = 7;
            this.Copyright_Label.Text = "MisakiEQは水咲(みさき)によって作られたはずですが\r\nコピーライトファイル読み取り中にエラーが発生しました。";
            this.Copyright_Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Link_VersionHistory
            // 
            this.Link_VersionHistory.Location = new System.Drawing.Point(671, 379);
            this.Link_VersionHistory.Name = "Link_VersionHistory";
            this.Link_VersionHistory.Size = new System.Drawing.Size(109, 23);
            this.Link_VersionHistory.TabIndex = 6;
            this.Link_VersionHistory.Text = "更新履歴";
            this.Link_VersionHistory.UseVisualStyleBackColor = true;
            this.Link_VersionHistory.Click += new System.EventHandler(this.Link_VersionHistory_Click);
            // 
            // LinkDonate
            // 
            this.LinkDonate.Location = new System.Drawing.Point(671, 350);
            this.LinkDonate.Name = "LinkDonate";
            this.LinkDonate.Size = new System.Drawing.Size(109, 23);
            this.LinkDonate.TabIndex = 5;
            this.LinkDonate.Text = "寄付";
            this.LinkDonate.UseVisualStyleBackColor = true;
            this.LinkDonate.Click += new System.EventHandler(this.LinkDonate_Click);
            // 
            // LinkAbout
            // 
            this.LinkAbout.Location = new System.Drawing.Point(671, 321);
            this.LinkAbout.Name = "LinkAbout";
            this.LinkAbout.Size = new System.Drawing.Size(109, 23);
            this.LinkAbout.TabIndex = 4;
            this.LinkAbout.Text = "MisakiEQについて";
            this.LinkAbout.UseVisualStyleBackColor = true;
            this.LinkAbout.Click += new System.EventHandler(this.LinkAbout_Click);
            // 
            // LinkLicense
            // 
            this.LinkLicense.Location = new System.Drawing.Point(671, 292);
            this.LinkLicense.Name = "LinkLicense";
            this.LinkLicense.Size = new System.Drawing.Size(109, 23);
            this.LinkLicense.TabIndex = 3;
            this.LinkLicense.Text = "ライセンス";
            this.LinkLicense.UseVisualStyleBackColor = true;
            this.LinkLicense.Click += new System.EventHandler(this.LinkLicense_Click);
            // 
            // LinkTwitter
            // 
            this.LinkTwitter.Location = new System.Drawing.Point(671, 263);
            this.LinkTwitter.Name = "LinkTwitter";
            this.LinkTwitter.Size = new System.Drawing.Size(109, 23);
            this.LinkTwitter.TabIndex = 2;
            this.LinkTwitter.Text = "開発者Twitter";
            this.LinkTwitter.UseVisualStyleBackColor = true;
            this.LinkTwitter.Click += new System.EventHandler(this.button2_Click);
            // 
            // VersionName
            // 
            this.VersionName.AutoSize = true;
            this.VersionName.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.VersionName.Location = new System.Drawing.Point(262, 3);
            this.VersionName.Name = "VersionName";
            this.VersionName.Size = new System.Drawing.Size(275, 19);
            this.VersionName.TabIndex = 0;
            this.VersionName.Text = "MisakiEQの不明なバージョンです！";
            // 
            // SettingClose
            // 
            this.SettingClose.AccessibleName = "SettingClose";
            this.SettingClose.Controls.Add(this.TestLabel);
            this.SettingClose.Controls.Add(this.TestButton);
            this.SettingClose.Controls.Add(this.button3);
            this.SettingClose.Controls.Add(this.GetDataPauseButton);
            this.SettingClose.Controls.Add(this.CloseApplication);
            this.SettingClose.Location = new System.Drawing.Point(4, 22);
            this.SettingClose.Name = "SettingClose";
            this.SettingClose.Padding = new System.Windows.Forms.Padding(3);
            this.SettingClose.Size = new System.Drawing.Size(788, 408);
            this.SettingClose.TabIndex = 3;
            this.SettingClose.Text = "終了";
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(235, 124);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 3;
            this.TestButton.Text = "TestButton";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(649, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 21);
            this.button3.TabIndex = 2;
            this.button3.Text = "Crash Application";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GetDataPauseButton
            // 
            this.GetDataPauseButton.Location = new System.Drawing.Point(649, 325);
            this.GetDataPauseButton.Name = "GetDataPauseButton";
            this.GetDataPauseButton.Size = new System.Drawing.Size(131, 22);
            this.GetDataPauseButton.TabIndex = 1;
            this.GetDataPauseButton.Text = "データ取得の一時停止";
            this.GetDataPauseButton.UseVisualStyleBackColor = true;
            this.GetDataPauseButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // CloseApplication
            // 
            this.CloseApplication.Location = new System.Drawing.Point(649, 353);
            this.CloseApplication.Name = "CloseApplication";
            this.CloseApplication.Size = new System.Drawing.Size(131, 22);
            this.CloseApplication.TabIndex = 0;
            this.CloseApplication.Text = "アプリケーションの終了";
            this.CloseApplication.UseVisualStyleBackColor = true;
            this.CloseApplication.Click += new System.EventHandler(this.CloseApplication_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaskStatus,
            this.TaskProgressBar,
            this.TaskProgressText,
            this.StatusMassage});
            this.statusStrip.Location = new System.Drawing.Point(0, 476);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 25);
            this.statusStrip.TabIndex = 16;
            this.statusStrip.Text = "statusStrip1";
            // 
            // TaskStatus
            // 
            this.TaskStatus.AutoSize = false;
            this.TaskStatus.Name = "TaskStatus";
            this.TaskStatus.Size = new System.Drawing.Size(100, 20);
            this.TaskStatus.Text = "準備OK";
            this.TaskStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TaskProgressBar
            // 
            this.TaskProgressBar.Name = "TaskProgressBar";
            this.TaskProgressBar.Size = new System.Drawing.Size(300, 19);
            // 
            // TaskProgressText
            // 
            this.TaskProgressText.AutoSize = false;
            this.TaskProgressText.Name = "TaskProgressText";
            this.TaskProgressText.Size = new System.Drawing.Size(78, 20);
            this.TaskProgressText.Text = "---.--%";
            this.TaskProgressText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusMassage
            // 
            this.StatusMassage.Name = "StatusMassage";
            this.StatusMassage.Size = new System.Drawing.Size(261, 20);
            this.StatusMassage.Text = "現在実行中のタスクはありません。";
            // 
            // Timer_KyoshinEx
            // 
            this.Timer_KyoshinEx.Interval = 50;
            this.Timer_KyoshinEx.Tick += new System.EventHandler(this.Timer_KyoshinEx_Tick);
            // 
            // Timer_AdjustKyoshinEx
            // 
            this.Timer_AdjustKyoshinEx.Interval = 1800000;
            this.Timer_AdjustKyoshinEx.Tick += new System.EventHandler(this.Timer_AdjustKyoshinEx_Tick);
            // 
            // OtherPCWatchingTimer
            // 
            this.OtherPCWatchingTimer.Interval = 5000;
            this.OtherPCWatchingTimer.Tick += new System.EventHandler(this.OtherPCWatchingTimer_Tick);
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.Location = new System.Drawing.Point(326, 129);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(55, 12);
            this.TestLabel.TabIndex = 4;
            this.TestLabel.Text = "TestLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Test_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "設定 - MisakiEQ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.P2P_Interval_EarthQuake)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P2P_Interval_Tsunami)).EndInit();
            this.EarthquakeTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.MisakiEQ_Infomation.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.MisakiEQ_LatestData.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.KyoshinEx.ResumeLayout(false);
            this.KyoshinEx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KyoshinImage)).EndInit();
            this.MisakiEQ_Status.ResumeLayout(false);
            this.MisakiEQ_Status.PerformLayout();
            this.MisakiEQ_Settings.ResumeLayout(false);
            this.SettingTab.ResumeLayout(false);
            this.DataUpdateSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingKyoshinExUpdateDelayValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingKyoshinExUpdateTimerValue)).EndInit();
            this.ComputerSettings.ResumeLayout(false);
            this.ComputerSettings.PerformLayout();
            this.TwitterSettings.ResumeLayout(false);
            this.TwitterSettings.PerformLayout();
            this.SettingsAbout.ResumeLayout(false);
            this.SettingsAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MisakiEQIcon)).EndInit();
            this.SettingClose.ResumeLayout(false);
            this.SettingClose.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown P2P_Interval_EarthQuake;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label P2P_ErrorMassage;
        private System.Windows.Forms.NumericUpDown P2P_Interval_Tsunami;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RequestedCount;
        private System.Windows.Forms.Button P2P_Conform;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label P2P_Request_Max;
        private System.Windows.Forms.Label P2P_Request_Usage;
        private System.Windows.Forms.ProgressBar P2P_Progress_Usage;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Twitter_Author;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Tweet_Index;
        private System.Windows.Forms.Button Twitter_Update;
        private System.Windows.Forms.CheckBox Twitter_isReply;

        private System.Windows.Forms.Timer Timer_EarthQuake;
        private System.Windows.Forms.Timer Timer_Tsunami;
        private System.Windows.Forms.Timer UIUpdate;
        private System.Windows.Forms.Timer Timer_EEW;
        private System.Windows.Forms.Label Test_Label;
        private System.Windows.Forms.TabControl EarthquakeTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label EEWInitOKLabel;
        private System.Windows.Forms.Label EQInitOKLabel;
        private System.Windows.Forms.Label EEW_Index;
        private System.Windows.Forms.Label EQ_Index;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label TsunamiInitOKLabel;
        private System.Windows.Forms.Label Tsunami_Index;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MisakiEQ_Infomation;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage MisakiEQ_LatestData;
        private System.Windows.Forms.TabPage MisakiEQ_Status;
        private System.Windows.Forms.TabPage MisakiEQ_Settings;
        private System.Windows.Forms.TabControl SettingTab;
        private System.Windows.Forms.TabPage DataUpdateSettings;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar TaskProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel TaskStatus;
        private System.Windows.Forms.TabPage TwitterSettings;
        private System.Windows.Forms.TabPage SettingsAbout;
        private System.Windows.Forms.Label VersionName;
        private System.Windows.Forms.ToolStripStatusLabel TaskProgressText;
        private System.Windows.Forms.ToolStripStatusLabel StatusMassage;
        private System.Windows.Forms.Button LinkTwitter;
        private System.Windows.Forms.Button LinkLicense;
        private System.Windows.Forms.Button LinkAbout;
        private System.Windows.Forms.Button LinkDonate;
        private System.Windows.Forms.TabPage SettingClose;
        private System.Windows.Forms.Button GetDataPauseButton;
        private System.Windows.Forms.Button CloseApplication;
        private System.Windows.Forms.Button ReAuth;
        private System.Windows.Forms.TabPage KyoshinEx;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker KyoshinDateTime;
        private System.Windows.Forms.PictureBox KyoshinImage;
        private System.Windows.Forms.Timer Timer_KyoshinEx;
        private System.Windows.Forms.Button Link_VersionHistory;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Copyright_Label;
        private System.Windows.Forms.Button DisplayKyoshinEx;
        private System.Windows.Forms.PictureBox MisakiEQIcon;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage ComputerSettings;
        private System.Windows.Forms.CheckBox CSettingEventlogEEW;
        private System.Windows.Forms.CheckBox CSettingEventlog;
        private System.Windows.Forms.Button MisakiEQTwitterLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer Timer_AdjustKyoshinEx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox SettingKyoshinExDisplayEEW;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown SettingKyoshinExUpdateDelayValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown SettingKyoshinExUpdateTimerValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox JMAEQData_Tsunami;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox JMAEQData_ShindoInfo;
        private System.Windows.Forms.TextBox JMAEQData_Max;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox JMAEQData_km;
        private System.Windows.Forms.TextBox JMAEQData_M;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox JMAEQData_Shingen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox JMAEQData_Time;
        private System.Windows.Forms.ComboBox Tweet_isHost;
        private System.Windows.Forms.CheckBox Tweet_checkBox;
        private System.Windows.Forms.Label Tweet_AddressName;
        private System.Windows.Forms.TextBox Tweet_textbox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer OtherPCWatchingTimer;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox EEWDisplay_Magnitude;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox EEWDisplay_Hypocenter;
        private System.Windows.Forms.CheckBox EEWDisplay_IsFinalSerial;
        private System.Windows.Forms.TextBox EEWDisplay_Serial;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox EEWDisplay_AnnounceTime;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox EEWDisplay_Type;
        private System.Windows.Forms.TextBox EEWDisplay_Depth;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox EEWDisplay_WarnForecast;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox EEWDisplay_MaxScale;
        private System.Windows.Forms.TextBox EEWDisplay_OriginTime;
        private System.Windows.Forms.Label label33;
        public System.Windows.Forms.NotifyIcon notification;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Label TestLabel;
    }
}

