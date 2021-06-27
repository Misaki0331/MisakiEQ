using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
#pragma warning disable IDE1006 // jsonの名前は変えられない為
namespace MisakiEQ
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class EQHypocenter
    {
        public int depth { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double magnitude { get; set; }
        public string name { get; set; }
    }

    public class EQEarthquake
    {
        public string domesticTsunami { get; set; }
        public string foreignTsunami { get; set; }
        public EQHypocenter hypocenter { get; set; }
        public int maxScale { get; set; }
        public string time { get; set; }
    }

    public class EQIssue
    {
        public string correct { get; set; }
        public string source { get; set; }
        public string time { get; set; }
        public string type { get; set; }
    }

    public class EQPoint
    {
        public string addr { get; set; }
        public bool isArea { get; set; }
        public string pref { get; set; }
        public int scale { get; set; }
    }

    public class EQRoot
    {
        public int code { get; set; }
        public string created_at { get; set; }
        public EQEarthquake earthquake { get; set; }
        public string id { get; set; }
        public EQIssue issue { get; set; }
        public List<EQPoint> points { get; set; }
        public string time { get; set; }

        [JsonProperty("user-agent")]
        public string UserAgent { get; set; }
        public string ver { get; set; }
    }




    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class EEWTitle
    {
        public int Code { get; set; }
        public string String { get; set; }
        public string Detail { get; set; }
    }

    public class EEWSource
    {
        public int Code { get; set; }
        public string String { get; set; }
    }

    public class EEWStatus
    {
        public string Code { get; set; }
        public string String { get; set; }
        public string Detail { get; set; }
    }

    public class EEWAnnouncedTime
    {
        public string String { get; set; }
        public int UnixTime { get; set; }
        public string RFC1123 { get; set; }
    }

    public class EEWOriginTime
    {
        public string String { get; set; }
        public int UnixTime { get; set; }
        public string RFC1123 { get; set; }
    }

    public class EEWType
    {
        public int Code { get; set; }
        public string String { get; set; }
        public string Detail { get; set; }
    }

    public class EEWDepth
    {
        public int Int { get; set; }
        public string String { get; set; }
        public int Code { get; set; }
    }

    public class EEWLocation
    {
        public double Lat { get; set; }
        public double Long { get; set; }
        public EEWDepth Depth { get; set; }
    }

    public class EEWMagnitude
    {
        public double Float { get; set; }
        public string String { get; set; }
        public string LongString { get; set; }
        public int Code { get; set; }
    }

    public class EEWEpicenter
    {
        public int Code { get; set; }
        public string String { get; set; }
        public int Rank2 { get; set; }
        public string String2 { get; set; }
    }

    public class EEWAccuracy
    {
        public EEWEpicenter Epicenter { get; set; }
        public EEWDepth Depth { get; set; }
        public EEWMagnitude Magnitude { get; set; }
        public int NumberOfMagnitudeCalculation { get; set; }
    }

    public class EEWHypocenter
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public bool isAssumption { get; set; }
        public EEWLocation Location { get; set; }
        public EEWMagnitude Magnitude { get; set; }
        public EEWAccuracy Accuracy { get; set; }
        public bool isSea { get; set; }
    }

    public class EEWMaxIntensity
    {
        public string From { get; set; }
        public string To { get; set; }
        public string String { get; set; }
        public string LongString { get; set; }
    }

    public class EEWWarnForecast
    {
        public EEWHypocenter Hypocenter { get; set; }
        public List<string> District { get; set; }
        public List<string> LocalAreas { get; set; }
        public List<string> Regions { get; set; }
    }

    public class EEWReason
    {
        public int Code { get; set; }
        public string String { get; set; }
    }

    public class EEWChange
    {
        public int Code { get; set; }
        public string String { get; set; }
        public EEWReason Reason { get; set; }
    }

    public class EEWOption
    {
        public EEWChange Change { get; set; }
    }

    public class EEWIntensity
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Description { get; set; }
    }

    public class EEWArrival
    {
        public bool Flag { get; set; }
        public string Condition { get; set; }
        public string Time { get; set; }
    }

    public class EEWForecast
    {
        public EEWIntensity Intensity { get; set; }
        public bool Warn { get; set; }
        public EEWArrival Arrival { get; set; }
    }

    public class EEWRoot
    {
        public string ParseStatus { get; set; }
        public EEWTitle Title { get; set; }
        public EEWSource Source { get; set; }
        public EEWStatus Status { get; set; }
        public EEWAnnouncedTime AnnouncedTime { get; set; }
        public EEWOriginTime OriginTime { get; set; }
        public string EventID { get; set; }
        public EEWType Type { get; set; }
        public int Serial { get; set; }
        public EEWHypocenter Hypocenter { get; set; }
        public EEWMaxIntensity MaxIntensity { get; set; }
        public bool Warn { get; set; }
        public EEWWarnForecast WarnForecast { get; set; }
        public EEWOption Option { get; set; }
        public List<EEWForecast> Forecast { get; set; }
        public string OriginalText { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class TsunamiArea
    {
        public string grade { get; set; }
        public bool immediate { get; set; }
        public string name { get; set; }
    }

    public class TsunamiIssue
    {
        public string source { get; set; }
        public string time { get; set; }
        public string type { get; set; }
    }

    public class TsunamiRoot
    {
        public List<TsunamiArea> areas { get; set; }
        public bool cancelled { get; set; }
        public int code { get; set; }
        public string created_at { get; set; }
        public string id { get; set; }
        public TsunamiIssue issue { get; set; }
        public string time { get; set; }

        [JsonProperty("user-agent")]
        public string UserAgent { get; set; }
        public string ver { get; set; }
    }


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class LatestKyoshinSecurity
    {
        public string realm { get; set; }
        public string hash { get; set; }
    }

    public class LatestKyoshinResult
    {
        public string status { get; set; }
        public string message { get; set; }
    }

    public class LatestKyoshinRoot
    {
        public LatestKyoshinSecurity security { get; set; }
        public string latest_time { get; set; }
        public string request_time { get; set; }
        public LatestKyoshinResult result { get; set; }
    }

    public class KyoshinShindoColor
    {
        public double Intensity { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
    }

}
