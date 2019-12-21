Public Class Customer_Chaque
    Private Sub ChaquereceivedBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ChaquereceivedBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbsdatabaseDataSet)

    End Sub

    Private Sub Customer_Chaque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CustomerTableAdapter.Fill(Me.DbsdatabaseDataSet.customer)
        Me.ChaquereceivedTableAdapter.Fill(Me.DbsdatabaseDataSet.chaquereceived)
        CustomerDataGridView.Location = New Point(C_NameTextBox.Left, C_NameTextBox.Top + C_NameTextBox.Height)
        CustomerDataGridView.Visible = False
        Try
            For M As Integer = 0 To ChaquereceivedDataGridView.Rows.Count() - 1 Step +1
                If ChaquereceivedDataGridView.Rows(M).Cells(4).Value = "PENDING" Then
                    ChaquereceivedDataGridView.Rows(M).DefaultCellStyle.BackColor = Color.Yellow
                End If
                If ChaquereceivedDataGridView.Rows(M).Cells(4).Value = "RETURNED" Then
                    ChaquereceivedDataGridView.Rows(M).DefaultCellStyle.BackColor = Color.GreenYellow
                End If
                If ChaquereceivedDataGridView.Rows(M).Cells(4).Value = "REALISED" Then
                    ChaquereceivedDataGridView.Rows(M).DefaultCellStyle.BackColor = Color.Red
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Dim tot As Integer = 0
        For j As Integer = 0 To ChaquereceivedDataGridView.Rows.Count() - 1 Step +1

            tot = tot + ChaquereceivedDataGridView.Rows(j).Cells(3).Value
        Next

        Label7.Text = tot.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChaquereceivedBindingSource.AddNew()
        Chq_NoTextBox.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        StatusTextBox.Text = "PENDING"
        Try
            ChaquereceivedBindingSource.EndEdit()
            ChaquereceivedTableAdapter.Update(DbsdatabaseDataSet.chaquereceived)
        Catch ex As Exception

        End Try
    End Sub



    Private Sub Chq_NoTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Chq_NoTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            C_NameTextBox.Select()
        End If
    End Sub

    Private Sub C_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles C_NameTextBox.TextChanged
        CustomerBindingSource.Filter = "Name LIKE'" & C_NameTextBox.Text & "%'"
    End Sub

    Private Sub C_NameTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles C_NameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            CustomerDataGridView.Visible = True
        End If
        If e.KeyCode = Keys.Escape Then
            CustomerDataGridView.Visible = False
        End If
        If e.KeyCode = Keys.Up Then
            CustomerDataGridView.Select()
        End If
        If e.KeyCode = Keys.Down Then
            CustomerDataGridView.Select()
        End If
    End Sub

    Private Sub CustomerDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGridView.CellContentClick

    End Sub

    Private Sub CustomerDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles CustomerDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim n As Integer = CustomerDataGridView.CurrentRow.Index
            C_NameTextBox.Text = CustomerDataGridView.Rows.Item(n).Cells(0).Value
            CustomerDataGridView.Visible = False
            BankTextBox.Select()

        End If
    End Sub

    Private Sub BankTextBox_TextChanged(sender As Object, e As EventArgs) Handles BankTextBox.TextChanged

    End Sub

    Private Sub BankTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BankTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            AmountTextBox.Select()
        End If
    End Sub

    Private Sub AmountTextBox_TextChanged(sender As Object, e As EventArgs) Handles AmountTextBox.TextChanged

    End Sub

    Private Sub AmountTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AmountTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker2_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Button2.PerformClick()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If StatusTextBox.Text = "RETURNED" Then
            MsgBox("This is a Return Chaque ")
        Else
            MessageBox.Show("Are you Ok", "OR Not!", MessageBoxButtons.YesNo)
            If Windows.Forms.DialogResult.Yes Then
                StatusTextBox.Text = "REALISED"
                Try
                    ChaquereceivedBindingSource.EndEdit()
                    ChaquereceivedTableAdapter.Update(DbsdatabaseDataSet.chaquereceived)
                Catch ex As Exception

                End Try
            End If
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If StatusTextBox.Text = "REALISED" Then
            MsgBox("This is a Realised Chaque ")
        Else
            MessageBox.Show("Are you Ok", "OR Not!", MessageBoxButtons.YesNo)
            If Windows.Forms.DialogResult.Yes Then
                StatusTextBox.Text = "RETURNED"
                Try
                    ChaquereceivedBindingSource.EndEdit()
                    ChaquereceivedTableAdapter.Update(DbsdatabaseDataSet.chaquereceived)
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox2.Text = "RETURNED"
        Dim tot As Integer = 0
        For j As Integer = 0 To ChaquereceivedDataGridView.Rows.Count() - 1 Step +1

            tot = tot + ChaquereceivedDataGridView.Rows(j).Cells(3).Value
        Next

        Label7.Text = tot.ToString()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox2.Text = "REALISED"
        Dim tot As Integer = 0
        For j As Integer = 0 To ChaquereceivedDataGridView.Rows.Count() - 1 Step +1

            tot = tot + ChaquereceivedDataGridView.Rows(j).Cells(3).Value
        Next

        Label7.Text = tot.ToString()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox2.Text = "PENDING"
        Dim tot As Integer = 0
        For j As Integer = 0 To ChaquereceivedDataGridView.Rows.Count() - 1 Step +1

            tot = tot + ChaquereceivedDataGridView.Rows(j).Cells(3).Value
        Next

        Label7.Text = tot.ToString()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Me.ChaquereceivedBindingSource.Filter = "Status LIKE'" & TextBox2.Text & "%'"
        If TextBox2.Text = "PENDING" Then
            For f As Integer = 0 To ChaquereceivedDataGridView.Rows.Count() - 1 Step +1
                ChaquereceivedDataGridView.Rows(f).DefaultCellStyle.BackColor = Color.Yellow
            Next
        End If
        If TextBox2.Text = "REALISED" Then
            For f As Integer = 0 To ChaquereceivedDataGridView.Rows.Count() - 1 Step +1
                ChaquereceivedDataGridView.Rows(f).DefaultCellStyle.BackColor = Color.GreenYellow
            Next
        End If
        If TextBox2.Text = "RETURNED" Then
            For f As Integer = 0 To ChaquereceivedDataGridView.Rows.Count() - 1 Step +1
                ChaquereceivedDataGridView.Rows(f).DefaultCellStyle.BackColor = Color.Red
            Next
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.ChaquereceivedBindingSource.Filter = "C_Name LIKE'" & TextBox1.Text & "%'"
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Me.ChaquereceivedBindingSource.Filter = "Bank LIKE'" & TextBox5.Text & "%'"
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Me.ChaquereceivedBindingSource.Filter = "Chq_No LIKE'" & TextBox6.Text & "%'"
    End Sub
End Class