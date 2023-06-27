<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_InputStock
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_InputStock))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Ed_Qty = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.LookUpEdit3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpMDUoMGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Master_Data.DataSet()
        Me.LookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpMDInvCategoryGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpMDInvBrandGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ed_BarcodeInput = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_InvName_Input = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_InvNo_Input = New DevExpress.XtraEditors.TextEdit()
        Me.SB_Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Print = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.Sp_T_Opname_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_T_Opname_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_Detail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoTransaction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_Inv = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Sp_MDInventory_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Ed_Barcode = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_NoTransaksi = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Sp_T_Opname_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_T_Opname_GetDataTableAdapter()
        Me.Sp_MDInventory_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInventory_GetDataTableAdapter()
        Me.QueriesTableAdapter = New Master_Data.DataSetTableAdapters.QueriesTableAdapter()
        Me.Sp_MDInvBrand_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInvBrand_GetDataTableAdapter()
        Me.Sp_MDInvCategory_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInvCategory_GetDataTableAdapter()
        Me.Sp_MDUoMGetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDUoMGetDataTableAdapter()
        Me.TableAdapterManager = New Master_Data.DataSetTableAdapters.TableAdapterManager()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.Ed_KodeHarga = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Ed_Qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpMDUoMGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpMDInvCategoryGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpMDInvBrandGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_BarcodeInput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_InvName_Input.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_InvNo_Input.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_T_Opname_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_T_Opname_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_Inv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInventory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Barcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_NoTransaksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_KodeHarga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.Ed_KodeHarga)
        Me.LayoutControl1.Controls.Add(Me.Ed_Qty)
        Me.LayoutControl1.Controls.Add(Me.MemoEdit1)
        Me.LayoutControl1.Controls.Add(Me.LookUpEdit3)
        Me.LayoutControl1.Controls.Add(Me.LookUpEdit2)
        Me.LayoutControl1.Controls.Add(Me.LookUpEdit1)
        Me.LayoutControl1.Controls.Add(Me.Ed_BarcodeInput)
        Me.LayoutControl1.Controls.Add(Me.Ed_InvName_Input)
        Me.LayoutControl1.Controls.Add(Me.Ed_InvNo_Input)
        Me.LayoutControl1.Controls.Add(Me.SB_Submit)
        Me.LayoutControl1.Controls.Add(Me.SB_Print)
        Me.LayoutControl1.Controls.Add(Me.SB_Refresh)
        Me.LayoutControl1.Controls.Add(Me.Sp_T_Opname_GetDataGridControl)
        Me.LayoutControl1.Controls.Add(Me.Ed_Barcode)
        Me.LayoutControl1.Controls.Add(Me.Ed_NoTransaksi)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(824, 371)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Ed_Qty
        '
        Me.Ed_Qty.Location = New System.Drawing.Point(657, 241)
        Me.Ed_Qty.MenuManager = Me.RibbonControl1
        Me.Ed_Qty.Name = "Ed_Qty"
        Me.Ed_Qty.Size = New System.Drawing.Size(143, 22)
        Me.Ed_Qty.StyleController = Me.LayoutControl1
        Me.Ed_Qty.TabIndex = 16
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Size = New System.Drawing.Size(824, 60)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 431)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(824, 22)
        Me.RibbonStatusBar1.Visible = False
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Location = New System.Drawing.Point(657, 293)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(143, 18)
        Me.MemoEdit1.StyleController = Me.LayoutControl1
        Me.MemoEdit1.TabIndex = 15
        '
        'LookUpEdit3
        '
        Me.LookUpEdit3.Location = New System.Drawing.Point(657, 163)
        Me.LookUpEdit3.Name = "LookUpEdit3"
        Me.LookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit3.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 36, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UoMCode", "Uo MCode", 67, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UoMName", "Uo MName", 72, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "Remark", 56, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModifiedUser", "Modified User", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModifiedDate", "Modified Date", 87, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LookUpEdit3.Properties.DataSource = Me.SpMDUoMGetDataBindingSource
        Me.LookUpEdit3.Properties.DisplayMember = "UoMName"
        Me.LookUpEdit3.Properties.ValueMember = "ID"
        Me.LookUpEdit3.Size = New System.Drawing.Size(143, 22)
        Me.LookUpEdit3.StyleController = Me.LayoutControl1
        Me.LookUpEdit3.TabIndex = 14
        '
        'SpMDUoMGetDataBindingSource
        '
        Me.SpMDUoMGetDataBindingSource.DataMember = "sp_MDUoMGetData"
        Me.SpMDUoMGetDataBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LookUpEdit2
        '
        Me.LookUpEdit2.Location = New System.Drawing.Point(657, 137)
        Me.LookUpEdit2.Name = "LookUpEdit2"
        Me.LookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 36, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryNo", "Category No", 80, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Category Name", 98, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 76, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModifiedUser", "Modified User", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LookUpEdit2.Properties.DataSource = Me.SpMDInvCategoryGetDataBindingSource
        Me.LookUpEdit2.Properties.DisplayMember = "CategoryName"
        Me.LookUpEdit2.Properties.ValueMember = "ID"
        Me.LookUpEdit2.Size = New System.Drawing.Size(143, 22)
        Me.LookUpEdit2.StyleController = Me.LayoutControl1
        Me.LookUpEdit2.TabIndex = 13
        '
        'SpMDInvCategoryGetDataBindingSource
        '
        Me.SpMDInvCategoryGetDataBindingSource.DataMember = "sp_MDInvCategory_GetData"
        Me.SpMDInvCategoryGetDataBindingSource.DataSource = Me.DataSet
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(657, 111)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 36, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BrandNo", "Brand No", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BrandName", "Brand Name", 81, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 76, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModifiedUser", "Modified User", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.LookUpEdit1.Properties.DataSource = Me.SpMDInvBrandGetDataBindingSource
        Me.LookUpEdit1.Properties.DisplayMember = "BrandName"
        Me.LookUpEdit1.Properties.ValueMember = "ID"
        Me.LookUpEdit1.Size = New System.Drawing.Size(143, 22)
        Me.LookUpEdit1.StyleController = Me.LayoutControl1
        Me.LookUpEdit1.TabIndex = 12
        '
        'SpMDInvBrandGetDataBindingSource
        '
        Me.SpMDInvBrandGetDataBindingSource.DataMember = "sp_MDInvBrand_GetData"
        Me.SpMDInvBrandGetDataBindingSource.DataSource = Me.DataSet
        '
        'Ed_BarcodeInput
        '
        Me.Ed_BarcodeInput.Location = New System.Drawing.Point(657, 85)
        Me.Ed_BarcodeInput.Name = "Ed_BarcodeInput"
        Me.Ed_BarcodeInput.Size = New System.Drawing.Size(143, 22)
        Me.Ed_BarcodeInput.StyleController = Me.LayoutControl1
        Me.Ed_BarcodeInput.TabIndex = 11
        '
        'Ed_InvName_Input
        '
        Me.Ed_InvName_Input.Location = New System.Drawing.Point(657, 215)
        Me.Ed_InvName_Input.Name = "Ed_InvName_Input"
        Me.Ed_InvName_Input.Size = New System.Drawing.Size(143, 22)
        Me.Ed_InvName_Input.StyleController = Me.LayoutControl1
        Me.Ed_InvName_Input.TabIndex = 10
        '
        'Ed_InvNo_Input
        '
        Me.Ed_InvNo_Input.Location = New System.Drawing.Point(657, 189)
        Me.Ed_InvNo_Input.Name = "Ed_InvNo_Input"
        Me.Ed_InvNo_Input.Size = New System.Drawing.Size(143, 22)
        Me.Ed_InvNo_Input.StyleController = Me.LayoutControl1
        Me.Ed_InvNo_Input.TabIndex = 9
        '
        'SB_Submit
        '
        Me.SB_Submit.Location = New System.Drawing.Point(571, 315)
        Me.SB_Submit.Name = "SB_Submit"
        Me.SB_Submit.Size = New System.Drawing.Size(229, 22)
        Me.SB_Submit.StyleController = Me.LayoutControl1
        Me.SB_Submit.TabIndex = 8
        Me.SB_Submit.Text = "&Submit"
        '
        'SB_Print
        '
        Me.SB_Print.ImageOptions.SvgImage = CType(resources.GetObject("SB_Print.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_Print.Location = New System.Drawing.Point(659, 12)
        Me.SB_Print.Name = "SB_Print"
        Me.SB_Print.Size = New System.Drawing.Size(153, 36)
        Me.SB_Print.StyleController = Me.LayoutControl1
        Me.SB_Print.TabIndex = 7
        Me.SB_Print.Text = "&Print"
        '
        'SB_Refresh
        '
        Me.SB_Refresh.ImageOptions.SvgImage = CType(resources.GetObject("SB_Refresh.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_Refresh.Location = New System.Drawing.Point(503, 12)
        Me.SB_Refresh.Name = "SB_Refresh"
        Me.SB_Refresh.Size = New System.Drawing.Size(152, 36)
        Me.SB_Refresh.StyleController = Me.LayoutControl1
        Me.SB_Refresh.TabIndex = 6
        Me.SB_Refresh.Text = "Refresh"
        '
        'Sp_T_Opname_GetDataGridControl
        '
        Me.Sp_T_Opname_GetDataGridControl.DataSource = Me.Sp_T_Opname_GetDataBindingSource
        Me.Sp_T_Opname_GetDataGridControl.Location = New System.Drawing.Point(12, 52)
        Me.Sp_T_Opname_GetDataGridControl.MainView = Me.GV_Detail
        Me.Sp_T_Opname_GetDataGridControl.Name = "Sp_T_Opname_GetDataGridControl"
        Me.Sp_T_Opname_GetDataGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Repo_LUE_Inv})
        Me.Sp_T_Opname_GetDataGridControl.Size = New System.Drawing.Size(543, 307)
        Me.Sp_T_Opname_GetDataGridControl.TabIndex = 1
        Me.Sp_T_Opname_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Detail})
        '
        'Sp_T_Opname_GetDataBindingSource
        '
        Me.Sp_T_Opname_GetDataBindingSource.DataMember = "sp_T_Opname_GetData"
        Me.Sp_T_Opname_GetDataBindingSource.DataSource = Me.DataSet
        '
        'GV_Detail
        '
        Me.GV_Detail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colNoTransaction, Me.colBarcode, Me.colInventoryID, Me.colQty, Me.colDescription, Me.colModifiedUser, Me.colInventoryNo})
        Me.GV_Detail.GridControl = Me.Sp_T_Opname_GetDataGridControl
        Me.GV_Detail.Name = "GV_Detail"
        Me.GV_Detail.OptionsView.ShowFooter = True
        Me.GV_Detail.OptionsView.ShowIndicator = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.AllowFocus = False
        '
        'colNoTransaction
        '
        Me.colNoTransaction.Caption = "#No"
        Me.colNoTransaction.FieldName = "NoTransaction"
        Me.colNoTransaction.Name = "colNoTransaction"
        Me.colNoTransaction.OptionsColumn.AllowEdit = False
        Me.colNoTransaction.OptionsColumn.AllowFocus = False
        Me.colNoTransaction.OptionsFilter.AllowFilter = False
        Me.colNoTransaction.Visible = True
        Me.colNoTransaction.VisibleIndex = 0
        Me.colNoTransaction.Width = 32
        '
        'colBarcode
        '
        Me.colBarcode.FieldName = "Barcode"
        Me.colBarcode.Name = "colBarcode"
        Me.colBarcode.OptionsColumn.AllowEdit = False
        Me.colBarcode.OptionsColumn.AllowFocus = False
        Me.colBarcode.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Barcode", "{0} Jenis")})
        Me.colBarcode.Visible = True
        Me.colBarcode.VisibleIndex = 1
        Me.colBarcode.Width = 138
        '
        'colInventoryID
        '
        Me.colInventoryID.Caption = "Nama Barang"
        Me.colInventoryID.ColumnEdit = Me.Repo_LUE_Inv
        Me.colInventoryID.FieldName = "InventoryID"
        Me.colInventoryID.Name = "colInventoryID"
        Me.colInventoryID.OptionsColumn.AllowEdit = False
        Me.colInventoryID.OptionsColumn.AllowFocus = False
        Me.colInventoryID.Visible = True
        Me.colInventoryID.VisibleIndex = 3
        Me.colInventoryID.Width = 130
        '
        'Repo_LUE_Inv
        '
        Me.Repo_LUE_Inv.AutoHeight = False
        Me.Repo_LUE_Inv.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_Inv.DataSource = Me.Sp_MDInventory_GetDataBindingSource
        Me.Repo_LUE_Inv.DisplayMember = "InventoryName"
        Me.Repo_LUE_Inv.Name = "Repo_LUE_Inv"
        Me.Repo_LUE_Inv.ValueMember = "ID"
        '
        'Sp_MDInventory_GetDataBindingSource
        '
        Me.Sp_MDInventory_GetDataBindingSource.DataMember = "sp_MDInventory_GetData"
        Me.Sp_MDInventory_GetDataBindingSource.DataSource = Me.DataSet
        '
        'colQty
        '
        Me.colQty.FieldName = "Qty"
        Me.colQty.MaxWidth = 50
        Me.colQty.MinWidth = 50
        Me.colQty.Name = "colQty"
        Me.colQty.OptionsFilter.AllowFilter = False
        Me.colQty.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "Total = {0:n0} barang")})
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 4
        Me.colQty.Width = 50
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 5
        Me.colDescription.Width = 119
        '
        'colModifiedUser
        '
        Me.colModifiedUser.FieldName = "ModifiedUser"
        Me.colModifiedUser.Name = "colModifiedUser"
        '
        'colInventoryNo
        '
        Me.colInventoryNo.Caption = "No. Inventory"
        Me.colInventoryNo.FieldName = "InventoryNo"
        Me.colInventoryNo.Name = "colInventoryNo"
        Me.colInventoryNo.OptionsColumn.AllowEdit = False
        Me.colInventoryNo.OptionsColumn.AllowFocus = False
        Me.colInventoryNo.Visible = True
        Me.colInventoryNo.VisibleIndex = 2
        Me.colInventoryNo.Width = 72
        '
        'Ed_Barcode
        '
        Me.Ed_Barcode.Location = New System.Drawing.Point(273, 12)
        Me.Ed_Barcode.Name = "Ed_Barcode"
        Me.Ed_Barcode.Size = New System.Drawing.Size(226, 22)
        Me.Ed_Barcode.StyleController = Me.LayoutControl1
        Me.Ed_Barcode.TabIndex = 5
        '
        'Ed_NoTransaksi
        '
        Me.Ed_NoTransaksi.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Ed_NoTransaksi.Location = New System.Drawing.Point(98, 12)
        Me.Ed_NoTransaksi.Name = "Ed_NoTransaksi"
        Me.Ed_NoTransaksi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ed_NoTransaksi.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Ed_NoTransaksi.Properties.Mask.EditMask = "n0"
        Me.Ed_NoTransaksi.Size = New System.Drawing.Size(85, 22)
        Me.Ed_NoTransaksi.StyleController = Me.LayoutControl1
        Me.Ed_NoTransaksi.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlGroup2, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(824, 371)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Ed_NoTransaksi
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(175, 40)
        Me.LayoutControlItem1.Text = "No. Transaksi :"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(83, 16)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Ed_Barcode
        Me.LayoutControlItem2.Location = New System.Drawing.Point(175, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(316, 40)
        Me.LayoutControlItem2.Text = "Barcode :"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(83, 16)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem9, Me.EmptySpaceItem1, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(547, 40)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(257, 311)
        Me.LayoutControlGroup2.Text = ".:: Detail ::."
        Me.LayoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Ed_InvName_Input
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 130)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(233, 26)
        Me.LayoutControlItem8.Text = "Inv Name :"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(83, 16)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SB_Submit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 230)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(233, 26)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Ed_InvNo_Input
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(233, 26)
        Me.LayoutControlItem7.Text = "Inv No. :"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(83, 16)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.Ed_BarcodeInput
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(233, 26)
        Me.LayoutControlItem9.Text = "Barcode :"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(83, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 256)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(233, 0)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(233, 10)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(233, 10)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.LookUpEdit1
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(233, 26)
        Me.LayoutControlItem10.Text = "Brand :"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(83, 16)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.LookUpEdit2
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(233, 26)
        Me.LayoutControlItem11.Text = "Category :"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(83, 16)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.LookUpEdit3
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(233, 26)
        Me.LayoutControlItem12.Text = "Satuan :"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(83, 16)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.MemoEdit1
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 208)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(233, 22)
        Me.LayoutControlItem13.Text = "Desc :"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(83, 16)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.Ed_Qty
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 156)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(233, 26)
        Me.LayoutControlItem14.Text = "Qty :"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(83, 16)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SB_Refresh
        Me.LayoutControlItem4.Location = New System.Drawing.Point(491, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(156, 40)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Sp_T_Opname_GetDataGridControl
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(547, 311)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SB_Print
        Me.LayoutControlItem5.Location = New System.Drawing.Point(647, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(157, 40)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'Sp_T_Opname_GetDataTableAdapter
        '
        Me.Sp_T_Opname_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDInventory_GetDataTableAdapter
        '
        Me.Sp_MDInventory_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDInvBrand_GetDataTableAdapter
        '
        Me.Sp_MDInvBrand_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDInvCategory_GetDataTableAdapter
        '
        Me.Sp_MDInvCategory_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDUoMGetDataTableAdapter
        '
        Me.Sp_MDUoMGetDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.sp_MDEmployee_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvBrand_GetDataTableAdapter = Me.Sp_MDInvBrand_GetDataTableAdapter
        Me.TableAdapterManager.sp_MDInvCategory_GetDataTableAdapter = Me.Sp_MDInvCategory_GetDataTableAdapter
        Me.TableAdapterManager.sp_MDInventory_GetDataTableAdapter = Me.Sp_MDInventory_GetDataTableAdapter
        Me.TableAdapterManager.sp_MDInventory_PrintBarcodeListTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvProduct_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_T_Opname_GetDataTableAdapter = Me.Sp_T_Opname_GetDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = Master_Data.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Ed_KodeHarga
        '
        Me.Ed_KodeHarga.Location = New System.Drawing.Point(657, 267)
        Me.Ed_KodeHarga.MenuManager = Me.RibbonControl1
        Me.Ed_KodeHarga.Name = "Ed_KodeHarga"
        Me.Ed_KodeHarga.Size = New System.Drawing.Size(143, 22)
        Me.Ed_KodeHarga.StyleController = Me.LayoutControl1
        Me.Ed_KodeHarga.TabIndex = 17
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.Ed_KodeHarga
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 182)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(233, 26)
        Me.LayoutControlItem15.Text = "Kode Harga :"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(83, 16)
        '
        'Frm_InputStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 453)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "Frm_InputStock"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Input Stock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Ed_Qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpMDUoMGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpMDInvCategoryGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpMDInvBrandGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_BarcodeInput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_InvName_Input.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_InvNo_Input.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_T_Opname_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_T_Opname_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_Inv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInventory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Barcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_NoTransaksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_KodeHarga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Ed_Barcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sp_T_Opname_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Detail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sp_T_Opname_GetDataBindingSource As BindingSource
    Friend WithEvents DataSet As DataSet
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoTransaction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Repo_LUE_Inv As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Sp_T_Opname_GetDataTableAdapter As DataSetTableAdapters.sp_T_Opname_GetDataTableAdapter
    Friend WithEvents Sp_MDInventory_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDInventory_GetDataTableAdapter As DataSetTableAdapters.sp_MDInventory_GetDataTableAdapter
    Friend WithEvents QueriesTableAdapter As DataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents SB_Refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Ed_NoTransaksi As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Ed_BarcodeInput As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_InvName_Input As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_InvNo_Input As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SB_Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_Print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LookUpEdit3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SpMDUoMGetDataBindingSource As BindingSource
    Friend WithEvents LookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SpMDInvCategoryGetDataBindingSource As BindingSource
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SpMDInvBrandGetDataBindingSource As BindingSource
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sp_MDInvBrand_GetDataTableAdapter As DataSetTableAdapters.sp_MDInvBrand_GetDataTableAdapter
    Friend WithEvents Sp_MDInvCategory_GetDataTableAdapter As DataSetTableAdapters.sp_MDInvCategory_GetDataTableAdapter
    Friend WithEvents Sp_MDUoMGetDataTableAdapter As DataSetTableAdapters.sp_MDUoMGetDataTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Friend WithEvents colInventoryNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents Ed_Qty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Ed_KodeHarga As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
End Class
