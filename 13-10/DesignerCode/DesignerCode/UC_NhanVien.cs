using DTO;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Label = System.Windows.Forms.Label;
using OfficeOpenXml;
using Newtonsoft.Json;
using OfficeOpenXml.Style;
using Formatting = Newtonsoft.Json.Formatting;

namespace GUI
{
    public partial class UC_NhanVien : UserControl
    {
        private NhanVienBLL BLLNhanVien;
        private List<NhanVienDTO> danhSachNhanVien;

        public UC_NhanVien()
        {
            InitializeComponent();
            BLLNhanVien = new NhanVienBLL();


            // Khởi tạo
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvNhanVien = new DataGridView();
            DataGridViewTextBoxColumn MaNhanVien = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn TenNhanVien = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn NgaySinh = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Email = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn SDT = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn DiaChi = new DataGridViewTextBoxColumn();
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            Button btnThem = new Button();
            Button btnXoa = new Button();
            Button btnSua = new Button();
            Button btnNhap = new Button();
            Button btnXuat = new Button();
            Label label1 = new Label();
            Label label2 = new Label();
            Label label3 = new Label();
            Label label4 = new Label();
            Label label5 = new Label();
            Label label6 = new Label();
            txtMaNhanVien = new TextBox();
            txtTenNhanVien = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            Button btnXuatJs = new Button();
            Adddatasample();
            LoadDanhSachNhanVien();
            //
            // Tạo một TableLayoutPanel và thiết lập các thuộc tính của nó
            //

            tableLayoutPanel.ColumnCount = 6;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 74F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel.Controls.Add(dgvNhanVien, 0, 0);
            tableLayoutPanel.Controls.Add(btnThem, 0, 3);
            tableLayoutPanel.Controls.Add(btnXoa, 1, 3);
            tableLayoutPanel.Controls.Add(btnSua, 2, 3);
            tableLayoutPanel.Controls.Add(btnNhap, 3, 3);
            tableLayoutPanel.Controls.Add(btnXuat, 4, 3);
            tableLayoutPanel.Controls.Add(label1, 0, 1);
            tableLayoutPanel.Controls.Add(label2, 1, 1);
            tableLayoutPanel.Controls.Add(label3, 2, 1);
            tableLayoutPanel.Controls.Add(label4, 3, 1);
            tableLayoutPanel.Controls.Add(label5, 4, 1);
            tableLayoutPanel.Controls.Add(label6, 5, 1);
            tableLayoutPanel.Controls.Add(txtMaNhanVien, 0, 2);
            tableLayoutPanel.Controls.Add(txtTenNhanVien, 1, 2);
            tableLayoutPanel.Controls.Add(txtEmail, 3, 2);
            tableLayoutPanel.Controls.Add(txtSDT, 4, 2);
            tableLayoutPanel.Controls.Add(txtDiaChi, 5, 2);
            tableLayoutPanel.Controls.Add(dtpNgaySinh, 2, 2);
            tableLayoutPanel.Controls.Add(btnXuatJs, 5, 3);
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.TabIndex = 0;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);

