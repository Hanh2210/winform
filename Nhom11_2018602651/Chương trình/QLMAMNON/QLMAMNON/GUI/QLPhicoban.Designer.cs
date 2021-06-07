
namespace QLMAMNON.GUI
{
    partial class QLPhicoban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLPhicoban));
            this.label1 = new System.Windows.Forms.Label();
            this.txtluongcb = new System.Windows.Forms.TextBox();
            this.cbxnamhoc = new System.Windows.Forms.ComboBox();
            this.dgvhienthi = new System.Windows.Forms.DataGridView();
            this.namhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongcoban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocphicoban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtphicb = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Năm học";
            // 
            // txtluongcb
            // 
            this.txtluongcb.Location = new System.Drawing.Point(333, 87);
            this.txtluongcb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtluongcb.Name = "txtluongcb";
            this.txtluongcb.Size = new System.Drawing.Size(160, 22);
            this.txtluongcb.TabIndex = 1;
            // 
            // cbxnamhoc
            // 
            this.cbxnamhoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxnamhoc.FormattingEnabled = true;
            this.cbxnamhoc.Location = new System.Drawing.Point(333, 46);
            this.cbxnamhoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxnamhoc.Name = "cbxnamhoc";
            this.cbxnamhoc.Size = new System.Drawing.Size(160, 24);
            this.cbxnamhoc.TabIndex = 2;
            // 
            // dgvhienthi
            // 
            this.dgvhienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhienthi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namhoc,
            this.luongcoban,
            this.hocphicoban});
            this.dgvhienthi.Location = new System.Drawing.Point(152, 214);
            this.dgvhienthi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvhienthi.Name = "dgvhienthi";
            this.dgvhienthi.RowHeadersWidth = 51;
            this.dgvhienthi.Size = new System.Drawing.Size(482, 185);
            this.dgvhienthi.TabIndex = 3;
            // 
            // namhoc
            // 
            this.namhoc.DataPropertyName = "namhoc";
            this.namhoc.HeaderText = "Năm học";
            this.namhoc.MinimumWidth = 6;
            this.namhoc.Name = "namhoc";
            this.namhoc.Width = 125;
            // 
            // luongcoban
            // 
            this.luongcoban.DataPropertyName = "luongcoban";
            this.luongcoban.HeaderText = "Lương cơ bản";
            this.luongcoban.MinimumWidth = 6;
            this.luongcoban.Name = "luongcoban";
            this.luongcoban.Width = 150;
            // 
            // hocphicoban
            // 
            this.hocphicoban.DataPropertyName = "hocphicoban";
            this.hocphicoban.HeaderText = "Học phí cơ bản";
            this.hocphicoban.MinimumWidth = 6;
            this.hocphicoban.Name = "hocphicoban";
            this.hocphicoban.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lương cơ bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Học phí cơ bản";
            // 
            // txtphicb
            // 
            this.txtphicb.Location = new System.Drawing.Point(333, 125);
            this.txtphicb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtphicb.Name = "txtphicb";
            this.txtphicb.Size = new System.Drawing.Size(160, 22);
            this.txtphicb.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(152, 164);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 42);
            this.btnThem.TabIndex = 7;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(333, 160);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 42);
            this.btnSua.TabIndex = 8;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(534, 160);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 42);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phí Cơ Bản";
            // 
            // QLPhicoban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(775, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtphicb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvhienthi);
            this.Controls.Add(this.cbxnamhoc);
            this.Controls.Add(this.txtluongcb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QLPhicoban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phicoban";
            this.Load += new System.EventHandler(this.QLPhicoban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtluongcb;
        private System.Windows.Forms.ComboBox cbxnamhoc;
        private System.Windows.Forms.DataGridView dgvhienthi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtphicb;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn namhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongcoban;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocphicoban;
        private System.Windows.Forms.Label label4;
    }
}