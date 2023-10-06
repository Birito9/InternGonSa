namespace FormOrderData_TrangThaiGiaoHang
{
    partial class UC_TrangThaiGiaoHang
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvFormOrderTrangThaiGiaoHang = new DataGridView();
            MaTrangThaiGiaoHang = new DataGridViewTextBoxColumn();
            TenTrangThai = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            txtTenTrangThai = new TextBox();
            txtMoTa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaTrangThaiGiaoHang = new TextBox();
            btnNhap = new Button();
            btnXuat = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFormOrderTrangThaiGiaoHang).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(dgvFormOrderTrangThaiGiaoHang, 0, 0);
            tableLayoutPanel1.Controls.Add(btnThem, 0, 3);
            tableLayoutPanel1.Controls.Add(btnXoa, 1, 3);
            tableLayoutPanel1.Controls.Add(btnSua, 2, 3);
            tableLayoutPanel1.Controls.Add(txtTenTrangThai, 1, 2);
            tableLayoutPanel1.Controls.Add(txtMoTa, 2, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Controls.Add(txtMaTrangThaiGiaoHang, 0, 2);
            tableLayoutPanel1.Controls.Add(btnNhap, 3, 2);
            tableLayoutPanel1.Controls.Add(btnXuat, 3, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60.472496F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.32158F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.6029625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.6029625F));
            tableLayoutPanel1.Size = new Size(970, 590);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvFormOrderTrangThaiGiaoHang
            // 
            dgvFormOrderTrangThaiGiaoHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFormOrderTrangThaiGiaoHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFormOrderTrangThaiGiaoHang.Columns.AddRange(new DataGridViewColumn[] { MaTrangThaiGiaoHang, TenTrangThai, MoTa });
            tableLayoutPanel1.SetColumnSpan(dgvFormOrderTrangThaiGiaoHang, 4);
            dgvFormOrderTrangThaiGiaoHang.Dock = DockStyle.Fill;
            dgvFormOrderTrangThaiGiaoHang.Location = new Point(3, 3);
            dgvFormOrderTrangThaiGiaoHang.Name = "dgvFormOrderTrangThaiGiaoHang";
            dgvFormOrderTrangThaiGiaoHang.RowHeadersWidth = 62;
            dgvFormOrderTrangThaiGiaoHang.RowTemplate.Height = 33;
            dgvFormOrderTrangThaiGiaoHang.Size = new Size(964, 350);
            dgvFormOrderTrangThaiGiaoHang.TabIndex = 0;
            dgvFormOrderTrangThaiGiaoHang.RowPostPaint += dgvFormOrderTrangThaiGiaoHang_RowPostPaint;
            dgvFormOrderTrangThaiGiaoHang.SelectionChanged += dgvFormOrderTrangThaiGiaoHang_SelectionChanged;
            // 
            // MaTrangThaiGiaoHang
            // 
            MaTrangThaiGiaoHang.DataPropertyName = "MaTrangThaiGiaoHang";
            MaTrangThaiGiaoHang.HeaderText = "Mã Trạng Thái Giao Hàng";
            MaTrangThaiGiaoHang.MinimumWidth = 8;
            MaTrangThaiGiaoHang.Name = "MaTrangThaiGiaoHang";
            // 
            // TenTrangThai
            // 
            TenTrangThai.DataPropertyName = "TenTrangThai";
            TenTrangThai.HeaderText = "Tên Trạng Thái";
            TenTrangThai.MinimumWidth = 8;
            TenTrangThai.Name = "TenTrangThai";
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "MoTa";
            MoTa.HeaderText = "Mô Tả";
            MoTa.MinimumWidth = 8;
            MoTa.Name = "MoTa";
            // 
            // btnThem
            // 
            btnThem.Dock = DockStyle.Fill;
            btnThem.Location = new Point(50, 517);
            btnThem.Margin = new Padding(50, 20, 50, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(142, 53);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.Location = new Point(292, 517);
            btnXoa.Margin = new Padding(50, 20, 50, 20);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(142, 53);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Dock = DockStyle.Fill;
            btnSua.Location = new Point(534, 517);
            btnSua.Margin = new Padding(50, 20, 50, 20);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(142, 53);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // txtTenTrangThai
            // 
            txtTenTrangThai.Dock = DockStyle.Fill;
            txtTenTrangThai.Location = new Point(272, 435);
            txtTenTrangThai.Margin = new Padding(30);
            txtTenTrangThai.Name = "txtTenTrangThai";
            txtTenTrangThai.Size = new Size(182, 31);
            txtTenTrangThai.TabIndex = 5;
            // 
            // txtMoTa
            // 
            txtMoTa.Dock = DockStyle.Fill;
            txtMoTa.Location = new Point(514, 435);
            txtMoTa.Margin = new Padding(30);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(182, 31);
            txtMoTa.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 366);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(222, 29);
            label1.TabIndex = 7;
            label1.Text = "Mã Trạng Thái";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(252, 366);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Size = new Size(222, 29);
            label2.TabIndex = 8;
            label2.Text = "Tên Trạng Thái";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(494, 366);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Size = new Size(222, 29);
            label3.TabIndex = 9;
            label3.Text = "Mô Tả";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaTrangThaiGiaoHang
            // 
            txtMaTrangThaiGiaoHang.Dock = DockStyle.Fill;
            txtMaTrangThaiGiaoHang.Location = new Point(30, 435);
            txtMaTrangThaiGiaoHang.Margin = new Padding(30);
            txtMaTrangThaiGiaoHang.Name = "txtMaTrangThaiGiaoHang";
            txtMaTrangThaiGiaoHang.Size = new Size(182, 31);
            txtMaTrangThaiGiaoHang.TabIndex = 4;
            // 
            // btnNhap
            // 
            btnNhap.Dock = DockStyle.Fill;
            btnNhap.Location = new Point(776, 425);
            btnNhap.Margin = new Padding(50, 20, 50, 20);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(144, 52);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Dock = DockStyle.Fill;
            btnXuat.Location = new Point(776, 517);
            btnXuat.Margin = new Padding(50, 20, 50, 20);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(144, 53);
            btnXuat.TabIndex = 11;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // UC_TrangThaiGiaoHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_TrangThaiGiaoHang";
            Size = new Size(970, 590);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFormOrderTrangThaiGiaoHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvFormOrderTrangThaiGiaoHang;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private TextBox txtMaTrangThaiGiaoHang;
        private TextBox txtTenTrangThai;
        private TextBox txtMoTa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnNhap;
        private Button btnXuat;
        private DataGridViewTextBoxColumn MaTrangThaiGiaoHang;
        private DataGridViewTextBoxColumn TenTrangThai;
        private DataGridViewTextBoxColumn MoTa;
    }
}
