using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyPhuKienDienTu.DAO;
using QuanLyPhuKienDienTu.DTO;

namespace QuanLyPhuKienDienTu.BLL
{
    class BLL_SanPham
    {
        private static BLL_SanPham instance;
        public static BLL_SanPham Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLL_SanPham();
                return BLL_SanPham.instance;
            }
            private set { instance = value; }
        }

        private BLL_SanPham() { }

        public List<SanPham> GetKhachHang()
        {
            return BLL_SanPham.Instance.GetKhachHang();
        }
        public List<SanPham_View> GetSanPham_Views(string tensp, string loai, string thuonghieu , string gia )
        {
            List<SanPham_View> list = new List<SanPham_View>();
            foreach(SanPham_View i in DAO.DAO_SanPham.Instance.GetSanPhamView())
            {
                if(tensp =="All")
                {
                    if(loai=="All")
                    {
                        if(thuonghieu=="All")
                        {
                            if (gia == "All")
                                list.Add(i);
                            else
                            {
                                switch(gia)
                                {
                                    case "Dưới 5 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) < 5000000)
                                            list.Add(i);
                                        break;
                                    case "5-10 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 5000000 && Convert.ToDecimal(i.GiaBan) < 10000000)
                                            list.Add(i);
                                        break;
                                    case "10-30 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 10000000 && Convert.ToDecimal(i.GiaBan) < 30000000)
                                            list.Add(i);
                                        break;
                                    case "Trên 30 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 30000000)
                                            list.Add(i);
                                        break;
                                }
                            }
                        }
                        else
                        {
                            if (gia == "All"&& i.TenThuongHieu ==thuonghieu)
                                list.Add(i);
                            else
                            {
                                switch (gia)
                                {
                                    case "Dưới 5 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) < 5000000 && i.TenThuongHieu == thuonghieu)
                                            list.Add(i);
                                        break;
                                    case "5-10 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 5000000 && Convert.ToDecimal(i.GiaBan) < 10000000 && i.TenThuongHieu == thuonghieu)
                                            list.Add(i);
                                        break;
                                    case "10-30 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 10000000 && Convert.ToDecimal(i.GiaBan) < 30000000 && i.TenThuongHieu == thuonghieu)
                                            list.Add(i);
                                        break;
                                    case "Trên 30 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 30000000)
                                            list.Add(i);
                                        break;
                                }
                            }
                        }    
                    }
                    else
                    {
                        if (thuonghieu == "All" && i.TenLoai ==loai)
                        {
                            if (gia == "All"&&i.TenLoai == loai)
                                list.Add(i);
                            else
                            {
                                switch (gia)
                                {
                                    case "Dưới 5 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) < 5000000 && i.TenLoai == loai)
                                            list.Add(i);
                                        break;
                                    case "5-10 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 5000000 && Convert.ToDecimal(i.GiaBan) < 10000000 && i.TenLoai == loai)
                                            list.Add(i);
                                        break;
                                    case "10-30 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 10000000 && Convert.ToDecimal(i.GiaBan) < 30000000 && i.TenLoai == loai)
                                            list.Add(i);
                                        break;
                                    case "Trên 30 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 30000000 && i.TenLoai == loai)
                                            list.Add(i);
                                        break;
                                }
                            }
                        }
                        else
                        {
                            if (gia == "All" && i.TenThuongHieu == thuonghieu && i.TenLoai == loai)
                                list.Add(i);
                            else
                            {
                                switch (gia)
                                {
                                    case "Dưới 5 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) < 5000000 && i.TenThuongHieu == thuonghieu && i.TenLoai == loai)
                                            list.Add(i);
                                        break;
                                    case "5-10 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 5000000 && Convert.ToDecimal(i.GiaBan) < 10000000 && i.TenThuongHieu == thuonghieu && i.TenLoai == loai)
                                            list.Add(i);
                                        break;
                                    case "10-30 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 10000000 && Convert.ToDecimal(i.GiaBan) < 30000000 && i.TenThuongHieu == thuonghieu && i.TenLoai == loai)
                                            list.Add(i);
                                        break;
                                    case "Trên 30 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 30000000 && i.TenLoai == loai)
                                            list.Add(i);
                                        break;
                                }
                            }
                        }
                    }    
                }
                else
                {
                    if (loai == "All" && i.TenSanPham.Contains(tensp))
                    {
                        if (thuonghieu == "All" && i.TenSanPham.Contains(tensp))
                        {
                            if (gia == "All" && i.TenSanPham.Contains(tensp))
                                list.Add(i);
                            else
                            {
                                switch (gia)
                                {
                                    case "Dưới 5 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) < 5000000 && i.TenSanPham.Contains(tensp))
                                            list.Add(i);
                                        break;
                                    case "5-10 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 5000000 && Convert.ToDecimal(i.GiaBan) < 10000000 && i.TenSanPham.Contains(tensp))
                                            list.Add(i);
                                        break;
                                    case "10-30 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 10000000 && Convert.ToDecimal(i.GiaBan) < 30000000 && i.TenSanPham.Contains(tensp))
                                            list.Add(i);
                                        break;
                                    case "Trên 30 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 30000000 && i.TenSanPham.Contains(tensp))
                                            list.Add(i);
                                        break;
                                }
                            }
                        }
                        else
                        {
                            if (gia == "All" && i.TenThuongHieu == thuonghieu && i.TenSanPham.Contains(tensp))
                                list.Add(i);
                            else
                            {
                                switch (gia)
                                {
                                    case "Dưới 5 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) < 5000000 && i.TenThuongHieu == thuonghieu && i.TenSanPham.Contains(tensp))
                                            list.Add(i);
                                        break;
                                    case "5-10 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 5000000 && Convert.ToDecimal(i.GiaBan) < 10000000 && i.TenThuongHieu == thuonghieu && i.TenSanPham.Contains(tensp))
                                            list.Add(i);
                                        break;
                                    case "10-30 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 10000000 && Convert.ToDecimal(i.GiaBan) < 30000000 && i.TenThuongHieu == thuonghieu && i.TenSanPham.Contains(tensp))
                                            list.Add(i);
                                        break;
                                    case "Trên 30 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 30000000 && i.TenSanPham.Contains(tensp))
                                            list.Add(i);
                                        break;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (thuonghieu == "All" && i.TenLoai == loai && i.TenSanPham.Contains(tensp))
                        {
                            if (gia == "All" && i.TenLoai == loai && i.TenSanPham.Contains(tensp))
                                list.Add(i);
                            else
                            {
                                switch (gia)
                                {
                                    case "Dưới 5 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) < 5000000 && i.TenLoai == loai && i.TenSanPham.Contains(tensp))
                                            list.Add(i);
                                        break;
                                    case "5-10 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 5000000 && Convert.ToDecimal(i.GiaBan) < 10000000 && i.TenLoai == loai && i.TenSanPham.Contains(tensp))
                                            list.Add(i);
                                        break;
                                    case "10-30 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 10000000 && Convert.ToDecimal(i.GiaBan) < 30000000 && i.TenLoai == loai && i.TenSanPham.Contains(tensp))
                                            list.Add(i);
                                        break;
                                    case "Trên 30 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 30000000 && i.TenLoai == loai && i.TenSanPham.Contains(tensp))
                                            list.Add(i);
                                        break;
                                }
                            }
                        }
                        else
                        {
                            if (gia == "All" && i.TenThuongHieu == thuonghieu && i.TenLoai == loai && i.TenSanPham.Contains(tensp))
                                list.Add(i);
                            else
                            {
                                switch (gia)
                                {
                                    case "Dưới 5 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) < 5000000 && i.TenThuongHieu == thuonghieu && i.TenLoai == loai && i.TenSanPham.Contains(tensp))
                                            list.Add(i);
                                        break;
                                    case "5-10 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 5000000 && Convert.ToDecimal(i.GiaBan) < 10000000 && i.TenThuongHieu == thuonghieu && i.TenLoai == loai && i.TenSanPham.Contains(tensp))
                                            list.Add(i);
                                        break;
                                    case "10-30 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 10000000 && Convert.ToDecimal(i.GiaBan) < 30000000 && i.TenThuongHieu == thuonghieu && i.TenLoai == loai && i.TenSanPham.Contains(tensp))
                                            list.Add(i);
                                        break;
                                    case "Trên 30 triệu":
                                        if (Convert.ToDecimal(i.GiaBan) > 30000000 && i.TenLoai == loai && i.TenSanPham.Contains(tensp))
                                            list.Add(i);
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            return list;
        }


    }
}
