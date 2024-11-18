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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
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

        public static string GenerateUUID()
        {
            return Guid.NewGuid().ToString();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showForm(new FrmLogin());
            this.Close();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string userId = GenerateUUID();


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

            string Sql_FindEmail =
                "Select email from Nguoidung" + " Where email = " + "'" + email + "'";

            SqlDataReader drd = conn.executeSQL(Sql_FindEmail);

            if (drd.HasRows)
            {
                MessageBox.Show("Email đã tồn tại trong hệ thống!");
                txtEmail.Clear();
                txtEmail.Focus();
                conn.closeConn();
                return;
            }

            drd.Close();


            string Sql_Register =
                "Insert into Nguoidung (MaNguoiDung, TenDangNhap, Email, Matkhau) values ('" +
                userId + "'" + "," + "'" +
                username + "'" + "," + "'" +
                email + "'" + "," + "'" +
                password + "'" + ")";



            int rows = conn.executeUpdate(Sql_Register);

            if (rows > 0)
            {
                MessageBox.Show("Đăng ký thành công!");
                this.Close();
                showForm(new FrmLogin());
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!");
            }

            conn.closeConn();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPass.Checked ? '\0' : '*';
        }
    }
}
