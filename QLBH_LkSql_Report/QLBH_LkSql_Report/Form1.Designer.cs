namespace QLBH_LkSql_Report
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhToolStripMenuItem
            // 
            this.nhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bảngKháchHàngToolStripMenuItem,
            this.bảngHàngHóaToolStripMenuItem,
            this.bảngHóaĐơnToolStripMenuItem});
            this.nhToolStripMenuItem.Name = "nhToolStripMenuItem";
            this.nhToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.nhToolStripMenuItem.Text = "Nhập Dữ Liệu";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoHóaĐơnToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.báoCáoToolStripMenuItem.Text = "Báo Cáo";
            // 
            // bảngKháchHàngToolStripMenuItem
            // 
            this.bảngKháchHàngToolStripMenuItem.Name = "bảngKháchHàngToolStripMenuItem";
            this.bảngKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.bảngKháchHàngToolStripMenuItem.Text = "Bảng Khách Hàng";
            this.bảngKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.bảngKháchHàngToolStripMenuItem_Click);
            // 
            // bảngHàngHóaToolStripMenuItem
            // 
            this.bảngHàngHóaToolStripMenuItem.Name = "bảngHàngHóaToolStripMenuItem";
            this.bảngHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.bảngHàngHóaToolStripMenuItem.Text = "Bảng Hàng Hóa";
            this.bảngHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.bảngHàngHóaToolStripMenuItem_Click);
            // 
            // bảngHóaĐơnToolStripMenuItem
            // 
            this.bảngHóaĐơnToolStripMenuItem.Name = "bảngHóaĐơnToolStripMenuItem";
            this.bảngHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.bảngHóaĐơnToolStripMenuItem.Text = "Bảng Hóa Đơn";
            this.bảngHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.bảngHóaĐơnToolStripMenuItem_Click);
            // 
            // báoCáoHóaĐơnToolStripMenuItem
            // 
            this.báoCáoHóaĐơnToolStripMenuItem.Name = "báoCáoHóaĐơnToolStripMenuItem";
            this.báoCáoHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.báoCáoHóaĐơnToolStripMenuItem.Text = "Báo Cáo Hóa Đơn";
            this.báoCáoHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.báoCáoHóaĐơnToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 467);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoHóaĐơnToolStripMenuItem;
    }
}

