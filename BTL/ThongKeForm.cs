using BULs;
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
    public partial class ThongKeForm : Form
    {
        BaoCao_BUL baoCao_BUL = new BaoCao_BUL();
        public string MANV, TENNV;
        public ThongKeForm(string manv, string tennv)
        {
            InitializeComponent();
            this.MANV = manv;
            this.TENNV = tennv;
        }

        private void btnBaoCaoNgay_Click(object sender, EventArgs e)
        {
            string date = dtNgay.Text;
            grvBaoCaoNgay.DataSource = baoCao_BUL.BaoCao_Ngay(date);
            lbTsl_Ngay.Text = baoCao_BUL.BaoCao_TongSL_Ngay(date).ToString();
            lbTdt_Ngay.Text = baoCao_BUL.BaoCao_TongDT_Ngay(date).ToString();
        }

        private void btnBaoCaoThang_Click(object sender, EventArgs e)
        {
            string month = dtThang.Text;
            grvBaoCaoThang.DataSource = baoCao_BUL.BaoCao_Thang(month);
            lbTsl_Thang.Text = baoCao_BUL.BaoCao_TongSL_Thang(month).ToString();
            lbTdt_Thang.Text = baoCao_BUL.BaoCao_TongDT_Thang(month).ToString();
        }

        private void btnBaoCaoNam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNam.Text))
            {
                MessageBox.Show("Bạn chưa nhập năm xuất báo cáo!", "Thông báo");
            }
            else
            {
                string year = txtNam.Text;
                grvBaoCaoNam.DataSource = baoCao_BUL.BaoCao_Nam(year);
                lbTsl_Nam.Text = baoCao_BUL.BaoCao_TongSL_Nam(year).ToString();
                lbTdt_Nam.Text = baoCao_BUL.BaoCao_TongDT_Nam(year).ToString();
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyForm quanLyForm = new QuanLyForm(MANV, TENNV);
            quanLyForm.ShowDialog();
            this.Close();
        }
    }
}
