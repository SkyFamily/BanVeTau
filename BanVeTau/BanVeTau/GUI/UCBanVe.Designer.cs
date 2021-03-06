﻿namespace BanVeTau.GUI
{
    partial class UcBanVe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement6 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement7 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colAnh = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colMaGhe = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colTenKhachHang = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colSoTien = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.imageListLoaiGhe = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtNgayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.btnDatGhe = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLoaiGhe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGaDen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLichTrinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGaDi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tileView = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colLoaiGheId = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colGiaoDichId = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn2 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colSoShe1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colDaDuocDat = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCoTheHuy = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colSoShe = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView)).BeginInit();
            this.SuspendLayout();
            // 
            // colAnh
            // 
            this.colAnh.FieldName = "Anh";
            this.colAnh.Name = "colAnh";
            this.colAnh.Visible = true;
            this.colAnh.VisibleIndex = 2;
            // 
            // colMaGhe
            // 
            this.colMaGhe.FieldName = "MaGhe";
            this.colMaGhe.Name = "colMaGhe";
            this.colMaGhe.Visible = true;
            this.colMaGhe.VisibleIndex = 9;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.FieldName = "TenKhachHang";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.Visible = true;
            this.colTenKhachHang.VisibleIndex = 8;
            // 
            // colSoTien
            // 
            this.colSoTien.DisplayFormat.FormatString = "C";
            this.colSoTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoTien.FieldName = "SoTien";
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.Visible = true;
            this.colSoTien.VisibleIndex = 10;
            // 
            // imageListLoaiGhe
            // 
            this.imageListLoaiGhe.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListLoaiGhe.ImageSize = new System.Drawing.Size(64, 64);
            this.imageListLoaiGhe.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtNgayKhoiHanh);
            this.panel1.Controls.Add(this.btnDatGhe);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbLoaiGhe);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbGaDen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbLichTrinh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbGaDi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 81);
            this.panel1.TabIndex = 8;
            // 
            // dtNgayKhoiHanh
            // 
            this.dtNgayKhoiHanh.CustomFormat = "dd/MM/yyyy HH:hh";
            this.dtNgayKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKhoiHanh.Location = new System.Drawing.Point(524, 15);
            this.dtNgayKhoiHanh.Name = "dtNgayKhoiHanh";
            this.dtNgayKhoiHanh.Size = new System.Drawing.Size(129, 20);
            this.dtNgayKhoiHanh.TabIndex = 4;
            this.dtNgayKhoiHanh.ValueChanged += new System.EventHandler(this.dtNgayKhoiHanh_ValueChanged);
            // 
            // btnDatGhe
            // 
            this.btnDatGhe.Location = new System.Drawing.Point(524, 41);
            this.btnDatGhe.Name = "btnDatGhe";
            this.btnDatGhe.Size = new System.Drawing.Size(129, 23);
            this.btnDatGhe.TabIndex = 5;
            this.btnDatGhe.Text = "Đặt ghế";
            this.btnDatGhe.UseVisualStyleBackColor = true;
            this.btnDatGhe.Click += new System.EventHandler(this.btnDatGhe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày khởi hành";
            // 
            // cbLoaiGhe
            // 
            this.cbLoaiGhe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiGhe.FormattingEnabled = true;
            this.cbLoaiGhe.Location = new System.Drawing.Point(279, 43);
            this.cbLoaiGhe.Name = "cbLoaiGhe";
            this.cbLoaiGhe.Size = new System.Drawing.Size(138, 21);
            this.cbLoaiGhe.TabIndex = 3;
            this.cbLoaiGhe.SelectedIndexChanged += new System.EventHandler(this.cbLoaiGhe_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loại ghế";
            // 
            // cbGaDen
            // 
            this.cbGaDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGaDen.FormattingEnabled = true;
            this.cbGaDen.Location = new System.Drawing.Point(279, 14);
            this.cbGaDen.Name = "cbGaDen";
            this.cbGaDen.Size = new System.Drawing.Size(138, 21);
            this.cbGaDen.TabIndex = 1;
            this.cbGaDen.SelectedIndexChanged += new System.EventHandler(this.cbGaDen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ga đến";
            // 
            // cbLichTrinh
            // 
            this.cbLichTrinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLichTrinh.FormattingEnabled = true;
            this.cbLichTrinh.Location = new System.Drawing.Point(74, 43);
            this.cbLichTrinh.Name = "cbLichTrinh";
            this.cbLichTrinh.Size = new System.Drawing.Size(138, 21);
            this.cbLichTrinh.TabIndex = 2;
            this.cbLichTrinh.SelectedIndexChanged += new System.EventHandler(this.cbLichTrinh_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lịch trình";
            // 
            // cbGaDi
            // 
            this.cbGaDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGaDi.FormattingEnabled = true;
            this.cbGaDi.Location = new System.Drawing.Point(74, 14);
            this.cbGaDi.Name = "cbGaDi";
            this.cbGaDi.Size = new System.Drawing.Size(138, 21);
            this.cbGaDi.TabIndex = 0;
            this.cbGaDi.SelectedIndexChanged += new System.EventHandler(this.cbGaDi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ga đi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 503);
            this.panel2.TabIndex = 11;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bindingSource1;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 81);
            this.gridControl.MainView = this.tileView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1071, 422);
            this.gridControl.TabIndex = 6;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(BanVeTau.Models.GheModel);
            // 
            // tileView
            // 
            this.tileView.AppearanceItem.Selected.BackColor = System.Drawing.Color.YellowGreen;
            this.tileView.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileView.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLoaiGheId,
            this.colTen,
            this.colAnh,
            this.colGiaoDichId,
            this.colGhiChu,
            this.tileViewColumn1,
            this.tileViewColumn2,
            this.colSoShe1,
            this.colTenKhachHang,
            this.colMaGhe,
            this.colSoTien,
            this.colDaDuocDat,
            this.colCoTheHuy});
            this.tileView.ColumnSet.CheckedColumn = this.colDaDuocDat;
            this.tileView.ColumnSet.EnabledColumn = this.colCoTheHuy;
            this.tileView.ColumnSet.GroupColumn = this.colTen;
            this.tileView.ContextButtonOptions.AllowHtmlText = true;
            this.tileView.GridControl = this.gridControl;
            this.tileView.GroupCount = 1;
            this.tileView.Name = "tileView";
            this.tileView.OptionsFind.AlwaysVisible = true;
            this.tileView.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.tileView.OptionsTiles.ItemSize = new System.Drawing.Size(180, 64);
            this.tileView.OptionsTiles.RowCount = 5;
            this.tileView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTen, DevExpress.Data.ColumnSortOrder.Ascending)});
            tileViewItemElement1.Column = this.colAnh;
            tileViewItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileViewItemElement1.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None;
            tileViewItemElement1.ImageBorderColor = System.Drawing.Color.Empty;
            tileViewItemElement1.ImageLocation = new System.Drawing.Point(11, -12);
            tileViewItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileViewItemElement1.ImageSize = new System.Drawing.Size(64, 64);
            tileViewItemElement1.Text = "colAnh";
            tileViewItemElement2.Column = null;
            tileViewItemElement2.ImageBorderColor = System.Drawing.Color.Empty;
            tileViewItemElement2.Text = "Mã ghế";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileViewItemElement3.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Right;
            tileViewItemElement3.AnchorElementIndex = 1;
            tileViewItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            tileViewItemElement3.Appearance.Normal.ForeColor = System.Drawing.SystemColors.Highlight;
            tileViewItemElement3.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement3.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement3.Column = this.colMaGhe;
            tileViewItemElement3.ImageBorderColor = System.Drawing.Color.Empty;
            tileViewItemElement3.Text = "colMaGhe";
            tileViewItemElement4.Column = null;
            tileViewItemElement4.ImageBorderColor = System.Drawing.Color.Empty;
            tileViewItemElement4.Text = "KH";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileViewItemElement4.TextLocation = new System.Drawing.Point(0, 18);
            tileViewItemElement5.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Right;
            tileViewItemElement5.AnchorElementIndex = 3;
            tileViewItemElement5.Appearance.Normal.ForeColor = System.Drawing.SystemColors.Highlight;
            tileViewItemElement5.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement5.Column = this.colTenKhachHang;
            tileViewItemElement5.ImageBorderColor = System.Drawing.Color.Empty;
            tileViewItemElement5.Text = "colTenKhachHang";
            tileViewItemElement6.Column = null;
            tileViewItemElement6.ImageBorderColor = System.Drawing.Color.Empty;
            tileViewItemElement6.Text = "Giá vé";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileViewItemElement6.TextLocation = new System.Drawing.Point(0, 36);
            tileViewItemElement7.AnchorAlignment = DevExpress.Utils.AnchorAlignment.Right;
            tileViewItemElement7.AnchorElementIndex = 5;
            tileViewItemElement7.Appearance.Normal.ForeColor = System.Drawing.SystemColors.Highlight;
            tileViewItemElement7.Appearance.Normal.Options.UseForeColor = true;
            tileViewItemElement7.Column = this.colSoTien;
            tileViewItemElement7.ImageBorderColor = System.Drawing.Color.Empty;
            tileViewItemElement7.Text = "colSoTien";
            this.tileView.TileTemplate.Add(tileViewItemElement1);
            this.tileView.TileTemplate.Add(tileViewItemElement2);
            this.tileView.TileTemplate.Add(tileViewItemElement3);
            this.tileView.TileTemplate.Add(tileViewItemElement4);
            this.tileView.TileTemplate.Add(tileViewItemElement5);
            this.tileView.TileTemplate.Add(tileViewItemElement6);
            this.tileView.TileTemplate.Add(tileViewItemElement7);
            // 
            // colLoaiGheId
            // 
            this.colLoaiGheId.FieldName = "LoaiGheId";
            this.colLoaiGheId.Name = "colLoaiGheId";
            this.colLoaiGheId.Visible = true;
            this.colLoaiGheId.VisibleIndex = 0;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            // 
            // colGiaoDichId
            // 
            this.colGiaoDichId.FieldName = "GiaoDichId";
            this.colGiaoDichId.Name = "colGiaoDichId";
            this.colGiaoDichId.Visible = true;
            this.colGiaoDichId.VisibleIndex = 3;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 4;
            // 
            // tileViewColumn1
            // 
            this.tileViewColumn1.FieldName = "LichTrinhTuyenDuongId";
            this.tileViewColumn1.Name = "tileViewColumn1";
            this.tileViewColumn1.Visible = true;
            this.tileViewColumn1.VisibleIndex = 5;
            // 
            // tileViewColumn2
            // 
            this.tileViewColumn2.FieldName = "LichTrinhId";
            this.tileViewColumn2.Name = "tileViewColumn2";
            this.tileViewColumn2.Visible = true;
            this.tileViewColumn2.VisibleIndex = 6;
            // 
            // colSoShe1
            // 
            this.colSoShe1.FieldName = "SoShe";
            this.colSoShe1.Name = "colSoShe1";
            this.colSoShe1.Visible = true;
            this.colSoShe1.VisibleIndex = 7;
            // 
            // colDaDuocDat
            // 
            this.colDaDuocDat.AppearanceCell.BackColor = System.Drawing.Color.LightGreen;
            this.colDaDuocDat.AppearanceCell.BackColor2 = System.Drawing.Color.LightGreen;
            this.colDaDuocDat.AppearanceCell.Options.UseBackColor = true;
            this.colDaDuocDat.FieldName = "DaDuocDat";
            this.colDaDuocDat.Name = "colDaDuocDat";
            this.colDaDuocDat.Visible = true;
            this.colDaDuocDat.VisibleIndex = 11;
            // 
            // colCoTheHuy
            // 
            this.colCoTheHuy.AppearanceCell.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.colCoTheHuy.AppearanceCell.BackColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.colCoTheHuy.AppearanceCell.Options.UseBackColor = true;
            this.colCoTheHuy.FieldName = "CoTheDat";
            this.colCoTheHuy.Name = "colCoTheHuy";
            this.colCoTheHuy.Visible = true;
            this.colCoTheHuy.VisibleIndex = 12;
            // 
            // colSoShe
            // 
            this.colSoShe.Name = "colSoShe";
            // 
            // UcBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "UcBanVe";
            this.Size = new System.Drawing.Size(1071, 503);
            this.Load += new System.EventHandler(this.UCBanVe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListLoaiGhe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbGaDi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDatGhe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGaDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLichTrinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLoaiGhe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgayKhoiHanh;
        private DevExpress.XtraGrid.Columns.TileViewColumn colSoShe;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colLoaiGheId;
        private DevExpress.XtraGrid.Columns.TileViewColumn colTen;
        private DevExpress.XtraGrid.Columns.TileViewColumn colAnh;
        private DevExpress.XtraGrid.Columns.TileViewColumn colGiaoDichId;
        private DevExpress.XtraGrid.Columns.TileViewColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn1;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn2;
        private DevExpress.XtraGrid.Columns.TileViewColumn colSoShe1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colTenKhachHang;
        private DevExpress.XtraGrid.Columns.TileViewColumn colMaGhe;
        private DevExpress.XtraGrid.Columns.TileViewColumn colSoTien;
        private DevExpress.XtraGrid.Columns.TileViewColumn colDaDuocDat;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCoTheHuy;
    }
}
