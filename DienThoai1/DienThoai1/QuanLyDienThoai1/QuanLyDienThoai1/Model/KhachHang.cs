using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai1.Model
{
   public class KhachHang
    {
        private string ma_khach_hang;
        private string ho_ten;
        private string so_dien_thoai;
        private string dia_chi;
        //dùng để khởi tạo khi k cần truyền tham số

        public string MaKhachHang
        {
            get
            {
                return this.ma_khach_hang;
            }
            set
            {
                this.ma_khach_hang = value;
            }
        }

        public string HoTen
        {
            get
            {
                return this.ho_ten;
            }
            set
            {
                this.ho_ten = value;
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

        public KhachHang() { }

        public KhachHang(string ma_khach_hang, string ho_ten,  string so_dien_thoai, string dia_chi)
        {
            this.ma_khach_hang = ma_khach_hang;
            this.ho_ten = ho_ten;
            this.so_dien_thoai = so_dien_thoai;
            this.dia_chi = dia_chi;
           
        }
    }
}

