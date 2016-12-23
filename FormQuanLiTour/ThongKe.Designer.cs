namespace FormQuanLiTour
{
    partial class ThongKe
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
            this.ngaybatdau = new System.Windows.Forms.TextBox();
            this.ngayketthuc = new System.Windows.Forms.TextBox();
            this.TKDTV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Tong = new System.Windows.Forms.Label();
            this.timepicker1 = new System.Windows.Forms.DateTimePicker();
            this.timepicker2 = new System.Windows.Forms.DateTimePicker();
            this.TKmatour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKtentour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKgiatour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKngaykhoihanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKdadangky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKdacdiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKloaihinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKthoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKphuongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKtonghanhkhachtour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKtrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TKDTV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày kết thúc";
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaybatdau.Location = new System.Drawing.Point(178, 56);
            this.ngaybatdau.Name = "ngaybatdau";
            this.ngaybatdau.Size = new System.Drawing.Size(162, 29);
            this.ngaybatdau.TabIndex = 2;
            this.ngaybatdau.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayketthuc.Location = new System.Drawing.Point(178, 93);
            this.ngayketthuc.Name = "ngayketthuc";
            this.ngayketthuc.Size = new System.Drawing.Size(162, 29);
            this.ngayketthuc.TabIndex = 3;
            // 
            // TKDTV
            // 
            this.TKDTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TKDTV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TKmatour,
            this.TKtentour,
            this.TKgiatour,
            this.TKngaykhoihanh,
            this.TKdadangky,
            this.TKtien,
            this.TKdacdiem,
            this.TKloaihinh,
            this.TKthoigian,
            this.TKphuongtien,
            this.TKtonghanhkhachtour,
            this.TKtrangthai});
            this.TKDTV.Location = new System.Drawing.Point(58, 153);
            this.TKDTV.Name = "TKDTV";
            this.TKDTV.Size = new System.Drawing.Size(643, 199);
            this.TKDTV.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(581, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thống Kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TKClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng Tiền:";
            // 
            // Tong
            // 
            this.Tong.AutoSize = true;
            this.Tong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tong.Location = new System.Drawing.Point(625, 372);
            this.Tong.Name = "Tong";
            this.Tong.Size = new System.Drawing.Size(19, 21);
            this.Tong.TabIndex = 7;
            this.Tong.Text = "0";
            // 
            // timepicker1
            // 
            this.timepicker1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timepicker1.Location = new System.Drawing.Point(346, 56);
            this.timepicker1.Name = "timepicker1";
            this.timepicker1.Size = new System.Drawing.Size(200, 29);
            this.timepicker1.TabIndex = 8;
            this.timepicker1.ValueChanged += new System.EventHandler(this.nhapngaybd);
            // 
            // timepicker2
            // 
            this.timepicker2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timepicker2.Location = new System.Drawing.Point(346, 93);
            this.timepicker2.Name = "timepicker2";
            this.timepicker2.Size = new System.Drawing.Size(200, 29);
            this.timepicker2.TabIndex = 9;
            this.timepicker2.ValueChanged += new System.EventHandler(this.nhapngaykt);
            // 
            // TKmatour
            // 
            this.TKmatour.DataPropertyName = "Matour";
            this.TKmatour.HeaderText = "Mã Tour";
            this.TKmatour.Name = "TKmatour";
            // 
            // TKtentour
            // 
            this.TKtentour.DataPropertyName = "Tentour";
            this.TKtentour.HeaderText = "Tên Tour";
            this.TKtentour.Name = "TKtentour";
            // 
            // TKgiatour
            // 
            this.TKgiatour.HeaderText = "Giá Tour";
            this.TKgiatour.Name = "TKgiatour";
            // 
            // TKngaykhoihanh
            // 
            this.TKngaykhoihanh.DataPropertyName = "Ngaykhoihanh";
            this.TKngaykhoihanh.HeaderText = "Ngày Khởi Hành";
            this.TKngaykhoihanh.Name = "TKngaykhoihanh";
            // 
            // TKdadangky
            // 
            this.TKdadangky.DataPropertyName = "Dadangky";
            this.TKdadangky.HeaderText = "Tổng Số Hành Khách";
            this.TKdadangky.Name = "TKdadangky";
            // 
            // TKtien
            // 
            this.TKtien.HeaderText = "Thành tiền";
            this.TKtien.Name = "TKtien";
            // 
            // TKdacdiem
            // 
            this.TKdacdiem.HeaderText = "Đặc Điểm";
            this.TKdacdiem.Name = "TKdacdiem";
            this.TKdacdiem.Visible = false;
            // 
            // TKloaihinh
            // 
            this.TKloaihinh.HeaderText = "Loại Hình";
            this.TKloaihinh.Name = "TKloaihinh";
            this.TKloaihinh.Visible = false;
            // 
            // TKthoigian
            // 
            this.TKthoigian.HeaderText = "Thời Gian";
            this.TKthoigian.Name = "TKthoigian";
            this.TKthoigian.Visible = false;
            // 
            // TKphuongtien
            // 
            this.TKphuongtien.HeaderText = "Phương Tiện";
            this.TKphuongtien.Name = "TKphuongtien";
            this.TKphuongtien.Visible = false;
            // 
            // TKtonghanhkhachtour
            // 
            this.TKtonghanhkhachtour.HeaderText = "Tổng Số HK";
            this.TKtonghanhkhachtour.Name = "TKtonghanhkhachtour";
            this.TKtonghanhkhachtour.Visible = false;
            // 
            // TKtrangthai
            // 
            this.TKtrangthai.HeaderText = "Trạng Thái";
            this.TKtrangthai.Name = "TKtrangthai";
            this.TKtrangthai.Visible = false;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 463);
            this.Controls.Add(this.timepicker2);
            this.Controls.Add(this.timepicker1);
            this.Controls.Add(this.Tong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TKDTV);
            this.Controls.Add(this.ngayketthuc);
            this.Controls.Add(this.ngaybatdau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.TKDTV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ngaybatdau;
        private System.Windows.Forms.TextBox ngayketthuc;
        private System.Windows.Forms.DataGridView TKDTV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Tong;
        private System.Windows.Forms.DateTimePicker timepicker1;
        private System.Windows.Forms.DateTimePicker timepicker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKmatour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKtentour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKgiatour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKngaykhoihanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKdadangky;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKdacdiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKloaihinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKthoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKphuongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKtonghanhkhachtour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKtrangthai;
    }
}