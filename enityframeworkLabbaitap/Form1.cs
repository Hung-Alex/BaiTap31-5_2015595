using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enityframeworkLabbaitap
{
    public partial class Form1 : Form
    {
        QLSinhVienEntities data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSinhVien();
        }
        List<Lop> GetDSLop()
        {
            List<Lop> dslop= data.Lops.SqlQuery("select * from Lop").ToList();
            return dslop;
        }
        string DanhSachLop(int ?id)
        {
            foreach (Lop item in GetDSLop())
            {
                if (id==item.ID)
                {
                    return item.TenLop;
                }
            }
            return "";
        }
        void LoadSinhVien()
        {
            lvDanhSachSV.Items.Clear();
            data = new QLSinhVienEntities();
            var dssv = data.SinhViens.SqlQuery("select * from SinhVien").ToList();
            foreach (SinhVien item in dssv.ToList())
            {
                ListViewItem itemsv = new ListViewItem(item.ID.ToString());
                itemsv.SubItems.Add(item.HoTen.ToString());
               itemsv.SubItems.Add(DanhSachLop(item.MaLop));
                lvDanhSachSV.Items.Add(itemsv);
                itemsv.Tag = item;

            }

        }
    }
}
