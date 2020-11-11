using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDienThoai1.Model
{
    public class HoaDonNhap
    {
        private string ma_hoa_don;
        private string ten_hoa_don;
        private string ma_doi_tac;
        private string ngay_nhap;
        private int so_luong_nhap;
        private double don_gia;
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

        public string NgayNhap
        {
            get
            {
                return this.ngay_nhap;
            }
            set
            {
                this.ngay_nhap = value;
            }
        }

        public int SoLuongNhap
        {
            get
            {
                return this.so_luong_nhap;
            }
            set
            {
                this.so_luong_nhap = value;
            }
        }

        public double DonGia
        {
            get
            {
                return this.don_gia;
            }
            set
            {
                this.don_gia = value;
            }
        }



        public HoaDonNhap() { }

        public HoaDonNhap(string ma_hoa_don,string ten_hoa_don, string ma_doi_tac, string ngay_nhap , int so_luong_nhap , double don_gia)
        {
            this.ma_hoa_don = ma_hoa_don;
            this.ten_hoa_don = ten_hoa_don;
            this.ma_doi_tac = ma_doi_tac;
            this.ngay_nhap = ngay_nhap;
            this.so_luong_nhap = so_luong_nhap;
            this.don_gia = don_gia;
            
        }
    }
}
