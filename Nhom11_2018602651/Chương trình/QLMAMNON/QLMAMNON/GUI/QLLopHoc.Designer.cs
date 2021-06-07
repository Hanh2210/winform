namespace QLMAMNON.GUI
{
    partial class QLLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLLopHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxtenlop = new System.Windows.Forms.ComboBox();
            this.cbxhoten = new System.Windows.Forms.ComboBox();
            this.cbxtennamhoc = new System.Windows.Forms.ComboBox();
            this.cbxtenkhoi = new System.Windows.Forms.ComboBox();
            this.dgvHienthi = new System.Windows.Forms.DataGridView();
            this.hotenhs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennamhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khối";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên học sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phân Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên năm học";
            // 
            // cbxtenlop
            // 
            this.cbxtenlop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxtenlop.FormattingEnabled = true;
            this.cbxtenlop.Location = new System.Drawing.Point(340, 88);
            this.cbxtenlop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxtenlop.Name = "cbxtenlop";
            this.cbxtenlop.Size = new System.Drawing.Size(236, 24);
            this.cbxtenlop.TabIndex = 2;
            // 
            // cbxhoten
            // 
            this.cbxhoten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxhoten.FormattingEnabled = true;
            this.cbxhoten.Location = new System.Drawing.Point(340, 47);
            this.cbxhoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxhoten.Name = "cbxhoten";
            this.cbxhoten.Size = new System.Drawing.Size(236, 24);
            this.cbxhoten.TabIndex = 1;
            // 
            // cbxtennamhoc
            // 
            this.cbxtennamhoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxtennamhoc.FormattingEnabled = true;
            this.cbxtennamhoc.Location = new System.Drawing.Point(340, 171);
            this.cbxtennamhoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxtennamhoc.Name = "cbxtennamhoc";
            this.cbxtennamhoc.Size = new System.Drawing.Size(236, 24);
            this.cbxtennamhoc.TabIndex = 4;
            // 
            // cbxtenkhoi
            // 
            this.cbxtenkhoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxtenkhoi.FormattingEnabled = true;
            this.cbxtenkhoi.Location = new System.Drawing.Point(340, 130);
            this.cbxtenkhoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxtenkhoi.Name = "cbxtenkhoi";
            this.cbxtenkhoi.Size = new System.Drawing.Size(236, 24);
            this.cbxtenkhoi.TabIndex = 3;
            // 
            // dgvHienthi
            // 
            this.dgvHienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienthi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotenhs,
            this.tenlop,
            this.tenkhoi,
            this.tennamhoc});
            this.dgvHienthi.Location = new System.Drawing.Point(132, 268);
            this.dgvHienthi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHienthi.Name = "dgvHienthi";
            this.dgvHienthi.RowHeadersWidth = 51;
            this.dgvHienthi.RowTemplate.Height = 24;
            this.dgvHienthi.Size = new System.Drawing.Size(553, 150);
            this.dgvHienthi.TabIndex = 8;
            // 
            // hotenhs
            // 
            this.hotenhs.DataPropertyName = "hotenhs";
            this.hotenhs.HeaderText = "Tên học sinh";
            this.hotenhs.MinimumWidth = 6;
            this.hotenhs.Name = "hotenhs";
            this.hotenhs.Width = 125;
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
            // btnTimkiem
            // 
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.Location = new System.Drawing.Point(610, 205);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 41);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(132, 205);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 41);
            this.btnThem.TabIndex = 7;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(254, 205);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 41);
            this.btnSua.TabIndex = 8;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(374, 205);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 41);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(489, 214);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(115, 22);
            this.txttimkiem.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(729, 20);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 43);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(713, 411);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 15;
            this.btnXuat.Text = "Xuất báo cáo";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // QLLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(831, 481);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.dgvHienthi);
            this.Controls.Add(this.cbxtenkhoi);
            this.Controls.Add(this.cbxtennamhoc);
            this.Controls.Add(this.cbxhoten);
            this.Controls.Add(this.cbxtenlop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLLopHoc";
            this.Load += new System.EventHandler(this.QLLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxtenlop;
        private System.Windows.Forms.ComboBox cbxhoten;
        private System.Windows.Forms.ComboBox cbxtennamhoc;
        private System.Windows.Forms.ComboBox cbxtenkhoi;
        private System.Windows.Forms.DataGridView dgvHienthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennamhoc;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuat;
    }
}