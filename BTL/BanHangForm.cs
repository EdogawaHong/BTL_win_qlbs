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
using DTOs;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace BTL
{
    public partial class BanHangForm : Form
    {
        public string MANV, TENNV;
        KhachHang_BUL khachHang_BUL = new KhachHang_BUL();
        Sach_BUL sach_BUL = new Sach_BUL();
        HoaDon_BUL hoaDon_BUL = new HoaDon_BUL();
        ChiTietHD_BUL chiTietHD_BUL = new ChiTietHD_BUL();
        List<SanPham> sanPhams = new List<SanPham>();
        BindingSource dts = new BindingSource();
        public BanHangForm(string manv, string tennv)
        {
            InitializeComponent();
            this.MANV = manv;
            this.TENNV = tennv;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int slc = sach_BUL.SoLuongCon(cbSach.SelectedValue.ToString());
            int soluong = int.Parse(nbSoLuong.Value.ToString());
            if (soluong > 0)
            {
                if (slc > soluong)
                {
                    SanPham sp = sach_BUL.Get_SanPham(cbSach.SelectedValue.ToString(), soluong);
                    if (!sanPhams.Contains(sp))
                    {
                        sanPhams.Add(sp);
                        dts.Add(sp);
                        lbTongTien.Text = TongTien().ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Só lượng sách hiện có không đủ!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn số lượng sách muốn mua!", "Thông báo");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int slc = sach_BUL.SoLuongCon(cbSach.SelectedValue.ToString());
            int soluong = int.Parse(nbSoLuong.Value.ToString());
            if (soluong > 0)
            {
                if (slc > soluong)
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
                    MessageBox.Show("Só lượng sách hiện có không đủ!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn số lượng sách muốn mua!", "Thông báo");
            }
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            exportgridview(grvDanhSach_SP, "HoaDon" + txtMaHD.Text);
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int khachtra = int.Parse(txtKhachTra.Text);
                if (khachtra < TongTien())
                {
                    MessageBox.Show("Khách trả thiếu tiền! Vui lòng nhập số tiền lớn hơn hoặc bằng số tiền phải trả!", "Thông báo");
                }
                else
                {
                    lbTienThua.Text = (khachtra - TongTien()).ToString();
                    HoaDon hd = new HoaDon();
                    hd.manv = MANV;
                    hd.makh = cbKH.SelectedValue.ToString();
                    hd.ngaymua = DateTime.Parse(dtNgayMua.Value.ToString());
                    hd.khachtra = khachtra;

                    if (hoaDon_BUL.Them_HD(hd))
                    {
                        int count = hoaDon_BUL.GetTable_HD().Count;
                        hd.mahd = hoaDon_BUL.GetTable_HD()[count - 1].mahd.ToString();
                        txtMaHD.Text = hd.mahd;
                        foreach (SanPham sp in sanPhams)
                        {
                            if(chiTietHD_BUL.Them_CT(hd.mahd, sp.ma, sp.soluong))
                            {
                                sach_BUL.CapNhatSoLuong(sp.ma, sp.soluong);
                            }
                        }
                    }

                }
                btnXuatHoaDon.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Yêu cầu nhập số nguyên dương lớn hơn hoặc bằng số tiền phải trả!", "Thông báo");
            }
        }

        private void BanHangForm_Load(object sender, EventArgs e)
        {
            cbKH.DataSource = khachHang_BUL.GetTable_KH();
            cbKH.DisplayMember = "ten";
            cbKH.ValueMember = "ma";

            cbSach.DataSource = sach_BUL.GetTable_Sach();
            cbSach.DisplayMember = "tensach";
            cbSach.ValueMember = "masach";

            lbTenNV.Text = TENNV;

            dts.DataSource = typeof(SanPham);
            grvDanhSach_SP.DataSource = dts;
            grvDanhSach_SP.AutoGenerateColumns = false;

            btnXuatHoaDon.Enabled = false;
            dtNgayMua.Enabled = false;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyForm quanLyForm = new QuanLyForm(MANV, TENNV);
            quanLyForm.ShowDialog();
            this.Close();
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
                    pdfdoc.Add(new Phrase("                     HOA DON BAN HANG\n\n"));
                    pdfdoc.Add(new Phrase("Ma hoa don: " + txtMaHD.Text));
                    pdfdoc.Add(new Phrase("\nNhan vien: " + lbTenNV.Text));
                    pdfdoc.Add(new Phrase("\nNgay: " + dtNgayMua.Value.ToString()));
                    pdfdoc.Add(pdfPTable);
                    pdfdoc.Add(new Phrase("\n                                               Tien hang: " + lbTongTien.Text));
                    pdfdoc.Add(new Phrase("\n                                               Khach dua: " + txtKhachTra.Text));
                    pdfdoc.Add(new Phrase("\n                                               Tien tra lai: " + lbTienThua.Text));
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }
    }
}
