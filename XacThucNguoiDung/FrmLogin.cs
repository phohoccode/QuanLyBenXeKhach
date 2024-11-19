using QuanLyBaoCao;
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
using TrangChu;

namespace XacThucNguoiDung
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private bool checkValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
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


        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPass.Checked ? '\0' : '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (!checkValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng kiểm tra lạ!");
                txtEmail.Focus();
                return;
            }

            Connection conn = new Connection();
            bool check_conn = conn.openConn();

            if (!check_conn)
            {
                MessageBox.Show("Kết nối Sql thất bại!");
                conn.closeConn();
                return;
            }

            string Sql_FindUser = "Select * from NGUOIDUNG where Email = " +
                "'" + email + "'" + " and MatKhau = " + "'" + password + "'";

            SqlDataReader drd = conn.executeSQL(Sql_FindUser);

            if (drd.HasRows)
            {
                while (drd.Read())
                {
                    string usernameFromDrd = drd["TenDangNhap"].ToString();
                    string roleFromDrd = drd["VaiTro"].ToString();
                    string emailFromDrd = drd["Email"].ToString();

                    UserSession.SaveUserInfo(usernameFromDrd, emailFromDrd, roleFromDrd);

                    showForm(new FrmTrangChuAdmin());
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác!");
            }

            drd.Close();
            conn.closeConn();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showForm(new FrmRegister());
            this.Hide();
        }

        private void linkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showForm(new FrmForgotPassword());
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
