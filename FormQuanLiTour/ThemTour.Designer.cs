namespace FormQuanLiTour
{
    partial class ThemTour
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbten = new System.Windows.Forms.ComboBox();
            this.txtmatour = new System.Windows.Forms.TextBox();
            this.lbkhoihanh = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btthem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btrefresh = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.CTDTV = new System.Windows.Forms.DataGridView();
            this.TTtendiadiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTpv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTtour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTmatinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTmatour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTmadiadiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTchitiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tbthutu = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTDTV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbthutu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbten);
            this.panel1.Controls.Add(this.txtmatour);
            this.panel1.Controls.Add(this.lbkhoihanh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 289);
            this.panel1.TabIndex = 0;
            // 
            // cbten
            // 
            this.cbten.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbten.FormattingEnabled = true;
            this.cbten.Location = new System.Drawing.Point(311, 92);
            this.cbten.Name = "cbten";
            this.cbten.Size = new System.Drawing.Size(332, 29);
            this.cbten.TabIndex = 11;
            this.cbten.SelectedIndexChanged += new System.EventHandler(this.cbten_SelectedIndexChanged);
            // 
            // txtmatour
            // 
            this.txtmatour.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatour.Location = new System.Drawing.Point(311, 44);
            this.txtmatour.Name = "txtmatour";
            this.txtmatour.ReadOnly = true;
            this.txtmatour.Size = new System.Drawing.Size(332, 29);
            this.txtmatour.TabIndex = 10;
            // 
            // lbkhoihanh
            // 
            this.lbkhoihanh.AutoSize = true;
            this.lbkhoihanh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkhoihanh.Location = new System.Drawing.Point(185, 184);
            this.lbkhoihanh.Name = "lbkhoihanh";
            this.lbkhoihanh.Size = new System.Drawing.Size(90, 21);
            this.lbkhoihanh.TabIndex = 5;
            this.lbkhoihanh.Text = "Khởi Hành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên Địa Điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Tour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.Location = new System.Drawing.Point(58, 3);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(129, 53);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.Themdiadiem);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btrefresh);
            this.panel2.Controls.Add(this.btsua);
            this.panel2.Controls.Add(this.btxoa);
            this.panel2.Controls.Add(this.btthem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 516);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 62);
            this.panel2.TabIndex = 1;
            // 
            // btrefresh
            // 
            this.btrefresh.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrefresh.Location = new System.Drawing.Point(654, 3);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(129, 53);
            this.btrefresh.TabIndex = 3;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.refresh);
            // 
            // btsua
            // 
            this.btsua.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.Location = new System.Drawing.Point(253, 3);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(129, 53);
            this.btsua.TabIndex = 2;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.Capnhatdiadiem);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(456, 3);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(129, 53);
            this.btxoa.TabIndex = 1;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.XoaDiadiem);
            // 
            // CTDTV
            // 
            this.CTDTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CTDTV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TTtendiadiem,
            this.TTpv,
            this.TTtour,
            this.TTmatinh,
            this.TTmatour,
            this.TTmadiadiem,
            this.TTchitiet});
            this.CTDTV.Location = new System.Drawing.Point(127, 295);
            this.CTDTV.Name = "CTDTV";
            this.CTDTV.Size = new System.Drawing.Size(619, 215);
            this.CTDTV.TabIndex = 2;
            this.CTDTV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TTDTV_CellContentClick);
            this.CTDTV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.chondongdd);
            // 
            // TTtendiadiem
            // 
            this.TTtendiadiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TTtendiadiem.DataPropertyName = "Tendiadiem";
            this.TTtendiadiem.HeaderText = "Tên Địa Điểm";
            this.TTtendiadiem.Name = "TTtendiadiem";
            this.TTtendiadiem.Width = 97;
            // 
            // TTpv
            // 
            this.TTpv.DataPropertyName = "Province";
            this.TTpv.HeaderText = "Pv";
            this.TTpv.Name = "TTpv";
            this.TTpv.Visible = false;
            // 
            // TTtour
            // 
            this.TTtour.DataPropertyName = "Tour";
            this.TTtour.HeaderText = "tour";
            this.TTtour.Name = "TTtour";
            this.TTtour.Visible = false;
            // 
            // TTmatinh
            // 
            this.TTmatinh.DataPropertyName = "Matinh";
            this.TTmatinh.HeaderText = "Mã Tỉnh";
            this.TTmatinh.Name = "TTmatinh";
            this.TTmatinh.Visible = false;
            // 
            // TTmatour
            // 
            this.TTmatour.DataPropertyName = "Matour";
            this.TTmatour.HeaderText = "Mã Tour";
            this.TTmatour.Name = "TTmatour";
            this.TTmatour.Visible = false;
            // 
            // TTmadiadiem
            // 
            this.TTmadiadiem.DataPropertyName = "Madiadiem";
            this.TTmadiadiem.HeaderText = "Mã Địa Điểm";
            this.TTmadiadiem.Name = "TTmadiadiem";
            this.TTmadiadiem.Visible = false;
            // 
            // TTchitiet
            // 
            this.TTchitiet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TTchitiet.DataPropertyName = "Chitiet";
            this.TTchitiet.HeaderText = "Hành trình";
            this.TTchitiet.Name = "TTchitiet";
            this.TTchitiet.Width = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Thứ Tự:";
            // 
            // tbthutu
            // 
            this.tbthutu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbthutu.Location = new System.Drawing.Point(311, 137);
            this.tbthutu.Name = "tbthutu";
            this.tbthutu.Size = new System.Drawing.Size(332, 29);
            this.tbthutu.TabIndex = 13;
            // 
            // ThemTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 578);
            this.Controls.Add(this.CTDTV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ThemTour";
            this.Text = "Chi Tiết Tour";
            this.Load += new System.EventHandler(this.Load1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CTDTV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView CTDTV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmatour;
        private System.Windows.Forms.Label lbkhoihanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTtendiadiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTpv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTtour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTmatinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTmatour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTmadiadiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTchitiet;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.ComboBox cbten;
        private System.Windows.Forms.TextBox tbthutu;
        private System.Windows.Forms.Label label2;
    }
}