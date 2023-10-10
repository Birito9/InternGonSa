namespace GUI_NhanVien
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            tc1 = new TabControl();
            tabPage1 = new TabPage();
            uc_QuanLyNhanVien1 = new GUI_QuanLyNhanVien.uc_QuanLyNhanVien();
            tabPage2 = new TabPage();
            uC_TrangThaiGiaoHang1 = new FormOrderData_TrangThaiGiaoHang.UC_TrangThaiGiaoHang();
            tableLayoutPanel1 = new TableLayoutPanel();
            tc1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tc1
            // 
            tableLayoutPanel1.SetColumnSpan(tc1, 2);
            tc1.Controls.Add(tabPage1);
            tc1.Controls.Add(tabPage2);
            tc1.Dock = DockStyle.Fill;
            tc1.Location = new Point(3, 3);
            tc1.Name = "tc1";
            tc1.SelectedIndex = 0;
            tc1.Size = new Size(1252, 658);
            tc1.TabIndex = 0;
            tc1.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(uc_QuanLyNhanVien1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1244, 620);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản Lý Nhân Viên";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // uc_QuanLyNhanVien1
            // 
            uc_QuanLyNhanVien1.Dock = DockStyle.Fill;
            uc_QuanLyNhanVien1.Location = new Point(3, 3);
            uc_QuanLyNhanVien1.Name = "uc_QuanLyNhanVien1";
            uc_QuanLyNhanVien1.Size = new Size(1238, 614);
            uc_QuanLyNhanVien1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(uC_TrangThaiGiaoHang1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1244, 620);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Trạng Thái Giao Hàng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // uC_TrangThaiGiaoHang1
            // 
            uC_TrangThaiGiaoHang1.Dock = DockStyle.Fill;
            uC_TrangThaiGiaoHang1.Location = new Point(3, 3);
            uC_TrangThaiGiaoHang1.Name = "uC_TrangThaiGiaoHang1";
            uC_TrangThaiGiaoHang1.Size = new Size(1238, 614);
            uC_TrangThaiGiaoHang1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tc1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1258, 664);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 664);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(1280, 720);
            Name = "MainForm";
            Text = "Quản Lý Nhân Viên";
            tc1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ToolTip toolTip1;
        private TabControl tc1;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tabPage1;
        private GUI_QuanLyNhanVien.uc_QuanLyNhanVien uc_QuanLyNhanVien1;
        private TabPage tabPage2;
        private FormOrderData_TrangThaiGiaoHang.UC_TrangThaiGiaoHang uC_TrangThaiGiaoHang1;
    }
}
