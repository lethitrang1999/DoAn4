using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using QuanLyDienThoai1.Model;

namespace QuanLyDienThoai1.DataAccess
{
    public class KhachHangDA
    {
        public List<KhachHang> LayDanhSachSanPham()
        {
            List<KhachHang> ds_khach_hang = new List<KhachHang>();

            StreamReader sr = new StreamReader("E:KhachHang.txt");
            string str_line = sr.ReadLine();

            while (str_line != null)
            {
                string[] atts = str_line.Split('/');

                string ma_kh = atts[0];
                string ho_ten = atts[1];
                string so_dien_thoai = atts[2];
                string dia_chi = atts[3];
               

                KhachHang sp = new KhachHang(ma_kh, ho_ten, so_dien_thoai, dia_chi);
                ds_khach_hang.Add(sp);

                str_line = sr.ReadLine();
            }

            sr.Close();

            return ds_khach_hang;
        }

        public void Them(KhachHang sp)
        {
            StreamWriter sw = new StreamWriter("E:KhachHang.txt", append: true);
            string data_row = sp.MaKhachHang + "/" + sp.HoTen + "/" + sp.SoDienThoai + "/" + sp.DiaChi ;
            sw.WriteLine(data_row);
            sw.Close();
        }

        public void CapNhat(List<KhachHang> ds_khach_hang)
        {
            StreamWriter sw = new StreamWriter("E:KhachHang.txt");
            foreach (var sp in ds_khach_hang)
            {
                string data_row = sp.MaKhachHang + "/" + sp.HoTen + "/" + sp.SoDienThoai + "/" + sp.DiaChi ;
                sw.WriteLine(data_row);
            }

            sw.Close();
        }
    }
}
