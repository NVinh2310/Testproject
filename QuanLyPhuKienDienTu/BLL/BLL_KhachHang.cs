using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhuKienDienTu.DAO;

namespace QuanLyPhuKienDienTu.BLL
{
    class BLL_KhachHang
    {
        private static BLL_KhachHang instance;
        public static BLL_KhachHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLL_KhachHang();
                return BLL_KhachHang.instance;
            }
            private set { instance = value; }
        }

        private BLL_KhachHang() { }

        public List<KhachHang> GetKhachHang()
        {
            return DAO_KhachHang.Instance.GetKhachHang();
        }
    }
}
