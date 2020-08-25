Public Class ViewSup
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        txtSuAddress.Clear()
        txtSuEmail.Clear()
        txtSuName.Clear()
        txtSuNumber.Clear()
    End Sub

    Private Sub ViewSup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SupplierTableAdapter1.Fill(DSSupplier.Supplier)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        SupplierTableAdapter1.FillBy(DSSupplier.Supplier, TextBox2.Text)
    End Sub

    Private Sub txtUpdateSu_Click(sender As Object, e As EventArgs) Handles txtUpdateSu.Click
        'SupplierBindingSource.EndEdit()
        SupplierTableAdapter1.UpdateQuery5(txtSuName.Text, txtSuAddress.Text, txtSuNumber.Text, txtSuEmail.Text, ComboBox1.Text, TextBox1.Text, TextBox1.Text)
        MsgBox("Supplier Updated!")
        SupplierTableAdapter1.Fill(DSSupplier.Supplier)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        txtSuName.Clear()
        txtSuAddress.Clear()
        txtSuEmail.Clear()
        txtSuNumber.Clear()
        TextBox1.Clear()
        ComboBox1.Text = ""
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SupplierBindingSource.MoveFirst()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SupplierBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SupplierBindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SupplierBindingSource.MoveLast()
    End Sub
End Class