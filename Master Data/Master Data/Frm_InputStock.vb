Imports DevExpress.XtraReports.UI

Public Class Frm_InputStock

    Dim userModified As String
    Private frmParentInfo As DevExpress.XtraEditors.XtraForm
    Private parentribbonx As DevExpress.XtraBars.Ribbon.RibbonControl


    Public Sub New(ByVal parent As DevExpress.XtraEditors.XtraForm, ByVal ConnString As String, ByVal Source As String, ByVal parentribbon As DevExpress.XtraBars.Ribbon.RibbonControl, ByVal ModuleCode As String, ByVal Username As String, ByVal giiDB As String, Optional ByVal GACCDB As String = "", Optional ByVal Warehouse As String = "", Optional ByVal CropYear As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        frmParentInfo = parent
        parentribbonx = parentribbon
        My.Settings.Item("ConnectionString") = ConnString

    End Sub
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Public Function GetFormName() As DevExpress.XtraBars.Ribbon.RibbonForm
        Return Me
    End Function

    Private Sub Frm_InputStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.sp_MDInventory_GetData' table. You can move, or remove it, as needed.
        Me.Sp_MDInventory_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInventory_GetData)
        Ed_NoTransaksi.EditValue = 0
        'TODO: This line of code loads data into the 'DataSet.sp_MDInventory_PrintBarcodeList' table. You can move, or remove it, as needed.
        Me.Sp_T_Opname_GetDataTableAdapter.Fill(Me.DataSet.sp_T_Opname_GetData, CInt(Ed_NoTransaksi.EditValue))
        Me.Sp_MDInvBrand_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvBrand_GetData, 0)
        Me.Sp_MDInvCategory_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvCategory_GetData, 0)
        Me.Sp_MDUoMGetDataTableAdapter.Fill(Me.DataSet.sp_MDUoMGetData, 0)
        userModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.Username

    End Sub

    Sub RefreshData()
        Me.Sp_T_Opname_GetDataTableAdapter.Fill(Me.DataSet.sp_T_Opname_GetData, CInt(Ed_NoTransaksi.EditValue))
    End Sub

    Private Sub Ed_Barcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Ed_Barcode.KeyPress
        If (e.KeyChar = ChrW(13)) Then
            Dim temp As Integer
            temp = CInt(Me.QueriesTableAdapter.sp_T_Opname_CheckInvBarcode(Ed_Barcode.EditValue.ToString))
            If (temp <> 0) Then
                Me.QueriesTableAdapter.sp_T_Opname_InsUpdData(Ed_Barcode.EditValue.ToString,
                                                                CInt(Ed_NoTransaksi.EditValue), 1, userModified)

                RefreshData()
                Ed_Barcode.EditValue = ""
            Else


                LayoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

                Ed_BarcodeInput.EditValue = Ed_Barcode.EditValue
                Ed_InvNo_Input.EditValue = ""
                Ed_InvName_Input.EditValue = ""
                Ed_Qty.EditValue = 1
                Ed_KodeHarga.EditValue = ""
                LookUpEdit1.Reset()
                LookUpEdit2.Reset()
                LookUpEdit3.Reset()
                LookUpEdit1.Select()

            End If
        End If


    End Sub

    Private Sub SB_Refresh_Click(sender As Object, e As EventArgs) Handles SB_Refresh.Click
        Me.Sp_MDInventory_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInventory_GetData)
        'TODO: This line of code loads data into the 'DataSet.sp_MDInventory_PrintBarcodeList' table. You can move, or remove it, as needed.
        Me.Sp_T_Opname_GetDataTableAdapter.Fill(Me.DataSet.sp_T_Opname_GetData, CInt(Ed_NoTransaksi.EditValue))
        Me.Sp_MDInvBrand_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvBrand_GetData, 0)
        Me.Sp_MDInvCategory_GetDataTableAdapter.Fill(Me.DataSet.sp_MDInvCategory_GetData, 0)
        Me.Sp_MDUoMGetDataTableAdapter.Fill(Me.DataSet.sp_MDUoMGetData, 0)

    End Sub

    Private Sub SB_Print_Click(sender As Object, e As EventArgs) Handles SB_Print.Click
        Dim report As New DevExpress.XtraReports.UI.XtraReport

        report = New Rpt_Opname(CInt(Ed_NoTransaksi.EditValue))
        Using printTool As New ReportPrintTool(report)

            printTool.ShowPreviewDialog()

            'printTool.Print()
            '    printTool.Print("myPrinter")
        End Using
    End Sub

    Private Sub Ed_NoTransaksi_EditValueChanged(sender As Object, e As EventArgs) Handles Ed_NoTransaksi.EditValueChanged
        Me.Sp_T_Opname_GetDataTableAdapter.Fill(Me.DataSet.sp_T_Opname_GetData, CInt(Ed_NoTransaksi.EditValue))

    End Sub

    Private Sub SB_Submit_Click(sender As Object, e As EventArgs) Handles SB_Submit.Click
        Me.QueriesTableAdapter.sp_T_Opname_InsUpdInventory(Ed_BarcodeInput.EditValue.ToString,
                                                           Ed_InvNo_Input.EditValue.ToString,
                                                           Ed_InvName_Input.EditValue.ToString,
                                                           CInt(LookUpEdit1.EditValue),
                                                           CInt(LookUpEdit2.EditValue),
                                                           CInt(LookUpEdit3.EditValue),
                                                           MemoEdit1.Text.ToString,
                                                           Ed_KodeHarga.EditValue,
                                                           userModified)
        LayoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Ed_Barcode.Select()


        Me.QueriesTableAdapter.sp_T_Opname_InsUpdData(Ed_BarcodeInput.EditValue.ToString,
                                                                CInt(Ed_NoTransaksi.EditValue), CInt(Ed_Qty.EditValue), userModified)


    End Sub

    Private Sub GV_Detail_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_Detail.ValidateRow
        Me.Sp_T_Opname_GetDataBindingSource.EndEdit()
        Me.Validate()
        TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub
End Class