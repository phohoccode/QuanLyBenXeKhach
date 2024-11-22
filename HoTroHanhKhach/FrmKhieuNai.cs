using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HoTroHanhKhach
{
    public partial class FrmKhieuNai : Form
    {
        public FrmKhieuNai()
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

        private void sendComplaint()
        {
            var fromAddress = new MailAddress("phohoccode@gmail.com", "Quản lý bến xe");
            const string password = "edfr elqg nlvh sltj";
            const string title = "Khiếu nại từ người dùng - Quản lý Bến xe";


            // thông tin khiếu nại từ người dùng
            string email = txtEmail.Text;


            bool isValidEmail = checkValidEmail(email);

            if (!isValidEmail)
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }

            string soDienThoai = txtSoDienThoai.Text;
            string tenNguoiDung = txtHoVaTen.Text;
            string bienSoXe = cbBienSoXe.SelectedItem?.ToString() ?? "Không xác định";
            string thoiGian = cbThoiGian.SelectedItem?.ToString() ?? "Không xác định";
            string tuyenDuong = cbTuyenDuong.SelectedItem?.ToString() ?? "Không xác định";
            string lyDoKhieuNai = cbLyDoKhieuNai.SelectedItem?.ToString() ?? "Không xác định";
            string moTa = txtMoTa.Text;

            // Nội dung email
            string content = $@"
                <div style='font-family: Arial, sans-serif; line-height: 1.6;'>
                    <h2 style='color: #007BFF;'>Khiếu nại mới từ người dùng</h2>
                    <h3 style='color: #555;'>Thông tin người gửi:</h3>
                    <p><strong>Họ và tên:</strong> {tenNguoiDung}</p>
                    <p><strong>Email:</strong> {email}</p>
                    <p><strong>Số điện thoại:</strong> {soDienThoai}</p>

                    <h3 style='color: #555;'>Thông tin chuyến đi:</h3>
                    <p><strong>Biển số xe:</strong> {bienSoXe}</p>
                    <p><strong>Thời gian khởi hành:</strong> {thoiGian}</p>
                    <p><strong>Tuyến đường:</strong> {tuyenDuong}</p>

                    <h3 style='color: #555;'>Chi tiết khiếu nại:</h3>
                    <p><strong>Lý do khiếu nại:</strong> {lyDoKhieuNai}</p>
                    <p><strong>Mô tả:</strong> {moTa}</p>

                    <br>
                    <footer style='color: #aaa;'>Được gửi từ hệ thống Quản lý Bến xe</footer>
                </div>";

            var message = new MailMessage
            {
                From = fromAddress,
                Subject = title,
                Body = content,
                IsBodyHtml = true
            };

            message.To.Add(email);

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(fromAddress.Address, password)
            };


            smtp.Send(message);

            MessageBox.Show("Gửi khiếu nại thành công!");
        }

        private bool validateForm()
        {
            if (string.IsNullOrEmpty(txtHoVaTen.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text) || string.IsNullOrEmpty(txtMoTa.Text))
            {
                return false;
            }

            return true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            bool isValid = validateForm();

            if (!isValid)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khiếu nại!");
                return;
            }


            if (cbXacNhan.Checked)
            {
                btnLamMoi.Enabled = false;
                btnXacNhan.Enabled = false;
                sendComplaint();
               
                btnLamMoi.Enabled = true;
                btnXacNhan.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng xác nhận điều khoản trước khi gửi khiếu nại!");
            }
        }

        private void FrmKhieuNai_Load(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            bool check_conn = conn.openConn();

            if (!check_conn)
            {
                MessageBox.Show("Kết nối Sql thất bại!");
                conn.closeConn();
                return;
            }


            try
            {
                cbBienSoXe.Items.Clear();
                cbThoiGian.Items.Clear();
                cbTuyenDuong.Items.Clear();


                string Sql_XeKhach = "Select * from XEKHACH";
                string Sql_TuyenDuong = "Select * from LICHTRINH";


                // đọc dữ liệu từ bảng xe khách
                SqlDataReader drd_Xekhach = conn.executeSQL(Sql_XeKhach);


                while (drd_Xekhach.Read())
                {
                    cbBienSoXe.Items.Add(drd_Xekhach["BienSo"].ToString());
                }


                drd_Xekhach.Close();

                // đọc dữ liệu từ bảng lịch trình
                SqlDataReader drd_tuyenduong = conn.executeSQL(Sql_TuyenDuong);

                while (drd_tuyenduong.Read())
                {
                    cbTuyenDuong.Items.Add(drd_tuyenduong["TuyenDuong"].ToString());
                    cbThoiGian.Items.Add(drd_tuyenduong["NgayKhoiHanh"].ToString() + " " + drd_tuyenduong["GioKhoiHanh"].ToString());
                }

                cbLyDoKhieuNai.SelectedIndex = 0;
                cbTuyenDuong.SelectedIndex = 0;
                cbThoiGian.SelectedIndex = 0;
                cbBienSoXe.SelectedIndex = 0;

                drd_tuyenduong.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra! Vui lòng liên hệ quản trị viên.");
            }
            finally
            {
                conn.closeConn();
            }
        }

       
    }
}
