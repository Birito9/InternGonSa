namespace GUI_QuanLyNhanVien
{
    partial class uc_QuanLyNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvNhanVien = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMaNhanVien = new TextBox();
            txtTenNhanVien = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            btnXuatJs = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, TenNhanVien, NgaySinh, Email, SDT, DiaChi });
            tableLayoutPanel1.SetColumnSpan(dgvNhanVien, 6);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(3, 3);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 62;
            dgvNhanVien.RowTemplate.Height = 33;
            dgvNhanVien.Size = new Size(1033, 496);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.RowPostPaint += dgvNhanVien_RowPostPaint;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã Nhân Viên";
            MaNhanVien.MinimumWidth = 8;
            MaNhanVien.Name = "MaNhanVien";
            // 
            // TenNhanVien
            // 
            TenNhanVien.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Tên Nhân Viên";
            TenNhanVien.MinimumWidth = 8;
            TenNhanVien.Name = "TenNhanVien";
            TenNhanVien.Width = 160;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.MinimumWidth = 8;
            NgaySinh.Name = "NgaySinh";
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.Width = 90;
            // 
            // SDT
            // 
            SDT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SDT.DataPropertyName = "SDT";
            SDT.HeaderText = "Số Điện Thoại";
            SDT.MinimumWidth = 8;
            SDT.Name = "SDT";
            SDT.Width = 145;
            // 
            // DiaChi
            // 
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            DiaChi.Width = 74;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666718F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Controls.Add(dgvNhanVien, 0, 0);
            tableLayoutPanel1.Controls.Add(btnThem, 0, 3);
            tableLayoutPanel1.Controls.Add(btnXoa, 1, 3);
            tableLayoutPanel1.Controls.Add(btnSua, 2, 3);
            tableLayoutPanel1.Controls.Add(btnNhap, 3, 3);
            tableLayoutPanel1.Controls.Add(btnXuat, 4, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Controls.Add(label4, 3, 1);
            tableLayoutPanel1.Controls.Add(label5, 4, 1);
            tableLayoutPanel1.Controls.Add(label6, 5, 1);
            tableLayoutPanel1.Controls.Add(txtMaNhanVien, 0, 2);
            tableLayoutPanel1.Controls.Add(txtTenNhanVien, 1, 2);
            tableLayoutPanel1.Controls.Add(txtEmail, 3, 2);
            tableLayoutPanel1.Controls.Add(txtSDT, 4, 2);
            tableLayoutPanel1.Controls.Add(txtDiaChi, 5, 2);
            tableLayoutPanel1.Controls.Add(dtpNgaySinh, 2, 2);
            tableLayoutPanel1.Controls.Add(btnXuatJs, 5, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.2720947F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.754772F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.516887F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.160059F));
            tableLayoutPanel1.Size = new Size(1039, 681);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.Location = new Point(26, 617);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 50);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThemNhanVien_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Location = new Point(199, 617);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 50);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoaNhanVien_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.Location = new Point(372, 617);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 50);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSuaNhanVien_Click;
            // 
            // btnNhap
            // 
            btnNhap.Anchor = AnchorStyles.None;
            btnNhap.Location = new Point(545, 617);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(120, 50);
            btnNhap.TabIndex = 4;
            btnNhap.Text = "Nhập Excel";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.None;
            btnXuat.Location = new Point(718, 617);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(120, 50);
            btnXuat.TabIndex = 5;
            btnXuat.Text = "Xuất Excel";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(25, 512);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 6;
            label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(198, 512);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 7;
            label2.Text = "Tên Nhân viên";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(386, 512);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 8;
            label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(578, 512);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(717, 512);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 10;
            label5.Text = "Số Điện Thoại";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(918, 512);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 11;
            label6.Text = "Địa Chỉ";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Dock = DockStyle.Fill;
            txtMaNhanVien.Location = new Point(20, 557);
            txtMaNhanVien.Margin = new Padding(20, 10, 20, 10);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(133, 31);
            txtMaNhanVien.TabIndex = 12;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Dock = DockStyle.Fill;
            txtTenNhanVien.Location = new Point(193, 557);
            txtTenNhanVien.Margin = new Padding(20, 10, 20, 10);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(133, 31);
            txtTenNhanVien.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(539, 557);
            txtEmail.Margin = new Padding(20, 10, 20, 10);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(133, 31);
            txtEmail.TabIndex = 15;
            // 
            // txtSDT
            // 
            txtSDT.Dock = DockStyle.Fill;
            txtSDT.Location = new Point(712, 557);
            txtSDT.Margin = new Padding(20, 10, 20, 10);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(133, 31);
            txtSDT.TabIndex = 16;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Dock = DockStyle.Fill;
            txtDiaChi.Location = new Point(885, 557);
            txtDiaChi.Margin = new Padding(20, 10, 20, 10);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(134, 31);
            txtDiaChi.TabIndex = 17;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Dock = DockStyle.Fill;
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(356, 557);
            dtpNgaySinh.Margin = new Padding(10);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(153, 31);
            dtpNgaySinh.TabIndex = 18;
            // 
            // btnXuatJs
            // 
            btnXuatJs.Anchor = AnchorStyles.None;
            btnXuatJs.Location = new Point(892, 617);
            btnXuatJs.Name = "btnXuatJs";
            btnXuatJs.Size = new Size(120, 50);
            btnXuatJs.TabIndex = 19;
            btnXuatJs.Text = "Xuất Json";
            btnXuatJs.UseVisualStyleBackColor = true;
            btnXuatJs.Click += btnXuatJs_Click;
            // 
            // uc_QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "uc_QuanLyNhanVien";
            Size = new Size(1039, 681);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvNhanVien;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnNhap;
        private Button btnXuat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMaNhanVien;
        private TextBox txtTenNhanVien;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private DateTimePicker dtpNgaySinh;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn DiaChi;
        private Button btnXuatJs;
    }
}
