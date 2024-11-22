namespace HoTroHanhKhach
{
    partial class FrmHoTroHanhKhach
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
            this.btnKhieuNai = new System.Windows.Forms.Button();
            this.btnThonTinLienHe = new System.Windows.Forms.Button();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKhieuNai);
            this.panel1.Controls.Add(this.btnThonTinLienHe);
            this.panel1.Controls.Add(this.btnHuongDan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 758);
            this.panel1.TabIndex = 0;
            // 
            // btnKhieuNai
            // 
            this.btnKhieuNai.Image = global::HoTroHanhKhach.Properties.Resources.complaint;
            this.btnKhieuNai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhieuNai.Location = new System.Drawing.Point(10, 156);
            this.btnKhieuNai.Name = "btnKhieuNai";
            this.btnKhieuNai.Size = new System.Drawing.Size(200, 42);
            this.btnKhieuNai.TabIndex = 1;
            this.btnKhieuNai.Text = "Gửi khiếu nại";
            this.btnKhieuNai.UseVisualStyleBackColor = true;
            this.btnKhieuNai.Click += new System.EventHandler(this.btnKhieuNai_Click);
            // 
            // btnThonTinLienHe
            // 
            this.btnThonTinLienHe.Image = global::HoTroHanhKhach.Properties.Resources.file__1_;
            this.btnThonTinLienHe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThonTinLienHe.Location = new System.Drawing.Point(10, 28);
            this.btnThonTinLienHe.Name = "btnThonTinLienHe";
            this.btnThonTinLienHe.Size = new System.Drawing.Size(200, 42);
            this.btnThonTinLienHe.TabIndex = 1;
            this.btnThonTinLienHe.Text = "Thông tin liên hệ";
            this.btnThonTinLienHe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThonTinLienHe.UseVisualStyleBackColor = true;
            this.btnThonTinLienHe.Click += new System.EventHandler(this.btnThonTinLienHe_Click);
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Image = global::HoTroHanhKhach.Properties.Resources.user_guide;
            this.btnHuongDan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuongDan.Location = new System.Drawing.Point(10, 90);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(200, 42);
            this.btnHuongDan.TabIndex = 1;
            this.btnHuongDan.Text = "Hướng dẫn";
            this.btnHuongDan.UseVisualStyleBackColor = true;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(270, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(730, 758);
            this.panelContainer.TabIndex = 2;
            // 
            // FrmHoTroHanhKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 758);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHoTroHanhKhach";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmHoTroHanhKhach_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThonTinLienHe;
        private System.Windows.Forms.Button btnHuongDan;
        private System.Windows.Forms.Button btnKhieuNai;
        private System.Windows.Forms.Panel panelContainer;
    }
}

