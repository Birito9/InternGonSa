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
        private string filePath = @"D:\Intern\GitHub\repo\InternGonSa\12-10\WebAPI\WebAPI\ListNhanVien.json";

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

        // POST: api/NhanVien
        [HttpPost]
        public IActionResult CreateOrUpdateNhanViens([FromBody] List<NhanVien> nhanViensToAdd)
        {
            try
            {
                string json = System.IO.File.ReadAllText(filePath);
                var existingNhanViens = JsonSerializer.Deserialize<List<NhanVien>>(json);

                var maNhanViensAdded = new List<string>();

                foreach (var nv in nhanViensToAdd)
                {
                    var existingNv = existingNhanViens.FirstOrDefault(n => n.MaNhanVien == nv.MaNhanVien);
                    if (existingNv == null)
                    {
                        existingNhanViens.Add(nv);
                        maNhanViensAdded.Add(nv.MaNhanVien);
                    }
                    else
                    {
                        existingNv.TenNhanVien = nv.TenNhanVien;
                        existingNv.NgaySinh = nv.NgaySinh;
                        existingNv.Email = nv.Email;
                        existingNv.SDT = nv.SDT;
                        existingNv.DiaChi = nv.DiaChi;
                    }
                }

                System.IO.File.WriteAllText(filePath, JsonSerializer.Serialize(existingNhanViens));

                if (maNhanViensAdded.Count > 0)
                {
                    return Ok($"Các nhân viên có mã {string.Join(", ", maNhanViensAdded)} đã được thêm vào danh sách.");
                }
                else
                {
                    return Ok("Các nhân viên đã được cập nhật.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // DELETE: api/NhanVien/NV001
        [HttpDelete("{maNhanVien}")]
        public IActionResult DeleteNhanVien(string maNhanVien)
        {
            try
            {
                string json = System.IO.File.ReadAllText(filePath);
                var nhanViens = JsonSerializer.Deserialize<List<NhanVien>>(json);
                var nhanVien = nhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien);
                if (nhanVien == null)
                    return NotFound("Không tìm thấy nhân viên");
                nhanViens.Remove(nhanVien);
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
