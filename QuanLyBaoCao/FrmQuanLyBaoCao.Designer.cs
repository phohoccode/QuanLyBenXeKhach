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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnDSBaoCao = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnInBaoCao);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnThemMoi);
            this.panel1.Controls.Add(this.btnDSBaoCao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 753);
            this.panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(12, 701);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(280, 40);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Location = new System.Drawing.Point(12, 150);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(280, 40);
            this.btnInBaoCao.TabIndex = 0;
            this.btnInBaoCao.Text = "In báo cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = true;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThemMoi.Location = new System.Drawing.Point(12, 81);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(280, 40);
            this.btnThemMoi.TabIndex = 0;
            this.btnThemMoi.Text = "Thêm báo cáo mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnDSBaoCao
            // 
            this.btnDSBaoCao.Location = new System.Drawing.Point(12, 12);
            this.btnDSBaoCao.Name = "btnDSBaoCao";
            this.btnDSBaoCao.Size = new System.Drawing.Size(280, 40);
            this.btnDSBaoCao.TabIndex = 0;
            this.btnDSBaoCao.Text = "Danh sách báo cáo";
            this.btnDSBaoCao.UseVisualStyleBackColor = true;
            this.btnDSBaoCao.Click += new System.EventHandler(this.btnDSBaoCao_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(332, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(650, 753);
            this.panelContainer.TabIndex = 2;
            // 
            // FrmQuanLyBaoCao
            // 
            this.AcceptButton = this.btnThemMoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnThemMoi;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Black;
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
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnThoat;
    }
}

