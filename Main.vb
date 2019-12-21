Public Class Main
    Private Sub ItemToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ItemToolStripMenuItem1.Click
        Alll_Items.Show()
        Alll_Items.MdiParent = Me

    End Sub

    Private Sub TemSaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemSaleToolStripMenuItem.Click
        Tem_Sale2.Show()
        Tem_Sale2.MdiParent = Me
    End Sub

    Private Sub TemSaleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TemSaleToolStripMenuItem1.Click
        Tem_Sale4.Show()
        Tem_Sale4.MdiParent = Me
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        New_Customer.Show()
        New_Customer.MdiParent = Me
    End Sub

    Private Sub ChaqueIssueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChaqueIssueToolStripMenuItem.Click
        Customer_Chaque.Show()
        Customer_Chaque.MdiParent = Me
    End Sub

    Private Sub INVOICEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INVOICEToolStripMenuItem.Click
        Sale_Invice.Show()
        Sale_Invice.MdiParent = Me
    End Sub

    Private Sub TemSale4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemSale4ToolStripMenuItem.Click
        Tem_Sale6.Show()
        Tem_Sale6.MdiParent = Me
    End Sub

    Private Sub TemSale3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemSale3ToolStripMenuItem.Click
        Tem_Sale7.Show()
        Tem_Sale7.MdiParent = Me
    End Sub

    Private Sub TemSale5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemSale5ToolStripMenuItem.Click
        Tem_Sale9.Show()
        Tem_Sale9.MdiParent = Me
    End Sub
End Class