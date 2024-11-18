using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XacThucNguoiDung
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        public void showForm(Form formToShow)
        {
            if (formToShow != null)
            {
                formToShow.Show();
            }
            else
            {
                MessageBox.Show("Form không hợp lệ.");
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            showForm(new FrmForgotPassword());
            this.Hide();
        }

     

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPass.Checked ? '\0' : '*';
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            bool check_conn = conn.openConn();

            if (!check_conn)
            {
                MessageBox.Show("Kết nối Sql thất bại!");
                conn.closeConn();
                return;
            }

            string OTP = txtToken.Text;

            string Sql_CheckOTP = "Select * from XacMinhTaiKhoan where MaToken = " + "'" + OTP + "'";

            SqlDataReader drd = conn.executeSQL(Sql_CheckOTP);


            if (!drd.HasRows)
            {
                MessageBox.Show("Mã xác thực không đúng!");
                conn.closeConn();
                return;
            }

            drd.Close();


            string newPassword = txtPassword.Text;

            string Sql_UpdatePassword =
                "Update NguoiDung set MatKhau = " + "'" + newPassword + "'";

            int rows = conn.executeUpdate(Sql_UpdatePassword);

            if (rows > 0)
            {
                MessageBox.Show("Thay đổi mật khẩu thành công!");
                this.Close();
                showForm(new FrmLogin());
            }
            else
            {
                MessageBox.Show("Thay đổi mật khẩu thất bại!");
            }


            conn.closeConn();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
