using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.DAO
{
    class DAO_Loai
    {
        private static DAO_Loai instance;
        public static DAO_Loai Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAO_Loai();
                return DAO_Loai.instance;
            }
            private set { instance = value; }
        }
        public List<Loai> GetLoai()
        {
            List<Loai> loai = new List<Loai>();
            using (QuanLyPhuKienDienTuEntities db = new QuanLyPhuKienDienTuEntities())
            {
                foreach(var i in db.Loais.ToList())
                {
                    loai.Add(new Loai
                    {
                        TenLoai = i.TenLoai,
                        MaLoai = i.MaLoai
                    }
                      );
                }
                return loai.ToList();
            }
        }
    }
}
