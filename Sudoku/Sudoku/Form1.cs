using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            SoundManager.PlayLoop("menu");
        }

        private void pnlName_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //*

            int radius = 15;
            int width = pnlName.Width - 2;
            int height = pnlName.Height - 2;

            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            using (var pen = new Pen(Color.DodgerBlue, 2))
            {
                path.AddArc(1, 1, radius, radius, 180, 90);
                path.AddArc(width - radius, 1, radius, radius, 270, 90);
                path.AddArc(width - radius, height - radius,
                            radius, radius, 0, 90);
                path.AddArc(1, height - radius,
                            radius, radius, 90, 90);

                path.CloseFigure();
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép phím Backspace để xóa
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            // Chỉ cho phép chữ cái tiếng Anh và chữ số
            if (!((e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||
                  (e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                  (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string oldText = txtName.Text;
            string newText = "";

            foreach (char c in oldText)
            {
                if ((c >= 'A' && c <= 'Z') ||
                    (c >= 'a' && c <= 'z') ||
                    (c >= '0' && c <= '9'))
                {
                    newText += c;
                }
            }

            if (oldText != newText)
            {
                int cursorPosition = txtName.SelectionStart;

                txtName.Text = newText;

                txtName.SelectionStart =
                    Math.Min(cursorPosition, newText.Length);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            SoundManager.Play("normal-click");   // +++
            // Nếu chưa nhập tên thì mặc định là Guest
            string playerName = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(playerName))
            {
                playerName = "Guest";
            }
            // Mở Form chọn chế độ
            using (frmDifficulty difficultyForm = new frmDifficulty())
            {
                if (difficultyForm.ShowDialog() == DialogResult.OK)
                {
                    string difficulty = difficultyForm.SelectedDifficulty;

                    this.Hide();

                    using (frmGame gameForm = new frmGame(difficulty, playerName))
                    {
                        gameForm.ShowDialog();
                    }

                    this.Show();

                    SoundManager.PlayLoop("menu");   // đặt ở đây, sau dấu } đóng của using
                }
            }
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            SoundManager.Play("normal-click");   // +++
            frmGuide guides = new frmGuide();
            guides.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SoundManager.Play("normal-click");   // +++
            frmSetting setting = new frmSetting();
            setting.ShowDialog(this);
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            SoundManager.Play("normal-click");   // +++
            frmRecord records = new frmRecord();
            records.ShowDialog(this);
        }
    }
}
