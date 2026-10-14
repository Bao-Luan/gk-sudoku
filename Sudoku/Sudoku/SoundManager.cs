using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class SoundManager
    {
        [DllImport("winmm.dll", CharSet = CharSet.Auto)]
        private static extern int mciSendString(string cmd, StringBuilder ret, int retLen, IntPtr hwnd);

        // Hai công tắc độc lập
        public static bool MenuMusicEnabled = true;   // điều khiển bởi Cài đặt (ngoài game)
        public static bool GameMusicEnabled = true;   // điều khiển bởi nút loa trong game

        // Đang ở trong màn chơi hay không (để hiệu ứng biết dùng công tắc nào)
        public static bool InGame = false;

        private static string bgmAlias = null;

        // Chống phát lặp: cùng một hiệu ứng không phát lại trong vòng 150 ms
        private static readonly Dictionary<string, int> lastPlayed = new Dictionary<string, int>();

        private static string Path_(string name)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Audio", name + ".mp3");
        }

        // Hiệu ứng ngắn
        public static void Play(string name)
        {
            try
            {
                bool enabled = InGame ? GameMusicEnabled : MenuMusicEnabled;
                if (!enabled) return;

                int now = Environment.TickCount;
                int last;
                if (lastPlayed.TryGetValue(name, out last) && now - last < 150)
                    return;
                lastPlayed[name] = now;

                string alias = "sfx_" + name;
                mciSendString("close " + alias, null, 0, IntPtr.Zero);
                mciSendString("open \"" + Path_(name) + "\" type mpegvideo alias " + alias, null, 0, IntPtr.Zero);
                mciSendString("play " + alias, null, 0, IntPtr.Zero);
            }
            catch (Exception)
            {
                // Lỗi âm thanh không được làm hỏng game
            }
        }

        // Nhạc nền lặp lại
        public static void PlayLoop(string name)
        {
            try
            {
                StopMusic();

                bool enabled = (name == "menu") ? MenuMusicEnabled : GameMusicEnabled;
                if (!enabled) return;

                bgmAlias = "bgm";
                mciSendString("open \"" + Path_(name) + "\" type mpegvideo alias bgm", null, 0, IntPtr.Zero);
                mciSendString("play bgm repeat", null, 0, IntPtr.Zero);
            }
            catch (Exception)
            {
            }
        }

        // Dừng nhạc nền
        public static void StopMusic()
        {
            try
            {
                if (bgmAlias == null) return;

                mciSendString("stop bgm", null, 0, IntPtr.Zero);
                mciSendString("close bgm", null, 0, IntPtr.Zero);
                bgmAlias = null;
            }
            catch (Exception)
            {
            }
        }

    }
}
