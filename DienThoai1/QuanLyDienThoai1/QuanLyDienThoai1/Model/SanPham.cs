using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuanLyDienThoai1.Model
{
    public class SanPham
    {
        private string ma_san_pham;
        private string ten_san_pham;
        private int kich_thuoc;
        private string mau_sac;
        private int so_luong;
        private double don_gia;

        public string MaSanPham
        {
            get
            {
                return this.ma_san_pham;
            }
            set
            {
                this.ma_san_pham = value;
            }
        }

        public string TenSanPham
        {
            get
            {
                return this.ten_san_pham;
            }
            set
            {
                this.ten_san_pham = value;
            }
        }

        public int KichThuoc
        {
            get
            {
                return this.kich_thuoc;
            }
            set
            {
                this.kich_thuoc = value;
            }
        }

        public string MauSac
        {
            get
            {
                return this.mau_sac;
            }
            set
            {
                this.mau_sac = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return this.so_luong;
            }
            set
            {
                this.so_luong = value;
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
        public SanPham()
        {
            this.ma_san_pham = "";
            this.ten_san_pham = "";
            this.kich_thuoc = 0;
            this.mau_sac = "";
            this.so_luong = 0;
            this.don_gia = 0.0;

        }

        public SanPham(string ma_san_pham, string ten_san_pham, int kich_thuoc, string mau_sac, int so_luong, double don_gia)
        {
            this.ma_san_pham = ma_san_pham;
            this.ten_san_pham = ten_san_pham;
            this.kich_thuoc = kich_thuoc;
            this.mau_sac = mau_sac;
            this.so_luong = so_luong;
            this.don_gia = don_gia;
        }
        //public String toString()
        //{
        //    SanPham sp = new SanPham();
        //    return MaSanPham + "\t" + TenSanPham + "\t" + KichThuoc + "\t" + MauSac + "\t" + SoLuong + "\t" + DonGia;
        //}

        //public SanPham(object obj)
        //{
        //    this.ma_san_pham = obj.
        //    this.ten_san_pham = ten_san_pham;
        //    this.kich_thuoc = kich_thuoc;
        //    this.mau_sac = mau_sac;
        //    this.so_luong = so_luong;
        //    this.don_gia = don_gia;
        //}

    }
}
