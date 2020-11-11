using System;
using QuanLyDienThoai1.Presentation;
using QuanLyDienThoai1.Model;
using QuanLyDienThoai1.DataAccess;
using System.Text;

namespace QuanLyDienThoai1
{
    class Program
    {
        static void Main(string[] args)
        {
            MEnuChinh mn = new MEnuChinh();
            mn.Menu();
        }

    }
}

