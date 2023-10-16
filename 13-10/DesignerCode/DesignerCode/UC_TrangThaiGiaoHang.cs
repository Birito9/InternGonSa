using BLL;
using DTO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace GUI
{
    public partial class UC_TrangThaiGiaoHang : UserControl
    {
        private BLLTrangThaiGiaoHang bllTrangThaiGiaoHang = new BLLTrangThaiGiaoHang();
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvTrangThaiGiaoHang;
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
        private Button btnEncrypt;
        private Button btnDecrypt;
        private DataGridViewTextBoxColumn MaTrangThaiGiaoHang;
        private DataGridViewTextBoxColumn TenTrangThai;
        private DataGridViewTextBoxColumn MoTa;
        public UC_TrangThaiGiaoHang()
        {
            InitializeComponent();
            bllTrangThaiGiaoHang = new BLLTrangThaiGiaoHang();

            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            dgvTrangThaiGiaoHang = new DataGridView();
            DataGridViewTextBoxColumn MaTrangThaiGiaoHang = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn TenTrangThai = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn MoTa = new DataGridViewTextBoxColumn();
            Button btnThem = new Button();
            Button btnXoa = new Button();
            Button btnSua = new Button();
            Button btnNhap = new Button();
            Button btnXuat = new Button();
            Button btnEncrypt = new Button();
            Button btnDecrypt = new Button();

            txtTenTrangThai = new TextBox();
            txtMoTa = new TextBox();
            txtMaTrangThaiGiaoHang = new TextBox();

            Label label1 = new Label();
            Label label2 = new Label();
            Label label3 = new Label();
            LoadDataFromAPI();


            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60.472496F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.32158F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.6029625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.6029625F));
            tableLayoutPanel1.Size = new Size(970, 590);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Controls.Add(dgvTrangThaiGiaoHang, 0, 0);
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
            tableLayoutPanel1.Controls.Add(btnEncrypt, 4, 2);
            tableLayoutPanel1.Controls.Add(btnDecrypt, 4, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";

            // 
            // dgvFormOrderTrangThaiGiaoHang
            // 
            dgvTrangThaiGiaoHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrangThaiGiaoHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrangThaiGiaoHang.Columns.AddRange(new DataGridViewColumn[] { MaTrangThaiGiaoHang, TenTrangThai, MoTa });
            tableLayoutPanel1.SetColumnSpan(dgvTrangThaiGiaoHang, 5);
            dgvTrangThaiGiaoHang.Dock = DockStyle.Fill;
            dgvTrangThaiGiaoHang.Location = new Point(3, 3);
            dgvTrangThaiGiaoHang.Name = "dgvTrangThaiGiaoHang";
            dgvTrangThaiGiaoHang.RowHeadersWidth = 62;
            dgvTrangThaiGiaoHang.RowTemplate.Height = 33;
            dgvTrangThaiGiaoHang.Size = new Size(964, 350);
            dgvTrangThaiGiaoHang.TabIndex = 0;
            dgvTrangThaiGiaoHang.RowPostPaint += dgvFormOrderTrangThaiGiaoHang_RowPostPaint;
            dgvTrangThaiGiaoHang.SelectionChanged += dgvFormOrderTrangThaiGiaoHang_SelectionChanged;
            dgvTrangThaiGiaoHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrangThaiGiaoHang.AutoGenerateColumns = false;

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
            MoTa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MoTa.DataPropertyName = "MoTa";
            MoTa.HeaderText = "Mô Tả";
            MoTa.MinimumWidth = 8;
            MoTa.Name = "MoTa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 366);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(174, 29);
            label1.TabIndex = 7;
            label1.Text = "Mã Trạng Thái";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(204, 366);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Size = new Size(174, 29);
            label2.TabIndex = 8;
            label2.Text = "Tên Trạng Thái";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(398, 366);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Size = new Size(174, 29);
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
            txtMaTrangThaiGiaoHang.Size = new Size(134, 31);
            txtMaTrangThaiGiaoHang.TabIndex = 4;
            // 
            // txtTenTrangThai
            // 
            txtTenTrangThai.Dock = DockStyle.Fill;
            txtTenTrangThai.Location = new Point(224, 435);
            txtTenTrangThai.Margin = new Padding(30);
            txtTenTrangThai.Name = "txtTenTrangThai";
            txtTenTrangThai.Size = new Size(134, 31);
            txtTenTrangThai.TabIndex = 5;
            // 
            // txtMoTa
            // 
            txtMoTa.Dock = DockStyle.Fill;
            txtMoTa.Location = new Point(418, 435);
            txtMoTa.Margin = new Padding(30);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(134, 31);
            txtMoTa.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.Dock = DockStyle.Fill;
            btnThem.Location = new Point(50, 517);
            btnThem.Margin = new Padding(50, 20, 50, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 53);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.Location = new Point(244, 517);
            btnXoa.Margin = new Padding(50, 20, 50, 20);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 53);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Dock = DockStyle.Fill;
            btnSua.Location = new Point(438, 517);
            btnSua.Margin = new Padding(50, 20, 50, 20);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 53);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnNhap
            // 
            btnNhap.Dock = DockStyle.Fill;
            btnNhap.Location = new Point(632, 425);
            btnNhap.Margin = new Padding(50, 20, 50, 20);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(94, 52);
            btnNhap.TabIndex = 10;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Dock = DockStyle.Fill;
            btnXuat.Location = new Point(632, 517);
            btnXuat.Margin = new Padding(50, 20, 50, 20);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(94, 53);
            btnXuat.TabIndex = 11;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Dock = DockStyle.Fill;
            btnEncrypt.Location = new Point(826, 425);
            btnEncrypt.Margin = new Padding(50, 20, 50, 20);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(94, 52);
            btnEncrypt.TabIndex = 12;
            btnEncrypt.Text = "Mã Hóa";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Dock = DockStyle.Fill;
            btnDecrypt.Location = new Point(826, 517);
            btnDecrypt.Margin = new Padding(50, 20, 50, 20);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(94, 53);
            btnDecrypt.TabIndex = 13;
            btnDecrypt.Text = "Giải Mã";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;


            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_TrangThaiGiaoHang";
            Size = new Size(970, 590);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();

        }
        private async void LoadDataFromAPI()
        {
            try
            {
                // Gọi phương thức BLL để lấy danh sách dữ liệu từ API
                var dataList = await Task.Run(() => bllTrangThaiGiaoHang.getListFromDAL());

                if (dataList != null && dataList.Count > 0)
                {
                    // Gán danh sách dữ liệu cho DataGridView
                    dgvTrangThaiGiaoHang.DataSource = dataList;

                }
                else
                {
                    MessageBox.Show("Không có dữ liệu hoặc có lỗi khi lấy dữ liệu từ API.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void SetColumnHeaders()
        {
            for (int i = 0; i < dgvTrangThaiGiaoHang.Rows.Count; i++)
            {
                dgvTrangThaiGiaoHang.Rows[i].Cells["SoThuTu"].Value = (i + 1).ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các ô nhập liệu
                string maTrangThai = txtMaTrangThaiGiaoHang.Text;
                string tenTrangThai = txtTenTrangThai.Text;
                string moTa = txtMoTa.Text;

                // Kiểm tra xem các ô nhập liệu có dữ liệu hợp lệ không
                if (string.IsNullOrEmpty(maTrangThai) || string.IsNullOrEmpty(tenTrangThai))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin MaTrangThai và TenTrangThai.");
                    return;
                }

                // Tạo một đối tượng OrderData_TrangThaiGiaoHang từ các giá trị đã nhập
                var newTrangThai = new DTOTrangThaiGiaoHang
                {
                    MaTrangThaiGiaoHang = maTrangThai,
                    TenTrangThai = tenTrangThai,
                    MoTa = moTa
                };

                // Lấy danh sách dữ liệu hiện tại từ DataGridView
                List<DTOTrangThaiGiaoHang> dataList = (List<DTOTrangThaiGiaoHang>)dgvTrangThaiGiaoHang.DataSource;

                // Kiểm tra xem danh sách đã được tạo hay chưa
                if (dataList == null)
                {
                    dataList = new List<DTOTrangThaiGiaoHang>();
                }

                // Thêm dữ liệu mới vào danh sách
                dataList.Add(newTrangThai);

                // Cập nhật lại DataGridView
                dgvTrangThaiGiaoHang.DataSource = null; // Xóa dữ liệu hiện tại
                dgvTrangThaiGiaoHang.DataSource = dataList; // Gán danh sách mới


                ClearTextBoxs();

                MessageBox.Show("Thêm dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn trong DataGridView không
                if (dgvTrangThaiGiaoHang.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn dòng bạn muốn xóa.");
                    return;
                }

                // Lấy chỉ mục của dòng được chọn
                int selectedIndex = dgvTrangThaiGiaoHang.SelectedRows[0].Index;

                // Lấy danh sách dữ liệu hiện tại từ DataGridView
                List<DTOTrangThaiGiaoHang> dataList = (List<DTOTrangThaiGiaoHang>)dgvTrangThaiGiaoHang.DataSource;

                // Xóa dòng được chọn khỏi danh sách
                dataList.RemoveAt(selectedIndex);

                // Cập nhật lại DataGridView
                dgvTrangThaiGiaoHang.DataSource = null; // Xóa dữ liệu hiện tại
                dgvTrangThaiGiaoHang.DataSource = dataList; // Gán danh sách mới


                MessageBox.Show("Xóa dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isEditing = false; // Biến đánh dấu trạng thái sửa


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isEditing)
                {
                    // Nếu đang không trong trạng thái sửa, chuyển sang trạng thái sửa
                    isEditing = true;
                    
                    // Đặt các TextBox cho phép chỉnh sửa
                    txtMaTrangThaiGiaoHang.Enabled = false;
                    txtTenTrangThai.Enabled = true;
                    txtMoTa.Enabled = true;

                    // Lấy dòng được chọn từ DataGridView
                    DataGridViewRow selectedRow = dgvTrangThaiGiaoHang.SelectedRows[0];
                    // Lấy dữ liệu từ dòng được chọn và hiển thị trong các TextBox
                    txtMaTrangThaiGiaoHang.Text = selectedRow.Cells["MaTrangThaiGiaoHang"].Value.ToString();
                    txtTenTrangThai.Text = selectedRow.Cells["TenTrangThai"].Value.ToString();
                    txtMoTa.Text = selectedRow.Cells["MoTa"].Value?.ToString(); // Sử dụng ?. để tránh lỗi nếu MoTa là null
                }
                else
                {
                    // Nếu đang trong trạng thái sửa, thực hiện lưu sửa đổi
                    isEditing = false;
                  
                                         // Đặt các TextBox thành trạng thái chỉ đọc
                    txtMaTrangThaiGiaoHang.Enabled = true;
                    txtTenTrangThai.Enabled = true;
                    txtMoTa.Enabled = true;

                    // Lấy dữ liệu từ TextBox sau khi chỉnh sửa
                    string maTrangThai = txtMaTrangThaiGiaoHang.Text;
                    string tenTrangThai = txtTenTrangThai.Text;
                    string moTa = txtMoTa.Text;

                    // Lấy dòng được chọn từ DataGridView
                    DataGridViewRow selectedRow = dgvTrangThaiGiaoHang.SelectedRows[0];
                    // Cập nhật dữ liệu trong dòng được chọn
                    selectedRow.Cells["MaTrangThaiGiaoHang"].Value = maTrangThai;
                    selectedRow.Cells["TenTrangThai"].Value = tenTrangThai;
                    selectedRow.Cells["MoTa"].Value = moTa;

                    ClearTextBoxs();
                    MessageBox.Show("Lưu sửa đổi thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa đổi dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxs()
        {
            txtMaTrangThaiGiaoHang.Text = string.Empty;
            txtTenTrangThai.Text = string.Empty;
            txtMoTa.Text = string.Empty;
        }

        private void dgvFormOrderTrangThaiGiaoHang_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvTrangThaiGiaoHang.CurrentRow;
            if (dr != null)
            {
                // Lấy thông tin từ dòng được chọn và đổ vào các TextBox
                txtMaTrangThaiGiaoHang.Text = (dr.Cells["MaTrangThaiGiaoHang"].Value ?? string.Empty).ToString();
                txtTenTrangThai.Text = (dr.Cells["TenTrangThai"].Value ?? string.Empty).ToString();
                txtMoTa.Text = (dr.Cells["MoTa"].Value ?? string.Empty).ToString();
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem dgvFormOrderTrangThaiGiaoHang có khác null hay không
                if (dgvTrangThaiGiaoHang != null)
                {
                    // Tạo một số ngẫu nhiên từ 1000 đến 99999
                    Random random = new Random();
                    int randomNumber = random.Next(1000, 99999);

                    // Tạo tên tệp Excel với số ngẫu nhiên
                    string tenTepExcel = $"DanhSachTrangThaiGiaoHang_{randomNumber}.xlsx";

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
                            // Tạo một Sheet có tên là "DanhSachTrangThaiGiaoHang"
                            var worksheet = package.Workbook.Worksheets.Add("DanhSachTrangThaiGiaoHang");

                            // Đặt tiêu đề cho các cột từ DataGridView (hàng đầu tiên)
                            for (int col = 1; col <= dgvTrangThaiGiaoHang.Columns.Count; col++)
                            {
                                worksheet.Cells[1, col].Value = dgvTrangThaiGiaoHang.Columns[col - 1].HeaderText;
                            }
                            for (int col = 1; col <= dgvTrangThaiGiaoHang.Columns.Count; col++)
                            {
                                worksheet.Cells[2, col].Value = dgvTrangThaiGiaoHang.Columns[col - 1].DataPropertyName;
                            }

                            // Đổ dữ liệu từ DataGridView vào Excel bắt đầu từ hàng thứ hai
                            for (int row = 0; row < dgvTrangThaiGiaoHang.Rows.Count; row++)
                            {
                                for (int col = 0; col < dgvTrangThaiGiaoHang.Columns.Count; col++)
                                {
                                    // Kiểm tra xem Cell có giá trị null hay không
                                    if (dgvTrangThaiGiaoHang.Rows[row].Cells[col].Value != null)
                                    {
                                        worksheet.Cells[row + 3, col + 1].Value = dgvTrangThaiGiaoHang.Rows[row].Cells[col].Value.ToString();
                                    }
                                    else
                                    {
                                        worksheet.Cells[row + 3, col + 1].Value = string.Empty;
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
                else
                {
                    MessageBox.Show("Danh sách trống hoặc chưa được khởi tạo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        // Đảm bảo rằng số cột trong Excel khớp với số cột trong DataGridView của bạn
                        if (colCount != dgvTrangThaiGiaoHang.Columns.Count)
                        {
                            MessageBox.Show("Số cột trong tệp Excel không khớp với số cột trong DataGridView.");
                            return;
                        }

                        // Xóa dữ liệu hiện tại trong DataGridView
                        dgvTrangThaiGiaoHang.DataSource = null;

                        // Lặp qua từng dòng trong sheet để kiểm tra và tránh nhập dữ liệu trùng
                        for (int row = 3; row <= rowCount; row++) // Bắt đầu từ hàng thứ ba
                        {
                            string maTrangThaiGiaoHang = worksheet.Cells[row, 1].Value.ToString(); // Giả sử cột đầu tiên là mã trạng thái giao hàng

                            // Kiểm tra xem mã trạng thái giao hàng đã tồn tại trong DataGridView chưa
                            bool trung = false;
                            foreach (DataGridViewRow existingRow in dgvTrangThaiGiaoHang.Rows)
                            {
                                if (existingRow.Cells[0].Value != null && existingRow.Cells[0].Value.ToString() == maTrangThaiGiaoHang)
                                {
                                    trung = true;
                                    break;
                                }
                            }

                            // Nếu không trùng, thêm dòng vào DataGridView
                            if (!trung)
                            {
                                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                                dataGridViewRow.CreateCells(dgvTrangThaiGiaoHang);

                                for (int col = 1; col <= colCount; col++)
                                {
                                    dataGridViewRow.Cells[col - 1].Value = worksheet.Cells[row, col].Value.ToString();
                                }

                                dgvTrangThaiGiaoHang.Rows.Add(dataGridViewRow);
                            }
                        }

                        MessageBox.Show("Nhập dữ liệu từ tệp Excel thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhập dữ liệu từ tệp Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFormOrderTrangThaiGiaoHang_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Lấy số thứ tự của hàng (bắt đầu từ 1)
            int rowIndex = e.RowIndex + 1;

            // Tạo một brush để vẽ số thứ tự
            using (SolidBrush brush = new SolidBrush(dgvTrangThaiGiaoHang.RowHeadersDefaultCellStyle.ForeColor))
            {
                // Xác định vị trí để vẽ số thứ tự trên hàng tiêu đề
                float x = e.RowBounds.Left + 10; // Điều chỉnh vị trí xuất phát theo ý muốn
                float y = e.RowBounds.Top + (e.RowBounds.Height - e.InheritedRowStyle.Font.Height) / 2;

                // Vẽ số thứ tự
                e.Graphics.DrawString(rowIndex.ToString(), e.InheritedRowStyle.Font, brush, x, y);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy danh sách dữ liệu hiện tại từ DataGridView
                List<DTOTrangThaiGiaoHang> dataList = (List<DTOTrangThaiGiaoHang>)dgvTrangThaiGiaoHang.DataSource;

                if (dataList != null)
                {
                    foreach (var item in dataList)
                    {
                        // Mã hóa MaTrangThaiGiaoHang
                        item.MaTrangThaiGiaoHang = Encrypt(item.MaTrangThaiGiaoHang);

                        // Mã hóa TenTrangThai
                        item.TenTrangThai = Encrypt(item.TenTrangThai);
                    }

                    // Cập nhật lại DataGridView
                    dgvTrangThaiGiaoHang.DataSource = null; // Xóa dữ liệu hiện tại
                    dgvTrangThaiGiaoHang.DataSource = dataList; // Gán danh sách mới

                    // Lưu dữ liệu đã mã hóa vào tệp App.Config
                    SaveEncryptedDataToConfig(dataList);

                    MessageBox.Show("Mã hóa dữ liệu thành công và lưu vào App.Config!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mã hóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lưu dữ liệu đã mã hóa vào tệp App.Config
        private void SaveEncryptedDataToConfig(List<DTOTrangThaiGiaoHang> dataList)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Xóa toàn bộ dữ liệu trong AppSettings
            config.AppSettings.Settings.Clear();

            // Lưu từng dòng dữ liệu đã mã hóa vào AppSettings
            for (int i = 0; i < dataList.Count; i++)
            {
                config.AppSettings.Settings.Add(dataList[i].MaTrangThaiGiaoHang, dataList[i].TenTrangThai);
            }

            // Lưu thay đổi
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }

        // Lấy dữ liệu đã mã hóa từ tệp App.Config
        private List<DTOTrangThaiGiaoHang> GetEncryptedDataFromConfig()
        {
            List<DTOTrangThaiGiaoHang> encryptedDataList = new List<DTOTrangThaiGiaoHang>();
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                string value = config.AppSettings.Settings[key].Value;
                encryptedDataList.Add(new DTOTrangThaiGiaoHang
                {
                    MaTrangThaiGiaoHang = key,
                    TenTrangThai = value
                });
            }

            return encryptedDataList;
        }


        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu đã mã hóa từ tệp App.Config
                List<DTOTrangThaiGiaoHang> encryptedDataList = GetEncryptedDataFromConfig();

                if (encryptedDataList != null)
                {
                    foreach (var item in encryptedDataList)
                    {
                        // Giải mã MaTrangThaiGiaoHang
                        item.MaTrangThaiGiaoHang = Decrypt(item.MaTrangThaiGiaoHang);

                        // Giải mã TenTrangThai
                        item.TenTrangThai = Decrypt(item.TenTrangThai);
                    }

                    // Hiển thị dữ liệu giải mã trong DataGridView
                    dgvTrangThaiGiaoHang.DataSource = null; // Xóa dữ liệu hiện tại
                    dgvTrangThaiGiaoHang.DataSource = encryptedDataList; // Gán danh sách đã giải mã

                    // Hỏi người dùng vị trí lưu tệp văn bản đã giải mã
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text Files|*.txt";
                    saveFileDialog.FileName = "DecryptedData.txt";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        // Lưu dữ liệu đã giải mã vào tệp văn bản
                        SaveDecryptedDataToTextFile(encryptedDataList, filePath);

                        MessageBox.Show("Giải mã dữ liệu thành công và lưu vào tệp văn bản!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi giải mã dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Lưu dữ liệu đã giải mã vào tệp văn bản
        private void SaveDecryptedDataToTextFile(List<DTOTrangThaiGiaoHang> dataList, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var item in dataList)
                {
                    writer.WriteLine($"MaTrangThaiGiaoHang: {item.MaTrangThaiGiaoHang}, TenTrangThai: {item.TenTrangThai}");
                }
            }
        }


        // Hàm mã hóa văn bản sử dụng AES
        private string Encrypt(string input)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes("1234567890123456"); // Thay thế bằng khóa mã hóa của bạn
                aesAlg.IV = Encoding.UTF8.GetBytes("1234567890123456"); // Thay thế bằng vector khởi tạo của bạn

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(input);
                    }

                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        // Hàm giải mã văn bản sử dụng AES
        private string Decrypt(string cipherText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes("1234567890123456"); // Thay thế bằng khóa mã hóa của bạn
                aesAlg.IV = Encoding.UTF8.GetBytes("1234567890123456"); // Thay thế bằng vector khởi tạo của bạn

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }
}
