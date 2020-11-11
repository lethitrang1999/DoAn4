using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using QuanLyDienThoai1.BusinessLogic;
using QuanLyDienThoai1.Model;

namespace QuanLyDienThoai1.Presentation
{
    public class HoaDonNhapView
    {
        HoaDonNhapBL sp_bl = new HoaDonNhapBL();

        public void ThemMoi()
        {
            Console.WriteLine("Nhap thong tin San Pham");
            while (true)
            {
                HoaDonNhap sp = new HoaDonNhap();
                Console.Write("Ma Hoa Don: ");
                sp.MaHoaDon = Console.ReadLine();
                Console.Write("Ten Hoa Don: ");
                sp.TenHoaDon= Console.ReadLine();
                Console.Write("Ma Doi Tac: ");
                sp.MaDoiTac = Console.ReadLine();
                Console.Write("Ngay Nhap: ");
                sp.NgayNhap = Console.ReadLine();
                Console.Write("So Luong Nhap: ");
                sp.SoLuongNhap = int.Parse(Console.ReadLine());
                Console.Write("Don gia: ");
                sp.DonGia = int.Parse(Console.ReadLine());







                sp_bl.Them(sp);

                Console.Write("Ban co muon nhap tiep tuc them moi San Pham khong? Y/N: ");
                string tiep_tuc = Console.ReadLine();
                if (tiep_tuc == "N" || tiep_tuc == "n")
                    break;
            }
        }

        public void HienThi()
        {
            Console.WriteLine("Danh sach hoa don:");
            string str_line = string.Empty;

            Console.WriteLine("Ma Hoa Don   \t      Ten Hoa Don  \t      Ma Doi Tac   \t       Ngay Nhap    \t  So Luong Nhap \t Don Gia");
            List<HoaDonNhap> ds_doi_tac = sp_bl.DanhSachHoaDon();
            foreach (var sp in ds_doi_tac)
            { 
                string data_show = sp.MaHoaDon + "\t            "+ sp.TenHoaDon + " \t          "+ sp.MaDoiTac + "\t                 "+ sp.NgayNhap + "        \t "+ sp.SoLuongNhap  + "\t               "  + sp.DonGia;
                Console.WriteLine(data_show);
            }
        }

        public void Sua()
        {
            Console.Write("Nhap hoa don tac muon sua:");
            string ma_hoa_don = Console.ReadLine();
            HoaDonNhap sp = sp_bl.TimKiem(ma_hoa_don);
            if (sp != null)
            {
                Console.Write("Ten Hoa Don: ");
                string ten_hoa_don = Console.ReadLine();
                if (ten_hoa_don != "")
                    sp.MaDoiTac = ten_hoa_don;


                Console.Write("Ma Doi Tac: ");
                string ma_doi_tac = Console.ReadLine();
                if (ma_doi_tac != "")
                    sp.MaDoiTac = ma_doi_tac;

                Console.Write("Ngay Nhap: ");
                string ngay_nhap = Console.ReadLine();
                if (ngay_nhap != "")
                    sp.NgayNhap = ngay_nhap;

                Console.Write("So Luong Nhap: ");
                string so_luong_nhap = Console.ReadLine();
                if (so_luong_nhap != "")
                    sp.SoLuongNhap =int.Parse( so_luong_nhap);

                Console.Write("Don Gia: ");
                string don_gia = Console.ReadLine();
                if (don_gia != "")
                    sp.DonGia = int.Parse(don_gia);

                sp_bl.Sua(sp);
            }
            else
            {
                Console.WriteLine("Hoa don muon sua khong ton tai!");
            }
        }

        public void Xoa()
        {
            Console.Write("Nhap ma Hoa Don muon xoa:");
            string ma_hoa_don = Console.ReadLine();
            HoaDonNhap sp = sp_bl.TimKiem(ma_hoa_don);
            if (sp != null)
            {
                sp_bl.Xoa(ma_hoa_don);
            }
            else
            {
                Console.WriteLine("ma hoa don muon xoa khong ton tai!");
            }
        }

        public void TimKiem()
        {
            Console.Write("Nhap ma hoa don muon tim kiem:");
            string ma_hoa_don = Console.ReadLine();
            HoaDonNhap sp = sp_bl.TimKiem(ma_hoa_don);
            if (sp != null)
            {
                Console.WriteLine("Ma hoa don /t  Ten Hoa don /t Ma doi tac /t Ngay Nhap  /t So Luong Nhap  /t  Don Gia");
                string data_show = sp.MaHoaDon + "/t" + sp.TenHoaDon + "/t" + sp.MaDoiTac + "/t" + sp.NgayNhap + "/t" + sp.SoLuongNhap  + "/t" + sp.DonGia;
                Console.WriteLine(data_show);
            }
            else
            {
                Console.WriteLine("Hoa don muon tim kiem khong ton tai!");
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
