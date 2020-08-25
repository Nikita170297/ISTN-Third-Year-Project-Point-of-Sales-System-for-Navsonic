Public Class Update_Inventory

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Update_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group7DataSet.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.DSUpdate.Supplier)
        'TODO: This line of code loads data into the 'Group7DataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.DSUpdate.Products)
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ProductsTableAdapter.FillBy1(DSUpdate.Products, TextBox2.Text)

    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick

        Try
            Dim supplierName As String = ComboBox1.SelectedValue.ToString.Trim
            Dim supplierID As Integer
            For i = 0 To DSUpdate.Supplier.Rows.Count - 1
                If (DSUpdate.Supplier.Rows(i).Item(1) = supplierName) Then

                    supplierID = DSUpdate.Supplier.Rows(i).Item(0)


                End If
            Next
            Dim receivedDate As Date = Date.Today
            Dim quanity As String
            quanity = CInt(InputBox("Enter received Quantity", "Order Product"))
            Dim row As DataRow
            row = DSUpdate.Products.NewRow

            For i As Integer = 0 To row.ItemArray.Count - 1
                row.Item(i) = DataGridView1.CurrentRow.Cells(i).Value
            Next

            Dim prodId As Integer = CInt(row.Item(0))
            Dim prodPrice As Decimal = CDec(row.Item(2))
            Dim amount As Decimal = prodPrice * quanity

            Goods_ReceivedTableAdapter1.Insert(supplierID, Login.staffId, prodId, amount, quanity, receivedDate)
            ProductsTableAdapter.UpdateQuantity2(quanity, prodId, prodId)

            MsgBox("Inventory Updated!")
            ProductsTableAdapter.Fill(DSUpdate.Products)


        Catch ex As Exception

        End Try


    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar <> "" Then



            e.Handled = True

        End If
    End Sub
End Class