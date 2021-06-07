
namespace QLMAMNON.GUI
{
    partial class QLHocPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLHocPhi));
            this.dgvhienthi = new System.Windows.Forms.DataGridView();
            this.mathanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenhs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocphicoban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hogiadinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonghocphi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbchuahoanthanh = new System.Windows.Forms.RadioButton();
            this.rbhoanthanh = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txttonghp = new System.Windows.Forms.TextBox();
            this.rbhothuong = new System.Windows.Forms.RadioButton();
            this.rbhongheo = new System.Windows.Forms.RadioButton();
            this.rbhocanngheo = new System.Windows.Forms.RadioButton();
            this.cbxnamhoc = new System.Windows.Forms.ComboBox();
            this.txttenhs = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txthocphi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtmathanhtoan = new System.Windows.Forms.TextBox();
            this.txtlop = new System.Windows.Forms.TextBox();
            this.cbxmahs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtnganquy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhienthi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvhienthi
            // 
            this.dgvhienthi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvhienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhienthi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathanhtoan,
            this.mahs,
            this.hotenhs,
            this.malop,
            this.hocphicoban,
            this.hogiadinh,
            this.tonghocphi,
            this.tinhtrang,
            this.namhoc});
            this.dgvhienthi.Location = new System.Drawing.Point(24, 362);
            this.dgvhienthi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvhienthi.Name = "dgvhienthi";
            this.dgvhienthi.RowHeadersWidth = 51;
            this.dgvhienthi.Size = new System.Drawing.Size(874, 202);
            this.dgvhienthi.TabIndex = 14;
            this.dgvhienthi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhienthi_CellClick);
            // 
            // mathanhtoan
            // 
            this.mathanhtoan.DataPropertyName = "mathanhtoan";
            this.mathanhtoan.HeaderText = "Mã thanh toán";
            this.mathanhtoan.MinimumWidth = 6;
            this.mathanhtoan.Name = "mathanhtoan";
            this.mathanhtoan.Width = 125;
            // 
            // mahs
            // 
            this.mahs.DataPropertyName = "mahs";
            this.mahs.HeaderText = "Mã học sinh";
            this.mahs.MinimumWidth = 6;
            this.mahs.Name = "mahs";
            this.mahs.Width = 125;
            // 
            // hotenhs
            // 
            this.hotenhs.DataPropertyName = "hotenhs";
            this.hotenhs.HeaderText = "Họ tên học sinh";
            this.hotenhs.MinimumWidth = 6;
            this.hotenhs.Name = "hotenhs";
            this.hotenhs.Width = 125;
            // 
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "Lớp";
            this.malop.MinimumWidth = 6;
            this.malop.Name = "malop";
            this.malop.Width = 125;
            // 
            // hocphicoban
            // 
            this.hocphicoban.DataPropertyName = "hocphicoban";
            this.hocphicoban.HeaderText = "Học phí cơ bản";
            this.hocphicoban.MinimumWidth = 6;
            this.hocphicoban.Name = "hocphicoban";
            this.hocphicoban.Width = 125;
            // 
            // hogiadinh
            // 
            this.hogiadinh.DataPropertyName = "hogiadinh";
            this.hogiadinh.HeaderText = "Hộ gia đình";
            this.hogiadinh.MinimumWidth = 6;
            this.hogiadinh.Name = "hogiadinh";
            this.hogiadinh.Width = 125;
            // 
            // tonghocphi
            // 
            this.tonghocphi.DataPropertyName = "tonghocphi";
            this.tonghocphi.HeaderText = "Tổng học phí";
            this.tonghocphi.MinimumWidth = 6;
            this.tonghocphi.Name = "tonghocphi";
            this.tonghocphi.Width = 125;
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.MinimumWidth = 6;
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Width = 125;
            // 
            // namhoc
            // 
            this.namhoc.DataPropertyName = "namhoc";
            this.namhoc.HeaderText = "Năm học";
            this.namhoc.MinimumWidth = 6;
            this.namhoc.Name = "namhoc";
            this.namhoc.Width = 125;
            // 
            // rbchuahoanthanh
            // 
            this.rbchuahoanthanh.AutoSize = true;
            this.rbchuahoanthanh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbchuahoanthanh.Location = new System.Drawing.Point(280, 172);
            this.rbchuahoanthanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbchuahoanthanh.Name = "rbchuahoanthanh";
            this.rbchuahoanthanh.Size = new System.Drawing.Size(136, 20);
            this.rbchuahoanthanh.TabIndex = 13;
            this.rbchuahoanthanh.TabStop = true;
            this.rbchuahoanthanh.Text = "Chưa hoàn thành";
            this.rbchuahoanthanh.UseVisualStyleBackColor = true;
            // 
            // rbhoanthanh
            // 
            this.rbhoanthanh.AutoSize = true;
            this.rbhoanthanh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbhoanthanh.Location = new System.Drawing.Point(151, 172);
            this.rbhoanthanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbhoanthanh.Name = "rbhoanthanh";
            this.rbhoanthanh.Size = new System.Drawing.Size(99, 20);
            this.rbhoanthanh.TabIndex = 12;
            this.rbhoanthanh.TabStop = true;
            this.rbhoanthanh.Text = "Hoàn thành";
            this.rbhoanthanh.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 175);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tình trạng";
            // 
            // txttonghp
            // 
            this.txttonghp.Enabled = false;
            this.txttonghp.Location = new System.Drawing.Point(159, 130);
            this.txttonghp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttonghp.Name = "txttonghp";
            this.txttonghp.Size = new System.Drawing.Size(141, 22);
            this.txttonghp.TabIndex = 11;
            // 
            // rbhothuong
            // 
            this.rbhothuong.AutoSize = true;
            this.rbhothuong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbhothuong.Location = new System.Drawing.Point(8, 37);
            this.rbhothuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbhothuong.Name = "rbhothuong";
            this.rbhothuong.Size = new System.Drawing.Size(93, 20);
            this.rbhothuong.TabIndex = 7;
            this.rbhothuong.TabStop = true;
            this.rbhothuong.Text = "Hộ thường";
            this.rbhothuong.UseVisualStyleBackColor = true;
            // 
            // rbhongheo
            // 
            this.rbhongheo.AutoSize = true;
            this.rbhongheo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbhongheo.Location = new System.Drawing.Point(136, 37);
            this.rbhongheo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbhongheo.Name = "rbhongheo";
            this.rbhongheo.Size = new System.Drawing.Size(87, 20);
            this.rbhongheo.TabIndex = 10;
            this.rbhongheo.TabStop = true;
            this.rbhongheo.Text = "Hộ nghèo";
            this.rbhongheo.UseVisualStyleBackColor = true;
            // 
            // rbhocanngheo
            // 
            this.rbhocanngheo.AutoSize = true;
            this.rbhocanngheo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbhocanngheo.Location = new System.Drawing.Point(260, 37);
            this.rbhocanngheo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbhocanngheo.Name = "rbhocanngheo";
            this.rbhocanngheo.Size = new System.Drawing.Size(114, 20);
            this.rbhocanngheo.TabIndex = 11;
            this.rbhocanngheo.TabStop = true;
            this.rbhocanngheo.Text = "Hộ cận nghèo";
            this.rbhocanngheo.UseVisualStyleBackColor = true;
            // 
            // cbxnamhoc
            // 
            this.cbxnamhoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxnamhoc.FormattingEnabled = true;
            this.cbxnamhoc.Location = new System.Drawing.Point(159, 135);
            this.cbxnamhoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxnamhoc.Name = "cbxnamhoc";
            this.cbxnamhoc.Size = new System.Drawing.Size(160, 24);
            this.cbxnamhoc.TabIndex = 4;
            this.cbxnamhoc.SelectedIndexChanged += new System.EventHandler(this.cbxnamhoc_SelectedIndexChanged);
            // 
            // txttenhs
            // 
            this.txttenhs.Enabled = false;
            this.txttenhs.Location = new System.Drawing.Point(159, 53);
            this.txttenhs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttenhs.Name = "txttenhs";
            this.txttenhs.Size = new System.Drawing.Size(160, 22);
            this.txttenhs.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbhothuong);
            this.groupBox1.Controls.Add(this.rbhongheo);
            this.groupBox1.Controls.Add(this.rbhocanngheo);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(441, 81);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hộ gia đình";
            // 
            // txthocphi
            // 
            this.txthocphi.Enabled = false;
            this.txthocphi.Location = new System.Drawing.Point(159, 9);
            this.txthocphi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txthocphi.Name = "txthocphi";
            this.txthocphi.Size = new System.Drawing.Size(141, 22);
            this.txthocphi.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txtmathanhtoan);
            this.panel1.Controls.Add(this.txtlop);
            this.panel1.Controls.Add(this.cbxmahs);
            this.panel1.Controls.Add(this.cbxnamhoc);
            this.panel1.Controls.Add(this.txttenhs);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(34, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 204);
            this.panel1.TabIndex = 12;
            // 
            // txtmathanhtoan
            // 
            this.txtmathanhtoan.BackColor = System.Drawing.SystemColors.Menu;
            this.txtmathanhtoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmathanhtoan.Enabled = false;
            this.txtmathanhtoan.Location = new System.Drawing.Point(303, 12);
            this.txtmathanhtoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmathanhtoan.Name = "txtmathanhtoan";
            this.txtmathanhtoan.Size = new System.Drawing.Size(112, 15);
            this.txtmathanhtoan.TabIndex = 20;
            this.txtmathanhtoan.Visible = false;
            // 
            // txtlop
            // 
            this.txtlop.Enabled = false;
            this.txtlop.Location = new System.Drawing.Point(159, 93);
            this.txtlop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(160, 22);
            this.txtlop.TabIndex = 3;
            // 
            // cbxmahs
            // 
            this.cbxmahs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxmahs.FormattingEnabled = true;
            this.cbxmahs.Location = new System.Drawing.Point(159, 12);
            this.cbxmahs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxmahs.Name = "cbxmahs";
            this.cbxmahs.Size = new System.Drawing.Size(160, 24);
            this.cbxmahs.TabIndex = 1;
            this.cbxmahs.SelectedIndexChanged += new System.EventHandler(this.cbxmahs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã học sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên học sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Năm học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Học phí cơ bản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tổng học phí";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.btnTinh);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.rbchuahoanthanh);
            this.panel2.Controls.Add(this.rbhoanthanh);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txttonghp);
            this.panel2.Controls.Add(this.txthocphi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(433, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 204);
            this.panel2.TabIndex = 13;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(309, 128);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(100, 28);
            this.btnTinh.TabIndex = 6;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Học phí";
            // 
            // btnthem
            // 
            this.btnthem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(139, 283);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 52);
            this.btnthem.TabIndex = 7;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(294, 283);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 52);
            this.btnsua.TabIndex = 8;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(433, 282);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 52);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtnganquy
            // 
            this.txtnganquy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnganquy.Enabled = false;
            this.txtnganquy.Location = new System.Drawing.Point(756, 24);
            this.txtnganquy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnganquy.Name = "txtnganquy";
            this.txtnganquy.Size = new System.Drawing.Size(141, 22);
            this.txtnganquy.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(653, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ngân quỹ";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttimkiem.Location = new System.Drawing.Point(657, 297);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(123, 22);
            this.txttimkiem.TabIndex = 20;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(789, 280);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(81, 52);
            this.btntimkiem.TabIndex = 21;
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // QLHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(926, 612);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnganquy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvhienthi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QLHocPhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLHocPhi";
            this.Load += new System.EventHandler(this.QLHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhienthi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvhienthi;
        private System.Windows.Forms.RadioButton rbchuahoanthanh;
        private System.Windows.Forms.RadioButton rbhoanthanh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttonghp;
        private System.Windows.Forms.RadioButton rbhothuong;
        private System.Windows.Forms.RadioButton rbhongheo;
        private System.Windows.Forms.RadioButton rbhocanngheo;
        private System.Windows.Forms.ComboBox cbxnamhoc;
        private System.Windows.Forms.TextBox txttenhs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txthocphi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxmahs;
        private System.Windows.Forms.TextBox txtlop;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtnganquy;
        private System.Windows.Forms.TextBox txtmathanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahs;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocphicoban;
        private System.Windows.Forms.DataGridViewTextBoxColumn hogiadinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonghocphi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn namhoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntimkiem;
    }
}