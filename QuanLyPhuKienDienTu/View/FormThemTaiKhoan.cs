using QuanLyPhuKienDienTu.BLL;
using QuanLyPhuKienDienTu.DAO;
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
    public partial class FormThemTaiKhoan : Form
    {
        public delegate void MyDel();
        public MyDel del { get; set; }
        public FormThemTaiKhoan()
        {
            InitializeComponent();
            SetCBB();
        }

        private void SetCBB()
        {
            List<NhanVien> list = BLL_NhanVien.Instance.GetNhanVienChuaCoTK();

            foreach(NhanVien item in list)
            {
                cbbName.Items.Add(new CBBItem
                {
                    Value = item.MaNhanVien,
                    Text = item.TenNhanVien
                });
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;

            //Trường hợp các dữ liệu đầu vào trống 
            if (Process.IsEmpty(cbbName.Text))
            {
                MessageBox.Show("Hãy chọn nhân viên để thêm tài khoản");
                return;
            }

            if (Process.IsEmpty(username) || 
                Process.IsEmpty(password) || 
                Process.IsEmpty(txbSubmitPas.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin");
                return;
            }

            //Nhập lại mật khẩu không khớp
            if (!password.Equals(txbSubmitPas.Text))
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác");
                return;
            }

            //Tên tài khoản đã tồn tại
            if (!BLL_TaiKhoan.Instance.TenTaiKhoanHopLe(username))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại");
                return;
            }

            //Lỗi tự nhập combobox bị sai. Cần xử lý Exception
            try
            {
                int id = ((CBBItem)cbbName.SelectedItem).Value;
                
                TaiKhoan taiKhoan = new TaiKhoan()
                {
                    MaNhanVien = id,
                    Username = username,
                    Password = password
                };

                if (BLL_TaiKhoan.Instance.ThemTaiKhoan(taiKhoan))
                {
                    MessageBox.Show("Thêm thành công");
                    del();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Dữ liệu nhân viên muốn thêm bị sai. Vui lòng chọn lại");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
