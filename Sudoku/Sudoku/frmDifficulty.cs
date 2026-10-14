using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class frmDifficulty : Form
    {
        public string SelectedDifficulty { get; private set; }
        public frmDifficulty()
        {
            InitializeComponent();
        }

        private void pnlDifficulty_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 20;
            int width = pnlDifficulty.Width - 2;
            int height = pnlDifficulty.Height - 2;

            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(Color.Black, 2))
            {
                path.AddArc(1, 1, radius, radius, 180, 90);
                path.AddArc(width - radius, 1,
                            radius, radius, 270, 90);
                path.AddArc(width - radius, height - radius,
                            radius, radius, 0, 90);
                path.AddArc(1, height - radius,
                            radius, radius, 90, 90);

                path.CloseFigure();
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            SoundManager.Play("normal-click");   // +++
            SelectedDifficulty = "Easy";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            SoundManager.Play("normal-click");   // +++
            SelectedDifficulty = "Medium";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            SoundManager.Play("normal-click");   // +++
            SelectedDifficulty = "Hard";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
