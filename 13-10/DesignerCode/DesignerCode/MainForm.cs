using GUI;
using System.Windows.Forms;

namespace DesignerCode
{
    public partial class MainForm : Form
    {
        private TabControl tc1 = new TabControl();
        private TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
        private TabPage tabPage1 = new TabPage();
        private TabPage tabPage2 = new TabPage();
        private GUI.UC_NhanVien UC_NhanVien1 = new GUI.UC_NhanVien();
        private GUI.UC_TrangThaiGiaoHang UC_TrangThaiGiaoHang1 = new GUI.UC_TrangThaiGiaoHang();

        public MainForm()
        {
            InitializeComponent();

            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));                                 
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tc1, 0, 0);
            tableLayoutPanel1.TabIndex = 0;

            // 
            // tc1
            // 
            tableLayoutPanel1.SetColumnSpan(tc1, 2);
            tc1.Controls.Add(tabPage1);
            tc1.Controls.Add(tabPage2);
            tc1.Dock = DockStyle.Fill;
            tc1.Name = "tc1";
            tc1.SelectedIndex = 0;
            tc1.TabIndex = 1;

            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(UC_NhanVien1);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Text = "Quản Lý Nhân Viên";
            tabPage1.UseVisualStyleBackColor = true;

            // 
            // UC_NhanVien
            // 
            UC_NhanVien1.Dock = DockStyle.Fill;
            UC_NhanVien1.Name = "UC_NhanVien";
            UC_NhanVien1.TabIndex = 2;

            //
            // tabPage2
            //

            tabPage2.Controls.Add(UC_TrangThaiGiaoHang1);
            tabPage2.Name = "tabPage1";
            tabPage2.Padding = new Padding(3);
            tabPage2.Text = "Trạng Thái Giao Hàng";
            tabPage2.UseVisualStyleBackColor = true;

            //
            // UC_TrangThaiGiaoHang
            //
            UC_TrangThaiGiaoHang1.Dock = DockStyle.Fill;
            UC_TrangThaiGiaoHang1.Name = "UC_TrangThaiGiaoHang";
            UC_TrangThaiGiaoHang1.TabIndex = 3;

            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(1280, 720);
            Name = "MainForm";
            Text = "Quản Lý Nhân Viên";

        }
    }
}