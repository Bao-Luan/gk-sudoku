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
    public partial class frmRecord : Form
    {
        public frmRecord()
        {
            InitializeComponent();
            LoadRecords();
        }

        private void LoadRecords()
        {
            foreach (DataGridViewColumn col in dgvRecords.Columns)   // +++
                col.Visible = true;                                  // +++

            dgvRecords.Rows.Clear();

            var records = RecordManager.Load();

            int rank = 1;
            foreach (var r in records)
            {
                dgvRecords.Rows.Add(
                    rank,
                    r.PlayerName,
                    ToDisplayDifficulty(r.Difficulty),
                    r.Score,
                    string.Format("{0:00}:{1:00}", r.Seconds / 60, r.Seconds % 60),
                    r.WinDate.ToString("dd/MM/yyyy HH:mm"));
                rank++;
            }

            lblEmpty.Visible = records.Count == 0;
            dgvRecords.Visible = records.Count > 0;
            lblCount.Text = "Số ván thắng đã lưu: " + records.Count;
            lblFileInfo.Text = "Dữ liệu lưu tại: " + System.IO.Path.GetFileName(RecordManager.FilePath);
        }

        private string ToDisplayDifficulty(string d)
        {
            switch (d)
            {
                case "Easy": return "Dễ";
                case "Medium": return "Trung bình";
                case "Hard": return "Khó";
                default: return d;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SoundManager.Play("normal-click");   // +++
            this.Close();
        }
    }
}
