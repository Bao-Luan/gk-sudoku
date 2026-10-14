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
    public partial class frmGuide : Form
    {
        public frmGuide()
        {
            InitializeComponent();
        }

        private void frmGuide_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SoundManager.Play("normal-click");   // +++
            this.Close();
        }
    }
}
