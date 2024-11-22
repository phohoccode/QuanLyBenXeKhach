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

namespace QuanLyDoanhThu
{
    public partial class FrmQuanLyDoanhThu : Form
    {
        public FrmQuanLyDoanhThu()
        {
            InitializeComponent();
        }

        private void UpdateChart(DataTable dataTable)
        {
            // Xóa dữ liệu cũ trong chart
            chartDoanhThu.Series.Clear();

            // Tạo series cho số vé bán được
            var seriesSoVeBanDuoc = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Số vé bán được",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String
            };

            // Tạo series cho tổng doanh thu
            var seriesTongDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Tổng doanh thu",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String
            };

            // Thêm dữ liệu từ DataTable vào chart
            foreach (DataRow row in dataTable.Rows)
            {
                string ngayGiaoDich = Convert.ToDateTime(row["Ngày giao dịch"]).ToString("dd/MM/yyyy");
                int soVeBanDuoc = Convert.ToInt32(row["Số vé bán được"]);
                decimal tongDoanhThu = Convert.ToDecimal(row["Tổng doanh thu"]);

                seriesSoVeBanDuoc.Points.AddXY(ngayGiaoDich, soVeBanDuoc);
                seriesTongDoanhThu.Points.AddXY(ngayGiaoDich, tongDoanhThu);
            }

            // Thêm series vào chart
            chartDoanhThu.Series.Add(seriesSoVeBanDuoc);
            chartDoanhThu.Series.Add(seriesTongDoanhThu);

            // Tùy chỉnh hiển thị trục X
            chartDoanhThu.ChartAreas[0].AxisX.Title = "Ngày giao dịch";
            chartDoanhThu.ChartAreas[0].AxisY.Title = "Biểu đồ doanh thu";
            chartDoanhThu.ChartAreas[0].RecalculateAxesScale();
        }

        private void LoadData(string type)
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

                string dateTime = time.Value.ToString("yyyy-MM-dd");
                string Sql_Select = "";

                if (type == "all")
                {
                    Sql_Select = $@"
                        SELECT 
                            ROW_NUMBER() OVER (ORDER BY CONVERT(DATE, VX.NgayDatVe) ASC, SUM(LV.GiaVe) DESC) AS N'Số thứ tự',
                            CONVERT(DATE, VX.NgayDatVe) AS N'Ngày giao dịch',
                            VX.LoaiVe as N'Loại vé', 
                            COUNT(VX.MaVe) AS N'Số vé bán được',  
                            SUM(LV.GiaVe) AS N'Tổng doanh thu' 
                        FROM VEXE VX
                        INNER JOIN LOAIVE LV ON VX.LoaiVe = LV.LoaiVe
                          AND VX.TrangThaiVe = N'Đã Đặt'
                        GROUP BY 
                            CONVERT(DATE, VX.NgayDatVe),
                            VX.LoaiVe
                        ORDER BY CONVERT(DATE, VX.NgayDatVe) ASC, SUM(LV.GiaVe) DESC; 
                    ";
                }
                else
                {
                    Sql_Select = $@"
                        SELECT 
                            ROW_NUMBER() OVER (ORDER BY CONVERT(DATE, VX.NgayDatVe) ASC, SUM(LV.GiaVe) DESC) AS N'Số thứ tự',
                            CONVERT(DATE, VX.NgayDatVe) AS N'Ngày giao dịch',
                            VX.LoaiVe as N'Loại vé', 
                            COUNT(VX.MaVe) AS N'Số vé bán được',  
                            SUM(LV.GiaVe) AS N'Tổng doanh thu' 
                        FROM VEXE VX
                        INNER JOIN LOAIVE LV ON VX.LoaiVe = LV.LoaiVe
                          AND VX.TrangThaiVe = N'Đã Đặt'
                        WHERE CONVERT(DATE, VX.NgayDatVe) = '{dateTime}'
                        GROUP BY 
                            CONVERT(DATE, VX.NgayDatVe),
                            VX.LoaiVe
                        ORDER BY CONVERT(DATE, VX.NgayDatVe) ASC, SUM(LV.GiaVe) DESC;";
                }


                // Đổ dữ liệu
                SqlDataReader drd = conn.executeSQL(Sql_Select);
                DataTable dataTable = new DataTable();

                dataTable.Load(drd);
                dgvDoanhThu.DataSource = dataTable;
                drd.Close();

                // Vẽ biểu đồ
                UpdateChart(dataTable);

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

        private void FrmQuanLyDoanhThu_Load(object sender, EventArgs e)
        {
            LoadData("all");
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadData("filter");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData("all");

            // Reset lại giá trị của DateTimePicker
            time.Value = DateTime.Now;
        }
    }
}
