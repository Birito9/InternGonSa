namespace GUI
{
    partial class UC_QLNV
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
            groupBox3 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button7 = new Button();
            panel1 = new Panel();
            btnQLNV_Back = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvQLNV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            label6 = new Label();
            gboxGioiTinh = new GroupBox();
            radNam = new RadioButton();
            radNu = new RadioButton();
            dtpNgaySinh = new DateTimePicker();
            txtHoTen = new TextBox();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtUserID = new TextBox();
            txtMaCN = new TextBox();
            txtMaNV = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLNV).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            gboxGioiTinh.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 3);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.5538826F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.44612F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 288F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1133, 762);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button7);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(2, 637);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(1129, 123);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.MenuBar;
            button5.FlatAppearance.BorderColor = Color.Gainsboro;
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(928, 55);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(115, 36);
            button5.TabIndex = 4;
            button5.Text = "Export";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuBar;
            button4.FlatAppearance.BorderColor = Color.Gainsboro;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(756, 55);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(115, 36);
            button4.TabIndex = 3;
            button4.Text = "Import";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuBar;
            button3.FlatAppearance.BorderColor = Color.Gainsboro;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources.Delete;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(585, 55);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(115, 36);
            button3.TabIndex = 2;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuBar;
            button2.FlatAppearance.BorderColor = Color.Gainsboro;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.Edit;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(413, 55);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(115, 36);
            button2.TabIndex = 1;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuBar;
            button1.FlatAppearance.BorderColor = Color.Gainsboro;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.New;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(242, 55);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(115, 36);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.MenuBar;
            button7.FlatAppearance.BorderColor = Color.Gainsboro;
            button7.FlatAppearance.BorderSize = 2;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(70, 55);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(115, 36);
            button7.TabIndex = 8;
            button7.Text = "Tìm kiếm";
            button7.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnQLNV_Back);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 71);
            panel1.TabIndex = 0;
            // 
            // btnQLNV_Back
            // 
            btnQLNV_Back.BackColor = Color.Red;
            btnQLNV_Back.FlatAppearance.BorderColor = Color.Gainsboro;
            btnQLNV_Back.FlatAppearance.BorderSize = 2;
            btnQLNV_Back.FlatStyle = FlatStyle.Popup;
            btnQLNV_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLNV_Back.Image = Properties.Resources.Logout;
            btnQLNV_Back.ImageAlign = ContentAlignment.MiddleLeft;
            btnQLNV_Back.Location = new Point(953, 14);
            btnQLNV_Back.Margin = new Padding(2);
            btnQLNV_Back.Name = "btnQLNV_Back";
            btnQLNV_Back.Size = new Size(148, 36);
            btnQLNV_Back.TabIndex = 5;
            btnQLNV_Back.Text = "Thoát";
            btnQLNV_Back.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(425, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(304, 38);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ NHÂN VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvQLNV);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(2, 77);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(1129, 268);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị";
            // 
            // dgvQLNV
            // 
            dgvQLNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQLNV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvQLNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLNV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dgvQLNV.Dock = DockStyle.Fill;
            dgvQLNV.Location = new Point(2, 26);
            dgvQLNV.Margin = new Padding(2);
            dgvQLNV.Name = "dgvQLNV";
            dgvQLNV.RowHeadersWidth = 82;
            dgvQLNV.RowTemplate.Height = 41;
            dgvQLNV.Size = new Size(1125, 240);
            dgvQLNV.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã NV";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "UserID";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Mã chi nhánh";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Họ tên";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Ngày sinh";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Giới tính";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "SĐT";
            Column7.MinimumWidth = 10;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Email";
            Column8.MinimumWidth = 10;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Địa chỉ";
            Column9.MinimumWidth = 10;
            Column9.Name = "Column9";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(2, 349);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1129, 284);
            panel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(gboxGioiTinh);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtUserID);
            groupBox1.Controls.Add(txtMaCN);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1129, 284);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(407, 210);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 20;
            label6.Text = "Giới tính";
            // 
            // gboxGioiTinh
            // 
            gboxGioiTinh.Controls.Add(radNam);
            gboxGioiTinh.Controls.Add(radNu);
            gboxGioiTinh.Location = new Point(524, 183);
            gboxGioiTinh.Name = "gboxGioiTinh";
            gboxGioiTinh.Size = new Size(196, 68);
            gboxGioiTinh.TabIndex = 19;
            gboxGioiTinh.TabStop = false;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Checked = true;
            radNam.Location = new Point(19, 29);
            radNam.Margin = new Padding(2);
            radNam.Name = "radNam";
            radNam.Size = new Size(75, 29);
            radNam.TabIndex = 17;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(125, 29);
            radNu.Margin = new Padding(2);
            radNu.Name = "radNu";
            radNu.Size = new Size(61, 29);
            radNu.TabIndex = 18;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(524, 130);
            dtpNgaySinh.Margin = new Padding(2);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(163, 31);
            dtpNgaySinh.TabIndex = 16;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(524, 61);
            txtHoTen.Margin = new Padding(2);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(163, 31);
            txtHoTen.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(915, 141);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(155, 31);
            txtEmail.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(915, 210);
            txtDiaChi.Margin = new Padding(2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(155, 31);
            txtDiaChi.TabIndex = 13;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(915, 57);
            txtSDT.Margin = new Padding(2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(155, 31);
            txtSDT.TabIndex = 12;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(179, 130);
            txtUserID.Margin = new Padding(2);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(155, 31);
            txtUserID.TabIndex = 11;
            // 
            // txtMaCN
            // 
            txtMaCN.Location = new Point(179, 205);
            txtMaCN.Margin = new Padding(2);
            txtMaCN.Name = "txtMaCN";
            txtMaCN.Size = new Size(155, 31);
            txtMaCN.TabIndex = 10;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(179, 58);
            txtMaNV.Margin = new Padding(2);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(155, 31);
            txtMaNV.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(794, 211);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(65, 25);
            label10.TabIndex = 8;
            label10.Text = "Địa chỉ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(794, 135);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(54, 25);
            label9.TabIndex = 7;
            label9.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(794, 59);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(44, 25);
            label8.TabIndex = 6;
            label8.Text = "SĐT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(407, 134);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 5;
            label7.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 55);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 3;
            label5.Text = "Họ tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 210);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 2;
            label4.Text = "Mã chi nhánh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 138);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 1;
            label3.Text = "UserID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 63);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã NV";
            // 
            // UC_QLNV
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "UC_QLNV";
            Size = new Size(1133, 762);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLNV).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gboxGioiTinh.ResumeLayout(false);
            gboxGioiTinh.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private DataGridView dgvQLNV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button7;
        private Button btnQLNV_Back;
        private Panel panel2;
        private GroupBox groupBox1;
        private RadioButton radNu;
        private RadioButton radNam;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtHoTen;
        private TextBox txtEmail;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtUserID;
        private TextBox txtMaCN;
        private TextBox txtMaNV;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private GroupBox gboxGioiTinh;
    }
}
