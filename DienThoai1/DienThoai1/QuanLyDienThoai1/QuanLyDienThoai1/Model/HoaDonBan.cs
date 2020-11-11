using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDienThoai1.Model
{
    public class HoaDonBan
    {
        private string ma_hoa_don;
        private string ten_hoa_don;
        private string ma_doi_tac;
        private string ngay_ban;
        private int so_luong_ban;

        public string MaHoaDon
        {
            get
            {
                return this.ma_hoa_don;
            }
            set
            {
                this.ma_hoa_don = value;
            }
        }

        public string TenHoaDon
        {
            get
            {
                return this.ten_hoa_don;
            }
            set
            {
                this.ten_hoa_don = value;
            }
        }

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

        public string NgayBan
        {
            get
            {
                return this.ngay_ban;
            }
            set
            {
                this.ngay_ban = value;
            }
        }

        public int SoLuongBan
        {
            get
            {
                return this.so_luong_ban;
            }
            set
            {
                this.so_luong_ban = value;
            }
        }

        public HoaDonBan() { }

        public HoaDonBan(string ma_hoa_don, string ten_hoa_don, string ma_doi_tac, string ngay_ban, int so_luong_ban)
        {
            this.ma_hoa_don = ma_hoa_don;
            this.ten_hoa_don = ten_hoa_don;
            this.ma_doi_tac = ma_doi_tac;
            this.ngay_ban = ngay_ban;
            this.so_luong_ban = so_luong_ban;

        }
    }
}
