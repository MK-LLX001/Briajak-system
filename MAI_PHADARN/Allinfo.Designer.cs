namespace MAI_PHADARN
{
    partial class Allinfo
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmi_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmi_data = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmi_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmi_moneykip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmi_moneybat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmi_moneydola = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmi_money = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmi_countmai = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1203, 72);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Location = new System.Drawing.Point(38, 120);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(626, 206);
            this.layoutControl1.TabIndex = 12;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(626, 206);
            this.Root.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.gridControl1.Location = new System.Drawing.Point(0, 72);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1203, 854);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Noto Sans Lao", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmi_id,
            this.colmi_data,
            this.colmi_name,
            this.colmi_moneykip,
            this.colmi_moneybat,
            this.colmi_moneydola,
            this.colmi_money,
            this.colmi_countmai});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1274, 595, 264, 272);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "mi_moneykip", null, "(ຈໍານວນເງີນກີບ: SUM={0:#,#;#,#})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "mi_moneybat", null, "(ຈໍານວນເງີນບາດ: SUM={0:#,#;#,#})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "mi_moneydola", null, "(ຈໍານວນເງີນໂດລາ: SUM={0:#,#;#,#})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsLayout.StoreAllOptions = true;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colmi_id
            // 
            this.colmi_id.AppearanceCell.Font = new System.Drawing.Font("Noto Sans Lao", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmi_id.AppearanceCell.Options.UseFont = true;
            this.colmi_id.AppearanceHeader.Font = new System.Drawing.Font("Noto Sans Lao", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmi_id.AppearanceHeader.Options.UseFont = true;
            this.colmi_id.AppearanceHeader.Options.UseTextOptions = true;
            this.colmi_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmi_id.Caption = "ລະຫັດ";
            this.colmi_id.FieldName = "mi_id";
            this.colmi_id.Name = "colmi_id";
            this.colmi_id.Width = 96;
            // 
            // colmi_data
            // 
            this.colmi_data.AppearanceCell.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmi_data.AppearanceCell.Options.UseFont = true;
            this.colmi_data.AppearanceCell.Options.UseTextOptions = true;
            this.colmi_data.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmi_data.AppearanceHeader.Font = new System.Drawing.Font("Noto Sans Lao", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmi_data.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colmi_data.AppearanceHeader.Options.UseFont = true;
            this.colmi_data.AppearanceHeader.Options.UseTextOptions = true;
            this.colmi_data.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmi_data.Caption = "ວັນທີ່ເດືອນປີ";
            this.colmi_data.FieldName = "mi_data";
            this.colmi_data.Name = "colmi_data";
            this.colmi_data.Visible = true;
            this.colmi_data.VisibleIndex = 0;
            this.colmi_data.Width = 124;
            // 
            // colmi_name
            // 
            this.colmi_name.AppearanceCell.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmi_name.AppearanceCell.Options.UseFont = true;
            this.colmi_name.AppearanceCell.Options.UseTextOptions = true;
            this.colmi_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmi_name.AppearanceHeader.Font = new System.Drawing.Font("Noto Sans Lao", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmi_name.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colmi_name.AppearanceHeader.Options.UseFont = true;
            this.colmi_name.AppearanceHeader.Options.UseTextOptions = true;
            this.colmi_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmi_name.Caption = "ຊື່ ແລະ ນາມສະກຸນ";
            this.colmi_name.FieldName = "mi_name";
            this.colmi_name.Name = "colmi_name";
            this.colmi_name.Visible = true;
            this.colmi_name.VisibleIndex = 1;
            this.colmi_name.Width = 248;
            // 
            // colmi_moneykip
            // 
            this.colmi_moneykip.AppearanceCell.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmi_moneykip.AppearanceCell.Options.UseFont = true;
            this.colmi_moneykip.AppearanceCell.Options.UseTextOptions = true;
            this.colmi_moneykip.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmi_moneykip.AppearanceHeader.Font = new System.Drawing.Font("Noto Sans Lao", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmi_moneykip.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colmi_moneykip.AppearanceHeader.Options.UseFont = true;
            this.colmi_moneykip.AppearanceHeader.Options.UseTextOptions = true;
            this.colmi_moneykip.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmi_moneykip.Caption = "ຈໍານວນເງີນກີບ";
            this.colmi_moneykip.DisplayFormat.FormatString = "{0:#,#;#,#}";
            this.colmi_moneykip.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmi_moneykip.FieldName = "mi_moneykip";
            this.colmi_moneykip.Name = "colmi_moneykip";
            this.colmi_moneykip.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "mi_moneykip", "ຈຳນວນເງິນກີບ={0:#,#;#,#} ກີບ")});
            this.colmi_moneykip.Visible = true;
            this.colmi_moneykip.VisibleIndex = 2;
            this.colmi_moneykip.Width = 228;
            // 
            // colmi_moneybat
            // 
            this.colmi_moneybat.AppearanceCell.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmi_moneybat.AppearanceCell.Options.UseFont = true;
            this.colmi_moneybat.AppearanceCell.Options.UseTextOptions = true;
            this.colmi_moneybat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmi_moneybat.AppearanceHeader.Font = new System.Drawing.Font("Noto Sans Lao", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmi_moneybat.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colmi_moneybat.AppearanceHeader.Options.UseFont = true;
            this.colmi_moneybat.AppearanceHeader.Options.UseTextOptions = true;
            this.colmi_moneybat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmi_moneybat.Caption = "ຈໍານວນເງີນບາດ";
            this.colmi_moneybat.DisplayFormat.FormatString = "{0:#,#;#,#}";
            this.colmi_moneybat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmi_moneybat.FieldName = "mi_moneybat";
            this.colmi_moneybat.Name = "colmi_moneybat";
            this.colmi_moneybat.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "mi_moneybat", "ຈຳນວນເງິນບາດ={0:#,#;#,#} ບາດ")});
            this.colmi_moneybat.Visible = true;
            this.colmi_moneybat.VisibleIndex = 3;
            this.colmi_moneybat.Width = 228;
            // 
            // colmi_moneydola
            // 
            this.colmi_moneydola.AppearanceCell.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmi_moneydola.AppearanceCell.Options.UseFont = true;
            this.colmi_moneydola.AppearanceCell.Options.UseTextOptions = true;
            this.colmi_moneydola.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmi_moneydola.AppearanceHeader.Font = new System.Drawing.Font("Noto Sans Lao", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmi_moneydola.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colmi_moneydola.AppearanceHeader.Options.UseFont = true;
            this.colmi_moneydola.AppearanceHeader.Options.UseTextOptions = true;
            this.colmi_moneydola.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmi_moneydola.Caption = "ຈໍານວນເງີນໂດລາ";
            this.colmi_moneydola.DisplayFormat.FormatString = "{0:#,#;#,#}";
            this.colmi_moneydola.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colmi_moneydola.FieldName = "mi_moneydola";
            this.colmi_moneydola.Name = "colmi_moneydola";
            this.colmi_moneydola.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "mi_moneydola", "ຈໍານວນເງີນໂດລາ={0:#,#;#,#} ໂດລາ")});
            this.colmi_moneydola.Visible = true;
            this.colmi_moneydola.VisibleIndex = 4;
            this.colmi_moneydola.Width = 228;
            // 
            // colmi_money
            // 
            this.colmi_money.AppearanceCell.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmi_money.AppearanceCell.Options.UseFont = true;
            this.colmi_money.AppearanceCell.Options.UseTextOptions = true;
            this.colmi_money.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmi_money.AppearanceHeader.Font = new System.Drawing.Font("Noto Sans Lao", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmi_money.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colmi_money.AppearanceHeader.Options.UseFont = true;
            this.colmi_money.AppearanceHeader.Options.UseTextOptions = true;
            this.colmi_money.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmi_money.Caption = "ປະເພດເງິນ";
            this.colmi_money.FieldName = "mi_money";
            this.colmi_money.Name = "colmi_money";
            this.colmi_money.Visible = true;
            this.colmi_money.VisibleIndex = 5;
            this.colmi_money.Width = 86;
            // 
            // colmi_countmai
            // 
            this.colmi_countmai.AppearanceCell.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmi_countmai.AppearanceCell.Options.UseFont = true;
            this.colmi_countmai.AppearanceCell.Options.UseTextOptions = true;
            this.colmi_countmai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmi_countmai.AppearanceHeader.Font = new System.Drawing.Font("Noto Sans Lao", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmi_countmai.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colmi_countmai.AppearanceHeader.Options.UseFont = true;
            this.colmi_countmai.AppearanceHeader.Options.UseTextOptions = true;
            this.colmi_countmai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmi_countmai.Caption = "ຈຳນວນໄມ້-ມັດ";
            this.colmi_countmai.FieldName = "mi_countmai";
            this.colmi_countmai.Name = "colmi_countmai";
            this.colmi_countmai.Visible = true;
            this.colmi_countmai.VisibleIndex = 6;
            this.colmi_countmai.Width = 100;
            // 
            // Allinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 926);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Allinfo";
            this.Text = "Allinfo";
            this.Load += new System.EventHandler(this.Allinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colmi_id;
        private DevExpress.XtraGrid.Columns.GridColumn colmi_data;
        private DevExpress.XtraGrid.Columns.GridColumn colmi_name;
        private DevExpress.XtraGrid.Columns.GridColumn colmi_moneykip;
        private DevExpress.XtraGrid.Columns.GridColumn colmi_moneybat;
        private DevExpress.XtraGrid.Columns.GridColumn colmi_moneydola;
        private DevExpress.XtraGrid.Columns.GridColumn colmi_money;
        private DevExpress.XtraGrid.Columns.GridColumn colmi_countmai;
    }
}