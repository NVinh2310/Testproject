using QuanLyPhuKienDienTu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DAO
{
    class DAO_TaiKhoan_View
    {
        private static DAO_TaiKhoan_View instance;
        public static DAO_TaiKhoan_View Instance
        {
            get
            {
                if (instance == null) 
                    instance = new DAO_TaiKhoan_View();
                return DAO_TaiKhoan_View.instance;
            }
            private set { instance = value; }
        }

        private DAO_TaiKhoan_View() { }

        public List<TaiKhoan_View> GetTaiKhoan()
        {
            List<TaiKhoan_View> accounts = new List<TaiKhoan_View>();

            //using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            //{
            //    foreach (var item in db.TaiKhoans.ToList())
            //    {
            //        accounts.Add(new TaiKhoan_View()
            //        {
            //            MaTaiKhoan = item.MaTaiKhoan,
            //            TenNhanVien = item.NhanVien.TenNhanVien,
            //            Username = item.Username,
            //            TrangThai = (item.NhanVien.TrangThai == 1) ? "Quản lý" : "Nhân viên"
            //        });
            //    }
            //}

            accounts.AddRange(new TaiKhoan_View[] {
                new TaiKhoan_View()
                {
                    MaTaiKhoan = 1, 
                    TenNhanVien = "Bùi Ngọc Thịnh", 
                    Username = "ngocthinh303", 
                    TrangThai = "Nhân viên"
                },
                new TaiKhoan_View()
                {
                    MaTaiKhoan = 2,
                    TenNhanVien = "Nguyễn Văn Vĩnh",
                    Username = "dragonnevadie",
                    TrangThai = "Quản lý"
                },
                new TaiKhoan_View()
                {
                    MaTaiKhoan = 3,
                    TenNhanVien = "Nguyễn Thị Bích Phượng",
                    Username = "phuongngungok",
                    TrangThai = "Nhân viên"
                },
                new TaiKhoan_View()
                {
                    MaTaiKhoan = 4,
                    TenNhanVien = "Karma Sutra",
                    Username = "karmasutra",
                    TrangThai = "Nhân viên"
                },
                new TaiKhoan_View()
                {
                    MaTaiKhoan = 5,
                    TenNhanVien = "ZZ547QWER",
                    Username = "asfdcxb",
                    TrangThai = "Nhân viên"
                }
            });

            return accounts;
        }
    }
}
