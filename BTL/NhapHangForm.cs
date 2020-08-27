using BULs;
using DTOs;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class NhapHangForm : Form
    {
        public string MANV, TENNV;
        Sach_BUL sach_BUL = new Sach_BUL();
        NCC_BUL nCC_BUL = new NCC_BUL();
        PhieuNhap_BUL phieuNhap_BUL = new PhieuNhap_BUL();
        ChiTietPN_BUL chiTietPN_BUL = new ChiTietPN_BUL();

        List<SanPham> sanPhams = new List<SanPham>();
        BindingSource dts = new BindingSource();
        public NhapHangForm(string manv, string tennv)
        {
            InitializeComponent();
            this.MANV = manv;
            this.TENNV = tennv;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int soluong = int.Parse(nbSoLuong.Value.ToString());
            if (soluong > 0)
            {
                SanPham sp = sach_BUL.Get_SanPhamNhap(cbSach.SelectedValue.ToString(), soluong);
                if (!sanPhams.Contains(sp))
                {
                    sanPhams.Add(sp);
                    dts.Add(sp);
                    lbTongTien.Text = TongTien().ToString();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn số lượng sách cần nhập!", "Thông báo");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int soluong = int.Parse(nbSoLuong.Value.ToString());
            if (soluong > 0)
            {

                foreach (SanPham sp in sanPhams)
                {
                    if (sp.ma.Equals(cbSach.SelectedValue.ToString()))
                    {
                        sp.soluong = soluong;
                        sp.tinhtien = sp.soluong * sp.dongia;
                        HienThi();
                        break;
                    }
                }

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn số lượng sách cần nhập!", "Thông báo");
            }
        }

        private void btnXuatPhieu_Click(object sender, EventArgs e)
        {
            exportgridview(grvDanhSach_SP, "PhieuNhap" + txtMaPN.Text);
        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            if (sanPhams.Count != 0)
            {
                PhieuNhap pn = new PhieuNhap();
                pn.manv = MANV;
                pn.mancc = cbNCC.SelectedValue.ToString();
                pn.ngaynhap = DateTime.Parse(dtNgayNhap.Value.ToString());

                if (phieuNhap_BUL.Them_PN(pn))
                {
                    int count = phieuNhap_BUL.GetTable_PN().Count;
                    pn.mapn = phieuNhap_BUL.GetTable_PN()[count - 1].mapn.ToString();
                    txtMaPN.Text = pn.mapn;
                    foreach (SanPham sp in sanPhams)
                    {
                        if (chiTietPN_BUL.Them_CT(pn.mapn, sp.ma, sp.soluong))
                        {
                            sach_BUL.CapNhatSoLuongNhap(sp.ma, sp.soluong);
                        }
                    }
                }
                btnXuatPhieu.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sách cần nhập!", "Thông báo");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyForm quanLyForm = new QuanLyForm(MANV, TENNV);
            quanLyForm.ShowDialog();
            this.Close();
        }

        private void NhapHangForm_Load(object sender, EventArgs e)
        {
            cbNCC.DataSource = nCC_BUL.GetTable_NCC();
            cbNCC.DisplayMember = "ten";
            cbNCC.ValueMember = "ma";

            cbSach.DataSource = sach_BUL.GetTable_Sach();
            cbSach.DisplayMember = "tensach";
            cbSach.ValueMember = "masach";

            lbTenNV.Text = TENNV;

            dts.DataSource = typeof(SanPham);
            grvDanhSach_SP.DataSource = dts;
            grvDanhSach_SP.AutoGenerateColumns = false;

            btnXuatPhieu.Enabled = false;
            dtNgayNhap.Enabled = false;
        }

        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < sanPhams.Count)
            {
                try
                {
                    int i = grvDanhSach_SP.CurrentRow.Index;
                    nbSoLuong.Value = int.Parse(grvDanhSach_SP.Rows[i].Cells[3].Value.ToString());
                    cbSach.Text = grvDanhSach_SP.Rows[i].Cells[2].Value.ToString();

                    if (e.ColumnIndex == 0)
                    {
                        sanPhams.RemoveAt(i);
                        HienThi();
                    }
                }
                catch { }
            }
        }
        private long TongTien()
        {
            long tongtien = 0;
            foreach (SanPham sp in sanPhams)
            {
                tongtien += sp.tinhtien;
            }
            return tongtien;
        }

        private void HienThi()
        {
            grvDanhSach_SP.Rows.Clear();
            foreach (SanPham sp in sanPhams)
            {
                dts.Add(sp);
            }
            lbTongTien.Text = TongTien().ToString();
        }
        public void exportgridview(DataGridView grv, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(grv.Columns.Count - 1);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            foreach (DataGridViewColumn column in grv.Columns)
            {
                if (column.Index != 0)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfPTable.AddCell(cell);
                }
            }

            foreach (DataGridViewRow row in grv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex != 0)
                        pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A6, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(new Phrase("Nha sach Su Pham \nDC: 136 Xuan Thuy, Cau Giay, HN\n\n"));
                    pdfdoc.Add(new Phrase("                PHIEU NHAP HANG\n\n"));
                    pdfdoc.Add(new Phrase("Ma phieu: " + txtMaPN.Text));
                    pdfdoc.Add(new Phrase("\nNhan vien: " + lbTenNV.Text));
                    pdfdoc.Add(new Phrase("\nNgay: " + dtNgayNhap.Value.ToString()));
                    pdfdoc.Add(pdfPTable);
                    pdfdoc.Add(new Phrase("\n                                       Tien hang: " + lbTongTien.Text));
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }
    }
}
