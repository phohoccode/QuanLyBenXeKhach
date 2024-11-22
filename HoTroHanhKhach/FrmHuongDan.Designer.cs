namespace HoTroHanhKhach
{
    partial class FrmHuongDan
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbLoaiHuongDan = new System.Windows.Forms.ComboBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại hướng dẫn";
            // 
            // cbLoaiHuongDan
            // 
            this.cbLoaiHuongDan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiHuongDan.FormattingEnabled = true;
            this.cbLoaiHuongDan.Items.AddRange(new object[] {
            "Đặt Vé",
            "Quy Trình Khiếu Nại"});
            this.cbLoaiHuongDan.Location = new System.Drawing.Point(199, 15);
            this.cbLoaiHuongDan.Name = "cbLoaiHuongDan";
            this.cbLoaiHuongDan.Size = new System.Drawing.Size(485, 29);
            this.cbLoaiHuongDan.TabIndex = 2;
            this.cbLoaiHuongDan.SelectedIndexChanged += new System.EventHandler(this.cbLoaiHuongDan_SelectedIndexChanged);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContainer.Location = new System.Drawing.Point(0, 58);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(730, 700);
            this.panelContainer.TabIndex = 3;
            // 
            // FrmHuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 758);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.cbLoaiHuongDan);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmHuongDan";
            this.Text = "FrmHuongDan";
            this.Load += new System.EventHandler(this.FrmHuongDan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLoaiHuongDan;
        private System.Windows.Forms.Panel panelContainer;
    }
}