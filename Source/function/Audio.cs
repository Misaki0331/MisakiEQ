using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.XAudio2;
using SharpDX.Multimedia;
namespace MisakiEQ.Audio
{

    class Sound
    {
        MasteringVoice _mastering;
        XAudio2 xAudio;
        
        public Sound()
        {
            xAudio = new XAudio2();
            _mastering = new MasteringVoice(xAudio);
            _mastering.SetVolume(1, 0);
            xAudio.StartEngine();
        }
        public double GetMasterVolume()
        {
            float vol;
            _mastering.GetVolume(out vol);
            return vol;
        }
        public void SetMasterVolume(double vol)
        {
            _mastering.SetVolume((float)vol, 0);
        }
        public void GetStream(System.IO.Stream data, ref SourceVoice voice)
        {
            var stream = new SoundStream(data);
            var waveFormat = stream.Format;
            var buffer = new AudioBuffer
            {
                Stream = stream.ToDataStream(),
                AudioBytes = (int)stream.Length,
                Flags = BufferFlags.EndOfStream
            };
            stream.Close();
            
            voice = new SourceVoice(xAudio, waveFormat, true);
            // Adds a sample callback to check that they are working on source voices
            voice.SubmitSourceBuffer(buffer, stream.DecodedPacketsInfo);
            buffer.Stream.Dispose();
        }
        public void Play(ref SourceVoice voice)
        {
            voice.Start();
        }
        public void Stop(ref SourceVoice voice)
        {
            voice.Stop();
        }

        public bool Dispose(ref SourceVoice voice)
        {
            try
            {
                voice.DestroyVoice();
                voice.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    class MisakiEQSound
    {
        public struct _SND
        {
            public SourceVoice Earthquake_Break;
            public SourceVoice Earthquake_Mid;
            public SourceVoice Earthquake_Small;
            public SourceVoice EEW_Info;
            public SourceVoice EEW_Warn;
            public SourceVoice Tsunami_Alert;
            public SourceVoice Tsunami_Update;
        }
        public _SND SE = new _SND();
        public int AllDispose()//リソース開放できた数
        {
            int cnt = 0;
            Sound _s = new Sound();
            if(_s.Dispose(ref SE.Earthquake_Break))cnt++;
            if(_s.Dispose(ref SE.Earthquake_Mid))cnt++;
            if(_s.Dispose(ref SE.Earthquake_Small))cnt++;
            if(_s.Dispose(ref SE.EEW_Info))cnt++;
            if(_s.Dispose(ref SE.EEW_Warn))cnt++;
            if(_s.Dispose(ref SE.Tsunami_Alert))cnt++;
            if(_s.Dispose(ref SE.Tsunami_Update))cnt++;
            return cnt;
        }
    }
}
