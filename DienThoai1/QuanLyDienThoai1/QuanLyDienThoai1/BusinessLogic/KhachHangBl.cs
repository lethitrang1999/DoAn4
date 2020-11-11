using System;
using System.Collections.Generic;
using System.Text;
using QuanLyDienThoai1.Model;
using QuanLyDienThoai1.DataAccess;

namespace QuanLyDienThoai1.BusinessLogic
{
    public class KhachHangBL
    {
        KhachHangDA sp_da = new KhachHangDA();

        public List<KhachHang> DanhSachKhachHang()
        {
            return sp_da.LayDanhSachSanPham();
        }

        public void Them(KhachHang sp)
        {
            sp_da.Them(sp);
        }

        public void Sua(KhachHang sp_update)
        {
            List<KhachHang> ds_san_pham_cap_nhat = new List<KhachHang>();
            List<KhachHang> ds_san_pham_hien_tai = this.DanhSachKhachHang();

            foreach (var sp_ht in ds_san_pham_hien_tai)
            {
                if (sp_update.MaKhachHang == sp_ht.MaKhachHang)
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

        public void Xoa(string ma_khach_hang)
        {
            List<KhachHang> ds_khach_hang = this.DanhSachKhachHang();

            KhachHang khach_hang = ds_khach_hang.Find(sp => sp.MaKhachHang == ma_khach_hang);
            if (khach_hang != null)
            {
                ds_khach_hang.Remove(khach_hang);
            }
            sp_da.CapNhat(ds_khach_hang);
        }

        public KhachHang TimKiem(string ma_khach_hang)
        {
            List<KhachHang> ds_khach_hang = this.DanhSachKhachHang();
            KhachHang khach_hang = ds_khach_hang.Find(sp => sp.MaKhachHang == ma_khach_hang);

            return khach_hang;
        }
    }
}
