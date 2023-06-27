Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI

Public Class Frm_InvList


#Region "Variables"
    Private isNew As Boolean
    Dim isUpdate As Boolean = False
    Dim userModified As String
    Dim RowFocus As Integer
    Dim dt As DataTable

#End Region

    Private frmParentInfo As DevExpress.XtraEditors.XtraForm
    Private parentribbonx As DevExpress.XtraBars.Ribbon.RibbonControl

    Shared Sub New()
        '      DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
        NavigationFrame1.SelectedPage = NavigationPage1
    End Sub

    Public Sub New(ByVal parent As DevExpress.XtraEditors.XtraForm, ByVal ConnString As String, ByVal Source As String, ByVal parentribbon As DevExpress.XtraBars.Ribbon.RibbonControl, ByVal ModuleCode As String, ByVal Username As String, ByVal giiDB As String, Optional ByVal GACCDB As String = "", Optional ByVal Warehouse As String = "", Optional ByVal CropYear As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        frmParentInfo = parent
        parentribbonx = parentribbon
        NavigationFrame1.SelectedPage = NavigationPage1

    End Sub

    Public Function GetFormName() As DevExpress.XtraBars.Ribbon.RibbonForm
        Return Me
    End Function

    Class RowInfo
        Public Sub New(ByVal view As GridView, ByVal rowHandle As Integer)
            Me.RowHandle = rowHandle
            Me.View = view
        End Sub 'New
        Public View As GridView
        Public RowHandle As Integer
    End Class


    Sub SettingGridControl()
        dt = New DataTable
        dt.Columns.Add("Inv_ID")
        dt.Columns.Add("Barcode")
        dt.Columns.Add("Inv_No")
        dt.Columns.Add("Price")
        dt.Columns.Add("Qty")

        Sp_MDInventory_PrintBarcodeListGridControl.DataSource = dt

        GV_Barcode.Columns(0).Visible = False
        GV_Barcode.Columns(1).OptionsColumn.AllowEdit = False
        GV_Barcode.Columns(1).OptionsColumn.AllowFocus = False
        GV_Barcode.Columns(1).Caption = "Barcode"
        GV_Barcode.Columns(1).Width = 150
        GV_Barcode.Columns(2).OptionsColumn.AllowEdit = False
        GV_Barcode.Columns(2).OptionsColumn.AllowFocus = False
        GV_Barcode.Columns(2).Caption = "Barang"
        GV_Barcode.Columns(3).Width = 100
        GV_Barcode.Columns(3).Caption = "Harga"
        GV_Barcode.Columns(3).Width = 100
        GV_Barcode.Columns(3).ColumnEdit = RepoNum_Barcode
        GV_Barcode.Columns(3).OptionsColumn.AllowEdit = False
        GV_Barcode.Columns(3).OptionsColumn.AllowFocus = False
        GV_Barcode.Columns(4).Caption = "#"
        GV_Barcode.Columns(4).ColumnEdit = RepoNum_Barcode
        GV_Barcode.Columns(4).Width = 50

        GV_Barcode.OptionsView.ShowIndicator = False
        GV_Barcode.OptionsView.ShowDetailButtons = False
        GV_Barcode.OptionsView.ShowGroupPanel = False
        GV_Barcode.OptionsView.ShowHorizontalLines = False

    End Sub

    Private Sub Frm_SPMaterialReceiveCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.sp_MDInventory_PrintBarcodeList' table. You can move, or remove it, as needed.
        Me.Sp_MDInventory_PrintBarcodeListTableAdapter.Fill(Me.DataSet.sp_MDInventory_PrintBarcodeList)
        Me.sp_MDInventory_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInventory_GetData)
        Me.Sp_MDInvBrand_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvBrand_GetData, 0)
        Me.Sp_MDInvCategory_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvCategory_GetData, 0)
        Me.Sp_MDInvProduct_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvProduct_GetData, 0)
        Me.Sp_MDUoMGetDataTableAdapter.Fill(Me.DataSet.sp_MDUoMGetData, 0)


        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.Username
        '  FillDataAdapter()
        ''DxErrorProvider1.ClearErrors()
        DataSet.sp_MDInventory_GetData.Columns("ModifiedUser").DefaultValue = userModified
        LCGroup_Barcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        'DataSet.sp_SPMaterialReceiveDetailGetData.Columns("ModifiedDate").DefaultValue = Now
        '   SettingGridControl()

    End Sub



    Private Sub FillDataAdapter()
        Try
            Me.sp_MDInventory_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInventory_GetData)
            Me.Sp_MDInvBrand_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvBrand_GetData, 0)
            Me.Sp_MDInvCategory_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvCategory_GetData, 0)
            Me.Sp_MDInvProduct_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvProduct_GetData, 0)
            Me.Sp_MDUoMGetDataTableAdapter.Fill(Me.DataSet.sp_MDUoMGetData, 0)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub


    Private Sub DateEditEnd_Leave(sender As Object, e As EventArgs)
        FillDataAdapter()
    End Sub


    Function ValidationCheck() As Boolean
        Return True
    End Function



    Private Sub GV_Detail_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GV_Detail.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        ' Check whether a row is right-clicked.
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            e.Menu.Items.Clear()
            Dim menuItemDeleteRow As New DXMenuItem("&Print List",
          AddressOf OnDeleteRowDetail, ImageCollection.Images(0))
            menuItemDeleteRow.Tag = New RowInfo(view, rowHandle)
            e.Menu.Items.Add(menuItemDeleteRow)
            Dim menuDetail As New DXMenuItem("&Detail Barang",
          AddressOf OnDetail, ImageCollection.Images(1))
            menuItemDeleteRow.Tag = New RowInfo(view, rowHandle)
            e.Menu.Items.Add(menuDetail)
        End If
    End Sub
    Sub OnDetail(ByVal sender As Object, ByVal e As EventArgs)
        RowFocus = GV_Detail.FocusedRowHandle

        TabPane1.SelectedPage = TabNavigationPage2
        Sp_MDInventory_GetTransactionDataTableAdapter.Fill(Me.DataSet.sp_MDInventory_GetTransactionData, CInt(GV_Detail.GetRowCellValue(GV_Detail.FocusedRowHandle(), colID)))

    End Sub

    Sub OnDeleteRowDetail(ByVal sender As Object, ByVal e As EventArgs)
        RowFocus = GV_Detail.FocusedRowHandle
        Dim DeletedVar1 As String

        DeletedVar1 = GV_Detail.GetRowCellValue(RowFocus, colDescription).ToString
        Try
            Dim item As DXMenuItem = CType(sender, DXMenuItem)
            Dim info As RowInfo = CType(item.Tag, RowInfo)

            If MessageBox.Show("Are you sure you want to Insert data?", "Confirmation", MessageBoxButtons.YesNoCancel) = MsgBoxResult.Yes Then
                ' info.View.DeleteRow(info.RowHandle)
                'Me.QueriesTableAdapter.sp_MDInventory_PrintBarcodeInsList(GV_Detail.GetRowCellValue(info.RowHandle, colBarcode),
                '                                                          GV_Detail.GetRowCellValue(info.RowHandle, colID),
                '                                                          GV_Detail.GetRowCellValue(info.RowHandle, colInventoryNo),

                'Dim row1 As String() = New String() {"1", "1", "1", "1", "1"}
                'GridView1.
                'Dim dr As DataRow = dt.NewRow()
                ''GridView1.AddNewRow()
                'dr(0) = GV_Detail.GetRowCellValue(info.RowHandle, colID)
                'dr(1) = GV_Detail.GetRowCellValue(info.RowHandle, colBarcode)
                'dr(2) = GV_Detail.GetRowCellValue(info.RowHandle, colInventoryNo)
                'dr(3) = GV_Detail.GetRowCellValue(info.RowHandle, colPrice)
                'dr(4) = 0
                'dt.Rows.Add(dr)
                'GridControl1.DataSource = dt

                Me.QueriesTableAdapter.sp_MDInventory_PrintBarcodeInsList("",
                                                                          CInt(GV_Detail.GetRowCellValue(info.RowHandle, colID)),
                                                                          GV_Detail.GetRowCellValue(info.RowHandle, colInventoryNo).ToString,
                                                                          0,
                                                                          0,
                                                                          UserModified)
                Me.Sp_MDInventory_PrintBarcodeListTableAdapter.Fill(Me.DataSet.sp_MDInventory_PrintBarcodeList)
                'Me.Validate()
                'Me.Sp_POS_CashierTransactionAdditional_GetDataBindingSource.EndEdit()
                'Me.TableAdapterManager.UpdateAll(Me.DataSet)
                'Me.Sp_POS_CashierTransactionAdditional_GetDataTableAdapter.Fill(Me.DataSet.sp_POS_CashierTransactionAdditional_GetData, Dt_OrderDate.DateTime)
            Else
                'BtnRefresh.PerformClick()
                'AlertControl1.Show(Me, "Cancel on Delete Data", DeletedVar1)
            End If
            AlertControl.Show(Me, "Success on Insert Data", DeletedVar1)
        Catch ex As Exception
            AlertControl.Show(Me, "Error on Insert Data", ex.Message)
        End Try
    End Sub

    Private Sub SB_BarcodePrint_Click(sender As Object, e As EventArgs) Handles SB_BarcodePrint.Click
        Dim report As New DevExpress.XtraReports.UI.XtraReport


        report = New Rpt_LabelBarcode()
        'report = New Rpt_BillPrintPreview()
        Using printTool As New ReportPrintTool(report)

            printTool.ShowPreviewDialog()

            'printTool.Print()
            '    printTool.Print("myPrinter")
        End Using

    End Sub

    Private Sub GV_Barcode_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_Barcode.ValidateRow
        Me.Validate()
        Me.Sp_MDInventory_PrintBarcodeListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)
    End Sub

    Private Sub GV_Barcode_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GV_Barcode.PopupMenuShowing
        Dim view As GridView = CType(sender, GridView)
        ' Check whether a row is right-clicked.
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Dim rowHandle As Integer = e.HitInfo.RowHandle
            e.Menu.Items.Clear()
            Dim menuItemDeleteRow As New DXMenuItem("&Delete Row",
          AddressOf OnDeleteRowBarcode, ImageCollection.Images(0))
            menuItemDeleteRow.Tag = New RowInfo(view, rowHandle)
            e.Menu.Items.Add(menuItemDeleteRow)
        End If
    End Sub



    Sub OnDeleteRowBarcode(ByVal sender As Object, ByVal e As EventArgs)
        RowFocus = GV_Detail.FocusedRowHandle
        Dim DeletedVar1 As String

        DeletedVar1 = GV_Detail.GetRowCellValue(RowFocus, colDescription).ToString
        Try
            Dim item As DXMenuItem = CType(sender, DXMenuItem)
            Dim info As RowInfo = CType(item.Tag, RowInfo)

            GV_Barcode.DeleteRow(info.RowHandle)
            Me.Validate()
            Me.Sp_MDInventory_PrintBarcodeListBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataSet)
            AlertControl.Show(Me, "Success on Delete Data", DeletedVar1)
        Catch ex As Exception
            AlertControl.Show(Me, "Error on Delete Data", ex.Message)
        End Try
    End Sub


    Private Sub SB_BarcodePrice_Click(sender As Object, e As EventArgs) Handles SB_BarcodePrice.Click
        Dim report As New DevExpress.XtraReports.UI.XtraReport


        report = New Rpt_LabelBarcodePrice()
        'report = New Rpt_BillPrintPreview()
        Using printTool As New ReportPrintTool(report)

            printTool.ShowPreviewDialog()

            'printTool.Print()
            '    printTool.Print("myPrinter")
        End Using
    End Sub

    Private Sub GV_Detail_DoubleClick(sender As Object, e As EventArgs) Handles GV_Detail.DoubleClick

        Me.Sp_MDInventory_GetHPPHistoryTableAdapter.Fill(Me.DataSet.sp_MDInventory_GetHPPHistory, CInt(GV_Detail.GetFocusedRowCellValue(colID)))
    End Sub

    Private Sub GV_Detail_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_Detail.ValidateRow
        Try
            If (ValidationCheck() = False) Then
                Exit Sub
            End If

            Me.sp_MDInventory_GetDataBindingSource.EndEdit()
            Me.Validate()
            TableAdapterManager.UpdateAll(Me.DataSet)

            FillDataAdapter()

        Catch ex As Exception
            AlertControl.Show(Me, "Trouble in Input", ex.Message)
        End Try
    End Sub

    Private Sub BBI_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBI_Close.ItemClick
        Me.Close()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        FillDataAdapter()
    End Sub

    Private Sub BE_BarcodeToogle_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BE_BarcodeToogle.ItemClick

    End Sub

    Private Sub BE_BarcodeToogle_EditValueChanged(sender As Object, e As EventArgs) Handles BE_BarcodeToogle.EditValueChanged
        If (BE_BarcodeToogle.EditValue = True) Then
            LCGroup_Barcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            LCGroup_Barcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
    End Sub

    Private Sub BBI_CreateList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBI_CreateList.ItemClick
        Dim report As New DevExpress.XtraReports.UI.XtraReport
        If (IsNothing(BI_Search.EditValue)) Then
            BI_Search.EditValue = ""
        End If
        report = New Rpt_PriceByKeyword(BI_Search.EditValue.ToString)

        'report = New Rpt_BillPrintPreview()
        Using printTool As New ReportPrintTool(report)

            printTool.ShowPreviewDialog()

            'printTool.Print()
            '    printTool.Print("myPrinter")
        End Using
    End Sub
End Class