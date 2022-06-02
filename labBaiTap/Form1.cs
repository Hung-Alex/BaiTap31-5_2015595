using labBaiTap.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labBaiTap
{
    public partial class Form1 : Form
    {
        List<SinhVien> qlSinhvien;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qlSinhvien = DAO.SinhVienDAO.Instance.GetSinhVien();
            LoadLop();
            LoadSinhVien(DAO.SinhVienDAO.Instance.GetSinhVien());
        }
        void LoadLop()
        {
            cboLop.DataSource = DAO.LopDAO.Instance.GetSinhVien();
            cboLop.DisplayMember="TenLop";
        }
        void LoadSinhVien(List<SinhVien> ds)
        {
            lvDanhSachSV.Items.Clear();
            foreach (SinhVien item in ds)
            {
                ListViewItem itemSV = new ListViewItem(item.HienThiThongTinListView()) ;
                itemSV.Tag = item;
                lvDanhSachSV.Items.Add(itemSV);
            }
        }

        private void lvDanhSachSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachSV.SelectedItems.Count>0)
            {
                SinhVien x = lvDanhSachSV.SelectedItems[0].Tag as SinhVien;
                cboLop.Text = x.Lop;
                txtID.Text = x.ID.ToString();
                txtHoTenSV.Text = x.HoTen;
            }
            else
            {
                cboLop.Text = "";
                txtID.Text = "";
                txtHoTenSV.Text = "";
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadSinhVien(DAO.SinhVienDAO.Instance.GetSinhVien());
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            cboLop.Text = "";
            txtID.Text = "";
            txtHoTenSV.Text = "";
        }
        object[] GetThongTinSinhVien(object id=null)
        {

            int malop = 0;

            if (cboLop.SelectedIndex != -1 && cboLop.SelectedItem != null)
            {
                malop = (cboLop.SelectedItem as Lop).ID;
            }
            string hoten = txtHoTenSV.Text;
            object[] ds = new object[] { hoten, malop,id };
            return ds;
        }

            bool CheckThongTin()
        {
            if (string.IsNullOrWhiteSpace(cboLop.Text)||string.IsNullOrWhiteSpace(txtHoTenSV.Text))
                return false;
            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!CheckThongTin())
            {
                MessageBox.Show("Vui Lòng nhập đây đủ thông tin");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtID.Text))
                {
                    if (DAO.SinhVienDAO.Instance.InsertSinhVien(GetThongTinSinhVien())>0)
                    {
                        MessageBox.Show("Thêm Thành Công");

                    }
                    else
                    {
                        MessageBox.Show("Thêm Không Thành Công");

                    }
                }
                else
                {
                    if (DAO.SinhVienDAO.Instance.UpdateSinhVien(GetThongTinSinhVien(txtID.Text)) > 0)
                    {
                        MessageBox.Show("Cập Nhật Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Cập Nhật Không Thành Công");

                    }
                }
            
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<SinhVien> dssv = new List<SinhVien>();
            foreach (SinhVien item in qlSinhvien)
            {
                if (item.HoTen.Contains(txtTimKiem.Text))
                {
                    dssv.Add(item);
                }
            }
            LoadSinhVien(dssv);
        }
    }
}
