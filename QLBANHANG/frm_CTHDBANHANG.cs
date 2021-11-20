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
    public partial class frm_CTHDBANHANG : DevComponents.DotNetBar.Office2007Form
    {
        public frm_CTHDBANHANG()
        {
            InitializeComponent();
        }
        public string IDHD { get; set; }
        ConnectDB cn = new ConnectDB();
        int dong;
        bool themmoi;

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
            //txtdg.Enabled = true;


            cmdthem.Enabled = false;
            cmdluu.Enabled = true;
            cmdsua.Enabled = false;
            cmdxoa.Enabled = false;
        }
        public void hienthi(string SOHD)
        {
            string sql = @"SELECT  Ma,tbl_PhieuBanChiTiet.ID_PB, tbl_Hang.Ten, tbl_PhieuBanChiTiet.SL, tbl_PhieuBanChiTiet.DonGia, tbl_Hang.DVT, (SL*tbl_Hang.DONGIA) as 'ThanhTien'
            FROM tbl_PhieuBanChiTiet 
            INNER JOIN tbl_Hang ON tbl_PhieuBanChiTiet.HANG = tbl_Hang.Ma 
            where  tbl_PhieuBanChiTiet.ID_PB=N'" + SOHD + "'";
            msds.DataSource = cn.taobang(sql);
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            setnull();
            Un_locktex();
            themmoi = true;
        }
        decimal soluongcu = 0;
        private bool CheckSoLuong(string IDHH, decimal SoluongCu, decimal SoLuongMoi)
        {
            decimal tt = SoLuongMoi - SoluongCu;
            bool values = true;
            string sql = "Select count(*) from tbl_Hang where Ma=N'" + IDHH + "' and Soluong>='" + tt + "'";
            if (cn.LoadLable(sql) == "0")
            { values = false; }
            else { values = true; }
            return values;
        }
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
                    string sql = "Select count(*) from tbl_PhieuBanChiTiet where ID_PB=N'" + cbmhd.Text + "' and HANG=N'" + cbmathe.Text + "'";
                    if (cn.LoadLable(sql) == "0")
                    {

                        try
                        {
                            if (CheckSoLuong(cbmathe.SelectedValue.ToString(), 0, txtsl.Value))
                            {
                                cn.ExcuteNonQuery("insert into tbl_PhieuBanChiTiet values(N'" + cbmhd.SelectedValue.ToString() + "',N'" + cbmathe.SelectedValue.ToString() + "',N'" + txtsl.Text + "',N'" + txtdg.Text + "')");
                                hienthi(cbmhd.Text);

                                cn.ExcuteNonQuery(@"UPDATE    tbl_PhieuBanHang
SET              TongTien = (SELECT     sum(SL* DonGia)  FROM         tbl_PhieuBanChiTiet where ID_PB=N'" + cbmhd.Text + "' ) where  IDPHIEU =N'" + cbmhd.Text + "'");

                                cn.ExcuteNonQuery(@"UPDATE    tbl_Hang
SET              Soluong =Soluong - '" + txtsl.Text + "' where  Ma =N'" + cbmathe.SelectedValue.ToString() + "'");
                                MessageBox.Show("Lưu Thành Công");
                            }
                            else
                            { MessageBox.Show("Số lượng không đủ cung cấp"); }

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
                    if (CheckSoLuong(cbmathe.SelectedValue.ToString(), soluongcu, txtsl.Value))
                    {
                        cn.ExcuteNonQuery("update tbl_PhieuBanChiTiet set DonGia=N'" + txtdg.Text + "',SL=N'" + txtsl.Text + "' where ID_PB=N'" + cbmhd.Text + "' and HANG=N'" + cbmathe.Text + "'");
                        cn.ExcuteNonQuery(@"UPDATE    tbl_PhieuBanHang
SET              TongTien = (SELECT     sum(SL* DonGia)  FROM         tbl_PhieuBanChiTiet where ID_PB=N'" + cbmhd.Text + "' ) where  IDPHIEU =N'" + cbmhd.Text + "'");
                        cn.ExcuteNonQuery(@"UPDATE    tbl_HANG
SET              Soluong =Soluong - '" + (txtsl.Value - soluongcu) + "' where  Ma =N'" + cbmathe.SelectedValue.ToString() + "'");

                        hienthi(cbmhd.Text);
                        MessageBox.Show("Sửa Thành Công");
                    }
                    else
                    { MessageBox.Show("Số lượng không đủ cung cấp"); }
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
                cn.ExcuteNonQuery("delete tbl_PhieuBanChiTiet  where ID_PB=N'" + cbmhd.Text + "' and HANG=N'" + cbmathe.Text + "'");

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
                cbmhd.Text = msds.Rows[dong].Cells["ID_PB"].Value.ToString();
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
            cn.LoadCombobox(cbmhd, "Select * from tbl_PhieuBanHang", "IDPHIEU", "IDPHIEU");
            cn.LoadCombobox(cbmathe, "Select * from tbl_HANG", "Ten", "Ma");
            cbmhd.Text = IDHD;
            hienthi(cbmhd.Text);
            Locktext();

        }

        private void cbmathe_SelectedValueChanged(object sender, EventArgs e)
        {
            var value = cbmathe.SelectedValue.ToString();
            if (!string.IsNullOrEmpty(value))
            {
                txtdg.Text = cn.LoadLable($"select DONGIA from tbl_Hang where Ma = '{value}'");

            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                frm_INHDBANHANG frm = new frm_INHDBANHANG();
                frm.MaHD = cbmhd.Text;
                frm.ShowDialog();
            }
            catch { }
        }

        private void msds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}