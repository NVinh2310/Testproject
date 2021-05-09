using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DAO
{
    class DAO_KhachHang
    {
        private static DAO_KhachHang instance;
        public static DAO_KhachHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAO_KhachHang();
                return DAO_KhachHang.instance;
            }
            private set { instance = value; }
        }
        private DAO_KhachHang()
        { }
        public List<KhachHang> GetKhachHang()
        {
            List<KhachHang> khachhang = new List<KhachHang>();
            khachhang.AddRange(new KhachHang[]
                {
                    new KhachHang()
                    {
                        MaKhachHang = 1,
                        TenKhachHang = "Nguyễn Hà",
                        DiaChi = "142/6 Nguyễn Trung Trực",
                        SoDienThoai = "023792632"
                    },
                    new KhachHang()
                    {
                        MaKhachHang = 2,
                        TenKhachHang = "Trần My",
                        DiaChi = "122/6 Phạm Văn Đồng",
                        SoDienThoai = "074947944"
                    },
                    new KhachHang()
                    {
                        MaKhachHang = 3,
                        TenKhachHang = "Lê Thị A",
                        DiaChi = "11 Lê Duẩn",
                        SoDienThoai = "9876368739"
                    },

                });
            return khachhang;
        }
    }
}
