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

        ////POST
        //[HttpPost("AddCreNV")]
        //public async Task<ActionResult<IEnumerable<NhanVien>>> PostNhanVien(List<NhanVien> nhanViens)
        //{
        //    if (nhanViens == null || !nhanViens.Any())
        //    {
        //        return BadRequest("Danh sách nhân viên trống.");
        //    }

        //    foreach (var nhanVien in nhanViens)
        //    {
        //        // Kiểm tra xem nhanVien đã tồn tại trong cơ sở dữ liệu hay chưa
        //        if (NhanVienExists(nhanVien.MaNhanVien))
        //        {
        //            var validationResult = ValidateNhanVien(nhanVien);
        //            if (validationResult != null)
        //            {
        //                return validationResult;
        //            }
        //            // Kiểm tra xem chức vụ đã thay đổi
        //            var existingNhanVien = _context.NhanViens.FirstOrDefault(nv => nv.MaNhanVien == nhanVien.MaNhanVien);
        //            if (existingNhanVien != null && existingNhanVien.ChucVu != nhanVien.ChucVu)
        //            {
        //                // Xóa nhân viên hiện tại
        //                _context.NhanViens.Remove(existingNhanVien);

        //                // Tạo mã nhân viên mới dựa trên chức vụ mới
        //                var maNhanVienMoi = GetUnusedMaNhanVien(nhanVien.ChucVu, nhanVien.MaNhanVien);
        //                if (maNhanVienMoi == null)
        //                {
        //                    return BadRequest("Không thể tạo mã nhân viên mới.");
        //                }
        //                nhanVien.MaNhanVien = maNhanVienMoi;

        //                // Thêm nhân viên mới
        //                _context.NhanViens.Add(nhanVien);
        //            }
        //            else
        //            {
        //                // Cập nhật thông tin của nhân viên
        //                _context.Entry(nhanVien).State = EntityState.Modified;
        //            }
        //        }
        //        else
        //        {
        //            // Nhân viên chưa tồn tại, tạo mã nhân viên mới dựa trên chức vụ
        //            var maNhanVien = GetUnusedMaNhanVien(nhanVien.ChucVu, nhanVien.MaNhanVien);
        //            if (maNhanVien == null)
        //            {
        //                return BadRequest("Không thể tạo mã nhân viên mới.");
        //            }
        //            nhanVien.MaNhanVien = maNhanVien;
        //            _context.NhanViens.Add(nhanVien);
        //        }
        //    }

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        return StatusCode(500, "Lỗi khi lưu vào cơ sở dữ liệu.");
        //    }

        //    return Ok(nhanViens);
        //}

        [HttpPost("AddCreNV")]
        public async Task<ActionResult<IEnumerable<NhanVien>>> PostNhanVien(List<NhanVien> nhanViens)
        {
            // Kiểm tra nếu danh sách nhân viên trống hoặc null
            if (nhanViens == null || !nhanViens.Any())
            {
                return BadRequest("Danh sách nhân viên trống.");
            }

            foreach (var nhanVien in nhanViens)
            {
                // Kiểm tra xem nếu nhân viên đã tồn tại trong cơ sở dữ liệu
                if (NhanVienExists(nhanVien.MaNhanVien))
                {
                    // Kiểm tra hợp lệ của thông tin nhân viên
                    var validationResult = ValidateNhanVien(nhanVien);
                    if (validationResult != null)
                    {
                        return validationResult;
                    }

                    // Cập nhật thông tin của nhân viên
                    _context.Entry(nhanVien).State = EntityState.Modified;
                }
                else
                {
                    // Nhân viên chưa tồn tại, tạo mã nhân viên mới dựa trên chức vụ
                    var maNhanVien = GetUnusedMaNhanVien(nhanVien.ChucVu, nhanVien.MaNhanVien);
                    if (maNhanVien == null)
                    {
                        return BadRequest("Không thể tạo mã nhân viên mới.");
                    }
                    nhanVien.MaNhanVien = maNhanVien;

                    // Thêm nhân viên mới vào cơ sở dữ liệu
                    _context.NhanViens.Add(nhanVien);
                }
            }

            try
            {
                // Lưu các thay đổi vào cơ sở dữ liệu
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                return StatusCode(500, "Lỗi khi lưu vào cơ sở dữ liệu.");
            }

            // Trả về kết quả thành công
            return Ok(nhanViens);
        }

        private string GetUnusedMaNhanVien(string chucVu, string existingMaNhanVien = null)
        {
            int count = _context.NhanViens.Count(nv => nv.ChucVu == chucVu);
            string prefix = GetChucVuPrefix(chucVu);

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

        private string GetChucVuPrefix(string chucVu)
        {
            switch (chucVu)
            {
                case "Backend":
                    return "BE";
                case "Frontend":
                    return "FE";
                case "Teamlead":
                    return "TL";
                default:
                    return string.Empty;
            }
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
