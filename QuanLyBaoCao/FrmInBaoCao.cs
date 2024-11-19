using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using Word = Microsoft.Office.Interop.Word;

namespace QuanLyBaoCao
{
    public partial class FrmInBaoCao : Form
    {
        public FrmInBaoCao()
        {
            InitializeComponent();
        }

        private void FrmInBaoCao_Load(object sender, EventArgs e)
        {

            cbDinhDang.SelectedIndex = 0;

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
                      "BAOCAO.GhiChu as 'Ghi chú'" +
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

        private void PrintReportToWord(string reportCode, string reportContent)
        {
            // Tạo một đối tượng Word Application
            Word.Application wordApp = new Word.Application();
            wordApp.Visible = false;

            // Tạo một tài liệu Word mới
            Word.Document doc = wordApp.Documents.Add();

            // Thêm tiêu đề cho báo cáo
            doc.Content.Text = "Mã báo cáo: " + reportCode;

            // Thêm nội dung báo cáo vào tài liệu
            doc.Content.Text += "\n" + reportContent;

            // Lưu tài liệu vào thư mục với tên file là mã báo cáo
            string filePath = @"D:\BaoCao\dotnet\FileInBaoCao\" + reportCode + "_Report.docx";

            // Kiểm tra thư mục lưu trữ có tồn tại chưa, nếu không thì tạo thư mục
            if (!Directory.Exists(@"D:\BaoCao\dotnet\FileInBaoCao\"))
            {
                Directory.CreateDirectory(@"D:\BaoCao\dotnet\FileInBaoCao\");
            }

            // Lưu và đóng tài liệu
            doc.SaveAs2(filePath);
            doc.Close();

            MessageBox.Show($"Báo cáo '{reportCode}' đã được lưu tại: {filePath}");
        }

        private void PrintReportToPdf(string reportCode, string reportContent)
        {
            // Thư viện iTextSharp dùng để tạo PDF
            using (var doc = new iTextSharp.text.Document())
            {
                // Lưu tệp PDF vào thư mục bạn chỉ định
                string filePath = @"D:\BaoCao\dotnet\FileInBaoCao\" + reportCode + "_Report.pdf";

                // Kiểm tra thư mục lưu trữ có tồn tại chưa, nếu không thì tạo thư mục
                if (!Directory.Exists(@"D:\BaoCao\dotnet\FileInBaoCao\"))
                {
                    Directory.CreateDirectory(@"D:\BaoCao\dotnet\FileInBaoCao\");
                }

                // Tạo đối tượng Writer để ghi PDF vào file
                using (var writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create)))
                {
                    // Mở tài liệu để thêm nội dung
                    doc.Open();

                    // Thêm tiêu đề cho báo cáo
                    doc.Add(new iTextSharp.text.Paragraph("Mã báo cáo: " + reportCode));

                    // Thêm nội dung báo cáo vào PDF
                    doc.Add(new iTextSharp.text.Paragraph("\n" + reportContent));

                    // Đóng tài liệu PDF
                    doc.Close();
                }

                MessageBox.Show($"Báo cáo '{reportCode}' đã được lưu tại: {filePath}");
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào trong DataGridView chưa
            if (dgvDSBaoCao.SelectedRows.Count > 0)
            {
                // Lấy thông tin từ dòng được chọn
                string maBaoCao = dgvDSBaoCao.SelectedRows[0].Cells["Mã báo cáo"].Value.ToString();
                string tenBaoCao = dgvDSBaoCao.SelectedRows[0].Cells["Tên báo cáo"].Value.ToString();
                string nguoiLapBaoCao = dgvDSBaoCao.SelectedRows[0].Cells["Người lập báo cáo"].Value.ToString();
                string ghiChu = dgvDSBaoCao.SelectedRows[0].Cells["Ghi chú"].Value.ToString();
                int soVeBanDuoc = Convert.ToInt32(dgvDSBaoCao.SelectedRows[0].Cells["Số vé bán được"].Value);
                decimal tongDoanhThu = Convert.ToDecimal(dgvDSBaoCao.SelectedRows[0].Cells["Tổng doanh thu"].Value);
                DateTime thoiGianLapBaoCao = Convert.ToDateTime(dgvDSBaoCao.SelectedRows[0].Cells["Thời gian lập"].Value);


                if (cbDinhDang.SelectedItem != null)
                {
                    string reportContent = $"Người lập báo cáo: {nguoiLapBaoCao}\n" +
                                             $"Thời gian lập báo cáo: {thoiGianLapBaoCao.ToString("dd/MM/yyyy")}\n" +
                                             $"Tổng doanh thu: {tongDoanhThu:C}\n" +
                                             $"Số vé bán được: {soVeBanDuoc}\n" +
                                             $"Ghi chú: {ghiChu}";

                    string selectedFormat = cbDinhDang.SelectedItem.ToString();

                    if (selectedFormat == "Word")
                    {
                        PrintReportToWord(maBaoCao, reportContent);
                    }
                    else if (selectedFormat == "PDF")
                    {

                        PrintReportToPdf(maBaoCao, reportContent);
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng chọn định dạng báo cáo (Word hoặc PDF).");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một báo cáo để in.");
            }
        }
    }
}
