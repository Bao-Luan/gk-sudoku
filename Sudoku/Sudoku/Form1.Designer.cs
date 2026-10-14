namespace Sudoku
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tblMenu = new System.Windows.Forms.TableLayoutPanel();
            this.pnlName = new System.Windows.Forms.Panel();
            this.tblName = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.tblMenu.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.tblName.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.BackColor = System.Drawing.Color.Transparent;
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.58004F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.83992F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.58004F));
            this.tblMain.Controls.Add(this.pnlMenu, 1, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.38389F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.13744F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.320695F));
            this.tblMain.Size = new System.Drawing.Size(1062, 633);
            this.tblMain.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMenu.Controls.Add(this.tblMenu);
            this.pnlMenu.Location = new System.Drawing.Point(349, 189);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(363, 381);
            this.pnlMenu.TabIndex = 0;
            // 
            // tblMenu
            // 
            this.tblMenu.ColumnCount = 1;
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMenu.Controls.Add(this.pnlName, 0, 0);
            this.tblMenu.Controls.Add(this.btnHowToPlay, 0, 4);
            this.tblMenu.Controls.Add(this.btnSetting, 0, 3);
            this.tblMenu.Controls.Add(this.btnRecord, 0, 2);
            this.tblMenu.Controls.Add(this.btnPlay, 0, 1);
            this.tblMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMenu.Location = new System.Drawing.Point(0, 0);
            this.tblMenu.Name = "tblMenu";
            this.tblMenu.RowCount = 5;
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tblMenu.Size = new System.Drawing.Size(363, 381);
            this.tblMenu.TabIndex = 0;
            // 
            // pnlName
            // 
            this.pnlName.Controls.Add(this.tblName);
            this.pnlName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlName.Location = new System.Drawing.Point(3, 3);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(357, 100);
            this.pnlName.TabIndex = 0;
            this.pnlName.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlName_Paint);
            // 
            // tblName
            // 
            this.tblName.ColumnCount = 1;
            this.tblName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblName.Controls.Add(this.lblName, 0, 0);
            this.tblName.Controls.Add(this.txtName, 0, 1);
            this.tblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblName.Location = new System.Drawing.Point(0, 0);
            this.tblName.Name = "tblName";
            this.tblName.RowCount = 2;
            this.tblName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblName.Size = new System.Drawing.Size(357, 100);
            this.tblName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.ForeColor = System.Drawing.Color.Navy;
            this.lblName.Location = new System.Drawing.Point(48, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(261, 32);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nhập tên người chơi";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.Location = new System.Drawing.Point(32, 43);
            this.txtName.MaxLength = 10;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(292, 42);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHowToPlay.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHowToPlay.Location = new System.Drawing.Point(3, 313);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(357, 65);
            this.btnHowToPlay.TabIndex = 1;
            this.btnHowToPlay.Text = "Hướng dẫn";
            this.btnHowToPlay.UseVisualStyleBackColor = true;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetting.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSetting.Location = new System.Drawing.Point(3, 245);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(357, 62);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecord.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRecord.Location = new System.Drawing.Point(3, 177);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(357, 62);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.Text = "Kỷ lục";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlay.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPlay.Location = new System.Drawing.Point(3, 109);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(357, 62);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Chơi";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sudoku.Properties.Resources.sudoku_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 633);
            this.Controls.Add(this.tblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUDOKU";
            this.tblMain.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.tblMenu.ResumeLayout(false);
            this.pnlName.ResumeLayout(false);
            this.tblName.ResumeLayout(false);
            this.tblName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.TableLayoutPanel tblMenu;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.TableLayoutPanel tblName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnPlay;
    }
}

