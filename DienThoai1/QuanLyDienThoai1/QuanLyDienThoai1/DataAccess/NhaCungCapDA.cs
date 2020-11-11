using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using QuanLyDienThoai1.Model;
//DAL đảm nhận chức năng tương tác với CSDL, tức là chúng ta sẽ viết các hàm kết nối, xử lý thêm xóa sửa

namespace QuanLyDienThoai1.DataAccess
{
    public class NhaCungCapDA
    {
        public List<NhaCungCap> LayDanhSachSanPham()
        {
            List<NhaCungCap> ds_nha_cung_cap = new List<NhaCungCap>();

            StreamReader sr = new StreamReader("E:KhachHang.txt");
            string str_line = sr.ReadLine();

            while (str_line != null)
            {
                string[] atts = str_line.Split('/');

                string ma_ncc = atts[0];
                string ho_ten = atts[1];
                string so_dien_thoai = atts[2];
                string dia_chi = atts[3];
                NhaCungCap sp = new NhaCungCap(ma_ncc, ho_ten, so_dien_thoai, dia_chi);
                ds_nha_cung_cap.Add(sp);

                str_line = sr.ReadLine();
            }

            sr.Close();

            return ds_nha_cung_cap;
        }

        public void Them(NhaCungCap sp)
        {
            StreamWriter sw = new StreamWriter("E:KhachHang.txt", append: true);
            string data_row = sp.MaNhaCungCap + "/" + sp.HoTen + "/" + sp.SoDienThoai + "/" + sp.DiaChi;
            sw.WriteLine(data_row);
            sw.Close();
        }

        public void CapNhat(List<NhaCungCap> ds_nha_cung_cap)
        {
            StreamWriter sw = new StreamWriter("E:KhachHang.txt");
            foreach (var sp in ds_nha_cung_cap)
            {
                string data_row = sp.MaNhaCungCap + "/" + sp.HoTen + "/" + sp.SoDienThoai + "/" + sp.DiaChi;
                sw.WriteLine(data_row);
            }

            sw.Close();
        }
    }
}
