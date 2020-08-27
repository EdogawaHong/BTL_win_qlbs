using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class QuanLyForm : Form
    {
        public string MANV, TENNV;
        public QuanLyForm(string manv,string tennv)
        {
            InitializeComponent();
            this.MANV = manv;
            this.TENNV = tennv;
        }

        private void btnQuanLyThongTin_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyThongTinForm quanLyThongTinForm = new QuanLyThongTinForm(MANV,TENNV);
            quanLyThongTinForm.ShowDialog();
            this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongKeForm thongKeForm = new ThongKeForm(MANV, TENNV);
            thongKeForm.ShowDialog();
            this.Close();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            BanHangForm banHangForm = new BanHangForm(MANV, TENNV);
            banHangForm.ShowDialog();
            this.Close();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhapHangForm nhapHangForm=new NhapHangForm(MANV, TENNV);
            nhapHangForm.ShowDialog();
            this.Close();
        }

        private void QuanLyForm_Load(object sender, EventArgs e)
        {
            lbTenNV.Text = TENNV;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhapForm dangNhapForm = new DangNhapForm();
            dangNhapForm.ShowDialog();
            this.Close();
        }
    }
}
