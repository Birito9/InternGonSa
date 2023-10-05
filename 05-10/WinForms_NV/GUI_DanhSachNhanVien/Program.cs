using System;
using System.Windows.Forms;
using GUI_NhanVien;

namespace QuanLyNhanVienApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
