using QuanLyPhuKienDienTu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DAO
{
    class DAO_TaiKhoan
    {
        private static DAO_TaiKhoan instance;
        public static DAO_TaiKhoan Instance
        {
            get
            {
                if (instance == null) 
                    instance = new DAO_TaiKhoan();
                return DAO_TaiKhoan.instance;
            }
            private set { instance = value; }
        }

        private DAO_TaiKhoan() { }

        public bool DangNhap(string username, string password)
        {
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                try
                {
                    int data = db.TaiKhoans.
                        Where(p => p.Username == username && p.Password == password).
                        Count();
                    if (data == 1)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool TenTaiKhoanHopLe(string username)
        {
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                try
                {
                    int data = db.TaiKhoans.Where(p => p.Username == username).Count();
                    if (data == 0)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public int LayIDTaiKhoan(string username, string password)
        {
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                try
                {
                    var data = from taikhoan in db.TaiKhoans
                               where (taikhoan.Username == username && taikhoan.Password == password)
                               select taikhoan;

                    foreach (var item in data)
                    {
                        return item.MaTaiKhoan;
                    }

                    return -1;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public bool DoiMatKhau(int id, string newPassword)
        {
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                try
                {
                    TaiKhoan account = db.TaiKhoans.Find(id);
                    account.Password = newPassword;
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
        }

        public List<TaiKhoan_View> GetTaiKhoan()
        {
            List<TaiKhoan_View> accounts = new List<TaiKhoan_View>();

            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                foreach (var item in db.TaiKhoans.ToList())
                {
                    accounts.Add(new TaiKhoan_View()
                    {
                        MaTaiKhoan = item.MaTaiKhoan,
                        TenNhanVien = item.NhanVien.TenNhanVien,
                        Username = item.Username,
                        TrangThai = (item.NhanVien.TrangThai == 1) ? "Quản lý" : "Nhân viên"
                    });
                }
            }

            return accounts;
        }

        public List<TaiKhoan_View> GetTaiKhoanBangTen(string name)
        {
            List<TaiKhoan_View> accounts = new List<TaiKhoan_View>();

            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                var data = db.TaiKhoans.Where(p => p.NhanVien.TenNhanVien.Contains(name)).ToList();
                foreach (var item in data)
                {
                    accounts.Add(new TaiKhoan_View()
                    {
                        MaTaiKhoan = item.MaTaiKhoan,
                        TenNhanVien = item.NhanVien.TenNhanVien,
                        Username = item.Username,
                        TrangThai = (item.NhanVien.TrangThai == 1) ? "Quản lý" : "Nhân viên"
                    });
                }
            }

            return accounts;
        }

        public bool ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                try
                {
                    db.TaiKhoans.Add(taiKhoan);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
        }

        public bool XoaTaiKhoan(int id)
        {
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                try
                {
                    TaiKhoan taikhoan = db.TaiKhoans.Find(id);
                    db.TaiKhoans.Remove(taikhoan);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
