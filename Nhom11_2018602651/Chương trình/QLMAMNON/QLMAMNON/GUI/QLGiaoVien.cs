using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLMAMNON.BLL;

namespace QLMAMNON.GUI
{
    public partial class QLGiaoVien : Form
    {
        Giaovien gv = new Giaovien();
        public QLGiaoVien()
        {
            InitializeComponent();
        }

        public void LoadNhanvien()
        {
            NhanvienBLL nv = new NhanvienBLL();
            DataTable dt = nv.shownhanvien();
            cbxtengiaovien.DataSource = dt;
            cbxtengiaovien.DisplayMember = "hotennv";
            cbxtengiaovien.ValueMember = "manv";
        }

        public void LoadKhoi()
        {
            Khoihoc kh = new Khoihoc();
            DataTable dt = kh.showKhoihoc();
            cbxtenkhoi.DataSource = dt;
            cbxtenkhoi.DisplayMember = "tenkhoi";
            cbxtenkhoi.ValueMember = "tenkhoi";
        }

        public void LoadLop()
        {
            Lop lp = new Lop();
            DataTable dt = lp.showLop();
            cbxtenlop.DataSource = dt;
            cbxtenlop.DisplayMember = "tenlop";
            cbxtenlop.ValueMember = "malop";
        }

        public void LoadNam()
        {
            Namhoc nh = new Namhoc();
            DataTable dt = nh.showNamhoc();
            cbxtennamhoc.DataSource = dt;
            cbxtennamhoc.DisplayMember = "tennamhoc";
            cbxtennamhoc.ValueMember = "namhoc";
        }

        private void QLGiaoVien_Load(object sender, EventArgs e)
        {
            LoadNhanvien();
            LoadKhoi();
            LoadLop();
            LoadNam();
            DataTable dt = new DataTable();
            dt = gv.showGiaovien();
            dgvHienThi.DataSource = dt;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string hotengv = cbxtengiaovien.SelectedValue.ToString();
                string tenlop = cbxtenlop.SelectedValue.ToString();
                string tenkhoi = cbxtenkhoi.SelectedValue.ToString();
                string tennamhoc = cbxtennamhoc.SelectedValue.ToString();
                gv.Themgiaovien(hotengv, tenlop, tenkhoi, tennamhoc);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Không được trùng giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
            }
            QLGiaoVien_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string hotengv = cbxtengiaovien.SelectedValue.ToString();
                string tenlop = cbxtenlop.SelectedValue.ToString();
                string tenkhoi = cbxtenkhoi.SelectedValue.ToString();
                string tennamhoc = cbxtennamhoc.SelectedValue.ToString();
                gv.Suagiaovien(hotengv, tenlop, tenkhoi, tennamhoc);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Không được trùng giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
            }
            QLGiaoVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbxtengiaovien.Text == string.Empty)
            {
                MessageBox.Show("Bạn phải chọn tên giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string mahs = cbxtengiaovien.SelectedValue.ToString();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    gv.Xoagiaovien(mahs);
                    QLGiaoVien_Load(sender, e);

                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txtTimkiem.Text;
            DataTable dt = gv.Timkiem(timkiem);
            if (dt.Rows.Count > 0)
            {
                dgvHienThi.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm kiếm được kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
    }
}
