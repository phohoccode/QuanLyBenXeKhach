using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void dgvDSBaoCao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDSBaoCao.Rows[e.RowIndex];

                string maBaoCao = row.Cells["Mã báo cáo"].Value.ToString();
                string nguoiLapBaoCao = row.Cells["Người lập báo cáo"].Value.ToString();
                DateTime thoiGianLap = (DateTime)row.Cells["Thời gian lập báo cáo"].Value;
                decimal tongDoanhThu = (decimal)row.Cells["Tổng doanh thu"].Value;
                decimal chiPhiVanHanh = (decimal)row.Cells["Chi phí vận hành"].Value;
                decimal loiNhuan = (decimal)row.Cells["Lợi nhuận"].Value;

                // Hiển thị thông tin
                MessageBox.Show(
                                $"- Mã báo cáo: {maBaoCao}\n" +
                                $"- Người lập báo cáo: {nguoiLapBaoCao}\n" +
                                $"- Thời gian lập báo cáo: {thoiGianLap.ToShortDateString()}\n" +
                                $"- Tổng doanh thu: {tongDoanhThu}\n" +
                                $"- Chi phí vận hành: {chiPhiVanHanh}\n" +
                                $"- Lợi nhuận: {loiNhuan}");
            }
        }

        private void FrmDanhSachBaoCao_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Mã báo cáo", typeof(string));
            dataTable.Columns.Add("Người lập báo cáo", typeof(string));
            dataTable.Columns.Add("Thời gian lập báo cáo", typeof(DateTime));
            dataTable.Columns.Add("Tổng doanh thu", typeof(decimal));
            dataTable.Columns.Add("Chi phí vận hành", typeof(decimal));
            dataTable.Columns.Add("Lợi nhuận", typeof(decimal));

            // Tạo dữ liệu giả và thêm vào DataTable
            for (int i = 1; i <= 10; i++)
            {
                string reportID = "BC" + i.ToString("D3"); // Mã báo cáo giả
                string reportUser = $"User {i}"; // Người lập báo cáo giả
                DateTime reportDate = DateTime.Now.AddDays(-i); // Thời gian lập báo cáo giả
                decimal totalRevenue = new Random().Next(1000000, 5000000); // Tổng doanh thu giả
                decimal operationCost = new Random().Next(500000, 2000000); // Chi phí vận hành giả
                decimal profit = totalRevenue - operationCost; // Lợi nhuận giả

                // Thêm dòng vào DataTable
                dataTable.Rows.Add(reportID, reportUser, reportDate, totalRevenue, operationCost, profit);
            }
            dgvDSBaoCao.DataSource = dataTable;
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

        private void btnDatLai_Click(object sender, EventArgs e)
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
