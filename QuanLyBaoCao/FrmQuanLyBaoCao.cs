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


namespace QuanLyBaoCao
{
    public partial class FrmQuanLyBaoCao : Form
    {
        public FrmQuanLyBaoCao()
        {
            InitializeComponent();
        }

        private void ShowFormInPanel(Form formToShow)
        {
            // Xóa các control cũ trong Panel nếu có
            panelContainer.Controls.Clear();

            // Đặt các thuộc tính cho form con
            formToShow.TopLevel = false; // Để form con không là form độc lập
            formToShow.FormBorderStyle = FormBorderStyle.None; // Ẩn border của form con
            formToShow.Dock = DockStyle.Fill; // Fill toàn bộ panel

            // Thêm form con vào panel và hiển thị nó
            panelContainer.Controls.Add(formToShow);
            formToShow.Show();
        }

       


        private void FrmQuanLyBaoCao_Load(object sender, EventArgs e)
        {
            FrmDanhSachBaoCao frmDanhSachBaoCao = new FrmDanhSachBaoCao();
            ShowFormInPanel(frmDanhSachBaoCao);
        }

        private void btnDSBaoCao_Click(object sender, EventArgs e)
        {
            FrmDanhSachBaoCao frmDanhSachBaoCao = new FrmDanhSachBaoCao();
            ShowFormInPanel(frmDanhSachBaoCao);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FrmTaoBaoCao frmTaoBaoCao = new FrmTaoBaoCao();
            ShowFormInPanel(frmTaoBaoCao);
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            FrmInBaoCao frmInBaoCao = new FrmInBaoCao();
            ShowFormInPanel(frmInBaoCao);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
