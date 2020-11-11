using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using QuanLyDienThoai1.Model;
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

            StreamReader sr = new StreamReader("E:SanPham.txt");
            string str_line = sr.ReadLine();

            while (str_line != null)
            {
                string[] atts = str_line.Split('/');

                string ma_sp = atts[0];
                string ten_sp = atts[1];
                int kich_thuoc = int.Parse(atts[2]);
                string mau_sac = atts[3];
                int so_luong = int.Parse(atts[4]);
                double don_gia = double.Parse(atts[5]);

                SanPham sp = new SanPham(ma_sp, ten_sp, kich_thuoc, mau_sac, so_luong,don_gia );
                ds_san_pham.Add(sp);

                str_line = sr.ReadLine();
            }

            sr.Close();

            return ds_san_pham;
        }

        public void Them(SanPham sp)
        {
            StreamWriter sw = new StreamWriter("E:SanPham.txt", append: true);
            string data_row = sp.MaSanPham + "/" + sp.TenSanPham + "/" + sp.KichThuoc + "/" + sp.MauSac + "/" + sp.SoLuong /*+ "/"+sp.DonGia*/;
            sw.WriteLine(data_row);
            sw.Close();
        }

        public void CapNhat(List<SanPham> ds_san_pham)
        {
            StreamWriter sw = new StreamWriter("E:SanPham.txt");
            foreach (var sp in ds_san_pham)
            {
                string data_row = sp.MaSanPham + "/" + sp.TenSanPham + "/" + sp.KichThuoc + "/" + sp.MauSac + "/" + sp.SoLuong ;
                sw.WriteLine(data_row);
            }

            sw.Close();
        }
        public double tinhtien()
        {
            List<SanPham> ds = new List<SanPham>();
            double t = 0;
            foreach (SanPham sp in ds)
                t = t + sp.SoLuong * sp.DonGia;
            return t;
        }

    }
}
