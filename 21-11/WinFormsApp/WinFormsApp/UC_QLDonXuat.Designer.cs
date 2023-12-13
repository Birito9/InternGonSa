namespace GUI
{
    partial class UC_QLDonXuat
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
            panel1 = new Panel();
            btnQLDX_Back = new Button();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            groupBox2 = new GroupBox();
            dtpNgayXuat = new DateTimePicker();
            txtTenDX = new TextBox();
            txtMaNV = new TextBox();
            txtMaDX = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnExQLDX = new Button();
            btnImpQLDX = new Button();
            btnXoaQLDX = new Button();
            btnSearchQLDX = new Button();
            btnSuaQLDX = new Button();
            btnThemQLDX = new Button();
            groupBox1 = new GroupBox();
            dgvQLDX = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLDX).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 2);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.3072357F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.6927643F));
            tableLayoutPanel1.Size = new Size(1139, 945);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnQLDX_Back);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 83);
            panel1.TabIndex = 0;
            // 
            // btnQLDX_Back
            // 
            btnQLDX_Back.BackColor = Color.Red;
            btnQLDX_Back.FlatAppearance.BorderColor = Color.Gainsboro;
            btnQLDX_Back.FlatAppearance.BorderSize = 2;
            btnQLDX_Back.FlatStyle = FlatStyle.Popup;
            btnQLDX_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLDX_Back.Image = Properties.Resources.Logout;
            btnQLDX_Back.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLDX_Back.Location = new Point(955, 21);
            btnQLDX_Back.Margin = new Padding(2);
            btnQLDX_Back.Name = "btnQLDX_Back";
            btnQLDX_Back.Size = new Size(148, 36);
            btnQLDX_Back.TabIndex = 6;
            btnQLDX_Back.Text = "Thoát";
            btnQLDX_Back.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(437, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(293, 38);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ ĐƠN XUẤT";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(2, 623);
            splitContainer1.Margin = new Padding(2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox3);
            splitContainer1.Size = new Size(1133, 319);
            splitContainer1.SplitterDistance = 675;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpNgayXuat);
            groupBox2.Controls.Add(txtTenDX);
            groupBox2.Controls.Add(txtMaNV);
            groupBox2.Controls.Add(txtMaDX);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(675, 319);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // dtpNgayXuat
            // 
            dtpNgayXuat.CustomFormat = "dd/MM/yyyy";
            dtpNgayXuat.Format = DateTimePickerFormat.Custom;
            dtpNgayXuat.Location = new Point(245, 248);
            dtpNgayXuat.Margin = new Padding(2);
            dtpNgayXuat.Name = "dtpNgayXuat";
            dtpNgayXuat.Size = new Size(359, 31);
            dtpNgayXuat.TabIndex = 7;
            dtpNgayXuat.Value = new DateTime(2023, 11, 27, 12, 53, 49, 0);
            // 
            // txtTenDX
            // 
            txtTenDX.Location = new Point(245, 183);
            txtTenDX.Margin = new Padding(2);
            txtTenDX.Name = "txtTenDX";
            txtTenDX.Size = new Size(359, 31);
            txtTenDX.TabIndex = 6;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(245, 118);
            txtMaNV.Margin = new Padding(2);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(359, 31);
            txtMaNV.TabIndex = 5;
            // 
            // txtMaDX
            // 
            txtMaDX.Location = new Point(245, 53);
            txtMaDX.Margin = new Padding(2);
            txtMaDX.Name = "txtMaDX";
            txtMaDX.Size = new Size(359, 31);
            txtMaDX.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 248);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 3;
            label5.Text = "Ngày xuất";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 183);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 2;
            label4.Text = "Tên đơn ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 118);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 1;
            label3.Text = "Mã NV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 53);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã đơn xuất";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnExQLDX);
            groupBox3.Controls.Add(btnImpQLDX);
            groupBox3.Controls.Add(btnXoaQLDX);
            groupBox3.Controls.Add(btnSearchQLDX);
            groupBox3.Controls.Add(btnSuaQLDX);
            groupBox3.Controls.Add(btnThemQLDX);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(455, 319);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnExQLDX
            // 
            btnExQLDX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExQLDX.Location = new Point(277, 248);
            btnExQLDX.Margin = new Padding(2);
            btnExQLDX.Name = "btnExQLDX";
            btnExQLDX.Size = new Size(115, 36);
            btnExQLDX.TabIndex = 4;
            btnExQLDX.Text = "Export";
            btnExQLDX.UseVisualStyleBackColor = true;
            // 
            // btnImpQLDX
            // 
            btnImpQLDX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnImpQLDX.Location = new Point(277, 149);
            btnImpQLDX.Margin = new Padding(2);
            btnImpQLDX.Name = "btnImpQLDX";
            btnImpQLDX.Size = new Size(115, 36);
            btnImpQLDX.TabIndex = 3;
            btnImpQLDX.Text = "Import";
            btnImpQLDX.UseVisualStyleBackColor = true;
            // 
            // btnXoaQLDX
            // 
            btnXoaQLDX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoaQLDX.Image = Properties.Resources.Delete;
            btnXoaQLDX.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaQLDX.Location = new Point(83, 248);
            btnXoaQLDX.Margin = new Padding(2);
            btnXoaQLDX.Name = "btnXoaQLDX";
            btnXoaQLDX.Size = new Size(115, 36);
            btnXoaQLDX.TabIndex = 2;
            btnXoaQLDX.Text = "Xóa";
            btnXoaQLDX.UseVisualStyleBackColor = true;
            // 
            // btnSearchQLDX
            // 
            btnSearchQLDX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchQLDX.Location = new Point(277, 51);
            btnSearchQLDX.Margin = new Padding(2);
            btnSearchQLDX.Name = "btnSearchQLDX";
            btnSearchQLDX.Size = new Size(115, 36);
            btnSearchQLDX.TabIndex = 3;
            btnSearchQLDX.Text = "Tìm kiếm";
            btnSearchQLDX.UseVisualStyleBackColor = true;
            // 
            // btnSuaQLDX
            // 
            btnSuaQLDX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuaQLDX.Image = Properties.Resources.Edit;
            btnSuaQLDX.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuaQLDX.Location = new Point(83, 149);
            btnSuaQLDX.Margin = new Padding(2);
            btnSuaQLDX.Name = "btnSuaQLDX";
            btnSuaQLDX.Size = new Size(115, 36);
            btnSuaQLDX.TabIndex = 1;
            btnSuaQLDX.Text = "Sửa";
            btnSuaQLDX.UseVisualStyleBackColor = true;
            // 
            // btnThemQLDX
            // 
            btnThemQLDX.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemQLDX.Image = Properties.Resources.New;
            btnThemQLDX.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemQLDX.Location = new Point(83, 51);
            btnThemQLDX.Margin = new Padding(2);
            btnThemQLDX.Name = "btnThemQLDX";
            btnThemQLDX.Size = new Size(115, 36);
            btnThemQLDX.TabIndex = 0;
            btnThemQLDX.Text = "Thêm";
            btnThemQLDX.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvQLDX);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(2, 89);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1135, 530);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hiển thị";
            // 
            // dgvQLDX
            // 
            dgvQLDX.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLDX.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvQLDX.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLDX.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvQLDX.Dock = DockStyle.Fill;
            dgvQLDX.Location = new Point(2, 26);
            dgvQLDX.Margin = new Padding(2);
            dgvQLDX.Name = "dgvQLDX";
            dgvQLDX.RowHeadersWidth = 82;
            dgvQLDX.RowTemplate.Height = 41;
            dgvQLDX.Size = new Size(1131, 502);
            dgvQLDX.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã đơn xuất";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã NV";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên đơn";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Ngày xuất";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            // 
            // UC_QLDonXuat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "UC_QLDonXuat";
            Size = new Size(1139, 945);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLDX).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private DataGridView dgvQLDX;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label2;
        private Button btnSearchQLDX;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnExQLDX;
        private Button btnImpQLDX;
        private Button btnXoaQLDX;
        private Button btnSuaQLDX;
        private Button btnThemQLDX;
        private TextBox txtTenDX;
        private TextBox txtMaNV;
        private TextBox txtMaDX;
        private DateTimePicker dtpNgayXuat;
        private Button btnQLDX_Back;
    }
}
