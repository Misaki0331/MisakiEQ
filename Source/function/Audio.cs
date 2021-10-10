using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NAudio;
using NAudio.Wave;
using System.Threading;

namespace MisakiEQ.Audio
{

    class Sound
    {

        public Sound()
        {

        }
        public double GetMasterVolume()
        {
            double value = 0;
            return value;
        }
        public void SetMasterVolume(double vol)
        {
        }
        public void GetStream(System.IO.Stream data, ref SoundBuffer voice)
        {
            if (voice == null) voice = new SoundBuffer();
            voice.Reader = new WaveFileReader(data);
            voice.Wave = new WaveOut();

        }
        public void Play(ref SoundBuffer voice)
        {
            try
            {
                voice.Reader.CurrentTime = TimeSpan.FromSeconds(0);
                voice.Wave.Init(voice.Reader);
                voice.Wave.Play();
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void Stop(ref SoundBuffer voice)
        {
            voice.Wave.Stop();

        }
        //Play=0:Pause Play=1:Play/Resume Play=Other:Auto Pause/Play
        public void Pause(ref SoundBuffer voice, int Play = -1)
        {
            switch (voice.Wave.PlaybackState)
            {
                case PlaybackState.Stopped:
                    if (Play != 0 || Play == 1)
                    {
                        voice.Reader.CurrentTime = TimeSpan.FromSeconds(0);
                        voice.Wave.Init(voice.Reader);
                        voice.Wave.Play();
                    }
                    break;
                case PlaybackState.Paused:
                    if (Play != 0 || Play == 1) voice.Wave.Resume();
                    break;
                case PlaybackState.Playing:
                    if (Play != 1 || Play == 0) voice.Wave.Pause();
                    break;
            }
        }
        public void Replay(ref SoundBuffer voice)
        {
            voice.Wave.Stop();
            voice.Reader.CurrentTime= TimeSpan.FromSeconds(0);
            voice.Wave.Init(voice.Reader);
            voice.Wave.Play();
        }
        public bool Dispose(ref SoundBuffer voice)
        {
            try
            {
                voice.Wave.Dispose();
                voice.Reader.Dispose();
                voice = null;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    class SoundBuffer
    {
        public WaveOut Wave;
        public WaveFileReader Reader;

        public void Dispose()
        {
            Wave.Dispose();
            Reader.Dispose();
        }
    }
    class MisakiEQSound
    {
        public struct _SND
        {
            public SoundBuffer Earthquake_Break;
            public SoundBuffer Earthquake_Mid;
            public SoundBuffer Earthquake_Small;
            public SoundBuffer EEW_Info;
            public SoundBuffer EEW_Warn;
            public SoundBuffer Tsunami_Alert;
            public SoundBuffer Tsunami_Update;
        }
        public _SND SE = new _SND();
        public int AllDispose()//リソース開放できた数
        {
            int cnt = 0;
            Sound _s = new Sound();
            if (_s.Dispose(ref SE.Earthquake_Break)) cnt++;
            if (_s.Dispose(ref SE.Earthquake_Mid)) cnt++;
            if (_s.Dispose(ref SE.Earthquake_Small)) cnt++;
            if (_s.Dispose(ref SE.EEW_Info)) cnt++;
            if (_s.Dispose(ref SE.EEW_Warn)) cnt++;
            if (_s.Dispose(ref SE.Tsunami_Alert)) cnt++;
            if (_s.Dispose(ref SE.Tsunami_Update)) cnt++;
            return cnt;
        }
    }
}
