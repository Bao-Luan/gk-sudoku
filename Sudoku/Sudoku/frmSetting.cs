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
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();

            // Hiển thị đúng trạng thái hiện tại khi mở form
            rdbSoundOn.Checked = SoundManager.MenuMusicEnabled;
            rdbSoundOff.Checked = !SoundManager.MenuMusicEnabled;

            rdbSoundOn.CheckedChanged += rdbSound_CheckedChanged;
            rdbSoundOff.CheckedChanged += rdbSound_CheckedChanged;
        }

        private void rdbSound_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;
            if (rdb == null || !rdb.Checked) return;

            if (rdb == rdbSoundOff)
            {
                SoundManager.StopMusic();         // tắt nhạc menu ngay lập tức
                SoundManager.MenuMusicEnabled = false;
            }
            else
            {
                SoundManager.MenuMusicEnabled = true;
                SoundManager.PlayLoop("menu");    // bật lại thì nhạc menu phát tiếp
                //SoundManager.Play("normal-click");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SoundManager.Play("normal-click");
            this.Close();
        }
    }
}
