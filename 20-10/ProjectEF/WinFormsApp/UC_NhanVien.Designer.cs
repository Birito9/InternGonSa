namespace GUI
{
    partial class UC_NhanVien
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvNhanVien = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
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
            label7 = new Label();
            cbxChucVu = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, TenNhanVien, NgaySinh, Email, SDT, DiaChi, ChucVu });
            tableLayoutPanel1.SetColumnSpan(dgvNhanVien, 7);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(3, 3);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 62;
            dgvNhanVien.RowTemplate.Height = 33;
            dgvNhanVien.Size = new Size(1128, 497);
            dgvNhanVien.TabIndex = 0;
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
            // ChucVu
            // 
            ChucVu.DataPropertyName = "ChucVu";
            ChucVu.HeaderText = "Chức Vụ";
            ChucVu.MinimumWidth = 8;
            ChucVu.Name = "ChucVu";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28531F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2881641F));
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
            tableLayoutPanel1.Controls.Add(label7, 6, 1);
            tableLayoutPanel1.Controls.Add(cbxChucVu, 6, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.Size = new Size(1134, 681);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.Location = new Point(20, 614);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 50);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Location = new Point(181, 614);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 50);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.Location = new Point(342, 614);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 50);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnNhap
            // 
            btnNhap.Anchor = AnchorStyles.None;
            btnNhap.Location = new Point(503, 614);
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
            btnXuat.Location = new Point(664, 614);
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
            label1.Location = new Point(19, 510);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 6;
            label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(180, 510);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 7;
            label2.Text = "Tên Nhân viên";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(356, 510);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 8;
            label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(536, 510);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(663, 510);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 10;
            label5.Text = "Số Điện Thoại";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(851, 510);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 11;
            label6.Text = "Địa Chỉ";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Dock = DockStyle.Fill;
            txtMaNhanVien.Location = new Point(20, 553);
            txtMaNhanVien.Margin = new Padding(20, 10, 20, 10);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(121, 31);
            txtMaNhanVien.TabIndex = 12;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Dock = DockStyle.Fill;
            txtTenNhanVien.Location = new Point(181, 553);
            txtTenNhanVien.Margin = new Padding(20, 10, 20, 10);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(121, 31);
            txtTenNhanVien.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(503, 553);
            txtEmail.Margin = new Padding(20, 10, 20, 10);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(121, 31);
            txtEmail.TabIndex = 15;
            // 
            // txtSDT
            // 
            txtSDT.Dock = DockStyle.Fill;
            txtSDT.Location = new Point(664, 553);
            txtSDT.Margin = new Padding(20, 10, 20, 10);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(121, 31);
            txtSDT.TabIndex = 16;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Dock = DockStyle.Fill;
            txtDiaChi.Location = new Point(825, 553);
            txtDiaChi.Margin = new Padding(20, 10, 20, 10);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(121, 31);
            txtDiaChi.TabIndex = 17;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Dock = DockStyle.Fill;
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(332, 553);
            dtpNgaySinh.Margin = new Padding(10);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(141, 31);
            dtpNgaySinh.TabIndex = 18;
            // 
            // btnXuatJs
            // 
            btnXuatJs.Anchor = AnchorStyles.None;
            btnXuatJs.Location = new Point(825, 614);
            btnXuatJs.Name = "btnXuatJs";
            btnXuatJs.Size = new Size(120, 50);
            btnXuatJs.TabIndex = 19;
            btnXuatJs.Text = "Xuất Json";
            btnXuatJs.UseVisualStyleBackColor = true;
            btnXuatJs.Click += btnXuatJs_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(1011, 510);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 20;
            label7.Text = "Chức Vụ";
            // 
            // cbxChucVu
            // 
            cbxChucVu.Anchor = AnchorStyles.None;
            cbxChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxChucVu.FormattingEnabled = true;
            cbxChucVu.Location = new Point(969, 553);
            cbxChucVu.Name = "cbxChucVu";
            cbxChucVu.Size = new Size(162, 33);
            cbxChucVu.TabIndex = 21;
            // 
            // UC_NhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_NhanVien";
            Size = new Size(1134, 681);
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
        private Button btnXuatJs;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn ChucVu;
        private Label label7;
        private ComboBox cbxChucVu;
    }
}
