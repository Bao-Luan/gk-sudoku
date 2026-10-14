using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += (s, e) =>
                MessageBox.Show("Đã xảy ra lỗi: " + e.Exception.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMenu());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể khởi động game: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
