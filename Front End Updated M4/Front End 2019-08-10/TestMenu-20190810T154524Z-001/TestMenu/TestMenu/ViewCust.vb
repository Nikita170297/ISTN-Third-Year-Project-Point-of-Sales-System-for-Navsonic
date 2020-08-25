Public Class ViewCust
    Friend CustID As Integer

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Customer_DetailsTableAdapter1.Fillby2(DSCustomer.Customer_Details, txtSearch.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        CustomerDetailsBindingSource.MoveFirst()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        CustomerDetailsBindingSource.MoveNext()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        CustomerDetailsBindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        CustomerDetailsBindingSource.MoveLast()

    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private Sub ViewCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Customer_DetailsTableAdapter1.Fill(DSCustomer.Customer_Details)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        Dim row As DataRow
        row = DSCustomer.Customer_Details.NewRow
        For i As Integer = 0 To row.ItemArray.Count - 1
            row.Item(i) = DataGridView1.CurrentRow.Cells(i).Value

        Next
        CustID = row.Item(0)
        SubmitInstallationReq.txtCustID.Text = CustID
        Me.Hide()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        CustomerDetailsBindingSource.MovePrevious()

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        CustomerDetailsBindingSource.MoveNext()

    End Sub

    Private Sub btnBack_Click_2(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        CustomerDetailsBindingSource.MoveFirst()

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        CustomerDetailsBindingSource.MoveLast()

    End Sub
End Class