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
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string password = txbPassword.Text;
            string newPassword = txbNewPassword.Text;

            if (Process.IsEmpty(username) ||
                Process.IsEmpty(password) ||
                Process.IsEmpty(newPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            //Kiểm tra username và password có tồn tại không
            if (BLL_TaiKhoan.Instance.DangNhap(username, password))
            {
                //Đổi mật khẩu
                if(BLL_TaiKhoan.Instance.DoiMatKhau(username, password, newPassword)) {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi !");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không chính xác hoặc tài khoản không tồn tại");
            }
        }
    }
}
