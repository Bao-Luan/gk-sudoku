namespace Sudoku
{
    partial class frmDifficulty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDifficulty));
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.pnlDifficulty = new System.Windows.Forms.Panel();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.pnlDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDifficulty.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDifficulty.Location = new System.Drawing.Point(70, 40);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(210, 40);
            this.lblDifficulty.TabIndex = 0;
            this.lblDifficulty.Text = "CHỌN CHẾ ĐỘ";
            this.lblDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDifficulty
            // 
            this.pnlDifficulty.Controls.Add(this.btnEasy);
            this.pnlDifficulty.Controls.Add(this.btnMedium);
            this.pnlDifficulty.Controls.Add(this.btnHard);
            this.pnlDifficulty.Location = new System.Drawing.Point(70, 100);
            this.pnlDifficulty.Name = "pnlDifficulty";
            this.pnlDifficulty.Size = new System.Drawing.Size(210, 200);
            this.pnlDifficulty.TabIndex = 1;
            this.pnlDifficulty.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDifficulty_Paint);
            // 
            // btnEasy
            // 
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEasy.Location = new System.Drawing.Point(25, 10);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(155, 45);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.Text = "Dễ";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedium.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMedium.Location = new System.Drawing.Point(25, 75);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(155, 45);
            this.btnMedium.TabIndex = 0;
            this.btnMedium.Text = "Trung bình";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHard.Location = new System.Drawing.Point(25, 140);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(155, 45);
            this.btnHard.TabIndex = 0;
            this.btnHard.Text = "Khó";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // frmDifficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(342, 353);
            this.Controls.Add(this.pnlDifficulty);
            this.Controls.Add(this.lblDifficulty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDifficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUDOKU";
            this.pnlDifficulty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Panel pnlDifficulty;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
    }
}