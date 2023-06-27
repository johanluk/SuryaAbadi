Public Class Frm_Customer
    Private Sub Frm_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Sp_MDCustomer_GetDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Sp_MDCustomer_GetDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Sp_MDCustomer_GetDataTableAdapter.Fill(Me.DataSet.sp_MDCustomer_GetData, 1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class