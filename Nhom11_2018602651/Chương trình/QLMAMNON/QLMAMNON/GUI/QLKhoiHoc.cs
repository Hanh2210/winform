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
    public partial class QLKhoiHoc : Form
    {
        Khoihoc kh = new Khoihoc();
        public QLKhoiHoc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void LoadNamhoc()
        {
            Namhoc nh = new Namhoc();
            DataTable dt = nh.showNamhoc();
            cbxnamhoc.DataSource = dt;
            cbxnamhoc.DisplayMember = "tennamhoc";
            cbxnamhoc.ValueMember = "namhoc";
        }

        private void QLKhoiHoc_Load(object sender, EventArgs e)
        {
            LoadNamhoc();
            DataTable dt = new DataTable();
            dt = kh.showKhoihoc();
            dgvQLKhoihoc.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txttenkhoi.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống Tên khối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbxnamhoc.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống năm học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string namhoc = cbxnamhoc.SelectedValue.ToString();
                    string tenkhoi = txttenkhoi.Text;
                    kh.Themkhoihoc(tenkhoi, namhoc);
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Không được trùng tên khối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
                }
                QLKhoiHoc_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txttenkhoi.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống Tên khối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbxnamhoc.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống năm học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string namhoc = cbxnamhoc.SelectedValue.ToString();
                    string tenkhoi = txttenkhoi.Text;
                    kh.Suakhoihoc(tenkhoi, namhoc);
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Không được trùng tên khối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
                }
                QLKhoiHoc_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttenkhoi.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải chọn tên khối để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string tenkhoi = txttenkhoi.Text;
                    DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        kh.XoaKhoihoc(tenkhoi);
                        QLKhoiHoc_Load(sender, e);
                        txttenkhoi.Clear();
                    }
                }
            }
            catch (SqlException ex)
            {

                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    MessageBox.Show("Xóa không thành công, liên quan đến khóa phụ");
                }
            }
            
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            DataTable dt = kh.Timkiem(timkiem);
            if (dt.Rows.Count > 0)
            {
                dgvQLKhoihoc.DataSource = dt;
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

        int row;
        private void dgvQLKhoihoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txttenkhoi.Text = dgvQLKhoihoc.Rows[row].Cells[0].Value.ToString();
            }
        }
    }
}
