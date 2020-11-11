using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDienThoai1.BusinessLogic;
using QuanLyDienThoai1.DataAccess;
using QuanLyDienThoai1.Model;
using QuanLyDienThoai1.Presentation;

namespace QuanLyDienThoai1
{
    class MEnuChinh
    {
       public void Menu()
        {
            Console.WriteLine("Phan mem quan ly dien thoai");

            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.Clear();
                Console.SetCursorPosition(30, 3);
                Console.WriteLine("PHẦN MỀM QUẢN LÝ ĐIỆN THOẠI");
                Console.SetCursorPosition(0, 7);
                Console.WriteLine();
                Console.WriteLine("\t\t╔══════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t║   CÁC CHỨC NĂNG QUẢN LÝ :                                            ║");
                Console.WriteLine("\t\t╠══════════════════════════════════════════════════════════════════════╣");
                Console.WriteLine("\t\t║                                                                      ║");
                Console.WriteLine("\t\t║                          XIN MỜI NHẬP                                ║");
                Console.WriteLine("\t\t║                                                                      ║");
                Console.WriteLine("\t\t║                       1.SẢN PHẨM                                     ║");
                Console.WriteLine("\t\t║                                                                      ║");
                Console.WriteLine("\t\t║                       2.ĐỐI TÁC                                      ║");
                Console.WriteLine("\t\t║                                                                      ║");
                Console.WriteLine("\t\t║                       3.HÓA ĐƠN BÁN                                  ║");
                Console.WriteLine("\t\t║                                                                      ║");
                Console.WriteLine("\t\t║                       4.HÓA ĐƠN NHẬP                                 ║");
                Console.WriteLine("\t\t║                                                                      ║");
                Console.WriteLine("\t\t║                       5.KHÁCH HÀNG                                   ║");
                Console.WriteLine("\t\t║                                                                      ║");
                Console.WriteLine("\t\t║                       6.NHÀ CUNG CẤP                                 ║");
                Console.WriteLine("\t\t║                                                                      ║");
                Console.WriteLine("\t\t║                                                                      ║");
                Console.WriteLine("\t\t║                                                                      ║");
                Console.WriteLine("\t\t║                    CHỌN CHỨC NĂNG QUẢN LÝ:                           ║");
                Console.WriteLine("\t\t║                                                                      ║");
                Console.WriteLine("\t\t╠══════════════════════════════════════════════════════════════════════╣");
                Console.WriteLine("\t\t║                                                                      ║");
                Console.WriteLine("\t\t║                                                                      ║");
                Console.WriteLine("\t\t╚══════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("");
                Console.WriteLine();
                Console.WriteLine("\t\t    ╔═════════════════════╦═════════════════════════════════════╗");
                Console.WriteLine("\t\t    ║ GIÁO VIÊN HƯỚNG DẪN ║NGUYỄN THỊ NHỊ                       ║");
                Console.WriteLine("\t\t    ╠═════════════════════╬═════════════════════════════════════╣");
                Console.WriteLine("\t\t    ║                     ║LÊ THỊ TRANG                         ║");
                Console.WriteLine("\t\t    ║   NGƯỜI THỰC HIỆN   ╠═════════════════════════════════════╣");
                Console.WriteLine("\t\t    ║                     ║LỚP TK 15.7                          ║");
                Console.WriteLine("\t\t    ╚═════════════════════╩═════════════════════════════════════╝");
                string menu = Console.ReadLine();

                if (menu == "1")
                {
                    Console.Clear();
                    SanPhamView sp_view = new SanPhamView();
                    sp_view.QuanLy();


                }
                else if (menu == "2")
                {
                    Console.Clear();
                    DoiTacView dt = new DoiTacView();
                    dt.QuanLy();
                }

                else if (menu == "3")
                {
                    Console.Clear();
                    HoaDonBanView dt = new HoaDonBanView();
                    dt.QuanLy();
                }
                else if (menu == "4")
                {
                    Console.Clear();
                    HoaDonNhapView dt = new HoaDonNhapView();
                    dt.QuanLy();
                }
                else if (menu == "5")
                {
                    Console.Clear();
                    KhachHangView dt = new KhachHangView();
                    dt.QuanLy();
                }

                else if (menu == "6")
                {
                    Console.Clear();
                    NhaCungCapView dt = new NhaCungCapView();
                    dt.QuanLy();
                }
                Console.WriteLine("Nhap exit de thoat chuong trinh hoac nhan phim bat ky de tiep tuc!");
                string exit = Console.ReadLine();
                if (exit == "exit")
                    break;
            }
            Console.ReadKey();

        }
    }
}
