namespace QLMAMNON.GUI
{
    partial class QLLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLLop));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.cbxtenkhoi = new System.Windows.Forms.ComboBox();
            this.cbxnamhoc = new System.Windows.Forms.ComboBox();
            this.dgvHienthi = new System.Windows.Forms.DataGridView();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khối";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Năm học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quản Lý Lớp";
            // 
            // txttenlop
            // 
            this.txttenlop.Location = new System.Drawing.Point(315, 100);
            this.txttenlop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(186, 22);
            this.txttenlop.TabIndex = 2;
            // 
            // txtmalop
            // 
            this.txtmalop.Location = new System.Drawing.Point(315, 60);
            this.txtmalop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(186, 22);
            this.txtmalop.TabIndex = 1;
            // 
            // cbxtenkhoi
            // 
            this.cbxtenkhoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxtenkhoi.FormattingEnabled = true;
            this.cbxtenkhoi.Location = new System.Drawing.Point(315, 144);
            this.cbxtenkhoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxtenkhoi.Name = "cbxtenkhoi";
            this.cbxtenkhoi.Size = new System.Drawing.Size(186, 24);
            this.cbxtenkhoi.TabIndex = 3;
            // 
            // cbxnamhoc
            // 
            this.cbxnamhoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxnamhoc.FormattingEnabled = true;
            this.cbxnamhoc.Location = new System.Drawing.Point(315, 187);
            this.cbxnamhoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxnamhoc.Name = "cbxnamhoc";
            this.cbxnamhoc.Size = new System.Drawing.Size(186, 24);
            this.cbxnamhoc.TabIndex = 4;
            // 
            // dgvHienthi
            // 
            this.dgvHienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienthi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malop,
            this.tenlop,
            this.tenkhoi,
            this.namhoc});
            this.dgvHienthi.Location = new System.Drawing.Point(130, 284);
            this.dgvHienthi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHienthi.Name = "dgvHienthi";
            this.dgvHienthi.RowHeadersWidth = 51;
            this.dgvHienthi.RowTemplate.Height = 24;
            this.dgvHienthi.Size = new System.Drawing.Size(560, 153);
            this.dgvHienthi.TabIndex = 11;
            this.dgvHienthi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienthi_CellClick);
            // 
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "Mã lớp";
            this.malop.MinimumWidth = 6;
            this.malop.Name = "malop";
            this.malop.Width = 125;
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
            // namhoc
            // 
            this.namhoc.DataPropertyName = "tennamhoc";
            this.namhoc.HeaderText = "Năm học";
            this.namhoc.MinimumWidth = 6;
            this.namhoc.Name = "namhoc";
            this.namhoc.Width = 125;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(615, 224);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 40);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(146, 224);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 40);
            this.btnThem.TabIndex = 6;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(269, 224);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 40);
            this.btnSua.TabIndex = 7;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(395, 224);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 40);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(512, 242);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(99, 22);
            this.txttimkiem.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(713, 9);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 55);
            this.button5.TabIndex = 17;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // QLLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvHienthi);
            this.Controls.Add(this.cbxnamhoc);
            this.Controls.Add(this.cbxtenkhoi);
            this.Controls.Add(this.txtmalop);
            this.Controls.Add(this.txttenlop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLLop";
            this.Load += new System.EventHandler(this.QLLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.ComboBox cbxtenkhoi;
        private System.Windows.Forms.ComboBox cbxnamhoc;
        private System.Windows.Forms.DataGridView dgvHienthi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn namhoc;
    }
}