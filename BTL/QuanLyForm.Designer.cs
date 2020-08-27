namespace BTL
{
    partial class QuanLyForm
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
            this.btnQuanLyThongTin = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuanLyThongTin
            // 
            this.btnQuanLyThongTin.Image = global::BTL.Properties.Resources.icons8_info_popup_64__1_;
            this.btnQuanLyThongTin.Location = new System.Drawing.Point(83, 126);
            this.btnQuanLyThongTin.Name = "btnQuanLyThongTin";
            this.btnQuanLyThongTin.Size = new System.Drawing.Size(234, 77);
            this.btnQuanLyThongTin.TabIndex = 4;
            this.btnQuanLyThongTin.Text = "Quản lý thông tin";
            this.btnQuanLyThongTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyThongTin.UseVisualStyleBackColor = true;
            this.btnQuanLyThongTin.Click += new System.EventHandler(this.btnQuanLyThongTin_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Image = global::BTL.Properties.Resources.icons8_task_64;
            this.btnNhapHang.Location = new System.Drawing.Point(403, 258);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(234, 77);
            this.btnNhapHang.TabIndex = 3;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Image = global::BTL.Properties.Resources.icons8_sell_stock_64;
            this.btnBanHang.Location = new System.Drawing.Point(83, 258);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(234, 77);
            this.btnBanHang.TabIndex = 2;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Image = global::BTL.Properties.Resources.icons8_statistics_64;
            this.btnThongKe.Location = new System.Drawing.Point(403, 126);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(234, 77);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "Thống kê báo cáo";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL.Properties.Resources.icons8_person_calendar_24;
            this.pictureBox1.Location = new System.Drawing.Point(562, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 25);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTenNV.Location = new System.Drawing.Point(597, 18);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(76, 13);
            this.lbTenNV.TabIndex = 7;
            this.lbTenNV.Text = "Tên nhân viên";
            this.lbTenNV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(600, 45);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(75, 23);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // QuanLyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.lbTenNV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuanLyThongTin);
            this.Controls.Add(this.btnNhapHang);
            this.Controls.Add(this.btnBanHang);
            this.Controls.Add(this.btnThongKe);
            this.Name = "QuanLyForm";
            this.Text = "Quản lý bán sách - nhà sách Sư Phạm";
            this.Load += new System.EventHandler(this.QuanLyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnQuanLyThongTin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Button btnDangXuat;
    }
}