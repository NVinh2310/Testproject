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
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
            LoadTaiKhoan();

        }

        private void LoadTaiKhoan()
        {
            dataGridView1.DataSource = BLL_TaiKhoan.Instance.GetTaiKhoan();
            Process.InvisibleAttributes(dataGridView1, new object[] { "MaTaiKhoan" });
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            FormThemTaiKhoan form = new FormThemTaiKhoan();
            this.Hide();
            form.del = new FormThemTaiKhoan.MyDel(LoadTaiKhoan);
            form.ShowDialog();
            this.Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;

            //Không có tài khoản được chọn
            if (r.Count == 0)
            {
                MessageBox.Show("Không có tài khoản được chọn");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản này ?", "Cảnh báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                foreach (DataGridViewRow i in r)
                {
                    int id = (int)i.Cells["MaTaiKhoan"].Value;
                    if (BLL_TaiKhoan.Instance.XoaTaiKhoan(id))
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi");
                    }
                }
                LoadTaiKhoan();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string name = txbSearch.Text;
            dataGridView1.DataSource = BLL_TaiKhoan.Instance.GetTaiKhoanBangTen(name);
            Process.InvisibleAttributes(dataGridView1, new object[] { "MaTaiKhoan" });
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
