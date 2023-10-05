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
            dgvNhanVien = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            TenNhanVien = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            SDT = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            txtMaNhanVien = new TextBox();
            txtTenNhanVien = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            btnThemNhanVien = new Button();
            btnXoaNhanVien = new Button();
            btnSuaNhanVien = new Button();
            lblMaNhanVien = new Label();
            lblTenNhanVien = new Label();
            lblNgaySinh = new Label();
            lblEmail = new Label();
            lblSDT = new Label();
            lblDiaChi = new Label();
            toolTip1 = new ToolTip(components);
            dtpNgaySinh = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, TenNhanVien, NgaySinh, Email, SDT, DiaChi });
            dgvNhanVien.Location = new Point(20, 23);
            dgvNhanVien.Margin = new Padding(5, 6, 5, 6);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 62;
            dgvNhanVien.Size = new Size(1000, 385);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
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
            TenNhanVien.DataPropertyName = "TenNhanVien";
            TenNhanVien.HeaderText = "Tên Nhân Viên";
            TenNhanVien.MinimumWidth = 8;
            TenNhanVien.Name = "TenNhanVien";
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
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            // 
            // SDT
            // 
            SDT.DataPropertyName = "SDT";
            SDT.HeaderText = "Số Điện Thoại";
            SDT.MinimumWidth = 8;
            SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(133, 423);
            txtMaNhanVien.Margin = new Padding(5, 6, 5, 6);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(164, 31);
            txtMaNhanVien.TabIndex = 1;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(133, 473);
            txtTenNhanVien.Margin = new Padding(5, 6, 5, 6);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(164, 31);
            txtTenNhanVien.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(433, 423);
            txtEmail.Margin = new Padding(5, 6, 5, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(164, 31);
            txtEmail.TabIndex = 4;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(433, 473);
            txtSDT.Margin = new Padding(5, 6, 5, 6);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(164, 31);
            txtSDT.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(433, 523);
            txtDiaChi.Margin = new Padding(5, 6, 5, 6);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(164, 31);
            txtDiaChi.TabIndex = 6;
            // 
            // btnThemNhanVien
            // 
            btnThemNhanVien.Location = new Point(650, 423);
            btnThemNhanVien.Margin = new Padding(5, 6, 5, 6);
            btnThemNhanVien.Name = "btnThemNhanVien";
            btnThemNhanVien.Size = new Size(125, 44);
            btnThemNhanVien.TabIndex = 7;
            btnThemNhanVien.Text = "Thêm";
            btnThemNhanVien.UseVisualStyleBackColor = true;
            btnThemNhanVien.Click += btnThemNhanVien_Click;
            // 
            // btnXoaNhanVien
            // 
            btnXoaNhanVien.Location = new Point(650, 473);
            btnXoaNhanVien.Margin = new Padding(5, 6, 5, 6);
            btnXoaNhanVien.Name = "btnXoaNhanVien";
            btnXoaNhanVien.Size = new Size(125, 44);
            btnXoaNhanVien.TabIndex = 8;
            btnXoaNhanVien.Text = "Xóa";
            btnXoaNhanVien.UseVisualStyleBackColor = true;
            btnXoaNhanVien.Click += btnXoaNhanVien_Click;
            // 
            // btnSuaNhanVien
            // 
            btnSuaNhanVien.Location = new Point(650, 523);
            btnSuaNhanVien.Margin = new Padding(5, 6, 5, 6);
            btnSuaNhanVien.Name = "btnSuaNhanVien";
            btnSuaNhanVien.Size = new Size(125, 44);
            btnSuaNhanVien.TabIndex = 9;
            btnSuaNhanVien.Text = "Sửa";
            btnSuaNhanVien.UseVisualStyleBackColor = true;
            btnSuaNhanVien.Click += btnSuaNhanVien_Click;
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.AutoSize = true;
            lblMaNhanVien.Location = new Point(20, 429);
            lblMaNhanVien.Margin = new Padding(5, 0, 5, 0);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(70, 25);
            lblMaNhanVien.TabIndex = 10;
            lblMaNhanVien.Text = "Mã NV:";
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.AutoSize = true;
            lblTenNhanVien.Location = new Point(20, 479);
            lblTenNhanVien.Margin = new Padding(5, 0, 5, 0);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(71, 25);
            lblTenNhanVien.TabIndex = 11;
            lblTenNhanVien.Text = "Tên NV:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(20, 529);
            lblNgaySinh.Margin = new Padding(5, 0, 5, 0);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(95, 25);
            lblNgaySinh.TabIndex = 12;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(333, 429);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email:";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(333, 479);
            lblSDT.Margin = new Padding(5, 0, 5, 0);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(48, 25);
            lblSDT.TabIndex = 14;
            lblSDT.Text = "SĐT:";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(333, 529);
            lblDiaChi.Margin = new Padding(5, 0, 5, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(69, 25);
            lblDiaChi.TabIndex = 15;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(133, 528);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(164, 31);
            dtpNgaySinh.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 617);
            Controls.Add(dtpNgaySinh);
            Controls.Add(lblDiaChi);
            Controls.Add(lblSDT);
            Controls.Add(lblEmail);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblTenNhanVien);
            Controls.Add(lblMaNhanVien);
            Controls.Add(btnSuaNhanVien);
            Controls.Add(btnXoaNhanVien);
            Controls.Add(btnThemNhanVien);
            Controls.Add(txtDiaChi);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(txtTenNhanVien);
            Controls.Add(txtMaNhanVien);
            Controls.Add(dgvNhanVien);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Quản Lý Nhân Viên";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNhanVien;
        private TextBox txtMaNhanVien;
        private TextBox txtTenNhanVien;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private Button btnThemNhanVien;
        private Button btnXoaNhanVien;
        private Button btnSuaNhanVien;
        private Label lblMaNhanVien;
        private Label lblTenNhanVien;
        private Label lblNgaySinh;
        private Label lblEmail;
        private Label lblSDT;
        private Label lblDiaChi;
        private ToolTip toolTip1;
        private DateTimePicker dtpNgaySinh;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn TenNhanVien;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn DiaChi;
    }
}
