using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QLBANHANG
{
    public partial class frm_CTPhieuNhap : DevComponents.DotNetBar.Office2007Form
    {
        public frm_CTPhieuNhap()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        int dong;
        bool themmoi;
        public string IDHD { get; set; }
        public void setnull()
        {
            cbmathe.Text = "";
           
            txtsl.Text = "0";
            txtdg.Text = "0";

        }
        public void Locktext()
        {
            cbmathe.Enabled = false;
            cbmhd.Enabled = false;
            txtsl.Enabled = false;
            txtdg.Enabled = false;


            cmdthem.Enabled = true;
            cmdluu.Enabled = false;
            cmdsua.Enabled = true;
            cmdxoa.Enabled = true;
        }
        public void Un_locktex()
        {
            cbmathe.Enabled = true;
          
            txtsl.Enabled = true;
            txtdg.Enabled = true;


            cmdthem.Enabled = false;
            cmdluu.Enabled = true;
            cmdsua.Enabled = false;
            cmdxoa.Enabled = false;
        }
        public void hienthi(string IDPN)
        {
            string sql = @"SELECT     tbl_PhieuNhapChiTiet.ID_PN, tbl_HANG.Ten, tbl_PhieuNhapChiTiet.SL, tbl_PhieuNhapChiTiet.DonGia
FROM         tbl_PhieuNhapChiTiet INNER JOIN
                      tbl_HANG ON tbl_PhieuNhapChiTiet.HANG = tbl_HANG.Ma where tbl_PhieuNhapChiTiet.ID_PN=N'" + IDPN + "'";
            msds.DataSource = cn.taobang(sql);
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            setnull();
            Un_locktex();
            themmoi = true;
        }
        decimal soluongcu = 0; 
        private void cmdluu_Click(object sender, EventArgs e)
        {

            if (themmoi == true)
            {
                if (string.IsNullOrEmpty(cbmathe.Text) || string.IsNullOrEmpty(cbmhd.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.");
                }
                else
                {
                    string sql = "Select count(*) from tbl_PhieuNhapChiTiet where ID_PN=N'" + cbmhd.Text + "' and HANG=N'" + cbmathe.SelectedValue.ToString() +"'";
                    if (cn.LoadLable(sql) == "0")
                    {

                        try
                        {
                            cn.ExcuteNonQuery("insert into tbl_PhieuNhapChiTiet values(N'" + cbmhd.SelectedValue.ToString() + "',N'" + cbmathe.SelectedValue.ToString() + "',N'" + txtsl.Text + "',N'" + txtdg.Text + "')");
                            hienthi(cbmhd.Text);
                            cn.ExcuteNonQuery(@"UPDATE    tbl_PhieuNhap
SET              TONGTIEN = (SELECT     sum(SL* DonGia)  FROM         tbl_PhieuNhapChiTiet where ID_PN=N'" + cbmhd.Text + "' ) where  IDPN =N'" + cbmhd.Text + "'");

                            cn.ExcuteNonQuery(@"UPDATE    tbl_Hang
SET              Soluong =Soluong + '" + txtsl.Text + "' where  Ma =N'" + cbmathe.SelectedValue.ToString() + "'");
                            MessageBox.Show("Lưu Thành Công");
                        
                        }
                        catch
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
                    cn.ExcuteNonQuery("update tbl_PhieuNhapChiTiet set DonGia=N'" + txtdg.Text + "',SL=N'" + txtsl.Text + "' where ID_PN=N'" + cbmhd.Text + "' and HANG=N'" + cbmathe.SelectedValue.ToString() + "'");
                    cn.ExcuteNonQuery(@"UPDATE    tbl_PhieuNhap
SET              TONGTIEN = (SELECT     sum(SL* DonGia)  FROM         tbl_PhieuNhapChiTiet where ID_PN=N'" + cbmhd.Text + "' ) where  IDPN =N'" + cbmhd.Text + "'");
                    cn.ExcuteNonQuery(@"UPDATE    tbl_HANG
SET              Soluong =Soluong + '" + (txtsl.Value - soluongcu) + "' where  Ma =N'" + cbmathe.SelectedValue.ToString() + "'");
    
                    hienthi(cbmhd.Text);
                    MessageBox.Show("Sửa Thành Công");
               
                }
                catch
                {
                    MessageBox.Show("Sửa Thất Bại");
                }
            }
            Locktext();
            setnull();
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            Un_locktex();
            cbmathe.Enabled = false;
            cbmhd.Enabled = false;
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                cn.ExcuteNonQuery("delete tbl_PhieuNhapChiTiet  where ID_PN=N'" + cbmhd.Text + "' and HANG=N'" + cbmathe.SelectedValue.ToString() + "'");

                hienthi(cbmhd.Text);
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
                dong = e.RowIndex;
                cbmhd.Text = msds.Rows[dong].Cells["ID_PN"].Value.ToString();
                cbmathe.Text = msds.Rows[dong].Cells["Ten"].Value.ToString();
                txtsl.Text = msds.Rows[dong].Cells["SL"].Value.ToString();
                txtdg.Text = msds.Rows[dong].Cells["DonGia"].Value.ToString();
                if (!string.IsNullOrEmpty(msds.Rows[dong].Cells["SL"].Value.ToString()))
                {
                    soluongcu = decimal.Parse(msds.Rows[dong].Cells["SL"].Value.ToString());
                }
                else
                { soluongcu = 0; }
            }
            catch
            { }
        }

        private void frm_CTHDBANHANG_Load(object sender, EventArgs e)
        {
            cn.LoadCombobox(cbmhd, "Select * from tbl_PhieuNhap", "IDPN", "IDPN");
            cn.LoadCombobox(cbmathe, "Select * from tbl_Hang", "Ten", "Ma");
            cbmhd.Text = IDHD;
            hienthi(cbmhd.Text);
            Locktext();
         
        }

        private void cbmathe_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frm_INHDNHAP frm = new frm_INHDNHAP();
            frm.MaHD = cbmhd.Text;
            frm.ShowDialog();
        }
    }
}