using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaoCao
{
    public partial class FrmQuanLyBaoCao : Form
    {
        public FrmQuanLyBaoCao()
        {
            InitializeComponent();
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
                } else
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
            LoadData("all");
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadData("filter");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData("all");

            time.Value = DateTime.Now;

        }    

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;

            float x = 100; // Vị trí X để bắt đầu vẽ
            float y = 100; // Vị trí Y để bắt đầu vẽ
            float rowHeight = 25; // Chiều cao của mỗi dòng
            float columnWidth = 120; // Chiều rộng mặc định của cột
            int columns = dgvDSBaoCao.Columns.Count; // Số lượng cột
            int rows = dgvDSBaoCao.Rows.Count; // Số lượng dòng

            // tiêu đề
            graphics.DrawString("BÁO CÁO DOANH THU " + DateTime.Now.ToString("dd/MM/yyyy"), new Font("Arial", 14, FontStyle.Bold), brush, x, y);
            y += rowHeight * 2; // Tăng khoảng cách để không chồng lên tiêu đề cột

            // Vẽ tiêu đề cột
            for (int i = 0; i < columns; i++)
            {
                graphics.FillRectangle(Brushes.LightGray, x, y, columnWidth, rowHeight);
                graphics.DrawRectangle(Pens.Black, x, y, columnWidth, rowHeight);
                graphics.DrawString(dgvDSBaoCao.Columns[i].HeaderText, font, brush, x + 2, y + 2);
                x += columnWidth; // Tính toán x cho cột tiếp theo
            }
            y += rowHeight; // Cập nhật y cho dòng tiếp theo

            // Vẽ nội dung bảng
            for (int i = 0; i < rows; i++)
            {
                x = 100; // Reset x về vị trí bắt đầu
                for (int j = 0; j < columns; j++)
                {
                    graphics.DrawRectangle(Pens.Black, x, y, columnWidth, rowHeight); // Vẽ viền

                    var cellValue = dgvDSBaoCao.Rows[i].Cells[j].Value;

                  
                    if (dgvDSBaoCao.Columns[j].HeaderText == "Ngày giao dịch" && cellValue is DateTime dateValue)
                    {
                        graphics.DrawString(dateValue.ToString("yyyy-MM-dd"), font, brush, x + 2, y + 2);
                    }
                    else
                    { 
                        graphics.DrawString(cellValue?.ToString() ?? "", font, brush, x + 2, y + 2);
                    }

                    x += columnWidth; // Tính toán x cho cột tiếp theo
                }
                y += rowHeight; // Cập nhật y cho dòng tiếp theo
            }

            y += rowHeight;
            graphics.DrawString("Người lập báo cáo: ..........", new Font("Arial", 12, FontStyle.Italic), brush, 100, y);
            y += rowHeight;
            graphics.DrawString("Ký tên", new Font("Arial", 12), brush, 100, y); 

            // Kiểm tra xem có cần tiếp tục in không
            e.HasMorePages = false;
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            // Cấu hình sự kiện in
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            // Mở hộp thoại in
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }

        }

       
    }
}
