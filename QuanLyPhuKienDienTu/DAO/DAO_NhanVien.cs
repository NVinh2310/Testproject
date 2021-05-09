using QuanLyPhuKienDienTu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DAO
{
    class DAO_NhanVien
    {
        private static DAO_NhanVien instance;
        public static DAO_NhanVien Instance
        {
            get 
            {
                if (instance == null)
                    instance = new DAO_NhanVien();
                return DAO_NhanVien.instance;
            }
            private set { instance = value; }
        }

        private DAO_NhanVien() { }

        public int TrangThaiNhanVien(string username)
        {
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                try
                {
                    var data = from nhanvien in db.NhanViens
                               from taikhoan in db.TaiKhoans
                               where (nhanvien.MaNhanVien == taikhoan.MaNhanVien && 
                                        taikhoan.Username == username)
                               select new
                               {
                                   State = nhanvien.TrangThai
                               };

                    foreach (var item in data)
                    {
                        return item.State;
                    }
                    return -1;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public List<NhanVien> GetNhanVienChuaCoTK()
        {
            List<NhanVien> nhanVien = new List<NhanVien>();

            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                var data = from nhanvien in db.NhanViens
                           where !(from taikhoan in db.TaiKhoans select taikhoan.MaNhanVien)
                           .Contains(nhanvien.MaNhanVien)
                           select nhanvien;
                foreach (var item in data)
                {
                    nhanVien.Add(new NhanVien()
                    {
                        MaNhanVien = item.MaNhanVien,
                        TenNhanVien = item.TenNhanVien
                    });
                }
            }

            return nhanVien;
        }
    }
}
