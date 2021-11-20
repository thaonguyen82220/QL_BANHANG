using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLBANHANG.Model;

namespace QLBANHANG
{
    public partial class frm_PhieuBanHang : Form
    {
        public frm_PhieuBanHang()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        int dong;
        bool themmoi;
        int current=0;

        public void setnull()
        {
            Function f = new Function();
            txtma.Text = "DHB"+f.RandomNumber() + f.Random(2);
            txtma.Enabled = false;
            cbkh.Text = "";
            txtngay.Text = DateTime.Now.ToShortDateString();
            txttongtien.Text = "0";
            cbnv.Text = "";
        }
        public void Locktext()
        {
            cbkh.Enabled = false;
            cbnv.Enabled = false;
            txtma.Enabled = false;
            txtngay.Enabled = false;
            txttongtien.Enabled = false;
            cmdthem.Enabled = true;
            cmdluu.Enabled = false;
            cmdsua.Enabled = true;
            cmdxoa.Enabled = true;
        }
        public void Un_locktex()
        {
            cbnv.Enabled = true;
            cbkh.Enabled = true;
            txtma.Enabled = true;
            txtngay.Enabled = true;
            cmdthem.Enabled = false;
            cmdluu.Enabled = true;
            cmdsua.Enabled = false;
            cmdxoa.Enabled = false;
        }
        public void hienthi()
        {
            string sql = @"SELECT     tbl_PhieuBanHang.IDPHIEU, tbl_KhachHang.tenkh, tbl_PhieuBanHang.NGAYLAP, tbl_NhanVien.tennv, tbl_PhieuBanHang.TongTien,
                        ( case tbl_PhieuBanHang.TrangThai 
	                        when 0 then N'Đang xử lý' 
	                        when 1 then N'Hoàn thành' 
	                        end) as 'TrangThai'
                        FROM         tbl_PhieuBanHang INNER JOIN
                      tbl_NhanVien ON tbl_PhieuBanHang.MANV = tbl_NhanVien.manv INNER JOIN
                      tbl_KhachHang ON tbl_PhieuBanHang.MAKH = tbl_KhachHang.makh";
            msds.DataSource = cn.taobang(sql);

        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            setnull();
            Un_locktex();
            themmoi = true;
        }

        private void cmdluu_Click(object sender, EventArgs e)
        {

            if (themmoi == true)
            {
                if (string.IsNullOrEmpty(txtma.Text) || string.IsNullOrEmpty(cbnv.Text) || string.IsNullOrEmpty(cbkh.Text) || string.IsNullOrEmpty(txtngay.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.");
                }
                else
                {
                    string sql = "Select count(*) from tbl_PhieuBanHang where IDPHIEU=N'" + txtma.Text + "'";
                    if (cn.LoadLable(sql) == "0")
                    {

                        try
                        {                          
                            cn.ExcuteNonQuery("insert into tbl_PhieuBanHang values(N'" + txtma.Text + "',N'" + cbkh.SelectedValue.ToString() + "',N'" + txtngay.Text + "',N'" + cbnv.SelectedValue.ToString() + "','0','"+cbTrangThai.SelectedItem.ToString()+"')");

                            hienthi();
                            MessageBox.Show("Lưu Thành Công");
                            buttonX1.Enabled = true;
                        }
                        catch(Exception ex)
                        {            
                            MessageBox.Show("Lưu Thất Bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã Này Đã Có");

                    }
                }
            }
            else
            {
                try
                {
                    cn.ExcuteNonQuery("update tbl_PhieuBanHang " +
                        "set MANV=N'" + cbnv.SelectedValue.ToString() 
                        + "',MAKH=N'" + cbkh.SelectedValue.ToString() + "',NGAYLAP=N'" + txtngay.Text + "', TrangThai="+cbTrangThai.SelectedItem.ToString()+" where IDPHIEU=N'" + txtma.Text + "'");

                    hienthi();
                    MessageBox.Show("Sửa Thành Công");
                    buttonX1.Enabled = true;
                }
                catch(Exception ex)
                {
                    throw (ex);
                    //MessageBox.Show("Sửa Thất Bại");
                }
            }
            Locktext();
            setnull();
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            Un_locktex();
            txtma.Enabled = false;
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ExcuteNonQuery("delete tbl_PhieuBanHang where IDPHIEU=N'" + txtma.Text + "'");

                hienthi();
                MessageBox.Show("Xóa Thành Công");
                setnull();
            }
            catch
            {
                MessageBox.Show("Xóa Thất Bại");
            }
        }
        private void msds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Locktext();
            try
            {
                current = dong = e.RowIndex;
                txtma.Text = msds.Rows[dong].Cells["IDPHIEU"].Value.ToString();
                cbkh.Text = msds.Rows[dong].Cells["tenkh"].Value.ToString();
                txtngay.Text = msds.Rows[dong].Cells["NGAYLAP"].Value.ToString();
                cbnv.Text = msds.Rows[dong].Cells["tennv"].Value.ToString();
                //txttongtien.Text = msds.Rows[dong].Cells["TongTien"].Value.ToString();
                if (msds.Rows[dong].Cells["TrangThai"].Value.ToString() == "Đang xử lý")
                {
                    cbTrangThai.SelectedIndex = 0;
                }
                else
                    cbTrangThai.SelectedIndex = 1;
            }
            catch(Exception exx)
            {
                throw exx;
            }
        }

        private void frm_PhieuNhap_Load(object sender, EventArgs e)
        {
            hienthi();
            Locktext();
            cn.LoadCombobox(cbkh, "Select * from tbl_KhachHang", "tenkh", "makh");
            cn.LoadCombobox(cbnv, "Select * from tbl_NhanVien", "tennv", "manv");
            buttonX1.Enabled = true;
            txtngay.Value = DateTime.Now;
            cbTrangThai.SelectedIndex = 0;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtma.Text))
            { MessageBox.Show("Bạn phải chọn một hóa đơn."); }
            else
            {
                var phieu = new Function().GetPhieuBanHang(txtma.Text);
                frm_DonHang frm = new frm_DonHang(phieu);
                this.Hide();
                frm.ShowDialog();
                this.Show();
                hienthi();
                buttonX1.Enabled = true;
            }
        }

        private void msds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtma.Text))
            { MessageBox.Show("Bạn phải chọn một hóa đơn."); }
            else
            {
                try
                {
                    dong = current;
                    if (msds.Rows[dong].Cells["TrangThai"].Value.ToString() != "Đang xử lý")
                    {
                        MessageBox.Show("Đơn hàng đã được xử lý");
                    }
                    else
                    {
                        Function f = new Function();

                        frm_HoaDon frm = new frm_HoaDon(f.GetPhieuBanHang(txtma.Text));
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                    }    
                }
                catch (Exception exx)
                {
                    throw exx;
                }
            }
            
        }

        private void btnSearchMaChungTu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thao_DSBaoGia frm = new Thao_DSBaoGia();
            frm.ShowDialog();
            this.Show();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_KhachHang frm = new frm_KhachHang();
            frm.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}