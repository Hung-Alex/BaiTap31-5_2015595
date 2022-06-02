using labBaiTap.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labBaiTap.DAO
{
    class SinhVienDAO
    {
        private static SinhVienDAO instance;

        public static SinhVienDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SinhVienDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private SinhVienDAO() { }
        public List<DTO.SinhVien> GetSinhVien()
        {
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery(@"select a.ID ,a.HoTen,b.TenLop from SinhVien a,Lop b where a.MaLop=b.ID");
            List<DTO.SinhVien> dsSV = new List<DTO.SinhVien>();
            foreach (DataRow item in data.Rows)
            {
                SinhVien sv = new SinhVien(item);
                dsSV.Add(sv);
            }
            return dsSV;
        }
        public int InsertSinhVien(object [] ds)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery("exec dbo.InsertStudent @HoTen , @Malop",ds);
        }
        public int UpdateSinhVien(object[] ds)
        {
            return DAO.DataProvider.Instance.ExecuteNonQuery("exec dbo.usp_UpdateSinhVien  @tensinhvien , @malop , @id", ds);
        }

    }
}
