namespace QuanLyBaoCao
{
    partial class FrmQuanLyBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnDSBaoCao = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnXuatBaoCao);
            this.panel1.Controls.Add(this.btnThemMoi);
            this.panel1.Controls.Add(this.btnDSBaoCao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 753);
            this.panel1.TabIndex = 1;
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Image = global::QuanLyBaoCao.Properties.Resources.export;
            this.btnXuatBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatBaoCao.Location = new System.Drawing.Point(12, 150);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(200, 40);
            this.btnXuatBaoCao.TabIndex = 0;
            this.btnXuatBaoCao.Text = "Xuất báo cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = true;
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThemMoi.Image = global::QuanLyBaoCao.Properties.Resources.more;
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.Location = new System.Drawing.Point(12, 81);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(200, 40);
            this.btnThemMoi.TabIndex = 0;
            this.btnThemMoi.Text = "Thêm báo cáo mới";
            this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnDSBaoCao
            // 
            this.btnDSBaoCao.Image = global::QuanLyBaoCao.Properties.Resources.checklist;
            this.btnDSBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSBaoCao.Location = new System.Drawing.Point(12, 12);
            this.btnDSBaoCao.Name = "btnDSBaoCao";
            this.btnDSBaoCao.Size = new System.Drawing.Size(200, 40);
            this.btnDSBaoCao.TabIndex = 0;
            this.btnDSBaoCao.Text = "Danh sách báo cáo";
            this.btnDSBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDSBaoCao.UseVisualStyleBackColor = true;
            this.btnDSBaoCao.Click += new System.EventHandler(this.btnDSBaoCao_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(250, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(750, 753);
            this.panelContainer.TabIndex = 2;
            // 
            // FrmQuanLyBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 753);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuanLyBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý báo cáo";
            this.Load += new System.EventHandler(this.FrmQuanLyBaoCao_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDSBaoCao;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnXuatBaoCao;
    }
}

