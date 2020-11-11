using System;
using System.Collections.Generic;
using System.Text;
using QuanLyDienThoai1.Model;
using QuanLyDienThoai1.DataAccess;
//tầng thao tác vs cơ sở dữ liệu
namespace QuanLyDienThoai1.BusinessLogic
{
    public class HoaDonBanBL
    {
        SanPham sp = new SanPham();
        HoaDonBanDA sp_da = new HoaDonBanDA();
        List<SanPham> ds_san_pham = new List<SanPham>();
        //lấy danh sách
        public List<HoaDonBan> DanhSachHoaDon()
        {
            return sp_da.LayDanhSachSanPham();
        }

        public void Them(HoaDonBan sp)
        {
            sp_da.Them(sp);
        }

        public void Sua(HoaDonBan sp_update)
        {
            List<HoaDonBan> ds_san_pham_cap_nhat = new List<HoaDonBan>();
            List<HoaDonBan> ds_san_pham_hien_tai = this.DanhSachHoaDon();

            foreach (var sp_ht in ds_san_pham_hien_tai)
            {
                if (sp_update.MaHoaDon == sp_ht.MaHoaDon)
                {
                    ds_san_pham_cap_nhat.Add(sp_update);
                }
                else
                {
                    ds_san_pham_cap_nhat.Add(sp_ht);
                }
            }

            sp_da.CapNhat(ds_san_pham_cap_nhat);
        }

        public void Xoa(string ma_hoa_don)
        {
            List<HoaDonBan> ds_hoa_don = this.DanhSachHoaDon();

            HoaDonBan hoa_don = ds_hoa_don.Find(sp => sp.MaHoaDon == ma_hoa_don);
            if (hoa_don != null)
            {
                ds_hoa_don.Remove(hoa_don);
            }
            sp_da.CapNhat(ds_hoa_don);
        }

        public HoaDonBan TimKiem(string ma_hoa_don)
        {
            List<HoaDonBan> ds_hoa_don = this.DanhSachHoaDon();
            HoaDonBan hoa_don = ds_hoa_don.Find(sp => sp.MaHoaDon == ma_hoa_don);

            return hoa_don;
        }

       //hoa don
    }
}
