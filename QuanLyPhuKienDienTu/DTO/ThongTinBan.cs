using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DTO
{
    class ThongTinBan
    {
        public int MaHoaDonBan { get; set; }
        public string TenKhachHang { get; set; }
        public DateTime NgayBan { get; set; }
        public int TongSoLuong { get; set; }
        public decimal TongGiaBan { get; set; }
    }
}
