using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            doc.Content.Text += "Nội dung báo cáo:\n" + reportContent + "\n";

            // Lưu tài liệu vào thư mục với tên file là mã báo cáo
            string filePath = @"D:\BaoCao\DanhSachBaoCao\" + reportCode + "_Report.docx";

            // Kiểm tra thư mục lưu trữ có tồn tại chưa, nếu không thì tạo thư mục
            if (!Directory.Exists(@"D:\BaoCao\DanhSachBaoCao"))
            {
                Directory.CreateDirectory(@"D:\BaoCao\DanhSachBaoCao");
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
                string filePath = @"D:\BaoCao\DanhSachBaoCao\" + reportCode + "_Report.pdf";

                // Kiểm tra thư mục lưu trữ có tồn tại chưa, nếu không thì tạo thư mục
                if (!Directory.Exists(@"D:\BaoCao\DanhSachBaoCao"))
                {
                    Directory.CreateDirectory(@"D:\BaoCao\DanhSachBaoCao");
                }

                // Tạo đối tượng Writer để ghi PDF vào file
                using (var writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create)))
                {
                    // Mở tài liệu để thêm nội dung
                    doc.Open();

                    // Thêm tiêu đề cho báo cáo
                    doc.Add(new iTextSharp.text.Paragraph("Mã báo cáo: " + reportCode));

                    // Thêm nội dung báo cáo vào PDF
                    doc.Add(new iTextSharp.text.Paragraph("Nội dung báo cáo:\n" + reportContent));

                    // Đóng tài liệu PDF
                    doc.Close();
                }

                MessageBox.Show($"Báo cáo '{reportCode}' đã được lưu tại: {filePath}");
            }
        }


        private void btnInNgay_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào trong DataGridView chưa
            if (dgvDSBaoCao.SelectedRows.Count > 0)
            {
                // Lấy thông tin từ dòng được chọn
                string reportCode = dgvDSBaoCao.SelectedRows[0].Cells["Mã báo cáo"].Value.ToString();
                string reportUser = dgvDSBaoCao.SelectedRows[0].Cells["Người lập báo cáo"].Value.ToString();
                DateTime reportDate = Convert.ToDateTime(dgvDSBaoCao.SelectedRows[0].Cells["Thời gian lập báo cáo"].Value);
                decimal totalRevenue = Convert.ToDecimal(dgvDSBaoCao.SelectedRows[0].Cells["Tổng doanh thu"].Value);
                decimal operationCost = Convert.ToDecimal(dgvDSBaoCao.SelectedRows[0].Cells["Chi phí vận hành"].Value);
                decimal profit = Convert.ToDecimal(dgvDSBaoCao.SelectedRows[0].Cells["Lợi nhuận"].Value);

            
                if (cbDinhDang.SelectedItem != null)
                {
                  
                    string reportContent = $"Người lập báo cáo: {reportUser}\n" +
                                           $"Thời gian lập báo cáo: {reportDate.ToString("dd/MM/yyyy")}\n" +
                                           $"Tổng doanh thu: {totalRevenue:C}\n" +
                                           $"Chi phí vận hành: {operationCost:C}\n" +
                                           $"Lợi nhuận: {profit:C}";

                    string selectedFormat = cbDinhDang.SelectedItem.ToString();

                    if (selectedFormat == "Word")
                    {
                       
                        PrintReportToWord(reportCode, reportContent);
                    }
                    else if (selectedFormat == "PDF")
                    {
                      
                        PrintReportToPdf(reportCode, reportContent);
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
