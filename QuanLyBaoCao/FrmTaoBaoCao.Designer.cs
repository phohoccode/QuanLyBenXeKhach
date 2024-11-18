namespace QuanLyBaoCao
{
    partial class FrmTaoBaoCao
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
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChiPhiVH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBaoCao = new System.Windows.Forms.DateTimePicker();
            this.txtLoiNhuan = new System.Windows.Forms.TextBox();
            this.txtTongDThu = new System.Windows.Forms.TextBox();
            this.txtNguoiLapBC = new System.Windows.Forms.TextBox();
            this.txtMaBC = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(379, 680);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(119, 40);
            this.btnLamMoi.TabIndex = 0;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTao.Location = new System.Drawing.Point(531, 680);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(75, 40);
            this.btnTao.TabIndex = 0;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnTao);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtChiPhiVH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpBaoCao);
            this.groupBox1.Controls.Add(this.txtLoiNhuan);
            this.groupBox1.Controls.Add(this.txtTongDThu);
            this.groupBox1.Controls.Add(this.txtNguoiLapBC);
            this.groupBox1.Controls.Add(this.txtMaBC);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 739);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo doanh thu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 27);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lợi nhuận";
            // 
            // txtChiPhiVH
            // 
            this.txtChiPhiVH.Location = new System.Drawing.Point(339, 304);
            this.txtChiPhiVH.Multiline = true;
            this.txtChiPhiVH.Name = "txtChiPhiVH";
            this.txtChiPhiVH.Size = new System.Drawing.Size(267, 40);
            this.txtChiPhiVH.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chi phí vận hành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng doanh thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Người lập báo cáo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thời gian lập báo cáo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã báo cáo";
            // 
            // dtpBaoCao
            // 
            this.dtpBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaoCao.Location = new System.Drawing.Point(339, 178);
            this.dtpBaoCao.Name = "dtpBaoCao";
            this.dtpBaoCao.Size = new System.Drawing.Size(267, 31);
            this.dtpBaoCao.TabIndex = 2;
            // 
            // txtLoiNhuan
            // 
            this.txtLoiNhuan.Location = new System.Drawing.Point(339, 365);
            this.txtLoiNhuan.Multiline = true;
            this.txtLoiNhuan.Name = "txtLoiNhuan";
            this.txtLoiNhuan.Size = new System.Drawing.Size(267, 40);
            this.txtLoiNhuan.TabIndex = 1;
            this.txtLoiNhuan.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtTongDThu
            // 
            this.txtTongDThu.Location = new System.Drawing.Point(339, 237);
            this.txtTongDThu.Multiline = true;
            this.txtTongDThu.Name = "txtTongDThu";
            this.txtTongDThu.Size = new System.Drawing.Size(267, 40);
            this.txtTongDThu.TabIndex = 1;
            this.txtTongDThu.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtNguoiLapBC
            // 
            this.txtNguoiLapBC.Location = new System.Drawing.Point(339, 109);
            this.txtNguoiLapBC.Multiline = true;
            this.txtNguoiLapBC.Name = "txtNguoiLapBC";
            this.txtNguoiLapBC.Size = new System.Drawing.Size(267, 40);
            this.txtNguoiLapBC.TabIndex = 1;
            // 
            // txtMaBC
            // 
            this.txtMaBC.Location = new System.Drawing.Point(339, 45);
            this.txtMaBC.Multiline = true;
            this.txtMaBC.Name = "txtMaBC";
            this.txtMaBC.Size = new System.Drawing.Size(267, 40);
            this.txtMaBC.TabIndex = 1;
            // 
            // FrmTaoBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 753);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTaoBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemMoi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBaoCao;
        private System.Windows.Forms.TextBox txtTongDThu;
        private System.Windows.Forms.TextBox txtNguoiLapBC;
        private System.Windows.Forms.TextBox txtMaBC;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChiPhiVH;
        private System.Windows.Forms.TextBox txtLoiNhuan;
    }
}