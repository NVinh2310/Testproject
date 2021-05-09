using QuanLyPhuKienDienTu.BLL;
using QuanLyPhuKienDienTu.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhuKienDienTu.View
{
    public partial class FormChiTietBan : Form
    {
        public int MaHoaDon { get; set; }
        public FormChiTietBan(int id)
        {
            InitializeComponent();
            MaHoaDon = id;
            LoadClient();
            LoadProduct();
        }

        private void LoadClient()
        {
            KhachHang khachHang = BLL_ThongTinBan.Instance.ThongTinKhachHang(MaHoaDon);
            lbName.Text = khachHang.TenKhachHang;
            lbAddress.Text = khachHang.DiaChi;
            lbPhone.Text = khachHang.SoDienThoai;
        }

        private void LoadProduct() 
        {
            List<ChiTietBan> sanPham = BLL_ThongTinBan.Instance.ThongTinSanPham(MaHoaDon);

            for (int i = 1; i <= sanPham.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(i.ToString()) { Tag = sanPham[i - 1].MaSanPham };
                listViewItem.SubItems.Add(sanPham[i - 1].TenSanPham);
                listViewItem.SubItems.Add(sanPham[i - 1].MauSac);
                listViewItem.SubItems.Add(sanPham[i - 1].SoLuongBan.ToString());
                listViewItem.SubItems.Add(sanPham[i - 1].GiaBan.ToString());
                listViewItem.SubItems.Add((sanPham[i - 1].SoLuongBan * sanPham[i - 1].GiaBan).ToString());

                lvDetail.Items.Add(listViewItem);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
