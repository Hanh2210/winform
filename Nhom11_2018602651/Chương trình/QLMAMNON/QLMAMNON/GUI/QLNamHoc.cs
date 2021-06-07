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
    public partial class QLNamHoc : Form
    {
        Namhoc nh = new Namhoc();
        public QLNamHoc()
        {
            InitializeComponent();
            CenterToScreen();        }

        private void QLNamHoc_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = nh.showNamhoc();
            dgvnamhoc.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtnamhoc.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống Năm học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txttennamhoc.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống Tên năm học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string namhoc = txtnamhoc.Text;
                    string tennamhoc = txttennamhoc.Text;
                    string ngaybatdau = dtpngaybatdau.Value.ToString("yyyy/MM/dd");
                    string ngayketthuc = dtpngayketthuc.Value.ToString("yyyy/MM/dd");
                    nh.Themnamhoc(namhoc, tennamhoc, ngaybatdau, ngayketthuc);
                    QLNamHoc_Load(sender, e);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
                }

            }
        }
     
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtnamhoc.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống Năm học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txttennamhoc.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống Tên năm học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string namhoc = txtnamhoc.Text;
                    string tennamhoc = txttennamhoc.Text;
                    string ngaybatdau = dtpngaybatdau.Value.ToString("yyyy/MM/dd");
                    string ngayketthuc = dtpngayketthuc.Value.ToString("yyyy/MM/dd");
                    nh.Suanamhoc(namhoc, tennamhoc, ngaybatdau, ngayketthuc);
                }
                
                catch (FormatException)
                {
                    MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
                }
                QLNamHoc_Load(sender, e);
            }
        }

        int row;
        private void dgvnamhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txtnamhoc.Text = dgvnamhoc.Rows[row].Cells[0].Value.ToString();
                txttennamhoc.Text = dgvnamhoc.Rows[row].Cells[1].Value.ToString();
                dtpngaybatdau.Text = dgvnamhoc.Rows[row].Cells[2].Value.ToString();
                dtpngayketthuc.Text = dgvnamhoc.Rows[row].Cells[3].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtnamhoc.Text == string.Empty)
            {
                MessageBox.Show("Bạn phải chọn năm học để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string namhoc = txtnamhoc.Text;
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    nh.Xoanamhoc(namhoc);
                    QLNamHoc_Load(sender, e);
                    txtnamhoc.Clear();
                    txttennamhoc.Clear();
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            DataTable dt = nh.Timkiem(timkiem);
            if (dt.Rows.Count > 0)
            {
                dgvnamhoc.DataSource = dt;
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

        private void dgvnamhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
