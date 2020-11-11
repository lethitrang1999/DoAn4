using System;
using System.Collections.Generic;
using System.Text;
using QuanLyDienThoai1.Model;
using QuanLyDienThoai1.DataAccess;

namespace QuanLyDienThoai1.BusinessLogic
{
    public class HoaDonNhapBL
    {
        HoaDonNhapDA sp_da = new HoaDonNhapDA();

        public List<HoaDonNhap> DanhSachHoaDon()
        {
            return sp_da.LayDanhSachSanPham();
        }

        public void Them(HoaDonNhap sp)
        {
            sp_da.Them(sp);
        }

        public void Sua(HoaDonNhap sp_update)
        {
            List<HoaDonNhap> ds_san_pham_cap_nhat = new List<HoaDonNhap>();
            List<HoaDonNhap> ds_san_pham_hien_tai = this.DanhSachHoaDon();

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
            List<HoaDonNhap> ds_hoa_don = this.DanhSachHoaDon();

            HoaDonNhap hoa_don = ds_hoa_don.Find(sp => sp.MaHoaDon == ma_hoa_don);
            if (hoa_don != null)
            {
                ds_hoa_don.Remove(hoa_don);
            }
            sp_da.CapNhat(ds_hoa_don);
        }

        public HoaDonNhap TimKiem(string ma_hoa_don)
        {
            List<HoaDonNhap> ds_hoa_don = this.DanhSachHoaDon();
            HoaDonNhap hoa_don = ds_hoa_don.Find(sp => sp.MaHoaDon == ma_hoa_don);

            return hoa_don;
        }
    }
}
