﻿namespace HoTroHanhKhach
{
    partial class FrmKhieuNai
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.cbXacNhan = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbLyDoKhieuNai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbTuyenDuong = new System.Windows.Forms.ComboBox();
            this.cbThoiGian = new System.Windows.Forms.ComboBox();
            this.cbBienSoXe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Controls.Add(this.cbXacNhan);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(690, 732);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khiếu nại";
            //this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = global::HoTroHanhKhach.Properties.Resources.refresh;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(405, 673);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 40);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Image = global::HoTroHanhKhach.Properties.Resources.approve;
            this.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhan.Location = new System.Drawing.Point(543, 673);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(120, 40);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // cbXacNhan
            // 
            this.cbXacNhan.AutoSize = true;
            this.cbXacNhan.Location = new System.Drawing.Point(25, 626);
            this.cbXacNhan.Name = "cbXacNhan";
            this.cbXacNhan.Size = new System.Drawing.Size(425, 25);
            this.cbXacNhan.TabIndex = 6;
            this.cbXacNhan.Text = "Tôi xác nhận thông tin cung cấp là chính xác";
            this.cbXacNhan.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbLyDoKhieuNai);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtMoTa);
            this.groupBox4.Location = new System.Drawing.Point(25, 409);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(638, 192);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết khiếu nại";
            // 
            // cbLyDoKhieuNai
            // 
            this.cbLyDoKhieuNai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLyDoKhieuNai.FormattingEnabled = true;
            this.cbLyDoKhieuNai.Items.AddRange(new object[] {
            "Hủy chuyến không báo trước",
            "Chất lượng dịch vụ kém",
            "Thái độ nhân viên không tốt",
            "Vấn đề với vé (mất vé, đổi vé, hoàn tiền)",
            "Tình trạng xe không an toàn",
            "Lý do khác"});
            this.cbLyDoKhieuNai.Location = new System.Drawing.Point(253, 37);
            this.cbLyDoKhieuNai.Name = "cbLyDoKhieuNai";
            this.cbLyDoKhieuNai.Size = new System.Drawing.Size(362, 29);
            this.cbLyDoKhieuNai.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lý do khiếu nại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mô tả chi tiết sự việc";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(253, 88);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(362, 86);
            this.txtMoTa.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbTuyenDuong);
            this.groupBox3.Controls.Add(this.cbThoiGian);
            this.groupBox3.Controls.Add(this.cbBienSoXe);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(25, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(638, 174);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chuyến xe";
            // 
            // cbTuyenDuong
            // 
            this.cbTuyenDuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTuyenDuong.FormattingEnabled = true;
            this.cbTuyenDuong.Items.AddRange(new object[] {
            "Hủy chuyến không báo trước",
            "Chất lượng dịch vụ kém",
            "Thái độ nhân viên không tốt",
            "Vấn đề với vé (mất vé, đổi vé, hoàn tiền)",
            "Tình trạng xe không an toàn",
            "Lý do khác"});
            this.cbTuyenDuong.Location = new System.Drawing.Point(253, 124);
            this.cbTuyenDuong.Name = "cbTuyenDuong";
            this.cbTuyenDuong.Size = new System.Drawing.Size(362, 29);
            this.cbTuyenDuong.TabIndex = 3;
            // 
            // cbThoiGian
            // 
            this.cbThoiGian.DropDownHeight = 1066;
            this.cbThoiGian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThoiGian.FormattingEnabled = true;
            this.cbThoiGian.IntegralHeight = false;
            this.cbThoiGian.Items.AddRange(new object[] {
            "Hủy chuyến không báo trước",
            "Chất lượng dịch vụ kém",
            "Thái độ nhân viên không tốt",
            "Vấn đề với vé (mất vé, đổi vé, hoàn tiền)",
            "Tình trạng xe không an toàn",
            "Lý do khác"});
            this.cbThoiGian.Location = new System.Drawing.Point(253, 78);
            this.cbThoiGian.Name = "cbThoiGian";
            this.cbThoiGian.Size = new System.Drawing.Size(362, 29);
            this.cbThoiGian.TabIndex = 3;
            // 
            // cbBienSoXe
            // 
            this.cbBienSoXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBienSoXe.FormattingEnabled = true;
            this.cbBienSoXe.Items.AddRange(new object[] {
            "Hủy chuyến không báo trước",
            "Chất lượng dịch vụ kém",
            "Thái độ nhân viên không tốt",
            "Vấn đề với vé (mất vé, đổi vé, hoàn tiền)",
            "Tình trạng xe không an toàn",
            "Lý do khác"});
            this.cbBienSoXe.Location = new System.Drawing.Point(253, 32);
            this.cbBienSoXe.Name = "cbBienSoXe";
            this.cbBienSoXe.Size = new System.Drawing.Size(362, 29);
            this.cbBienSoXe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Biển số xe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tuyến đường";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời gian khởi hành";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSoDienThoai);
            this.groupBox2.Controls.Add(this.txtHoVaTen);
            this.groupBox2.Location = new System.Drawing.Point(25, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 157);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cá nhân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(253, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(362, 26);
            this.txtEmail.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(253, 71);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(362, 26);
            this.txtSoDienThoai.TabIndex = 1;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(253, 26);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(362, 26);
            this.txtHoVaTen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 0;
            // 
            // FrmKhieuNai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 758);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmKhieuNai";
            this.Text = "FrmKhieuNai";
            this.Load += new System.EventHandler(this.FrmKhieuNai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbLyDoKhieuNai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.CheckBox cbXacNhan;
        private System.Windows.Forms.ComboBox cbBienSoXe;
        private System.Windows.Forms.ComboBox cbTuyenDuong;
        private System.Windows.Forms.ComboBox cbThoiGian;
    }
}