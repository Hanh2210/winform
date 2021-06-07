namespace QLMAMNON.GUI
{
    partial class QLKhoiHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLKhoiHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenkhoi = new System.Windows.Forms.TextBox();
            this.cbxnamhoc = new System.Windows.Forms.ComboBox();
            this.dgvQLKhoihoc = new System.Windows.Forms.DataGridView();
            this.tenkhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKhoihoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Khối Học";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khối";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên năm học";
            // 
            // txttenkhoi
            // 
            this.txttenkhoi.Location = new System.Drawing.Point(286, 60);
            this.txttenkhoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenkhoi.Name = "txttenkhoi";
            this.txttenkhoi.Size = new System.Drawing.Size(220, 22);
            this.txttenkhoi.TabIndex = 1;
            // 
            // cbxnamhoc
            // 
            this.cbxnamhoc.FormattingEnabled = true;
            this.cbxnamhoc.Location = new System.Drawing.Point(286, 101);
            this.cbxnamhoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxnamhoc.Name = "cbxnamhoc";
            this.cbxnamhoc.Size = new System.Drawing.Size(220, 24);
            this.cbxnamhoc.TabIndex = 2;
            // 
            // dgvQLKhoihoc
            // 
            this.dgvQLKhoihoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLKhoihoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenkhoi,
            this.namhoc});
            this.dgvQLKhoihoc.Location = new System.Drawing.Point(201, 233);
            this.dgvQLKhoihoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQLKhoihoc.Name = "dgvQLKhoihoc";
            this.dgvQLKhoihoc.RowHeadersWidth = 51;
            this.dgvQLKhoihoc.RowTemplate.Height = 24;
            this.dgvQLKhoihoc.Size = new System.Drawing.Size(308, 150);
            this.dgvQLKhoihoc.TabIndex = 5;
            this.dgvQLKhoihoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLKhoihoc_CellClick);
            // 
            // tenkhoi
            // 
            this.tenkhoi.DataPropertyName = "tenkhoi";
            this.tenkhoi.HeaderText = "Tên khối";
            this.tenkhoi.MinimumWidth = 6;
            this.tenkhoi.Name = "tenkhoi";
            this.tenkhoi.Width = 125;
            // 
            // namhoc
            // 
            this.namhoc.DataPropertyName = "tennamhoc";
            this.namhoc.HeaderText = "Năm học";
            this.namhoc.MinimumWidth = 6;
            this.namhoc.Name = "namhoc";
            this.namhoc.Width = 125;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.Location = new System.Drawing.Point(431, 153);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 42);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(176, 153);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 42);
            this.btnThem.TabIndex = 5;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(269, 153);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 42);
            this.btnSua.TabIndex = 6;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(350, 153);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 42);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(397, 207);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(112, 22);
            this.txttimkiem.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(574, 9);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 37);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // QLKhoiHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(661, 415);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.dgvQLKhoihoc);
            this.Controls.Add(this.cbxnamhoc);
            this.Controls.Add(this.txttenkhoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLKhoiHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLKhoiHoc";
            this.Load += new System.EventHandler(this.QLKhoiHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKhoihoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenkhoi;
        private System.Windows.Forms.ComboBox cbxnamhoc;
        private System.Windows.Forms.DataGridView dgvQLKhoihoc;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn namhoc;
    }
}