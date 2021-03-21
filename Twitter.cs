using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CoreTweet;
using static CoreTweet.OAuth;

namespace MisakiEQ
{
    class Twitter
    {
        private static string consumer_key    = "5x4mO0EEaBwNPZGcSiBzqUpD6";
        private static string consumer_sec    = "SfhJmQSLCcIhRhjZZjBcPkDEhLsXSYd2ZBhULYbDVeIrtFkDf1";
        private static string accesstoken     = "1129403055374340101-rvnDpPVbnXS40X9nCoe5U2s8aq21ng";
        private static string accesstoken_sec = "qMHYChSHGYWjx17GmQNJcRPhRs1x8bl0zvHs0GdfP2wDv";
        private static Tokens tokens;
        public Twitter()
        {
            tokens = CoreTweet.Tokens.Create(consumer_key
                , consumer_sec
                , accesstoken
                , accesstoken_sec);
        }
        
        public void Tweet(string TweetText)
        {
            tokens.Statuses.Update( status : TweetText );
        }
        public void Reply(long TweetID,string TweetText)
        {
            tokens.Statuses.Update(status : TweetText, in_reply_to_status_id:TweetID);
        }
        public void GetLastTweet()
        {
          // tokens.Users.
        }
        public string GetScreenName()
        {

            return tokens.ScreenName;
        }
        public List<Status> GetTweetUser(string UserID, int count)
        {
            
            return tokens.Statuses.UserTimeline(count: count, screen_name: UserID).ToList();
        }
        public long GetLatestTweetID()
        {
            List<CoreTweet.Status> TwiList = GetTweetUser("0x7FF", 1);

            return TwiList[0].Id;
        }
    }
}
