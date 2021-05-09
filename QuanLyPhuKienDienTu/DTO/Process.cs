using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhuKienDienTu.DTO
{
    public class Process
    {
        public static bool IsEmpty(string text)
        {
            if (text == "")
                return true;
            return false;
        }

        public static void InvisibleAttributes(DataGridView dataView, object[] parameters = null)
        {
            foreach (string item in parameters)
            {
                dataView.Columns[item].Visible = false;
            }
        }

        public static string FormatDate(DateTime dateTime)
        {
            return dateTime.ToString("dd-MM-yyyy");
        }
    }
}
