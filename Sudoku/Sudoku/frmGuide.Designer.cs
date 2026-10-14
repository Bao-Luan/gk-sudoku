namespace Sudoku
{
    partial class frmGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuide));
            this.pnlGuide = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblMembers = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblRuleContent = new System.Windows.Forms.Label();
            this.lblHintContent = new System.Windows.Forms.Label();
            this.lblLivesContent = new System.Windows.Forms.Label();
            this.lblInputContent = new System.Windows.Forms.Label();
            this.lblGoalContent = new System.Windows.Forms.Label();
            this.lblLivesTitle = new System.Windows.Forms.Label();
            this.lblHintTitle = new System.Windows.Forms.Label();
            this.lblInputTitle = new System.Windows.Forms.Label();
            this.lblRuleTitle = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlGuide.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGuide
            // 
            this.pnlGuide.AutoSize = true;
            this.pnlGuide.Controls.Add(this.pnlFooter);
            this.pnlGuide.Controls.Add(this.pnlContent);
            this.pnlGuide.Location = new System.Drawing.Point(25, 20);
            this.pnlGuide.Name = "pnlGuide";
            this.pnlGuide.Size = new System.Drawing.Size(950, 1000);
            this.pnlGuide.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Location = new System.Drawing.Point(25, 850);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(900, 80);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(360, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 60);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Controls.Add(this.lblMembers);
            this.pnlContent.Controls.Add(this.lblGroupName);
            this.pnlContent.Controls.Add(this.lblRuleContent);
            this.pnlContent.Controls.Add(this.lblHintContent);
            this.pnlContent.Controls.Add(this.lblLivesContent);
            this.pnlContent.Controls.Add(this.lblInputContent);
            this.pnlContent.Controls.Add(this.lblGoalContent);
            this.pnlContent.Controls.Add(this.lblLivesTitle);
            this.pnlContent.Controls.Add(this.lblHintTitle);
            this.pnlContent.Controls.Add(this.lblInputTitle);
            this.pnlContent.Controls.Add(this.lblRuleTitle);
            this.pnlContent.Controls.Add(this.lblGoal);
            this.pnlContent.Controls.Add(this.lblTitle);
            this.pnlContent.Location = new System.Drawing.Point(25, 20);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(900, 814);
            this.pnlContent.TabIndex = 1;
            // 
            // lblMembers
            // 
            this.lblMembers.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMembers.Location = new System.Drawing.Point(110, 770);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(600, 120);
            this.lblMembers.TabIndex = 3;
            this.lblMembers.Text = "Nguyễn Thanh Huy - 51.01.104.035\r\nOh Seung Jun - 51.01.104.039\r\nHuỳnh Trần Bảo Lu" +
    "ân - 51.01.104.056\r\nChu Lê Anh Tú - 51.01.104.111";
            // 
            // lblGroupName
            // 
            this.lblGroupName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGroupName.ForeColor = System.Drawing.Color.Black;
            this.lblGroupName.Location = new System.Drawing.Point(40, 730);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(600, 50);
            this.lblGroupName.TabIndex = 2;
            this.lblGroupName.Text = "Nhóm thực hiện: Tứ kỵ sĩ Khải Huyền";
            // 
            // lblRuleContent
            // 
            this.lblRuleContent.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRuleContent.Location = new System.Drawing.Point(70, 220);
            this.lblRuleContent.Name = "lblRuleContent";
            this.lblRuleContent.Size = new System.Drawing.Size(800, 129);
            this.lblRuleContent.TabIndex = 1;
            this.lblRuleContent.Text = resources.GetString("lblRuleContent.Text");
            // 
            // lblHintContent
            // 
            this.lblHintContent.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHintContent.Location = new System.Drawing.Point(70, 591);
            this.lblHintContent.Name = "lblHintContent";
            this.lblHintContent.Size = new System.Drawing.Size(800, 70);
            this.lblHintContent.TabIndex = 1;
            this.lblHintContent.Text = "Nhấn Gợi ý (tốn 500 điểm) để game tự điền đúng một ô trống ngẫu nhiên. Bật hoặc t" +
    "ắt âm thanh bằng nút loa trên màn hình chơi.";
            // 
            // lblLivesContent
            // 
            this.lblLivesContent.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLivesContent.Location = new System.Drawing.Point(70, 481);
            this.lblLivesContent.Name = "lblLivesContent";
            this.lblLivesContent.Size = new System.Drawing.Size(800, 60);
            this.lblLivesContent.TabIndex = 1;
            this.lblLivesContent.Text = "Bạn có 3 mạng. Mỗi lần nhập sai sẽ mất 1 mạng, hết mạng là thua. Thời gian được t" +
    "ính từ lúc bắt đầu ván chơi. Khi thắng, mạng còn lại được đổi thành điểm.";
            // 
            // lblInputContent
            // 
            this.lblInputContent.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblInputContent.Location = new System.Drawing.Point(70, 401);
            this.lblInputContent.Name = "lblInputContent";
            this.lblInputContent.Size = new System.Drawing.Size(800, 40);
            this.lblInputContent.TabIndex = 1;
            this.lblInputContent.Text = "Chọn một ô trống, sau đó nhấn nút số tương ứng bên dưới bảng.";
            // 
            // lblGoalContent
            // 
            this.lblGoalContent.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGoalContent.Location = new System.Drawing.Point(70, 140);
            this.lblGoalContent.Name = "lblGoalContent";
            this.lblGoalContent.Size = new System.Drawing.Size(800, 40);
            this.lblGoalContent.TabIndex = 1;
            this.lblGoalContent.Text = "Điền các số từ 1 đến 9 vào bảng Sudoku 9×9 sao cho đúng quy tắc.";
            // 
            // lblLivesTitle
            // 
            this.lblLivesTitle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLivesTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLivesTitle.Location = new System.Drawing.Point(50, 441);
            this.lblLivesTitle.Name = "lblLivesTitle";
            this.lblLivesTitle.Size = new System.Drawing.Size(400, 40);
            this.lblLivesTitle.TabIndex = 0;
            this.lblLivesTitle.Text = "4. Mạng và thời gian";
            // 
            // lblHintTitle
            // 
            this.lblHintTitle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHintTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHintTitle.Location = new System.Drawing.Point(50, 551);
            this.lblHintTitle.Name = "lblHintTitle";
            this.lblHintTitle.Size = new System.Drawing.Size(400, 40);
            this.lblHintTitle.TabIndex = 0;
            this.lblHintTitle.Text = "5. Chức năng hỗ trợ";
            // 
            // lblInputTitle
            // 
            this.lblInputTitle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblInputTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblInputTitle.Location = new System.Drawing.Point(50, 361);
            this.lblInputTitle.Name = "lblInputTitle";
            this.lblInputTitle.Size = new System.Drawing.Size(400, 40);
            this.lblInputTitle.TabIndex = 0;
            this.lblInputTitle.Text = "3. Cách nhập số";
            // 
            // lblRuleTitle
            // 
            this.lblRuleTitle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRuleTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRuleTitle.Location = new System.Drawing.Point(50, 180);
            this.lblRuleTitle.Name = "lblRuleTitle";
            this.lblRuleTitle.Size = new System.Drawing.Size(400, 40);
            this.lblRuleTitle.TabIndex = 0;
            this.lblRuleTitle.Text = "2. Quy tắc chơi";
            // 
            // lblGoal
            // 
            this.lblGoal.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGoal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGoal.Location = new System.Drawing.Point(50, 100);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(400, 40);
            this.lblGoal.TabIndex = 0;
            this.lblGoal.Text = "1. Mục tiêu";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.Location = new System.Drawing.Point(100, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(700, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HƯỚNG DẪN CHƠI SUDOKU";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 1094);
            this.ControlBox = false;
            this.Controls.Add(this.pnlGuide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmGuide_Load);
            this.pnlGuide.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGuide;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblRuleContent;
        private System.Windows.Forms.Label lblHintContent;
        private System.Windows.Forms.Label lblLivesContent;
        private System.Windows.Forms.Label lblInputContent;
        private System.Windows.Forms.Label lblGoalContent;
        private System.Windows.Forms.Label lblLivesTitle;
        private System.Windows.Forms.Label lblHintTitle;
        private System.Windows.Forms.Label lblInputTitle;
        private System.Windows.Forms.Label lblRuleTitle;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label lblMembers;
    }
}