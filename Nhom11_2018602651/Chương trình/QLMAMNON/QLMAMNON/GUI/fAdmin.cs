using QLMAMNON.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMAMNON
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            CenterToScreen();
            design();
        }

        private void design()
        {
            panelHocsinh.Visible = false;
            panelNhanvien.Visible = false;
            panelNienkhoa.Visible = false;
            panelThuchi.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelHocsinh.Visible == true)
                panelHocsinh.Visible = false;
            if (panelNhanvien.Visible == true)
                panelNhanvien.Visible = false;
            if (panelNienkhoa.Visible == true)
                panelNienkhoa.Visible = false;
            if (panelThuchi.Visible == true)
                panelThuchi.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void fAdmin_Load(object sender, EventArgs e)
        {
            
        }

 

      
        #region MenuNhanVien
        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            showSubmenu(panelNhanvien);
        }

        private void btnQuanlynv_Click(object sender, EventArgs e)
        {
            openChildForm(new QLNhanVien());
            hideSubmenu();
        }

        private void btnPhancong_Click(object sender, EventArgs e)
        {
            openChildForm(new QLGiaoVien());
            hideSubmenu();
        }
        #endregion
        #region MenuHocSinh
        private void btnhocsinh_Click(object sender, EventArgs e)
        {
            showSubmenu(panelHocsinh);
        }
        private void btnqlhocsinh_Click(object sender, EventArgs e)
        {
            openChildForm(new QLHocSinh());
            hideSubmenu();
        }

        private void btnphanlop_Click(object sender, EventArgs e)
        {
            openChildForm(new QLLopHoc());
            hideSubmenu();
        }
        #endregion
        #region MenuNienkhoa
        private void btnNienkhoa_Click(object sender, EventArgs e)
        { 
            showSubmenu(panelNienkhoa);
        }

        private void btnqlNam_Click(object sender, EventArgs e)
        {
            openChildForm(new QLNamHoc());
            hideSubmenu();
        }

        private void btnqlKhoi_Click(object sender, EventArgs e)
        {
            openChildForm(new QLKhoiHoc());
            hideSubmenu();
        }

        private void btnqlLop_Click(object sender, EventArgs e)
        {
            openChildForm(new QLLop());
            hideSubmenu();
        }
        #endregion
        #region MenuThuChi
        private void btnThuchi_Click(object sender, EventArgs e)
        {
            showSubmenu(panelThuchi);
        }

        private void btnluongnv_Click(object sender, EventArgs e)
        {
            openChildForm(new QLLuong());
            hideSubmenu();
        }

        private void btnhocphi_Click(object sender, EventArgs e)
        {
            openChildForm(new QLHocPhi());
            hideSubmenu();
        }

        private void btnPhicoban_Click_1(object sender, EventArgs e)
        {
            openChildForm(new QLPhicoban());
            hideSubmenu();
        }

        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new QLTaiKhoan());
            hideSubmenu();
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
                
            }
        }

        private void btnfMain_Click(object sender, EventArgs e)
        {
            
            //fAdmin_Load(sender, e);
            //this.Close();
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            openChildForm(new XuatBaoCao());
            hideSubmenu();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
