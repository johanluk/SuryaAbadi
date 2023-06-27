Public Class Frm_Template

#Region "Variables"
    Private isNew As Boolean
    Private UserModified As String
    Dim isUpdate As Boolean = False
#End Region

    Public Sub New()
        InitializeComponent()
        DateEditStart.DateTime = DateAdd(DateInterval.Day, -7, Today)
        DateEditEnd.DateTime = DateAdd(DateInterval.Day, 7, Today)

        NavigationFrame1.SelectedPage = NavigationPage1
    End Sub

    Public Sub New(ByVal ConnString As String, ByVal Source As String, ByVal ModuleCode As String, ByVal Username As String, ByVal giiDB As String, Optional ByVal GACCDB As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        NavigationFrame1.SelectedPage = NavigationPage1

        My.Settings.Item("ConnectionString") = ConnString
        DateEditStart.DateTime = DateAdd(DateInterval.Day, -7, Today)
        DateEditEnd.DateTime = DateAdd(DateInterval.Day, 7, Today)

    End Sub

    Private Sub Frm_SPMaterialReceiveCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.sp_MDMenuType_GetData' table. You can move, or remove it, as needed.
        Me.Sp_MDMenuType_GetDataTableAdapter.Fill(Me.DataSet.sp_MDMenuType_GetData)

        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.Username
        '  FillDataAdapter()
        ''DxErrorProvider1.ClearErrors()
        ''UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.Username
        'DataSet.sp_SPMaterialReceiveDetailGetData.Columns("ModifiedUser").DefaultValue = "sds"
        'DataSet.sp_SPMaterialReceiveDetailGetData.Columns("ModifiedDate").DefaultValue = Now
    End Sub



    Private Sub FillDataAdapter()
        Try
            Me.Sp_MDMenuType_GetDataTableAdapter.Fill(Me.DataSet.sp_MDMenuType_GetData)
            '   Me.Sp_SPMaterialReceiveDetailGetDataTableAdapter.Fill(Me.DataSet.sp_SPMaterialReceiveDetailGetData, 0)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub
    Sub NewProcess()
        Try
            Me.Cursor = Cursors.WaitCursor
            DetailLayout()
            Sp_MDMenuType_GetDataGridControl.DataSource = Me.DataSet.sp_MDMenuType_GetData
            Sp_MDMenuType_GetDataBindingSource.AddNew()


        Catch ex As Exception
            AlertControl.Show(Me, "ss", ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub HomeLayout()
        XtraTabControl1.SelectedTabPage = XtraTabPage1
        DxErrorProvider.ClearErrors()
        isUpdate = False
        WindowsUIButtonPanel_Header.Buttons.Item(0).Properties.Enabled = True
    End Sub

    Private Sub DetailLayout()
        XtraTabControl1.SelectedTabPage = XtraTabPage2
        DxErrorProvider.ClearErrors()
        WindowsUIButtonPanel_Header.Buttons.Item(0).Properties.Enabled = False
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            'Me.Sp_SPMaterialReceiveDetailGetDataTableAdapter.Fill(Me.DataSet.sp_SPMaterialReceiveDetailGetData, 0)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DateEditEnd_Leave(sender As Object, e As EventArgs) Handles DateEditEnd.Leave, DateEditStart.Leave
        FillDataAdapter()
    End Sub

    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel_Header.ButtonClick
        Select Case e.Button.Properties.Caption
            Case "New"

                NewProcess()
            Case "Save"
                SaveProcess()

            Case "Close"
                Me.Close()
                Me.Dispose()

        End Select
    End Sub

    Function ValidationCheck()
        Return True
    End Function

    Sub SaveProcess()
        Try
            If (ValidationCheck() = False) Then
                Exit Sub
            End If

            Me.Validate()
            If (isUpdate) Then
                Me.QueriesTableAdapter.sp_MDMenuType_Transaction(2,
                                                             CInt(MenuTypeNoTextEdit.Tag),
                                                             MenuTypeNoTextEdit.EditValue.ToString,
                                                             MenuTypeNameTextEdit.EditValue.ToString,
                                                             DescriptionMemoEdit.EditValue.ToString,
                                                             UserModified)
            Else
                Me.QueriesTableAdapter.sp_MDMenuType_Transaction(1,
                                                             0,
                                                             MenuTypeNoTextEdit.EditValue.ToString,
                                                             MenuTypeNameTextEdit.EditValue.ToString,
                                                             DescriptionMemoEdit.EditValue.ToString,
                                                             UserModified)

            End If

            FillDataAdapter()

            AlertControl.Show(Me, "Success", MenuTypeNameTextEdit.EditValue.ToString + " Berhasil Disimpan")
            SB_Back.PerformClick()
        Catch ex As Exception
            AlertControl.Show(Me, "Trouble in Input", ex.Message)
        End Try
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanging(sender As Object, e As DevExpress.XtraTab.TabPageChangingEventArgs) Handles XtraTabControl1.SelectedPageChanging
        TransitionManager1.StartTransition(XtraTabControl1)

    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        TransitionManager1.EndTransition()
    End Sub

    Private Sub SB_Back_Click(sender As Object, e As EventArgs) Handles SB_Back.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            DxErrorProvider.ClearErrors()
            Sp_MDMenuType_GetDataBindingSource.CancelEdit()
            HomeLayout()
        Catch ex As Exception
            AlertControl.Show(Me, "Check On btnBack_ItemClick()", ex.Message)
        Finally
            Sp_MDMenuType_GetDataGridControl.DataSource = Sp_MDMenuType_GetDataBindingSource
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub GV_Detail_DoubleClick(sender As Object, e As EventArgs) Handles GV_Detail.DoubleClick
        If (GV_Detail.RowCount > 0) Then
            isUpdate = True
            DetailLayout()
        End If
    End Sub
End Class