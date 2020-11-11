using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDienThoai1.Model;
using System.IO;

namespace QuanLyDienThoai1.DataAccess
{
    public class HoaDonBanDA
    {
        public List<HoaDonBan> LayDanhSachSanPham()
        {
            List<HoaDonBan> ds_hoa_don = new List<HoaDonBan>();

            StreamReader sr = new StreamReader("E:HoaDonBan.txt");
            string str_line = sr.ReadLine();

            while (str_line != null)
            {
                string[] atts = str_line.Split('/');

                string ma_hd = atts[0];
                string ten_hd = atts[1];
                string ma_dt = atts[2];
                string ngay_ban = atts[3];
                int so_luong_ban = int.Parse(atts[4]);

                HoaDonBan sp = new HoaDonBan(ma_hd, ten_hd, ma_dt, ngay_ban, so_luong_ban);
                ds_hoa_don.Add(sp);

                str_line = sr.ReadLine();
            }

            sr.Close();

            return ds_hoa_don;
        }

        public void Them(HoaDonBan dt)
        {
            StreamWriter sw = new StreamWriter("E:HoaDonBan.txt", append: true);
            string data_row = dt.MaHoaDon + "/" + dt.TenHoaDon + "/" + dt.MaDoiTac + "/" + dt.NgayBan + "/" + dt.SoLuongBan;
            sw.WriteLine(data_row);
            sw.Close();
        }

        public void CapNhat(List<HoaDonBan> ds_hoa_don)
        {
            StreamWriter sw = new StreamWriter("E:HoaDonBan.txt");
            foreach (var sp in ds_hoa_don)
            {
                string data_row = sp.MaHoaDon + "/" + sp.TenHoaDon + "/" + sp.MaDoiTac + "/" + sp.NgayBan + "/" + sp.SoLuongBan;
                sw.WriteLine(data_row);
           }


            sw.Close();
        }
      
    }
}

