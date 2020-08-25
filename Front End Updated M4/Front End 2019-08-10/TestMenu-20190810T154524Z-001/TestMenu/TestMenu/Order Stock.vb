Public Class Order_Stock

    Dim prodId As Integer
    Dim prodPrice As Decimal
    Dim supplierId As Integer
    Dim sum As Decimal = 0

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Order_New_Product.Show()

    End Sub

    Private Sub Order_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'TODO: This line of code loads data into the 'Group7DataSet.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.Group7DataSet.Supplier)


        'TODO: This line of code loads data into the 'DSOrder.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.DSOrder.Supplier)
        'TODO: This line of code loads data into the 'DSOrder.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.DSOrder.Products)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Dim supplierName As String = ComboBox1.SelectedValue.ToString.Trim

        'For i = 0 To DSOrder.Supplier.Rows.Count - 1
        'If (DSOrder.Supplier.Rows(i).Item(1) = supplierName) Then

        'supplierId = DSOrder.Supplier.Rows(i).Item(0)


        'End If



        'Next


        'Supplier_Order1TableAdapter1.CreateOrder(supplierId, 2, MaskedTextBox1.Text, 0)
        'Supplier_Order1TableAdapter1.Fill(DSOrder.Supplier_Order1)
        'SupplierOrder1BindingSource.MoveLast()
        Dim date1 = Date.Now
        Dim date2 As Date = MaskedTextBox1.Text
        If (Date.Compare(date1, date2) < 0) Then
            Dim supplierName As String = ComboBox1.SelectedValue.ToString.Trim

            For i = 0 To DSOrder.Supplier.Rows.Count - 1
                If (DSOrder.Supplier.Rows(i).Item(1) = supplierName) Then

                    supplierId = DSOrder.Supplier.Rows(i).Item(0)


                End If



            Next


            Supplier_Order1TableAdapter1.CreateOrder(supplierId, 2, MaskedTextBox1.Text, 0)
            Supplier_Order1TableAdapter1.Fill(DSOrder.Supplier_Order1)
            SupplierOrder1BindingSource.MoveLast()
            DataGridView1.Enabled = True


        Else
            MaskedTextBox1.Clear()
            MessageBox.Show("Invalid Date, Please re-enter")

        End If


    End Sub

    Private Sub DataGridView2_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseDoubleClick
        Dim row2 As DataRow
        row2 = DSOrder.Order_Line.NewRow
        Dim ask As MsgBoxResult = MsgBox("Are you sure you want to remove these items from the order", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            For i As Integer = 0 To row2.ItemArray.Count - 1
                row2.Item(i) = DataGridView2.CurrentRow.Cells(i).Value
            Next

            sum = sum - CDec(row2.Item(3) * row2.Item(4))
            TextBox1.Text = sum
            Order_LineTableAdapter.DeleteOrder(CInt(row2.Item(0)))
            Order_LineTableAdapter.FillBy(DSOrder.Order_Line, CInt(TextBox2.Text))






        End If
       



    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick

        Try
            Dim quanity As String
            quanity = CInt(InputBox("Enter Quantity", "Order Product"))
            Dim row As DataRow
            row = DSOrder.Products.NewRow

            For i As Integer = 0 To row.ItemArray.Count - 1
                row.Item(i) = DataGridView1.CurrentRow.Cells(i).Value
            Next

            prodId = CInt(row.Item(0))
            prodPrice = CDec(row.Item(2))
            Dim amount As Decimal = prodPrice * quanity
            sum = sum + amount

            Order_LineTableAdapter.Insert(CInt(TextBox2.Text), prodId, quanity, prodPrice)
            Order_LineTableAdapter.FillBy(DSOrder.Order_Line, CInt(TextBox2.Text))
            TextBox1.Text = sum
        Catch ex As Exception

        End Try








    End Sub

   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Supplier_Order1TableAdapter1.UpdateOrder(sum, CInt(TextBox2.Text), CInt(TextBox2.Text))
        MsgBox("Order Completed!")
        TextBox1.Clear()
        TextBox2.Clear()
        DSOrder.Order_Line.Rows.Clear()

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ProductsTableAdapter.FillBy1(DSOrder.Products, txtSearch.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class