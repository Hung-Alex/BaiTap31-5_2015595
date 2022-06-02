using labBaiTap.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labBaiTap.DAO
{
    class LopDAO
    {
        private static LopDAO instance;

        public static LopDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LopDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private LopDAO() { }
        public List<Lop> GetSinhVien()
        {
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery(@"select * from Lop");
            List<Lop> dsLop = new List<Lop>();
            foreach (DataRow item in data.Rows)
            {
                Lop x = new Lop(item);
                dsLop.Add(x);
            }
            return dsLop;
        }
    }
}
