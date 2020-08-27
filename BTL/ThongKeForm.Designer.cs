namespace BTL
{
    partial class ThongKeForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBaoCaoNgay = new System.Windows.Forms.Button();
            this.lbTdt_Ngay = new System.Windows.Forms.Label();
            this.lbTsl_Ngay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grvBaoCaoNgay = new System.Windows.Forms.DataGridView();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBaoCaoThang = new System.Windows.Forms.Button();
            this.lbTdt_Thang = new System.Windows.Forms.Label();
            this.lbTsl_Thang = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grvBaoCaoThang = new System.Windows.Forms.DataGridView();
            this.dtThang = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBaoCaoNam = new System.Windows.Forms.Button();
            this.lbTsl_Nam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grvBaoCaoNam = new System.Windows.Forms.DataGridView();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lbTdt_Nam = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.TenSachNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTienNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSachThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTienThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSachNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTienNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoCaoNgay)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoCaoThang)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoCaoNam)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBaoCaoNgay);
            this.tabPage1.Controls.Add(this.lbTdt_Ngay);
            this.tabPage1.Controls.Add(this.lbTsl_Ngay);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.grvBaoCaoNgay);
            this.tabPage1.Controls.Add(this.dtNgay);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Báo cáo theo ngày";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBaoCaoNgay
            // 
            this.btnBaoCaoNgay.Location = new System.Drawing.Point(255, 12);
            this.btnBaoCaoNgay.Name = "btnBaoCaoNgay";
            this.btnBaoCaoNgay.Size = new System.Drawing.Size(75, 23);
            this.btnBaoCaoNgay.TabIndex = 6;
            this.btnBaoCaoNgay.Text = "Báo cáo";
            this.btnBaoCaoNgay.UseVisualStyleBackColor = true;
            this.btnBaoCaoNgay.Click += new System.EventHandler(this.btnBaoCaoNgay_Click);
            // 
            // lbTdt_Ngay
            // 
            this.lbTdt_Ngay.AutoSize = true;
            this.lbTdt_Ngay.Location = new System.Drawing.Point(602, 367);
            this.lbTdt_Ngay.Name = "lbTdt_Ngay";
            this.lbTdt_Ngay.Size = new System.Drawing.Size(13, 13);
            this.lbTdt_Ngay.TabIndex = 5;
            this.lbTdt_Ngay.Text = "0";
            // 
            // lbTsl_Ngay
            // 
            this.lbTsl_Ngay.AutoSize = true;
            this.lbTsl_Ngay.Location = new System.Drawing.Point(602, 335);
            this.lbTsl_Ngay.Name = "lbTsl_Ngay";
            this.lbTsl_Ngay.Size = new System.Drawing.Size(13, 13);
            this.lbTsl_Ngay.TabIndex = 4;
            this.lbTsl_Ngay.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng doanh thu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng số lượng bán được:";
            // 
            // grvBaoCaoNgay
            // 
            this.grvBaoCaoNgay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvBaoCaoNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBaoCaoNgay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSachNgay,
            this.SoLuongNgay,
            this.DonGiaNgay,
            this.ThanhTienNgay});
            this.grvBaoCaoNgay.Location = new System.Drawing.Point(6, 54);
            this.grvBaoCaoNgay.Name = "grvBaoCaoNgay";
            this.grvBaoCaoNgay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvBaoCaoNgay.Size = new System.Drawing.Size(710, 255);
            this.grvBaoCaoNgay.TabIndex = 1;
            // 
            // dtNgay
            // 
            this.dtNgay.CustomFormat = "yyyy-MM-dd";
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgay.Location = new System.Drawing.Point(6, 15);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(200, 20);
            this.dtNgay.TabIndex = 0;
            this.dtNgay.Value = new System.DateTime(2020, 8, 23, 0, 0, 0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBaoCaoThang);
            this.tabPage2.Controls.Add(this.lbTdt_Thang);
            this.tabPage2.Controls.Add(this.lbTsl_Thang);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.grvBaoCaoThang);
            this.tabPage2.Controls.Add(this.dtThang);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Báo cáo theo tháng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBaoCaoThang
            // 
            this.btnBaoCaoThang.Location = new System.Drawing.Point(255, 18);
            this.btnBaoCaoThang.Name = "btnBaoCaoThang";
            this.btnBaoCaoThang.Size = new System.Drawing.Size(75, 23);
            this.btnBaoCaoThang.TabIndex = 13;
            this.btnBaoCaoThang.Text = "Báo cáo";
            this.btnBaoCaoThang.UseVisualStyleBackColor = true;
            this.btnBaoCaoThang.Click += new System.EventHandler(this.btnBaoCaoThang_Click);
            // 
            // lbTdt_Thang
            // 
            this.lbTdt_Thang.AutoSize = true;
            this.lbTdt_Thang.Location = new System.Drawing.Point(656, 369);
            this.lbTdt_Thang.Name = "lbTdt_Thang";
            this.lbTdt_Thang.Size = new System.Drawing.Size(13, 13);
            this.lbTdt_Thang.TabIndex = 12;
            this.lbTdt_Thang.Text = "0";
            // 
            // lbTsl_Thang
            // 
            this.lbTsl_Thang.AutoSize = true;
            this.lbTsl_Thang.Location = new System.Drawing.Point(656, 337);
            this.lbTsl_Thang.Name = "lbTsl_Thang";
            this.lbTsl_Thang.Size = new System.Drawing.Size(13, 13);
            this.lbTsl_Thang.TabIndex = 11;
            this.lbTsl_Thang.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng doanh thu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tổng số lượng bán được:";
            // 
            // grvBaoCaoThang
            // 
            this.grvBaoCaoThang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvBaoCaoThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBaoCaoThang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSachThang,
            this.SoLuongThang,
            this.DonGiaThang,
            this.ThanhTienThang});
            this.grvBaoCaoThang.Location = new System.Drawing.Point(6, 60);
            this.grvBaoCaoThang.Name = "grvBaoCaoThang";
            this.grvBaoCaoThang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvBaoCaoThang.Size = new System.Drawing.Size(710, 255);
            this.grvBaoCaoThang.TabIndex = 8;
            // 
            // dtThang
            // 
            this.dtThang.CustomFormat = "yyyy-MM";
            this.dtThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThang.Location = new System.Drawing.Point(6, 21);
            this.dtThang.Name = "dtThang";
            this.dtThang.Size = new System.Drawing.Size(200, 20);
            this.dtThang.TabIndex = 7;
            this.dtThang.Value = new System.DateTime(2020, 8, 23, 0, 0, 0, 0);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtNam);
            this.tabPage3.Controls.Add(this.lbTdt_Nam);
            this.tabPage3.Controls.Add(this.btnBaoCaoNam);
            this.tabPage3.Controls.Add(this.lbTsl_Nam);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.grvBaoCaoNam);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Báo cáo theo năm";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBaoCaoNam
            // 
            this.btnBaoCaoNam.Location = new System.Drawing.Point(255, 20);
            this.btnBaoCaoNam.Name = "btnBaoCaoNam";
            this.btnBaoCaoNam.Size = new System.Drawing.Size(75, 23);
            this.btnBaoCaoNam.TabIndex = 13;
            this.btnBaoCaoNam.Text = "Báo cáo";
            this.btnBaoCaoNam.UseVisualStyleBackColor = true;
            this.btnBaoCaoNam.Click += new System.EventHandler(this.btnBaoCaoNam_Click);
            // 
            // lbTsl_Nam
            // 
            this.lbTsl_Nam.AutoSize = true;
            this.lbTsl_Nam.Location = new System.Drawing.Point(663, 341);
            this.lbTsl_Nam.Name = "lbTsl_Nam";
            this.lbTsl_Nam.Size = new System.Drawing.Size(13, 13);
            this.lbTsl_Nam.TabIndex = 11;
            this.lbTsl_Nam.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tổng doanh thu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tổng số lượng bán được:";
            // 
            // grvBaoCaoNam
            // 
            this.grvBaoCaoNam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvBaoCaoNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBaoCaoNam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSachNam,
            this.SoLuongNam,
            this.DonGiaNam,
            this.ThanhTienNam});
            this.grvBaoCaoNam.Location = new System.Drawing.Point(6, 62);
            this.grvBaoCaoNam.Name = "grvBaoCaoNam";
            this.grvBaoCaoNam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvBaoCaoNam.Size = new System.Drawing.Size(710, 255);
            this.grvBaoCaoNam.TabIndex = 8;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(706, 12);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 23);
            this.btnQuayLai.TabIndex = 2;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lbTdt_Nam
            // 
            this.lbTdt_Nam.AutoSize = true;
            this.lbTdt_Nam.Location = new System.Drawing.Point(663, 373);
            this.lbTdt_Nam.Name = "lbTdt_Nam";
            this.lbTdt_Nam.Size = new System.Drawing.Size(13, 13);
            this.lbTdt_Nam.TabIndex = 14;
            this.lbTdt_Nam.Text = "0";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(6, 20);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(188, 20);
            this.txtNam.TabIndex = 15;
            // 
            // TenSachNgay
            // 
            this.TenSachNgay.DataPropertyName = "TenSach";
            this.TenSachNgay.HeaderText = "Tên sách";
            this.TenSachNgay.Name = "TenSachNgay";
            // 
            // SoLuongNgay
            // 
            this.SoLuongNgay.DataPropertyName = "SoLuongBan";
            this.SoLuongNgay.HeaderText = "Số lượng";
            this.SoLuongNgay.Name = "SoLuongNgay";
            // 
            // DonGiaNgay
            // 
            this.DonGiaNgay.DataPropertyName = "DonGia";
            this.DonGiaNgay.HeaderText = "Đơn giá";
            this.DonGiaNgay.Name = "DonGiaNgay";
            // 
            // ThanhTienNgay
            // 
            this.ThanhTienNgay.DataPropertyName = "ThanhTien";
            this.ThanhTienNgay.HeaderText = "Thành tiền";
            this.ThanhTienNgay.Name = "ThanhTienNgay";
            // 
            // TenSachThang
            // 
            this.TenSachThang.DataPropertyName = "TenSach";
            this.TenSachThang.HeaderText = "Tên sách";
            this.TenSachThang.Name = "TenSachThang";
            // 
            // SoLuongThang
            // 
            this.SoLuongThang.DataPropertyName = "SoLuongBan";
            this.SoLuongThang.HeaderText = "Số lượng";
            this.SoLuongThang.Name = "SoLuongThang";
            // 
            // DonGiaThang
            // 
            this.DonGiaThang.DataPropertyName = "DonGia";
            this.DonGiaThang.HeaderText = "Đơn giá";
            this.DonGiaThang.Name = "DonGiaThang";
            // 
            // ThanhTienThang
            // 
            this.ThanhTienThang.DataPropertyName = "ThanhTien";
            this.ThanhTienThang.HeaderText = "Thành tiền";
            this.ThanhTienThang.Name = "ThanhTienThang";
            // 
            // TenSachNam
            // 
            this.TenSachNam.DataPropertyName = "TenSach";
            this.TenSachNam.HeaderText = "Tên sách";
            this.TenSachNam.Name = "TenSachNam";
            // 
            // SoLuongNam
            // 
            this.SoLuongNam.DataPropertyName = "SoLuongBan";
            this.SoLuongNam.HeaderText = "Số lượng";
            this.SoLuongNam.Name = "SoLuongNam";
            // 
            // DonGiaNam
            // 
            this.DonGiaNam.DataPropertyName = "DonGia";
            this.DonGiaNam.HeaderText = "Đơn giá";
            this.DonGiaNam.Name = "DonGiaNam";
            // 
            // ThanhTienNam
            // 
            this.ThanhTienNam.DataPropertyName = "ThanhTien";
            this.ThanhTienNam.HeaderText = "Thành tiền";
            this.ThanhTienNam.Name = "ThanhTienNam";
            // 
            // ThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.tabControl1);
            this.Name = "ThongKeForm";
            this.Text = "Thống kê báo cáo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoCaoNgay)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoCaoThang)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoCaoNam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.DataGridView grvBaoCaoNgay;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Button btnBaoCaoNgay;
        private System.Windows.Forms.Label lbTdt_Ngay;
        private System.Windows.Forms.Label lbTsl_Ngay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaoCaoThang;
        private System.Windows.Forms.Label lbTdt_Thang;
        private System.Windows.Forms.Label lbTsl_Thang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grvBaoCaoThang;
        private System.Windows.Forms.DateTimePicker dtThang;
        private System.Windows.Forms.Button btnBaoCaoNam;
        private System.Windows.Forms.Label lbTsl_Nam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView grvBaoCaoNam;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label lbTdt_Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSachNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSachThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSachNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienNam;
    }
}