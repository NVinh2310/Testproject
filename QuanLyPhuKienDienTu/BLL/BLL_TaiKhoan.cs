using QuanLyPhuKienDienTu.DAO;
using QuanLyPhuKienDienTu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.BLL
{
    class BLL_TaiKhoan
    {
        private static BLL_TaiKhoan instance;
        public static BLL_TaiKhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLL_TaiKhoan();
                return BLL_TaiKhoan.instance;
            }
            private set { instance = value; }
        }

        private BLL_TaiKhoan() {}

        public List<TaiKhoan_View> GetTaiKhoan()
        {
            return DAO_TaiKhoan.Instance.GetTaiKhoan();
        }

        public List<TaiKhoan_View> GetTaiKhoanBangTen(string name)
        {
            return DAO_TaiKhoan.Instance.GetTaiKhoanBangTen(name);
        }

        public bool ThemTaiKhoan(TaiKhoan taiKhoan)
        {
            return DAO_TaiKhoan.Instance.ThemTaiKhoan(taiKhoan);
        }

        public bool XoaTaiKhoan(int id)
        {
            return DAO_TaiKhoan.Instance.XoaTaiKhoan(id);
        }

        public bool DangNhap(string username, string password)
        {
            return DAO_TaiKhoan.Instance.DangNhap(username, password);
        }

        public bool DoiMatKhau(string username, string password, string newPassword)
        {
            int id = DAO_TaiKhoan.Instance.LayIDTaiKhoan(username, password);

            return DAO_TaiKhoan.Instance.DoiMatKhau(id, newPassword);
        }

        public bool TenTaiKhoanHopLe(string username)
        {
            return DAO_TaiKhoan.Instance.TenTaiKhoanHopLe(username);
        }
    }
}
