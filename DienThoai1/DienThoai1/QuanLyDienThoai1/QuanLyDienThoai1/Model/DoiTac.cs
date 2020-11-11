using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanLyDienThoai1.Model
{
    public class DoiTac
    {
        private string ma_doi_tac;
        private string ten_doi_tac;
        private string dia_chi;
        private string so_dien_thoai;
        private bool la_khach_hang;
        private bool la_nha_cung_cap;

        public string MaDoiTac
        {
            get
            {
                return this.ma_doi_tac;
            }
            set
            {
                this.ma_doi_tac = value;
            }
        }

        public string TenDoiTac
        {
            get
            {
                return this.ten_doi_tac;
            }
            set
            {
                this.ten_doi_tac = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return this.dia_chi;
            }
            set
            {
                this.dia_chi = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return this.so_dien_thoai;
            }
            set
            {
                this.so_dien_thoai = value;
            }
        }

        public bool LaKhachHang
        {
            get
            {
                return this.la_khach_hang;
            }
            set
            {
                this.la_khach_hang = value;
            }
        }

        public bool LaNhaCungCap
        {
            get
            {
                return this.la_nha_cung_cap;
            }
            set
            {
                this.la_nha_cung_cap = value;
            }
        }

        public DoiTac() { }

        public DoiTac(string ma_doi_tac, string ten_doi_tac, string dia_chi, string so_dien_thoai, bool la_khach_hang, bool la_nha_cung_cap)
        {
            this.ma_doi_tac = ma_doi_tac;
            this.ten_doi_tac = ten_doi_tac;
            this.dia_chi = dia_chi;
            this.so_dien_thoai = so_dien_thoai;
            this.la_khach_hang = la_khach_hang;
            this.la_nha_cung_cap = la_nha_cung_cap;
        }

        //public void ThemMoi()
        //{
        //    string tiep_tuc = "Y";
        //    StreamWriter sw = new StreamWriter("../../../Database/DoiTac.txt", append: true);

        //    Console.WriteLine("Nhap thong tin Doi Tac");
        //    while (tiep_tuc != "N")
        //    {
        //        Console.Write("Ma doi tac: ");
        //        this.ma_doi_tac = Console.ReadLine();
        //        Console.Write("Ten doi tac: ");
        //        this.ten_doi_tac = Console.ReadLine();
        //        Console.Write("Dia chi: ");
        //        this.dia_chi = Console.ReadLine();
        //        Console.Write("So dien thoai: ");
        //        this.so_dien_thoai = Console.ReadLine();

        //        Console.WriteLine("Loai Doi Tac:");
        //        Console.WriteLine("1. Khach Hang");
        //        Console.WriteLine("2. Nha Cung Cap");
        //        Console.WriteLine("3. Ca 2");
        //        string loai_dt = Console.ReadLine();

        //        if (loai_dt == "1")
        //        {
        //            this.la_khach_hang = true;
        //            this.la_nha_cung_cap = false;
        //        }
        //        else if (loai_dt == "2")
        //        {
        //            this.la_khach_hang = false;
        //            this.la_nha_cung_cap = true;
        //        }
        //        else
        //        {
        //            this.la_khach_hang = true;
        //            this.la_nha_cung_cap = true;
        //        }

        //        string data_row = this.ma_doi_tac + "/" + this.ten_doi_tac + "/" + this.dia_chi + "/" + this.so_dien_thoai + "/" + this.la_khach_hang.ToString() + "/" + this.la_nha_cung_cap.ToString();

        //        sw.WriteLine(data_row);

        //        Console.Write("Ban co muon nhap tiep tuc them moi Doi Tac khong? Y/N: ");
        //        tiep_tuc = Console.ReadLine();
        //    }

        //    sw.Close();
        //}

        //public void HienThi()
        //{
        //    Console.WriteLine("Danh sach Doi Tac:");
        //    StreamReader sr = new StreamReader("../../../Database/DoiTac.txt");
        //    string str_line = string.Empty;

        //    Console.WriteLine("Ma/Ten/Dia chi/So Dien Thoai/La Khach Hang?/La Nha Cung Cap?");
        //    while (str_line != null)
        //    {
        //        str_line = sr.ReadLine();
        //        Console.WriteLine(str_line);
        //    }

        //    sr.Close();

        //}

        //public void QuanLy()
        //{
        //    Console.WriteLine("1. Them moi Doi Tac");
        //    Console.WriteLine("2. Hien thi danh sach Doi Tac");
        //    string lua_chon = Console.ReadLine();

        //    if (lua_chon == "1")
        //        this.ThemMoi();
        //    else if (lua_chon == "2")
        //        this.HienThi();

        //}
    }
}
