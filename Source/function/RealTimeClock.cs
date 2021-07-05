using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisakiEQ.Clock
{
    class RealTimeClock//2036年問題
    {
        public DateTime GetTime()
        {
            try
            {
                // NTPサーバへの接続用UDP生成
                var ip = new System.Net.IPEndPoint(System.Net.IPAddress.Any, 0);
                var udp = new System.Net.Sockets.UdpClient(ip);

                // NTPサーバへのリクエスト送信
                var sendData = new Byte[48];
                sendData[0] = 0xB;
                udp.Send(sendData, 48, "time.windows.com", 123);

                // NTPサーバから日時データ受信
                var receiveData = udp.Receive(ref ip);

                // 1900年1月1日からの経過秒数計算
                var totalSeconds = (long)(
                            receiveData[40] * Math.Pow(2, (8 * 3)) +
                            receiveData[41] * Math.Pow(2, (8 * 2)) +
                            receiveData[42] * Math.Pow(2, (8 * 1)) +
                            receiveData[43]);

                var utcTime = new DateTime(1900, 1, 1).AddSeconds(totalSeconds);

                // 協定世界時 (UTC) からローカルタイムゾーンへの変更
                var localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, TimeZoneInfo.Local);
                return localTime;
            }
            catch
            {
                return System.DateTime.Now;
            }
        }
        
    }
}
