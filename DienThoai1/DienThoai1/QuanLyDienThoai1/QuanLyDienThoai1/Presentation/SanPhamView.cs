using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using QuanLyDienThoai1.BusinessLogic;
using QuanLyDienThoai1.Model;

//Lớp này làm nhiệm vụ giao tiếp với người dùng cuối để thu thập dữ liệu và hiển thị kết quả/dữ liệu thông qua các thành phần trong giao diện người sử dụng.
//Lớp này có nhiệm vụ chính giao tiếp với người dùng. Nó gồm các thành phần giao diện ( win form, web form,…) và thực hiện các công việc như nhập liệu, hiển thị dữ liêu, kiểm tra tính đúng đắn dữ liệu trước khi gọi lớp Business Logic Layer (BLL).

namespace QuanLyDienThoai1.Presentation
{
  //  List<SanPham> ds_san_pham;
    public class SanPhamView
    {
        SanPhamBL sp_bl = new SanPhamBL();

        public void ThemMoi()
        {
            Console.WriteLine("Nhap thong tin San Pham");
            while (true)
            {
                SanPham sp = new SanPham();
                Console.Write("Ma san pham: ");
                sp.MaSanPham = Console.ReadLine();
                Console.Write("Ten san pham: ");
                sp.TenSanPham = Console.ReadLine();
                Console.Write("Kich thuoc: ");
                sp.KichThuoc = int.Parse(Console.ReadLine());
                Console.Write("Mau sac: ");
                sp.MauSac = Console.ReadLine();
                Console.Write("So luong: ");
                sp.SoLuong = int.Parse(Console.ReadLine());
                Console.Write("Don Gia: ");
                sp.DonGia = double.Parse(Console.ReadLine());

                sp_bl.Them(sp);

                Console.Write("Ban co muon nhap tiep tuc them moi San Pham khong? Y/N: ");
                string tiep_tuc = Console.ReadLine();
                if (tiep_tuc == "N" || tiep_tuc == "n")
                    break;
            }
        }

        public void HienThi()
        {
            Console.WriteLine("Danh sach san pham:");
            //đọc dòng đầu tiên
            string str_line = string.Empty;

            Console.WriteLine("Ma   \t    Ten    \t    Kich Thuoc    \t     Mau sac    \t     So luong   \t  Don Gia");
            List<SanPham> ds_san_pham = sp_bl.DanhSachSanPham();
            foreach (var sp in ds_san_pham)
            {
                string data_show = sp.MaSanPham +   "\t\t  " + sp.TenSanPham + " \t \t      "        + sp.KichThuoc +     "   \t\t             "        + sp.MauSac +         "   \t \t               "  + sp.SoLuong/* +"\t\t" + sp.DonGia*/;
                Console.WriteLine(data_show);
            }
        }

        public void Sua()
        {
            Console.Write("Nhap ma san pham muon sua:");
            string ma_san_pham = Console.ReadLine();
            SanPham sp = sp_bl.TimKiem(ma_san_pham);
            if (sp != null)
            {
                Console.Write("Ten san pham: ");
                string ten_san_pham = Console.ReadLine();
                if (ten_san_pham != "")
                    sp.TenSanPham = ten_san_pham;

                Console.Write("Kich thuoc: ");
                string kich_thuoc = Console.ReadLine();
                if (kich_thuoc != "")
                    sp.KichThuoc = int.Parse(kich_thuoc);

                Console.Write("Mau sac: ");
                string mau_sac = Console.ReadLine();
                if (mau_sac != "")
                    sp.MauSac = mau_sac;

                Console.Write("So luong: ");
                string so_luong = Console.ReadLine();
                if (so_luong != "")
                    sp.SoLuong = int.Parse(so_luong);

                Console.Write("Don Gia: ");
                string don_gia = Console.ReadLine();
                if (don_gia != "")
                    sp.DonGia = double.Parse(don_gia);

                sp_bl.Sua(sp);
            }
            else
            {
                Console.WriteLine("San pham muon sua khong ton tai!");
            }
        }

        public void Xoa()
        {
            Console.Write("Nhap ma san pham muon xoa:");
            string ma_san_pham = Console.ReadLine();
            SanPham sp = sp_bl.TimKiem(ma_san_pham);
            if (sp != null)
            {
                sp_bl.Xoa(ma_san_pham);
            }
            else
            {
                Console.WriteLine("San pham muon xoa khong ton tai!");
            }
        }
        public void TimKiem()
        {
            Console.Write("Nhap ma san pham muon tim kiem:");
            string ma_san_pham = Console.ReadLine();
            SanPham sp = sp_bl.TimKiem(ma_san_pham);
            if (sp != null)
            {
                Console.WriteLine("Ma  \t  Ten    \t    Kich Thuoc     \t      Mau sac    \t    So luong  /*\t Don gia*/"); 
                string data_show = sp.MaSanPham + "\t" + sp.TenSanPham + "\t" + sp.KichThuoc + "\t" + sp.MauSac + "\t" + sp.SoLuong /*+"\t" +sp.DonGia*/;
                Console.WriteLine(data_show);
            }
            else
            {
                Console.WriteLine("San pham muon tim kiem khong ton tai!");
            }
        }

        public double tinhtien()
        {
            List<SanPham> ds = new List<SanPham>();
            double t = 0;
            foreach (SanPham sp in ds)
                t = t + sp.SoLuong * sp.DonGia;
            return t;
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
                Console.WriteLine(" 6. Quay lai");
                Console.WriteLine(" 7. Tong tien");
                string lua_chon = Console.ReadLine();
                Program main = new Program();

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
                else
                    if (lua_chon == "7")
                {
                    Console.Clear();
                    tinhtien();
                }
                Console.WriteLine("Nhap exit de thoat quan ly San pham hoac nhan phim bat ky de tiep tuc!");
                string exit = Console.ReadLine();
                if (exit == "exit")
                    break;
            }
        }

        //public double Tinhtien()
        //{
        //    SanPham sp = new SanPham();
        //    double t = sp.DonGia * sp.SoLuong;
        //    return t;
        //}
    }
}
