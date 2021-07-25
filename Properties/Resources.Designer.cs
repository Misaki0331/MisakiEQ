﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MisakiEQ.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MisakiEQ.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   このアプリケーションをご利用いただきありがとうございます。
        ///
        ///MisakiEQは以下の情報から地震データを受信します。あらかじめフィルタを外した上でご利用ください。
        ///・p2pquake.netからの震度速報、詳細な地震情報及び津波情報
        ///・iedred7584.comからの緊急地震速報
        ///・kmoni.bosai.go.jpからの強震モニタ
        ///
        ///緊急地震速報APIを提供してくださった iedred7584 様に感謝を申し上げます。
        ///GitHub : https://github.com/iedred7584
        ///Twitter : https://twitter.com/iedred7584
        ///
        ///強震モニタは独立行政法人防災科学技術研究所(NIED)が提供するサービスであり、当ソフトMisakiEQとは一切関係はありません。
        ///入手する強震モニタのデータは防災科学技術研究所が提供する画像データを使用させていただいております。
        ///このような貴重な情報を提供してくださる独立行政法人防災科学技術研究所に感謝を申し上げます。
        ///公式サイト : https://www.bosai.go.jp/
        ///強震モニタ  [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string About {
            get {
                return ResourceManager.GetString("About", resourceCulture);
            }
        }
        
        /// <summary>
        ///   型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.Drawing.Bitmap basemap_Alpha {
            get {
                object obj = ResourceManager.GetObject("basemap_Alpha", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.Drawing.Bitmap basemap_shadow {
            get {
                object obj = ResourceManager.GetObject("basemap_shadow", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   2021/07/25 18:47:38.77 
        /// に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string BuildDate {
            get {
                return ResourceManager.GetString("BuildDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   このアプリはすべての機能が無料でご利用いただけますが、開発者に寄付を送ることも可能です。
        ///
        ///PayPalリンク
        ///https://paypal.me/Blueplanet256
        ///
        ///ビットコイン(Bitcoin)
        ///1HLG5Ac1FZvxZm8zZn2X2eYexnz3hnE7sT
        /// に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Donate {
            get {
                return ResourceManager.GetString("Donate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.Drawing.Bitmap EEW {
            get {
                object obj = ResourceManager.GetObject("EEW", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   System.IO.MemoryStream に類似した型 System.IO.UnmanagedMemoryStream のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream First {
            get {
                return ResourceManager.GetStream("First", resourceCulture);
            }
        }
        
        /// <summary>
        ///   型 System.Byte[] のローカライズされたリソースを検索します。
        /// </summary>
        internal static byte[] Font_7barSPBd {
            get {
                object obj = ResourceManager.GetObject("Font_7barSPBd", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.Drawing.Bitmap help {
            get {
                object obj = ResourceManager.GetObject("help", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.Drawing.Bitmap Kyoshin_Basemap {
            get {
                object obj = ResourceManager.GetObject("Kyoshin_Basemap", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   [{&quot;Intensity&quot;:-3,&quot;R&quot;:0,&quot;G&quot;:0,&quot;B&quot;:205},{&quot;Intensity&quot;:-2.9,&quot;R&quot;:0,&quot;G&quot;:7,&quot;B&quot;:209},{&quot;Intensity&quot;:-2.8,&quot;R&quot;:0,&quot;G&quot;:14,&quot;B&quot;:214},{&quot;Intensity&quot;:-2.7,&quot;R&quot;:0,&quot;G&quot;:21,&quot;B&quot;:218},{&quot;Intensity&quot;:-2.6,&quot;R&quot;:0,&quot;G&quot;:28,&quot;B&quot;:223},{&quot;Intensity&quot;:-2.5,&quot;R&quot;:0,&quot;G&quot;:36,&quot;B&quot;:227},{&quot;Intensity&quot;:-2.4,&quot;R&quot;:0,&quot;G&quot;:43,&quot;B&quot;:231},{&quot;Intensity&quot;:-2.3,&quot;R&quot;:0,&quot;G&quot;:50,&quot;B&quot;:236},{&quot;Intensity&quot;:-2.2,&quot;R&quot;:0,&quot;G&quot;:57,&quot;B&quot;:240},{&quot;Intensity&quot;:-2.1,&quot;R&quot;:0,&quot;G&quot;:64,&quot;B&quot;:245},{&quot;Intensity&quot;:-2,&quot;R&quot;:0,&quot;G&quot;:72,&quot;B&quot;:250},{&quot;Intensity&quot;:-1.9,&quot;R&quot;:0,&quot;G&quot;:85,&quot;B&quot;:238},{&quot;Intensity&quot;:-1.8,&quot;R&quot;:0,&quot;G&quot;:99,&quot... に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string KyoshinColor {
            get {
                return ResourceManager.GetString("KyoshinColor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ### CoreTweet ###
        ///
        ///The MIT License (MIT)
        ///
        ///CoreTweet - A .NET Twitter Library supporting Twitter API 1.1
        ///Copyright (c) 2013-2018 CoreTweet Development Team
        ///
        ///Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the &quot;Software&quot;), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit perso [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string License {
            get {
                return ResourceManager.GetString("License", resourceCulture);
            }
        }
        
        /// <summary>
        ///   型 System.Drawing.Bitmap のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.Drawing.Bitmap main_big {
            get {
                object obj = ResourceManager.GetObject("main_big", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   (アイコン) に類似した型 System.Drawing.Icon のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.Drawing.Icon mainico {
            get {
                object obj = ResourceManager.GetObject("mainico", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   型 System.Byte[] のローカライズされたリソースを検索します。
        /// </summary>
        internal static byte[] map_land {
            get {
                object obj = ResourceManager.GetObject("map_land", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   型 System.Byte[] のローカライズされたリソースを検索します。
        /// </summary>
        internal static byte[] map_landc {
            get {
                object obj = ResourceManager.GetObject("map_landc", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   型 System.Byte[] のローカライズされたリソースを検索します。
        /// </summary>
        internal static byte[] map_landd {
            get {
                object obj = ResourceManager.GetObject("map_landd", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   型 System.Byte[] のローカライズされたリソースを検索します。
        /// </summary>
        internal static byte[] map_landx {
            get {
                object obj = ResourceManager.GetObject("map_landx", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   型 System.Byte[] のローカライズされたリソースを検索します。
        /// </summary>
        internal static byte[] map_line {
            get {
                object obj = ResourceManager.GetObject("map_line", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   MisakiEQは水咲(みさき)によって作られました。
        ///Copyright 2020-2021 Misaki (Otsuka Shion) All right reserved. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Misaki_License {
            get {
                return ResourceManager.GetString("Misaki_License", resourceCulture);
            }
        }
        
        /// <summary>
        ///   https://twitter.com/MisakiEQ に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string MisakiEQTwitterLink {
            get {
                return ResourceManager.GetString("MisakiEQTwitterLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   701370169650642944 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ReportUserID {
            get {
                return ResourceManager.GetString("ReportUserID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   System.IO.MemoryStream に類似した型 System.IO.UnmanagedMemoryStream のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream SND_Earthquake_Break {
            get {
                return ResourceManager.GetStream("SND_Earthquake_Break", resourceCulture);
            }
        }
        
        /// <summary>
        ///   System.IO.MemoryStream に類似した型 System.IO.UnmanagedMemoryStream のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream SND_Earthquake_Mid {
            get {
                return ResourceManager.GetStream("SND_Earthquake_Mid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   System.IO.MemoryStream に類似した型 System.IO.UnmanagedMemoryStream のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream SND_Earthquake_Small {
            get {
                return ResourceManager.GetStream("SND_Earthquake_Small", resourceCulture);
            }
        }
        
        /// <summary>
        ///   System.IO.MemoryStream に類似した型 System.IO.UnmanagedMemoryStream のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream SND_EEW_Info {
            get {
                return ResourceManager.GetStream("SND_EEW_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   System.IO.MemoryStream に類似した型 System.IO.UnmanagedMemoryStream のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream SND_EEW_Warn {
            get {
                return ResourceManager.GetStream("SND_EEW_Warn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   System.IO.MemoryStream に類似した型 System.IO.UnmanagedMemoryStream のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream SND_Tsunami_Alert {
            get {
                return ResourceManager.GetStream("SND_Tsunami_Alert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   System.IO.MemoryStream に類似した型 System.IO.UnmanagedMemoryStream のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream SND_Tsunami_Update {
            get {
                return ResourceManager.GetStream("SND_Tsunami_Update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   LsJ5tDiMeLhg0pczmv9SNzUcE に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Twitter_ConsumerKey {
            get {
                return ResourceManager.GetString("Twitter_ConsumerKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   8S6cTD3ZH6a2kCvmKMIVBdbqhihhl0oFJoF8DKcWFGQYTuxYQx に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Twitter_ConsumerSecretKey {
            get {
                return ResourceManager.GetString("Twitter_ConsumerSecretKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   https://twitter.com/0x7FF に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TwitterLink {
            get {
                return ResourceManager.GetString("TwitterLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   2021/07/16 - 0.6.0 Updated
        ///別ウィンドウで詳細情報を表示できるようになりました。
        ///
        ///2021/07/06 - 0.5.5 Updated
        ///震度値を修正しました。
        ///
        ///2021/07/03 - 0.5.4 Updated
        ///地域設定のマップ機能の挙動を修正
        ///
        ///2021/06/30 - 0.5.3 Updated
        ///強震モニタが出現しない不具合を完璧に修正
        ///
        ///2021/06/30 - 0.5.2 Updated
        ///多重起動を阻止する機能を追加しました。
        ///
        ///2021/06/30 - 0.5.1 Updated
        ///緊急地震速報が表示されない不具合を直しました。
        ///
        ///2021/06/30 - 0.5.0 Updated
        ///緊急地震速報発令時にエリアまでの到達時間を表示されるようになりました。
        ///
        ///2021/06/27 - 0.4.0 Updated
        ///緊急地震速報発令時にエリアの推定震度を表示できるようになりました。
        ///強震モニタ不具合を微調整(直ってほしい)
        ///起動時に応答なしになる不具合を修正。
        ///
        ///2021/06/26 - 0.3.2 Updated
        ///強震モ [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Update_History {
            get {
                return ResourceManager.GetString("Update_History", resourceCulture);
            }
        }
        
        /// <summary>
        ///   MisakiEQ For Windows Version 0.6.0 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string Version {
            get {
                return ResourceManager.GetString("Version", resourceCulture);
            }
        }
        
        /// <summary>
        ///   System.IO.MemoryStream に類似した型 System.IO.UnmanagedMemoryStream のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream Warn {
            get {
                return ResourceManager.GetStream("Warn", resourceCulture);
            }
        }
    }
}
