
namespace QLMAMNON.GUI
{
    partial class XuatBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XuatBaoCao));
            this.tabBaocao = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.btnXuatbc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hotennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennamhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabBaocao.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBaocao
            // 
            this.tabBaocao.Controls.Add(this.tabPage1);
            this.tabBaocao.Controls.Add(this.tabPage2);
            this.tabBaocao.Controls.Add(this.tabPage3);
            this.tabBaocao.Location = new System.Drawing.Point(12, 12);
            this.tabBaocao.Name = "tabBaocao";
            this.tabBaocao.SelectedIndex = 0;
            this.tabBaocao.Size = new System.Drawing.Size(699, 291);
            this.tabBaocao.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.btnLoc);
            this.tabPage1.Controls.Add(this.txtLoc);
            this.tabPage1.Controls.Add(this.btnXuatbc);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(691, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phân công giạng dạy";
            // 
            // btnLoc
            // 
            this.btnLoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc.Image")));
            this.btnLoc.Location = new System.Drawing.Point(247, 195);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 44);
            this.btnLoc.TabIndex = 3;
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(123, 206);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(118, 26);
            this.txtLoc.TabIndex = 2;
            // 
            // btnXuatbc
            // 
            this.btnXuatbc.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatbc.Image")));
            this.btnXuatbc.Location = new System.Drawing.Point(402, 195);
            this.btnXuatbc.Name = "btnXuatbc";
            this.btnXuatbc.Size = new System.Drawing.Size(75, 44);
            this.btnXuatbc.TabIndex = 1;
            this.btnXuatbc.UseVisualStyleBackColor = true;
            this.btnXuatbc.Click += new System.EventHandler(this.btnXuatbc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotennv,
            this.tenlop,
            this.tenkhoi,
            this.tennamhoc});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(685, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hotennv
            // 
            this.hotennv.DataPropertyName = "hotennv";
            this.hotennv.HeaderText = "Họ tên giáo viên";
            this.hotennv.MinimumWidth = 6;
            this.hotennv.Name = "hotennv";
            this.hotennv.Width = 200;
            // 
            // tenlop
            // 
            this.tenlop.DataPropertyName = "tenlop";
            this.tenlop.HeaderText = "Lớp";
            this.tenlop.MinimumWidth = 6;
            this.tenlop.Name = "tenlop";
            this.tenlop.Width = 125;
            // 
            // tenkhoi
            // 
            this.tenkhoi.DataPropertyName = "tenkhoi";
            this.tenkhoi.HeaderText = "Khối";
            this.tenkhoi.MinimumWidth = 6;
            this.tenkhoi.Name = "tenkhoi";
            this.tenkhoi.Width = 125;
            // 
            // tennamhoc
            // 
            this.tennamhoc.DataPropertyName = "tennamhoc";
            this.tennamhoc.HeaderText = "Năm học";
            this.tennamhoc.MinimumWidth = 6;
            this.tennamhoc.Name = "tennamhoc";
            this.tennamhoc.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(691, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Học sinh";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(691, 259);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // XuatBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(752, 345);
            this.Controls.Add(this.tabBaocao);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XuatBaoCao";
            this.Text = "XuatBaoCao";
            this.tabBaocao.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBaocao;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnXuatbc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennamhoc;
    }
}