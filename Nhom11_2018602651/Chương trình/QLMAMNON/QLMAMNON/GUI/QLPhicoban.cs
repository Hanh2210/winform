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
    public partial class QLPhicoban : Form
    {
        Phicoban phi = new Phicoban();
        public QLPhicoban()
        {
            InitializeComponent();
        }
        public void LoadNamhoc()
        {
            Namhoc nh = new Namhoc();
            DataTable dt = nh.showNamhoc();
            cbxnamhoc.DataSource = dt;
            cbxnamhoc.DisplayMember = "tennamhoc";
            cbxnamhoc.ValueMember = "namhoc";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtluongcb.Text == string.Empty)
            {
                MessageBox.Show("Lương cơ bản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtphicb.Text == string.Empty)
            {
                MessageBox.Show("Học phí cơ bản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string namhoc = cbxnamhoc.SelectedValue.ToString();
                    int luongcoban = int.Parse(txtluongcb.Text);
                    int hocphicoban = int.Parse(txtphicb.Text);
                    phi.Themphi(namhoc,luongcoban,hocphicoban);
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
                QLPhicoban_Load(sender, e);
            }
        }

        private void QLPhicoban_Load(object sender, EventArgs e)
        {
            LoadNamhoc();
            DataTable dt = new DataTable();
            dt = phi.showPhicb();
            dgvhienthi.DataSource = dt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtluongcb.Text == string.Empty)
            {
                MessageBox.Show("Lương cơ bản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtphicb.Text == string.Empty)
            {
                MessageBox.Show("Học phí cơ bản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string namhoc = cbxnamhoc.SelectedValue.ToString();
                    int luongcoban = int.Parse(txtluongcb.Text);
                    int hocphicoban = int.Parse(txtphicb.Text);
                    phi.Suaphi(namhoc, luongcoban, hocphicoban);
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
                QLPhicoban_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string namhoc = cbxnamhoc.SelectedValue.ToString();
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                phi.Xoaphi(namhoc);
                QLPhicoban_Load(sender, e);

            }
        }
    }
}
