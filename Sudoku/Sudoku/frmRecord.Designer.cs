namespace Sudoku
{
    partial class frmRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblFileInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDifficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(150, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(550, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BẢNG XẾP HẠNG SUDOKU";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.lblSubtitle.Location = new System.Drawing.Point(165, 110);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(520, 55);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Xếp theo điểm cao nhất, rồi thời gian ngắn nhất.";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecords.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecords.ColumnHeadersHeight = 50;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRank,
            this.colPlayer,
            this.colDifficulty,
            this.colScore,
            this.colTime,
            this.colDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecords.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecords.EnableHeadersVisualStyles = false;
            this.dgvRecords.Location = new System.Drawing.Point(10, 200);
            this.dgvRecords.MultiSelect = false;
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.ReadOnly = true;
            this.dgvRecords.RowHeadersVisible = false;
            this.dgvRecords.RowHeadersWidth = 51;
            this.dgvRecords.RowTemplate.Height = 40;
            this.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecords.Size = new System.Drawing.Size(800, 360);
            this.dgvRecords.TabIndex = 2;
            // 
            // lblEmpty
            // 
            this.lblEmpty.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmpty.ForeColor = System.Drawing.Color.Gray;
            this.lblEmpty.Location = new System.Drawing.Point(85, 280);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(680, 40);
            this.lblEmpty.TabIndex = 3;
            this.lblEmpty.Text = "Chưa có kỷ lục. Hãy hoàn thành một ván Sudoku!";
            this.lblEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCount.ForeColor = System.Drawing.Color.Navy;
            this.lblCount.Location = new System.Drawing.Point(30, 600);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(600, 50);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Số ván thắng đã lưu: 0";
            // 
            // lblFileInfo
            // 
            this.lblFileInfo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFileInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblFileInfo.Location = new System.Drawing.Point(30, 630);
            this.lblFileInfo.Name = "lblFileInfo";
            this.lblFileInfo.Size = new System.Drawing.Size(280, 30);
            this.lblFileInfo.TabIndex = 5;
            this.lblFileInfo.Text = "Dữ liệu lưu tại:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(277, 712);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(230, 60);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // colRank
            // 
            this.colRank.FillWeight = 50F;
            this.colRank.HeaderText = "Hạng";
            this.colRank.MinimumWidth = 6;
            this.colRank.Name = "colRank";
            this.colRank.ReadOnly = true;
            this.colRank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPlayer
            // 
            this.colPlayer.FillWeight = 120F;
            this.colPlayer.HeaderText = "Người chơi";
            this.colPlayer.MinimumWidth = 6;
            this.colPlayer.Name = "colPlayer";
            this.colPlayer.ReadOnly = true;
            this.colPlayer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDifficulty
            // 
            this.colDifficulty.HeaderText = "Chế độ";
            this.colDifficulty.MinimumWidth = 6;
            this.colDifficulty.Name = "colDifficulty";
            this.colDifficulty.ReadOnly = true;
            this.colDifficulty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colScore
            // 
            this.colScore.FillWeight = 85F;
            this.colScore.HeaderText = "Điểm";
            this.colScore.MinimumWidth = 6;
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            this.colScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTime
            // 
            this.colTime.FillWeight = 95F;
            this.colTime.HeaderText = "Thời gian";
            this.colTime.MinimumWidth = 6;
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Ngày thắng";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(832, 853);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFileInfo);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecord";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bảng xếp hạng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblFileInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDifficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
    }
}