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
        [HttpGet("GetNV")]
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

        [HttpPost("AddCreNV")]
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

            foreach (var nhanVien in nhanViens)
            {
                var validationResult = ValidateNhanVien(nhanVien);
                if (validationResult != null)
                {
                    return validationResult;
                }

                // Kiểm tra xem nhanVien đã tồn tại trong cơ sở dữ liệu hay chưa
                if (NhanVienExists(nhanVien.MaNhanVien))
                {
                    // Nếu nhân viên đã tồn tại, hãy cập nhật thông tin của nhân viên này thay vì tạo mới mã nhân viên
                    _context.Entry(nhanVien).State = EntityState.Modified;
                }
                else
                {
                    // Nếu nhân viên chưa tồn tại, tạo mã nhân viên mới
                    var maNhanVien = GetUnusedMaNhanVien(nhanVien.ChucVu, nhanVien.MaNhanVien);
                    if (maNhanVien == null)
                    {
                        return BadRequest("Không thể tạo mã nhân viên mới.");
                    }
                    nhanVien.MaNhanVien = maNhanVien;
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

            return Ok(nhanViens);
        }


        private string GetUnusedMaNhanVien(string chucVu, string existingMaNhanVien = null)
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

                // Nếu mã nhân viên chưa được sử dụng hoặc là mã của nhân viên cần update, trả về mã này
                if (!_context.NhanViens.Any(nv => nv.MaNhanVien == maNhanVien) || maNhanVien == existingMaNhanVien)
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

        
        private bool NhanVienExists(string id)
        {
            return _context.NhanViens != null && _context.NhanViens.Any(e => e.MaNhanVien == id);
        }

       


        // DELETE: api/NhanVien/5
        [HttpDelete("DeleteNV/{id}")]
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




    }
}
