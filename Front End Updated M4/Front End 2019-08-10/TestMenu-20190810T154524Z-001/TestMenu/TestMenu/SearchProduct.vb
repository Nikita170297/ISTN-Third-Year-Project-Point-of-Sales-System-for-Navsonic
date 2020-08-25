Public Class SearchProduct
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ProductsTableAdapter1.FillBy1(DSProducts.Products, txtSearch.Text)
    End Sub

    Private Sub SearchProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductsTableAdapter1.Fill(DSProducts.Products)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class