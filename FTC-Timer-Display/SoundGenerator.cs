﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using System.IO;
using System.Diagnostics;
using System.Speech;
using System.Speech.Synthesis;

namespace FTC_Timer_Display
{
    public static class SoundGenerator
    {
        static SoundGenerator()
        {
            
        }

        // Sound player settings & objects
        public static readonly string AppPath = AppDomain.CurrentDomain.BaseDirectory;
        public static readonly string SoundsFolder = String.Format(@"{0}\{1}", AppPath, @"Sounds\GameSounds");
        public static readonly string NumberFolder = String.Format(@"{0}\{1}", AppPath, @"Sounds\Numbers");
        private static Dictionary<string, SoundPlayer> sounds = new Dictionary<string, SoundPlayer>();

        public static event EventHandler<int> soundsPercentChange;
        private static AutoResetEvent wait = new AutoResetEvent(false);

        public static List<string> availableSounds
        {
            get
            {
                return sounds.Keys.ToList<string>();
            }
        }

        // Synth Settings & Objects
        private static SpeechSynthesizer voice;
        public static int voiceOutputVolume
        {
            get { return voice == null ? 0 : voice.Volume; }
            set { if (voice != null) voice.Volume = Math.Min(100, Math.Max(0, value)); }
        }
        public static int voiceOutputRate
        {
            get { return voice == null ? 0 : voice.Rate; }
            set { if(voice != null) voice.Rate = Math.Min(10, Math.Max(-10, value)); }
        }
        // Shared
        public static bool isMuted { get; set; }

        public static bool isInit { get; private set; }
        public static bool voiceReady { get { return voice != null; } }

        public static void init(EventHandler<int> percentChangeHandler)
        {
            // Handler
            soundsPercentChange += percentChangeHandler;
            // Initialize Required Sound Files
            if (!initSoundFiles(SoundsFolder)) log("Failed to load Game Sounds", new Exception());
            // Initialize optional numbers
            if (!initSoundFiles(NumberFolder)) log("Failed to load Number Sounds", new Exception());
            // Load all files into memory
            loadSounds();

            try
            {
                // Synth
                voice = new SpeechSynthesizer();
                voice.Volume = 100;
            }
            catch (Exception ex)
            {
                log("Failed to Initialize Voice Synth.", "SoundGen", ex);
            }
            isInit = true;
        }

        private static bool initSoundFiles(string path)
        {
            try
            {
                // Sound files - Load from given directory
                if (!Directory.Exists(path)) return false;
                string[] files = Directory.GetFiles(path);
                log("Loading {0} sounds..", files.Length);
                foreach (string s in files)
                {
                    string key = (Path.GetFileName(s).Split('.'))[0].ToLower();
                    SoundPlayer player = new SoundPlayer(s);
                    player.Tag = key;
                    player.LoadCompleted += SoundLoadCompleteCallback;
                    sounds.Add(key, player);
                }
                log("Loaded.");
                return true;
            }
            catch(Exception ex)
            {
                log("Exception initializing sound files", ex);
                return false;
            }
        }
        /// <summary>
        /// Internal function to log data from the class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        private static void log(string message, params object[] args)
        {
            string myName = string.Format("SoundGen");
            LogMgr.logger.Info(LogMgr.make(message, myName, 0, args));
        }
        /// <summary>
        /// Internal function to log data from this class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        /// <param name="args">The arguments.</param>
        private static void log(string message, Exception ex, params object[] args)
        {
            string msg = LogMgr.make(message, "SoundGen", 0, args);
            LogMgr.logger.Error(msg, ex);
        }
        /// <summary>
        /// Loads the sounds from files.
        /// </summary>
        private static void loadSounds()
        {
            int loadedCount = 0;
            foreach (SoundPlayer s in sounds.Values)
            {
                s.Load();
                wait.WaitOne();
                wait.Reset();
                loadedCount++;
                decimal dPercent = ((decimal)loadedCount / (decimal)sounds.Count) * 100;
                int iPercent = (int)dPercent;
                if (soundsPercentChange != null)
                {
                    EventHandler<int> handler = soundsPercentChange;
                    handler(null, iPercent);
                }
            }
        }

