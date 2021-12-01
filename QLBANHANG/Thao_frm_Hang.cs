using QLBANHANG.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBANHANG
{
    public partial class Thao_frm_Hang : Form
    {
        int dong = -1, flag =0;
        string current_id = "no";
        ConnectDB cn = new ConnectDB();
        Function f = new Function();
        public Thao_frm_Hang()
        {
            InitializeComponent();
            cn.LoadCombobox(cbChonLoaiHang, "Select * from tbl_loai", "TenLoai", "Ma");
            cn.LoadCombobox(cbLocLoaiHang, "Select * from tbl_loai", "TenLoai", "Ma");
            cn.LoadCombobox(cbDvt,"select * from tbl_dvt","ten","id");
            LoadDanhSach();
            LoadDuLieuVaoDanhSach();
            cbThue.SelectedIndex = 0;
            flag++;
        }
        public void LoadDuLieuVaoDanhSach()
        {
            /*foreach (DataGridViewRow item in dgDanhSach.Rows)
            {
                var id_loai = item.Cells["loai"].Value.ToString();
                var id_dvt = item.Cells["dvt"].Value.ToString();
                var ten = f.GetLoaiSanPham(id_loai).TenLoai;
                var dvt = f.GetDonViTinh(id_dvt).Ten;
                item.Cells["loai"].Value = ten;
                item.Cells["dvt"].Value = dvt;
            }*/
        }
        public void LoadDanhSach()
        {
            List<tbl_HANG> list = f.GetListSanPham();
            dgDanhSach.DataSource = list;
        }
        public void Lammoi()
        {
                txtMaSP.Text = "SP"+f.RandomNumber()+f.Random(2);
                txtGiaBan.Text = "0";
                txtGiaNhap.Text = "0";
                txtChietKhau.Text = "0";
                txtTenSP.Text = "";
                txtMauSac.Text = "";
                txtMota.Text = "";
                cbTrangthai.Checked = false;
                cbThue.SelectedValue = 0;   
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Lammoi();
            btnLuu.Enabled = true;
            btnCapnhat.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {                
                if ((txtTimGiaS.Text == "0" && txtTimGiaE.Text=="0") && rbTimten.Checked)
                {
                    if (!string.IsNullOrEmpty(txtNhap.Text))
                    {
                        var l = f.GetListSanPhamByName(txtNhap.Text);
                        dgDanhSach.DataSource = l;
                    }
                    else
                        MessageBox.Show("Bạn chưa nhập tên tìm kiếm");
                }
                else
                {
                    if((txtTimGiaS.Text != "0" && txtTimGiaE.Text != "0"))
                    {
                        if (double.Parse(txtTimGiaS.Text) >= double.Parse(txtTimGiaE.Text))
                        {
                            MessageBox.Show("Giá không đúng vui lòng nhập lại");
                        }
                        else
                        if (!string.IsNullOrEmpty(txtNhap.Text) && rbTimten.Checked)
                        {
                            var l = f.GetListSanPham(txtNhap.Text, float.Parse(txtTimGiaS.Text), float.Parse(txtTimGiaE.Text));
                            dgDanhSach.DataSource = l;
                        }
                        else
                        {
                            var l = f.GetListSanPhamByGiaBan(float.Parse(txtTimGiaS.Text), float.Parse(txtTimGiaE.Text));
                            dgDanhSach.DataSource = l;
                        }
                    }    
                       
                }
            }
            catch
            {
                MessageBox.Show("Giá không đúng vui lòng nhập lại");
            }            
        }

        private void CheckGiaNhap(object sender, EventArgs e)
        {
            try
            {
                if(double.Parse(txtGiaBan.Text)<0 || double.Parse(txtGiaNhap.Text)<0)
                {
                    MessageBox.Show("Giá nhập vào không đúng");
                }
            }
            catch
            {
                MessageBox.Show("Giá nhập vào không đúng");
                txtGiaBan.Text = "0";
                txtGiaNhap.Text = "0";
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            Lammoi();
            btnLuu.Enabled = false;
            btnCapnhat.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnCapnhat.Enabled = true;
            btnLuu.Enabled = false;
            var sp = f.GetSanPham(current_id);
            if (sp != null)
            {
                txtMaSP.Text = current_id;
                txtGiaBan.Text = sp.DONGIABAN.ToString();
                txtGiaNhap.Text = sp.DONGIANHAP.ToString();
                txtChietKhau.Text = sp.Chietkhau.ToString();
                txtTenSP.Text = sp.Ten;
                txtMauSac.Text = sp.Mausac;
                txtMota.Text = sp.Mota;
                if (sp.Trangthai == 0)
                    cbTrangthai.Checked = true;
                else
                    cbTrangthai.Checked = false;
                cbThue.SelectedIndex = cbThue.FindStringExact(sp.Thue.ToString());
                cbChonLoaiHang.SelectedValue = sp.LOAI;
                cbDvt.SelectedValue = sp.DVT;
            }
            else
                MessageBox.Show("Không tìm thấy hoặc đã bị xóa");
        }

        private void btnTatca_Click(object sender, EventArgs e)
        {
            LoadDanhSach();
        }

        private void Chon(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                if (dong > -1)
                {
                    current_id = dgDanhSach.Rows[dong].Cells["Ma"].Value.ToString();
                    
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
                else
                {
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (f.GetSanPham(current_id) != null)
            {
                var up = f.XoaSanPham(current_id);
                if (up)
                {
                    MessageBox.Show("Thành công");
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    btnCapnhat.Enabled = false;
                    LoadDanhSach();
                    Lammoi();
                }    
                    
                else
                    MessageBox.Show("Lỗi");

            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtTenSP.Text) && !string.IsNullOrEmpty(txtGiaBan.Text) && !string.IsNullOrEmpty(txtGiaNhap.Text) && double.Parse(txtChietKhau.Text) >= 0)
                {
                    var obj = new tbl_HANG();
                    obj.Ma = txtMaSP.Text;
                    obj.Ten = txtTenSP.Text;
                    obj.Mausac = txtMauSac.Text;
                    obj.Mota = txtMota.Text;
                    obj.LOAI = cbChonLoaiHang.SelectedValue.ToString();
                    obj.Thue = double.Parse(cbThue.SelectedItem.ToString());
                    obj.DVT = cbDvt.SelectedValue.ToString();
                    obj.Chietkhau = double.Parse(txtChietKhau.Text);
                    obj.DONGIABAN = double.Parse(txtGiaBan.Text);
                    obj.DONGIANHAP = double.Parse(txtGiaNhap.Text);
                    if (cbTrangthai.Checked)
                        obj.Trangthai = 0;
                    else
                        obj.Trangthai = 1;
                    var up = f.EditSanPham(obj);
                    if (up)
                    {
                        MessageBox.Show("Thành công");
                        LoadDanhSach();
                    }    
                        
                    else
                        MessageBox.Show("Lỗi");
                }
                else
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            catch
            {
                MessageBox.Show("Dữ liệu không đúng định dạng, vui lòng nhập lại");
            }
                   
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtTenSP.Text) && !string.IsNullOrEmpty(txtGiaBan.Text) && !string.IsNullOrEmpty(txtGiaNhap.Text) && double.Parse(txtChietKhau.Text)>=0)
                {
                    var obj = new tbl_HANG();
                    obj.Ma = txtMaSP.Text;
                    obj.Ten = txtTenSP.Text;
                    obj.Mausac = txtMauSac.Text;
                    obj.Mota = txtMota.Text;
                    obj.LOAI = cbChonLoaiHang.SelectedValue.ToString();
                    obj.Thue = double.Parse(cbThue.SelectedItem.ToString());
                    obj.DVT = cbDvt.SelectedValue.ToString();
                    obj.Chietkhau = double.Parse(txtChietKhau.Text);
                    obj.DONGIABAN = double.Parse(txtGiaBan.Text);
                    obj.DONGIANHAP = double.Parse(txtGiaNhap.Text);
                    if (cbTrangthai.Checked)
                        obj.Trangthai = 0;
                    var up = f.AddSanPham(obj);
                    if (up)
                    {
                        MessageBox.Show("Thành công");
                        btnCapnhat.Enabled = true;
                        btnLuu.Enabled = false;
                        LoadDanhSach();
                    }
                    else
                        MessageBox.Show("Lỗi");
                }
                else
                    MessageBox.Show("Bạn chưa nhập đủ thông tin");
            }
            catch
            {
                MessageBox.Show("Bạn nhập không đúng thông tin");
            }
            

            
        }

        private void CheckChietKhau(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(txtChietKhau.Text) < 0 || double.Parse(txtChietKhau.Text) > 100)
                {
                    MessageBox.Show("Giá trị nhập vào không đúng");
                    txtChietKhau.Text = "0";
                }
            }
            catch
            {
                MessageBox.Show("Giá trị nhập vào không đúng");
                txtChietKhau.Text = "0";
            }
        }

        private void LoadTheoLoai(object sender, EventArgs e)
        {
            if (flag != 0)
            {
                var id = cbLocLoaiHang.SelectedValue.ToString();
                var list = f.GetListSanPhamByLoai(id);
                if (list != null)
                {
                    dgDanhSach.DataSource = list;
                }
                else
                    MessageBox.Show("Không tồn tại hoặc đã bị xóa");
            }
        }
    }
}
