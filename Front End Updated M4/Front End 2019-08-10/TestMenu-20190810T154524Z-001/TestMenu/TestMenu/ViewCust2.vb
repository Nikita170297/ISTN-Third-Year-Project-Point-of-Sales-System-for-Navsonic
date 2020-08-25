Public Class ViewCust2
    Friend CustID2 As Integer
    Friend rewards As Double
    Friend Name As String


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Customer_DetailsTableAdapter1.Fillby2(DSCustomer.Customer_Details, txtSearch.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        CustomerDetailsBindingSource.MoveFirst()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        CustomerDetailsBindingSource.MovePrevious()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        CustomerDetailsBindingSource.MoveNext()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        CustomerDetailsBindingSource.MoveLast()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()

    End Sub

    Private Sub ViewCust2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Customer_DetailsTableAdapter1.Fill(DSCustomer.Customer_Details)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        Dim row As DataRow
        row = DSCustomer.Customer_Details.NewRow
        For i As Integer = 0 To row.ItemArray.Count - 1
            row.Item(i) = DataGridView1.CurrentRow.Cells(i).Value

        Next
        Dim n As String = row.Item(1)
        Dim s As String = row.Item(2)
        Name = n & " " & s
        CustID2 = row.Item(0)
        rewards = row.Item(5)
        MakeASale.TextBox3.Text = CustID2
        MakeASale.TextBox4.Text = rewards
        MakeASale.NameAndSurname.Text = Name

        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        CustomerDetailsBindingSource.MoveFirst()

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        CustomerDetailsBindingSource.MoveNext()

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        CustomerDetailsBindingSource.MovePrevious()

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        CustomerDetailsBindingSource.MoveLast()

    End Sub
End Class