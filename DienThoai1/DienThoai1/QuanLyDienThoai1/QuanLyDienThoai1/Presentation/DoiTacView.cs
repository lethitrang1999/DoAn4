using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using QuanLyDienThoai1.BusinessLogic;
using QuanLyDienThoai1.Model;

namespace QuanLyDienThoai1.Presentation
{
    public class DoiTacView
    {
        DoiTacBL sp_bl = new DoiTacBL();

        public void ThemMoi()
        {
            Console.WriteLine("Nhap thong tin Doi tac");
            while (true)
            {
                DoiTac sp = new DoiTac();
                Console.Write("Ma doi tac: ");
                sp.MaDoiTac = Console.ReadLine();
                Console.Write("Ten doi tac: ");
                sp.TenDoiTac = Console.ReadLine();
                Console.Write("Dia chi: ");
                sp.DiaChi = Console.ReadLine();
                Console.Write("So Dien Thoai: ");
                sp.SoDienThoai = Console.ReadLine();

                Console.WriteLine("Loai Doi Tac:");
                Console.WriteLine("1. Khach Hang");
                Console.WriteLine("2. Nha Cung Cap");
                Console.WriteLine("3. Ca 2");
                string loai_dt = Console.ReadLine();

                if (loai_dt == "1")
                {
                    sp.LaKhachHang = true;
                    sp.LaNhaCungCap = false;
                }
                else if (loai_dt == "2")
                {
                    sp.LaKhachHang = false;
                    sp.LaNhaCungCap = true;
                }
                else
                {
                    sp.LaKhachHang = true;
                    sp.LaNhaCungCap = true;
                }





                sp_bl.Them(sp);

                Console.Write("Ban co muon nhap tiep tuc them moi Doi tac khong? Y/N: ");
                string tiep_tuc = Console.ReadLine();
                if (tiep_tuc == "N" || tiep_tuc == "n")
                    break;
            }
        }

        public void HienThi()
        {
            Console.WriteLine("Danh sach doi tac:");
            string str_line = string.Empty;

            Console.WriteLine("Ma   \t    Ten    \t    Dia Chi    \t        So Dien Thoai    \tLa Khach Hang?    \tLa Nha Cung Cap?");
            List<DoiTac> ds_doi_tac = sp_bl.DanhSachDoiTac();
            foreach (var sp in ds_doi_tac)
            {
                string data_show = sp.MaDoiTac + "\t  " + sp.TenDoiTac + " \t  " + sp.DiaChi + "\t"+ sp.SoDienThoai + "\t         " + sp.LaKhachHang + "           \t " + sp.LaNhaCungCap ;
                Console.WriteLine(data_show);
            }
        }

        public void Sua()
        {
            Console.Write("Nhap ma doi tac muon sua:");
            string ma_doi_tac = Console.ReadLine();
            DoiTac sp = sp_bl.TimKiem(ma_doi_tac);
            if (sp != null)
            {
                Console.Write("Ten doi tac: ");
                string ten_doi_tac = Console.ReadLine();
                if (ten_doi_tac != "")
                    sp.TenDoiTac = ten_doi_tac;

                Console.Write("Dia chi: ");
                string dia_chi = Console.ReadLine();
                if (dia_chi != "")
                    sp.DiaChi = dia_chi;

                Console.Write("So dien thoai: ");
                string so_dien_thoai = Console.ReadLine();
                if (so_dien_thoai != "")
                    sp.SoDienThoai = so_dien_thoai;

                Console.Write("La khach hang: ");
                string la_khach_hang = Console.ReadLine();
                if (la_khach_hang != "")
                    sp.LaKhachHang = bool.Parse(la_khach_hang);

                Console.Write("La khach hang: ");
                string la_nha_cung_cap = Console.ReadLine();
                if (la_nha_cung_cap != "")
                    sp.LaNhaCungCap = bool.Parse(la_nha_cung_cap);

                sp_bl.Sua(sp);
            }
            else
            {
                Console.WriteLine("Doi tac muon sua khong ton tai!");
            }
        }

        public void Xoa()
        {
            Console.Write("Nhap ma doi tac muon xoa:");
            string ma_doi_tac = Console.ReadLine();
            DoiTac sp = sp_bl.TimKiem(ma_doi_tac);
            if (sp != null)
            {
                sp_bl.Xoa(ma_doi_tac);
            }
            else
            {
                Console.WriteLine("ma doi tac muon xoa khong ton tai!");
            }
        }

        public void TimKiem()
        {
            Console.Write("Nhap ma san pham muon tim kiem:");
            string ma_doi_tac = Console.ReadLine();
            DoiTac sp = sp_bl.TimKiem(ma_doi_tac);
            if (sp != null)
            {
                Console.WriteLine("Ma /t Ten /t Dia chi /t So dien thoai /t La khach hang /t La nha cung cap");
                string data_show = sp.MaDoiTac + "/t" + sp.TenDoiTac + "/t" + sp.DiaChi + "/t" + sp.SoDienThoai + "/t" + sp.LaKhachHang + "/t" + sp.LaNhaCungCap;
                Console.WriteLine(data_show);
            }
            else
            {
                Console.WriteLine("Doi tac muon tim kiem khong ton tai!");
            }
        }

        public void QuanLy()
        {
            while (true)
            {
                Console.WriteLine("1. Them moi");
                Console.WriteLine("2. Hien thi");
                Console.WriteLine("3. Sua");
                Console.WriteLine("4. Xoa");
                Console.WriteLine("5. Tim kiem");
                Console.WriteLine("6. Quay lai");
                string lua_chon = Console.ReadLine();

                if (lua_chon == "1")
                    this.ThemMoi();
                else if (lua_chon == "2")
                    this.HienThi();
                if (lua_chon == "3")
                    this.Sua();
                else if (lua_chon == "4")
                    this.Xoa();
                if (lua_chon == "5")
                    this.TimKiem();
                else
                    if (lua_chon == "6")
                {
                    Console.Clear();
                    MEnuChinh mn = new MEnuChinh();
                    mn.Menu();
                }

                Console.WriteLine("Nhap exit de thoat quan ly Doi tac hoac nhan phim bat ky de tiep tuc!");
                string exit = Console.ReadLine();
                if (exit == "exit")
                    break;
            }
        }
    }
}
