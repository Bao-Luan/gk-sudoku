using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;   // THÊM

namespace Sudoku
{
    public class GameRecord
    {
        public string PlayerName { get; set; }
        public string Difficulty { get; set; }   // Easy / Medium / Hard
        public int Score { get; set; }
        public int Seconds { get; set; }
        public DateTime WinDate { get; set; }
    }
    public static class RecordManager
    {
        // File nằm cạnh file .exe (bin\Debug\records.txt)
        public static readonly string FilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "records.txt");

        // Ghi thêm 1 dòng vào cuối file (mỗi dòng là 1 ván thắng)
        public static void Save(GameRecord r)
        {
            try
            {
                string line = string.Join("|",
                    r.PlayerName,
                    r.Difficulty,
                    r.Score,
                    r.Seconds,
                    r.WinDate.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture));

                File.AppendAllText(FilePath, line + Environment.NewLine, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi file kỷ lục: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Đọc toàn bộ file, sắp xếp: điểm cao trước, nếu bằng điểm thì thời gian ngắn trước
        public static List<GameRecord> Load()
        {
            var list = new List<GameRecord>();

            try
            {
                if (!File.Exists(FilePath))
                    return list;

                foreach (string line in File.ReadAllLines(FilePath, Encoding.UTF8))
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] p = line.Split('|');
                    if (p.Length != 5) continue;   // bỏ qua dòng hỏng

                    int score, seconds;
                    DateTime date;

                    if (!int.TryParse(p[2], out score)) continue;
                    if (!int.TryParse(p[3], out seconds)) continue;
                    if (!DateTime.TryParseExact(p[4], "yyyy-MM-dd HH:mm:ss",
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out date)) continue;

                    list.Add(new GameRecord
                    {
                        PlayerName = p[0],
                        Difficulty = p[1],
                        Score = score,
                        Seconds = seconds,
                        WinDate = date
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể đọc file kỷ lục: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return list
                .OrderByDescending(r => r.Score)
                .ThenBy(r => r.Seconds)
                .ToList();
        }
    }
}
