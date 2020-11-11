using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDienThoai1.Model;
using QuanLyDienThoai1.DataAccess;
//Đây là nơi đáp ứng các yêu cầu thao tác dữ liệu của GUI layer, xử lý chính nguồn dữ liệu từ Presentation Layer trước khi truyền xuống Data Access Layer và lưu xuống hệ quản trị CSDL.s
//Đây còn là nơi kiểm tra các ràng buộc, tính toàn vẹn và hợp lệ dữ liệu, thực hiện tính toán và xử lý các yêu cầu nghiệp vụ, trước khi trả kết quả về Presentation Layer.

namespace QuanLyDienThoai1.BusinessLogic
{
    public class DoiTacBL
    {
        DoiTacDA dt_da = new DoiTacDA();

        public List<DoiTac> DanhSachDoiTac()
        {
            return dt_da.LayDanhSachDoiTac();
        }

        public void Them(DoiTac dt)
        {
            dt_da.Them(dt);
        }

        public void Sua(DoiTac sp_update)
        {
            List<DoiTac> ds_doi_tac_cap_nhat = new List<DoiTac>();
            List<DoiTac> ds_doi_tac_hien_tai = this.DanhSachDoiTac();

            foreach (var dt_ht in ds_doi_tac_hien_tai)
            {
                if (sp_update.MaDoiTac == dt_ht.MaDoiTac)
                {
                    ds_doi_tac_cap_nhat.Add(sp_update);
                }
                else
                {
                    ds_doi_tac_cap_nhat.Add(dt_ht);
                }
            }

            dt_da.CapNhat(ds_doi_tac_cap_nhat);
        }

        public void Xoa(string ma_doi_tac)
        {
            List<DoiTac> ds_doi_tac = this.DanhSachDoiTac();

            DoiTac doi_tac = ds_doi_tac.Find(dt => dt.MaDoiTac == ma_doi_tac);
            if (doi_tac != null)
            {
                ds_doi_tac.Remove(doi_tac);
            }
            dt_da.CapNhat(ds_doi_tac);
        }

        public DoiTac TimKiem(string ma_doi_tac)
        {
            List<DoiTac> ds_doi_tac = this.DanhSachDoiTac();
            DoiTac doi_tac = ds_doi_tac.Find(dt => dt.MaDoiTac == ma_doi_tac);

            return doi_tac;
        }
    }
}
