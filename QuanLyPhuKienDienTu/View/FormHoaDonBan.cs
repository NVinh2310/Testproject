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
    public partial class FormHoaDonBan : Form
    {
        public FormHoaDonBan()
        {
            InitializeComponent();
            LoadDaTa();
            SetCBB();
        }

        private void LoadDaTa()
        {
            dataGridView.DataSource = BLL_ThongTinBan.Instance.HoaDonBan();
            Process.InvisibleAttributes(dataGridView, new object[] { "MaHoaDonBan" });
        }

        private void SetCBB()
        {
            cbbDate.Items.AddRange(new string[] { "Ngày", "Tháng", "Năm" });
            cbbDate.SelectedIndex = 0;

            cbbSort.Items.AddRange(new string[] { "Tên", "Ngày", "Số lượng", "Giá bán" });
            cbbSort.SelectedIndex = 0;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadDaTa();
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value;
            string type = cbbDate.Text;

            switch (type)
            {
                case "Ngày":
                    dataGridView.DataSource = BLL_ThongTinBan.Instance.TimTheoNgay(dateTime);
                    break;
                case "Tháng":
                    dataGridView.DataSource = BLL_ThongTinBan.Instance.TimTheoThang(dateTime);
                    break;
                case "Năm":
                    dataGridView.DataSource = BLL_ThongTinBan.Instance.TimTheoNam(dateTime);
                    break;
                default:
                    MessageBox.Show("Không hợp lệ");
                    break;
            }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;

            if (Process.IsEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên muốn tìm");
                return;
            }

            dataGridView.DataSource = BLL_ThongTinBan.Instance.TimTheoTen(name);
            Process.InvisibleAttributes(dataGridView, new object[] { "MaHoaDonBan" });
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            List<ThongTinBan> list = new List<ThongTinBan>();
            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                ThongTinBan info = row.DataBoundItem as ThongTinBan;
                list.Add(info);
            }

            string type = cbbSort.Text;
            switch (type)
            {
                case "Tên":
                    dataGridView.DataSource = BLL_ThongTinBan.Instance.SapXepTheoTen(list);
                    break;
                case "Ngày":
                    dataGridView.DataSource = BLL_ThongTinBan.Instance.SapXepTheoNgay(list);
                    break;
                case "Số lượng":
                    dataGridView.DataSource = BLL_ThongTinBan.Instance.SapXepTheoSoLuong(list);
                    break;
                case "Giá bán":
                    dataGridView.DataSource = BLL_ThongTinBan.Instance.SapXepTheoGiaBan(list);
                    break;
                default:
                    MessageBox.Show("Không hợp lệ");
                    break;
            }
        }

        private void dataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //int idHoaDon = (int)dataGridView.SelectedRows[0].Cells["MaHoaDonBan"].Value;

            //FormChiTietBan form = new FormChiTietBan(idHoaDon);
            //this.Hide();
            //form.ShowDialog();
            //this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
