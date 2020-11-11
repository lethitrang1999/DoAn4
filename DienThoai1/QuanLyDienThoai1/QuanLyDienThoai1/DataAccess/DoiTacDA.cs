using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDienThoai1.Model;
using System.IO;

namespace QuanLyDienThoai1.DataAccess
{
    public class DoiTacDA
    {
        public List<DoiTac> LayDanhSachDoiTac()
        {
            List<DoiTac> ds_doi_tac = new List<DoiTac>();

            StreamReader sr = new StreamReader("E:DoiTac.txt");

            string str_line = sr.ReadLine();

            while (str_line != null)
            {
                string[] atts = str_line.Split('/');

                string ma_dt = atts[0];
                string ten_dt = atts[1];
                string dia_chi = atts[2];
                string so_dt = atts[3];
                bool la_KH = bool.Parse(atts[4]);
                bool la_NCC = bool.Parse(atts[5]);

                DoiTac sp = new DoiTac(ma_dt, ten_dt, dia_chi, so_dt, la_KH, la_NCC);
                ds_doi_tac.Add(sp);

                str_line = sr.ReadLine();
            }

            sr.Close();

            return ds_doi_tac;
        }

        public void Them(DoiTac dt)
        {
            StreamWriter sw = new StreamWriter("E:DoiTac.txt", append: true);
            string data_row = dt.MaDoiTac + "/" + dt.TenDoiTac + "/" + dt.DiaChi + "/" + dt.SoDienThoai + "/" + dt.LaKhachHang + "/" + dt.LaNhaCungCap;
            sw.WriteLine(data_row);
            sw.Close();
        }

        public void CapNhat(List<DoiTac> ds_doi_tac)
        {
            StreamWriter sw = new StreamWriter("E:DoiTac.txt");
            foreach (var sp in ds_doi_tac)
            {
                string data_row = sp.MaDoiTac + "/" + sp.TenDoiTac + "/" + sp.DiaChi + "/" + sp.SoDienThoai + "/" + sp.LaKhachHang + "/" + sp.LaNhaCungCap;
                sw.WriteLine(data_row);
            }

            sw.Close();
        }
    }
}

