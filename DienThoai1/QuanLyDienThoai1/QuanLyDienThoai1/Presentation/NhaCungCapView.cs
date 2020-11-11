using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using QuanLyDienThoai1.BusinessLogic;
using QuanLyDienThoai1.Model;

namespace QuanLyDienThoai1.Presentation
{
    public class NhaCungCapView
    {
        NhaCungCapBL sp_bl = new NhaCungCapBL();

        public void ThemMoi()
        {
            Console.WriteLine("Nhap thong tin nha cung cap");
            while (true)
            {
                NhaCungCap sp = new NhaCungCap();
                Console.Write("Ma Nha Cung Cap: ");
                sp.MaNhaCungCap = Console.ReadLine();
                Console.Write("Ho ten: ");
                sp.HoTen = Console.ReadLine();
                Console.Write("So Dien Thoai: ");
                sp.SoDienThoai = Console.ReadLine();
                Console.Write("Dia Chi: ");
                sp.DiaChi = Console.ReadLine();

                sp_bl.Them(sp);

                Console.Write("Ban co muon nhap tiep tuc them moi nha cung cap khong? Y/N: ");
                string tiep_tuc = Console.ReadLine();
                if (tiep_tuc == "N" || tiep_tuc == "n")
                    break;
            }
        }

        public void HienThi()
        {
            Console.WriteLine("Danh sach nha cung cap:");
            string str_line = string.Empty;

            Console.WriteLine("Ma Nha Cung Cap   \t    Ho ten    \t    So Dien Thoai   \t     Dia Chi    ");
            List<NhaCungCap> ds_nha_cung_cap = sp_bl.DanhSachNhaCungCap();
            foreach (var sp in ds_nha_cung_cap)
            {
                string data_show = sp.MaNhaCungCap + "\t  " + sp.HoTen + " \t       " + sp.SoDienThoai + "   \t             " + sp.DiaChi;
                Console.WriteLine(data_show);
            }
        }

        public void Sua()
        {
            Console.Write("Nhap nha cung cap muon sua:");
            string ma_nha_cung_cap = Console.ReadLine();
            NhaCungCap sp = sp_bl.TimKiem(ma_nha_cung_cap);
            if (sp != null)
            {
                Console.Write("Ten ho ten: ");
                string ho_ten = Console.ReadLine();
                if (ho_ten != "")
                    sp.HoTen = ho_ten;

                Console.Write("So Dien Thoai: ");
                string so_dien_thoai = Console.ReadLine();
                if (so_dien_thoai != "")
                    sp.SoDienThoai = so_dien_thoai;

                Console.Write("Dia Chi: ");
                string dia_chi = Console.ReadLine();
                if (dia_chi != "")
                    sp.DiaChi = dia_chi;


                sp_bl.Sua(sp);
            }
            else
            {
                Console.WriteLine("Nha Cung Cap muon sua khong ton tai!");
            }
        }

        public void Xoa()
        {
            Console.Write("Nhap ma nha cung cap muon xoa:");
            string ma_nha_cung_cap = Console.ReadLine();
            NhaCungCap sp = sp_bl.TimKiem(ma_nha_cung_cap);
            if (sp != null)
            {
                sp_bl.Xoa(ma_nha_cung_cap);
            }
            else
            {
                Console.WriteLine(" muon xoa khong ton tai!");
            }
        }

        public void TimKiem()
        {
            Console.Write("Nhap ma Nha Cung Cap muon tim kiem:");
            string ma_nha_cung_cap = Console.ReadLine();
            NhaCungCap sp = sp_bl.TimKiem(ma_nha_cung_cap);
            if (sp != null)
            {
                Console.WriteLine("Ma Nha Cung Cap  \t  Ho Ten    \t    So Dien Thoai     \t      Dia Chi    ");
                string data_show = sp.MaNhaCungCap + "\t" + sp.HoTen + "\t" + sp.SoDienThoai + "\t" + sp.DiaChi;
                Console.WriteLine(data_show);
            }
            else
            {
                Console.WriteLine("Nha Cung Cap muon tim kiem khong ton tai!");
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

                Console.WriteLine("Nhap exit de thoat quan ly Nha Cung Cap hoac nhan phim bat ky de tiep tuc!");
                string exit = Console.ReadLine();
                if (exit == "exit")
                    break;
            }
        }
    }
}
