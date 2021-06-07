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
    public partial class QLLopHoc : Form
    {
        Lophoc lhs = new Lophoc();
        public QLLopHoc()
        {
            InitializeComponent();
        }

        public void LoadHocsinh()
        {
            Hocsinh hs = new Hocsinh();
            DataTable dt = hs.showHocsinh();
            cbxhoten.DataSource = dt;
            cbxhoten.DisplayMember = "hotenhs";
            cbxhoten.ValueMember = "mahs";
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
        private void QLLopHoc_Load(object sender, EventArgs e)
        {
            LoadHocsinh();
            LoadKhoi();
            LoadLop();
            LoadNam();
            DataTable dt = new DataTable();
            dt = lhs.showLophoc();
            dgvHienthi.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
                try
                {
                    string hotenhs = cbxhoten.SelectedValue.ToString();
                    string tenlop = cbxtenlop.SelectedValue.ToString();
                    string tenkhoi = cbxtenkhoi.SelectedValue.ToString();
                    string tennamhoc = cbxtennamhoc.SelectedValue.ToString();
                    lhs.Themlophoc(hotenhs, tenlop, tenkhoi, tennamhoc);
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
                }
                QLLopHoc_Load(sender, e);
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string hotenhs = cbxhoten.SelectedValue.ToString();
                string tenlop = cbxtenlop.SelectedValue.ToString();
                string tenkhoi = cbxtenkhoi.SelectedValue.ToString();
                string tennamhoc = cbxtennamhoc.SelectedValue.ToString();
                lhs.Sualophoc(hotenhs, tenlop, tenkhoi, tennamhoc);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Không được trùng học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
            }
            QLLopHoc_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbxhoten.Text == string.Empty)
            {
                MessageBox.Show("Bạn phải chọn tên học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string mahs = cbxhoten.SelectedValue.ToString();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    lhs.Xoalophoc(mahs);
                    QLLopHoc_Load(sender, e);
                   
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;
            DataTable dt = lhs.Timkiem(timkiem);
            if (dt.Rows.Count > 0)
            {
                dgvHienthi.DataSource = dt;
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

        private void btnXuat_Click(object sender, EventArgs e)
        {
            // tạo ứng dụng Excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // tạo WorkBook mới trong ứng dụng Excel  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // tạo Excelsheet mới trong Workbook 
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // xem bảng excel đằng sau chương trình
            app.Visible = true;
            // lấy tham chiếu của trang tính đầu tiên. Theo mặc định, tên của nó là Sheet1.  
            // lưu trữ tham chiếu của nó đến trang tính
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // thay đổi tên của trang tính đang hoạt động  
            worksheet.Name = "Exported from gridview";
            // lưu trữ phần tiêu đề trong Excel    
            for (int i = 1; i < dgvHienthi.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvHienthi.Columns[i - 1].HeaderText;
            }
            // lưu trữ từng giá trị hàng và cột vào trang tính excel   
            for (int i = 0; i < dgvHienthi.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvHienthi.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvHienthi.Rows[i].Cells[j].Value.ToString();
                }
            }
            // lưu ứng dụng 
            //workbook.SaveAs("D:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Thoát khỏi ứng dụng  
            //app.Quit();

        }
    }
}
