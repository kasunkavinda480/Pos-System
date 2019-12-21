Public Class New_Customer
    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbsdatabaseDataSet)

    End Sub

    Private Sub New_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbsdatabaseDataSet.ref_details' table. You can move, or remove it, as needed.
        Me.Ref_detailsTableAdapter.Fill(Me.DbsdatabaseDataSet.ref_details)
        'TODO: This line of code loads data into the 'DbsdatabaseDataSet.ref_details' table. You can move, or remove it, as needed.
        Me.Ref_detailsTableAdapter.Fill(Me.DbsdatabaseDataSet.ref_details)
        'TODO: This line of code loads data into the 'DbsdatabaseDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.DbsdatabaseDataSet.customer)
        Ref_detailsDataGridView.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CustomerBindingSource.AddNew()
        NoTextBox.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        STypeTextBox1.Text = ComboBox1.Text
        RegisterDateDateTimePicker.Value = DateTimePicker1.Value
        Try
            CustomerBindingSource.EndEdit()
            CustomerTableAdapter.Update(DbsdatabaseDataSet.customer)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Are you Ok", "OR Not!", MessageBoxButtons.YesNo)
        If Windows.Forms.DialogResult.Yes Then
            CustomerBindingSource.RemoveCurrent()
            Try
                CustomerBindingSource.EndEdit()
                CustomerTableAdapter.Update(DbsdatabaseDataSet.customer)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub NoTextBox_TextChanged(sender As Object, e As EventArgs) Handles NoTextBox.TextChanged

    End Sub

    Private Sub NoTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles NoTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            NameTextBox.Select()

        End If
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub NameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles NameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            CityTextBox.Select()

        End If
    End Sub



    Private Sub CityTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles CityTextBox.TextChanged

    End Sub

    Private Sub CityTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CityTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddressTextBox.Select()
        End If
    End Sub



    Private Sub AddressTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged

    End Sub

    Private Sub AddressTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AddressTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox1.Select()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tel_NoTextBox.Select()
        End If
    End Sub

    Private Sub Tel_NoTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Tel_NoTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles Tel_NoTextBox.TextChanged

    End Sub

    Private Sub Tel_NoTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Tel_NoTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            FaxTextBox.Select()
        End If
    End Sub

    Private Sub FaxTextBox_TextChanged(sender As Object, e As EventArgs) Handles FaxTextBox.TextChanged

    End Sub

    Private Sub FaxTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles FaxTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            RefNameTextBox.Select()
        End If
    End Sub

    Private Sub RefNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles RefNameTextBox.TextChanged
        Ref_detailsBindingSource.Filter = "Ref_Name LIKE'" & RefNameTextBox.Text & "%'"
    End Sub

    Private Sub RefNameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles RefNameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ref_detailsDataGridView.Visible = True
        End If
        If e.KeyCode = Keys.Escape Then
            Ref_detailsDataGridView.Visible = False
        End If
        If e.KeyCode = Keys.Up Then
            Ref_detailsDataGridView.Select()
        End If
        If e.KeyCode = Keys.Down Then
            Ref_detailsDataGridView.Select()
        End If
    End Sub

    Private Sub Ref_detailsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Ref_detailsDataGridView.CellContentClick

    End Sub

    Private Sub Ref_detailsDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles Ref_detailsDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rnum As Integer = Ref_detailsDataGridView.CurrentRow.Index
            RefNameTextBox.Text = Ref_detailsDataGridView.Rows.Item(rnum).Cells(0).Value
            Ref_detailsDataGridView.Visible = False
            Button2.PerformClick()

        End If
    End Sub
End Class