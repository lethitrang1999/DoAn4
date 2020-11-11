using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using QuanLyDienThoai1.Model;
//thao tác đc ghi tệp text
//Lớp này thực hiện các nghiệp vụ liên quan đến lưu trữ và truy xuất dữ liệu của ứng dụng
//Data Access Layer (DAL) : Lớp này có chức năng giao tiếp với hệ quản trị CSDL như thực hiện các công việc liên quan đến lưu trữ và truy vấn dữ liệu ( tìm kiếm, thêm, xóa, sửa,…).
//là thành phần chính chịu trách nhiệm lưu trữ vào và truy xuất dữ liệu từ các nguồn dữ liệu 
namespace QuanLyDienThoai1.DataAccess
{
    public class SanPhamDA
    {
        //List<SanPham> ds_san_pham;
        public List<SanPham> LayDanhSachSanPham()
        {
            List<SanPham> ds_san_pham = new List<SanPham>();
            //doc file 
            StreamReader sr = new StreamReader("E:SanPham.txt");
            string str_line = sr.ReadLine();

            while (str_line != null)
            {
                //mỗi 1 sp thi se co ma , lấy gtri '/'
                string[] atts = str_line.Split('/');
                string ma_sp = atts[0];
                string ten_sp = atts[1];
                int kich_thuoc = int.Parse(atts[2]);
                string mau_sac = atts[3];
                int so_luong = int.Parse(atts[4]);
                double don_gia = double.Parse(atts[5]);

                SanPham sp = new SanPham(ma_sp, ten_sp, kich_thuoc, mau_sac, so_luong, don_gia );
                ds_san_pham.Add(sp);

                str_line = sr.ReadLine();
            }

            sr.Close();

            return ds_san_pham;
        }

        public void Them(SanPham sp)
        {
            StreamWriter sw = new StreamWriter("E:SanPham.txt", append: true);
            string data_row = sp.MaSanPham + "/" + sp.TenSanPham + "/" + sp.KichThuoc + "/" + sp.MauSac + "/" + sp.SoLuong + "/"+sp.DonGia;
            sw.WriteLine(data_row);
            sw.Close();
        }

        public void CapNhat(List<SanPham> ds_san_pham)
        {
            StreamWriter sw = new StreamWriter("E:SanPham.txt");
            foreach (var sp in ds_san_pham)
            {
                string data_row = sp.MaSanPham + "/" + sp.TenSanPham + "/" + sp.KichThuoc + "/" + sp.MauSac + "/" + sp.SoLuong + "/" + sp.DonGia;
                sw.WriteLine(data_row);
            }

            sw.Close();
        }
        
        //public void Readfile(string file)
        //  {
        //      file = "E:SanPham.txt";
        //      List<SanPham> ds_san_pham = new List<SanPham>();
        //      StreamReader str = new StreamReader(new FileStream(file, FileMode.Open));
        //      string strmp;
        //      string[] tmp;
        //      while(!str.EndOfStream)

        //      {
        //          strmp = str.ReadLine().Trim();
        //          if(strmp!="")
        //          {
        //              tmp = strmp.Split('/');
        //              ds_san_pham.Add(new SanPham((tmp[0]), tmp[1], int.Parse(tmp[2]), tmp[3], int.Parse(tmp[4]),double.Parse( tmp[5])));
        //          }
        //      }
        //      str.Close();
        //  }

        //  public void WriteFile(string filename)

        //  {
        //      StreamWriter str = new StreamWriter(filename, false);
        //      foreach (SanPham sp in ds_san_pham)
        //      {
        //          str.WriteLine(sp.toString());
        //      }
        //      str.Close();
        //  }
    }
}
