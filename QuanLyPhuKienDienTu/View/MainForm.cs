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

namespace QuanLyPhuKienDienTu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            setComboBox();
            show();
        }

        private void setComboBox()
        {
            comboBoxLoai.Items.Add(new CBBItem
            {
                Value = 0,
                Text = "All"
            });
            comboBoxHang.Items.Add(new CBBItem
            {
                Value = 0,
                Text = "All"
            });
            
            foreach (Loai i in BLL.BLL_Loai.Instance.GetLoai())
            {
                comboBoxLoai.Items.Add(new CBBItem
                {
                    Value= i.MaLoai,
                    Text =i.TenLoai
                });
            }
            comboBoxLoai.SelectedIndex = 0;
            
            foreach (ThuongHieu i in BLL.BLL_ThuongHieu.Instance.GetThuongHieu())
            {
                comboBoxHang.Items.Add(new CBBItem
                {
                    Value = i.MaThuongHieu,
                    Text = i.TenThuongHieu
                });
            }
            comboBoxHang.SelectedIndex = 0;
            comboBoxGia.SelectedIndex = 0;
        }
        public void show()
        {
            dataGridView1.DataSource = BLL.BLL_SanPham.Instance.GetSanPham_Views("All", "All", "All", "All");
            dataGridView1.Columns["MoTa"].Visible = false;
            dataGridView1.Columns["MaSanPham"].Visible = false;
            dataGridView1.Columns["MauSac"].Visible = false;
            dataGridView1.Columns["ThoiLuongBaoHanh"].Visible = false;
        }
        
        private void buttonTim_Click(object sender, EventArgs e)
        {
            string loai = comboBoxLoai.SelectedItem.ToString();
            string thuonghieu = comboBoxHang.SelectedItem.ToString();
            string gia = comboBoxGia.SelectedItem.ToString();

            dataGridView1.DataSource = BLL.BLL_SanPham.Instance.GetSanPham_Views(textBoxTim.Text, loai, thuonghieu, gia);
            dataGridView1.Columns["MoTa"].Visible = false;
            dataGridView1.Columns["MaSanPham"].Visible = false;
            dataGridView1.Columns["MauSac"].Visible = false;
            dataGridView1.Columns["ThoiLuongBaoHanh"].Visible = false;
        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {
        }

        
        public void LoadSanPhamView(int maSanPhamView)
        {
            foreach( SanPham_View i in BLL.BLL_SanPham.Instance.GetSanPham_Views("All", "All", "All", "All"))
            {
                if(maSanPhamView == i.MaSanPham)
                {
                    textBoxTenSp.Text = i.TenSanPham;
                    textBoxThuongHieu.Text = i.TenThuongHieu;
                    textBoxThoiLuongBH.Text = i.ThoiLuongBaoHanh.ToString();
                    textBoxGiaBan.Text = i.GiaBan.ToString();
                    textBoxLoai.Text = i.TenLoai;
                    textBoxSoLuongTon.Text = i.SoLuongTonKho.ToString();
                    labelMoTa.Text = i.MoTa;
                    textBoxMau.Text = i.MauSac;
                        
                }    
            }    
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int maSanPhamView = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MaSanPham"].Value.ToString());
            LoadSanPhamView(maSanPhamView);
        }
    }
}
