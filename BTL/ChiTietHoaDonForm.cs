using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;
using BULs;

namespace BTL
{
    public partial class ChiTietHoaDonForm : Form
    {
        public string MANV, TENNV;
        HoaDon_BUL hoaDon_BUL = new HoaDon_BUL();
        ChiTietHD_BUL chiTietHD_BUL = new ChiTietHD_BUL();
        public ChiTietHoaDonForm(string manv,string tennv,string mahd)
        {
            InitializeComponent();
            this.MANV = manv;
            this.TENNV = tennv;
            txtMaHD.Text = mahd;
            Load_Data(txtMaHD.Text);
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn cần xem!", "Thông báo");
            }
            else Load_Data(txtMaHD.Text);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyThongTinForm quanLyThongTinForm = new QuanLyThongTinForm(MANV, TENNV);
            quanLyThongTinForm.ShowDialog();
            this.Close();
        }
        private void Load_Data(string ma)
        {
            if (hoaDon_BUL.Get_HD(ma) != null)
            {
                HoaDon hd = hoaDon_BUL.Get_HD(ma);
                lbTenNV.Text = hd.tennv;
                lbTenKH.Text = hd.tenkh;
                lbNgayMua.Text = hd.ngaymua.ToString();
                lbKhachDua.Text = hd.khachtra.ToString();
                lbTongTien.Text = chiTietHD_BUL.TongTien(hd.mahd).ToString();
                lbTienThua.Text = (hd.khachtra - chiTietHD_BUL.TongTien(hd.mahd)).ToString();
                grvDanhSach.DataSource = chiTietHD_BUL.GetTable_CT(hd.mahd);
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn có mã " + ma, "Thông báo");
            }
        }
    }
}
