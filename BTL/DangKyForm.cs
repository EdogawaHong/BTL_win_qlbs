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
    public partial class DangKyForm : Form
    {
        NhanVien_BUL nhanVien_BUL = new NhanVien_BUL();
        public DangKyForm()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (check_textbox())
            {
                NhanVien nv = new NhanVien(txtTenNV.Text, txtDiaChiNV.Text, txtSdtNV.Text, txtMatKhau.Text);
                if (nhanVien_BUL.Them_NV(nv))
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo");
                    this.Hide();
                    DangNhapForm dangNhapForm = new DangNhapForm(nv.sdt, nv.matkhau);
                    dangNhapForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi đăng ký!", "Thông báo");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhapForm dangNhapForm = new DangNhapForm();
            dangNhapForm.ShowDialog();
            this.Close();
        }

        private bool check_textbox()
        {
            if(string.IsNullOrEmpty(txtTenNV.Text)||
                string.IsNullOrEmpty(txtDiaChiNV.Text)||
                string.IsNullOrEmpty(txtSdtNV.Text)||
                string.IsNullOrEmpty(txtMatKhau.Text)||
                string.IsNullOrEmpty(txtXacNhan.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
                return false;
            }
            else
            {
                if (!Check_SDT.Check(txtSdtNV.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo");
                    return false;
                }
                else
                {
                    if (txtMatKhau.Text != txtXacNhan.Text)
                    {
                        MessageBox.Show("Mật khẩu chưa trùng khớp!", "Thông báo");
                        return false;
                    }
                    return true;
                }
            }
        }
    }
}
