Public Class ViewProducts
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) 
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BindingSource1.MoveFirst()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        BindingSource1.MoveNext()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        BindingSource1.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BindingSource1.MoveLast()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ProductsTableAdapter1.FillBy(DSProduct.Products, ComboBox1.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ProductsTableAdapter1.FillBy1(DSProduct.Products, TextBox1.Text)
    End Sub

    Private Sub ViewProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductsTableAdapter1.Fill(DSProduct.Products)
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar <> "" Then



            e.Handled = True
        End If

    End Sub
End Class