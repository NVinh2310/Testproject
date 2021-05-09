using QuanLyPhuKienDienTu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DAO
{
    class DAO_SanPham
    {
        private static DAO_SanPham instance;
        public static DAO_SanPham Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAO_SanPham();
                return DAO_SanPham.instance;
            }
            private set { instance = value; }
        }
        public List<SanPham_View> GetSanPhamView()
        {
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                var list = (from i in db.SanPhams select new SanPham_View 
                { 
                    MaSanPham =i.MaSanPham,
                    TenSanPham = i.TenSanPham,
                    TenLoai=i.Loai.TenLoai, 
                    TenThuongHieu =i.ThuongHieu.TenThuongHieu,
                    SoLuongTonKho = i.SoLuongTonKho,
                    MauSac =i.MauSac,
                    MoTa =i.MoTa,
                    ThoiLuongBaoHanh=i.ThoiLuongBaoHanh,
                    GiaBan=i.GiaBan
                });
                return list.ToList();
            }
        }
    }

}
