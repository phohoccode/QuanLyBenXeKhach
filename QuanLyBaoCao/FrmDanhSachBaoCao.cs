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
    public partial class FrmDanhSachBaoCao : Form
    {
        public FrmDanhSachBaoCao()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            Connection conn = new Connection();
            bool check_conn = conn.openConn();

            if (!check_conn)
            {
                MessageBox.Show("Kết nối Sql thất bại!");
                conn.closeConn();
                return;
            }

            string Sql =
                "SELECT " +
                "BAOCAO.MaBaoCao," +
                "BAOCAO.TenBaoCao," +
                "BAOCAO.GhiChu," +
                "NGUOIDUNG.TenDangNhap AS NguoiLapBaoCao," +
                "BAOCAO.SoVeBanDuoc, BAOCAO.TongDoanhThu," +
                "BAOCAO.ThoiGianLap " +
                "FROM BAOCAO " +
                "JOIN NGUOIDUNG ON BAOCAO.MaNguoiDung = NGUOIDUNG.MaNguoiDung;";
            SqlDataReader drd = conn.executeSQL(Sql);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Mã báo cáo", typeof(int));
            dataTable.Columns.Add("Tên báo cáo", typeof(string));
            dataTable.Columns.Add("Người lập báo cáo", typeof(string));
            dataTable.Columns.Add("Số vé bán được", typeof(decimal));
            dataTable.Columns.Add("Tổng doanh thu", typeof(decimal));
            dataTable.Columns.Add("Thời gian lập báo cáo", typeof(DateTime));
            dataTable.Columns.Add("Ghi chú", typeof(string));


            while (drd.Read())
            {
                int maBaoCao = (int)drd["MaBaoCao"];
                string tenBaoCao = drd["TenBaoCao"].ToString();
                string ghiChu = drd["GhiChu"].ToString();
                string nguoiLapBaoCao = drd["NguoiLapBaoCao"].ToString();
                int soVeBanDuoc = (int)drd["SoVeBanDuoc"];
                decimal tongDoanhthu = (decimal)drd["TongDoanhThu"];
                DateTime thoiGianLap = (DateTime)drd["ThoiGianLap"];
                dataTable.Rows.Add(maBaoCao, tenBaoCao, nguoiLapBaoCao, soVeBanDuoc, tongDoanhthu, thoiGianLap, ghiChu);
            }
            dgvDSBaoCao.DataSource = dataTable;

            drd.Close();
            conn.closeConn();
        }

        private void FrmDanhSachBaoCao_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }



        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {

        }



        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {

        }


    }
}
