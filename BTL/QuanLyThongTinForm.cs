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
    public partial class QuanLyThongTinForm : Form
    {
        public string MANV, TENNV;
        NXB_BUL nXB_BUL = new NXB_BUL();
        TheLoai_BUL theLoai_BUL = new TheLoai_BUL();
        NCC_BUL nCC_BUL = new NCC_BUL();
        KhachHang_BUL khachHang_BUL = new KhachHang_BUL();
        Sach_BUL sach_BUL = new Sach_BUL();
        HoaDon_BUL hoaDon_BUL = new HoaDon_BUL();
        ChiTietHD_BUL chiTietHD_BUL = new ChiTietHD_BUL();
        PhieuNhap_BUL phieuNhap_BUL = new PhieuNhap_BUL();
        ChiTietPN_BUL chiTietPN_BUL = new ChiTietPN_BUL();
        public QuanLyThongTinForm(string manv, string tennv)
        {
            InitializeComponent();
            this.MANV = manv;
            this.TENNV = tennv;
            Load_Data();

            txtMaNXB.Enabled = false;
            txtMaTL.Enabled = false;
            txtMaNCC.Enabled = false;
            txtMaKH.Enabled = false;
            txtMaSach.Enabled = false;
            txtSoLuongCon.Enabled = false;
        }
        private void Load_Data()
        {
            grvDanhSachNXB.DataSource = nXB_BUL.GetTable_NXB();
            grvDanhSachTL.DataSource = theLoai_BUL.GetTable_TL();
            grvDanhSachNCC.DataSource = nCC_BUL.GetTable_NCC();
            grvDanhSachKH.DataSource = khachHang_BUL.GetTable_KH();
            grvDanhSachSach.DataSource = sach_BUL.GetTable_Sach();
            grvDanhSachHD.DataSource = hoaDon_BUL.GetTable_HD();
            grvDanhSachPN.DataSource = phieuNhap_BUL.GetTable_PN();

            cbTL.DataSource = theLoai_BUL.GetTable_TL();
            cbTL.DisplayMember = "ten";
            cbTL.ValueMember = "ma";

            cbNXB.DataSource = nXB_BUL.GetTable_NXB();
            cbNXB.DisplayMember = "ten";
            cbNXB.ValueMember = "ma";

            cbTimKiemSach.SelectedIndex = 0;
            cbTimKiemHD.SelectedIndex = 0;
            cbTimKiemPN.SelectedIndex = 0;
        }

        private void btnHienThiNXB_Click(object sender, EventArgs e)
        {
            grvDanhSachNXB.DataSource = nXB_BUL.GetTable_NXB();
        }

        private void btnThemNXB_Click(object sender, EventArgs e)
        {
            if (check_person(txtTenNXB.Text, txtDiaChiNXB.Text, txtSdtNXB.Text))
            {
                if (nXB_BUL.Them_NXB(new Person(txtTenNXB.Text, txtDiaChiNXB.Text, txtSdtNXB.Text)))
                {
                    Load_Data();
                    MessageBox.Show("Thêm mới thành công", "Thông báo");
                    Reset_NXB();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
                }
            }
        }

        private void btnSuaNXB_Click(object sender, EventArgs e)
        {
            if (check_person(txtTenNXB.Text, txtDiaChiNXB.Text, txtSdtNXB.Text))
            {
                if (!string.IsNullOrEmpty(txtMaNXB.Text))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin nhà xuất bản này không!", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (nXB_BUL.Sua_NXB(new Person(txtMaNXB.Text, txtTenNXB.Text, txtDiaChiNXB.Text, txtSdtNXB.Text)))
                        {
                            Load_Data();
                            MessageBox.Show("Sửa thành công", "Thông báo");
                            Reset_NXB();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn nhà xuất bản cần sửa!", "Thông báo");
                }
            }
        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaNXB.Text))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa nhà xuất bản này không!", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (nXB_BUL.Xoa_NXB(txtMaNXB.Text))
                    {
                        Load_Data();
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        Reset_NXB();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nhà xuất bản này!", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhà xuất bản cần xóa!", "Thông báo");
            }
        }

        private void btnTimKiemNXB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiemNXB.Text))
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm!", "Thông báo");
            else
            {
                if (nXB_BUL.TimKiem_NXB(txtTimKiemNXB.Text).Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin phù hợp!", "Thông báo");
                }
                else
                    grvDanhSachNXB.DataSource = nXB_BUL.TimKiem_NXB(txtTimKiemNXB.Text);
            }
        }

        private bool check_person(string ten, string diachi, string sdt)
        {
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
                return false;
            }
            else
            {
                if (Check_SDT.Check(sdt)) return true;
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo");
                    return false;
                }
            }
        }

        private void Cell_Click_NXB(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = grvDanhSachNXB.CurrentRow.Index;
                txtMaNXB.Text = grvDanhSachNXB.Rows[i].Cells[0].Value.ToString();
                txtTenNXB.Text = grvDanhSachNXB.Rows[i].Cells[1].Value.ToString();
                txtDiaChiNXB.Text = grvDanhSachNXB.Rows[i].Cells[2].Value.ToString();
                txtSdtNXB.Text = grvDanhSachNXB.Rows[i].Cells[3].Value.ToString();
            }
            catch { }
        }

        private void Reset_NXB()
        {
            txtMaNXB.Clear();
            txtTenNXB.Clear();
            txtDiaChiNXB.Clear();
            txtSdtNXB.Clear();
        }

        private void btnHienThiTL_Click(object sender, EventArgs e)
        {
            grvDanhSachTL.DataSource = theLoai_BUL.GetTable_TL();
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenTL.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
            }
            else
            {
                if (theLoai_BUL.Them_TL(new TheLoai(txtTenTL.Text)))
                {
                    Load_Data();
                    MessageBox.Show("Thêm mới thành công", "Thông báo");
                    Reset_TL();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
                }
            }
        }

        private void btnSuaTL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTL.Text))
            {
                MessageBox.Show("Bạn chưa chọn thể loại cần sửa!", "Thông báo");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTenTL.Text))
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin thể loại này không!", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (theLoai_BUL.Sua_TL(new TheLoai(txtMaTL.Text, txtTenTL.Text)))
                        {
                            Load_Data();
                            MessageBox.Show("Sửa thành công", "Thông báo");
                            Reset_TL();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
                        }
                    }
                }
            }
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTL.Text))
            {
                MessageBox.Show("Bạn chưa chọn thể loại cần xóa!", "Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa thể loại này không!", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (theLoai_BUL.Xoa_TL(txtMaTL.Text))
                    {
                        Load_Data();
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        Reset_TL();
                    }
                    else
                    {
                        MessageBox.Show("Bạn không thể xóa thể loại này!", "Thông báo");
                    }
                }
            }
        }

        private void btnTimKiemTL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiemTL.Text))
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm!", "Thông báo");
            else
            {
                if (theLoai_BUL.TimKiem_NXB(txtTimKiemTL.Text).Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin phù hợp!", "Thông báo");
                }
                else
                    grvDanhSachTL.DataSource = theLoai_BUL.TimKiem_NXB(txtTimKiemTL.Text);
            }
        }

        private void Cell_Click_TL(object sender, DataGridViewCellEventArgs e)
        {
            int i = grvDanhSachTL.CurrentRow.Index;
            txtMaTL.Text = grvDanhSachTL.Rows[i].Cells[0].Value.ToString();
            txtTenTL.Text = grvDanhSachTL.Rows[i].Cells[1].Value.ToString();
        }

        private void Reset_TL()
        {
            txtMaTL.Clear();
            txtTenTL.Clear();
        }

        private void btnHienThiNCC_Click(object sender, EventArgs e)
        {
            grvDanhSachNCC.DataSource = nCC_BUL.GetTable_NCC();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            if (check_person(txtTenNCC.Text, txtDiaChiNCC.Text, txtSdtNCC.Text))
            {
                if (nCC_BUL.Them_NCC(new Person(txtTenNCC.Text, txtDiaChiNCC.Text, txtSdtNCC.Text)))
                {
                    Load_Data();
                    MessageBox.Show("Thêm mới thành công", "Thông báo");
                    Reset_NCC();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
                }
            }
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            if (check_person(txtTenNCC.Text, txtDiaChiNCC.Text, txtSdtNCC.Text))
            {
                if (!string.IsNullOrEmpty(txtMaNCC.Text))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin nhà cung cấp này không!", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (nCC_BUL.Sua_NCC(new Person(txtMaNCC.Text, txtTenNCC.Text, txtDiaChiNCC.Text, txtSdtNCC.Text)))
                        {
                            Load_Data();
                            MessageBox.Show("Sửa thành công", "Thông báo");
                            Reset_NCC();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn nhà cung cấp cần sửa!", "Thông báo");
                }
            }
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaNCC.Text))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa nhà cung cấp này không!", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (nCC_BUL.Xoa_NCC(txtMaNCC.Text))
                    {
                        Load_Data();
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        Reset_NCC();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nhà cung cấp này!", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp cần xóa!", "Thông báo");
            }
        }

        private void btnTimKiemNCC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiemNCC.Text))
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm!", "Thông báo");
            else
            {
                if (nCC_BUL.TimKiem_NCC(txtTimKiemNCC.Text).Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin phù hợp!", "Thông báo");
                }
                else
                    grvDanhSachNCC.DataSource = nCC_BUL.TimKiem_NCC(txtTimKiemNCC.Text);
            }
        }

        private void Cell_click_NCC(object sender, DataGridViewCellEventArgs e)
        {
            int i = grvDanhSachNCC.CurrentRow.Index;
            txtMaNCC.Text = grvDanhSachNCC.Rows[i].Cells[0].Value.ToString();
            txtTenNCC.Text = grvDanhSachNCC.Rows[i].Cells[1].Value.ToString();
            txtDiaChiNCC.Text = grvDanhSachNCC.Rows[i].Cells[2].Value.ToString();
            txtSdtNCC.Text = grvDanhSachNCC.Rows[i].Cells[3].Value.ToString();
        }
        private void Reset_NCC()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChiNCC.Clear();
            txtSdtNCC.Clear();
        }

        private void btnHienThiKH_Click(object sender, EventArgs e)
        {
            grvDanhSachKH.DataSource = khachHang_BUL.GetTable_KH();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (check_person(txtTenKH.Text, txtDiaChiKH.Text, txtSdtKH.Text))
            {
                if (khachHang_BUL.Them_KH(new Person(txtTenKH.Text, txtDiaChiKH.Text, txtSdtKH.Text)))
                {
                    Load_Data();
                    MessageBox.Show("Thêm mới thành công", "Thông báo");
                    Reset_KH();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
                }
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (check_person(txtTenKH.Text, txtDiaChiKH.Text, txtSdtKH.Text))
            {
                if (!string.IsNullOrEmpty(txtMaKH.Text))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin khách hàng này không!", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (khachHang_BUL.Sua_KH(new Person(txtMaKH.Text, txtTenKH.Text, txtDiaChiKH.Text, txtSdtKH.Text)))
                        {
                            Load_Data();
                            MessageBox.Show("Sửa thành công", "Thông báo");
                            Reset_KH();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn khách hàng cần sửa!", "Thông báo");
                }
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaKH.Text))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa khách hàng này không!", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (khachHang_BUL.Xoa_KH(txtMaKH.Text))
                    {
                        Load_Data();
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        Reset_KH();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa khách hàng này!", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn khách hàng cần xóa!", "Thông báo");
            }
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiemKH.Text))
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm!", "Thông báo");
            else
            {
                if (khachHang_BUL.TimKiem_KH(txtTimKiemKH.Text).Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin phù hợp!", "Thông báo");
                }
                else
                    grvDanhSachKH.DataSource = khachHang_BUL.TimKiem_KH(txtTimKiemKH.Text);
            }
        }

        private void Cell_click_KH(object sender, DataGridViewCellEventArgs e)
        {
            int i = grvDanhSachKH.CurrentRow.Index;
            txtMaKH.Text = grvDanhSachKH.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = grvDanhSachKH.Rows[i].Cells[1].Value.ToString();
            txtDiaChiKH.Text = grvDanhSachKH.Rows[i].Cells[2].Value.ToString();
            txtSdtKH.Text = grvDanhSachKH.Rows[i].Cells[3].Value.ToString();
        }
        private void Reset_KH()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiaChiKH.Clear();
            txtSdtKH.Clear();
        }

        private void btnHienThiSach_Click(object sender, EventArgs e)
        {
            grvDanhSachSach.DataSource = sach_BUL.GetTable_Sach();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (Check_Sach())
            {
                Sach s = new Sach(txtTenSach.Text,
                    txtTacGia.Text,
                    int.Parse(txtDonGiaNhap.Text),
                    int.Parse(txtDonGiaBan.Text),
                    cbTL.SelectedValue.ToString(),
                    cbNXB.SelectedValue.ToString());
                if (sach_BUL.Them_Sach(s))
                {
                    Load_Data();
                    MessageBox.Show("Thêm mới thành công", "Thông báo");
                    Reset_Sach();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
                }
            }
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            if (Check_Sach())
            {
                if (!string.IsNullOrEmpty(txtMaSach.Text))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin sách này không!", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Sach s = new Sach(txtMaSach.Text,
                            txtTenSach.Text,
                            txtTacGia.Text,
                            int.Parse(txtDonGiaNhap.Text),
                            int.Parse(txtDonGiaBan.Text),
                            cbTL.SelectedValue.ToString(),
                            cbNXB.SelectedValue.ToString());
                        if (sach_BUL.Sua_Sach(s))
                        {
                            Load_Data();
                            MessageBox.Show("Sửa thành công", "Thông báo");
                            Reset_Sach();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra!", "Thông báo");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn khách hàng cần sửa!", "Thông báo");
                }
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaSach.Text))
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa sách này không!", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (sach_BUL.Xoa_Sach(txtMaSach.Text))
                    {
                        Load_Data();
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        Reset_Sach();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa sách này!", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sách cần xóa!", "Thông báo");
            }
        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            if (txtTimKiemSach.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm!", "Thông báo");
            }
            else
            {
                int i = cbTimKiemSach.SelectedIndex;
                if (sach_BUL.TimKiem_Sach(txtTimKiemSach.Text, i).Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin phù hợp!", "Thông báo");
                }
                else
                {
                    grvDanhSachSach.DataSource = sach_BUL.TimKiem_Sach(txtTimKiemSach.Text, i);
                }
            }
        }
        private bool Check_Sach()
        {
            if (string.IsNullOrEmpty(txtTenSach.Text) ||
                string.IsNullOrEmpty(txtTacGia.Text) ||
                string.IsNullOrEmpty(txtDonGiaNhap.Text) ||
                string.IsNullOrEmpty(txtDonGiaBan.Text) ||
                string.IsNullOrEmpty(cbTL.Text) ||
                string.IsNullOrEmpty(cbNXB.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo");
                return false;
            }
            else
            {
                try
                {
                    int dgn = int.Parse(txtDonGiaNhap.Text);
                    int dgb = int.Parse(txtDonGiaBan.Text);
                    if(dgn<dgb)
                        return true;
                    else
                    {
                        MessageBox.Show("Đơn giá nhập phải nhỏ hơn đơn giá bán", "Thông báo");
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Đơn giá là một số nguyên!", "Thông báo");
                    return false;
                }
            }
        }
        private void Reset_Sach()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtDonGiaBan.Clear();
            txtDonGiaNhap.Clear();
            txtSoLuongCon.Clear();
        }

        private void Cell_click_Sach(object sender, DataGridViewCellEventArgs e)
        {
            int i = grvDanhSachSach.CurrentRow.Index;
            txtMaSach.Text = grvDanhSachSach.Rows[i].Cells[0].Value.ToString();
            txtTenSach.Text = grvDanhSachSach.Rows[i].Cells[1].Value.ToString();
            txtTacGia.Text= grvDanhSachSach.Rows[i].Cells[2].Value.ToString();
            txtSoLuongCon.Text = grvDanhSachSach.Rows[i].Cells[5].Value.ToString();
            txtDonGiaNhap.Text = grvDanhSachSach.Rows[i].Cells[4].Value.ToString();
            txtDonGiaBan.Text = grvDanhSachSach.Rows[i].Cells[3].Value.ToString();
            cbTL.Text= grvDanhSachSach.Rows[i].Cells[6].Value.ToString();
            cbNXB.Text= grvDanhSachSach.Rows[i].Cells[7].Value.ToString();
        }

        private void btnTimKiemHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiemHD.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm!", "Thông báo");
            }
            else
            {
                int i = cbTimKiemHD.SelectedIndex;
                if (hoaDon_BUL.TimKiem_HD(txtTimKiemHD.Text, i).Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin phù hợp", "Thông báo");
                }
                else
                {
                    grvDanhSachHD.DataSource = hoaDon_BUL.TimKiem_HD(txtTimKiemHD.Text, i);
                }
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn cần xóa!", "Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa hóa đơn này không!", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    chiTietHD_BUL.Xoa_CT_MaHD(txtMaHD.Text);
                    hoaDon_BUL.Xoa_HD(txtMaHD.Text);
                    Load_Data();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
            }
        }

        private void btnXemChiTietHD_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietHoaDonForm chiTietHoaDonForm = new ChiTietHoaDonForm(MANV, TENNV,txtMaHD.Text);
            chiTietHoaDonForm.ShowDialog();
            this.Close();
        }

        private void Cell_Click_HD(object sender, DataGridViewCellEventArgs e)
        {
            int i = grvDanhSachHD.CurrentRow.Index;
            txtMaHD.Text = grvDanhSachHD.Rows[i].Cells[0].Value.ToString();
        }

        private void btnHienThiHD_Click(object sender, EventArgs e)
        {
            grvDanhSachHD.DataSource= hoaDon_BUL.GetTable_HD();
        }

        private void btnHienThiPN_Click(object sender, EventArgs e)
        {
            grvDanhSachPN.DataSource = phieuNhap_BUL.GetTable_PN();
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPN.Text))
            {
                MessageBox.Show("Bạn chưa chọn phiếu nhập cần xóa!", "Thông báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa phiếu nhập này không!", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    chiTietPN_BUL.Xoa_CT_MaPN(txtMaPN.Text);
                    phieuNhap_BUL.Xoa_PN(txtMaPN.Text);
                    Load_Data();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
            }
        }

        private void btnXemChiTietPN_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietPhieuNhapForm chiTietPhieuNhapForm = new ChiTietPhieuNhapForm(MANV, TENNV, txtMaPN.Text);
            chiTietPhieuNhapForm.ShowDialog();
            this.Close();
        }

        private void btnTimKiemPN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiemPN.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm!", "Thông báo");
            }
            else
            {
                int i = cbTimKiemPN.SelectedIndex;
                if (phieuNhap_BUL.TimKiem_PN(txtTimKiemPN.Text, i).Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin phù hợp", "Thông báo");
                }
                else
                {
                    grvDanhSachPN.DataSource = phieuNhap_BUL.TimKiem_PN(txtTimKiemPN.Text, i);
                }
            }
        }

        private void Cell_click_PN(object sender, DataGridViewCellEventArgs e)
        {
            int i = grvDanhSachPN.CurrentRow.Index;
            txtMaPN.Text = grvDanhSachPN.Rows[i].Cells[0].Value.ToString();
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
