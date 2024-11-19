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


            try
            {
                string Sql =
                      "SELECT " +
                      "BAOCAO.MaBaoCao as 'Mã báo cáo'," +
                      "BAOCAO.TenBaoCao as 'Tên báo cáo'," +
                      "NGUOIDUNG.TenDangNhap as 'Người lập báo cáo'," +
                      "BAOCAO.SoVeBanDuoc as 'Số vé bán được', " +
                      "BAOCAO.TongDoanhThu as 'Tổng doanh thu'," +
                      "BAOCAO.ThoiGianLap as 'Thời gian lập'," +
                      "BAOCAO.GhiChu as 'Ghi chú '" +
                      "FROM BAOCAO " +
                      "JOIN NGUOIDUNG ON BAOCAO.MaNguoiDung = NGUOIDUNG.MaNguoiDung;";

                SqlDataReader drd = conn.executeSQL(Sql);

                DataTable dataTable = new DataTable();

                // Load toàn bộ dữ liệu từ SqlDataReader vào DataTable
                dataTable.Load(drd);

                dgvDSBaoCao.DataSource = dataTable;

                drd.Close();

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

        private void FrmDanhSachBaoCao_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchValue = txtTimKiem.Text.Trim();

            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
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

            try
            {
                string Sql =
                    $@"SELECT 
                        BAOCAO.MaBaoCao as 'Mã báo cáo',
                        BAOCAO.TenBaoCao as 'Tên báo cáo',
                        NGUOIDUNG.TenDangNhap as 'Người lập báo cáo',
                        BAOCAO.SoVeBanDuoc as 'Số vé bán được',
                        BAOCAO.TongDoanhThu as 'Tổng doanh thu',
                        BAOCAO.GhiChu as 'Ghi chú'
                      FROM BAOCAO
                      JOIN NGUOIDUNG ON BAOCAO.MaNguoiDung = NGUOIDUNG.MaNguoiDung
                      WHERE 
                        BAOCAO.MaBaoCao LIKE '%{searchValue}%' OR
                        BAOCAO.TenBaoCao LIKE '%{searchValue}%' OR
                        NGUOIDUNG.TenDangNhap LIKE '%{searchValue}%' OR
                        BAOCAO.SoVeBanDuoc LIKE '%{searchValue}%' OR
                        BAOCAO.TongDoanhThu LIKE '%{searchValue}%' OR
                        BAOCAO.GhiChu LIKE '%{searchValue}%';";



                SqlDataReader drd = conn.executeSQL(Sql);

                DataTable dataTable = new DataTable();

                // Load toàn bộ dữ liệu từ SqlDataReader vào DataTable
                dataTable.Load(drd);

                dgvDSBaoCao.DataSource = dataTable;

                drd.Close();
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

       

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSBaoCao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn báo cáo cần xóa!");
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

            try
            {

                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa báo cáo này?", "Xác nhận xóa", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.OK)
                {
                    // Lấy dòng được chọn
                    var selectedRow = dgvDSBaoCao.SelectedRows[0];

                    int reportId = Convert.ToInt32(selectedRow.Cells["Mã báo cáo"].Value); 

                    string Sql_DeleteReport = $@"DELETE FROM BAOCAO WHERE MaBaoCao = {reportId};";
                    
                    int rows = conn.executeUpdate(Sql_DeleteReport);

                    if (rows > 0)
                    {
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa báo cáo thất bại!");
                    }


                }
        
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
