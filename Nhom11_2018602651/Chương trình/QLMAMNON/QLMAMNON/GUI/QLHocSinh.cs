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
    public partial class QLHocSinh : Form
    {
        Hocsinh hs = new Hocsinh();
        public QLHocSinh()
        {
            InitializeComponent();
        }

        private void QLHocSinh_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hs.showHocsinh();
            dgvHienthi.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtmahocsinh.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống mã học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txthotenhocsinh.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống họ tên học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtdantoc.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txthotenbo.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống họ tên bố", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtsdtbo.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống số điện thoại bố", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txthotenme.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống họ tên mẹ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtsdtme.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống số điện thoại mẹ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string mahs = txtmahocsinh.Text;
                    string hotenhs = txthotenhocsinh.Text;
                    string gioitinh = "";
                    if (rdbnam.Checked)
                        gioitinh = "Nam";
                    if (rdbnu.Checked)
                        gioitinh = "Nữ";
                    DateTime ngaysinh = dtpngaysinh.Value;
                    string hotenbo = txthotenbo.Text;
                    string sdtbo = txtsdtbo.Text;
                    string dantoc = txtdantoc.Text;
                    string hotenme = txthotenme.Text;
                    string sdtme = txtsdtme.Text;
                    hs.Themhocsinh(mahs, hotenhs, gioitinh, ngaysinh, dantoc, hotenbo, sdtbo, hotenme, sdtme);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QLHocSinh_Load(sender, e);
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Học sinh đã có trong danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int k = 0;
            for(int i = 0; i < dgvHienthi.Rows.Count - 1; i++)
            {
                if (txtmahocsinh.Text != dgvHienthi.Rows[i].Cells[0].Value.ToString())
                {
                    k = 1;
                }
            }          
            if (txtmahocsinh.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống mã học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txthotenhocsinh.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống họ tên học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtdantoc.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txthotenbo.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống họ tên bố", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtsdtbo.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống số điện thoại bố", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txthotenme.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống họ tên mẹ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtsdtme.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống số điện thoại mẹ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string mahs = txtmahocsinh.Text;
                    string hotenhs = txthotenhocsinh.Text;
                    string gioitinh = "";
                    if (rdbnam.Checked)
                        gioitinh = "Nam";
                    if (rdbnu.Checked)
                        gioitinh = "Nữ";
                    DateTime ngaysinh = dtpngaysinh.Value;
                    string hotenbo = txthotenbo.Text;
                    string sdtbo = txtsdtbo.Text;
                    string dantoc = txtdantoc.Text;
                    string hotenme = txthotenme.Text;
                    string sdtme = txtsdtme.Text;
                    hs.Suahocsinh(mahs, hotenhs, gioitinh, ngaysinh, dantoc, hotenbo, sdtbo, hotenme, sdtme);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QLHocSinh_Load(sender, e);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
                }
                catch (Exception)
                {
                    if (k == 1)
                    {
                        MessageBox.Show("Không được thay đổi mã học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtmahocsinh.Text == string.Empty)
            {
                MessageBox.Show("Bạn phải chọn học sinh để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string manv = txtmahocsinh.Text;
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    hs.Xoahocsinh(manv);
                    QLHocSinh_Load(sender, e);
                    txtmahocsinh.Clear();
                    txthotenhocsinh.Clear();
                    txtdantoc.Clear();
                    txthotenbo.Clear();
                    txtsdtbo.Clear();
                    txthotenme.Clear();
                    txtsdtme.Clear();
                }
            }
        }

        int row;
        private void dgvHienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txtmahocsinh.Text = dgvHienthi.Rows[row].Cells[0].Value.ToString();
                txthotenhocsinh.Text = dgvHienthi.Rows[row].Cells[1].Value.ToString();
                if (dgvHienthi.Rows[row].Cells[2].Value.Equals("Nam"))
                {
                    rdbnam.Checked = true;
                }
                else rdbnu.Checked = true;
                txthotenbo.Text = dgvHienthi.Rows[row].Cells[3].Value.ToString();
                txtsdtbo.Text = dgvHienthi.Rows[row].Cells[4].Value.ToString();
                txthotenme.Text = dgvHienthi.Rows[row].Cells[5].Value.ToString();
                txtsdtme.Text = dgvHienthi.Rows[row].Cells[6].Value.ToString();
                txtdantoc.Text = dgvHienthi.Rows[row].Cells[7].Value.ToString();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            List<hocsinh> nv = BLL.Hocsinh.Timkiemhocsinh(timkiem);
            if (nv.Count > 0)
            {
                dgvHienthi.DataSource = nv;
            }
            else
            {
                MessageBox.Show("Không tìm kiếm được kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void txtdantoc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
