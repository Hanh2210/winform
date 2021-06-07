namespace QLMAMNON.GUI
{
    partial class QLGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLGiaoVien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxtengiaovien = new System.Windows.Forms.ComboBox();
            this.cbxtenlop = new System.Windows.Forms.ComboBox();
            this.cbxtenkhoi = new System.Windows.Forms.ComboBox();
            this.cbxtennamhoc = new System.Windows.Forms.ComboBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.hotennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennamhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phân Công Giảng Dạy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên giáo viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên khối";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên năm học";
            // 
            // cbxtengiaovien
            // 
            this.cbxtengiaovien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxtengiaovien.FormattingEnabled = true;
            this.cbxtengiaovien.Location = new System.Drawing.Point(291, 60);
            this.cbxtengiaovien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxtengiaovien.Name = "cbxtengiaovien";
            this.cbxtengiaovien.Size = new System.Drawing.Size(248, 24);
            this.cbxtengiaovien.TabIndex = 1;
            // 
            // cbxtenlop
            // 
            this.cbxtenlop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxtenlop.FormattingEnabled = true;
            this.cbxtenlop.Location = new System.Drawing.Point(291, 105);
            this.cbxtenlop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxtenlop.Name = "cbxtenlop";
            this.cbxtenlop.Size = new System.Drawing.Size(248, 24);
            this.cbxtenlop.TabIndex = 2;
            // 
            // cbxtenkhoi
            // 
            this.cbxtenkhoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxtenkhoi.FormattingEnabled = true;
            this.cbxtenkhoi.Location = new System.Drawing.Point(291, 151);
            this.cbxtenkhoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxtenkhoi.Name = "cbxtenkhoi";
            this.cbxtenkhoi.Size = new System.Drawing.Size(248, 24);
            this.cbxtenkhoi.TabIndex = 3;
            // 
            // cbxtennamhoc
            // 
            this.cbxtennamhoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxtennamhoc.FormattingEnabled = true;
            this.cbxtennamhoc.Location = new System.Drawing.Point(291, 198);
            this.cbxtennamhoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxtennamhoc.Name = "cbxtennamhoc";
            this.cbxtennamhoc.Size = new System.Drawing.Size(248, 24);
            this.cbxtennamhoc.TabIndex = 4;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.Location = new System.Drawing.Point(587, 238);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 54);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(142, 241);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 54);
            this.btnThem.TabIndex = 6;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(249, 238);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 54);
            this.btnSua.TabIndex = 7;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(363, 240);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 55);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(472, 256);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(100, 22);
            this.txtTimkiem.TabIndex = 9;
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotennv,
            this.tenlop,
            this.tenkhoi,
            this.tennamhoc});
            this.dgvHienThi.Location = new System.Drawing.Point(91, 297);
            this.dgvHienThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.RowHeadersWidth = 51;
            this.dgvHienThi.RowTemplate.Height = 24;
            this.dgvHienThi.Size = new System.Drawing.Size(571, 150);
            this.dgvHienThi.TabIndex = 14;
            // 
            // hotennv
            // 
            this.hotennv.DataPropertyName = "hotennv";
            this.hotennv.HeaderText = "Tên giáo viên";
            this.hotennv.MinimumWidth = 6;
            this.hotennv.Name = "hotennv";
            this.hotennv.Width = 125;
            // 
            // tenlop
            // 
            this.tenlop.DataPropertyName = "tenlop";
            this.tenlop.HeaderText = "Tên lớp";
            this.tenlop.MinimumWidth = 6;
            this.tenlop.Name = "tenlop";
            this.tenlop.Width = 125;
            // 
            // tenkhoi
            // 
            this.tenkhoi.DataPropertyName = "tenkhoi";
            this.tenkhoi.HeaderText = "Tên khối";
            this.tenkhoi.MinimumWidth = 6;
            this.tenkhoi.Name = "tenkhoi";
            this.tenkhoi.Width = 125;
            // 
            // tennamhoc
            // 
            this.tennamhoc.DataPropertyName = "tennamhoc";
            this.tennamhoc.HeaderText = "Tên năm học";
            this.tennamhoc.MinimumWidth = 6;
            this.tennamhoc.Name = "tennamhoc";
            this.tennamhoc.Width = 125;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(665, 16);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 60);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // QLGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(752, 478);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvHienThi);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.cbxtennamhoc);
            this.Controls.Add(this.cbxtenkhoi);
            this.Controls.Add(this.cbxtenlop);
            this.Controls.Add(this.cbxtengiaovien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLGiaoVien";
            this.Load += new System.EventHandler(this.QLGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxtengiaovien;
        private System.Windows.Forms.ComboBox cbxtenlop;
        private System.Windows.Forms.ComboBox cbxtenkhoi;
        private System.Windows.Forms.ComboBox cbxtennamhoc;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennamhoc;
        private System.Windows.Forms.Button btnThoat;
    }
}