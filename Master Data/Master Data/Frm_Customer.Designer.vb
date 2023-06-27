<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Customer
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
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.DataSet = New Master_Data.DataSet()
        Me.Sp_MDCustomer_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_MDCustomer_GetDataTableAdapter = New Master_Data.DataSetTableAdapters.sp_MDCustomer_GetDataTableAdapter()
        Me.TableAdapterManager = New Master_Data.DataSetTableAdapters.TableAdapterManager()
        Me.Sp_MDCustomer_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.colCustomerNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDCard = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPostCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHamlet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNeighbourhood = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVillage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubdistrict = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBirthDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBirthPlace = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReligion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGender = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhone1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhone2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colimages = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCredit_Limit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContact_Person = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContact_Person_Address = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContact_Person_Phone1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContact_Person_Phone2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDCustomer_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_MDCustomer_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.RibbonControl.SearchEditItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 1
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019
        Me.RibbonControl.Size = New System.Drawing.Size(967, 169)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 577)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(967, 22)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.Sp_MDCustomer_GetDataGridControl)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 169)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(767, 408)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(767, 408)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_MDCustomer_GetDataBindingSource
        '
        Me.Sp_MDCustomer_GetDataBindingSource.DataMember = "sp_MDCustomer_GetData"
        Me.Sp_MDCustomer_GetDataBindingSource.DataSource = Me.DataSet
        '
        'Sp_MDCustomer_GetDataTableAdapter
        '
        Me.Sp_MDCustomer_GetDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.sp_MDEmployee_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvBrand_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvCategory_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInventory_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInventory_PrintBarcodeListTableAdapter = Nothing
        Me.TableAdapterManager.sp_MDInvProduct_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.sp_T_Opname_GetDataTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Master_Data.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sp_MDCustomer_GetDataGridControl
        '
        Me.Sp_MDCustomer_GetDataGridControl.DataSource = Me.Sp_MDCustomer_GetDataBindingSource
        Me.Sp_MDCustomer_GetDataGridControl.Location = New System.Drawing.Point(12, 12)
        Me.Sp_MDCustomer_GetDataGridControl.MainView = Me.GridView1
        Me.Sp_MDCustomer_GetDataGridControl.MenuManager = Me.RibbonControl
        Me.Sp_MDCustomer_GetDataGridControl.Name = "Sp_MDCustomer_GetDataGridControl"
        Me.Sp_MDCustomer_GetDataGridControl.Size = New System.Drawing.Size(743, 384)
        Me.Sp_MDCustomer_GetDataGridControl.TabIndex = 4
        Me.Sp_MDCustomer_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustomerNo, Me.colCustomerName, Me.colCustomerTypeID, Me.colIDCard, Me.colAddress, Me.colCity, Me.colPostCode, Me.colHamlet, Me.colNeighbourhood, Me.colVillage, Me.colSubdistrict, Me.colBirthDate, Me.colBirthPlace, Me.colReligion, Me.colGender, Me.colDescription, Me.colPhone1, Me.colPhone2, Me.colFax, Me.colimages, Me.colCredit_Limit, Me.colContact_Person, Me.colContact_Person_Address, Me.colContact_Person_Phone1, Me.colContact_Person_Phone2, Me.colemail, Me.colModifiedUser, Me.colModifiedDate, Me.colID})
        Me.GridView1.GridControl = Me.Sp_MDCustomer_GetDataGridControl
        Me.GridView1.Name = "GridView1"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Sp_MDCustomer_GetDataGridControl
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(747, 388)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'colCustomerNo
        '
        Me.colCustomerNo.FieldName = "CustomerNo"
        Me.colCustomerNo.Name = "colCustomerNo"
        Me.colCustomerNo.OptionsColumn.AllowEdit = False
        Me.colCustomerNo.OptionsColumn.AllowFocus = False
        Me.colCustomerNo.Visible = True
        Me.colCustomerNo.VisibleIndex = 0
        '
        'colCustomerName
        '
        Me.colCustomerName.FieldName = "CustomerName"
        Me.colCustomerName.Name = "colCustomerName"
        Me.colCustomerName.OptionsColumn.AllowEdit = False
        Me.colCustomerName.OptionsColumn.AllowFocus = False
        Me.colCustomerName.Visible = True
        Me.colCustomerName.VisibleIndex = 1
        '
        'colCustomerTypeID
        '
        Me.colCustomerTypeID.FieldName = "CustomerTypeID"
        Me.colCustomerTypeID.Name = "colCustomerTypeID"
        Me.colCustomerTypeID.OptionsColumn.AllowEdit = False
        Me.colCustomerTypeID.OptionsColumn.AllowFocus = False
        Me.colCustomerTypeID.Visible = True
        Me.colCustomerTypeID.VisibleIndex = 2
        '
        'colIDCard
        '
        Me.colIDCard.FieldName = "IDCard"
        Me.colIDCard.Name = "colIDCard"
        Me.colIDCard.OptionsColumn.AllowEdit = False
        Me.colIDCard.OptionsColumn.AllowFocus = False
        '
        'colAddress
        '
        Me.colAddress.FieldName = "Address"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.OptionsColumn.AllowEdit = False
        Me.colAddress.OptionsColumn.AllowFocus = False
        '
        'colCity
        '
        Me.colCity.FieldName = "City"
        Me.colCity.Name = "colCity"
        Me.colCity.OptionsColumn.AllowEdit = False
        Me.colCity.OptionsColumn.AllowFocus = False
        '
        'colPostCode
        '
        Me.colPostCode.FieldName = "PostCode"
        Me.colPostCode.Name = "colPostCode"
        Me.colPostCode.OptionsColumn.AllowEdit = False
        Me.colPostCode.OptionsColumn.AllowFocus = False
        '
        'colHamlet
        '
        Me.colHamlet.FieldName = "Hamlet"
        Me.colHamlet.Name = "colHamlet"
        Me.colHamlet.OptionsColumn.AllowEdit = False
        Me.colHamlet.OptionsColumn.AllowFocus = False
        '
        'colNeighbourhood
        '
        Me.colNeighbourhood.FieldName = "Neighbourhood"
        Me.colNeighbourhood.Name = "colNeighbourhood"
        Me.colNeighbourhood.OptionsColumn.AllowEdit = False
        Me.colNeighbourhood.OptionsColumn.AllowFocus = False
        '
        'colVillage
        '
        Me.colVillage.FieldName = "Village"
        Me.colVillage.Name = "colVillage"
        Me.colVillage.OptionsColumn.AllowEdit = False
        Me.colVillage.OptionsColumn.AllowFocus = False
        '
        'colSubdistrict
        '
        Me.colSubdistrict.FieldName = "Subdistrict"
        Me.colSubdistrict.Name = "colSubdistrict"
        Me.colSubdistrict.OptionsColumn.AllowEdit = False
        Me.colSubdistrict.OptionsColumn.AllowFocus = False
        '
        'colBirthDate
        '
        Me.colBirthDate.FieldName = "BirthDate"
        Me.colBirthDate.Name = "colBirthDate"
        Me.colBirthDate.OptionsColumn.AllowEdit = False
        Me.colBirthDate.OptionsColumn.AllowFocus = False
        '
        'colBirthPlace
        '
        Me.colBirthPlace.FieldName = "BirthPlace"
        Me.colBirthPlace.Name = "colBirthPlace"
        Me.colBirthPlace.OptionsColumn.AllowEdit = False
        Me.colBirthPlace.OptionsColumn.AllowFocus = False
        '
        'colReligion
        '
        Me.colReligion.FieldName = "Religion"
        Me.colReligion.Name = "colReligion"
        Me.colReligion.OptionsColumn.AllowEdit = False
        Me.colReligion.OptionsColumn.AllowFocus = False
        '
        'colGender
        '
        Me.colGender.FieldName = "Gender"
        Me.colGender.Name = "colGender"
        Me.colGender.OptionsColumn.AllowEdit = False
        Me.colGender.OptionsColumn.AllowFocus = False
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsColumn.AllowEdit = False
        Me.colDescription.OptionsColumn.AllowFocus = False
        '
        'colPhone1
        '
        Me.colPhone1.FieldName = "Phone1"
        Me.colPhone1.Name = "colPhone1"
        Me.colPhone1.OptionsColumn.AllowEdit = False
        Me.colPhone1.OptionsColumn.AllowFocus = False
        '
        'colPhone2
        '
        Me.colPhone2.FieldName = "Phone2"
        Me.colPhone2.Name = "colPhone2"
        Me.colPhone2.OptionsColumn.AllowEdit = False
        Me.colPhone2.OptionsColumn.AllowFocus = False
        '
        'colFax
        '
        Me.colFax.FieldName = "Fax"
        Me.colFax.Name = "colFax"
        Me.colFax.OptionsColumn.AllowEdit = False
        Me.colFax.OptionsColumn.AllowFocus = False
        '
        'colimages
        '
        Me.colimages.FieldName = "images"
        Me.colimages.Name = "colimages"
        Me.colimages.OptionsColumn.AllowEdit = False
        Me.colimages.OptionsColumn.AllowFocus = False
        '
        'colCredit_Limit
        '
        Me.colCredit_Limit.FieldName = "Credit_Limit"
        Me.colCredit_Limit.Name = "colCredit_Limit"
        Me.colCredit_Limit.OptionsColumn.AllowEdit = False
        Me.colCredit_Limit.OptionsColumn.AllowFocus = False
        '
        'colContact_Person
        '
        Me.colContact_Person.FieldName = "Contact_Person"
        Me.colContact_Person.Name = "colContact_Person"
        Me.colContact_Person.OptionsColumn.AllowEdit = False
        Me.colContact_Person.OptionsColumn.AllowFocus = False
        '
        'colContact_Person_Address
        '
        Me.colContact_Person_Address.FieldName = "Contact_Person_Address"
        Me.colContact_Person_Address.Name = "colContact_Person_Address"
        Me.colContact_Person_Address.OptionsColumn.AllowEdit = False
        Me.colContact_Person_Address.OptionsColumn.AllowFocus = False
        '
        'colContact_Person_Phone1
        '
        Me.colContact_Person_Phone1.FieldName = "Contact_Person_Phone1"
        Me.colContact_Person_Phone1.Name = "colContact_Person_Phone1"
        Me.colContact_Person_Phone1.OptionsColumn.AllowEdit = False
        Me.colContact_Person_Phone1.OptionsColumn.AllowFocus = False
        '
        'colContact_Person_Phone2
        '
        Me.colContact_Person_Phone2.FieldName = "Contact_Person_Phone2"
        Me.colContact_Person_Phone2.Name = "colContact_Person_Phone2"
        Me.colContact_Person_Phone2.OptionsColumn.AllowEdit = False
        Me.colContact_Person_Phone2.OptionsColumn.AllowFocus = False
        '
        'colemail
        '
        Me.colemail.FieldName = "email"
        Me.colemail.Name = "colemail"
        Me.colemail.OptionsColumn.AllowEdit = False
        Me.colemail.OptionsColumn.AllowFocus = False
        '
        'colModifiedUser
        '
        Me.colModifiedUser.FieldName = "ModifiedUser"
        Me.colModifiedUser.Name = "colModifiedUser"
        Me.colModifiedUser.OptionsColumn.AllowEdit = False
        Me.colModifiedUser.OptionsColumn.AllowFocus = False
        '
        'colModifiedDate
        '
        Me.colModifiedDate.FieldName = "ModifiedDate"
        Me.colModifiedDate.Name = "colModifiedDate"
        Me.colModifiedDate.OptionsColumn.AllowEdit = False
        Me.colModifiedDate.OptionsColumn.AllowFocus = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.AllowFocus = False
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.ID = New System.Guid("3f4d6204-db9f-4943-8004-d5c772f93c7b")
        Me.DockPanel1.Location = New System.Drawing.Point(767, 169)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(200, 408)
        Me.DockPanel1.Text = "DockPanel1"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 46)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(193, 359)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'Frm_Customer
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 599)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "Frm_Customer"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Frm_Customer"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDCustomer_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_MDCustomer_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DataSet As DataSet
    Friend WithEvents Sp_MDCustomer_GetDataBindingSource As BindingSource
    Friend WithEvents Sp_MDCustomer_GetDataTableAdapter As DataSetTableAdapters.sp_MDCustomer_GetDataTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sp_MDCustomer_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCustomerNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDCard As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPostCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHamlet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNeighbourhood As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVillage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubdistrict As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBirthDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBirthPlace As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReligion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGender As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhone1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhone2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colimages As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCredit_Limit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContact_Person As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContact_Person_Address As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContact_Person_Phone1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContact_Person_Phone2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
End Class
