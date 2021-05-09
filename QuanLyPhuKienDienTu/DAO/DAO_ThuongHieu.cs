using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DAO
{
    class DAO_ThuongHieu
    {
        private static DAO_ThuongHieu instance;
        public static DAO_ThuongHieu Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAO_ThuongHieu();
                return DAO_ThuongHieu.instance;
            }
            private set { instance = value; }
        }
        public List<ThuongHieu> GetThuongHieu()
        {
            List<ThuongHieu> loai = new List<ThuongHieu>();
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                foreach (var i in db.ThuongHieux.ToList())
                {
                    loai.Add(new ThuongHieu
                    {
                        TenThuongHieu = i.TenThuongHieu,
                        MaThuongHieu = i.MaThuongHieu
                    }
                      );
                }
                return loai.ToList();
            }
        }
    }
}
