Public Class Form1
    Public Sub Display_data()
        con.Open()

        Dim dt As New DataTable("tblUser")
        Dim rs As New OleDb.OleDbDataAdapter("Select * from tblUser", con)
        rs.Fill(dt)

        DataGridView1.DataSource = dt
        DataGridView1.Refresh()

        Label1.Text = dt.Rows.Count

        rs.Dispose()
        con.Close()

    End Sub
    Public Sub Login_data()
        con.Open()

        Dim dt As New DataTable("tblUser")
        Dim rs As New OleDb.OleDbDataAdapter("Select * from tblUser where fname = '" & TextBox1.Text & "'and pass = '" & TextBox2.Text & "'", con)
        rs.Fill(dt)

        DataGridView1.DataSource = dt
        DataGridView1.Refresh()

        Label1.Text = dt.Rows.Count

        rs.Dispose()
        con.Close()
        If Val(Label1.Text) = 1 Then
            Me.Hide()
            Main.Show()
        Else
            MsgBox("worng password")

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login_data()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub
    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Select()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display_data()
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Select()
        End If
    End Sub
End Class
