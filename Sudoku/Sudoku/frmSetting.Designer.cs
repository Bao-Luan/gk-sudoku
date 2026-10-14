namespace Sudoku
{
    partial class frmSetting
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbSound = new System.Windows.Forms.GroupBox();
            this.lblSound = new System.Windows.Forms.Label();
            this.rdbSoundOn = new System.Windows.Forms.RadioButton();
            this.rdbSoundOff = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbSound.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 22.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.Location = new System.Drawing.Point(105, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(480, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CÀI ĐẶT ÂM THANH";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbSound
            // 
            this.grbSound.BackColor = System.Drawing.Color.White;
            this.grbSound.Controls.Add(this.rdbSoundOff);
            this.grbSound.Controls.Add(this.rdbSoundOn);
            this.grbSound.Controls.Add(this.lblSound);
            this.grbSound.Location = new System.Drawing.Point(120, 110);
            this.grbSound.Name = "grbSound";
            this.grbSound.Size = new System.Drawing.Size(450, 220);
            this.grbSound.TabIndex = 1;
            this.grbSound.TabStop = false;
            // 
            // lblSound
            // 
            this.lblSound.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSound.ForeColor = System.Drawing.Color.Navy;
            this.lblSound.Location = new System.Drawing.Point(10, 40);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(175, 40);
            this.lblSound.TabIndex = 0;
            this.lblSound.Text = "Âm thanh";
            this.lblSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbSoundOn
            // 
            this.rdbSoundOn.AutoSize = true;
            this.rdbSoundOn.Checked = true;
            this.rdbSoundOn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbSoundOn.Location = new System.Drawing.Point(100, 120);
            this.rdbSoundOn.Name = "rdbSoundOn";
            this.rdbSoundOn.Size = new System.Drawing.Size(68, 33);
            this.rdbSoundOn.TabIndex = 1;
            this.rdbSoundOn.TabStop = true;
            this.rdbSoundOn.Text = "Bật";
            this.rdbSoundOn.UseVisualStyleBackColor = true;
            // 
            // rdbSoundOff
            // 
            this.rdbSoundOff.AutoSize = true;
            this.rdbSoundOff.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbSoundOff.Location = new System.Drawing.Point(290, 120);
            this.rdbSoundOff.Name = "rdbSoundOff";
            this.rdbSoundOff.Size = new System.Drawing.Size(66, 33);
            this.rdbSoundOff.TabIndex = 1;
            this.rdbSoundOff.Text = "Tắt";
            this.rdbSoundOff.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(260, 340);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(170, 55);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "ĐÓNG";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(672, 443);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grbSound);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cài đặt";
            this.grbSound.ResumeLayout(false);
            this.grbSound.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbSound;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.RadioButton rdbSoundOff;
        private System.Windows.Forms.RadioButton rdbSoundOn;
        private System.Windows.Forms.Button btnClose;
    }
}