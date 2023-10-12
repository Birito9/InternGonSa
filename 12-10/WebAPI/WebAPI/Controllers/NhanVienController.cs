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
        public IActionResult GetNhanViens()
        {
            try
            {
                string json = System.IO.File.ReadAllText(filePath);
                var nhanViens = JsonSerializer.Deserialize<List<NhanVien>>(json);
                return Ok(nhanViens);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/NhanVien/NV001
        [HttpGet("{maNhanVien}")]
        public IActionResult GetNhanVien(string maNhanVien)
        {
            try
            {
                string json = System.IO.File.ReadAllText(filePath);
                var nhanViens = JsonSerializer.Deserialize<List<NhanVien>>(json);
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
        public IActionResult CreateNhanVien([FromBody] NhanVien nhanVien)
        {
            try
            {
                string json = System.IO.File.ReadAllText(filePath);
                var nhanViens = JsonSerializer.Deserialize<List<NhanVien>>(json);
                nhanViens.Add(nhanVien);
                System.IO.File.WriteAllText(filePath, JsonSerializer.Serialize(nhanViens));
                return Ok("Nhân viên đã được thêm vào danh sách.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/NhanVien/NV001
        [HttpPut("{maNhanVien}")]
        public IActionResult UpdateNhanVien(string maNhanVien, [FromBody] NhanVien updatedNhanVien)
        {
            try
            {
                string json = System.IO.File.ReadAllText(filePath);
                var nhanViens = JsonSerializer.Deserialize<List<NhanVien>>(json);
                var nhanVien = nhanViens.FirstOrDefault(nv => nv.MaNhanVien == maNhanVien);
                if (nhanVien == null)
                    return NotFound("Không tìm thấy nhân viên");
                nhanVien.TenNhanVien = updatedNhanVien.TenNhanVien;
                nhanVien.NgaySinh = updatedNhanVien.NgaySinh;
                nhanVien.Email = updatedNhanVien.Email;
                nhanVien.SDT = updatedNhanVien.SDT;
                nhanVien.DiaChi = updatedNhanVien.DiaChi;
                System.IO.File.WriteAllText(filePath, JsonSerializer.Serialize(nhanViens));
                return Ok("Nhân viên đã được cập nhật.");
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
