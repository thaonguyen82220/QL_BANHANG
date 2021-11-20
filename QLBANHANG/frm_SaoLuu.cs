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
    public partial class frm_SaoLuu : DevComponents.DotNetBar.Office2007Form
    {
        public frm_SaoLuu()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection();
        ConnectDB con = new ConnectDB();
        private void btnSaoluu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtduongdan.Text))
            {
                MessageBox.Show("Vui Lòng Chọn Đường Dẫn Để Lưu");
            }
            else
            {
                if (File.Exists(txtduongdan.Text))
                {
                    File.Delete(txtduongdan.Text);
                }

                try
                {
                    cn = con.getcon();
                    cn.Open();
                    string saoluu = "Backup Database " + txtcsdl.Text + " to disk = '" + txtduongdan.Text + "' ";
                    SqlCommand cmd = new SqlCommand(saoluu, cn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Sao Lưu Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cn.Close();

                }
                catch (Exception generatedExceptionName)
                {
                    MessageBox.Show("Không thể  Sao Lưu Dữ Liệu!", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcsdl.Text))
            {
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = txtcsdl.Text;
                save.Filter = "File(*.bak)|*.bak";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    txtduongdan.Text = save.FileName;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}