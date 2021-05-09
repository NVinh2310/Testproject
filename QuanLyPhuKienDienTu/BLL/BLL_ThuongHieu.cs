using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuKienDienTu.BLL
{
    class BLL_ThuongHieu
    {
        private static BLL_ThuongHieu instance;
        public static BLL_ThuongHieu Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLL_ThuongHieu();
                return BLL_ThuongHieu.instance;
            }
            private set { instance = value; }
        }
        public List<ThuongHieu> GetThuongHieu()
        {
            return DAO.DAO_ThuongHieu.Instance.GetThuongHieu();
        }
    }
}