            //
            // dgvNhanVien
            //

            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel.SetColumnSpan(dgvNhanVien, 6);
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, TenNhanVien, NgaySinh, Email, SDT, DiaChi });
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.TabIndex = 1;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.SelectionChanged += dgvNhanVien_SelectionChanged;
            //dgvNhanVien.RowPostPaint += DgvNhanVien_RowPostPaint;
            // Columns Header dgvNhanVien
            // 
            // MaNhanVien
            // 

            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã Nhân Viên";
            MaNhanVien.MinimumWidth = 8;
    
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
            SDT.Width = 158;

            // 
            // DiaChi
            //
            //
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            DiaChi.Width = 104;

            // 
            // btnThem
            //

            btnThem.Anchor = AnchorStyles.None;
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 50);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;

            // 
            // btnXoa
            // 

            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 50);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoaNhanVien_Click;

            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 50);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSuaNhanVien_Click;

            // 
            // btnNhap
            // 
            btnNhap.Anchor = AnchorStyles.None;
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(120, 50);
            btnNhap.TabIndex = 5;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;

            // 
            // btnXuat
            // 
            btnXuat.Anchor = AnchorStyles.None;
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(120,50);
            btnXuat.TabIndex = 6;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;

            //
            // btnXuatJs
            //
            btnXuatJs.Anchor = AnchorStyles.None;
            btnXuatJs.Location = new Point(892, 617);
            btnXuatJs.Name = "btnXuatJs";
            btnXuatJs.Size = new Size(120, 50);
            btnXuatJs.TabIndex = 7;
            btnXuatJs.Text = "Xuất Json";
            btnXuatJs.UseVisualStyleBackColor = true;
            btnXuatJs.Click += btnXuatJs_Click;

            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.Text = "Mã Nhân Viên";

            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(198, 512);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.Text = "Tên Nhân viên";

            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(386, 512);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.Text = "Ngày Sinh";

            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(578, 512);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.Text = "Email";

            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(717, 512);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.Text = "Số Điện Thoại";

            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(918, 512);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.Text = "Địa Chỉ";

            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Dock = DockStyle.Fill;
            txtMaNhanVien.Location = new Point(20, 557);
            txtMaNhanVien.Margin = new Padding(20, 10, 20, 10);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(133, 31);
            txtMaNhanVien.TabIndex = 8;

            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Dock = DockStyle.Fill;
            txtTenNhanVien.Location = new Point(193, 557);
            txtTenNhanVien.Margin = new Padding(20, 10, 20, 10);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(133, 31);
            txtTenNhanVien.TabIndex = 9;

            //
            // txtEmail
            //
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(539, 557);
            txtEmail.Margin = new Padding(20, 10, 20, 10);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(133, 31);
            txtEmail.TabIndex = 10;

            //
            // txtSDT
            //
            txtSDT.Dock = DockStyle.Fill;
            txtSDT.Location = new Point(712, 557);
            txtSDT.Margin = new Padding(20, 10, 20, 10);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(133, 31);
            txtSDT.TabIndex = 11;

            //
            // txtDiaChi
            //
            txtDiaChi.Dock = DockStyle.Fill;
            txtDiaChi.Location = new Point(885, 557);
            txtDiaChi.Margin = new Padding(20, 10, 20, 10);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(134, 31);
            txtDiaChi.TabIndex = 12;

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
            dtpNgaySinh.TabIndex = 13;
                  
            //
            // UC_NhanVien
            //

            // Thêm TableLayoutPanel vào UserControl
            Controls.Add(tableLayoutPanel);

        }

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

        private void Adddatasample()
        {
            // Tạo một danh sách chứa thông tin của các Nhân viên mẫu
            List<NhanVienDTO> danhSachNhanVienMau = new List<NhanVienDTO>
            {
                new NhanVienDTO()
                {
                    MaNhanVien = "NV005",
                    TenNhanVien = "Nguyễn Văn A",
                    NgaySinh = new DateTime(1990, 1, 15),
                    Email = "nguyenvana@gmail.com",
                    SDT = "0123456789",
                    DiaChi = "123 Đường ABC, Quận XYZ"
                },
                new NhanVienDTO()
                {
                    MaNhanVien = "NV006",
                    TenNhanVien = "Trần Thị B",
                    NgaySinh = new DateTime(1995, 5, 20),
                    Email = "tranthib@gmail.com",
                    SDT = "0987654321",
                    DiaChi = "456 Đường XYZ, Quận ABC"
                },
                new NhanVienDTO()
                {
                    MaNhanVien = "NV007",
                    TenNhanVien = "Lê Văn C",
                    NgaySinh = new DateTime(1988, 8, 8),
                    Email = "levanc@gmail.com",
                    SDT = "0369852147",
                    DiaChi = "789 Đường DEF, Quận UVW"
                },
                new NhanVienDTO()
                {
                    MaNhanVien = "NV008",
                    TenNhanVien = "Phạm Thị D",
                    NgaySinh = new DateTime(1993, 3, 10),
                    Email = "phamthid@gmail.com",
                    SDT = "0765432190",
                    DiaChi = "101 Đường MNO, Quận PQR"
                }
            };

            // Lặp qua danh sách Nhân viên mẫu và thêm từng Nhân viên vào danh sách chính và cơ sở dữ liệu
            foreach (NhanVienDTO nhanVienMau in danhSachNhanVienMau)
            {
                BLLNhanVien.ThemNhanVien(nhanVienMau);
            }

            // Cập nhật danh sách và xóa nội dung các trường nhập liệu
            LoadDanhSachNhanVien();
            ClearTextBoxes();

        }

        private void LoadDanhSachNhanVien()
        {
            danhSachNhanVien = BLLNhanVien.LayDanhSachNhanVien();
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = danhSachNhanVien;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các controls nhập liệu
            string maNhanVien = txtMaNhanVien.Text;
            string tenNhanVien = txtTenNhanVien.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;

            // Tạo đối tượng NhanVienDTO từ thông tin đã nhập
            NhanVienDTO nhanVienMoi = new NhanVienDTO()
            {
                MaNhanVien = maNhanVien,
                TenNhanVien = tenNhanVien,
                NgaySinh = ngaySinh,
                Email = email,
                SDT = sdt,
                DiaChi = diaChi
            };

            // Kiểm tra hợp lệ trước khi thêm
            if (ValidateNhanVien(nhanVienMoi) == true && ValidateMaNhanVien(nhanVienMoi) == true)
            {
                // Thực hiện thêm Nhân viên vào danh sách và cơ sở dữ liệu
                BLLNhanVien.ThemNhanVien(nhanVienMoi);
                LoadDanhSachNhanVien();
                ClearTextBoxes();
                MessageBox.Show("thêm Nhân viên thành công!");
            }

        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgvNhanVien.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn Nhân viên cần xóa hoặc dữ liệu trống.");
                return;
            }

            // Lấy mã Nhân viên của dòng được chọn
            DataGridViewRow selectedRow = dgvNhanVien.CurrentRow;
            string maNhanVien = (selectedRow.Cells[0].Value ?? string.Empty).ToString();
            if (!string.IsNullOrEmpty(maNhanVien))
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa Nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra kết quả người dùng chọn
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        BLLNhanVien.XoaNhanVien(maNhanVien);
                        LoadDanhSachNhanVien();
                        MessageBox.Show("Xóa Nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Xóa không thành công, hiển thị thông báo lỗi và ghi log ngoại lệ (nếu cần)
                        MessageBox.Show("Xóa Nhân viên không thành công. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Ghi log ngoại lệ
                        // Logger.Log(ex);
                    }
                }
            }
        }

        private bool isEditing = false; // Biến trạng thái chỉnh sửa

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (!isEditing)
            {
                // Trạng thái "lấy thông tin từ data đổ xuống grid"
                isEditing = true;
                txtMaNhanVien.Enabled = false;

                // Lấy thông tin từ dòng được chọn trong DataGridView và đổ vào các TextBox
                DataGridViewRow selectedRow = dgvNhanVien.CurrentRow;
                if (selectedRow != null)
                {
                    txtMaNhanVien.Text = selectedRow.Cells[0].Value.ToString();
                    txtTenNhanVien.Text = selectedRow.Cells[1].Value.ToString();
                    dtpNgaySinh.Value = Convert.ToDateTime(selectedRow.Cells[2].Value);
                    txtEmail.Text = selectedRow.Cells[3].Value.ToString();
                    txtSDT.Text = selectedRow.Cells[4].Value.ToString();
                    txtDiaChi.Text = selectedRow.Cells[5].Value.ToString();
                }
            }
            else
            {
                // Trạng thái "cập nhật data lại cho datagridview"
                // Lấy thông tin từ các controls nhập liệu
                string maNhanVien = txtMaNhanVien.Text;
                string tenNhanVien = txtTenNhanVien.Text;
                DateTime ngaySinh = dtpNgaySinh.Value;
                string email = txtEmail.Text;
                string sdt = txtSDT.Text;
                string diaChi = txtDiaChi.Text;

                // Tạo đối tượng NhanVienDTO từ thông tin đã nhập
                NhanVienDTO nhanVienMoi = new NhanVienDTO()
                {
                    MaNhanVien = maNhanVien,
                    TenNhanVien = tenNhanVien,
                    NgaySinh = ngaySinh,
                    Email = email,
                    SDT = sdt,
                    DiaChi = diaChi
                };

                if (ValidateNhanVien(nhanVienMoi))
                {
                    // Thực hiện cập nhật thông tin Nhân viên
                    BLLNhanVien.CapNhatThongTinNhanVien(nhanVienMoi);
                    LoadDanhSachNhanVien();
                    ClearTextBoxes();
                    MessageBox.Show("Cập nhật thành công!");

                    // Trả về trạng thái ban đầu
                    isEditing = false;
                    txtMaNhanVien.Enabled = true;
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo một số ngẫu nhiên từ 1000 đến 99999
                Random random = new Random();
                int randomNumber = random.Next(1000, 99999);

                // Tạo tên tệp Excel với số ngẫu nhiên
                string tenTepExcel = $"DanhSachNhanVien_{randomNumber}.xlsx";

                // Khung hộp thoại cho phép người dùng chọn nơi lưu tệp
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.FileName = tenTepExcel;
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tenTepExcel = saveFileDialog.FileName;

                    // Tạo một ExcelPackage
                    using (var package = new ExcelPackage())
                    {
                        // Tạo một Sheet có tên là "DanhSachNhanVien"
                        var worksheet = package.Workbook.Worksheets.Add("DanhSachNhanVien");

                        // Đặt tiêu đề cho các cột (hàng đầu tiên)
                        for (int col = 1; col <= dgvNhanVien.Columns.Count; col++)
                        {
                            worksheet.Cells[1, col].Value = dgvNhanVien.Columns[col - 1].HeaderText;
                        }

                        // Đặt hàng thứ hai là định dạng DataPropertyName
                        for (int col = 1; col <= dgvNhanVien.Columns.Count; col++)
                        {
                            worksheet.Cells[2, col].Value = dgvNhanVien.Columns[col - 1].DataPropertyName;
                        }

                        // Đặt kiểu định dạng cho hàng tiêu đề
                        using (var range = worksheet.Cells["A1:F2"])
                        {
                            range.Style.Font.Bold = true;
                            range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                            range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Gray);
                            range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                        }

                        // Đổ dữ liệu từ DataGridView vào Excel bắt đầu từ hàng thứ ba
                        for (int row = 0; row < dgvNhanVien.Rows.Count; row++)
                        {
                            for (int col = 0; col < dgvNhanVien.Columns.Count; col++)
                            {
                                if (dgvNhanVien.Columns[col].DataPropertyName == "NgaySinh")
                                {
                                    // Định dạng ngày tháng là "dd/MM/yyyy"
                                    worksheet.Cells[row + 3, col + 1].Value = DateTime.Parse(dgvNhanVien.Rows[row].Cells[col].Value.ToString()).ToString("dd/MM/yyyy");
                                }
                                else
                                {
                                    worksheet.Cells[row + 3, col + 1].Value = dgvNhanVien.Rows[row].Cells[col].Value.ToString();
                                }
                            }
                        }

                        // Lưu file Excel với tên tệp đã chọn
                        var file = new FileInfo(tenTepExcel);
                        package.SaveAs(file);
                        MessageBox.Show("Xuất dữ liệu thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                // Khung hộp thoại cho phép người dùng chọn tệp Excel để nhập
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Tạo một ExcelPackage từ tệp Excel đã chọn
                    using (var package = new ExcelPackage(new FileInfo(filePath)))
                    {
                        // Chọn sheet bạn muốn đọc dữ liệu từ đó
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                        // Lấy số dòng và số cột trong sheet
                        int rowCount = worksheet.Dimension.Rows;
                        int colCount = worksheet.Dimension.Columns;

                        // Duyệt qua từng dòng trong sheet và đưa dữ liệu vào danh sách hiện có
                        for (int row = 3; row <= rowCount; row++) // Bắt đầu từ hàng thứ ba 
                        {
                            NhanVienDTO nhanVien = new NhanVienDTO();
                            nhanVien.MaNhanVien = worksheet.Cells[row, 1].Value.ToString();
                            nhanVien.TenNhanVien = worksheet.Cells[row, 2].Value.ToString();
                            nhanVien.NgaySinh = DateTime.ParseExact(worksheet.Cells[row, 3].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            nhanVien.Email = worksheet.Cells[row, 4].Value.ToString();
                            nhanVien.SDT = worksheet.Cells[row, 5].Value.ToString();
                            nhanVien.DiaChi = worksheet.Cells[row, 6].Value.ToString();

                            // Thêm nhanVien vào danh sách hiện có
                            danhSachNhanVien.Add(nhanVien);
                        }

                        // Cập nhật DataGridView
                        dgvNhanVien.DataSource = null;
                        dgvNhanVien.DataSource = danhSachNhanVien;

                        MessageBox.Show("Nhập dữ liệu từ tệp Excel thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhập dữ liệu từ tệp Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuatJs_Click(object sender, EventArgs e)
        {
            // Khung hộp thoại cho phép người dùng chọn nơi lưu tệp JSON
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files|*.json";
            saveFileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            saveFileDialog.FileName = "ListNhanVien.json";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string tenTepJSON = saveFileDialog.FileName;
                LuuDanhSachNhanVienSangJSON(tenTepJSON);
            }
        }

        private void ClearTextBoxes()
        {
            // Xóa nội dung các controls nhập liệu
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtEmail.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvNhanVien.CurrentRow;
            if (dr != null)
            {
                // Lấy thông tin từ dòng được chọn và đổ vào các TextBox
                txtMaNhanVien.Text = (dr.Cells[0].Value ?? string.Empty).ToString();
                txtTenNhanVien.Text = (dr.Cells[1].Value ?? string.Empty).ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(dr.Cells[2].Value ?? DateTime.Now);
                txtEmail.Text = (dr.Cells[3].Value ?? string.Empty).ToString();
                txtSDT.Text = (dr.Cells[4].Value ?? string.Empty).ToString();
                txtDiaChi.Text = (dr.Cells[5].Value ?? string.Empty).ToString();
            }
        }

        private bool ValidateMaNhanVien(NhanVienDTO nhanVien)
        {
            // Kiểm tra Mã nhân viên không được null hoặc rỗng
            if (string.IsNullOrEmpty(nhanVien.MaNhanVien))
            {
                MessageBox.Show("Mã nhân viên không được để trống.");
                return false;
            }

            // Kiểm tra xem Mã nhân viên đã tồn tại trong danh sách hay chưa
            if (danhSachNhanVien.Any(nv => nv.MaNhanVien == nhanVien.MaNhanVien))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại.");
                return false;
            }

            return true;
        }

        private bool ValidateNhanVien(NhanVienDTO nhanVien)
        {
            // Kiểm tra Ngày sinh không được lớn hơn hiện tại
            if (nhanVien.NgaySinh > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại.");
                return false;
            }

            // Kiểm tra Email phải có định dạng @gmail.com
            if (!nhanVien.Email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email phải có định dạng @gmail.com.");
                return false;
            }

            // Kiểm tra Số điện thoại
            string sdt = txtSDT.Text.Trim();
            if (!string.IsNullOrEmpty(sdt))
            {
                if (sdt.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải có đúng 10 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!Regex.IsMatch(sdt, @"^\d+$"))
                {
                    MessageBox.Show("Số điện thoại chỉ được chứa ký tự số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // Nếu không có lỗi, trả về true để xác nhận thông tin hợp lệ
            return true;
        }

        private void dgvNhanVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Lấy số thứ tự của hàng (bắt đầu từ 1)
            int rowIndex = e.RowIndex + 1;

            // Tạo một brush để vẽ số thứ tự
            using (SolidBrush brush = new SolidBrush(dgvNhanVien.RowHeadersDefaultCellStyle.ForeColor))
            {
                // Xác định vị trí để vẽ số thứ tự trên hàng tiêu đề
                float x = e.RowBounds.Left + 10; // Điều chỉnh vị trí xuất phát theo ý muốn
                float y = e.RowBounds.Top + (e.RowBounds.Height - e.InheritedRowStyle.Font.Height) / 2;

                // Vẽ số thứ tự
                e.Graphics.DrawString(rowIndex.ToString(), e.InheritedRowStyle.Font, brush, x, y);
            }
        }

        private void LuuDanhSachNhanVienSangJSON(string tenTepJSON)
        {
            if (danhSachNhanVien != null)
            {
                try
                {
                    // Chuyển danh sách Nhân viên thành chuỗi JSON
                    string json = JsonConvert.SerializeObject(danhSachNhanVien, Formatting.Indented);

                    // Lưu chuỗi JSON vào tệp
                    System.IO.File.WriteAllText(tenTepJSON, json);
                    MessageBox.Show("Lưu dữ liệu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu dữ liệu dưới dạng JSON: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
