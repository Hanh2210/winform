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


namespace QLMAMNON
{
    public partial class QLNhanVien : Form
    {
        NhanvienBLL nv = new NhanvienBLL();
        public QLNhanVien()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            List<nhanvien> nv = BLL.NhanvienBLL.Getnhanvien();
            dgrNhanvien.DataSource = nv;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //thêm
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtmanhanvien.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txthoten.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống họ tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtchucvu.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtchungminhthu.Text == string.Empty  )
            {
                MessageBox.Show("Không được để trống chứng minh nhân dân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtchungminhthu.TextLength < 10)
            {
                MessageBox.Show("Chứng minh nhân dân phải nhiều hơn 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtdantoc.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtdiachi.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string manv = txtmanhanvien.Text;
                    string hotennv = txthoten.Text;
                    string gioitinh = "";
                    if (rdbnam.Checked)
                        gioitinh = "Nam";
                    if (rdbnu.Checked)
                        gioitinh = "Nữ";
                    DateTime ngaysinh = dtpngaysinh.Value;
                    string chucvu = txtchucvu.Text;
                    string chungminhthu = txtchungminhthu.Text;
                    string dantoc = txtdantoc.Text;
                    string sodienthoai = txtsdt.Text;
                    string diachi = txtdiachi.Text;
                    nv.ThemNhanvien(manv, hotennv, gioitinh, ngaysinh, chucvu, chungminhthu, dantoc, sodienthoai, diachi);
                    MessageBox.Show("Thêm thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    QLNhanVien_Load(sender, e);
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Không được trùng Mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
                }
            }
        }


        //sửa
        private void button3_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < dgrNhanvien.Rows.Count - 1; i++)
            {
                if (txtmanhanvien.Text != dgrNhanvien.Rows[i].Cells[0].Value.ToString())
                {
                    k = 1;
                }
            }
            if (txtmanhanvien.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txthoten.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống họ tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtchucvu.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtchungminhthu.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống chứng minh nhân dân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtchungminhthu.TextLength < 10)
            {
                MessageBox.Show("Chứng minh nhân dân phải nhiều hơn 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtdantoc.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtdiachi.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string manv = txtmanhanvien.Text;
                    string hotennv = txthoten.Text;
                    string gioitinh = "";
                    if (rdbnam.Checked)
                        gioitinh = "Nam";
                    if (rdbnu.Checked)
                        gioitinh = "Nữ";
                    DateTime ngaysinh = dtpngaysinh.Value;
                    string chucvu = txtchucvu.Text;
                    string chungminhthu = txtchungminhthu.Text;
                    string dantoc = txtdantoc.Text;
                    string sodienthoai = txtsdt.Text;
                    string diachi = txtdiachi.Text;
                    nv.SuaNhanvien(manv, hotennv, gioitinh, ngaysinh, chucvu, chungminhthu, dantoc, sodienthoai, diachi);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QLNhanVien_Load(sender, e);
                }
                
                catch (FormatException)
                {
                    MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
                }
                catch (Exception)
                {
                    if (k == 1)
                    {
                        MessageBox.Show("Không được thay đổi mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        //xóa 

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmanhanvien.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string manv = txtmanhanvien.Text;
                    DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        nv.XoaNhanvien(manv);
                        QLNhanVien_Load(sender, e);
                        txtmanhanvien.Clear();
                        txthoten.Clear();
                        txtchucvu.Clear();
                        txtchungminhthu.Clear();
                        txtdantoc.Clear();
                        txtdiachi.Clear();
                        txtsdt.Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nhân viên đang phụ trách lớp, không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //tìm kiếm
        private void button1_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            List<nhanvien> nv = BLL.NhanvienBLL.Timkiemnhanvien(timkiem);
            if (nv.Count > 0)
            {
                dgrNhanvien.DataSource = nv;
            }
            else
            {
                MessageBox.Show("Không tìm kiếm được kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        int row;
        private void dgrNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txtmanhanvien.Text = dgrNhanvien.Rows[row].Cells[0].Value.ToString();
                txthoten.Text = dgrNhanvien.Rows[row].Cells[1].Value.ToString();
                if (dgrNhanvien.Rows[row].Cells[2].Value.Equals("Nam"))
                {
                    rdbnam.Checked = true;
                }
                else rdbnu.Checked = true;
                dtpngaysinh.Text = dgrNhanvien.Rows[row].Cells[3].Value.ToString();
                txtchucvu.Text = dgrNhanvien.Rows[row].Cells[4].Value.ToString();
                txtchungminhthu.Text = dgrNhanvien.Rows[row].Cells[5].Value.ToString();
                txtdantoc.Text = dgrNhanvien.Rows[row].Cells[6].Value.ToString();
                txtsdt.Text = dgrNhanvien.Rows[row].Cells[7].Value.ToString();
                txtdiachi.Text = dgrNhanvien.Rows[row].Cells[8].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
