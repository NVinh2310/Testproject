using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DTO
{
    class SanPham
    {
        public int MaSanPham { get; set; }
        public int MaThuongHieu { get; set; }
        public int MaLoai { get; set; }
        public string TenSanPham { get; set; }
        public string MauSac { get; set; }
        public string MoTa { get; set; }
        public decimal GiaBan { get; set; }
        public decimal GiaNhap { get; set; }
        public DateTime ThoiGianBaoHanh { get; set; }
        public SanPham()
        {

        }
        public SanPham (int MaSanPham, int MaThuongHieu, int MaLoai, string TenSanPham, string MauSac, string Mota, decimal GiaBan, decimal GiaNhap, DateTime ThoiGianBaoHanh)
        {
            this.MaSanPham = MaSanPham;
            this.MaThuongHieu = MaThuongHieu;
            this.MaLoai = MaLoai;
            this.TenSanPham = TenSanPham;
            this.MauSac = MauSac;
            this.MoTa = MoTa;
            this.GiaBan = GiaBan;
            this.GiaBan = GiaNhap;
            this.ThoiGianBaoHanh = ThoiGianBaoHanh;
        }
    }

}
