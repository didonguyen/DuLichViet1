namespace FormQuanLiTour
{
    partial class FormQuanLiTour
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
            this.dstour = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.QLTmatour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLTTrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLTDDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLTtentour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLTdacdiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLTgiatour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLTloaihinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLTthoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLTngaykhoihanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLTphuongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLTtong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dstourdtv = new System.Windows.Forms.Panel();
            this.btrefresh = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btchitiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dstour)).BeginInit();
            this.dstourdtv.SuspendLayout();
            this.SuspendLayout();
            // 
            // dstour
            // 
            this.dstour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dstour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QLTmatour,
            this.QLTTrangthai,
            this.QLTDDK,
            this.QLTtentour,
            this.QLTdacdiem,
            this.QLTgiatour,
            this.QLTloaihinh,
            this.QLTthoigian,
            this.QLTngaykhoihanh,
            this.QLTphuongtien,
            this.QLTtong});
            this.dstour.Location = new System.Drawing.Point(13, 96);
            this.dstour.Name = "dstour";
            this.dstour.Size = new System.Drawing.Size(878, 402);
            this.dstour.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh Sách Tour";
            // 
            // QLTmatour
            // 
            this.QLTmatour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.QLTmatour.DataPropertyName = "Matour";
            this.QLTmatour.HeaderText = "Mã Tour";
            this.QLTmatour.Name = "QLTmatour";
            this.QLTmatour.Width = 72;
            // 
            // QLTTrangthai
            // 
            this.QLTTrangthai.DataPropertyName = "Trangthai";
            this.QLTTrangthai.HeaderText = "TT";
            this.QLTTrangthai.Name = "QLTTrangthai";
            this.QLTTrangthai.Visible = false;
            // 
            // QLTDDK
            // 
            this.QLTDDK.DataPropertyName = "Dadangky";
            this.QLTDDK.HeaderText = "DDK";
            this.QLTDDK.Name = "QLTDDK";
            this.QLTDDK.Visible = false;
            // 
            // QLTtentour
            // 
            this.QLTtentour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QLTtentour.DataPropertyName = "Tentour";
            this.QLTtentour.HeaderText = "Tên Tour";
            this.QLTtentour.Name = "QLTtentour";
            // 
            // QLTdacdiem
            // 
            this.QLTdacdiem.DataPropertyName = "Dacdiem";
            this.QLTdacdiem.HeaderText = "Đặc Điểm";
            this.QLTdacdiem.Name = "QLTdacdiem";
            // 
            // QLTgiatour
            // 
            this.QLTgiatour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QLTgiatour.DataPropertyName = "Giatour";
            this.QLTgiatour.HeaderText = "Giá";
            this.QLTgiatour.Name = "QLTgiatour";
            // 
            // QLTloaihinh
            // 
            this.QLTloaihinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.QLTloaihinh.DataPropertyName = "Loaihinh";
            this.QLTloaihinh.HeaderText = "Loại Hình";
            this.QLTloaihinh.Name = "QLTloaihinh";
            this.QLTloaihinh.Width = 77;
            // 
            // QLTthoigian
            // 
            this.QLTthoigian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.QLTthoigian.DataPropertyName = "Thoigian";
            this.QLTthoigian.HeaderText = "Thời Gian";
            this.QLTthoigian.Name = "QLTthoigian";
            this.QLTthoigian.Width = 78;
            // 
            // QLTngaykhoihanh
            // 
            this.QLTngaykhoihanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QLTngaykhoihanh.DataPropertyName = "Ngaykhoihanh";
            this.QLTngaykhoihanh.HeaderText = "Ngày";
            this.QLTngaykhoihanh.Name = "QLTngaykhoihanh";
            // 
            // QLTphuongtien
            // 
            this.QLTphuongtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.QLTphuongtien.DataPropertyName = "Phuongtien";
            this.QLTphuongtien.HeaderText = "Phương Tiện";
            this.QLTphuongtien.Name = "QLTphuongtien";
            this.QLTphuongtien.Width = 93;
            // 
            // QLTtong
            // 
            this.QLTtong.DataPropertyName = "Tonghanhkhachtour";
            this.QLTtong.HeaderText = "Tổng Số Chỗ";
            this.QLTtong.Name = "QLTtong";
            // 
            // dstourdtv
            // 
            this.dstourdtv.Controls.Add(this.btrefresh);
            this.dstourdtv.Controls.Add(this.btthem);
            this.dstourdtv.Controls.Add(this.btsua);
            this.dstourdtv.Controls.Add(this.btxoa);
            this.dstourdtv.Controls.Add(this.btchitiet);
            this.dstourdtv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dstourdtv.Location = new System.Drawing.Point(0, 533);
            this.dstourdtv.Name = "dstourdtv";
            this.dstourdtv.Size = new System.Drawing.Size(903, 59);
            this.dstourdtv.TabIndex = 6;
            // 
            // btrefresh
            // 
            this.btrefresh.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrefresh.Location = new System.Drawing.Point(683, 3);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(114, 45);
            this.btrefresh.TabIndex = 4;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(107, 3);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(114, 45);
            this.btthem.TabIndex = 3;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.Location = new System.Drawing.Point(249, 3);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(114, 45);
            this.btsua.TabIndex = 2;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(391, 3);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(114, 45);
            this.btxoa.TabIndex = 1;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btchitiet
            // 
            this.btchitiet.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btchitiet.Location = new System.Drawing.Point(535, 3);
            this.btchitiet.Name = "btchitiet";
            this.btchitiet.Size = new System.Drawing.Size(114, 45);
            this.btchitiet.TabIndex = 0;
            this.btchitiet.Text = "Chi Tiết";
            this.btchitiet.UseVisualStyleBackColor = true;
            this.btchitiet.Click += new System.EventHandler(this.btchitiet_Click);
            // 
            // FormQuanLiTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 592);
            this.Controls.Add(this.dstourdtv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dstour);
            this.Name = "FormQuanLiTour";
            this.Text = "FormQuanLiTour";
            this.Load += new System.EventHandler(this.FormQuanLiTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dstour)).EndInit();
            this.dstourdtv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dstour;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLTmatour;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLTTrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLTDDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLTtentour;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLTdacdiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLTgiatour;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLTloaihinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLTthoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLTngaykhoihanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLTphuongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLTtong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel dstourdtv;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btchitiet;
    }
}