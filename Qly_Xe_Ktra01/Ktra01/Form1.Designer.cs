﻿namespace Ktra01
{
    partial class Form1
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
            this.Lv1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnTk = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnChen = new System.Windows.Forms.Button();
            this.txtGiaChuaThue = new System.Windows.Forms.TextBox();
            this.txtSoGhe = new System.Windows.Forms.TextBox();
            this.txtTrongTai = new System.Windows.Forms.TextBox();
            this.txtSoTuyen = new System.Windows.Forms.TextBox();
            this.txtHangSx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lv1
            // 
            this.Lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.Lv1.FullRowSelect = true;
            this.Lv1.GridLines = true;
            this.Lv1.Location = new System.Drawing.Point(42, 360);
            this.Lv1.Name = "Lv1";
            this.Lv1.Size = new System.Drawing.Size(789, 223);
            this.Lv1.TabIndex = 42;
            this.Lv1.UseCompatibleStateImageBehavior = false;
            this.Lv1.View = System.Windows.Forms.View.Details;
            this.Lv1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Chon);
            this.Lv1.SelectedIndexChanged += new System.EventHandler(this.Chon_xe);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hãng Sản Xuất";
            this.columnHeader1.Width = 144;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số ghế";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá Chưa Thuế";
            this.columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Tuyến";
            this.columnHeader4.Width = 139;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Trọng Tải";
            this.columnHeader5.Width = 145;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(435, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 23);
            this.btnThem.TabIndex = 41;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(435, 216);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(77, 23);
            this.btnHienThi.TabIndex = 39;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(573, 114);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(153, 22);
            this.txtTk.TabIndex = 38;
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(744, 191);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(177, 50);
            this.btnGhi.TabIndex = 37;
            this.btnGhi.Text = "Ghi Ds Xe Bus Trọng Tải [100-200]";
            this.btnGhi.UseVisualStyleBackColor = true;
            // 
            // btnTk
            // 
            this.btnTk.Location = new System.Drawing.Point(744, 101);
            this.btnTk.Name = "btnTk";
            this.btnTk.Size = new System.Drawing.Size(177, 50);
            this.btnTk.TabIndex = 36;
            this.btnTk.Text = "Tìm Kiếm Theo Tên Xe";
            this.btnTk.UseVisualStyleBackColor = true;
            this.btnTk.Click += new System.EventHandler(this.btnTk_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(744, 18);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(177, 50);
            this.btnSapXep.TabIndex = 35;
            this.btnSapXep.Text = "Sắp Xếp Theo Chiều Tăng Của Trọng Tải";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(435, 170);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 23);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(435, 128);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 23);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnChen
            // 
            this.btnChen.Location = new System.Drawing.Point(435, 85);
            this.btnChen.Name = "btnChen";
            this.btnChen.Size = new System.Drawing.Size(77, 23);
            this.btnChen.TabIndex = 32;
            this.btnChen.Text = "Chèn";
            this.btnChen.UseVisualStyleBackColor = true;
            this.btnChen.Click += new System.EventHandler(this.btnChen_Click);
            // 
            // txtGiaChuaThue
            // 
            this.txtGiaChuaThue.Location = new System.Drawing.Point(206, 115);
            this.txtGiaChuaThue.Name = "txtGiaChuaThue";
            this.txtGiaChuaThue.Size = new System.Drawing.Size(102, 22);
            this.txtGiaChuaThue.TabIndex = 29;
            // 
            // txtSoGhe
            // 
            this.txtSoGhe.Location = new System.Drawing.Point(206, 66);
            this.txtSoGhe.Name = "txtSoGhe";
            this.txtSoGhe.Size = new System.Drawing.Size(102, 22);
            this.txtSoGhe.TabIndex = 28;
            // 
            // txtTrongTai
            // 
            this.txtTrongTai.Location = new System.Drawing.Point(206, 219);
            this.txtTrongTai.Name = "txtTrongTai";
            this.txtTrongTai.Size = new System.Drawing.Size(102, 22);
            this.txtTrongTai.TabIndex = 31;
            // 
            // txtSoTuyen
            // 
            this.txtSoTuyen.Location = new System.Drawing.Point(206, 171);
            this.txtSoTuyen.Name = "txtSoTuyen";
            this.txtSoTuyen.Size = new System.Drawing.Size(102, 22);
            this.txtSoTuyen.TabIndex = 30;
            // 
            // txtHangSx
            // 
            this.txtHangSx.Location = new System.Drawing.Point(206, 18);
            this.txtHangSx.Name = "txtHangSx";
            this.txtHangSx.Size = new System.Drawing.Size(102, 22);
            this.txtHangSx.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Trọng Tải";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Số Tuyến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Giá Chưa Thuế";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Số Ghế";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Hãng Sản Xuất";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 617);
            this.Controls.Add(this.Lv1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.txtTk);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnTk);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnChen);
            this.Controls.Add(this.txtGiaChuaThue);
            this.Controls.Add(this.txtSoGhe);
            this.Controls.Add(this.txtTrongTai);
            this.Controls.Add(this.txtSoTuyen);
            this.Controls.Add(this.txtHangSx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Lv1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnTk;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnChen;
        private System.Windows.Forms.TextBox txtGiaChuaThue;
        private System.Windows.Forms.TextBox txtSoGhe;
        private System.Windows.Forms.TextBox txtTrongTai;
        private System.Windows.Forms.TextBox txtSoTuyen;
        private System.Windows.Forms.TextBox txtHangSx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

