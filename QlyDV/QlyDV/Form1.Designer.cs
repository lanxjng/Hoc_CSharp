namespace QlyDV
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
            this.nhậpDLBảngDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpDLBảngKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpDLBảngChứngTừToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpDLBảngDịchVụToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inBáoCáoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpDLBảngDịchVụToolStripMenuItem,
            this.inBáoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhậpDLBảngDịchVụToolStripMenuItem
            // 
            this.nhậpDLBảngDịchVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpDLBảngKháchHàngToolStripMenuItem,
            this.nhậpDLBảngChứngTừToolStripMenuItem,
            this.nhậpDLBảngDịchVụToolStripMenuItem1});
            this.nhậpDLBảngDịchVụToolStripMenuItem.Name = "nhậpDLBảngDịchVụToolStripMenuItem";
            this.nhậpDLBảngDịchVụToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.nhậpDLBảngDịchVụToolStripMenuItem.Text = "Nhập DL";
            // 
            // nhậpDLBảngKháchHàngToolStripMenuItem
            // 
            this.nhậpDLBảngKháchHàngToolStripMenuItem.Name = "nhậpDLBảngKháchHàngToolStripMenuItem";
            this.nhậpDLBảngKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.nhậpDLBảngKháchHàngToolStripMenuItem.Text = "Nhập DL Bảng Khách Hàng";
            this.nhậpDLBảngKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.nhậpDLBảngKháchHàngToolStripMenuItem_Click);
            // 
            // nhậpDLBảngChứngTừToolStripMenuItem
            // 
            this.nhậpDLBảngChứngTừToolStripMenuItem.Name = "nhậpDLBảngChứngTừToolStripMenuItem";
            this.nhậpDLBảngChứngTừToolStripMenuItem.Size = new System.Drawing.Size(258, 24);
            this.nhậpDLBảngChứngTừToolStripMenuItem.Text = "Nhập DL Bảng Chứng Từ";
            this.nhậpDLBảngChứngTừToolStripMenuItem.Click += new System.EventHandler(this.nhậpDLBảngChứngTừToolStripMenuItem_Click);
            // 
            // nhậpDLBảngDịchVụToolStripMenuItem1
            // 
            this.nhậpDLBảngDịchVụToolStripMenuItem1.Name = "nhậpDLBảngDịchVụToolStripMenuItem1";
            this.nhậpDLBảngDịchVụToolStripMenuItem1.Size = new System.Drawing.Size(258, 24);
            this.nhậpDLBảngDịchVụToolStripMenuItem1.Text = "Nhập DL Bảng Dịch Vụ";
            this.nhậpDLBảngDịchVụToolStripMenuItem1.Click += new System.EventHandler(this.nhậpDLBảngDịchVụToolStripMenuItem1_Click);
            // 
            // inBáoCáoToolStripMenuItem
            // 
            this.inBáoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inBáoCáoToolStripMenuItem1});
            this.inBáoCáoToolStripMenuItem.Name = "inBáoCáoToolStripMenuItem";
            this.inBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.inBáoCáoToolStripMenuItem.Text = "Báo Cáo";
            this.inBáoCáoToolStripMenuItem.Click += new System.EventHandler(this.inBáoCáoToolStripMenuItem_Click);
            // 
            // inBáoCáoToolStripMenuItem1
            // 
            this.inBáoCáoToolStripMenuItem1.Name = "inBáoCáoToolStripMenuItem1";
            this.inBáoCáoToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.inBáoCáoToolStripMenuItem1.Text = "In Báo Cáo";
            this.inBáoCáoToolStripMenuItem1.Click += new System.EventHandler(this.inBáoCáoToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 503);
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
        private System.Windows.Forms.ToolStripMenuItem nhậpDLBảngDịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpDLBảngKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpDLBảngChứngTừToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpDLBảngDịchVụToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inBáoCáoToolStripMenuItem1;
    }
}

