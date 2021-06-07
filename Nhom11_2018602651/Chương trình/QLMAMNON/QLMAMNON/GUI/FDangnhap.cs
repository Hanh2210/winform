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
using QLMAMNON.DTO;
using QLMAMNON.GUI;


namespace QLMAMNON.GUI
{
    public partial class FDangnhap : Form
    {
        public FDangnhap()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        Login lg = new Login();
        private void FDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            fAdmin ql = new fAdmin();
            DataTable dt = new DataTable();
            dt = lg.showLoginNhanvien(txttaikhoan.Text, txtmatkhau.Text);
            Boolean k = true;
            
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow item in dt.Rows)
                {
                    k = Convert.ToBoolean(item["quyen"]);
                }
                if (k == false)
                {
                    fAdmin f = new fAdmin();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    fNhanvien f = new fNhanvien();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    
                }
            }
            else MessageBox.Show("Thông tin tài khoản hoặc mật khẩu chưa đúng", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void txttaikhoan_Click(object sender, EventArgs e)
        {
            txttaikhoan.Clear();
        }

        private void txtmatkhau_Click(object sender, EventArgs e)
        {
            txtmatkhau.Clear();
            txtmatkhau.PasswordChar = '*';
        }


    }
}
