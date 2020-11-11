using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDienThoai1.Model;
using System.IO;

namespace QuanLyDienThoai1.DataAccess
{
    public class HoaDonNhapDA
    {
        public List<HoaDonNhap> LayDanhSachSanPham()
        {
            List<HoaDonNhap> ds_hoa_don = new List<HoaDonNhap>();

            StreamReader sr = new StreamReader("E:HoaDonNhap.txt");
            string str_line = sr.ReadLine();

            while (str_line != null)
            {
                string[] atts = str_line.Split('/');

                string ma_hd = atts[0];
                string ten_hd = atts[1];
                string ma_dt = atts[2]; 
                string ngay_nhap = atts[3];
                int so_luong_nhap = int.Parse(atts[4]);
                double don_gia = double.Parse(atts[5]);

                HoaDonNhap sp = new HoaDonNhap(ma_hd, ten_hd, ma_dt, ngay_nhap, so_luong_nhap , don_gia);
                ds_hoa_don.Add(sp);

                str_line = sr.ReadLine();
            }

            sr.Close();

            return ds_hoa_don;
        }

        public void Them(HoaDonNhap dt)
        {
            StreamWriter sw = new StreamWriter("E:HoaDonNhap.txt", append: true);
            string data_row = dt.MaHoaDon + "/" + dt.TenHoaDon + "/" + dt.MaDoiTac +  "/" + dt.NgayNhap + "/" + dt.SoLuongNhap + "/" + dt.DonGia;
            sw.WriteLine(data_row);
            sw.Close();
        }

        public void CapNhat(List<HoaDonNhap> ds_hoa_don)
        {
            StreamWriter sw = new StreamWriter("E:HoaDonNhap.txt");
            foreach (var sp in ds_hoa_don)
            {
                string data_row = sp.MaHoaDon + "/" + sp.TenHoaDon + "/" + sp.MaDoiTac + "/" + sp.NgayNhap + "/" + sp.SoLuongNhap + "/" + sp.DonGia;
                sw.WriteLine(data_row);
            }

            sw.Close();
        }
    }
}

