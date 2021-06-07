
namespace QLMAMNON.GUI
{
    partial class fNhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhanvien));
            this.btnfMain = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnout = new System.Windows.Forms.Button();
            this.btnThuchi = new System.Windows.Forms.Button();
            this.btnhocphi = new System.Windows.Forms.Button();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.panelThuchi = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panelThuchi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnfMain
            // 
            this.btnfMain.FlatAppearance.BorderSize = 0;
            this.btnfMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfMain.Image = ((System.Drawing.Image)(resources.GetObject("btnfMain.Image")));
            this.btnfMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfMain.Location = new System.Drawing.Point(91, 4);
            this.btnfMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnfMain.Name = "btnfMain";
            this.btnfMain.Size = new System.Drawing.Size(96, 85);
            this.btnfMain.TabIndex = 1;
            this.btnfMain.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(240, 624);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1208, 90);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnfMain);
            this.panel2.Controls.Add(this.btnout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 100);
            this.panel2.TabIndex = 4;
            // 
            // btnout
            // 
            this.btnout.FlatAppearance.BorderSize = 0;
            this.btnout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnout.Image = ((System.Drawing.Image)(resources.GetObject("btnout.Image")));
            this.btnout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnout.Location = new System.Drawing.Point(16, 27);
            this.btnout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(67, 62);
            this.btnout.TabIndex = 0;
            this.btnout.UseVisualStyleBackColor = true;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // btnThuchi
            // 
            this.btnThuchi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThuchi.FlatAppearance.BorderSize = 0;
            this.btnThuchi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuchi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThuchi.Image = ((System.Drawing.Image)(resources.GetObject("btnThuchi.Image")));
            this.btnThuchi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThuchi.Location = new System.Drawing.Point(0, 100);
            this.btnThuchi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThuchi.Name = "btnThuchi";
            this.btnThuchi.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnThuchi.Size = new System.Drawing.Size(240, 37);
            this.btnThuchi.TabIndex = 10;
            this.btnThuchi.Text = "THU CHI";
            this.btnThuchi.UseVisualStyleBackColor = true;
            this.btnThuchi.Click += new System.EventHandler(this.btnThuchi_Click);
            // 
            // btnhocphi
            // 
            this.btnhocphi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhocphi.FlatAppearance.BorderSize = 0;
            this.btnhocphi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhocphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhocphi.ForeColor = System.Drawing.Color.LightGray;
            this.btnhocphi.Location = new System.Drawing.Point(0, 0);
            this.btnhocphi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhocphi.Name = "btnhocphi";
            this.btnhocphi.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnhocphi.Size = new System.Drawing.Size(240, 37);
            this.btnhocphi.TabIndex = 6;
            this.btnhocphi.Text = "Quản Lý Học Phí";
            this.btnhocphi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhocphi.UseVisualStyleBackColor = true;
            this.btnhocphi.Click += new System.EventHandler(this.btnhocphi_Click);
            // 
            // btnBaocao
            // 
            this.btnBaocao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaocao.FlatAppearance.BorderSize = 0;
            this.btnBaocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaocao.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBaocao.Image = ((System.Drawing.Image)(resources.GetObject("btnBaocao.Image")));
            this.btnBaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaocao.Location = new System.Drawing.Point(0, 260);
            this.btnBaocao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnBaocao.Size = new System.Drawing.Size(240, 37);
            this.btnBaocao.TabIndex = 13;
            this.btnBaocao.Text = "BÁO CÁO";
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // panelThuchi
            // 
            this.panelThuchi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelThuchi.Controls.Add(this.btnhocphi);
            this.panelThuchi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThuchi.Location = new System.Drawing.Point(0, 137);
            this.panelThuchi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelThuchi.Name = "panelThuchi";
            this.panelThuchi.Size = new System.Drawing.Size(240, 123);
            this.panelThuchi.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.btnBaocao);
            this.panel1.Controls.Add(this.panelThuchi);
            this.panel1.Controls.Add(this.btnThuchi);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 714);
            this.panel1.TabIndex = 8;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.ForeColor = System.Drawing.Color.Black;
            this.panelChildForm.Location = new System.Drawing.Point(240, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1800, 1000);
            this.panelChildForm.TabIndex = 10;
            // 
            // fNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 714);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelChildForm);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fNhanvien";
            this.Text = "fNhanvien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panelThuchi.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnout;
        private System.Windows.Forms.Button btnThuchi;
        private System.Windows.Forms.Button btnhocphi;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Panel panelThuchi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChildForm;
    }
}