using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private string filePath = @"D:\Intern\GitHub\repo\InternGonSa\20-10\WebAPI\WebAPI\ListNhanVien.json";

        // GET: api/NhanVien
        [HttpGet]
        public IActionResult GetNhanViens(string maNhanVien = null)
        {
            try
            {
                string json = System.IO.File.ReadAllText(filePath);
                var nhanViens = JsonSerializer.Deserialize<List<NhanVien>>(json);

                if (string.IsNullOrEmpty(maNhanVien))
                {
                    return Ok(nhanViens);
                }

                var nhanVien = nhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien);
                if (nhanVien == null)
                    return NotFound("Không tìm thấy nhân viên");
                return Ok(nhanVien);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateOrUpdateNhanViens([FromBody] List<NhanVien> nhanViensToAdd)
        {
            try
            {
                string json = System.IO.File.ReadAllText(filePath);
                var existingNhanViens = JsonSerializer.Deserialize<List<NhanVien>>(json);

                var maNhanViensAdded = new List<string>();
                var maNhanViensUpdated = new List<string>();

                foreach (var nv in nhanViensToAdd)
                {
                    var existingNv = existingNhanViens.FirstOrDefault(n => n.MaNhanVien == nv.MaNhanVien);
                    if (existingNv == null)
                    {
                        nv.MaNhanVien = GenerateEmployeeCode(nv.ChucVu, existingNhanViens);
                        existingNhanViens.Add(nv);
                        maNhanViensAdded.Add(nv.MaNhanVien);
                    }
                    else
                    {
                        if (existingNv.ChucVu != nv.ChucVu)
                        {
                            // Lưu trữ chức vụ cũ
                            string oldChucVu = existingNv.ChucVu;

                            // Cập nhật mã nhân viên dựa trên chức vụ mới
                            nv.MaNhanVien = GenerateEmployeeCode(nv.ChucVu, existingNhanViens);

                            // Cập nhật chức vụ mới cho nhân viên cũ
                            existingNv.ChucVu = nv.ChucVu;

                            // Cập nhật mã nhân viên dựa trên chức vụ mới
                            UpdateEmployeeCodes(existingNhanViens, nv.ChucVu);

                            maNhanViensUpdated.Add(existingNv.MaNhanVien);
                        }

                        // Cập nhật thông tin nhân viên (ngoại trừ chức vụ)
                        existingNv.TenNhanVien = nv.TenNhanVien;
                        existingNv.NgaySinh = nv.NgaySinh;
                        existingNv.Email = nv.Email;
                        existingNv.SDT = nv.SDT;
                        existingNv.DiaChi = nv.DiaChi;
                    }
                }

                // Sắp xếp danh sách theo mã nhân viên
                existingNhanViens = existingNhanViens.OrderBy(nv => nv.MaNhanVien).ToList();

                System.IO.File.WriteAllText(filePath, JsonSerializer.Serialize(existingNhanViens));

                if (maNhanViensAdded.Count > 0)
                {
                    return Ok($"Các nhân viên có mã {string.Join(", ", maNhanViensAdded)} đã được thêm vào danh sách.");
                }
                else if (maNhanViensUpdated.Count > 0)
                {
                    return Ok($"Các nhân viên có mã {string.Join(", ", maNhanViensUpdated)} đã được cập nhật.");
                }
                else
                {
                    return Ok("Không có thay đổi nào.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        private string GenerateEmployeeCode(string chucVu, List<NhanVien> existingNhanViens)
        {
            // Đếm số lượng nhân viên hiện có với cùng chức vụ
            int count = existingNhanViens.Count(nv => nv.ChucVu == chucVu);

            // Tạo mã nhân viên dựa trên chức vụ và số lượng nhân viên
            string code = chucVu switch
            {
                "Backend" => $"BE{count + 1:D5}",
                "Frontend" => $"FE{count + 1:D5}",
                "Teamlead" => $"TL{count + 1:D5}",
                _ => throw new ArgumentException("Chức vụ không hợp lệ."),
            };

            return code;
        }

        private void UpdateEmployeeCodes(List<NhanVien> nhanViens, string chucVu)
        {
            int count = 0;

            foreach (var nv in nhanViens)
            {
                if (nv.ChucVu == chucVu)
                {
                    count++;
                    nv.MaNhanVien = GenerateEmployeeCodeDelete(chucVu, count);
                }
            }
        }

        private string GenerateEmployeeCodeDelete(string chucVu, int count)
        {
            // Tạo mã nhân viên dựa trên chức vụ và số lượng nhân viên
            string code = chucVu switch
            {
                "Backend" => $"BE{count:D5}",
                "Frontend" => $"FE{count:D5}",
                "Teamlead" => $"TL{count:D5}",
                _ => throw new ArgumentException("Chức vụ không hợp lệ."),
            };

            return code;
        }

        // DELETE: api/NhanVien/NV001
        [HttpDelete("{maNhanVien}")]
        public IActionResult DeleteNhanVien(string maNhanVien)
        {
            try
            {
                // Lấy danh sách nhân viên từ tệp JSON
                string json = System.IO.File.ReadAllText(filePath);
                var nhanViens = JsonSerializer.Deserialize<List<NhanVien>>(json);

                // Tìm và xóa nhân viên
                var nhanVien = nhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien);
                if (nhanVien == null)
                    return NotFound("Không tìm thấy nhân viên");

                // Lấy chức vụ của nhân viên
                string chucVu = nhanVien.ChucVu;

                // Xóa nhân viên khỏi danh sách
                nhanViens.Remove(nhanVien);

                // Cập nhật lại mã nhân viên cho những người cùng chức vụ
                UpdateEmployeeCodes(nhanViens, chucVu);

                // Lưu lại danh sách đã cập nhật vào tệp JSON
                System.IO.File.WriteAllText(filePath, JsonSerializer.Serialize(nhanViens));

                return Ok("Nhân viên đã được xóa khỏi danh sách.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
