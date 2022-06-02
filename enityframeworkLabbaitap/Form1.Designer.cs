
namespace enityframeworkLabbaitap
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblHoTenSV = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.gbDanhSachSV = new System.Windows.Forms.GroupBox();
            this.lvDanhSachSV = new System.Windows.Forms.ListView();
            this.chMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbDanhSachSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtTimKiem);
            this.splitContainer1.Panel1.Controls.Add(this.btnLuu);
            this.splitContainer1.Panel1.Controls.Add(this.btnTaiLai);
            this.splitContainer1.Panel1.Controls.Add(this.btnMacDinh);
            this.splitContainer1.Panel1.Controls.Add(this.txtHoTenSV);
            this.splitContainer1.Panel1.Controls.Add(this.txtID);
            this.splitContainer1.Panel1.Controls.Add(this.cboLop);
            this.splitContainer1.Panel1.Controls.Add(this.lblHoTenSV);
            this.splitContainer1.Panel1.Controls.Add(this.lblID);
            this.splitContainer1.Panel1.Controls.Add(this.lblLop);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbDanhSachSV);
            this.splitContainer1.Size = new System.Drawing.Size(864, 620);
            this.splitContainer1.SplitterDistance = 288;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(427, 240);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(281, 30);
            this.txtTimKiem.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(608, 177);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 42);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(466, 177);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(104, 42);
            this.btnTaiLai.TabIndex = 4;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(332, 177);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(98, 42);
            this.btnMacDinh.TabIndex = 4;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            // 
            // txtHoTenSV
            // 
            this.txtHoTenSV.Location = new System.Drawing.Point(332, 125);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.Size = new System.Drawing.Size(376, 22);
            this.txtHoTenSV.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(332, 84);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(376, 22);
            this.txtID.TabIndex = 2;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(332, 36);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(376, 24);
            this.cboLop.TabIndex = 1;
            // 
            // lblHoTenSV
            // 
            this.lblHoTenSV.AutoSize = true;
            this.lblHoTenSV.Location = new System.Drawing.Point(128, 130);
            this.lblHoTenSV.Name = "lblHoTenSV";
            this.lblHoTenSV.Size = new System.Drawing.Size(129, 17);
            this.lblHoTenSV.TabIndex = 0;
            this.lblHoTenSV.Text = "Họ và tên sinh viên";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(128, 84);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(128, 36);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(32, 17);
            this.lblLop.TabIndex = 0;
            this.lblLop.Text = "Lớp";
            // 
            // gbDanhSachSV
            // 
            this.gbDanhSachSV.Controls.Add(this.lvDanhSachSV);
            this.gbDanhSachSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDanhSachSV.Location = new System.Drawing.Point(0, 0);
            this.gbDanhSachSV.Name = "gbDanhSachSV";
            this.gbDanhSachSV.Size = new System.Drawing.Size(864, 328);
            this.gbDanhSachSV.TabIndex = 0;
            this.gbDanhSachSV.TabStop = false;
            this.gbDanhSachSV.Text = "Danh sách sinh viên";
            // 
            // lvDanhSachSV
            // 
            this.lvDanhSachSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMSSV,
            this.chHoTen,
            this.chLop});
            this.lvDanhSachSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSachSV.FullRowSelect = true;
            this.lvDanhSachSV.GridLines = true;
            this.lvDanhSachSV.HideSelection = false;
            this.lvDanhSachSV.Location = new System.Drawing.Point(3, 18);
            this.lvDanhSachSV.Name = "lvDanhSachSV";
            this.lvDanhSachSV.Size = new System.Drawing.Size(858, 307);
            this.lvDanhSachSV.TabIndex = 0;
            this.lvDanhSachSV.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachSV.View = System.Windows.Forms.View.Details;
            // 
            // chMSSV
            // 
            this.chMSSV.Text = "MSSV";
            this.chMSSV.Width = 100;
            // 
            // chHoTen
            // 
            this.chHoTen.Text = "Họ tên ";
            this.chHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chHoTen.Width = 300;
            // 
            // chLop
            // 
            this.chLop.Text = "Lớp";
            this.chLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chLop.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 620);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbDanhSachSV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblHoTenSV;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.GroupBox gbDanhSachSV;
        private System.Windows.Forms.ListView lvDanhSachSV;
        private System.Windows.Forms.ColumnHeader chMSSV;
        private System.Windows.Forms.ColumnHeader chHoTen;
        private System.Windows.Forms.ColumnHeader chLop;


    }
}


