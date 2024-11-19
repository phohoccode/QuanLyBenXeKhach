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

namespace QuanLyBaoCao
{
    public partial class FrmTaoBaoCao : Form
    {
        public FrmTaoBaoCao()
        {
            InitializeComponent();
        }

        private void clearFields()
        {
            txtGhiChu.Text = "";
            txtSoVeBanDuoc.Text = "";
            txtTenBaoCao.Text = "";
            txtTongDoanhThu.Text = "";
            cbNguoiLapBaoCao.SelectedIndex = -1;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            if (cbNguoiLapBaoCao.SelectedIndex == -1 || txtTenBaoCao.Text == "" || txtSoVeBanDuoc.Text == "" || txtTongDoanhThu.Text == "" || txtGhiChu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string nguoiLapBaoCao = cbNguoiLapBaoCao.SelectedItem.ToString();
            string tenBaoCao = txtTenBaoCao.Text;
            string thoiGianLap = dateTime.Value.ToString("yyyy-MM-dd");
            string soVeBanDuoc = txtSoVeBanDuoc.Text;
            string tongDoanhThu = txtTongDoanhThu.Text.Replace("vnđ", "");
            string ghiChu = txtGhiChu.Text;

            Connection conn = new Connection();
            bool check_conn = conn.openConn();

            if (!check_conn)
            {
                MessageBox.Show("Kết nối Sql thất bại!");
                conn.closeConn();
                return;
            }

            string Sql_Insert = $@"
                INSERT INTO BAOCAO
                (TenBaoCao, MaNguoiDung, ThoiGianLap, SoVeBanDuoc, TongDoanhThu, GhiChu)
                VALUES
                (N'{tenBaoCao}', (SELECT MaNguoiDung FROM NGUOIDUNG WHERE TenDangNhap = N'{nguoiLapBaoCao}'), '{thoiGianLap}', {soVeBanDuoc}, {tongDoanhThu}, N'{ghiChu}');";

            int rows = conn.executeUpdate(Sql_Insert);

            if (rows > 0)
            {
                MessageBox.Show("Thêm báo cáo thành công!");
                clearFields();
            }
            else
            {
                MessageBox.Show("Thêm báo cáo thất bại!");
            }

            conn.closeConn();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btmTimKiem_Click(object sender, EventArgs e)
        {

            Connection conn = new Connection();
            bool check_conn = conn.openConn();

            if (!check_conn)
            {
                MessageBox.Show("Kết nối Sql thất bại!");
                conn.closeConn();
                return;
            }

            string ngayDatVe = dateTime.Value.ToString("yyyy-MM-dd");

            string Sql_Find = $@"
                SELECT 
                    COUNT(*) AS SoVeBanDuoc,
                    ISNULL(SUM(GiaVe), 0) AS TongDoanhThu
                FROM VEXE
                WHERE CONVERT(DATE, NgayDatVe) = '{ngayDatVe}'
                AND TrangThaiVe = 'DaDat'";

            SqlDataReader drd = conn.executeSQL(Sql_Find);


            while (drd.Read())
            {
                string soVeBanDuoc = drd["SoVeBanDuoc"].ToString();
                string tongDoanhThu = drd["TongDoanhThu"].ToString();
                txtSoVeBanDuoc.Text = soVeBanDuoc;
                txtTongDoanhThu.Text = tongDoanhThu + "vnđ";
            }

            drd.Close();
            conn.closeConn();

        }



        private void FrmTaoBaoCao_Load(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            bool check_conn = conn.openConn();

            if (!check_conn)
            {
                MessageBox.Show("Kết nối Sql thất bại!");
                conn.closeConn();
                return;
            }

            string Sql = "SELECT * FROM NGUOIDUNG WHERE VaiTro = 'staff' OR VaiTro = 'admin';\r\n";
            SqlDataReader drd = conn.executeSQL(Sql);

            cbNguoiLapBaoCao.Items.Clear();

            while (drd.Read())
            {
                string tenNguoiDung = drd["TenDangNhap"].ToString();
                cbNguoiLapBaoCao.Items.Add(tenNguoiDung);
            }

            drd.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
