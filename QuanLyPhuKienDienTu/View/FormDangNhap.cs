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

namespace QuanLyPhuKienDienTu
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (Process.IsEmpty(username) || Process.IsEmpty(password)) {
                MessageBox.Show("Vui lòng nhập tài khoản trước khi đăng nhập !");
                return;
            }

            try
            {
                //Đăng nhập thành công
                if (BLL_TaiKhoan.Instance.DangNhap(username, password))
                {
                    int state = BLL_NhanVien.Instance.TrangThaiNhanVien(username);

                    switch (state)
                    {
                        case 0:
                            MessageBox.Show("Đây là nhân viên");
                            break;
                        case 1:
                            MessageBox.Show("Đây là quản lý");
                            break;
                        default:
                            break;
                    }
                }
                //Đăng nhập thất bại
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi");
            }
        }

        private void buttonChangePassWord_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
