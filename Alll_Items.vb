Imports MySql.Data.MySqlClient
Public Class Alll_Items
    Private Sub AllitemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AllitemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbsdatabaseDataSet)

    End Sub

    Private Sub Alll_Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DbsdatabaseDataSet.brand' table. You can move, or remove it, as needed.
        Me.BrandTableAdapter.Fill(Me.DbsdatabaseDataSet.brand)
        'TODO: This line of code loads data into the 'DbsdatabaseDataSet.allitems' table. You can move, or remove it, as needed.
        Me.AllitemsTableAdapter.Fill(Me.DbsdatabaseDataSet.allitems)
        BrandDataGridView.Visible = False
        For j As Integer = 0 To AllitemsDataGridView.Rows.Count() - 1
            Label3.Text = AllitemsDataGridView.Rows.Count()
        Next
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            AllitemsBindingSource.EndEdit()
            AllitemsTableAdapter.Update(DbsdatabaseDataSet.allitems)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BrandTextBox_TextChanged(sender As Object, e As EventArgs) Handles BrandTextBox.TextChanged
        Me.BrandBindingSource.Filter = "Name LIKE'" & BrandTextBox.Text & "%'"
    End Sub

    Private Sub BrandTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BrandTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            BrandDataGridView.Visible = True
        End If
        If e.KeyCode = Keys.Escape Then
            BrandDataGridView.Visible = False
        End If
        If e.KeyCode = Keys.Up Then
            BrandDataGridView.Select()
        End If
        If e.KeyCode = Keys.Down Then
            BrandDataGridView.Select()
        End If
    End Sub



    Private Sub BrandDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles BrandDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim ty As Integer = BrandDataGridView.CurrentRow.Index
            BrandTextBox.Text = BrandDataGridView.Rows.Item(ty).Cells(0).Value.ToString
            BrandDataGridView.Visible = False
            CostTextBox.Select()

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AllitemsBindingSource.AddNew()
        Item_CodeTextBox.Select()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MySqlConn = New MySqlConnection
        Dim COMMAND As MySqlCommand
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=sa@123;database=dbsdatabase"
        Dim READER As MySqlDataReader
        Try
            Dim Query As String
            MySqlConn.Open()
            Query = "update dbsdatabase.allitems set Item_Code='" & Item_CodeTextBox.Text & "',Description='" & DescriptionTextBox.Text & "',Brand='" & BrandTextBox.Text & "',Cost='" & CostTextBox.Text & "',Wholesale='" & WholesaleTextBox.Text & "',Retail='" & RetailTextBox.Text & "' where Description='" & DescriptionTextBox.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("DATA UPDATE")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Are you Sure to Delete This", "OR Not!", MessageBoxButtons.YesNo)
        If Windows.Forms.DialogResult.Yes Then
            Dim MySqlConn = New MySqlConnection
            Dim COMMAND As MySqlCommand
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString = "server=localhost;userid=root;password=sa@123;database=dbsdatabase"
            Dim READER As MySqlDataReader
            Try
                Dim Query As String
                MySqlConn.Open()
                Query = "delete  from dbsdatabase.allitems where Description='" & DescriptionTextBox.Text & "'"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MessageBox.Show("DATA Delete")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub



    Private Sub Item_CodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Item_CodeTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            DescriptionTextBox.Select()
        End If
    End Sub



    Private Sub DescriptionTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles DescriptionTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            BrandTextBox.Select()
        End If
    End Sub

    Private Sub CostTextBox_TextChanged(sender As Object, e As EventArgs) Handles CostTextBox.TextChanged

    End Sub

    Private Sub CostTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CostTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            WholesaleTextBox.Select()
        End If
    End Sub



    Private Sub WholesaleTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles WholesaleTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            RetailTextBox.Select()
        End If
    End Sub



    Private Sub RetailTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles RetailTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2.PerformClick()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        AllitemsBindingSource.Filter = "Item_Code LIKE'" & TextBox1.Text & "%'"
        For j As Integer = 0 To AllitemsDataGridView.Rows.Count() - 1
            Label3.Text = AllitemsDataGridView.Rows.Count()
        Next
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        AllitemsBindingSource.Filter = "Description LIKE'" & TextBox2.Text & "%'"
        For j As Integer = 0 To AllitemsDataGridView.Rows.Count() - 1
            Label3.Text = AllitemsDataGridView.Rows.Count()
        Next
    End Sub
End Class