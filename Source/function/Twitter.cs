using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using CoreTweet;
//using static CoreTweet.OAuth;

using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace MisakiEQ.TwiClient
{
    public class Twitter
    {
#if ADMIN || DEBUG
        //OAuth.OAuthSession session;


        private static string cKey = Properties.Resources.Twitter_ConsumerKey;//"6xE2EOb4ylyMBQ5T8gOeBY08l";
        private static string cSec = Properties.Resources.Twitter_ConsumerSecretKey;//"cNRiZJaFFNqh1Bx946dNvamSIJBnIbyVR5CBxERdJaHJZniwUG";
        private string aToken;
        private string aSec;
        //private static Tokens tokens;


        long LatestTweetID=0;
        TwitterClient client = null;
        public Twitter()

        {
            /*tokens = CoreTweet.Tokens.Create(consumer_key
                , consumer_sec
                , accesstoken
                , accesstoken_sec);*/
            string text = "";
            //session = OAuth.Authorize(cKey,cSec);
            try
            {
                int counter = 0;
                string line;

                // Read the file and display it line by line.  
                System.IO.StreamReader file =
                    new System.IO.StreamReader("TwiSession.dat");
                while ((line = file.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    counter++;
                    if (counter == 1)
                    {
                        aToken = line;
                    }
                    if (counter == 2)
                    {
                        aSec = line;

                    }
                }
                file.Close();
                try
                {
                    /*tokens = CoreTweet.Tokens.Create(cKey
                    , cSec
                    , aToken
                    , aSec);*/
                    //Auth.SetUserCredentials(cKey, cSec, aToken, aSec);
                    client = new TwitterClient(cKey, cSec, aToken, aSec);
                    //Auth.SetUserCredentials(cKey,cSec, aToken, aSec);
                }
                catch
                {

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if(text!="")
            {
               
                //tokens = OAuth.GetTokens(session, text);
                
            }
           
        }
        public string GetAccessToken()
        {
            //return tokens.AccessToken;
            //return client.Auth.
            return null;
        }
        public string GetAccessTokenSecret()
        {
            //return tokens.AccessTokenSecret;
            //return Tweetinvi.Auth.ApplicationCredentials.AccessTokenSecret;
            return null;
        }
        public void OpenAuthURL()
        {
            //session = Authorize(cKey, cSec);
            //System.Diagnostics.Process.Start(session.AuthorizeUri.AbsoluteUri);

            var appCredentials = new TwitterCredentials(cKey, cSec);
            //client.Auth.RequestAuthenticationUrlAsync();
            //var url = Auth.
            // Go to the URL so that Twitter authenticates the user and gives him a PIN code
            //var url = AuthFlow.CredentialsCreator.GetAuthorizationURL(appCredentials);

            // This line is an example, on how to make the user go on the URL
            //Process.Start(url);
        }
        public void EnterAuth(string Pincode)
        {
            try
            {
                //tokens = OAuth.GetTokens(session, Pincode);
            }
            catch
            {

            }
        }
        public long Tweet(string TweetText)
        {
            //if (tokens == null) return;
            //StatusResponse a = tokens.Statuses.Update( status : TweetText );
            var a = client.Tweets.PublishTweetAsync(TweetText);
            LatestTweetID = a.Id;
            return a.Id;
        }
        public long Reply(long TweetID,string TweetText)
        {
            //if (tokens == null) return;
            //StatusResponse a = tokens.Statuses.Update(status : TweetText, in_reply_to_status_id:TweetID);
            Console.WriteLine(TweetID);
            if (TweetID == 0)
            {
                return Tweet(TweetText);
            }
            try
            {
                var tweet = client.Tweets.GetTweetAsync(TweetID);
                var reply = client.Tweets.PublishTweetAsync(new PublishTweetParameters(TweetText)
                {
                    InReplyToTweet = tweet.Result
                });
                LatestTweetID = reply.Result.Id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine(ex.InnerException);
                throw ex;
            }
            return LatestTweetID;
        }
        public long GetUserID()
        {
            long ScreenID = 0;
            //if (tokens == null) return null;
            try
            {
                //var userResponse = tokens.Account.VerifyCredentials();
                //ScreenID= userResponse.ScreenName;
                var a = client.Users.GetAuthenticatedUserAsync().Result;
                ScreenID = a.Id;
            }
            catch
            {
                // MessageBox.Show(ex.Message);
                //tokens = null;
            }
            return ScreenID;
        }
        public string GetScreenName()
        {
            string ScreenID = null;
            //if (tokens == null) return null;
            try
            {
                //var userResponse = tokens.Account.VerifyCredentials();
                //ScreenID= userResponse.ScreenName;
                var a = client.Users.GetAuthenticatedUserAsync().Result;
                ScreenID = a.ScreenName;
            }
            catch 
            {
                // MessageBox.Show(ex.Message);
                //tokens = null;
            }
            return ScreenID;
            
        }
        public string GetStringName()
        {
            string name=null;
            //if (tokens == null) return null;
            try
            {
                //var userResponse = tokens.Account.VerifyCredentials();
                //name = userResponse.Name;

                var a = client.Users.GetAuthenticatedUserAsync().Result;
                name = a.Name;
            }
            catch
            {
                //tokens = null;
            }
            return name;
        }
         public ITweet[] GetTweetUser(long UserID)
         {
            // if (tokens == null) return null;
             try {
                //return tokens.Statuses.UserTimeline(count: count, screen_name: UserID).ToList();
                var a = client.Timelines.GetUserTimelineAsync(UserID).Result;
                Console.WriteLine(a[0].Id + "\n" + a[0].Text);
                return a;
            }
             catch
             {
                 return null;
             }
         }
        public ITweet GetLatestTweetUser(long UserID)
        {
            var a = client.Timelines.GetUserTimelineAsync(UserID).Result;
            if (a.Length > 0)
            {
                Console.WriteLine(a[0].Id + "\n" + a[0].Text);
                return a[0];
            }
            else { return null; }
        }
        public long GetLatestTweetID(string ID="")

        {
            //if (tokens == null) return 0;
            
            if (LatestTweetID==0||ID!="") {
                if (ID == "") return 0;
               var TwiList = GetLatestTweetUser(client.Users.GetUserAsync(ID).Result.Id);

                LatestTweetID = TwiList.Id;
                return TwiList.Id;
            }
            else
            {
                return LatestTweetID;
            }
        }
        public void Test()
        {
            try
            {
                //テスト用に報告
                //UserResponse a = tokens.Users.ReportSpam(user_id => Properties.Resources.ReportUserID);
                //if ((bool)a.IsSuspended) { Console.WriteLine("Suspended."); } else { Console.WriteLine("Yet."); }
            }
            catch
            {
                
            }
        }
#else
        public void Tweet(string TweetText) { }
        public void Reply(long TweetID, string TweetText) { }
        public string GetScreenName() { return null; }
        public List<Status> GetTweetUser(string UserID, int count) { return null; }
        public long GetLatestTweetID() { return -1; }

#endif
    }
}
