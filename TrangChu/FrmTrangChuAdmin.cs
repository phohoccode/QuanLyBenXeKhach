using HoTroHanhKhach;
using QuanLyBaoCao;
using QuanLyDoanhThu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrangChu
{
    public partial class FrmTrangChuAdmin : Form
    {
        public FrmTrangChuAdmin()
        {
            InitializeComponent();
        }

        private void ShowFormInPanel(Form formToShow)
        {
            panelContainer.Controls.Clear();
            formToShow.TopLevel = false;
            formToShow.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(formToShow);
            formToShow.Show();
        }


        private void FrmTrangChuAdmin_Load(object sender, EventArgs e)
        {
            

           
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyVeXe_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyLichTrinh_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyXeKhach_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyBaoCao_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmQuanLyBaoCao());
        }

        private void btnQuanLyDoanhThu_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmQuanLyDoanhThu());
        }

        private void btnHoTroHanhKhach_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FrmHoTroHanhKhach());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

        }
    }
}
