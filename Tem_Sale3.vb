Public Class Tem_Sale3
    Private Sub Tem_sale2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tem_sale2BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tem_sale2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbsdatabaseDataSet)

    End Sub

    Private Sub Tem_Sale3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbsdatabaseDataSet.selling' table. You can move, or remove it, as needed.
        Me.SellingTableAdapter.Fill(Me.DbsdatabaseDataSet.selling)
        'TODO: This line of code loads data into the 'DbsdatabaseDataSet.tem_sale2' table. You can move, or remove it, as needed.
        Me.Tem_sale2TableAdapter.Fill(Me.DbsdatabaseDataSet.tem_sale2)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Tem_sale2BindingSource.EndEdit()
            Tem_sale2TableAdapter.Update(DbsdatabaseDataSet.tem_sale2)
        Catch ex As Exception

        End Try
    End Sub
End Class