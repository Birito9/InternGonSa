using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace ProjectEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private readonly NhanVienContext _context;

        public NhanVienController(NhanVienContext context)
        {
            _context = context;
        }

        //GET: api/NhanVien
        [HttpGet]
        public async Task<IActionResult> GetNhanViens(string maNhanVien = null)
        {
            try
            {
                if (string.IsNullOrEmpty(maNhanVien))
                {
                    var nhanViens = await _context.NhanViens.ToListAsync();
                    return Ok(nhanViens);
                }
                else
                {
                    var nhanVien = await _context.NhanViens.FirstOrDefaultAsync(nv => nv.MaNhanVien == maNhanVien);
                    if (nhanVien == null)
                        return NotFound("Không tìm thấy nhân viên");
                    return Ok(nhanVien);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<NhanVien>>> PostNhanVien(List<NhanVien> nhanViens)
        {
            if (_context.NhanViens == null)
            {
                return Problem("Entity set 'NhanVienContext.NhanViens' is null.");
            }

            if (nhanViens == null || !nhanViens.Any())
            {
                return BadRequest("Danh sách nhân viên trống.");
            }

            // Danh sách tạm thời để lưu các nhân viên không trùng mã
            var uniqueNhanViens = new List<NhanVien>();

            foreach (var nhanVien in nhanViens)
            {
                var validationResult = ValidateNhanVien(nhanVien);
                if (validationResult != null)
                {
                    return validationResult;
                }

                var maNhanVien = GetUnusedMaNhanVien(nhanVien.ChucVu);
                if (maNhanVien == null)
                {
                    return BadRequest("Không thể tạo mã nhân viên mới.");
                }

                nhanVien.MaNhanVien = maNhanVien;

                // Kiểm tra xem nhanVien có tồn tại trong danh sách tạm thời không
                // Nếu không tồn tại, thêm vào danh sách tạm thời và context
                if (!uniqueNhanViens.Any(x => x.MaNhanVien == nhanVien.MaNhanVien))
                {
                    uniqueNhanViens.Add(nhanVien);
                    _context.NhanViens.Add(nhanVien);
                }
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                return StatusCode(500, "Lỗi khi lưu vào cơ sở dữ liệu.");
            }

            return Ok(uniqueNhanViens);
        }


        private string GetUnusedMaNhanVien(string chucVu)
        {
            int count = _context.NhanViens.Count(nv => nv.ChucVu == chucVu);
            string prefix = "";
            switch (chucVu)
            {
                case "Backend":
                    prefix = "BE";
                    break;
                case "Frontend":
                    prefix = "FE";
                    break;
                case "Teamlead":
                    prefix = "TL";
                    break;
                default:
                    return null;
            }

            // Tìm mã nhân viên chưa được sử dụng
            for (int i = 1; i <= count + 1; i++)
            {
                string maNhanVien = $"{prefix}{i:D4}";
                if (!_context.NhanViens.Any(nv => nv.MaNhanVien == maNhanVien))
                {
                    return maNhanVien;
                }
            }

            return null; // Nếu không tìm thấy mã nhân viên chưa được sử dụng, trả về null hoặc xử lý theo ý của bạn
        }              

        private ActionResult ValidateNhanVien(NhanVien nhanVien)
        {
            if (string.IsNullOrWhiteSpace(nhanVien.ChucVu))
            {
                return BadRequest("Chức vụ không được để trống.");
            }
            return null;
        }

        // PUT: api/NhanVien/UpdateNhanVien/{manhanvien}
        [HttpPut("UpdateNhanVien/{manhanvien}")]
        public async Task<IActionResult> PutNhanVien(string manhanvien, [FromBody] NhanVien nhanVien)
        {
            if (manhanvien != nhanVien.MaNhanVien)
            {
                return BadRequest("Mã nhân viên không khớp với đầu vào.");
            }

            if (!NhanVienExists(manhanvien))
            {
                return NotFound("Không tìm thấy nhân viên.");
            }

            var existingNhanVien = await _context.NhanViens.FindAsync(manhanvien);
            if (existingNhanVien == null)
            {
                return NotFound("Không tìm thấy nhân viên.");
            }

            var updatedNhanVien = new NhanVien
            {
                MaNhanVien = existingNhanVien.MaNhanVien,
                TenNhanVien = nhanVien.TenNhanVien,
                NgaySinh = nhanVien.NgaySinh,
                Email = nhanVien.Email,
                SDT = nhanVien.SDT,
                DiaChi = nhanVien.DiaChi,
                ChucVu = nhanVien.ChucVu
            };

            // Perform automatic update of MaNhanVien based on ChucVu
            updatedNhanVien.MaNhanVien = GetUnusedMaNhanVien(nhanVien.ChucVu);

            // Remove the existing entity from the context and mark it as deleted
            _context.Entry(existingNhanVien).State = EntityState.Deleted;

            // Add the updated entity to the context
            _context.NhanViens.Add(updatedNhanVien);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Lỗi khi cập nhật nhân viên.");
            }

            return NoContent(); // Indicates a successful update with no response body.
        }




        // DELETE: api/NhanVien/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNhanVien(string id)
        {
            if (_context.NhanViens == null)
            {
                return NotFound("Không tìm thấy dữ liệu nhân viên.");
            }
            var nhanVien = await _context.NhanViens.FindAsync(id);
            if (nhanVien == null)
            {
                return NotFound("Không tìm thấy nhân viên.");
            }

            _context.NhanViens.Remove(nhanVien);
            await _context.SaveChangesAsync();

            return Ok("Nhân viên đã được xóa thành công.");
        }


        private bool NhanVienExists(string id)
        {
            return _context.NhanViens != null && _context.NhanViens.Any(e => e.MaNhanVien == id);
        }

    }
}
