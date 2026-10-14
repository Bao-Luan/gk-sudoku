using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class frmGame : Form
    {
        private string difficulty;
        private string playerName;
        private int[,] solution = new int[9, 9];
        private int[,] puzzle = new int[9, 9];
        private Random random = new Random();
        private int lives = 3;
        private int elapsedSeconds = 0;
        private Button selectedButton = null;
        private int score = 0;
        private bool isSoundOn = true; // Mặc định bật âm thanh
        private Image soundOnImage;
        private Image soundOffImage;

        // Đánh dấu hàng, cột và khối 3x3 đã được tính điểm
        private bool[] scoredRows = new bool[9];
        private bool[] scoredCols = new bool[9];
        private bool[,] scoredBoxes = new bool[3, 3];

        public frmGame()
        {
            InitializeComponent();

            SoundManager.InGame = true;                        // THÊM: vào màn chơi
            isSoundOn = SoundManager.GameMusicEnabled;
            LoadSoundImages();
            this.FormClosing += (s, e) =>
            {
                SoundManager.StopMusic();
                SoundManager.InGame = false;                   // THÊM: rời màn chơi
            };
        }

        public frmGame(string difficulty, string playerName) : this()
        {
            this.difficulty = difficulty;
            this.playerName = playerName;

            StartGame();
        }

        private void StartGame()
        {
            try
            {
                SoundManager.PlayLoop(difficulty.ToLower());
                selectedButton = null;
                elapsedSeconds = 0;
                lblTime.Text = "Thời gian: 00:00";
                lblWinTime.Text = "Thời gian: 00:00";
                score = 0;
                lblScoreX.Text = "0";

                Array.Clear(scoredRows, 0, scoredRows.Length);
                Array.Clear(scoredCols, 0, scoredCols.Length);
                Array.Clear(scoredBoxes, 0, scoredBoxes.Length);

                GenerateSudoku();

                int emptyCells = GetEmptyCells();
                RemoveNumbers(emptyCells);
                LoadPuzzle(puzzle);

                lblMode.Text = "Chế độ: " + GetDifficultyDisplayName();
                UpdateLivesDisplay();
                lblTime.Text = "Thời gian: 00:00";
                lblPlayerName.Text = playerName;

                gameTimer.Stop();
                gameTimer.Interval = 1000;
                gameTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tạo ván chơi mới: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (pnlWin.Visible || pnlGameOver.Visible) return;

            int n = 0;
            if (e.KeyCode >= Keys.D1 && e.KeyCode <= Keys.D9) n = e.KeyCode - Keys.D0;
            else if (e.KeyCode >= Keys.NumPad1 && e.KeyCode <= Keys.NumPad9) n = e.KeyCode - Keys.NumPad0;

            if (n > 0)
            {
                ProcessNumber(n);
                e.Handled = true;
            }
        }

        private bool IsSafe(int[,] board, int row, int col, int number)
        {
            // Kiem tra hang va cot
            for (int i = 0; i < 9; i++)
            {
                if (board[row, i] == number)
                    return false;

                if (board[i, col] == number)
                    return false;
            }

            // Kiem tra vung 3x3
            int startRow = (row / 3) * 3;
            int startCol = (col / 3) * 3;

            for (int r = startRow; r < startRow + 3; r++)
            {
                for (int c = startCol; c < startCol + 3; c++)
                {
                    if (board[r, c] == number)
                        return false;
                }
            }

            return true;
        }

        private bool FillBoard(int[,] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row, col] != 0)
                    {
                        continue;
                    }

                    List<int> numbers = new List<int>();

                    for (int i = 1; i <= 9; i++)
                    {
                        numbers.Add(i);
                    }

                    // Xao tron cac so ngau nhien
                    for (int i = numbers.Count - 1; i > 0; i--)
                    {
                        int j = random.Next(i + 1);

                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }

                    foreach (int number in numbers)
                    {
                        if (IsSafe(board, row, col, number))
                        {
                            board[row, col] = number;

                            if (FillBoard(board))
                            {
                                return true;
                            }

                            // Quay lui neu khong dien tiep duoc
                            board[row, col] = 0;
                        }
                    }

                    return false;
                }
            }

            return true;
        }

        private void GenerateSudoku()
        {
            solution = new int[9, 9];

            FillBoard(solution);

            puzzle = new int[9, 9];

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    puzzle[row, col] = solution[row, col];
                }
            }
        }

        private int GetEmptyCells()
        {
            switch (difficulty)
            {
                case "Easy":
                    return 35;

                case "Medium":
                    return 43;

                case "Hard":
                    return 51;

                default:
                    return 35;
            }
        }

        private int CountSolutions(int[,] board, int limit)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row, col] != 0) continue;

                    int count = 0;
                    for (int n = 1; n <= 9; n++)
                    {
                        if (IsSafe(board, row, col, n))
                        {
                            board[row, col] = n;
                            count += CountSolutions(board, limit);
                            board[row, col] = 0;
                            if (count >= limit) return count;
                        }
                    }
                    return count;
                }
            }
            return 1; // không còn ô trống: tìm được 1 nghiệm
        }

        private void RemoveNumbers(int emptyCells)
        {
            List<int> cells = Enumerable.Range(0, 81).ToList();
            for (int i = cells.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                int t = cells[i]; cells[i] = cells[j]; cells[j] = t;
            }

            int removed = 0;
            foreach (int idx in cells)
            {
                if (removed >= emptyCells) break;

                int r = idx / 9, c = idx % 9;
                int backup = puzzle[r, c];
                puzzle[r, c] = 0;

                if (CountSolutions(puzzle, 2) == 1) removed++;   // vẫn 1 nghiệm: giữ ô trống
                else puzzle[r, c] = backup;                      // nhiều nghiệm: trả số lại
            }
        }

        private void LoadPuzzle(int[,] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    Button cell = this.Controls.Find(
                        "btn" + row + col, true
                    ).FirstOrDefault() as Button;

                    if (cell == null)
                        continue;

                    if (board[row, col] == 0)
                    {
                        // O trong de: duoc phep nhap
                        cell.Text = "";
                        cell.Enabled = true;
                        cell.BackColor = Color.White;
                        cell.ForeColor = Color.Black;
                        cell.Tag = null;
                    }
                    else
                    {
                        // O co so san: nen xam, khong duoc sua
                        cell.Text = board[row, col].ToString();
                        cell.Enabled = false;
                        cell.BackColor = Color.WhiteSmoke;
                        cell.ForeColor = Color.Black;
                        cell.Tag = "Fixed";
                    }
                }
            }
        }

        private string GetDifficultyDisplayName()
        {
            switch (difficulty)
            {
                case "Easy":
                    return "Dễ";

                case "Medium":
                    return "Trung bình";

                case "Hard":
                    return "Khó";

                default:
                    return "Dễ";
            }
        }

        private int GetScoreMultiplier()
        {
            switch (difficulty)
            {
                case "Easy":
                    return 1;

                case "Medium":
                    return 2;

                case "Hard":
                    return 3;

                default:
                    return 1;
            }
        }

        // Điểm thưởng đổi từ số mạng còn lại khi thắng
        private int GetLivesBonus()
        {
            int[] easy = { 0, 200, 500, 1000 };   // index = số mạng còn
            int[] medium = { 0, 500, 1000, 2000 };
            int[] hard = { 0, 1000, 2500, 5000 };

            if (lives < 0) return 0;
            if (lives > 3) lives = 3;

            switch (difficulty)
            {
                case "Easy": return easy[lives];
                case "Medium": return medium[lives];
                case "Hard": return hard[lives];
                default: return 0;
            }
        }

        private bool IsRowCompleted(int row)
        {
            for (int col = 0; col < 9; col++)
            {
                Button cell = this.Controls.Find(
                    "btn" + row + col, true
                ).FirstOrDefault() as Button;

                if (cell == null || cell.Text != solution[row, col].ToString())
                    return false;
            }

            return true;
        }

        private bool IsColumnCompleted(int col)
        {
            for (int row = 0; row < 9; row++)
            {
                Button cell = this.Controls.Find(
                    "btn" + row + col, true
                ).FirstOrDefault() as Button;

                if (cell == null || cell.Text != solution[row, col].ToString())
                    return false;
            }

            return true;
        }

        private bool IsBoxCompleted(int row, int col)
        {
            int startRow = (row / 3) * 3;
            int startCol = (col / 3) * 3;

            for (int r = startRow; r < startRow + 3; r++)
            {
                for (int c = startCol; c < startCol + 3; c++)
                {
                    Button cell = this.Controls.Find(
                        "btn" + r + c, true
                    ).FirstOrDefault() as Button;

                    if (cell == null || cell.Text != solution[r, c].ToString())
                        return false;
                }
            }

            return true;
        }

        private void CheckAndAddScore(int row, int col)
        {
            int multiplier = GetScoreMultiplier();

            // Kiểm tra hàng ngang
            if (!scoredRows[row] && IsRowCompleted(row))
            {
                scoredRows[row] = true;
                score += 100 * multiplier;
            }

            // Kiểm tra cột dọc
            if (!scoredCols[col] && IsColumnCompleted(col))
            {
                scoredCols[col] = true;
                score += 100 * multiplier;
            }

            // Xác định đúng khối 3x3 chứa ô vừa điền
            int boxRow = row / 3;
            int boxCol = col / 3;

            if (!scoredBoxes[boxRow, boxCol] &&
                IsBoxCompleted(row, col))
            {
                scoredBoxes[boxRow, boxCol] = true;
                score += 300 * multiplier;
            }

            // Cập nhật điểm trên giao diện
            lblScoreX.Text = score.ToString();
        }

        private void UpdateLivesDisplay()
        {
            if (lives == 3)
                lblLives.Text = "Mạng: ♥ ♥ ♥";
            else if (lives == 2)
                lblLives.Text = "Mạng: ♥ ♥ ♡";
            else if (lives == 1)
                lblLives.Text = "Mạng: ♥ ♡ ♡";
            else
                lblLives.Text = "Mạng: ♡ ♡ ♡";
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Không cho thời gian chạy khi ván đã kết thúc
            if (pnlWin.Visible || pnlGameOver.Visible)
            {
                gameTimer.Stop();
                return;
            }

            elapsedSeconds++;

            int minutes = elapsedSeconds / 60;
            int seconds = elapsedSeconds % 60;

            lblTime.Text = $"Thời gian: {minutes:00}:{seconds:00}";
        }

        private void KhoaNut(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // Không khóa 4 nút trên hai bảng kết thúc
                if (ctrl == btnRetry || ctrl == btnHome1 ||
                    ctrl == btnPlayAgain || ctrl == btnHome2)
                    continue;

                if (ctrl is Button)
                {
                    ctrl.Enabled = false;
                }

                KhoaNut(ctrl);
            }
        }

        private void MoKhoaNut(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                // Không thay đổi trạng thái 4 nút trên hai bảng kết thúc
                if (ctrl == btnRetry || ctrl == btnHome1 ||
                    ctrl == btnPlayAgain || ctrl == btnHome2)
                    continue;

                if (ctrl is Button)
                {
                    ctrl.Enabled = true;
                }

                MoKhoaNut(ctrl);
            }
        }

        private void GameOver()
        {
            gameTimer.Stop();
            SoundManager.StopMusic();       // +++
            SoundManager.Play("lose");      // +++

            KhoaNut(this);

            pnlWin.Visible = false;
            pnlGameOver.Visible = true;

            btnRetry.Visible = true;
            btnHome1.Visible = true;
        }

        private void GameWon()
        {
            // Dừng đồng hồ
            gameTimer.Stop();
            SoundManager.StopMusic();       // +++
            SoundManager.Play("win");       // +++

            // Lấy số giây đã chơi và chuyển thành phút:giây
            int minutes = elapsedSeconds / 60;
            int seconds = elapsedSeconds % 60;

            // Hiển thị thời gian trên bảng chiến thắng
            lblWinTime.Text = $"Thời gian: {minutes:00}:{seconds:00}";

            // Đổi mạng còn lại thành điểm
            score += GetLivesBonus();          // +++
            lives = 0;                          // +++ mạng đã đổi hết thành điểm
            UpdateLivesDisplay();               // +++
            lblScoreX.Text = score.ToString();  // +++

            RecordManager.Save(new GameRecord        // +++
            {
                PlayerName = playerName,
                Difficulty = difficulty,
                Score = score,
                Seconds = elapsedSeconds,
                WinDate = DateTime.Now
            });

            // Hiện bảng chiến thắng
            pnlGameOver.Visible = false;
            pnlWin.Visible = true;
            pnlWin.BringToFront();

            btnPlayAgain.Visible = true;
            btnHome2.Visible = true;

            KhoaNut(this);
        }

        private bool IsPuzzleCompleted()
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    Button cell = this.Controls.Find(
                    "btn" + row + col, true
                    ).FirstOrDefault() as Button;

                    // Không tìm thấy ô hoặc ô chưa có số
                    if (cell == null || string.IsNullOrWhiteSpace(cell.Text))
                        return false;

                    int number;

                    // Kiểm tra số trong ô có hợp lệ và đúng đáp án
                    if (!int.TryParse(cell.Text, out number) ||
                        number != solution[row, col])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void btnCell_Click(object sender, EventArgs e)
        {
            Button cell = sender as Button;

            if (cell == null)
                return;

            if (cell.Tag != null &&
                (cell.Tag.ToString() == "Fixed" ||
                 cell.Tag.ToString() == "Correct"))
                return;

            // Khôi phục màu ô được chọn trước đó
            if (selectedButton != null)
            {
                // Chỉ ô trống người chơi đang nhập (Tag == null) mới trở lại màu trắng
                if (selectedButton.Tag == null)
                    selectedButton.BackColor = Color.White;
            }

            // Chọn ô mới
            selectedButton = cell;
            selectedButton.BackColor = Color.LemonChiffon;
        }

        private void ProcessNumber(int number)
        {
            try
            {
                // Nếu chưa chọn ô Sudoku
                if (selectedButton == null)
                {
                    MessageBox.Show("Vui lòng chọn một ô trống trước!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int row = int.Parse(selectedButton.Name.Substring(3, 1));
                int col = int.Parse(selectedButton.Name.Substring(4, 1));

                if (number == solution[row, col])
                {
                    SoundManager.Play("right");
                    selectedButton.Text = number.ToString();
                    selectedButton.BackColor = Color.LightGreen;
                    selectedButton.ForeColor = Color.DarkGreen;
                    selectedButton.Enabled = false;
                    selectedButton.Tag = "Correct";

                    CheckAndAddScore(row, col);
                    selectedButton = null;

                    if (IsPuzzleCompleted())
                    {
                        GameWon();
                        return;
                    }
                }
                else
                {
                    SoundManager.Play("wrong");
                    lives--;
                    UpdateLivesDisplay();

                    MessageBox.Show("Sai! Bạn mất 1 mạng.", "Sai đáp án",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (lives <= 0)
                    {
                        GameOver();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi nhập số: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            // Lấy số từ nút vừa nhấn
            Button numberButton = sender as Button;

            if (numberButton == null)
                return;

            int number;

            if (!int.TryParse(numberButton.Text, out number))
                return;

            // Giao việc xử lý cho hàm dùng chung
            ProcessNumber(number);
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            // Ẩn cả hai panel
            pnlGameOver.Visible = false;
            pnlWin.Visible = false;

            // Mở khóa các nút Sudoku
            MoKhoaNut(this);

            // Đặt lại số mạng
            lives = 3;
            UpdateLivesDisplay();

            // Bắt đầu ván mới
            StartGame();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            SoundManager.Play("normal-click");   // +++
            SoundManager.PlayLoop("menu");       // +++ phát lại nhạc menu

            frmMenu menu = Application.OpenForms
                .OfType<frmMenu>()
                .FirstOrDefault();

            if (menu != null)
            {
                menu.Show();
                menu.BringToFront();
            }
            else
            {
                menu = new frmMenu();
                menu.Show();
            }

            this.Close();
        }

        private void ptbAvatar_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic == null || pic.Width <= 0 || pic.Height <= 0)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 20;
            int width = pic.Width - 1;
            int height = pic.Height - 1;
            int d = radius * 2;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(1, 1, d, d, 180, 90);
                path.AddArc(width - d - 1, 1, d, d, 270, 90);
                path.AddArc(width - d - 1, height - d - 1,
                            d, d, 0, 90);
                path.AddArc(1, height - d - 1,
                            d, d, 90, 90);

                path.CloseFigure();

                // Cat goc PictureBox theo hinh bo tron
                pic.Region = new Region(path);

                // Ve vien xanh duong dam
                using (Pen pen = new Pen(Color.DarkBlue, 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void pnlEndGame_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = sender as Panel;

            if (pnl == null || pnl.Width <= 0 || pnl.Height <= 0)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 20;
            int width = pnl.Width - 1;
            int height = pnl.Height - 1;

            int d = radius * 2;

            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(Color.DarkBlue, 4))
            {
                // Tao hinh chu nhat bo goc
                path.AddArc(1, 1, d, d, 180, 90);
                path.AddArc(width - d - 1, 1, d, d, 270, 90);
                path.AddArc(width - d - 1, height - d - 1,
                            d, d, 0, 90);
                path.AddArc(1, height - d - 1, d, d, 90, 90);

                path.CloseFigure();

                // Cat phan goc vuong ben ngoai
                pnl.Region = new Region(path);

                // Ve vien bo goc
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Bạn muốn đổi 500 điểm lấy 1 lượt trợ giúp không?",
                    "Trợ giúp Sudoku", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                if (score < 500)
                {
                    MessageBox.Show("Bạn không đủ điểm!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<Button> emptyCells = new List<Button>();

                for (int row = 0; row < 9; row++)
                {
                    for (int col = 0; col < 9; col++)
                    {
                        Button cell = this.Controls.Find("btn" + row + col, true)
                            .FirstOrDefault() as Button;

                        if (cell != null &&
                            string.IsNullOrWhiteSpace(cell.Text) &&
                            cell.Tag == null &&
                            cell.BackColor != Color.Gray)
                        {
                            emptyCells.Add(cell);
                        }
                    }
                }

                if (emptyCells.Count == 0)
                {
                    MessageBox.Show("Không còn ô trống phù hợp để trợ giúp!");
                    return;
                }

                int randomIndex = random.Next(emptyCells.Count);
                SoundManager.Play("hint-click");
                Button hintCell = emptyCells[randomIndex];

                score -= 500;
                lblScoreX.Text = score.ToString();

                int hintRow = int.Parse(hintCell.Name.Substring(3, 1));
                int hintCol = int.Parse(hintCell.Name.Substring(4, 1));

                hintCell.Text = solution[hintRow, hintCol].ToString();
                hintCell.BackColor = Color.LightGreen;
                hintCell.ForeColor = Color.DarkGreen;
                hintCell.Enabled = false;
                hintCell.Tag = "Correct";

                CheckAndAddScore(hintRow, hintCol);

                if (selectedButton != null &&
                    selectedButton != hintCell &&
                    selectedButton.Tag == null)
                {
                    selectedButton.BackColor = Color.White;
                }

                selectedButton = null;

                if (IsPuzzleCompleted())
                {
                    GameWon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi dùng trợ giúp: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSoundImages()
        {
            try
            {
                soundOnImage = Properties.Resources.sound_on;
                soundOffImage = Properties.Resources.sound_off;
            }
            catch (Exception)
            {
                soundOnImage = null;
                soundOffImage = null;
            }
            UpdateSoundButton();
        }

        private void UpdateSoundButton()
        {
            btnSound.Image = null;
            btnSound.BackgroundImage = isSoundOn ? soundOnImage : soundOffImage;
            btnSound.BackgroundImageLayout = ImageLayout.Stretch;
            btnSound.Text = (soundOnImage == null) ? (isSoundOn ? "BẬT" : "TẮT") : "";
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            isSoundOn = !isSoundOn;
            SoundManager.GameMusicEnabled = isSoundOn;                    // +++
            if (!isSoundOn) SoundManager.StopMusic();            // +++
            else SoundManager.PlayLoop(difficulty.ToLower());    // +++ bật lại thì phát nhạc nền
            UpdateSoundButton();
        }
    }
}
