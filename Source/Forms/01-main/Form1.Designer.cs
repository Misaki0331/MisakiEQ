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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.KyoshinEx = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.KyoshinDateTime = new System.Windows.Forms.DateTimePicker();
            this.KyoshinImage = new System.Windows.Forms.PictureBox();
            this.MisakiEQ_Status = new System.Windows.Forms.TabPage();
            this.MisakiEQ_Settings = new System.Windows.Forms.TabPage();
            this.SettingTab = new System.Windows.Forms.TabControl();
            this.DataUpdateSettings = new System.Windows.Forms.TabPage();
            this.TwitterSettings = new System.Windows.Forms.TabPage();
            this.ReAuth = new System.Windows.Forms.Button();
            this.SettingsAbout = new System.Windows.Forms.TabPage();
            this.Copyright_Label = new System.Windows.Forms.Label();
            this.Link_VersionHistory = new System.Windows.Forms.Button();
            this.LinkDonate = new System.Windows.Forms.Button();
            this.LinkAbout = new System.Windows.Forms.Button();
            this.LinkLicense = new System.Windows.Forms.Button();
            this.LinkTwitter = new System.Windows.Forms.Button();
            this.VersionName = new System.Windows.Forms.Label();
            this.SettingClose = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.GetDataPauseButton = new System.Windows.Forms.Button();
            this.CloseApplication = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.TaskStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TaskProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.TaskProgressText = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusMassage = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer_KyoshinEx = new System.Windows.Forms.Timer(this.components);
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
            this.KyoshinEx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KyoshinImage)).BeginInit();
            this.MisakiEQ_Status.SuspendLayout();
            this.MisakiEQ_Settings.SuspendLayout();
            this.SettingTab.SuspendLayout();
            this.DataUpdateSettings.SuspendLayout();
            this.TwitterSettings.SuspendLayout();
            this.SettingsAbout.SuspendLayout();
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
            this.notification.Icon = ((System.Drawing.Icon)(resources.GetObject("notification.Icon")));
            this.notification.Text = "MisakiEQ";
            this.notification.Visible = true;
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
            // KyoshinEx
            // 
            this.KyoshinEx.BackColor = System.Drawing.SystemColors.Control;
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
            this.DataUpdateSettings.Controls.Add(this.groupBox1);
            this.DataUpdateSettings.Location = new System.Drawing.Point(4, 22);
            this.DataUpdateSettings.Name = "DataUpdateSettings";
            this.DataUpdateSettings.Padding = new System.Windows.Forms.Padding(3);
            this.DataUpdateSettings.Size = new System.Drawing.Size(788, 408);
            this.DataUpdateSettings.TabIndex = 0;
            this.DataUpdateSettings.Text = "データ更新頻度";
            // 
            // TwitterSettings
            // 
            this.TwitterSettings.AutoScroll = true;
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
            this.VersionName.Location = new System.Drawing.Point(6, 16);
            this.VersionName.Name = "VersionName";
            this.VersionName.Size = new System.Drawing.Size(174, 12);
            this.VersionName.TabIndex = 0;
            this.VersionName.Text = "MisakiEQの不明なバージョンです！";
            // 
            // SettingClose
            // 
            this.SettingClose.AccessibleName = "SettingClose";
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
            this.statusStrip.Location = new System.Drawing.Point(0, 477);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 24);
            this.statusStrip.TabIndex = 16;
            this.statusStrip.Text = "statusStrip1";
            // 
            // TaskStatus
            // 
            this.TaskStatus.AutoSize = false;
            this.TaskStatus.Name = "TaskStatus";
            this.TaskStatus.Size = new System.Drawing.Size(100, 19);
            this.TaskStatus.Text = "準備OK";
            this.TaskStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TaskProgressBar
            // 
            this.TaskProgressBar.Name = "TaskProgressBar";
            this.TaskProgressBar.Size = new System.Drawing.Size(300, 18);
            // 
            // TaskProgressText
            // 
            this.TaskProgressText.AutoSize = false;
            this.TaskProgressText.Name = "TaskProgressText";
            this.TaskProgressText.Size = new System.Drawing.Size(78, 19);
            this.TaskProgressText.Text = "---.--%";
            this.TaskProgressText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusMassage
            // 
            this.StatusMassage.Name = "StatusMassage";
            this.StatusMassage.Size = new System.Drawing.Size(245, 19);
            this.StatusMassage.Text = "現在実行中のタスクはありません。";
            // 
            // Timer_KyoshinEx
            // 
            this.Timer_KyoshinEx.Interval = 50;
            this.Timer_KyoshinEx.Tick += new System.EventHandler(this.Timer_KyoshinEx_Tick);
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
            this.KyoshinEx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KyoshinImage)).EndInit();
            this.MisakiEQ_Status.ResumeLayout(false);
            this.MisakiEQ_Status.PerformLayout();
            this.MisakiEQ_Settings.ResumeLayout(false);
            this.SettingTab.ResumeLayout(false);
            this.DataUpdateSettings.ResumeLayout(false);
            this.TwitterSettings.ResumeLayout(false);
            this.TwitterSettings.PerformLayout();
            this.SettingsAbout.ResumeLayout(false);
            this.SettingsAbout.PerformLayout();
            this.SettingClose.ResumeLayout(false);
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
        private System.Windows.Forms.NotifyIcon notification;

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
    }
}

