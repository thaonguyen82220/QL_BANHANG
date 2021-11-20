using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using System.Configuration;


namespace QLBANHANG
{
    class ConnectDB
    {
        SqlConnection con; //Doi tuong ket noi CSDL 
        SqlCommand sqlcom; 
        SqlDataReader sqldr;
        private string constr = ConfigurationManager.ConnectionStrings["Context"].ConnectionString;
        public SqlConnection getcon()
        {
            return new SqlConnection(constr);
            //return new SqlConnection(@"Data Source=.;Initial Catalog=_banhang;Persist Security Info=True;User ID=sa; Password =060313192000");

        }
        public int returnscalarnumber(string sql)
        {
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(sql, con);
            int n = (int)sqlcom.ExecuteScalar();
            con.Close();
            return n;
        }
        public DataTable taobang(string sql)
        {
            con = getcon();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }

        public void ExcuteNonQuery(string sql)
        {
            con = getcon();
            sqlcom = new SqlCommand(sql, con);
            con.Open();
            sqlcom.ExecuteNonQuery();
            con.Close();
            con.Dispose();
        }

        public string LoadLable(string sql)
        {
            string ketqua = "";
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(sql, con);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                ketqua = sqldr[0].ToString();
            }
            con.Close();
            return ketqua;
        }

        public void LoadCombobox(ComboBox cb, string SQL, string DisplayMember, string ValueMember)
        {
            con = getcon();
            con.Open();
            cb.DataSource = taobang(SQL);
            cb.DisplayMember = DisplayMember;
            cb.ValueMember = ValueMember;
            con.Close();
        }
    }
}
