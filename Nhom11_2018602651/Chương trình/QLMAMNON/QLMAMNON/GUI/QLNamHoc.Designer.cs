namespace QLMAMNON.GUI
{
    partial class QLNamHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLNamHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnamhoc = new System.Windows.Forms.TextBox();
            this.txttennamhoc = new System.Windows.Forms.TextBox();
            this.dtpngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.dtpngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.dgvnamhoc = new System.Windows.Forms.DataGridView();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.namhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennamhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnamhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý năm học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên năm học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày kết thúc";
            // 
            // txtnamhoc
            // 
            this.txtnamhoc.Location = new System.Drawing.Point(311, 63);
            this.txtnamhoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnamhoc.Name = "txtnamhoc";
            this.txtnamhoc.Size = new System.Drawing.Size(260, 22);
            this.txtnamhoc.TabIndex = 1;
            // 
            // txttennamhoc
            // 
            this.txttennamhoc.Location = new System.Drawing.Point(311, 99);
            this.txttennamhoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttennamhoc.Name = "txttennamhoc";
            this.txttennamhoc.Size = new System.Drawing.Size(260, 22);
            this.txttennamhoc.TabIndex = 2;
            // 
            // dtpngaybatdau
            // 
            this.dtpngaybatdau.Location = new System.Drawing.Point(311, 140);
            this.dtpngaybatdau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpngaybatdau.Name = "dtpngaybatdau";
            this.dtpngaybatdau.Size = new System.Drawing.Size(260, 22);
            this.dtpngaybatdau.TabIndex = 3;
            // 
            // dtpngayketthuc
            // 
            this.dtpngayketthuc.Location = new System.Drawing.Point(311, 182);
            this.dtpngayketthuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpngayketthuc.Name = "dtpngayketthuc";
            this.dtpngayketthuc.Size = new System.Drawing.Size(260, 22);
            this.dtpngayketthuc.TabIndex = 4;
            // 
            // dgvnamhoc
            // 
            this.dgvnamhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnamhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namhoc,
            this.tennamhoc,
            this.ngaybatdau,
            this.ngayketthuc});
            this.dgvnamhoc.Location = new System.Drawing.Point(118, 306);
            this.dgvnamhoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvnamhoc.Name = "dgvnamhoc";
            this.dgvnamhoc.RowHeadersWidth = 51;
            this.dgvnamhoc.RowTemplate.Height = 24;
            this.dgvnamhoc.Size = new System.Drawing.Size(606, 150);
            this.dgvnamhoc.TabIndex = 5;
            this.dgvnamhoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnamhoc_CellClick);
            this.dgvnamhoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnamhoc_CellContentClick);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(527, 254);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(116, 22);
            this.txttimkiem.TabIndex = 6;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.Location = new System.Drawing.Point(649, 244);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 40);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(176, 244);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 43);
            this.btnThem.TabIndex = 7;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(311, 244);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 43);
            this.btnSua.TabIndex = 8;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(446, 243);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 43);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(765, 11);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 42);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // namhoc
            // 
            this.namhoc.DataPropertyName = "namhoc";
            this.namhoc.HeaderText = "Năm học";
            this.namhoc.MinimumWidth = 6;
            this.namhoc.Name = "namhoc";
            this.namhoc.Width = 125;
            // 
            // tennamhoc
            // 
            this.tennamhoc.DataPropertyName = "tennamhoc";
            this.tennamhoc.HeaderText = "Tên năm học";
            this.tennamhoc.MinimumWidth = 6;
            this.tennamhoc.Name = "tennamhoc";
            this.tennamhoc.Width = 125;
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.DataPropertyName = "ngaybatdau";
            this.ngaybatdau.HeaderText = "Ngày bắt đầu";
            this.ngaybatdau.MinimumWidth = 6;
            this.ngaybatdau.Name = "ngaybatdau";
            this.ngaybatdau.Width = 150;
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.DataPropertyName = "ngayketthuc";
            this.ngayketthuc.HeaderText = "Ngày kết thúc";
            this.ngayketthuc.MinimumWidth = 6;
            this.ngayketthuc.Name = "ngayketthuc";
            this.ngayketthuc.Width = 150;
            // 
            // QLNamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(852, 486);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.dgvnamhoc);
            this.Controls.Add(this.dtpngayketthuc);
            this.Controls.Add(this.dtpngaybatdau);
            this.Controls.Add(this.txttennamhoc);
            this.Controls.Add(this.txtnamhoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLNamHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLNamHoc";
            this.Load += new System.EventHandler(this.QLNamHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnamhoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnamhoc;
        private System.Windows.Forms.TextBox txttennamhoc;
        private System.Windows.Forms.DateTimePicker dtpngaybatdau;
        private System.Windows.Forms.DateTimePicker dtpngayketthuc;
        private System.Windows.Forms.DataGridView dgvnamhoc;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn namhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennamhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthuc;
    }
}