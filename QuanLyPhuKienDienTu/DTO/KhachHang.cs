using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DTO
{
    class KhachHang
    {
        
        public int MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public KhachHang()
        {

        }
        public KhachHang(int MakhachHang, string TenKhachHang, string DiaChi, string SoDienThoai)
        {
            this.MaKhachHang = MaKhachHang;
            this.TenKhachHang = TenKhachHang;
            this.DiaChi = DiaChi;
            this.SoDienThoai = SoDienThoai;
        }
    }
}
