using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;
namespace MisakiEQ.DiscordRPC
{
    class Main
    {
        private static DiscordRpcClient client;
        private string clientID = "843881865634250752";
        public void Init()
        {
            try
            {
                client = new DiscordRpcClient(clientID);

                //Set the logger

                //Subscribe to events
                client.OnReady += (sender, e) =>
                {
                    Console.WriteLine("Received Ready from user {0}", e.User.Username);
                    Console.WriteLine(e.User.Premium);
                };


                client.OnPresenceUpdate += (sender, e) =>
                {
                    Console.WriteLine("Received Update! {0}", e.Presence);
                };

                //Connect to the RPC
                client.Initialize();
                if (DiscordLImagePath == "") DiscordLImagePath = "default_main";
                client.SetPresence(new RichPresence()
                {
                    Details = DiscordDetail,
                    State = DiscordState,
                    Assets = new Assets()
                    {
                        LargeImageKey = DiscordLImagePath,
                        LargeImageText = DiscordLImageText,
                        SmallImageKey = DiscordSImagePath,
                        SmallImageText = DiscordSImageText
                    }
                });
            }
            catch
            {

            }

        }
        public void Update()
        {
            try
            {
                if (DiscordLImagePath == "") DiscordLImagePath = "default_main";
                client.SetPresence(new RichPresence()
                {
                    Details = DiscordDetail,
                    State = DiscordState,
                    Assets = new Assets()
                    {
                        LargeImageKey = DiscordLImagePath,
                        LargeImageText = DiscordLImageText,
                        SmallImageKey = DiscordSImagePath,
                        SmallImageText = DiscordSImageText
                    }
                });
                client.Invoke();
            }
            catch
            {

            }
        }
        public void SetStatus(string Detail,string State)
        {
            DiscordDetail = Detail;
            DiscordState = State;
            Update();
        }
        public void SetLargeImage(string Path,string Text)
        {
            DiscordLImagePath = Path;
            DiscordLImageText = Text;
            Update();
        }
        public void SetSmallImage(string Path,string Text)
        {
            DiscordSImagePath = Path;
            DiscordSImageText = Text;
            Update();
        }
        public void SetAll(string Detail,string State,string LPath,string LText,string SPath,string SText)
        {
            DiscordDetail = Detail;
            DiscordState = State;
            DiscordLImagePath = LPath;
            DiscordLImageText = LText;
            DiscordSImagePath = SPath;
            DiscordSImageText = SText;
            Update();
        }
        public void SetDefault()
        {
            DiscordDetail = "現在地震監視中";
            DiscordState = "地震発生次第表示されます。";
            DiscordLImagePath = "";
            DiscordLImageText = "";
            DiscordSImagePath = "";
            DiscordSImageText = "";
            Update();

        }
        string DiscordDetail { get; set; }
        string DiscordState { get; set; }
        string DiscordLImagePath { get; set; }
        string DiscordSImagePath { get; set; }
        string DiscordLImageText { get; set; }
        string DiscordSImageText { get; set; }
    }
}
