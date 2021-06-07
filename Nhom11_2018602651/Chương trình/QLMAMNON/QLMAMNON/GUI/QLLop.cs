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
    public partial class QLLop : Form
    {
        Lop lp = new Lop();
        public QLLop()
        {
            InitializeComponent();
        }

        private void QLLop_Load(object sender, EventArgs e)
        {
            LoadNamhoc();
            LoadKhoi();
            DataTable dt = new DataTable();
            dt = lp.showLop();
            dgvHienthi.DataSource = dt;
        }

        public void LoadNamhoc()
        {
            Namhoc nh = new Namhoc();
            DataTable dt = nh.showNamhoc();
            cbxnamhoc.DataSource = dt;
            cbxnamhoc.DisplayMember = "tennamhoc";
            cbxnamhoc.ValueMember = "namhoc";
        }

        public void LoadKhoi()
        {
            Khoihoc kh = new Khoihoc();
            DataTable dt = kh.showKhoihoc();
            cbxtenkhoi.DataSource = dt;
            cbxtenkhoi.DisplayMember = "tenkhoi";
            cbxtenkhoi.ValueMember = "tenkhoi";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtmalop.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txttenlop.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string malop = txtmalop.Text;
                    string tenlop = txttenlop.Text;
                    string tenkhoi = cbxtenkhoi.SelectedValue.ToString();
                    string namhoc = cbxnamhoc.SelectedValue.ToString();
                    lp.Themlop(malop, tenlop, tenkhoi, namhoc);
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Không được trùng mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
                }
                QLLop_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < dgvHienthi.Rows.Count - 1; i++)
            {
                if (txtmalop.Text != dgvHienthi.Rows[i].Cells[0].Value.ToString())
                {
                    k = 1;
                }
            }
            if (txtmalop.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txttenlop.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string malop = txtmalop.Text;
                    string tenlop = txttenlop.Text;
                    string tenkhoi = cbxtenkhoi.SelectedValue.ToString();
                    string namhoc = cbxnamhoc.SelectedValue.ToString();
                    lp.Sualop(malop, tenlop, tenkhoi, namhoc);
                }
               
                catch (FormatException)
                {
                    MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
                }
                catch (Exception)
                {
                    if (k == 1)
                    {
                        MessageBox.Show("Không được thay đổi mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                QLLop_Load(sender, e);
            }
        }
        int row;

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtmalop.Text == string.Empty)
            {
                MessageBox.Show("Bạn phải chọn lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string malop = txtmalop.Text;
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    lp.XoaLop(malop);
                    QLLop_Load(sender, e);
                    txtmalop.Clear();
                    txttenlop.Clear();
                }
            }
        }

        private void dgvHienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txtmalop.Text = dgvHienthi.Rows[row].Cells[0].Value.ToString();
                txttenlop.Text = dgvHienthi.Rows[row].Cells[1].Value.ToString();
                
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            DataTable dt = lp.Timkiem(timkiem);
            if (dt.Rows.Count > 0)
            {
                dgvHienthi.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm kiếm được kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
