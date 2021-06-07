using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMAMNON.GUI
{
    public partial class fNhanvien : Form
    {
        public fNhanvien()
        {
            InitializeComponent();
            CenterToScreen();
            design();
        }
        private void design()
        {
            //panelHocsinh.Visible = false;
            //panelNhanvien.Visible = false;
            //panelNienkhoa.Visible = false;
            panelThuchi.Visible = false;

        }

        private void hideSubmenu()
        {
            //if (panelHocsinh.Visible == true)
            //    panelHocsinh.Visible = false;
            //if (panelNhanvien.Visible == true)
            //    panelNhanvien.Visible = false;
            //if (panelNienkhoa.Visible == true)
            //    panelNienkhoa.Visible = false;
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

        private void btnThuchi_Click(object sender, EventArgs e)
        {
            showSubmenu(panelThuchi);
        }
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

        private void btnhocphi_Click(object sender, EventArgs e)
        {
            openChildForm(new QLHocPhi());
            hideSubmenu();
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            openChildForm(new XuatBaoCao());
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
    }
}
