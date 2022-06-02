using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace labBaiTap.DTO
{
    class SinhVien
    {
        private int _iD;
        private string _hoTen;
        private string _lop;
        public SinhVien() { }
        public SinhVien(DataRow item)
        {
            this.ID = int.Parse(item["ID"].ToString());
            this.HoTen = item["HoTen"].ToString();
            this.Lop= item["TenLop"].ToString();
        }
        public  string[] HienThiThongTinListView()
        {
            string[] s = {this.ID.ToString(),this.HoTen,this.Lop };
            return s;
        }
        public int ID { get => _iD; set => _iD = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string Lop { get => _lop; set => _lop = value; }
    }
}
