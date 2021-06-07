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
    public partial class QLTaiKhoan : Form
    {
        Login lg = new Login();
        public QLTaiKhoan()
        {
            InitializeComponent();
        }

        private void QLTaiKhoan_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = lg.showTaiKhoan();
            dataGridView1.DataSource = dt;
        }

        private void rdbuser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống Tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtmatkhau.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống Mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int quyen = 0;
                    string username = txttaikhoan.Text;
                    string pass = txtmatkhau.Text;
                    if (rdbAdmin.Checked) 
                    {
                        quyen = 0; 
                    }
                    else if (rdbuser.Checked)
                    {
                        quyen = 1; 
                    }
                        
                    lg.Themtaikhoan(username, pass, quyen);
                }
                
                catch (FormatException)
                {
                    MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
                }
                QLTaiKhoan_Load(sender, e);
            }
        }

        int row;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txttaikhoan.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                txtmatkhau.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống Tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtmatkhau.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống Mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int quyen = 0;
                    string username = txttaikhoan.Text;
                    string pass = txtmatkhau.Text;
                    if (rdbAdmin.Checked)
                    {
                        quyen = 0;
                    }
                    else if (rdbuser.Checked)
                    {
                        quyen = 1;
                    }
                    lg.Suataikhoan(username, pass, quyen);
                }

                catch (FormatException)
                {
                    MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
                }
                QLTaiKhoan_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Text == string.Empty)
            {
                MessageBox.Show("Bạn phải chọn tài khoản để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string tk = txttaikhoan.Text;
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    lg.XoaTaiKhoan(tk);
                    QLTaiKhoan_Load(sender, e);
                    txttaikhoan.Clear();
                    txtmatkhau.Clear();

                }
            }
        }
    }
}
