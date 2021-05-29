﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

using CoreTweet;
using static CoreTweet.OAuth;

namespace MisakiEQ
{
    public class Twitter
    {
#if ADMIN || DEBUG
        OAuth.OAuthSession session;
        private static string consumer_key    = "5x4mO0EEaBwNPZGcSiBzqUpD6";
        private static string consumer_sec    = "SfhJmQSLCcIhRhjZZjBcPkDEhLsXSYd2ZBhULYbDVeIrtFkDf1";
        private static string accesstoken     = "1129403055374340101-rvnDpPVbnXS40X9nCoe5U2s8aq21ng";
        private static string accesstoken_sec = "qMHYChSHGYWjx17GmQNJcRPhRs1x8bl0zvHs0GdfP2wDv";

        private static string cKey = "6xE2EOb4ylyMBQ5T8gOeBY08l";
        private static string cSec = "cNRiZJaFFNqh1Bx946dNvamSIJBnIbyVR5CBxERdJaHJZniwUG";
        private string aToken;
        private string aSec;
        private static Tokens tokens;
        string userName;
        public Twitter()

        {
            /*tokens = CoreTweet.Tokens.Create(consumer_key
                , consumer_sec
                , accesstoken
                , accesstoken_sec);*/
            string text = "";
            session = OAuth.Authorize(cKey,cSec);
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
                    tokens = CoreTweet.Tokens.Create(cKey
                    , cSec
                    , aToken
                    , aSec);
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
               
                tokens = OAuth.GetTokens(session, text);
                
            }
           
        }
        public string GetAccessToken()
        {
            return tokens.AccessToken;
        }
        public string GetAccessTokenSecret()
        {
            return tokens.AccessTokenSecret;
        }
        public void OpenAuthURL()
        {
            session = Authorize(cKey, cSec);
            System.Diagnostics.Process.Start(session.AuthorizeUri.AbsoluteUri);
        }
        public void EnterAuth(string Pincode)
        {
            try
            {
                tokens = OAuth.GetTokens(session, Pincode);
            }
            catch
            {

            }
        }
        public void Tweet(string TweetText)
        {
            if (tokens == null) return;
            tokens.Statuses.Update( status : TweetText );
        }
        public void Reply(long TweetID,string TweetText)
        {
            if (tokens == null) return;
            tokens.Statuses.Update(status : TweetText, in_reply_to_status_id:TweetID);
        }

        public string GetScreenName()
        {
            string ScreenID = null;
            if (tokens == null) return null;
            try
            {
                var userResponse = tokens.Account.VerifyCredentials();
                ScreenID= userResponse.ScreenName;
            }
            catch 
            {
                // MessageBox.Show(ex.Message);
                tokens = null;
            }
            return ScreenID;
            
        }
        public string GetStringName()
        {
            string name=null;
            if (tokens == null) return null;
            try
            {
                var userResponse = tokens.Account.VerifyCredentials();
                name = userResponse.Name;
            }
            catch
            {
                tokens = null;
            }
            return name;
        }
        public List<Status> GetTweetUser(string UserID, int count)
        {
            if (tokens == null) return null;
            try {
                return tokens.Statuses.UserTimeline(count: count, screen_name: UserID).ToList();
            }
            catch
            {
                return null;
            }
        }
        public long GetLatestTweetID(string ID)
        {
            if (tokens == null) return 0;
            List<CoreTweet.Status> TwiList = GetTweetUser(ID, 1);

            return TwiList[0].Id;
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