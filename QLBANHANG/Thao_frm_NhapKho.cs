﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBANHANG
{
    public partial class Thao_frm_NhapKho : Form
    {
        ConnectDB cn = new ConnectDB();
        public Thao_frm_NhapKho()
        {
            InitializeComponent();
            LoadDanhSach();
        }
        public void LoadDanhSach()
        {
            string sql = @"select hd.Id,hd.Ngay, n.tenncc, nv.tennv,hd.nguoigiao,hd.sdt, hd.chungtu, hd.tongtien,
            (case hd.trangthai
            when 0 then N'Đang xử lý'
            when 1 then N'Đã thanh toán'
            end) as 'trangthai'
            from tbl_HoaDonNhap hd, tbl_NhaCungCap n, tbl_NhanVien nv
            where hd.mancc = n.mancc and nv.manv=hd.manv";
            dgDanhsach.DataSource = cn.taobang(sql);
        }
    }
}
