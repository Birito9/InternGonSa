namespace GUI
{
    partial class UC_QuanLyKho
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
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtMaKho = new WinFormsApp.Text_Box_Custom();
            txtTenKho = new WinFormsApp.Text_Box_Custom();
            txtDiaChiKho = new WinFormsApp.Text_Box_Custom();
            txtMaChiNhanh = new WinFormsApp.Text_Box_Custom();
            panel1 = new Panel();
            dgvQuanLyKho = new DataGridView();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuanLyKho).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Location = new Point(19, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(983, 74);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(btnSua, 1, 0);
            tableLayoutPanel3.Controls.Add(btnXoa, 2, 0);
            tableLayoutPanel3.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel3.Location = new Point(494, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(486, 68);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSua.BackColor = SystemColors.ActiveCaption;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Image = Properties.Resources.Edit;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(181, 15);
            btnSua.Margin = new Padding(20, 15, 20, 15);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(121, 38);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnXoa.BackColor = SystemColors.ActiveCaption;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Image = Properties.Resources.Delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(342, 15);
            btnXoa.Margin = new Padding(20, 15, 20, 15);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(124, 38);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnThem.BackColor = SystemColors.ActiveCaption;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Image = Properties.Resources.New;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(20, 15);
            btnThem.Margin = new Padding(20, 15, 20, 15);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(121, 38);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(238, 101, 37);
            label4.Location = new Point(4, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 38);
            label4.TabIndex = 9;
            label4.Text = "Kho hàng";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(txtMaKho, 0, 0);
            tableLayoutPanel1.Controls.Add(txtTenKho, 1, 0);
            tableLayoutPanel1.Controls.Add(txtDiaChiKho, 2, 0);
            tableLayoutPanel1.Controls.Add(txtMaChiNhanh, 3, 0);
            tableLayoutPanel1.Location = new Point(19, 130);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(983, 129);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // txtMaKho
            // 
            txtMaKho.AllowNull = true;
            txtMaKho.AllowWhiteSpace = true;
            txtMaKho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMaKho.AutoSize = true;
            txtMaKho.Error = "";
            txtMaKho.errorProvider1 = null;
            txtMaKho.Label = "Mã Kho";
            txtMaKho.Location = new Point(3, 3);
            txtMaKho.MinimumChar = 0;
            txtMaKho.Multiline = false;
            txtMaKho.Name = "txtMaKho";
            txtMaKho.ReadOnly = false;
            txtMaKho.Size = new Size(239, 123);
            txtMaKho.TabIndex = 0;
            txtMaKho.ValidationType = WinFormsApp.Text_Box_Custom.eValidationType.SpecialChar;
            // 
            // txtTenKho
            // 
            txtTenKho.AllowNull = true;
            txtTenKho.AllowWhiteSpace = true;
            txtTenKho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTenKho.AutoSize = true;
            txtTenKho.Error = "";
            txtTenKho.errorProvider1 = null;
            txtTenKho.Label = "Tên Kho";
            txtTenKho.Location = new Point(248, 3);
            txtTenKho.MinimumChar = 0;
            txtTenKho.Multiline = false;
            txtTenKho.Name = "txtTenKho";
            txtTenKho.ReadOnly = false;
            txtTenKho.Size = new Size(239, 123);
            txtTenKho.TabIndex = 1;
            txtTenKho.ValidationType = WinFormsApp.Text_Box_Custom.eValidationType.SpecialChar;
            // 
            // txtDiaChiKho
            // 
            txtDiaChiKho.AllowNull = true;
            txtDiaChiKho.AllowWhiteSpace = true;
            txtDiaChiKho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDiaChiKho.AutoSize = true;
            txtDiaChiKho.Error = "";
            txtDiaChiKho.errorProvider1 = null;
            txtDiaChiKho.Label = "Địa Chỉ Kho";
            txtDiaChiKho.Location = new Point(493, 3);
            txtDiaChiKho.MinimumChar = 0;
            txtDiaChiKho.Multiline = false;
            txtDiaChiKho.Name = "txtDiaChiKho";
            txtDiaChiKho.ReadOnly = false;
            txtDiaChiKho.Size = new Size(239, 123);
            txtDiaChiKho.TabIndex = 2;
            txtDiaChiKho.ValidationType = WinFormsApp.Text_Box_Custom.eValidationType.SpecialChar;
            // 
            // txtMaChiNhanh
            // 
            txtMaChiNhanh.AllowNull = true;
            txtMaChiNhanh.AllowWhiteSpace = true;
            txtMaChiNhanh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMaChiNhanh.AutoSize = true;
            txtMaChiNhanh.Error = "";
            txtMaChiNhanh.errorProvider1 = null;
            txtMaChiNhanh.Label = "Mã Chi Nhánh";
            txtMaChiNhanh.Location = new Point(738, 3);
            txtMaChiNhanh.MinimumChar = 0;
            txtMaChiNhanh.Multiline = false;
            txtMaChiNhanh.Name = "txtMaChiNhanh";
            txtMaChiNhanh.ReadOnly = false;
            txtMaChiNhanh.Size = new Size(242, 123);
            txtMaChiNhanh.TabIndex = 3;
            txtMaChiNhanh.ValidationType = WinFormsApp.Text_Box_Custom.eValidationType.SpecialChar;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(dgvQuanLyKho);
            panel1.Location = new Point(19, 297);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 347);
            panel1.TabIndex = 3;
            // 
            // dgvQuanLyKho
            // 
            dgvQuanLyKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuanLyKho.Dock = DockStyle.Fill;
            dgvQuanLyKho.Location = new Point(0, 0);
            dgvQuanLyKho.Name = "dgvQuanLyKho";
            dgvQuanLyKho.RowHeadersWidth = 62;
            dgvQuanLyKho.RowTemplate.Height = 33;
            dgvQuanLyKho.Size = new Size(983, 347);
            dgvQuanLyKho.TabIndex = 0;
            // 
            // UC_QuanLyKho
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "UC_QuanLyKho";
            Size = new Size(1023, 662);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuanLyKho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private WinFormsApp.Text_Box_Custom txtMaKho;
        private WinFormsApp.Text_Box_Custom txtTenKho;
        private WinFormsApp.Text_Box_Custom txtDiaChiKho;
        private WinFormsApp.Text_Box_Custom txtMaChiNhanh;
        private Panel panel1;
        private DataGridView dgvQuanLyKho;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}
