Imports MySql.Data.MySqlClient
Public Class Tem_Sale7
    Private Sub Tem_Sale7_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Try
            'Me.Customer_paymentsTableAdapter.Fill(Me.DbsdatabaseDataSet.customer_payments)'
            Me.Sale_idTableAdapter.Fill(Me.DbsdatabaseDataSet.sale_id)
            Me.InvnoTableAdapter.Fill(Me.DbsdatabaseDataSet.invno)
            Me.Customer_creditTableAdapter.Fill(Me.DbsdatabaseDataSet.customer_credit)
            Me.AllitemsTableAdapter.Fill(Me.DbsdatabaseDataSet.allitems)
            Me.CustomerTableAdapter.Fill(Me.DbsdatabaseDataSet.customer)
            Me.Tem_sale3TableAdapter.Fill(Me.DbsdatabaseDataSet.tem_sale3)
            Dim fresh As Integer = Tem_sale2DataGridView.Rows.Count - 1
            If fresh <= 0 Then
            Else
                TextBox1.Text = Tem_sale2DataGridView.Item(7, fresh).Value.ToString
                TextBox2.Text = Tem_sale2DataGridView.Item(8, fresh).Value.ToString
                TextBox3.Text = Tem_sale2DataGridView.Item(9, fresh).Value.ToString
                TextBox5.Text = Tem_sale2DataGridView.Item(10, fresh).Value.ToString
                TextBox4.Text = Tem_sale2DataGridView.Item(11, fresh).Value.ToString

                Dim mgsum As Double = 0
                For j As Integer = 0 To Tem_sale2DataGridView.Rows.Count() - 1 Step +1
                    mgsum = mgsum + Tem_sale2DataGridView.Rows(j).Cells(5).Value
                Next
                mgsumTxt.Text = mgsum.ToString()
            End If
            Panel1.Visible = False
            Panel2.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If Panel1.Visible Then
            Panel1.Visible = False
        Else
            Panel1.Visible = False
        End If
        TextBox4.Text = DateTimePicker1.Value

    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown

        If e.KeyCode = Keys.Escape Then
            Panel1.Visible = False
            Panel2.Visible = False
        Else
            If e.KeyCode = Keys.Enter Then

                If Panel1.Visible Then
                    Panel1.Visible = True
                Else
                    Panel1.Visible = True
                End If
                If Panel2.Visible Then
                    Panel2.Visible = False
                Else
                    Panel2.Visible = False
                End If

            End If
        End If
        If e.KeyCode = Keys.Up Then
            CustomerDataGridView.Select()
        End If
        If e.KeyCode = Keys.Down Then
            CustomerDataGridView.Select()
        End If
    End Sub





    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Tem_sale3BindingSource.RemoveCurrent()
        Dim Ssize As Integer = 0
        If DiscoText.Text = "" Then
            MessageBox.Show("Please Enter Discount For your bill")
            Tem_sale3BindingSource.AddNew()
        Else
            For size As Integer = 0 To Tem_sale2DataGridView.Rows.Count - 1
                SellingBindingSource.AddNew()
                SellingDataGridView.Rows.Item(Ssize).Cells(0).Value = IdnoTextBox.Text
                SellingDataGridView.Rows.Item(Ssize).Cells(1).Value = TextBox1.Text
                SellingDataGridView.Rows.Item(Ssize).Cells(2).Value = TextBox2.Text
                SellingDataGridView.Rows.Item(Ssize).Cells(3).Value = TextBox3.Text
                SellingDataGridView.Rows.Item(Ssize).Cells(4).Value = Tem_sale2DataGridView.Rows.Item(size).Cells(0).Value
                SellingDataGridView.Rows.Item(Ssize).Cells(5).Value = Tem_sale2DataGridView.Rows.Item(size).Cells(1).Value
                SellingDataGridView.Rows.Item(Ssize).Cells(6).Value = Tem_sale2DataGridView.Rows.Item(size).Cells(2).Value
                SellingDataGridView.Rows.Item(Ssize).Cells(7).Value = Tem_sale2DataGridView.Rows.Item(size).Cells(3).Value
                SellingDataGridView.Rows.Item(Ssize).Cells(8).Value = Tem_sale2DataGridView.Rows.Item(size).Cells(4).Value
                SellingDataGridView.Rows.Item(Ssize).Cells(9).Value = Tem_sale2DataGridView.Rows.Item(size).Cells(5).Value
                SellingDataGridView.Rows.Item(Ssize).Cells(10).Value = mgsumTxt.Text
                SellingDataGridView.Rows.Item(Ssize).Cells(11).Value = DiscoText.Text
                SellingDataGridView.Rows.Item(Ssize).Cells(12).Value = LiveDiscountTxt.Text
                SellingDataGridView.Rows.Item(Ssize).Cells(13).Value = Fullsumtxt.Text
                SellingDataGridView.Rows.Item(Ssize).Cells(14).Value = TextBox5.Text
                SellingDataGridView.Rows.Item(Ssize).Cells(15).Value = TextBox4.Text
                IdnoTextBox.Text = IdnoTextBox.Text + 1
                Ssize = Ssize + 1


            Next
            'this about customer credit'
            Customer_creditBindingSource.AddNew()
            NameTextBox.Text = TextBox2.Text
            If AmountTextBox2.Text = "" Then
                AmountTextBox1.Text = Fullsumtxt.Text
            Else
                Customer_paymentsBindingSource.AddNew()
                IDTextBox.Text = IdnoTextBox.Text
                AmountTextBox1.Text = TextBox6.Text
                NameTextBox1.Text = TextBox2.Text
                TypeTextBox.Text = ComboBox1.Text
                RefTextBox1.Text = TextBox5.Text
                PDateDateTimePicker.Value = DateTimePicker1.Value
                Try
                    Customer_paymentsBindingSource.EndEdit()
                    Customer_paymentsTableAdapter.Update(DbsdatabaseDataSet.customer_payments)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
            GDateDateTimePicker.Value = DateTimePicker1.Value
            RefTextBox.Text = TextBox5.Text
            Try
                Customer_creditBindingSource.EndEdit()
                Customer_creditTableAdapter.Update(DbsdatabaseDataSet.customer_credit)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            '------------------------------'
            Dim MySqlConn = New MySqlConnection
            Dim COMMAND As MySqlCommand
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString = "server=localhost;userid=root;password=sa@123;database=dbsdatabase"
            Dim READER As MySqlDataReader
            Try
                Dim Query As String
                MySqlConn.Open()
                Query = "delete from dbsdatabase.tem_sale3"


                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Try
                Sale_idBindingSource.EndEdit()
                Sale_idTableAdapter.Update(DbsdatabaseDataSet.sale_id)
                SellingBindingSource.EndEdit()
                SellingTableAdapter.Update(DbsdatabaseDataSet.selling)

            Catch ex As Exception

            End Try
            Sale_Invice.TextBox1.Text = TextBox1.Text
            Sale_Invice.Show()
            Sale_Invice.MdiParent = Main
            Me.Close()
        End If




    End Sub



    Private Sub CustomerDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles CustomerDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim k As Integer

            k = CustomerDataGridView.CurrentRow.Index

            Me.TextBox2.Text = CustomerDataGridView.Item(0, k).Value.ToString

            Dim types As Integer = CustomerDataGridView.CurrentRow.Index
            TextBox3.Text = CustomerDataGridView.Rows.Item(types).Cells(1).Value.ToString
            TextBox5.Text = CustomerDataGridView.Rows.Item(types).Cells(2).Value.ToString

            If Panel1.Visible Then
                Panel1.Visible = False
            Else
                Panel1.Visible = False
            End If
            IT_CodeTextBox.Select()
        End If
    End Sub

    Private Sub IT_CodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles IT_CodeTextBox.TextChanged
        Me.AllitemsBindingSource.Filter = "Item_Code LIKE'" & IT_CodeTextBox.Text & "%'"
        If Panel2.Visible Then
            Panel2.Visible = True
        Else
            Panel2.Visible = True

        End If
        If Panel1.Visible Then
            Panel1.Visible = False
        Else
            Panel1.Visible = False
        End If
    End Sub

    Private Sub IT_CodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles IT_CodeTextBox.KeyDown
        If e.KeyCode = Keys.Escape Then
            If Panel2.Visible Then
                Panel2.Visible = False
            Else
                Panel2.Visible = False
            End If
        End If
        If e.KeyCode = Keys.Up Then
            AllitemsDataGridView.Select()
        End If
        If e.KeyCode = Keys.Down Then
            AllitemsDataGridView.Select()
        End If
    End Sub

    Private Sub DescriptionTextBox_TextChanged(sender As Object, e As EventArgs) Handles DescriptionTextBox.TextChanged
        Me.AllitemsBindingSource.Filter = "Description LIKE'" & DescriptionTextBox.Text & "%'"
        If Panel2.Visible Then
            Panel2.Visible = True
        Else
            Panel2.Visible = True

        End If
        If Panel1.Visible Then
            Panel1.Visible = False
        Else
            Panel1.Visible = False
        End If
    End Sub

    Private Sub DescriptionTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles DescriptionTextBox.KeyDown
        If e.KeyCode = Keys.Escape Then
            If Panel2.Visible Then
                Panel2.Visible = False
            Else
                Panel2.Visible = False
            End If
        End If
        If e.KeyCode = Keys.Up Then
            AllitemsDataGridView.Select()
        End If
        If e.KeyCode = Keys.Down Then
            AllitemsDataGridView.Select()
        End If
    End Sub

    Private Sub QutTextBox_TextChanged(sender As Object, e As EventArgs) Handles QutTextBox.TextChanged
        If QutTextBox.Text = "" Then
        Else
            If Unit_PriceTextBox.Text = "" Then
            Else
                AmountTextBox.Text = QutTextBox.Text * Unit_PriceTextBox.Text

            End If
        End If
    End Sub

    Private Sub QutTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles QutTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim MySqlConn = New MySqlConnection
            Dim COMMAND As MySqlCommand
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString = "server=localhost;userid=root;password=sa@123;database=dbsdatabase"
            Dim READER As MySqlDataReader
            If QutTextBox.Text = "" Then
            Else
                If StockTextBox.Text = "" Then
                    StockTextBox.Text = "0"
                    StockTextBox.Text = StockTextBox.Text - QutTextBox.Text
                    Try
                        Dim Query As String
                        MySqlConn.Open()
                        Query = "update dbsdatabase.allitems set Stock='" & StockTextBox.Text & "' where Description='" & DescriptionTextBox.Text & "'"
                        COMMAND = New MySqlCommand(Query, MySqlConn)
                        READER = COMMAND.ExecuteReader
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Else
                    StockTextBox.Text = StockTextBox.Text - QutTextBox.Text
                    Try
                        Dim Query As String
                        MySqlConn.Open()
                        Query = "update dbsdatabase.allitems set Stock='" & StockTextBox.Text & "' where Description='" & DescriptionTextBox.Text & "'"
                        COMMAND = New MySqlCommand(Query, MySqlConn)
                        READER = COMMAND.ExecuteReader
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            End If


            If Panel2.Visible Then
                Panel2.Visible = False
            Else
                Panel2.Visible = False
            End If
            Unit_PriceTextBox.Select()
        End If
    End Sub

    Private Sub Unit_PriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles Unit_PriceTextBox.TextChanged
        If QutTextBox.Text = "" Then

        Else
            If Unit_PriceTextBox.Text = "" Then
            Else
                AmountTextBox.Text = QutTextBox.Text * Unit_PriceTextBox.Text

            End If
        End If
    End Sub

    Private Sub Unit_PriceTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Unit_PriceTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            DiscountTextBox.Select()
        End If
    End Sub

    Private Sub DiscountTextBox_TextChanged(sender As Object, e As EventArgs) Handles DiscountTextBox.TextChanged

    End Sub

    Private Sub DiscountTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles DiscountTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If QutTextBox.Text = "" Then

            Else
                If Unit_PriceTextBox.Text = "" Then

                Else
                    If DiscountTextBox.Text = "" Then
                    Else
                        Dim dis As Integer
                        AmountTextBox.Text = QutTextBox.Text * Unit_PriceTextBox.Text
                        dis = 100 - DiscountTextBox.Text
                        AmountTextBox.Text = (AmountTextBox.Text / 100)
                        AmountTextBox.Text = AmountTextBox.Text * dis

                    End If
                End If
            End If
            Button2.PerformClick()



        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim mgsum As Integer = 0

        Dim m As Integer = Tem_sale2DataGridView.Rows.Count() - 1
        Tem_sale2DataGridView.Rows(m).Cells(7).Value = TextBox1.Text
        Tem_sale2DataGridView.Rows(m).Cells(8).Value = TextBox2.Text
        Tem_sale2DataGridView.Rows(m).Cells(9).Value = TextBox3.Text
        Tem_sale2DataGridView.Rows(m).Cells(10).Value = TextBox5.Text
        Tem_sale2DataGridView.Rows(m).Cells(11).Value = TextBox4.Text

        Dim ss As Integer = Tem_sale2DataGridView.Rows.Count() - 1
        Tem_sale2DataGridView.Rows(ss).Cells(6).Value = ss

        Tem_sale3BindingSource.EndEdit()
        Tem_sale3TableAdapter.Update(DbsdatabaseDataSet.tem_sale3)

        For j As Integer = 0 To Tem_sale2DataGridView.Rows.Count() - 1 Step +1
            mgsum = mgsum + Tem_sale2DataGridView.Rows(j).Cells(5).Value
        Next
        mgsumTxt.Text = mgsum.ToString()

        If Panel2.Visible Then
            Panel2.Visible = False
        Else
            Panel2.Visible = False
        End If

        Tem_sale3BindingSource.AddNew()
        IT_CodeTextBox.Select()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tem_sale3BindingSource.AddNew()
        NoTextBox.Text = NoTextBox.Text + 1
        TextBox1.Text = "Inv" + NoTextBox.Text
        Dim MySqlConn = New MySqlConnection
        Dim COMMAND As MySqlCommand
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=sa@123;database=dbsdatabase"
        Dim READER As MySqlDataReader
        Try
            Dim Query As String
            MySqlConn.Open()
            Query = "update dbsdatabase.invno set No='" & NoTextBox.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        TextBox2.Select()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("If you want to delete this", "OR Not!", MessageBoxButtons.YesNo)
        If Windows.Forms.DialogResult.Yes Then
            If StockTextBox.Text = "" Then
                StockTextBox.Text = "0"
                StockTextBox.Text = StockTextBox.Text + QutTextBox.Text
            Else
                StockTextBox.Text = StockTextBox.Text + QutTextBox.Text
            End If
            Dim del As Double = AmountTextBox.Text
            Dim mg As Double
            mg = mg - del
            mgsumTxt.Text = mg.ToString
            Tem_sale3BindingSource.RemoveCurrent()

        End If
    End Sub



    Private Sub AllitemsDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles AllitemsDataGridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            'this is about item code and des copy'
            Dim itcode As Integer = AllitemsDataGridView.CurrentRow.Index
            IT_CodeTextBox.Text = AllitemsDataGridView.Rows.Item(itcode).Cells(0).Value.ToString
            Dim des As Integer = AllitemsDataGridView.CurrentRow.Index
            DescriptionTextBox.Text = AllitemsDataGridView.Rows.Item(des).Cells(1).Value.ToString
            If TextBox3.Text = "" Then
            Else

                If TextBox3.Text = "Wholesale" Then
                    'Me.Unit_PriceTextBox.Text = AllItemsDataGridView.Item(3, x).Value.ToString

                    Try
                        Dim rnum As Integer = AllitemsDataGridView.CurrentRow.Index
                        Unit_PriceTextBox.Text = AllitemsDataGridView.Rows.Item(rnum).Cells(3).Value
                    Catch ex As Exception
                        'Unit_PriceTextBox.Text = WholesaleTextBox.Text'
                    End Try
                Else
                    If TextBox3.Text = "Retail" Then

                        Try
                            Dim retail As Integer = AllitemsDataGridView.CurrentRow.Index
                            Unit_PriceTextBox.Text = AllitemsDataGridView.Rows.Item(retail).Cells(4).Value
                        Catch ex As Exception
                            'Unit_PriceTextBox.Text = RetailTextBox.Text'
                        End Try
                    Else
                        MsgBox("your type is incorrect Please go to the customer table and correct it")
                    End If
                End If
            End If

            QutTextBox.Select()

        End If
    End Sub

    Private Sub DiscoText_TextChanged(sender As Object, e As EventArgs) Handles DiscoText.TextChanged
        If DiscoText.Text = "" Then
        Else
            If DiscoText.Text = "0" Then
                LiveDiscountTxt.Text = "0"
                Fullsumtxt.Text = mgsumTxt.Text
            End If
            Dim mgsum As Double = mgsumTxt.Text
            Dim disrate As Double = DiscoText.Text
            Dim disAmt As Double
            Dim fulltot As Double
            disAmt = (mgsum / 100) * disrate
            fulltot = (100 - disrate) * mgsum / 100

            LiveDiscountTxt.Text = disAmt.ToString
            Fullsumtxt.Text = fulltot.ToString
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Tem_sale3BindingSource.RemoveCurrent()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Dim fresh As Integer = Tem_sale2DataGridView.Rows.Count - 1
        If fresh <= 0 Then
        Else
            TextBox1.Text = Tem_sale2DataGridView.Item(7, fresh).Value.ToString
            TextBox2.Text = Tem_sale2DataGridView.Item(8, fresh).Value.ToString
            TextBox3.Text = Tem_sale2DataGridView.Item(9, fresh).Value.ToString
            TextBox5.Text = Tem_sale2DataGridView.Item(10, fresh).Value.ToString
            TextBox4.Text = Tem_sale2DataGridView.Item(11, fresh).Value.ToString

            Dim mgsum As Double = 0
            For j As Integer = 0 To Tem_sale2DataGridView.Rows.Count() - 1 Step +1
                mgsum = mgsum + Tem_sale2DataGridView.Rows(j).Cells(5).Value
            Next
            mgsumTxt.Text = mgsum.ToString()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Dim MySqlConn = New MySqlConnection
        Dim COMMAND As MySqlCommand
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;userid=root;password=sa@123;database=dbsdatabase"
        Dim READER As MySqlDataReader
        Try
            Dim Query As String
            MySqlConn.Open()
            Query = "update dbsdatabase.sale_id set idno='" & IdnoTextBox.Text & "' where idno='" & IdnoTextBox.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("DATA UPDATE")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Me.CustomerBindingSource.Filter = "Name LIKE'" & TextBox2.Text & "%'"
        Me.Customer_creditBindingSource.Filter = "Name LIKE'" & TextBox2.Text & "%'"
        If TextBox2.Text = NameTextBox.Text Then
            Dim mgcredit As Double = 0
            For cs As Integer = 0 To Customer_creditDataGridView.Rows.Count() - 1
                mgcredit = mgcredit + Customer_creditDataGridView.Rows.Item(cs).Cells(1).Value
            Next
            creditAmtTxt.Text = mgcredit.ToString
        End If
    End Sub

    Private Sub AmountTextBox2_TextChanged(sender As Object, e As EventArgs) Handles AmountTextBox2.TextChanged
        If DiscoText.Text = "" Then
        Else
            If AmountTextBox2.Text = "" Then
            Else
                Dim gsum As Double = Fullsumtxt.Text
                Dim bal As Double
                Dim pay As Double = AmountTextBox2.Text
                bal = gsum - pay
                TextBox6.Text = bal.ToString
            End If

        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        GDateDateTimePicker.Value = DateTimePicker1.Value
        TextBox4.Text = DateTimePicker1.Value
        PDateDateTimePicker.Value = DateTimePicker1.Value
    End Sub

    Private Sub CustomerDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDataGridView.CellContentClick

    End Sub
End Class