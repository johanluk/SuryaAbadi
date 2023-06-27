<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_InvList
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_InvList))
        Me.SB_Exit = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Sp_MDInventory_GetHPPHistoryGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_MDInventory_GetHPPHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New Master_Data.DataSet()
        Me.GV_HPP = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_HPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMRNo_HPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMRDate_HPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupplierName_HPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHPP_HPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BBI_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BI_Search = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchControl1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.Sp_MDInventory_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.sp_MDInventory_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_Detail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrandID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_Brand = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Sp_MDInvBrand_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_Category = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Sp_MDInvCategory_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_Product = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Sp_MDInvProduct_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colUoMID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_LUE_UoM = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Sp_MDUoMGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colMinStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaxStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Repo_Num = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colHPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStokAwal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStokAkhir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKodeHarga = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDisc1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDisc2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrosir1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrosir2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrosir3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriceBuy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPageCategory1 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SpMDInventoryGetTransactionDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colInventoryNo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesPOSNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesPOSDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOpname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransaksi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabNavigationPage3 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.FlyoutPanel1 = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl1 = New DevExpress.Utils.FlyoutPanelControl()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SB_BarcodePrice = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.Sp_MDInventory_PrintBarcodeListGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_MDInventory_PrintBarcodeListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_Barcode = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBarcode_List = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryNo_List = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty_List = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepoNum_Barcode = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPrice_List = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryID_List = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SearchControl1 = New DevExpress.XtraEditors.SearchControl()
        Me.SB_BarcodePrint = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.NavigationFrame1 = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.sp_MDInventory_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInventory_GetDataTableAdapter()
        Me.TableAdapterManager = New Master_Data.DataSetTableAdapters.TableAdapterManager()
        Me.Sp_MDInventory_PrintBarcodeListTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInventory_PrintBarcodeListTableAdapter()
        Me.AlertControl = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me.DxErrorProvider = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Sp_MDInvBrand_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInvBrand_GetDataTableAdapter()
        Me.Sp_MDInvCategory_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInvCategory_GetDataTableAdapter()
        Me.Sp_MDInvProduct_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInvProduct_GetDataTableAdapter()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.QueriesTableAdapter = New Master_Data.DataSetTableAdapters.QueriesTableAdapter()
        Me.Sp_MDUoMGetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDUoMGetDataTableAdapter()
        Me.Sp_MDInventory_GetTransactionDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInventory_GetTransactionDataTableAdapter()
        Me.Sp_MDInventory_GetHPPHistoryTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDInventory_GetHPPHistoryTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Sp_MDInventory_GetHPPHistoryGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInventory_GetHPPHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_HPP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInventory_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_MDInventory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_Brand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInvBrand_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_Category, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInvCategory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInvProduct_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_LUE_UoM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDUoMGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repo_Num, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabNavigationPage1.SuspendLayout()
        Me.TabNavigationPage2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpMDInventoryGetTransactionDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage3.SuspendLayout()
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel1.SuspendLayout()
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanelControl1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInventory_PrintBarcodeListGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDInventory_PrintBarcodeListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Barcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepoNum_Barcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationFrame1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SB_Exit
        '
        Me.SB_Exit.ImageOptions.SvgImage = CType(resources.GetObject("SB_Exit.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_Exit.Location = New System.Drawing.Point(14, 542)
        Me.SB_Exit.Name = "SB_Exit"
        Me.SB_Exit.Size = New System.Drawing.Size(72, 36)
        Me.SB_Exit.StyleController = Me.LayoutControl1
        Me.SB_Exit.TabIndex = 16
        Me.SB_Exit.Text = "&Exit"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.Sp_MDInventory_GetHPPHistoryGridControl)
        Me.LayoutControl1.Controls.Add(Me.TabPane1)
        Me.LayoutControl1.Controls.Add(Me.SB_BarcodePrice)
        Me.LayoutControl1.Controls.Add(Me.SB_Refresh)
        Me.LayoutControl1.Controls.Add(Me.Sp_MDInventory_PrintBarcodeListGridControl)
        Me.LayoutControl1.Controls.Add(Me.SearchControl1)
        Me.LayoutControl1.Controls.Add(Me.SB_BarcodePrint)
        Me.LayoutControl1.Controls.Add(Me.SB_Exit)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(318, 217, 432, 350)
        Me.LayoutControl1.Padding = New System.Windows.Forms.Padding(6)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(1315, 592)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Sp_MDInventory_GetHPPHistoryGridControl
        '
        Me.Sp_MDInventory_GetHPPHistoryGridControl.DataSource = Me.Sp_MDInventory_GetHPPHistoryBindingSource
        Me.Sp_MDInventory_GetHPPHistoryGridControl.Location = New System.Drawing.Point(962, 65)
        Me.Sp_MDInventory_GetHPPHistoryGridControl.MainView = Me.GV_HPP
        Me.Sp_MDInventory_GetHPPHistoryGridControl.MenuManager = Me.RibbonControl1
        Me.Sp_MDInventory_GetHPPHistoryGridControl.Name = "Sp_MDInventory_GetHPPHistoryGridControl"
        Me.Sp_MDInventory_GetHPPHistoryGridControl.Size = New System.Drawing.Size(327, 501)
        Me.Sp_MDInventory_GetHPPHistoryGridControl.TabIndex = 22
        Me.Sp_MDInventory_GetHPPHistoryGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_HPP})
        '
        'Sp_MDInventory_GetHPPHistoryBindingSource
        '
        Me.Sp_MDInventory_GetHPPHistoryBindingSource.DataMember = "sp_MDInventory_GetHPPHistory"
        Me.Sp_MDInventory_GetHPPHistoryBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GV_HPP
        '
        Me.GV_HPP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_HPP, Me.colMRNo_HPP, Me.colMRDate_HPP, Me.colSupplierName_HPP, Me.colHPP_HPP})
        Me.GV_HPP.GridControl = Me.Sp_MDInventory_GetHPPHistoryGridControl
        Me.GV_HPP.Name = "GV_HPP"
        Me.GV_HPP.OptionsView.ShowGroupPanel = False
        '
        'colID_HPP
        '
        Me.colID_HPP.FieldName = "ID"
        Me.colID_HPP.Name = "colID_HPP"
        Me.colID_HPP.OptionsColumn.AllowEdit = False
        Me.colID_HPP.OptionsColumn.AllowFocus = False
        '
        'colMRNo_HPP
        '
        Me.colMRNo_HPP.FieldName = "MRNo"
        Me.colMRNo_HPP.Name = "colMRNo_HPP"
        Me.colMRNo_HPP.OptionsColumn.AllowEdit = False
        Me.colMRNo_HPP.OptionsColumn.AllowFocus = False
        Me.colMRNo_HPP.Visible = True
        Me.colMRNo_HPP.VisibleIndex = 3
        '
        'colMRDate_HPP
        '
        Me.colMRDate_HPP.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colMRDate_HPP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colMRDate_HPP.FieldName = "MRDate"
        Me.colMRDate_HPP.Name = "colMRDate_HPP"
        Me.colMRDate_HPP.OptionsColumn.AllowEdit = False
        Me.colMRDate_HPP.OptionsColumn.AllowFocus = False
        Me.colMRDate_HPP.Visible = True
        Me.colMRDate_HPP.VisibleIndex = 2
        '
        'colSupplierName_HPP
        '
        Me.colSupplierName_HPP.FieldName = "SupplierName"
        Me.colSupplierName_HPP.Name = "colSupplierName_HPP"
        Me.colSupplierName_HPP.OptionsColumn.AllowEdit = False
        Me.colSupplierName_HPP.OptionsColumn.AllowFocus = False
        Me.colSupplierName_HPP.Visible = True
        Me.colSupplierName_HPP.VisibleIndex = 1
        '
        'colHPP_HPP
        '
        Me.colHPP_HPP.DisplayFormat.FormatString = "n0"
        Me.colHPP_HPP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHPP_HPP.FieldName = "HPP"
        Me.colHPP_HPP.Name = "colHPP_HPP"
        Me.colHPP_HPP.OptionsColumn.AllowEdit = False
        Me.colHPP_HPP.OptionsColumn.AllowFocus = False
        Me.colHPP_HPP.Visible = True
        Me.colHPP_HPP.VisibleIndex = 0
        '
        'RibbonControl1
        '
        Me.RibbonControl1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("a", New System.Guid("cfe14a9d-4219-46dd-9464-7c5104465a20"))})
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.BBI_Close, Me.BarButtonItem2, Me.BI_Search})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RibbonControl1.MaxItemId = 5
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.RibbonPageCategory1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl1})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal
        Me.RibbonControl1.Size = New System.Drawing.Size(1315, 95)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'BBI_Close
        '
        Me.BBI_Close.Caption = "Close"
        Me.BBI_Close.Id = 1
        Me.BBI_Close.ImageOptions.Image = CType(resources.GetObject("BBI_Close.ImageOptions.Image"), System.Drawing.Image)
        Me.BBI_Close.ImageOptions.LargeImage = CType(resources.GetObject("BBI_Close.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BBI_Close.Name = "BBI_Close"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Refresh"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BI_Search
        '
        Me.BI_Search.Caption = "Find Inventory :"
        Me.BI_Search.Edit = Me.RepositoryItemSearchControl1
        Me.BI_Search.EditWidth = 200
        Me.BI_Search.Id = 4
        Me.BI_Search.Name = "BI_Search"
        '
        'RepositoryItemSearchControl1
        '
        Me.RepositoryItemSearchControl1.AutoHeight = False
        Me.RepositoryItemSearchControl1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.RepositoryItemSearchControl1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemSearchControl1.Client = Me.Sp_MDInventory_GetDataGridControl
        Me.RepositoryItemSearchControl1.Name = "RepositoryItemSearchControl1"
        '
        'Sp_MDInventory_GetDataGridControl
        '
        Me.Sp_MDInventory_GetDataGridControl.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.Sp_MDInventory_GetDataGridControl.DataSource = Me.sp_MDInventory_GetDataBindingSource
        Me.Sp_MDInventory_GetDataGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sp_MDInventory_GetDataGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Sp_MDInventory_GetDataGridControl.Location = New System.Drawing.Point(0, 0)
        Me.Sp_MDInventory_GetDataGridControl.MainView = Me.GV_Detail
        Me.Sp_MDInventory_GetDataGridControl.Name = "Sp_MDInventory_GetDataGridControl"
        Me.Sp_MDInventory_GetDataGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.Repo_LUE_Brand, Me.Repo_LUE_Category, Me.Repo_LUE_Product, Me.Repo_Num, Me.Repo_LUE_UoM})
        Me.Sp_MDInventory_GetDataGridControl.Size = New System.Drawing.Size(910, 476)
        Me.Sp_MDInventory_GetDataGridControl.TabIndex = 13
        Me.Sp_MDInventory_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Detail})
        '
        'sp_MDInventory_GetDataBindingSource
        '
        Me.sp_MDInventory_GetDataBindingSource.DataMember = "sp_MDInventory_GetData"
        Me.sp_MDInventory_GetDataBindingSource.DataSource = Me.DataSet
        '
        'GV_Detail
        '
        Me.GV_Detail.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.GV_Detail.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_Detail.Appearance.Row.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.GV_Detail.Appearance.Row.Options.UseFont = True
        Me.GV_Detail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colInventoryNo, Me.colInventoryName, Me.colBrandID, Me.colCategoryID, Me.colProductID, Me.colUoMID, Me.colMinStock, Me.colMaxStock, Me.colDescription, Me.colModifiedUser, Me.colBarcode, Me.colPrice, Me.colHPP, Me.colStokAwal, Me.colStokAkhir, Me.colKodeHarga, Me.colDisc1, Me.colDisc2, Me.colisActive, Me.colGrosir1, Me.colGrosir2, Me.colGrosir3, Me.colPriceBuy})
        Me.GV_Detail.GridControl = Me.Sp_MDInventory_GetDataGridControl
        Me.GV_Detail.Name = "GV_Detail"
        Me.GV_Detail.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow
        Me.GV_Detail.OptionsEditForm.EditFormColumnCount = 5
        Me.GV_Detail.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV_Detail.OptionsFind.AlwaysVisible = True
        Me.GV_Detail.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_Detail.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_Detail.OptionsView.ShowGroupPanel = False
        Me.GV_Detail.OptionsView.ShowIndicator = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.AllowFocus = False
        Me.colID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
        '
        'colInventoryNo
        '
        Me.colInventoryNo.Caption = "Kode"
        Me.colInventoryNo.FieldName = "InventoryNo"
        Me.colInventoryNo.MaxWidth = 120
        Me.colInventoryNo.MinWidth = 120
        Me.colInventoryNo.Name = "colInventoryNo"
        Me.colInventoryNo.OptionsEditForm.VisibleIndex = 11
        Me.colInventoryNo.OptionsFilter.AllowFilter = False
        Me.colInventoryNo.Visible = True
        Me.colInventoryNo.VisibleIndex = 0
        Me.colInventoryNo.Width = 120
        '
        'colInventoryName
        '
        Me.colInventoryName.Caption = "Nama"
        Me.colInventoryName.FieldName = "InventoryName"
        Me.colInventoryName.Name = "colInventoryName"
        Me.colInventoryName.OptionsEditForm.Caption = "Nama :"
        Me.colInventoryName.OptionsEditForm.ColumnSpan = 2
        Me.colInventoryName.OptionsEditForm.UseEditorColRowSpan = False
        Me.colInventoryName.OptionsEditForm.VisibleIndex = 13
        Me.colInventoryName.OptionsFilter.AllowFilter = False
        Me.colInventoryName.Visible = True
        Me.colInventoryName.VisibleIndex = 2
        Me.colInventoryName.Width = 121
        '
        'colBrandID
        '
        Me.colBrandID.Caption = "Brand"
        Me.colBrandID.ColumnEdit = Me.Repo_LUE_Brand
        Me.colBrandID.FieldName = "InventoryBrandID"
        Me.colBrandID.MaxWidth = 120
        Me.colBrandID.MinWidth = 120
        Me.colBrandID.Name = "colBrandID"
        Me.colBrandID.OptionsEditForm.Caption = "Merk :"
        Me.colBrandID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colBrandID.OptionsEditForm.VisibleIndex = 23
        Me.colBrandID.OptionsFilter.AllowFilter = False
        Me.colBrandID.Width = 120
        '
        'Repo_LUE_Brand
        '
        Me.Repo_LUE_Brand.AutoHeight = False
        Me.Repo_LUE_Brand.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_Brand.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 36, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BrandNo", "Brand No", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BrandName", "Brand Name", 81, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 76, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModifiedUser", "Modified User", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.Repo_LUE_Brand.DataSource = Me.Sp_MDInvBrand_GetDataBindingSource
        Me.Repo_LUE_Brand.DisplayMember = "BrandName"
        Me.Repo_LUE_Brand.Name = "Repo_LUE_Brand"
        Me.Repo_LUE_Brand.ValueMember = "ID"
        '
        'Sp_MDInvBrand_GetDataBindingSource
        '
        Me.Sp_MDInvBrand_GetDataBindingSource.DataMember = "sp_MDInvBrand_GetData"
        Me.Sp_MDInvBrand_GetDataBindingSource.DataSource = Me.DataSet
        '
        'colCategoryID
        '
        Me.colCategoryID.Caption = "Kategori"
        Me.colCategoryID.ColumnEdit = Me.Repo_LUE_Category
        Me.colCategoryID.FieldName = "InventoryCategoryID"
        Me.colCategoryID.MaxWidth = 150
        Me.colCategoryID.MinWidth = 150
        Me.colCategoryID.Name = "colCategoryID"
        Me.colCategoryID.OptionsEditForm.Caption = "Kategori :"
        Me.colCategoryID.OptionsEditForm.StartNewRow = True
        Me.colCategoryID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colCategoryID.OptionsEditForm.VisibleIndex = 21
        Me.colCategoryID.OptionsFilter.AllowFilter = False
        Me.colCategoryID.Width = 150
        '
        'Repo_LUE_Category
        '
        Me.Repo_LUE_Category.AutoHeight = False
        Me.Repo_LUE_Category.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_Category.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 36, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryNo", "Category No", 80, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Category Name", 98, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 76, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModifiedUser", "Modified User", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.Repo_LUE_Category.DataSource = Me.Sp_MDInvCategory_GetDataBindingSource
        Me.Repo_LUE_Category.DisplayMember = "CategoryName"
        Me.Repo_LUE_Category.Name = "Repo_LUE_Category"
        Me.Repo_LUE_Category.ValueMember = "ID"
        '
        'Sp_MDInvCategory_GetDataBindingSource
        '
        Me.Sp_MDInvCategory_GetDataBindingSource.DataMember = "sp_MDInvCategory_GetData"
        Me.Sp_MDInvCategory_GetDataBindingSource.DataSource = Me.DataSet
        '
        'colProductID
        '
        Me.colProductID.Caption = "Produk"
        Me.colProductID.ColumnEdit = Me.Repo_LUE_Product
        Me.colProductID.FieldName = "InventoryProductID"
        Me.colProductID.Name = "colProductID"
        Me.colProductID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colProductID.OptionsEditForm.VisibleIndex = 22
        Me.colProductID.OptionsFilter.AllowFilter = False
        Me.colProductID.Width = 129
        '
        'Repo_LUE_Product
        '
        Me.Repo_LUE_Product.AutoHeight = False
        Me.Repo_LUE_Product.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_Product.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 36, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductNo", "Product No", 73, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name", 91, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 76, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModifiedUser", "Modified User", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.Repo_LUE_Product.DataSource = Me.Sp_MDInvProduct_GetDataBindingSource
        Me.Repo_LUE_Product.DisplayMember = "ProductName"
        Me.Repo_LUE_Product.Name = "Repo_LUE_Product"
        Me.Repo_LUE_Product.ValueMember = "ID"
        '
        'Sp_MDInvProduct_GetDataBindingSource
        '
        Me.Sp_MDInvProduct_GetDataBindingSource.DataMember = "sp_MDInvProduct_GetData"
        Me.Sp_MDInvProduct_GetDataBindingSource.DataSource = Me.DataSet
        '
        'colUoMID
        '
        Me.colUoMID.Caption = "Satuan"
        Me.colUoMID.ColumnEdit = Me.Repo_LUE_UoM
        Me.colUoMID.FieldName = "UoMID"
        Me.colUoMID.Name = "colUoMID"
        Me.colUoMID.OptionsEditForm.Caption = "Satuan :"
        Me.colUoMID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[True]
        Me.colUoMID.OptionsEditForm.VisibleIndex = 24
        Me.colUoMID.OptionsFilter.AllowFilter = False
        Me.colUoMID.Width = 90
        '
        'Repo_LUE_UoM
        '
        Me.Repo_LUE_UoM.AutoHeight = False
        Me.Repo_LUE_UoM.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Repo_LUE_UoM.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 36, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UoMCode", "Uo MCode", 67, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("UoMName", "Uo MName", 72, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "Remark", 56, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModifiedUser", "Modified User", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModifiedDate", "Modified Date", 87, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.Repo_LUE_UoM.DataSource = Me.Sp_MDUoMGetDataBindingSource
        Me.Repo_LUE_UoM.DisplayMember = "UoMName"
        Me.Repo_LUE_UoM.Name = "Repo_LUE_UoM"
        Me.Repo_LUE_UoM.ValueMember = "ID"
        '
        'Sp_MDUoMGetDataBindingSource
        '
        Me.Sp_MDUoMGetDataBindingSource.DataMember = "sp_MDUoMGetData"
        Me.Sp_MDUoMGetDataBindingSource.DataSource = Me.DataSet
        '
        'colMinStock
        '
        Me.colMinStock.FieldName = "MinStock"
        Me.colMinStock.Name = "colMinStock"
        '
        'colMaxStock
        '
        Me.colMaxStock.FieldName = "MaxStock"
        Me.colMaxStock.Name = "colMaxStock"
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.MaxWidth = 150
        Me.colDescription.MinWidth = 150
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.None
        Me.colDescription.OptionsEditForm.ColumnSpan = 4
        Me.colDescription.OptionsEditForm.StartNewRow = True
        Me.colDescription.OptionsEditForm.UseEditorColRowSpan = False
        Me.colDescription.OptionsEditForm.VisibleIndex = 51
        Me.colDescription.OptionsFilter.AllowFilter = False
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 3
        Me.colDescription.Width = 150
        '
        'colModifiedUser
        '
        Me.colModifiedUser.FieldName = "ModifiedUser"
        Me.colModifiedUser.Name = "colModifiedUser"
        Me.colModifiedUser.OptionsColumn.AllowEdit = False
        Me.colModifiedUser.OptionsColumn.AllowFocus = False
        '
        'colBarcode
        '
        Me.colBarcode.FieldName = "Barcode"
        Me.colBarcode.MaxWidth = 110
        Me.colBarcode.MinWidth = 110
        Me.colBarcode.Name = "colBarcode"
        Me.colBarcode.OptionsEditForm.VisibleIndex = 12
        Me.colBarcode.OptionsFilter.AllowFilter = False
        Me.colBarcode.Visible = True
        Me.colBarcode.VisibleIndex = 1
        Me.colBarcode.Width = 110
        '
        'colPrice
        '
        Me.colPrice.Caption = "Harga Retail"
        Me.colPrice.ColumnEdit = Me.Repo_Num
        Me.colPrice.FieldName = "Price"
        Me.colPrice.MaxWidth = 100
        Me.colPrice.MinWidth = 100
        Me.colPrice.Name = "colPrice"
        Me.colPrice.OptionsEditForm.Caption = "Retail:"
        Me.colPrice.OptionsEditForm.StartNewRow = True
        Me.colPrice.OptionsEditForm.VisibleIndex = 41
        Me.colPrice.OptionsFilter.AllowFilter = False
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 4
        Me.colPrice.Width = 100
        '
        'Repo_Num
        '
        Me.Repo_Num.AutoHeight = False
        Me.Repo_Num.Mask.EditMask = "n0"
        Me.Repo_Num.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Repo_Num.Mask.UseMaskAsDisplayFormat = True
        Me.Repo_Num.Name = "Repo_Num"
        '
        'colHPP
        '
        Me.colHPP.ColumnEdit = Me.Repo_Num
        Me.colHPP.FieldName = "HPP"
        Me.colHPP.Name = "colHPP"
        Me.colHPP.Width = 45
        '
        'colStokAwal
        '
        Me.colStokAwal.ColumnEdit = Me.Repo_Num
        Me.colStokAwal.FieldName = "StokAwal"
        Me.colStokAwal.Name = "colStokAwal"
        Me.colStokAwal.Width = 45
        '
        'colStokAkhir
        '
        Me.colStokAkhir.FieldName = "StokAkhir"
        Me.colStokAkhir.Name = "colStokAkhir"
        Me.colStokAkhir.OptionsColumn.AllowEdit = False
        Me.colStokAkhir.OptionsColumn.AllowFocus = False
        Me.colStokAkhir.Width = 48
        '
        'colKodeHarga
        '
        Me.colKodeHarga.FieldName = "KodeHarga"
        Me.colKodeHarga.Name = "colKodeHarga"
        Me.colKodeHarga.Width = 61
        '
        'colDisc1
        '
        Me.colDisc1.ColumnEdit = Me.Repo_Num
        Me.colDisc1.FieldName = "Disc1"
        Me.colDisc1.Name = "colDisc1"
        '
        'colDisc2
        '
        Me.colDisc2.ColumnEdit = Me.Repo_Num
        Me.colDisc2.FieldName = "Disc2"
        Me.colDisc2.Name = "colDisc2"
        '
        'colisActive
        '
        Me.colisActive.Caption = " "
        Me.colisActive.FieldName = "isActive"
        Me.colisActive.MaxWidth = 20
        Me.colisActive.Name = "colisActive"
        Me.colisActive.OptionsEditForm.Caption = "Barang Aktif"
        Me.colisActive.OptionsEditForm.VisibleIndex = 15
        Me.colisActive.OptionsFilter.AllowFilter = False
        Me.colisActive.Visible = True
        Me.colisActive.VisibleIndex = 8
        Me.colisActive.Width = 20
        '
        'colGrosir1
        '
        Me.colGrosir1.Caption = "Grosir 1"
        Me.colGrosir1.ColumnEdit = Me.Repo_Num
        Me.colGrosir1.FieldName = "Grosir1"
        Me.colGrosir1.MaxWidth = 80
        Me.colGrosir1.MinWidth = 80
        Me.colGrosir1.Name = "colGrosir1"
        Me.colGrosir1.OptionsColumn.AllowMove = False
        Me.colGrosir1.OptionsColumn.AllowSize = False
        Me.colGrosir1.OptionsEditForm.VisibleIndex = 42
        Me.colGrosir1.OptionsFilter.AllowFilter = False
        Me.colGrosir1.Visible = True
        Me.colGrosir1.VisibleIndex = 5
        Me.colGrosir1.Width = 80
        '
        'colGrosir2
        '
        Me.colGrosir2.Caption = "Grosir 2"
        Me.colGrosir2.ColumnEdit = Me.Repo_Num
        Me.colGrosir2.FieldName = "Grosir2"
        Me.colGrosir2.MaxWidth = 80
        Me.colGrosir2.MinWidth = 80
        Me.colGrosir2.Name = "colGrosir2"
        Me.colGrosir2.OptionsColumn.AllowMove = False
        Me.colGrosir2.OptionsColumn.AllowSize = False
        Me.colGrosir2.OptionsEditForm.VisibleIndex = 43
        Me.colGrosir2.OptionsFilter.AllowFilter = False
        Me.colGrosir2.Visible = True
        Me.colGrosir2.VisibleIndex = 6
        Me.colGrosir2.Width = 80
        '
        'colGrosir3
        '
        Me.colGrosir3.Caption = "Grosir 3"
        Me.colGrosir3.ColumnEdit = Me.Repo_Num
        Me.colGrosir3.FieldName = "Grosir3"
        Me.colGrosir3.MaxWidth = 80
        Me.colGrosir3.MinWidth = 80
        Me.colGrosir3.Name = "colGrosir3"
        Me.colGrosir3.OptionsColumn.AllowMove = False
        Me.colGrosir3.OptionsColumn.AllowSize = False
        Me.colGrosir3.OptionsEditForm.VisibleIndex = 44
        Me.colGrosir3.OptionsFilter.AllowFilter = False
        Me.colGrosir3.Visible = True
        Me.colGrosir3.VisibleIndex = 7
        Me.colGrosir3.Width = 80
        '
        'colPriceBuy
        '
        Me.colPriceBuy.Caption = "Harga Beli"
        Me.colPriceBuy.ColumnEdit = Me.Repo_Num
        Me.colPriceBuy.FieldName = "PriceBuy"
        Me.colPriceBuy.MaxWidth = 80
        Me.colPriceBuy.MinWidth = 80
        Me.colPriceBuy.Name = "colPriceBuy"
        Me.colPriceBuy.OptionsEditForm.VisibleIndex = 52
        Me.colPriceBuy.OptionsFilter.AllowFilter = False
        Me.colPriceBuy.Visible = True
        Me.colPriceBuy.VisibleIndex = 9
        Me.colPriceBuy.Width = 80
        '
        'RibbonPageCategory1
        '
        Me.RibbonPageCategory1.Name = "RibbonPageCategory1"
        Me.RibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonPageCategory1.Text = "RibbonPageCategory1"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Detail"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = " "
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BBI_Close)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = " "
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BI_Search)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 687)
        Me.RibbonStatusBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1315, 22)
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage3)
        Me.TabPane1.Location = New System.Drawing.Point(2, 10)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2, Me.TabNavigationPage3})
        Me.TabPane1.RegularSize = New System.Drawing.Size(910, 516)
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(910, 516)
        Me.TabPane1.TabIndex = 21
        Me.TabPane1.Text = "TabPane1"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "Halaman 1"
        Me.TabNavigationPage1.Controls.Add(Me.Sp_MDInventory_GetDataGridControl)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(910, 476)
        '
        'TabNavigationPage2
        '
        Me.TabNavigationPage2.Caption = "Halaman Detail "
        Me.TabNavigationPage2.Controls.Add(Me.GridControl1)
        Me.TabNavigationPage2.Name = "TabNavigationPage2"
        Me.TabNavigationPage2.Size = New System.Drawing.Size(910, 476)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.SpMDInventoryGetTransactionDataBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(809, 476)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SpMDInventoryGetTransactionDataBindingSource
        '
        Me.SpMDInventoryGetTransactionDataBindingSource.DataMember = "sp_MDInventory_GetTransactionData"
        Me.SpMDInventoryGetTransactionDataBindingSource.DataSource = Me.DataSet
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInventoryNo1, Me.colInventoryName1, Me.colSalesPOSNo, Me.colSalesPOSDate, Me.colOpname, Me.colTransaksi})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colInventoryNo1
        '
        Me.colInventoryNo1.FieldName = "InventoryNo"
        Me.colInventoryNo1.Name = "colInventoryNo1"
        Me.colInventoryNo1.OptionsColumn.AllowEdit = False
        Me.colInventoryNo1.OptionsColumn.AllowFocus = False
        Me.colInventoryNo1.Visible = True
        Me.colInventoryNo1.VisibleIndex = 0
        '
        'colInventoryName1
        '
        Me.colInventoryName1.FieldName = "InventoryName"
        Me.colInventoryName1.Name = "colInventoryName1"
        Me.colInventoryName1.OptionsColumn.AllowEdit = False
        Me.colInventoryName1.OptionsColumn.AllowFocus = False
        Me.colInventoryName1.Visible = True
        Me.colInventoryName1.VisibleIndex = 1
        '
        'colSalesPOSNo
        '
        Me.colSalesPOSNo.FieldName = "SalesPOSNo"
        Me.colSalesPOSNo.Name = "colSalesPOSNo"
        Me.colSalesPOSNo.OptionsColumn.AllowEdit = False
        Me.colSalesPOSNo.OptionsColumn.AllowFocus = False
        Me.colSalesPOSNo.Visible = True
        Me.colSalesPOSNo.VisibleIndex = 2
        '
        'colSalesPOSDate
        '
        Me.colSalesPOSDate.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colSalesPOSDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colSalesPOSDate.FieldName = "SalesPOSDate"
        Me.colSalesPOSDate.Name = "colSalesPOSDate"
        Me.colSalesPOSDate.OptionsColumn.AllowEdit = False
        Me.colSalesPOSDate.OptionsColumn.AllowFocus = False
        Me.colSalesPOSDate.Visible = True
        Me.colSalesPOSDate.VisibleIndex = 3
        '
        'colOpname
        '
        Me.colOpname.DisplayFormat.FormatString = "n0"
        Me.colOpname.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOpname.FieldName = "Opname"
        Me.colOpname.Name = "colOpname"
        Me.colOpname.OptionsColumn.AllowEdit = False
        Me.colOpname.OptionsColumn.AllowFocus = False
        Me.colOpname.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Opname", "{0:n0}")})
        Me.colOpname.Visible = True
        Me.colOpname.VisibleIndex = 4
        '
        'colTransaksi
        '
        Me.colTransaksi.DisplayFormat.FormatString = "n0"
        Me.colTransaksi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTransaksi.FieldName = "Transaksi"
        Me.colTransaksi.Name = "colTransaksi"
        Me.colTransaksi.OptionsColumn.AllowEdit = False
        Me.colTransaksi.OptionsColumn.AllowFocus = False
        Me.colTransaksi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Transaksi", "{0:n0}")})
        Me.colTransaksi.Visible = True
        Me.colTransaksi.VisibleIndex = 5
        '
        'TabNavigationPage3
        '
        Me.TabNavigationPage3.Caption = "TabNavigationPage3"
        Me.TabNavigationPage3.Controls.Add(Me.FlyoutPanel1)
        Me.TabNavigationPage3.Name = "TabNavigationPage3"
        Me.TabNavigationPage3.Size = New System.Drawing.Size(910, 476)
        '
        'FlyoutPanel1
        '
        Me.FlyoutPanel1.Controls.Add(Me.FlyoutPanelControl1)
        Me.FlyoutPanel1.Location = New System.Drawing.Point(141, 46)
        Me.FlyoutPanel1.Name = "FlyoutPanel1"
        Me.FlyoutPanel1.OwnerControl = Me.TabPane1
        Me.FlyoutPanel1.Size = New System.Drawing.Size(333, 117)
        Me.FlyoutPanel1.TabIndex = 0
        '
        'FlyoutPanelControl1
        '
        Me.FlyoutPanelControl1.Controls.Add(Me.LayoutControl2)
        Me.FlyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl1.FlyoutPanel = Me.FlyoutPanel1
        Me.FlyoutPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl1.Name = "FlyoutPanelControl1"
        Me.FlyoutPanelControl1.Size = New System.Drawing.Size(333, 117)
        Me.FlyoutPanelControl1.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.CheckEdit2)
        Me.LayoutControl2.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl2.Controls.Add(Me.LabelControl1)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(2, 2)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Padding = New System.Windows.Forms.Padding(5)
        Me.LayoutControl2.Root = Me.Root
        Me.LayoutControl2.Size = New System.Drawing.Size(329, 113)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(149, 40)
        Me.CheckEdit2.MenuManager = Me.RibbonControl1
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = "Original Barcode"
        Me.CheckEdit2.Size = New System.Drawing.Size(123, 20)
        Me.CheckEdit2.StyleController = Me.LayoutControl2
        Me.CheckEdit2.TabIndex = 6
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(12, 40)
        Me.CheckEdit1.MenuManager = Me.RibbonControl1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Enabled Inventory"
        Me.CheckEdit1.Size = New System.Drawing.Size(133, 20)
        Me.CheckEdit1.StyleController = Me.LayoutControl2
        Me.CheckEdit1.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Bahnschrift", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 24)
        Me.LabelControl1.StyleController = Me.LayoutControl2
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Filter"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem10, Me.EmptySpaceItem2, Me.LayoutControlItem11})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(329, 113)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.LabelControl1
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(309, 28)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.CheckEdit1
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(137, 65)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(264, 28)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(45, 65)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.CheckEdit2
        Me.LayoutControlItem11.Location = New System.Drawing.Point(137, 28)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(127, 65)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'SB_BarcodePrice
        '
        Me.SB_BarcodePrice.ImageOptions.SvgImage = CType(resources.GetObject("SB_BarcodePrice.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_BarcodePrice.Location = New System.Drawing.Point(962, 490)
        Me.SB_BarcodePrice.Name = "SB_BarcodePrice"
        Me.SB_BarcodePrice.Size = New System.Drawing.Size(327, 36)
        Me.SB_BarcodePrice.StyleController = Me.LayoutControl1
        Me.SB_BarcodePrice.TabIndex = 20
        Me.SB_BarcodePrice.Text = "&Barcode Print"
        '
        'SB_Refresh
        '
        Me.SB_Refresh.ImageOptions.SvgImage = CType(resources.GetObject("SB_Refresh.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_Refresh.Location = New System.Drawing.Point(308, 542)
        Me.SB_Refresh.Name = "SB_Refresh"
        Me.SB_Refresh.Size = New System.Drawing.Size(368, 36)
        Me.SB_Refresh.StyleController = Me.LayoutControl1
        Me.SB_Refresh.TabIndex = 19
        Me.SB_Refresh.Text = "&Refresh"
        '
        'Sp_MDInventory_PrintBarcodeListGridControl
        '
        Me.Sp_MDInventory_PrintBarcodeListGridControl.DataSource = Me.Sp_MDInventory_PrintBarcodeListBindingSource
        Me.Sp_MDInventory_PrintBarcodeListGridControl.Location = New System.Drawing.Point(962, 57)
        Me.Sp_MDInventory_PrintBarcodeListGridControl.MainView = Me.GV_Barcode
        Me.Sp_MDInventory_PrintBarcodeListGridControl.MenuManager = Me.RibbonControl1
        Me.Sp_MDInventory_PrintBarcodeListGridControl.Name = "Sp_MDInventory_PrintBarcodeListGridControl"
        Me.Sp_MDInventory_PrintBarcodeListGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepoNum_Barcode})
        Me.Sp_MDInventory_PrintBarcodeListGridControl.Size = New System.Drawing.Size(327, 429)
        Me.Sp_MDInventory_PrintBarcodeListGridControl.TabIndex = 18
        Me.Sp_MDInventory_PrintBarcodeListGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Barcode})
        '
        'Sp_MDInventory_PrintBarcodeListBindingSource
        '
        Me.Sp_MDInventory_PrintBarcodeListBindingSource.DataMember = "sp_MDInventory_PrintBarcodeList"
        Me.Sp_MDInventory_PrintBarcodeListBindingSource.DataSource = Me.DataSet
        '
        'GV_Barcode
        '
        Me.GV_Barcode.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBarcode_List, Me.colInventoryNo_List, Me.colQty_List, Me.colPrice_List, Me.colInventoryID_List})
        Me.GV_Barcode.GridControl = Me.Sp_MDInventory_PrintBarcodeListGridControl
        Me.GV_Barcode.Name = "GV_Barcode"
        Me.GV_Barcode.OptionsView.ShowGroupPanel = False
        Me.GV_Barcode.OptionsView.ShowIndicator = False
        '
        'colBarcode_List
        '
        Me.colBarcode_List.FieldName = "Barcode"
        Me.colBarcode_List.Name = "colBarcode_List"
        Me.colBarcode_List.OptionsColumn.AllowEdit = False
        Me.colBarcode_List.OptionsColumn.AllowFocus = False
        Me.colBarcode_List.Visible = True
        Me.colBarcode_List.VisibleIndex = 0
        Me.colBarcode_List.Width = 88
        '
        'colInventoryNo_List
        '
        Me.colInventoryNo_List.FieldName = "InventoryNo"
        Me.colInventoryNo_List.Name = "colInventoryNo_List"
        Me.colInventoryNo_List.OptionsColumn.AllowEdit = False
        Me.colInventoryNo_List.OptionsColumn.AllowFocus = False
        Me.colInventoryNo_List.OptionsFilter.AllowFilter = False
        Me.colInventoryNo_List.Visible = True
        Me.colInventoryNo_List.VisibleIndex = 1
        Me.colInventoryNo_List.Width = 155
        '
        'colQty_List
        '
        Me.colQty_List.ColumnEdit = Me.RepoNum_Barcode
        Me.colQty_List.FieldName = "Qty"
        Me.colQty_List.Name = "colQty_List"
        Me.colQty_List.OptionsFilter.AllowFilter = False
        Me.colQty_List.Visible = True
        Me.colQty_List.VisibleIndex = 2
        Me.colQty_List.Width = 55
        '
        'RepoNum_Barcode
        '
        Me.RepoNum_Barcode.AutoHeight = False
        Me.RepoNum_Barcode.Mask.EditMask = "n0"
        Me.RepoNum_Barcode.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepoNum_Barcode.Mask.UseMaskAsDisplayFormat = True
        Me.RepoNum_Barcode.Name = "RepoNum_Barcode"
        '
        'colPrice_List
        '
        Me.colPrice_List.ColumnEdit = Me.RepoNum_Barcode
        Me.colPrice_List.FieldName = "Price"
        Me.colPrice_List.Name = "colPrice_List"
        Me.colPrice_List.OptionsColumn.AllowEdit = False
        Me.colPrice_List.OptionsColumn.AllowFocus = False
        Me.colPrice_List.OptionsFilter.AllowFilter = False
        Me.colPrice_List.Width = 127
        '
        'colInventoryID_List
        '
        Me.colInventoryID_List.FieldName = "InventoryID"
        Me.colInventoryID_List.Name = "colInventoryID_List"
        Me.colInventoryID_List.OptionsFilter.AllowFilter = False
        '
        'SearchControl1
        '
        Me.SearchControl1.Client = Me.Sp_MDInventory_GetDataGridControl
        Me.SearchControl1.Location = New System.Drawing.Point(687, 545)
        Me.SearchControl1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.SearchControl1.Name = "SearchControl1"
        Me.SearchControl1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.SearchControl1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.SearchControl1.Properties.Appearance.Options.UseBackColor = True
        Me.SearchControl1.Properties.Appearance.Options.UseFont = True
        Me.SearchControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SearchControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.SearchControl1.Properties.Client = Me.Sp_MDInventory_GetDataGridControl
        Me.SearchControl1.Size = New System.Drawing.Size(213, 30)
        Me.SearchControl1.StyleController = Me.LayoutControl1
        Me.SearchControl1.TabIndex = 0
        '
        'SB_BarcodePrint
        '
        Me.SB_BarcodePrint.ImageOptions.SvgImage = CType(resources.GetObject("SB_BarcodePrint.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SB_BarcodePrint.Location = New System.Drawing.Point(962, 530)
        Me.SB_BarcodePrint.Name = "SB_BarcodePrint"
        Me.SB_BarcodePrint.Size = New System.Drawing.Size(327, 36)
        Me.SB_BarcodePrint.StyleController = Me.LayoutControl1
        Me.SB_BarcodePrint.TabIndex = 14
        Me.SB_BarcodePrint.Text = "&Barcode Print"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup5, Me.LayoutControlItem8, Me.LayoutControlGroup3})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 8, 0)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1315, 592)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem7, Me.EmptySpaceItem1, Me.LayoutControlItem6})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 520)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(914, 64)
        Me.LayoutControlGroup5.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SB_Exit
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(76, 40)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SearchControl1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(666, 0)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(224, 37)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(224, 37)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 2, 5, 2)
        Me.LayoutControlItem7.Size = New System.Drawing.Size(224, 40)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(76, 0)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(0, 37)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(9, 37)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(218, 40)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SB_Refresh
        Me.LayoutControlItem6.Location = New System.Drawing.Point(294, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(372, 40)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.TabPane1
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(914, 520)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.ExpandButtonVisible = True
        Me.LayoutControlGroup3.ExpandOnDoubleClick = True
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(914, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(401, 584)
        Me.LayoutControlGroup3.TextLocation = DevExpress.Utils.Locations.Left
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup4
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(355, 561)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup4, Me.LayoutControlGroup2})
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem3})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(331, 513)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Sp_MDInventory_PrintBarcodeListGridControl
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(331, 433)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SB_BarcodePrice
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 433)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(331, 40)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SB_BarcodePrint
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 473)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(331, 40)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.ExpandButtonMode = DevExpress.Utils.Controls.ExpandButtonMode.Inverted
        Me.LayoutControlGroup2.ExpandButtonVisible = True
        Me.LayoutControlGroup2.ExpandOnDoubleClick = True
        Me.LayoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Card
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(331, 513)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Sp_MDInventory_GetHPPHistoryGridControl
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(331, 513)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'NavigationFrame1
        '
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage1)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage2)
        Me.NavigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavigationFrame1.Location = New System.Drawing.Point(0, 95)
        Me.NavigationFrame1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NavigationFrame1.Name = "NavigationFrame1"
        Me.NavigationFrame1.Padding = New System.Windows.Forms.Padding(6)
        Me.NavigationFrame1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2})
        Me.NavigationFrame1.SelectedPage = Me.NavigationPage1
        Me.NavigationFrame1.Size = New System.Drawing.Size(1315, 592)
        Me.NavigationFrame1.TabIndex = 12
        Me.NavigationFrame1.Text = "NavigationFrame1"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Controls.Add(Me.LayoutControl1)
        Me.NavigationPage1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(1315, 592)
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(1315, 592)
        '
        'ImageCollection
        '
        Me.ImageCollection.ImageSize = New System.Drawing.Size(40, 40)
        Me.ImageCollection.ImageStream = CType(resources.GetObject("ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection.Images.SetKeyName(0, "Normal.png")
        Me.ImageCollection.Images.SetKeyName(1, "Hot.png")
        Me.ImageCollection.Images.SetKeyName(2, "Pressed.png")
        '
        'sp_MDInventory_GetDataTableAdapter
        '
        Me.sp_MDInventory_GetDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.sp_MDEmployee_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvBrand_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvCategory_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInventory_GetDataTableAdapter = Me.sp_MDInventory_GetDataTableAdapter
        Me.TableAdapterManager.sp_MDInventory_PrintBarcodeListTableAdapter = Me.Sp_MDInventory_PrintBarcodeListTableAdapter
        Me.TableAdapterManager.sp_MDInvProduct_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_T_Opname_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Master_Data.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sp_MDInventory_PrintBarcodeListTableAdapter
        '
        Me.Sp_MDInventory_PrintBarcodeListTableAdapter.ClearBeforeFill = True
        '
        'DxErrorProvider
        '
        Me.DxErrorProvider.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(379, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(362, 76)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Sp_MDInvBrand_GetDataTableAdapter
        '
        Me.Sp_MDInvBrand_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDInvCategory_GetDataTableAdapter
        '
        Me.Sp_MDInvCategory_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDInvProduct_GetDataTableAdapter
        '
        Me.Sp_MDInvProduct_GetDataTableAdapter.ClearBeforeFill = True
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Sp_MDUoMGetDataTableAdapter
        '
        Me.Sp_MDUoMGetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDInventory_GetTransactionDataTableAdapter
        '
        Me.Sp_MDInventory_GetTransactionDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_MDInventory_GetHPPHistoryTableAdapter
        '
        Me.Sp_MDInventory_GetHPPHistoryTableAdapter.ClearBeforeFill = True
        '
        'Frm_InvList
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 709)
        Me.ControlBox = False
        Me.Controls.Add(Me.NavigationFrame1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Frm_InvList"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Master Barang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Sp_MDInventory_GetHPPHistoryGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInventory_GetHPPHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_HPP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInventory_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_MDInventory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_Brand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInvBrand_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_Category, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInvCategory_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_Product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInvProduct_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_LUE_UoM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDUoMGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repo_Num, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabNavigationPage1.ResumeLayout(False)
        Me.TabNavigationPage2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpMDInventoryGetTransactionDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage3.ResumeLayout(False)
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanel1.ResumeLayout(False)
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlyoutPanelControl1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInventory_PrintBarcodeListGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDInventory_PrintBarcodeListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Barcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepoNum_Barcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavigationFrame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationFrame1.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet As DataSet
    Friend WithEvents NavigationFrame1 As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents SearchControl1 As DevExpress.XtraEditors.SearchControl
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents sp_MDInventory_GetDataBindingSource As BindingSource
    Friend WithEvents sp_MDInventory_GetDataTableAdapter As DataSetTableAdapters.sp_MDInventory_GetDataTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sp_MDInventory_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Detail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AlertControl As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents DxErrorProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrandID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUoMID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMinStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaxStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Sp_MDInvProduct_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDInvCategory_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDInvBrand_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDInvBrand_GetDataTableAdapter As DataSetTableAdapters.sp_MDInvBrand_GetDataTableAdapter
    Friend WithEvents Sp_MDInvCategory_GetDataTableAdapter As DataSetTableAdapters.sp_MDInvCategory_GetDataTableAdapter
    Friend WithEvents Sp_MDInvProduct_GetDataTableAdapter As DataSetTableAdapters.sp_MDInvProduct_GetDataTableAdapter
    Friend WithEvents Repo_LUE_Brand As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Repo_LUE_Category As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Repo_LUE_Product As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SB_BarcodePrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_Exit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents colBarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Repo_Num As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents SB_Refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Sp_MDInventory_PrintBarcodeListGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Barcode As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RepoNum_Barcode As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents QueriesTableAdapter As DataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents colBarcode_List As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryNo_List As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty_List As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice_List As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryID_List As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Sp_MDInventory_PrintBarcodeListBindingSource As BindingSource
    Friend WithEvents Sp_MDInventory_PrintBarcodeListTableAdapter As DataSetTableAdapters.sp_MDInventory_PrintBarcodeListTableAdapter
    Friend WithEvents Repo_LUE_UoM As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Sp_MDUoMGetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDUoMGetDataTableAdapter As DataSetTableAdapters.sp_MDUoMGetDataTableAdapter
    Friend WithEvents colHPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStokAwal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SB_BarcodePrice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents colStokAkhir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKodeHarga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SpMDInventoryGetTransactionDataBindingSource As BindingSource
    Friend WithEvents colInventoryNo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesPOSNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesPOSDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Sp_MDInventory_GetTransactionDataTableAdapter As DataSetTableAdapters.sp_MDInventory_GetTransactionDataTableAdapter
    Friend WithEvents colOpname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransaksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDisc2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Sp_MDInventory_GetHPPHistoryGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_HPP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sp_MDInventory_GetHPPHistoryBindingSource As BindingSource
    Friend WithEvents colID_HPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRNo_HPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMRDate_HPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupplierName_HPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHPP_HPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Sp_MDInventory_GetHPPHistoryTableAdapter As DataSetTableAdapters.sp_MDInventory_GetHPPHistoryTableAdapter
    Friend WithEvents TabNavigationPage3 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents FlyoutPanel1 As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl1 As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RibbonPageCategory1 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BBI_Close As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colGrosir1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrosir2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrosir3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriceBuy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BI_Search As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchControl1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
