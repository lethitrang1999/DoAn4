using System;
using System.Collections.Generic;
using System.Text;
using QuanLyDienThoai1.Model;
using QuanLyDienThoai1.DataAccess;

namespace QuanLyDienThoai1.BusinessLogic
{
    public class NhaCungCapBL
    {
        NhaCungCapDA sp_da = new NhaCungCapDA();

        public List<NhaCungCap> DanhSachNhaCungCap()
        {
            return sp_da.LayDanhSachSanPham();
        }

        public void Them(NhaCungCap sp)
        {
            sp_da.Them(sp);
        }

        public void Sua(NhaCungCap sp_update)
        {
            List<NhaCungCap> ds_san_pham_cap_nhat = new List<NhaCungCap>();
            List<NhaCungCap> ds_san_pham_hien_tai = this.DanhSachNhaCungCap();

            foreach (var sp_ht in ds_san_pham_hien_tai)
            {
                if (sp_update.MaNhaCungCap == sp_ht.MaNhaCungCap)
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

        public void Xoa(string ma_nha_cung_cap)
        {
            List<NhaCungCap> ds_nha_cung_cap = this.DanhSachNhaCungCap();

            NhaCungCap nha_cc = ds_nha_cung_cap.Find(sp => sp.MaNhaCungCap == ma_nha_cung_cap);
            if (nha_cc != null)
            {
                ds_nha_cung_cap.Remove(nha_cc);
            }
            sp_da.CapNhat(ds_nha_cung_cap);
        }

        public NhaCungCap TimKiem(string ma_nha_cung_cap)
        {
            List<NhaCungCap> ds_nha_cung_cap = this.DanhSachNhaCungCap();
            NhaCungCap nha_cc = ds_nha_cung_cap.Find(sp => sp.MaNhaCungCap == ma_nha_cung_cap);

            return nha_cc;
        }
    }
}
