namespace QlyDV
{
    partial class ChungTu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaCt = new System.Windows.Forms.TextBox();
            this.txtSoLg = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaCt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbbMaKh = new System.Windows.Forms.ComboBox();
            this.cbbMaDv = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã CT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã KH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã DV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Lượng";
            // 
            // txtMaCt
            // 
            this.txtMaCt.Location = new System.Drawing.Point(133, 13);
            this.txtMaCt.Name = "txtMaCt";
            this.txtMaCt.Size = new System.Drawing.Size(100, 22);
            this.txtMaCt.TabIndex = 5;
            // 
            // txtSoLg
            // 
            this.txtSoLg.Location = new System.Drawing.Point(133, 196);
            this.txtSoLg.Name = "txtSoLg";
            this.txtSoLg.Size = new System.Drawing.Size(100, 22);
            this.txtSoLg.TabIndex = 6;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(493, 49);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(493, 162);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(315, 162);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(315, 49);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCt,
            this.Ngay,
            this.MaKh,
            this.MaDv,
            this.SoLg});
            this.dataGridView1.Location = new System.Drawing.Point(56, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 150);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Chon_CT);
            // 
            // MaCt
            // 
            this.MaCt.DataPropertyName = "MaCt";
            this.MaCt.HeaderText = "Mã CT";
            this.MaCt.Name = "MaCt";
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            // 
            // MaKh
            // 
            this.MaKh.DataPropertyName = "MaKh";
            this.MaKh.HeaderText = "Mã KH";
            this.MaKh.Name = "MaKh";
            // 
            // MaDv
            // 
            this.MaDv.DataPropertyName = "MaDv";
            this.MaDv.HeaderText = "Mã DV";
            this.MaDv.Name = "MaDv";
            // 
            // SoLg
            // 
            this.SoLg.DataPropertyName = "SoLg";
            this.SoLg.HeaderText = "Số Lượng";
            this.SoLg.Name = "SoLg";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // cbbMaKh
            // 
            this.cbbMaKh.FormattingEnabled = true;
            this.cbbMaKh.Location = new System.Drawing.Point(133, 103);
            this.cbbMaKh.Name = "cbbMaKh";
            this.cbbMaKh.Size = new System.Drawing.Size(121, 24);
            this.cbbMaKh.TabIndex = 27;
            // 
            // cbbMaDv
            // 
            this.cbbMaDv.FormattingEnabled = true;
            this.cbbMaDv.Location = new System.Drawing.Point(133, 149);
            this.cbbMaDv.Name = "cbbMaDv";
            this.cbbMaDv.Size = new System.Drawing.Size(121, 24);
            this.cbbMaDv.TabIndex = 28;
            // 
            // ChungTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 434);
            this.Controls.Add(this.cbbMaDv);
            this.Controls.Add(this.cbbMaKh);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoLg);
            this.Controls.Add(this.txtMaCt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChungTu";
            this.Text = "ChungTu";
            this.Load += new System.EventHandler(this.ChungTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaCt;
        private System.Windows.Forms.TextBox txtSoLg;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbbMaKh;
        private System.Windows.Forms.ComboBox cbbMaDv;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDv;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLg;
    }
}