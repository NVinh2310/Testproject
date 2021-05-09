using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.BLL
{
    class BLL_Loai
    {
        private static BLL_Loai instance;
        public static BLL_Loai Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLL_Loai();
                return BLL_Loai.instance;
            }
            private set { instance = value; }
        }
        public List<Loai> GetLoai()
        {
                return DAO.DAO_Loai.Instance.GetLoai();
        }
    }
}
