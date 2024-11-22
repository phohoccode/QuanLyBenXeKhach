using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace XacThucNguoiDung
{
    public partial class FrmForgotPassword : Form
    {
        public FrmForgotPassword()
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

        private string GenerateToken()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString(); // Mã xác thực 6 chữ số
        }

        private void sendToken(string email, string token)
        {
            try
            {
                // Cấu hình máy chủ SMTP và thông tin tài khoản
                var fromAddress = new MailAddress("phohoccode@gmail.com", "Quản lý bến xe");
                const string password = "edfr elqg nlvh sltj";
                const string title = "Xác thực tài khoản!";

                string content = $"Kính chào Quý khách,\n\nChúng tôi đã nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn trên hệ thống Quản lý Bến xe.\n\nMã xác thực của bạn là: {token}\n\nVui lòng nhập mã này để tiếp tục quá trình xác thực và hoàn tất thay đổi mật khẩu.\n\nNếu bạn không yêu cầu đặt lại mật khẩu, vui lòng bỏ qua email này.\n\nTrân trọng,\nĐội ngũ hỗ trợ Quản lý Bến xe Liên tỉnh";


                // Tạo đối tượng SmtpClient để cấu hình máy chủ SMTP
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com", // Địa chỉ SMTP server của bạn (ví dụ smtp.gmail.com)
                    Port = 587,                // Cổng SMTP thông thường cho SSL là 587
                    EnableSsl = true,          // Kích hoạt SSL
                    Credentials = new NetworkCredential(fromAddress.Address, password) // Thông tin đăng nhập
                };

                // Gửi email (thay vì từ đối tượng MailAddress, ta dùng trực tiếp chuỗi email)
                smtp.Send(fromAddress.Address, email, title, content);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi email: {ex.Message}");
            }
        }

        public static string GenerateUUID()
        {
            return Guid.NewGuid().ToString();
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
            showForm(new FrmLogin());
            this.Close();
        }

      

        private async void btnContinute_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (!checkValidEmail(email))
            {
                MessageBox.Show("Email không đúng định dạng!");
                return;
            }


            string token = GenerateToken();

            btnContinute.Enabled = false;
            // gửi mã OTP qua email
            await Task.Run(() => sendToken(email, token));
            btnContinute.Enabled = true;

            Connection conn = new Connection();
            bool check_conn = conn.openConn();

            if (!check_conn)
            {
                MessageBox.Show("Kết nối Sql thất bại!");
                conn.closeConn();
                return;
            }

            string Sql_FindEmail =
                "Select * from NGUOIDUNG" + " Where email = " + "'" + email + "'";

            SqlDataReader drd = conn.executeSQL(Sql_FindEmail);

            if (!drd.HasRows)
            {
                MessageBox.Show("Email không tồn tại trong hệ thống!");
                txtEmail.Clear();
                txtEmail.Focus();
                conn.closeConn();
                return;
            }

            int userId = 0;

            while (drd.Read())
            {
                userId = Convert.ToInt32(drd["MaNguoiDung"].ToString());
            }

            drd.Close();

            string Sql_InsetTokenToSql =
                "Insert into XACMINHTAIKHOAN (MaNguoiDung,MaToken, LoaiXacMinh) values (" +
                "'" + userId + "'" + "," +
                "'" + token + "'" + "," +
                "'Forgot-Password')";

            int rows = conn.executeUpdate(Sql_InsetTokenToSql);

            if (rows > 0)
            {
                showForm(new FrmChangePassword());
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi!");
            }

            conn.closeConn();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
