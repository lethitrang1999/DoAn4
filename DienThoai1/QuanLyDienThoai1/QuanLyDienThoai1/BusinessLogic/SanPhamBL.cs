using System;
using System.Collections.Generic;
using System.Text;
using QuanLyDienThoai1.Model;
using QuanLyDienThoai1.DataAccess;

namespace QuanLyDienThoai1.BusinessLogic
{
    public class SanPhamBL
    {
        SanPhamDA sp_da = new SanPhamDA();

        public List<SanPham> DanhSachSanPham()
        {
            return sp_da.LayDanhSachSanPham();
        }

        public void Them(SanPham sp)
        {
            sp_da.Them(sp);
        }

        public void Sua(SanPham sp_update)
        {
            List<SanPham> ds_san_pham_cap_nhat = new List<SanPham>();
            List<SanPham> ds_san_pham_hien_tai = this.DanhSachSanPham();

            foreach (var sp_ht in ds_san_pham_hien_tai)
            {
                if (sp_update.MaSanPham == sp_ht.MaSanPham)
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

        public void Xoa(string ma_san_pham)
        {
            List<SanPham> ds_san_pham = this.DanhSachSanPham();
            //tim trong ds sp ra ma sp muon xoa neu ton tai thi thuc hien xoa sp do

            SanPham san_pham = ds_san_pham.Find(sp => sp.MaSanPham == ma_san_pham);
            if (san_pham != null)
            {
                ds_san_pham.Remove(san_pham);
            }
            sp_da.CapNhat(ds_san_pham);
        }

        public SanPham TimKiem(string ma_san_pham)
        {
            List<SanPham> ds_san_pham = this.DanhSachSanPham();
            SanPham san_pham = ds_san_pham.Find(sp => sp.MaSanPham == ma_san_pham);

            return san_pham;
        }
        public void Tongtien()
        {

        }

    }
}
