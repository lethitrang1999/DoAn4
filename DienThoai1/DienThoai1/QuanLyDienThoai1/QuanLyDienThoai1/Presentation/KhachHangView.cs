using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using QuanLyDienThoai1.BusinessLogic;
using QuanLyDienThoai1.Model;

namespace QuanLyDienThoai1.Presentation
{
    public class KhachHangView
    {
        KhachHangBL sp_bl = new KhachHangBL();

        public void ThemMoi()
        {
            Console.WriteLine("Nhap thong tin khach hang");
            while (true)
            {
                KhachHang sp = new KhachHang();
                Console.Write("Ma khach hang: ");
                sp.MaKhachHang = Console.ReadLine();
                Console.Write("Ho ten: ");
                sp.HoTen = Console.ReadLine();
                Console.Write("So Dien Thoai: ");
                sp.SoDienThoai = Console.ReadLine();
                Console.Write("Dia Chi: ");
                sp.DiaChi = Console.ReadLine();
               
                sp_bl.Them(sp);

                Console.Write("Ban co muon nhap tiep tuc them moi khach hang khong? Y/N: ");
                string tiep_tuc = Console.ReadLine();
                if (tiep_tuc == "N" || tiep_tuc == "n")
                    break;
            }
        }

        public void HienThi()
        {
            Console.WriteLine("Danh sach khach hang:");
            string str_line = string.Empty;

            Console.WriteLine("Ma khach hang   \t    Ho ten    \t    So Dien Thoai   \t     Dia Chi    ");
            List<KhachHang> ds_khach_hang = sp_bl.DanhSachKhachHang();
            foreach (var sp in ds_khach_hang)
            {
                string data_show = sp.MaKhachHang + "\t  " + sp.HoTen + " \t       " + sp.SoDienThoai + "   \t             " + sp.DiaChi ;
                Console.WriteLine(data_show);
            }
        }

        public void Sua()
        {
            Console.Write("Nhap ma khach hang muon sua:");
            string ma_khach_hang = Console.ReadLine();
            KhachHang sp = sp_bl.TimKiem(ma_khach_hang);
            if (sp != null)
            {
                Console.Write("Ten ho ten: ");
                string ho_ten = Console.ReadLine();
                if (ho_ten != "")
                    sp.HoTen = ho_ten;

                Console.Write("So Dien Thoai: ");
                string so_dien_thoai = Console.ReadLine();
                if (so_dien_thoai != "")
                    sp.SoDienThoai =so_dien_thoai;

                Console.Write("Dia Chi: ");
                string dia_chi = Console.ReadLine();
                if (dia_chi != "")
                    sp.DiaChi = dia_chi;

               
                sp_bl.Sua(sp);
            }
            else
            {
                Console.WriteLine("khach hang muon sua khong ton tai!");
            }
        }

        public void Xoa()
        {
            Console.Write("Nhap ma khach hang muon xoa:");
            string ma_khach_hang = Console.ReadLine();
            KhachHang sp = sp_bl.TimKiem(ma_khach_hang);
            if (sp != null)
            {
                sp_bl.Xoa(ma_khach_hang);
            }
            else
            {
                Console.WriteLine("Khach hang muon xoa khong ton tai!");
            }
        }

        public void TimKiem()
        {
            Console.Write("Nhap ma khach hang muon tim kiem:");
            string ma_khach_hang = Console.ReadLine();
            KhachHang sp = sp_bl.TimKiem(ma_khach_hang);
            if (sp != null)
            {
                Console.WriteLine("Ma khach hang  \t  Ho Ten    \t    So Dien Thoai     \t      Dia Chi    ");
                string data_show = sp.MaKhachHang + "\t" + sp.HoTen + "\t" + sp.SoDienThoai + "\t" + sp.DiaChi ;
                Console.WriteLine(data_show);
            }
            else
            {
                Console.WriteLine("Khach hang muon tim kiem khong ton tai!");
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

                Console.WriteLine("Nhap exit de thoat quan ly Khach Hang hoac nhan phim bat ky de tiep tuc!");
                string exit = Console.ReadLine();
                if (exit == "exit")
                    break;
            }
        }
    }
}
