using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai1.Model
{
    public class NhaCungCap
    {
        private string ma_nha_cung_cap;
        private string ho_ten;
        private string so_dien_thoai;
        private string dia_chi;


        public string MaNhaCungCap
        {
            get
            {
                return this.ma_nha_cung_cap;
            }
            set
            {
                this.ma_nha_cung_cap = value;
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

        public NhaCungCap() { }

        public NhaCungCap(string ma_nha_cung_cap, string ho_ten, string so_dien_thoai, string dia_chi)
        {
            this.ma_nha_cung_cap = ma_nha_cung_cap;
            this.ho_ten = ho_ten;
            this.so_dien_thoai = so_dien_thoai;
            this.dia_chi = dia_chi;

        }
    }
}

