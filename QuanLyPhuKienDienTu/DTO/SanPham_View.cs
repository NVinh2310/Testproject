using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DTO
{
    class SanPham_View
    {
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string TenThuongHieu { get; set; }
        public string TenLoai { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTonKho { get; set; }
        public string MauSac { get; set; }
        public string MoTa { get; set; }
        public int ThoiLuongBaoHanh { get; set; }
        
    }
}
