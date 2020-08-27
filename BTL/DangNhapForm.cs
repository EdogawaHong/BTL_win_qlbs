using BULs;
using DTOs;
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
    public partial class DangNhapForm : Form
    {
        NhanVien_BUL nhanVien_BUL = new NhanVien_BUL();
        public string SDT, MATKHAU;
        public DangNhapForm()
        {
            InitializeComponent();
        }
        public DangNhapForm(string sdt,string mk)
        {
            InitializeComponent();
            this.SDT = sdt;
            this.MATKHAU = mk;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSdtDN.Text = SDT;
            txtMatKhauDN.Text = MATKHAU;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSdtDN.Text) || string.IsNullOrEmpty(txtMatKhauDN.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin đăng nhập!", "Thông báo");
            }
            else
            {
                NhanVien nv = new NhanVien(txtSdtDN.Text, txtMatKhauDN.Text);
                if (nhanVien_BUL.GetList_NV().Contains(nv)){
                    foreach(NhanVien n in nhanVien_BUL.GetList_NV())
                    {
                        if (n.sdt.Equals(txtSdtDN.Text))
                        {
                            this.Hide();
                            QuanLyForm quanLyForm = new QuanLyForm(n.ma,n.ten);
                            quanLyForm.ShowDialog();
                            this.Close();
                        }
                    }
                }else MessageBox.Show("Vui lòng kiểm tra lại tài khoản!", "Thông báo");
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKyForm dangKyForm = new DangKyForm();
            dangKyForm.ShowDialog();
            this.Close();
        }
    }
}
