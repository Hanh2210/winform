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
using QLMAMNON.DAL;
using QLMAMNON.DTO;

namespace QLMAMNON.GUI
{
    public partial class QLHocPhi : Form
    {
        Hocphi hp = new Hocphi();
        
        
        public QLHocPhi()
        {
            InitializeComponent();
        }

        public void loadHocsinh()
        {
            Hocsinh hs = new Hocsinh();
            DataTable dt = hs.showHocsinh();
            cbxmahs.DataSource = dt;
            cbxmahs.DisplayMember = "mahs";
            cbxmahs.ValueMember = "mahs";
            string mahs = cbxmahs.SelectedValue.ToString();
            Hocphi hp = new Hocphi();
            DataTable dt1 = new DataTable();
            dt1 = hp.Loadcbxhs(mahs);
            foreach (DataRow item in dt1.Rows)
            {
                txttenhs.Text = item["hotenhs"].ToString();

            }
            DataTable dt2 = new DataTable();
            dt2 = hp.Loadlop(mahs);
            foreach (DataRow item in dt2.Rows)
            {
                txtlop.Text = item["malop"].ToString();

            }
        }
        private void QLHocPhi_Load(object sender, EventArgs e)
        {
            loadHocsinh();
            loadHocphi();
            DataTable dt = new DataTable();
            dt = hp.showHocphi();
            dgvhienthi.DataSource = dt;
        }

        //public void Nhap (out int hpcb, float giam)
        //{

        //    hpcb = int.Parse(txthocphi.Text);
           
        //}
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                int tinhtrang = 0;
                string mahs = cbxmahs.SelectedValue.ToString();
                int hocphicoban = Int32.Parse(txthocphi.Text);
                string namhoc = cbxnamhoc.SelectedValue.ToString();
                int tonghocphi = int.Parse(txttonghp.Text.ToString());
                string hogiadinh ="";
                if (rbchuahoanthanh.Checked)
                {
                    tinhtrang = 0;
                }
                if (rbhoanthanh.Checked)
                {
                    tinhtrang = 1;
                }
                int a = int.Parse(txthocphi.Text);
                if (rbhothuong.Checked)
                {
                    hogiadinh = "Hộ thường";
                }
                if (rbhocanngheo.Checked)
                {
                    hogiadinh = "Hộ cận nghèo";
                }
                if (rbhongheo.Checked)
                {
                    hogiadinh = "Hộ nghèo";
                }
                hp.themHocphi(mahs, hocphicoban, hogiadinh, tonghocphi, namhoc, tinhtrang);
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
            }
            QLHocPhi_Load(sender, e);
        }

        private void cbxmahs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mahs = cbxmahs.SelectedValue.ToString();
            Hocphi hp = new Hocphi();
            DataTable dt1 = new DataTable();
            dt1 = hp.Loadcbxhs(mahs);
            foreach (DataRow item in dt1.Rows)
            {
                txttenhs.Text = item["hotenhs"].ToString();

            }
            DataTable dt2 = new DataTable();
            dt2 = hp.Loadlop(mahs);
            foreach (DataRow item in dt2.Rows)
            {
                txtlop.Text = item["malop"].ToString();

            }
        }

        public void loadHocphi()
        {
            Phicoban pcb = new Phicoban();
            DataTable dt = pcb.showPhicb();
            cbxnamhoc.DataSource = dt;
            cbxnamhoc.DisplayMember = "namhoc";
            cbxnamhoc.ValueMember = "namhoc";
            string namhoc = cbxnamhoc.SelectedValue.ToString();
            Luong lh = new Luong();
            DataTable dt1 = new DataTable();
            dt1 = lh.Loadcbxnam(namhoc);
            foreach (DataRow item in dt1.Rows)
            {
                txthocphi.Text = item["hocphicoban"].ToString();
            }


        }

        private void cbxnamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string namhoc = cbxnamhoc.SelectedValue.ToString();
            Luong lh = new Luong();
            DataTable dt1 = new DataTable();
            dt1 = lh.Loadcbxnam(namhoc);
            foreach (DataRow item in dt1.Rows)
            {
                txthocphi.Text = item["hocphicoban"].ToString();
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txthocphi.Text);
            if(rbhothuong.Checked)
            {
                txttonghp.Text = a.ToString();
            }
            if(rbhocanngheo.Checked)
            {
                txttonghp.Text = (a * 0.5).ToString();
            }
            if(rbhongheo.Checked)
            {
                txttonghp.Text = 0.ToString();
            }    
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                int mathanhtoan = int.Parse(txtmathanhtoan.Text.ToString());
                int tinhtrang = 0;
                string mahs = cbxmahs.SelectedValue.ToString();
                int hocphicoban = Int32.Parse(txthocphi.Text);
                string namhoc = cbxnamhoc.SelectedValue.ToString();
                int tonghocphi = int.Parse(txttonghp.Text.ToString());
                string hogiadinh = "";
                if (rbchuahoanthanh.Checked)
                {
                    tinhtrang = 0;
                }
                if (rbhoanthanh.Checked)
                {
                    tinhtrang = 1;
                }
                if (rbhothuong.Checked) hogiadinh = "Ho thuongg";
                if (rbhocanngheo.Checked) hogiadinh = "Ho can ngheo";
                if (rbhongheo.Checked) hogiadinh = "Ho ngheo";
                hp.suaHocphi(mathanhtoan, mahs, hocphicoban, hogiadinh, tonghocphi, namhoc, tinhtrang);
            }
            //catch (SqlException ex)
            //{
            //    if (ex.Message.Contains("PRIMARY KEY"))
            //    {
            //        MessageBox.Show("Không được trùng học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            catch (FormatException)
            {
                MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
            }
            QLHocPhi_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mahs = cbxmahs.SelectedValue.ToString();
            string namhoc = cbxnamhoc.SelectedValue.ToString();
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                hp.xoaHocphi(mahs,namhoc);
                QLHocPhi_Load(sender, e);

            }
        }
        int row;
        private void dgvhienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txtmathanhtoan.Text = dgvhienthi.Rows[row].Cells[0].Value.ToString();
                cbxmahs.Text = dgvhienthi.Rows[row].Cells[1].Value.ToString();
                cbxnamhoc.Text = dgvhienthi.Rows[row].Cells[7].Value.ToString();
                txttonghp.Text = dgvhienthi.Rows[row].Cells[6].Value.ToString();


            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            DataTable dt = hp.Timkiem(timkiem);
            if (dt.Rows.Count > 0)
            {
                dgvhienthi.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm kiếm được kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