        public static void StopAll()
        {
            try
            {
                foreach (SoundPlayer player in sounds.Values) player.Stop();
                voice.SpeakAsyncCancelAll();
            }
            catch { }
        }

        public static void PlaySound(SoundPackage package)
        {
            switch (package.soundMethod)
            {
                case SoundPackage.SoundMethods.SoundFile:
                    log("Playing sound file '{0}'.", package.dataString);
                    PlaySoundFile(package.dataString, package.loop);
                    break;
                case SoundPackage.SoundMethods.FileToSpeech:
                    log("Speaking contents of file '{0}'.", package.dataString);
                    ReadFile(package.dataString);
                    break;
                case SoundPackage.SoundMethods.TextToSpeech:
                    log("Speaking direct TTS '{0}'.", package.dataString);
                    Speak(package.dataString);
                    break;
            }
        }
        // Sounce player functions
        private static void SoundLoadCompleteCallback(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            SoundPlayer player = (SoundPlayer)sender;
            string file = player.Tag == null ? "UNKNOWN" : player.Tag.ToString();
            wait.Set();
        }

        private static void PlaySoundFile(string name, bool loop)
        {
            try
            {
                if (isMuted) return;
                if (!isInit) throw new Exception("Sound Generation not initialized before call. This should never happen. I hope.");
                name = name.ToLower();
                if (sounds.ContainsKey(name))
                {
                    if (!loop) sounds[name].Play();
                    else sounds[name].PlayLooping();
                }
            }
            catch (Exception ex)
            {
                log("Exception playing sound '{0}'.", ex, name);
            }
        }

        // Voice Synth Functions
        private static void Speak(string s)
        {
            if (voice == null) return;
            if (!isMuted) voice.SpeakAsync(s);
        }

        private static bool ReadFile(string path)
        {
            if (voice == null) return false;
            try
            {
                if (isMuted) return true;
                string s = File.ReadAllText(path);
                Speak(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string TimeSpanToString(TimeSpan ts)
        {
            StringBuilder sb = new StringBuilder();
            // Hours
            if (ts.Hours == 1) sb.Append("1 Hour");
            else if (ts.Hours > 1) sb.Append(string.Format("{0} Hours", ts.Hours));
            if (ts.Hours != 0 && (ts.Minutes != 0 || ts.Seconds != 0)) sb.Append(", ");
            // Minutes
            if (ts.Minutes == 1) sb.Append("1 Minute");
            else if (ts.Minutes > 1) sb.Append(string.Format("{0} Minutes", ts.Minutes));
            if (ts.Minutes != 0 && ts.Seconds != 0) sb.Append(", ");
            // Seconds
            if (ts.Seconds > 0 && (ts.Hours > 0 || ts.Minutes > 0))
            {
                if (ts.Seconds == 1) sb.Append("1 Second");
                else sb.Append(string.Format("{0} Seconds", ts.Seconds));
            }
            else if (ts.Seconds > 0) sb.Append(ts.Seconds.ToString());
            // Return
            if (sb.Length == 0) return "";
            return sb.ToString();
        }

        [Serializable]
        public class SoundPackage
        {
            public string dataString { get; private set; }
            public SoundMethods soundMethod { get; private set; }
            public bool loop = false;

            public SoundPackage(SoundMethods method, string str)
            {
                dataString = str;
                soundMethod = method;
            }

            public enum SoundMethods
            {
                SoundFile,
                FileToSpeech,
                TextToSpeech
            }

            public bool soundCanPlay
            {
                get
                {
                    switch (this.soundMethod)
                    {
                        case SoundMethods.FileToSpeech:
                            if (File.Exists(dataString)) return true;
                            return false;
                        case SoundMethods.TextToSpeech:
                            return SoundGenerator.voiceReady;
                        case SoundMethods.SoundFile:
                            if (SoundGenerator.sounds.ContainsKey(dataString.ToLower())) return true;
                            return false;
                        default:
                            return false;
                    }
                }
            }
        }
    }
}
