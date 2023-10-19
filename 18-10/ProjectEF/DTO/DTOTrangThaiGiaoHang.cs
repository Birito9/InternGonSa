using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOTrangThaiGiaoHang
    {
        public string MaTrangThaiGiaoHang { get; set; } = null!;
        public string TenTrangThai { get; set; } = null!;
        public string? MoTa { get; set; }
    }
}
