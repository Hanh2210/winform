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
    public partial class QLLuong : Form
    {
        Luong luong = new Luong();


        public double nganquy = 1000000;
        public QLLuong()
        {
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                cbxthang.Items.Add(i);
            }
        }

        public void loadNhanvien()
        {

            NhanvienBLL nv = new NhanvienBLL();
            DataTable dt = nv.shownhanvien();
            cbxmanv.DataSource = dt;
            cbxmanv.DisplayMember = "manv";
            cbxmanv.ValueMember = "manv";
            string manv = cbxmanv.SelectedValue.ToString();
            Luong lh = new Luong();
            DataTable dt1 = new DataTable();
            dt1 = lh.LoadcbxLuong(manv);  
            foreach (DataRow item in dt1.Rows)
            {
            txttennv.Text = item["hotennv"].ToString();
            txtchucvu.Text = item["chucvu"].ToString();

            }
            //for (int i = 1; i <= 12; i++)
            //{
            //    cbxthang.Items.Add(i);
            //}
            //txttennv.Text = dt.Rows[0]["hotennv"].ToString().Trim();
        }

        private void cbxmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string manv = cbxmanv.SelectedValue.ToString();
            Luong lh = new Luong();
            DataTable dt1 = new DataTable();
            dt1 = lh.LoadcbxLuong(manv);
            foreach (DataRow item in dt1.Rows)
            {
                txttennv.Text = item["hotennv"].ToString();
                txtchucvu.Text = item["chucvu"].ToString();

            }
        }
        
        public void loadLuongcoban()
        {
            Phicoban pcb = new Phicoban();
            DataTable dt = pcb.showPhicb();
            cbxnam.DataSource = dt;
            cbxnam.DisplayMember = "namhoc";
            cbxnam.ValueMember = "namhoc";
            string namhoc = cbxnam.SelectedValue.ToString();
            Luong lh = new Luong();
            DataTable dt1 = new DataTable();
            dt1 = lh.Loadcbxnam(namhoc);
            foreach (DataRow item in dt1.Rows)
            {
                txtluongcb.Text = item["luongcoban"].ToString();
            }


        }
        private void QLLuong_Load(object sender, EventArgs e)
        {
            loadNhanvien();
            loadLuongcoban();
            DataTable dt = new DataTable();
            dt = luong.showLuong();
            dgvhienthiluong.DataSource = dt;
        }

        public double Tinhnganquy()
        {
            nganquy += double.Parse(txttongluong.Text);
            return nganquy;
        }

        public int xet(string tennv, string tt, string nh)
        {
            int k = 0;
            for (int i = 0; i < dgvhienthiluong.Rows.Count -1; i++)
            {
                string xet1 = dgvhienthiluong.Rows[i].Cells[2].Value.ToString();
                string xet2 = dgvhienthiluong.Rows[i].Cells[9].Value.ToString();
                string xet3 = dgvhienthiluong.Rows[i].Cells[10].Value.ToString();
                if ( xet1 == tennv && xet2 == tt && xet3 == nh)
                {
                    k = 1;
                }
                else
                {
                    k = 0;
                }
            }
            return k;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                string tt = cbxthang.Text;
                string nh = cbxnam.Text;
                int tinhtrang = 0;
                string manv = cbxmanv.SelectedValue.ToString();
                int thang = Int32.Parse(cbxthang.Text);
                string namhoc = cbxnam.SelectedValue.ToString();
                int luongcoban = int.Parse(txtluongcb.Text.ToString());
                int phucap = int.Parse(txtphucap.Text.ToString());
                int thuong = int.Parse(txtthuong.Text.ToString());
                int kyluat = int.Parse(txttru.Text.ToString());
                int tongluong = int.Parse(txttongluong.Text.ToString());
                string ghichu = txtghichu.Text.ToString();
                string tennv = txttennv.Text;
                if (rbchuahoanthanh.Checked)
                {
                    tinhtrang = 0;
                }
                if (rbhoanthanh.Checked)
                {
                    tinhtrang = 1;
                }
                int k = xet(tennv, tt, nh);
                txtnganquy.Text = Tinhnganquy().ToString();
                
                if (k == 0)
                {
                    luong.themLuong(manv, luongcoban, phucap, thuong, kyluat, tongluong, thang, namhoc, tinhtrang, ghichu);
                }
                else if(k==1)
                {
                    MessageBox.Show("Nhân viên "+tennv+" đã có lương tháng "+tt+" năm "+nh+"", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            catch (FormatException)
            {
                MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
            }
            QLLuong_Load(sender, e);
        }

        public void Nhap(out int lcb, out int lpc, out int thuong, out int tru)
        {
            
            lcb = int.Parse(txtluongcb.Text);
            lpc = int.Parse(txtphucap.Text);
            thuong = int.Parse(txtthuong.Text);
            tru = int.Parse(txttru.Text);
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {

            int lcb, lpc, thuong, tru;
            Luong x1 = new Luong();
            Nhap(out lcb, out lpc, out thuong, out tru);
           
            txttongluong.Text = x1.tinhLuong(lcb, lpc, thuong, tru).ToString();
            
            
        }

        private void cbxnam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string namhoc = cbxnam.SelectedValue.ToString();
            Luong lh = new Luong();
            DataTable dt1 = new DataTable();
            dt1 = lh.Loadcbxnam(namhoc);
            foreach (DataRow item in dt1.Rows)
            {
                txtluongcb.Text = item["luongcoban"].ToString();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                int mathanhtoan = int.Parse(txtmathanhtoan.Text.ToString());           
                int tinhtrang = 0;
                string manv = cbxmanv.SelectedValue.ToString();
                int thang = int.Parse(cbxthang.Text);
                string namhoc = cbxnam.SelectedValue.ToString();
                int luongcoban = int.Parse(txtluongcb.Text.ToString());
                int phucap = int.Parse(txtphucap.Text.ToString());
                int thuong = int.Parse(txtthuong.Text.ToString());
                int kyluat = int.Parse(txttru.Text.ToString());
                int tongluong = int.Parse(txttongluong.Text.ToString());
                string ghichu = txtghichu.Text.ToString();
                if (rbchuahoanthanh.Checked)
                {
                    tinhtrang = 0;
                }
                if (rbhoanthanh.Checked)
                {
                    tinhtrang = 1;
                }
                luong.suaLuong(mathanhtoan, manv, luongcoban, phucap, thuong, kyluat, tongluong, thang, namhoc, tinhtrang, ghichu);
            }
            //catch (SqlException ex)
            //{
            //    if (ex.Message.Contains("PRIMARY KEY"))
            //    {
            //        MessageBox.Show("Không được trùng giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            catch (FormatException)
            {
                MessageBox.Show("Bạn đã nhập sai dữ liệu", "Thông báo");
            }
            QLLuong_Load(sender, e);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            
            {
                int thang = int.Parse(cbxthang.Text);
                string manv = cbxmanv.SelectedValue.ToString();
                string namhoc = cbxnam.SelectedValue.ToString();
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    luong.xoaLuong(manv, thang, namhoc);
                    QLLuong_Load(sender, e);

                }
            }
        }
        int row;
        private void dgvhienthiluong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row >= 0)
            {
                txtmathanhtoan.Text = dgvhienthiluong.Rows[row].Cells[0].Value.ToString();
                cbxmanv.Text = dgvhienthiluong.Rows[row].Cells[1].Value.ToString();
                cbxthang.Text = dgvhienthiluong.Rows[row].Cells[9].Value.ToString();
                txtphucap.Text = dgvhienthiluong.Rows[row].Cells[5].Value.ToString();
                txtthuong.Text = dgvhienthiluong.Rows[row].Cells[6].Value.ToString();
                txttru.Text = dgvhienthiluong.Rows[row].Cells[7].Value.ToString();
                txttongluong.Text = dgvhienthiluong.Rows[row].Cells[8].Value.ToString();
                txtghichu.Text = dgvhienthiluong.Rows[row].Cells[12].Value.ToString();
               
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string timkiem = txtTimkiem.Text;
            DataTable dt = luong.Timkiem(timkiem);
            if (dt.Rows.Count > 0)
            {
                dgvhienthiluong.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm kiếm được kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnxuatbc_Click(object sender, EventArgs e)
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
            for (int i = 1; i < dgvhienthiluong.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvhienthiluong.Columns[i - 1].HeaderText;
            }
            // lưu trữ từng giá trị hàng và cột vào trang tính excel   
            for (int i = 0; i < dgvhienthiluong.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvhienthiluong.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvhienthiluong.Rows[i].Cells[j].Value.ToString();
                }
            }
            // lưu ứng dụng 
            //workbook.SaveAs("D:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Thoát khỏi ứng dụng  
            //app.Quit();
        }

        //private void loadDataCollection()
        //{
        //    cbxmanv.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //}
    }
}
