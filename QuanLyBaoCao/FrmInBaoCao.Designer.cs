﻿namespace QuanLyBaoCao
{
    partial class FrmInBaoCao
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
            this.dgvDSBaoCao = new System.Windows.Forms.DataGridView();
            this.cbDinhDang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInNgay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBaoCao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSBaoCao
            // 
            this.dgvDSBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBaoCao.Location = new System.Drawing.Point(9, 35);
            this.dgvDSBaoCao.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dgvDSBaoCao.Name = "dgvDSBaoCao";
            this.dgvDSBaoCao.ReadOnly = true;
            this.dgvDSBaoCao.RowHeadersWidth = 51;
            this.dgvDSBaoCao.RowTemplate.Height = 24;
            this.dgvDSBaoCao.Size = new System.Drawing.Size(608, 565);
            this.dgvDSBaoCao.TabIndex = 1;
            // 
            // cbDinhDang
            // 
            this.cbDinhDang.FormattingEnabled = true;
            this.cbDinhDang.Items.AddRange(new object[] {
            "Word",
            "PDF"});
            this.cbDinhDang.Location = new System.Drawing.Point(214, 50);
            this.cbDinhDang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDinhDang.Name = "cbDinhDang";
            this.cbDinhDang.Size = new System.Drawing.Size(180, 35);
            this.cbDinhDang.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn định dạnh:";
            // 
            // btnInNgay
            // 
            this.btnInNgay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnInNgay.Location = new System.Drawing.Point(410, 20);
            this.btnInNgay.Name = "btnInNgay";
            this.btnInNgay.Size = new System.Drawing.Size(207, 65);
            this.btnInNgay.TabIndex = 4;
            this.btnInNgay.Text = "In ngay";
            this.btnInNgay.UseVisualStyleBackColor = false;
            this.btnInNgay.Click += new System.EventHandler(this.btnInNgay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSBaoCao);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 611);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các báo cáo doanh thu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbDinhDang);
            this.groupBox2.Controls.Add(this.btnInNgay);
            this.groupBox2.Location = new System.Drawing.Point(12, 643);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 98);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cấu hình";
            // 
            // FrmInBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 753);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "In Báo Cáo";
            this.Load += new System.EventHandler(this.FrmInBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBaoCao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSBaoCao;
        private System.Windows.Forms.ComboBox cbDinhDang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInNgay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}