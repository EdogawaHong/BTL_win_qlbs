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
    public partial class ChiTietPhieuNhapForm : Form
    {
        public string MANV, TENNV;
        PhieuNhap_BUL phieuNhap_BUL = new PhieuNhap_BUL();
        ChiTietPN_BUL chiTietPN_BUL = new ChiTietPN_BUL();
        public ChiTietPhieuNhapForm(string manv, string tennv, string mahd)
        {
            InitializeComponent();
            this.MANV = manv;
            this.TENNV = tennv;
            txtMaPN.Text = mahd;
            Load_Data(txtMaPN.Text);
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPN.Text))
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn cần xem!", "Thông báo");
            }
            else Load_Data(txtMaPN.Text);
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
            if (phieuNhap_BUL.Get_PN(ma) != null)
            {
                PhieuNhap pn = phieuNhap_BUL.Get_PN(ma);
                lbTenNV.Text = pn.tennv;
                lbTenNCC.Text = pn.tenncc;
                lbNgayNhap.Text = pn.ngaynhap.ToString();
                lbTongTien.Text = chiTietPN_BUL.TongTien(pn.mapn).ToString();
                grvDanhSach.DataSource = chiTietPN_BUL.GetTable_CT(pn.mapn);
            }
            else
            {
                MessageBox.Show("Không tìm thấy phiếu nhập có mã " + ma, "Thông báo");
            }
        }
    }
}
