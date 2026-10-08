namespace NGUYEN_VU_NHAT_MINH_24810320314_BAI_TAP_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpNhapLieu = new System.Windows.Forms.GroupBox();
            this.lblMaVT = new System.Windows.Forms.Label();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.lblTenVT = new System.Windows.Forms.Label();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.cboDonViTinh = new System.Windows.Forms.ComboBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoaDong = new System.Windows.Forms.Button();
            this.btnXoaToanBo = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.lsvVatTu = new System.Windows.Forms.ListView();
            this.colMaVT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenVT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonViTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));

            this.grpNhapLieu.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            this.SuspendLayout();

            // grpNhapLieu
            this.grpNhapLieu.Controls.Add(this.btnXoaToanBo);
            this.grpNhapLieu.Controls.Add(this.btnXoaDong);
            this.grpNhapLieu.Controls.Add(this.btnCapNhat);
            this.grpNhapLieu.Controls.Add(this.btnThem);
            this.grpNhapLieu.Controls.Add(this.txtDonGia);
            this.grpNhapLieu.Controls.Add(this.lblDonGia);
            this.grpNhapLieu.Controls.Add(this.cboDonViTinh);
            this.grpNhapLieu.Controls.Add(this.lblDonViTinh);
            this.grpNhapLieu.Controls.Add(this.txtTenVT);
            this.grpNhapLieu.Controls.Add(this.lblTenVT);
            this.grpNhapLieu.Controls.Add(this.txtMaVT);
            this.grpNhapLieu.Controls.Add(this.lblMaVT);
            this.grpNhapLieu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNhapLieu.Location = new System.Drawing.Point(12, 12);
            this.grpNhapLieu.Name = "grpNhapLieu";
            this.grpNhapLieu.Size = new System.Drawing.Size(320, 390);
            this.grpNhapLieu.TabIndex = 0;
            this.grpNhapLieu.TabStop = false;
            this.grpNhapLieu.Text = "Thông tin Vật tư / Linh kiện";

            // lblMaVT
            this.lblMaVT.AutoSize = true;
            this.lblMaVT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaVT.Location = new System.Drawing.Point(15, 35);
            this.lblMaVT.Name = "lblMaVT";
            this.lblMaVT.Size = new System.Drawing.Size(60, 15);
            this.lblMaVT.Text = "Mã vật tư:";

            // txtMaVT
            this.txtMaVT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVT.Location = new System.Drawing.Point(18, 55);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(280, 25);
            this.txtMaVT.TabIndex = 1;

            // lblTenVT
            this.lblTenVT.AutoSize = true;
            this.lblTenVT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenVT.Location = new System.Drawing.Point(15, 90);
            this.lblTenVT.Name = "lblTenVT";
            this.lblTenVT.Size = new System.Drawing.Size(61, 15);
            this.lblTenVT.Text = "Tên vật tư:";

            // txtTenVT
            this.txtTenVT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVT.Location = new System.Drawing.Point(18, 110);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(280, 25);
            this.txtTenVT.TabIndex = 2;

            // lblDonViTinh
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonViTinh.Location = new System.Drawing.Point(15, 145);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(68, 15);
            this.lblDonViTinh.Text = "Đơn vị tính:";

            // cboDonViTinh
            this.cboDonViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonViTinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDonViTinh.FormattingEnabled = true;
            this.cboDonViTinh.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            this.cboDonViTinh.Location = new System.Drawing.Point(18, 165);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Size = new System.Drawing.Size(280, 25);
            this.cboDonViTinh.TabIndex = 3;

            // lblDonGia
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(15, 200);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(81, 15);
            this.lblDonGia.Text = "Đơn giá nhập:";

            // txtDonGia
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(18, 220);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(280, 25);
            this.txtDonGia.TabIndex = 4;

            // btnThem
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(18, 265);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 35);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnCapNhat
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(168, 265);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(130, 35);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            // btnXoaDong
            this.btnXoaDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoaDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDong.ForeColor = System.Drawing.Color.White;
            this.btnXoaDong.Location = new System.Drawing.Point(18, 315);
            this.btnXoaDong.Name = "btnXoaDong";
            this.btnXoaDong.Size = new System.Drawing.Size(130, 35);
            this.btnXoaDong.TabIndex = 7;
            this.btnXoaDong.Text = "Xóa dòng";
            this.btnXoaDong.UseVisualStyleBackColor = false;
            this.btnXoaDong.Click += new System.EventHandler(this.btnXoaDong_Click);

            // btnXoaToanBo
            this.btnXoaToanBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnXoaToanBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaToanBo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaToanBo.ForeColor = System.Drawing.Color.White;
            this.btnXoaToanBo.Location = new System.Drawing.Point(168, 315);
            this.btnXoaToanBo.Name = "btnXoaToanBo";
            this.btnXoaToanBo.Size = new System.Drawing.Size(130, 35);
            this.btnXoaToanBo.TabIndex = 8;
            this.btnXoaToanBo.Text = "Xóa toàn bộ";
            this.btnXoaToanBo.UseVisualStyleBackColor = false;
            this.btnXoaToanBo.Click += new System.EventHandler(this.btnXoaToanBo_Click);

            // grpDanhSach
            this.grpDanhSach.Controls.Add(this.lsvVatTu);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSach.Location = new System.Drawing.Point(345, 12);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(515, 390);
            this.grpDanhSach.TabIndex = 1;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách Vật tư / Linh kiện";

            // lsvVatTu
            this.lsvVatTu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaVT,
            this.colTenVT,
            this.colDonViTinh,
            this.colDonGia});
            this.lsvVatTu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvVatTu.FullRowSelect = true;
            this.lsvVatTu.GridLines = true;
            this.lsvVatTu.HideSelection = false;
            this.lsvVatTu.Location = new System.Drawing.Point(15, 25);
            this.lsvVatTu.MultiSelect = false;
            this.lsvVatTu.Name = "lsvVatTu";
            this.lsvVatTu.Size = new System.Drawing.Size(485, 350);
            this.lsvVatTu.TabIndex = 0;
            this.lsvVatTu.UseCompatibleStateImageBehavior = false;
            this.lsvVatTu.View = System.Windows.Forms.View.Details;
            this.lsvVatTu.SelectedIndexChanged += new System.EventHandler(this.lsvVatTu_SelectedIndexChanged);

            // colMaVT
            this.colMaVT.Text = "Mã VT";
            this.colMaVT.Width = 90;

            // colTenVT
            this.colTenVT.Text = "Tên VT";
            this.colTenVT.Width = 180;

            // colDonViTinh
            this.colDonViTinh.Text = "Đơn vị tính";
            this.colDonViTinh.Width = 90;

            // colDonGia
            this.colDonGia.Text = "Đơn giá (VNĐ)";
            this.colDonGia.Width = 120;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 415);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpNhapLieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục Vật tư / Linh kiện (Item List Manager)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpNhapLieu.ResumeLayout(false);
            this.grpNhapLieu.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNhapLieu;
        private System.Windows.Forms.Label lblMaVT;
        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.Label lblTenVT;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.ComboBox cboDonViTinh;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoaDong;
        private System.Windows.Forms.Button btnXoaToanBo;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.ListView lsvVatTu;
        private System.Windows.Forms.ColumnHeader colMaVT;
        private System.Windows.Forms.ColumnHeader colTenVT;
        private System.Windows.Forms.ColumnHeader colDonViTinh;
        private System.Windows.Forms.ColumnHeader colDonGia;
    }
}