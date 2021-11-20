using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using System.IO;
namespace QLBANHANG
{
    public partial class frm_PhucHoi : DevComponents.DotNetBar.Office2007Form
    {
        public frm_PhucHoi()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection();
        ConnectDB con = new ConnectDB();
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcsdl.Text))
            {
                SaveFileDialog save = new SaveFileDialog();
                //' tao hoi dialog
                save.FileName = txtcsdl.Text;
                save.Filter = "File(*.bak)|*.bak";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    txtduongdan.Text = save.FileName;
                }
            }
        }

        private void btnPhuchoi_Click(object sender, EventArgs e)
        {
            string _vTruyVan = "";

            try
            {
                cn = con.getcon();
                cn.Open();
                _vTruyVan = "ALTER DATABASE QLSV SET SINGLE_USER WITH ROLLBACK IMMEDIATE ";
                _vTruyVan += " USE master RESTORE DATABASE " + txtcsdl.Text + " FROM DISK = N'" + txtduongdan.Text + "'";
                _vTruyVan += " WITH  FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
                SqlCommand cmd = new SqlCommand(_vTruyVan, cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Phục Hổi Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}