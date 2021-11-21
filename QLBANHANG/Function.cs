using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using QLBANHANG.Model;

namespace QLBANHANG
{
    public class Function
    {
        Context2 db = null;
        public Function()
        {
            db = new Context2();
        }
        public string Random(int length)
        {
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }
        public string RandomNumber()
        {
            Random rnd = new Random();
            int month = rnd.Next(1, 13);  
            int dice = rnd.Next(1, 7);  
            int card = rnd.Next(52);
            return month.ToString() + dice.ToString() + card.ToString();
        }
        public List<tbl_ChiTietHoaDon> GetChiTietHoaDon(string id)
        {
            return db.tbl_ChiTietHoaDon.Where(x=>x.Id_hd==id).ToList();
        }
        public tbl_BaoGia GetBaoGia(string id)
        {
            return db.tbl_BaoGia.FirstOrDefault(x => x.mabaogia == id);
        }
        public List<tbl_HoaDon> GetDanhSachHoaDon()
        {
            return db.tbl_HoaDon.ToList();
        }
        public tbl_HoaDon TimHoaDonByMaPhieuBan(string id)
        {
            return GetDanhSachHoaDon().FirstOrDefault(x=>x.chungtu==id);
        }
        public List<tbl_BaoGia> GetDanhSachBaoGia(DateTime start=new DateTime(), DateTime end=new DateTime())
        {
            if(start!=new DateTime() && end != new DateTime())
            {
                return db.tbl_BaoGia.Where(x => x.ngay >= start && x.hieuluc <= end).ToList();
            }
            return db.tbl_BaoGia.ToList();
        }
        public List<tbl_ChiTietBaoGia> GetListChiTietBaoGia(string id)
        {
            return db.tbl_ChiTietBaoGia.Where(x => x.mabaogia == id).ToList();
        }
        public double TinhTienBaoGia(string id)
        {
            var bg = GetListChiTietBaoGia(id);
            double t = 0;
            if(bg!=null && bg.Count>0)
            {
                    foreach (var item in bg)
                    {
                        t = (double)(t + (item.soluong * item.dongia));
                    }               
            }
            return t;
        }
        public bool AddChiTietHoaDon(string id_hd, tbl_ChiTietHoaDon cthd)
        {
            if (GetHoaDon(id_hd) != null)
            {
                var o = db.tbl_ChiTietHoaDon.FirstOrDefault(x => x.masp == cthd.masp && x.Id_hd ==id_hd);
                if (o != null)
                {
                    o.soluong = cthd.soluong + o.soluong;
                    TongTienHoaDon(id_hd);
                    db.SaveChanges();                  
                }
                else
                {
                    db.tbl_ChiTietHoaDon.Add(cthd);
                    TongTienHoaDon(id_hd);
                    db.SaveChanges();
                }
                return true;
            }
            return false;
        }
        public bool XoaChiTietHoaDon(string id_hd, string masp)
        {
            if (GetHoaDon(id_hd) != null)
            {
                var o = db.tbl_ChiTietHoaDon.FirstOrDefault(x => x.masp == masp);
                if (o != null)
                {
                    db.tbl_ChiTietHoaDon.Remove(o);
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        public bool AddBaoGia(tbl_BaoGia bg)
        {
            if (GetBaoGia(bg.mabaogia) == null)
            {
                db.tbl_BaoGia.Add(bg);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool AddChiTietBaoGia(tbl_ChiTietBaoGia ct)
        {
            var bg = GetBaoGia(ct.mabaogia);
            if(bg!=null)
            {
                var o = db.tbl_ChiTietBaoGia.FirstOrDefault(x=>x.mabaogia==ct.mabaogia && x.masp==ct.masp);
                if(o!=null)
                {
                    o.soluong = o.soluong + ct.soluong;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    db.tbl_ChiTietBaoGia.Add(ct);
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        public bool EditHoaDon(tbl_HoaDon hd)
        {
            try
            {
                var o = db.tbl_HoaDon.SingleOrDefault(x => x.Id == hd.Id);
                if (o != null)
                {
                    o.chungtu = hd.chungtu;
                    o.makh = hd.makh;
                    o.manv = hd.manv;
                    o.Ngay = hd.Ngay;
                    o.phuongthuc = hd.phuongthuc;
                    o.stk = hd.stk;
                    o.danhan = hd.danhan;
                    o.tongtien = hd.tongtien;
                    o.trangthai = hd.trangthai;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool EditChiTietBaoGia(tbl_ChiTietBaoGia ct)
        {
                var o = db.tbl_ChiTietBaoGia.FirstOrDefault(x => x.mabaogia == ct.mabaogia && x.masp == ct.masp);
                if (o != null)
                {
                    o.soluong = ct.soluong;
                    db.SaveChanges();
                    return true;
                }         
            return false;
        }
        public bool EditBaoGia(tbl_BaoGia bg)
        {
            var o = GetBaoGia(bg.mabaogia);
            if (o != null)
            {
                o.ghichu = bg.ghichu;
                o.hieuluc = bg.hieuluc;
                o.makh = bg.makh;
                o.manv = bg.manv;
                o.ngay = bg.ngay;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool XoaBaoGia(string id)
        {
            try
            {
                var o = GetBaoGia(id);
                if (o != null)
                {
                    db.tbl_BaoGia.Remove(o);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch(Exception x)
            {
                throw x;
            }
        }
        public bool XoaChiTietBaoGia(string id, string id_sp)
        {
            try
            {
                var o = db.tbl_ChiTietBaoGia.FirstOrDefault(x=>x.mabaogia==id&&x.masp==id_sp);
                if (o != null)
                {
                    db.tbl_ChiTietBaoGia.Remove(o);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception x)
            {
                throw x;
            }
        }
        public bool ThanhToanHoaDon(string id)
        {
            try
            {
                var hd = GetHoaDon(id);
                if ( hd != null)
                {
                    tbl_PhieuBanHang p = GetPhieuBanHang(hd.chungtu);
                    if(p!=null)
                    {
                        p.TrangThai = 1;
                    }    
                    hd.trangthai = 1;
                    db.SaveChanges();
                    return true;
                }
                return false;
                

            }catch(Exception x)
            {
                throw x;
            }

        }
        public bool XoaHoaDon(string id)
        {
            try
            {
                var o = db.tbl_HoaDon.FirstOrDefault(x=>x.Id==id);
                if (o != null)
                {
                    db.tbl_HoaDon.Remove(o);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception x)
            {
                throw x;
            }
        }
        private bool CheckSoLuong(string IDHH)
        {
            var o = db.tbl_HANG.SingleOrDefault(x => x.Ma == IDHH);
            if (o.Soluong > 0)
                return true;
            return false;
        }
        public bool UpdatateTrangThaiPhieuBan(string id,bool stt)
        {
            var o = db.tbl_PhieuBanHang.SingleOrDefault(x => x.IDPHIEU == id);
            if (o != null)
            {
                if (stt)
                {
                    o.TrangThai = 1;
                }
                else
                    o.TrangThai = 0;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool UpdatateTrangThaiPhieuMua(string id, bool stt)
        {
            var o = db.tbl_PhieuNhap.SingleOrDefault(x => x.IDPN == id);
            if (o != null)
            {
                if (stt)
                {
                    o.TrangThai = 1;
                }
                else
                    o.TrangThai = 0;

                db.SaveChanges();
                return true;
            }
            return false;
        }
        public tbl_PhieuBanHang GetPhieuBanHang(string id)
        {
            return db.tbl_PhieuBanHang.SingleOrDefault(x => x.IDPHIEU == id);
        }
        public tbl_PhieuNhap GetPhieuNhap(string id)
        {
            return db.tbl_PhieuNhap.SingleOrDefault(x => x.IDPN == id);
        }
        public tbl_PhieuBanChiTiet GetPhieuBanChiTiet(string id, string sp)
        {
            return db.tbl_PhieuBanChiTiet.SingleOrDefault(x => x.ID_PB == id && x.HANG == sp);
        }
        public tbl_PhieuNhapChiTiet GetPhieuNhapChiTiet(string id, string sp)
        {
            return db.tbl_PhieuNhapChiTiet.SingleOrDefault(x => x.ID_PN == id && x.HANG==sp);
        }
        public IEnumerable<tbl_PhieuBanChiTiet> ListCTPB(string id)
        {
            return db.tbl_PhieuBanChiTiet.Where(x => x.ID_PB == id).ToList();
        }
        public IEnumerable<tbl_PhieuNhapChiTiet> ListCTPN(string id)
        {
            return db.tbl_PhieuNhapChiTiet.Where(x => x.ID_PN == id).ToList();
        }
        public tbl_KhachHang GetKhachHang(string id)
        {
            return db.tbl_KhachHang.SingleOrDefault(x => x.makh==id);
        }
        public tbl_HANG GetSanPham(string id)
        {
            return db.tbl_HANG.SingleOrDefault(x => x.Ma==id);
        }
        public tbl_HoaDon GetHoaDon(string id)
        {
            return db.tbl_HoaDon.SingleOrDefault(x => x.Id == id);
        }
        public tbl_HoaDon GetHoaDonByPhieuBanHang(string id)
        {
            return db.tbl_HoaDon.FirstOrDefault(x => x.chungtu ==id);
        }
        public tbl_NhanVien GetNhanVien(string id)
        {
            return db.tbl_NhanVien.SingleOrDefault(x => x.manv == id);
        }
        public List<tbl_NhanVien> GetListNhanVien()
        {
            return db.tbl_NhanVien.ToList();
        }
        public void UpdateKho(string id, int n, string mode){
            try
            {
                var o = db.tbl_HANG.SingleOrDefault(x => x.Ma == id);
                if (o != null)
                {
                    if (mode == "in")
                    {
                        o.Soluong = o.Soluong + n;
                    }
                    if (mode == "out")
                    {
                        o.Soluong = o.Soluong - n;
                    }
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
        public void UpdateKho(string id, int cu, int moi)
        {
            try
            {
                var o = db.tbl_HANG.SingleOrDefault(x => x.Ma == id);
                if (o != null)
                {
                    o.Soluong = o.Soluong + (cu - moi);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void TongTienPhieuBan(string id)
        {
            var o = GetPhieuBanHang(id);
            if (o != null)
            {
                o.TongTien = TotalCTPB(id);
                db.SaveChanges();
            }
        }
        public void TongTienPhieuNhap(string id)
        {
            var o = GetPhieuNhap(id);
            if (o != null)
            {
                o.TONGTIEN = TotalCTPN(id);
                db.SaveChanges();
            }
        }
        public void TongTienHoaDon(string id)
        {
            var o = GetHoaDon(id);
            if (o != null)
            {
                o.tongtien = TotalCTHD(id);
            }
        }
        public bool XoaPhieuNhap(string id)
        {
            var o = GetPhieuNhap(id);
            if (o != null)
            {
                db.tbl_PhieuNhap.Remove(o);
                var list = db.tbl_PhieuNhapChiTiet.ToList();
                list.RemoveAll(x => x.ID_PN == id);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool XoaPhieuBan(string id)
        {
            var o = GetPhieuBanHang(id);
            if (o != null)
            {
                db.tbl_PhieuBanHang.Remove(o);
                var list = db.tbl_PhieuBanChiTiet.ToList();
                list.RemoveAll(x => x.ID_PB == id);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool AddPhieuBan(tbl_PhieuBanHang p)
        {
            if (db.tbl_PhieuBanHang.FirstOrDefault(x=>x.IDPHIEU==p.IDPHIEU)==null)
            {
                db.tbl_PhieuBanHang.Add(p);
                db.SaveChanges();
                return true;
            }
            return false;

        }
        public bool EditPhieuBan(tbl_PhieuBanHang p)
        {
            var o = db.tbl_PhieuBanHang.FirstOrDefault(x => x.IDPHIEU == p.IDPHIEU);
            if (o != null)
            {
                o.TrangThai = p.TrangThai;
                o.NGAYLAP = p.NGAYLAP;
                o.NGAYGIAO = p.NGAYGIAO;
                o.MANV = p.MANV;
                o.MAKH = p.MAKH;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public double? TotalCTPB(string id)
        {
            double? t = 0;
            foreach(var item in ListCTPB(id))
            {
                t = t + (item.DonGia * item.SL);
            }
            return t;
        }
        public double? TotalCTHD(string id)
        {
            double? t = 0;
            foreach (var item in GetChiTietHoaDon(id))
            {
                var dongia = GetSanPham(item.masp).DONGIA;
                t = t + (dongia * item.soluong);
            }
            return t;
        }
        public double? TotalCTPN(string id)
        {
            double? t = 0;
            foreach (var item in ListCTPN(id))
            {
                t = t + (item.DonGia * item.SL);
            }
            return t;
        }
        public bool DeleteCTPN(string id, string sp)
        {
            if (GetPhieuNhapChiTiet(id, sp) != null)
            {
                try
                {
                    db.tbl_PhieuNhapChiTiet.Remove(GetPhieuNhapChiTiet(id, sp));
                    GetPhieuNhap(id).TONGTIEN = GetPhieuNhap(id).TONGTIEN - (GetPhieuNhapChiTiet(id, sp).SL * GetPhieuNhapChiTiet(id, sp).DonGia);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception x)
                {
                    throw x;
                }
            }
            else
                return false;
        }
        public bool DeleteCTPB(string id, string sp)
        {
            if (GetPhieuBanChiTiet(id, sp) != null)
            {
                try
                {
                    db.tbl_PhieuBanChiTiet.Remove(GetPhieuBanChiTiet(id, sp));
                    GetPhieuBanHang(id).TongTien = GetPhieuBanHang(id).TongTien - (GetPhieuBanChiTiet(id,sp).SL * GetPhieuBanChiTiet(id, sp).DonGia) ;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception x)
                {
                    throw x;
                }
            }
            else
                return false;
        }
        public bool EditCTPB(string id, string sp, int sl)
        {
            try
            {
                var o = db.tbl_PhieuBanChiTiet.SingleOrDefault(x => x.ID_PB == id && x.HANG == sp);
                if (o != null)
                {
                    o.SL = sl;
                    TongTienPhieuBan(id);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool EditCTPN(string id, string sp, int sl)
        {
            try
            {
                var o = db.tbl_PhieuNhapChiTiet.SingleOrDefault(x => x.ID_PN == id && x.HANG == sp);
                if (o != null)
                {
                    o.SL = sl;
                    TongTienPhieuNhap(id);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddCTPB(tbl_PhieuBanChiTiet phieu)
        {
            try
            {
                var o = db.tbl_PhieuBanChiTiet.SingleOrDefault(x => x.ID_PB == phieu.ID_PB && x.HANG == phieu.HANG);
                if ( o != null)
                {
                    o.SL = o.SL +  phieu.SL;
                    TongTienPhieuBan(phieu.ID_PB);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    db.tbl_PhieuBanChiTiet.Add(phieu);
                    db.SaveChanges();
                    TongTienPhieuBan(phieu.ID_PB);
                    db.SaveChanges();
                    return true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool AddCTPN(tbl_PhieuNhapChiTiet phieu)
        {
            try
            {
                var o = db.tbl_PhieuNhapChiTiet.SingleOrDefault(x => x.ID_PN == phieu.ID_PN && x.HANG == phieu.HANG);
                if (o != null)
                {
                    o.SL = o.SL + phieu.SL;
                    TongTienPhieuNhap(phieu.ID_PN);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    db.tbl_PhieuNhapChiTiet.Add(phieu);
                    db.SaveChanges();
                    TongTienPhieuNhap(phieu.ID_PN);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateTongTienHoaDonByMaPhieuBan(string id_pb)
        {
            var p = TimHoaDonByMaPhieuBan(id_pb);
            if (p != null )
            {
                p.tongtien = GetPhieuBanHang(id_pb).TongTien;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool UpdateTienNhanHoaDon(string id_hd,float tien)
        {
            var o = GetHoaDon(id_hd);
            if (o != null)
            {
                o.danhan = tien;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool AddHoaDon(tbl_HoaDon hd)
        {
            try
            {
                if (db.tbl_HoaDon.SingleOrDefault(x => x.Id == hd.Id)==null)
                {
                    hd.trangthai = 0;
                    db.tbl_HoaDon.Add(hd);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool DeletePhieuNhap(string id)
        {
            try
            {
                var o = db.tbl_PhieuNhap.SingleOrDefault(x => x.IDPN == id);
                if (o != null)
                {
                    db.tbl_PhieuNhap.Remove(o);
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool EditPhieuNhap(tbl_PhieuNhap phieu)
        {
            try
            {
                var o = db.tbl_PhieuNhap.SingleOrDefault(x => x.IDPN == phieu.IDPN);
                if (o != null)
                {
                    o.NGAY = phieu.NGAY;
                    o.NguoiGiao = phieu.NguoiGiao;
                    o.Sdt = phieu.Sdt;
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddPhieuNhap(tbl_PhieuNhap phieu)
        {
            try
            {
                var o = db.tbl_PhieuNhap.SingleOrDefault(x => x.IDPN == phieu.IDPN);
                if (o == null)
                {
                    db.tbl_PhieuNhap.Add(phieu);
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
