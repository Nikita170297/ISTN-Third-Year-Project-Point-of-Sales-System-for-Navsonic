Public Class MakeASale
    Dim sum As Decimal
    Dim saleId As Integer
    Dim custID As Integer

    Dim prodQuantity As Integer
    Dim newQuantity As Integer
    Dim price As Decimal
    Dim rewards As Decimal
    Dim newReward As Decimal



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub MakeASale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        'TODO: This line of code loads data into the 'Group7DataSet.Sale_Line' table. You can move, or remove it, as needed.
        'Me.Sale_LineTableAdapter.Fill(Me.DSsale.Sale_Line)
        'TODO: This line of code loads data into the 'Group7DataSet.Products' table. You can move, or remove it, as needed.

        Me.ProductsTableAdapter.Fill(Me.DSsale.Products)
        Product_SaleTableAdapter1.Fill(DSsale.Product_Sale)

        BSsale.MoveLast()
        Me.Text = "Make a sale"
    End Sub

   

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        custID = CInt(TextBox3.Text)
        Dim regDate As Date = Date.Now()
        Dim amount As Decimal = 0



        Customer_DetailsTableAdapter1.Rewards(DSsale.Customer_Details, custID)

        If (DSsale.Customer_Details.Rows.Count > 0) Then
            For i As Integer = 0 To DSsale.Customer_Details.Rows.Count - 1

                If (DSsale.Customer_Details.Rows(i).Item(0) = custID) Then
                    rewards = CDec(DSsale.Customer_Details.Rows(i).Item(5))
                End If


            Next

            Product_SaleTableAdapter1.Insert(Login.staffId, custID, amount, regDate)
            Product_SaleTableAdapter1.Fill(DSsale.Product_Sale)

            BSsale.MoveLast()
            TextBox3.ReadOnly = True
            Button3.Enabled = True
            Button5.Enabled = True
            ProductsTable.Enabled = True





        Else
            MessageBox.Show("Invalid Customer ID")

        End If

       








    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ProductsTable.RowHeaderMouseDoubleClick
        Try
            saleId = CInt(TextBox5.Text)

            Dim quanity As String
            quanity = InputBox("Enter Quantity", "Make a sale")
            Dim quantity2 As Integer = CInt(quanity)
            If quantity2 > ProductsTable.CurrentRow.Cells(3).Value Then
                MsgBox("You have requested to buy more products than we have in stock!")
                Exit Sub

            End If
            Dim prodId As Integer
            Dim row As DataRow
            row = DSsale.Products.NewRow

            For i As Integer = 0 To row.ItemArray.Count - 1
                row.Item(i) = ProductsTable.CurrentRow.Cells(i).Value
            Next


            prodId = CInt(row.Item(0))
            price = CDec(row.Item(2))
            prodQuantity = CInt(row.Item(3))



            price = price * quantity2




            sum = sum + price

            Sale_LineTableAdapter.Insert(prodId, saleId, quantity2, price)
            Sale_LineTableAdapter.FillBy(DSsale.Sale_Line, saleId)
            TextBox1.Text = price
            TextBox2.Text = sum
            newQuantity = prodQuantity - quantity2
            ProductsTableAdapter1.UpdateQuantity(newQuantity, prodId, prodId)
            ProductsTableAdapter1.Fill(DSsale.Products)


        Catch ex As Exception

        End Try







    End Sub
    

   


   

    Private Sub searchTxt_TextChanged(sender As Object, e As EventArgs) Handles searchTxt.TextChanged

        ProductsTableAdapter1.FillBy1(DSsale.Products, searchTxt.Text)
    End Sub

    Private Sub DataGridView2_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseDoubleClick
        Try
            Dim row2 As DataRow
            row2 = DSsale.Sale_Line.NewRow
            For i As Integer = 0 To row2.ItemArray.Count - 1
                row2.Item(i) = DataGridView2.CurrentRow.Cells(i).Value
            Next

            Dim lineId As Integer = CInt(row2.Item(0))
            Dim pLineId As Integer = CInt(row2.Item(1))
            Dim deleteQuantity As Integer = CInt(row2.Item(3))
            sum = sum - CDec(row2.Item(4))


            ProductsTableAdapter1.UpdateQuantity2(deleteQuantity, pLineId, pLineId)
            ProductsTableAdapter1.Fill(DSsale.Products)


            TextBox2.Text = sum

            Sale_LineTableAdapter.DeleteItem(pLineId, lineId)
            Sale_LineTableAdapter.FillBy(DSsale.Sale_Line, saleId)
        Catch ex As Exception

        End Try





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (sum < rewards) Then
            sum = 0
            newReward = rewards - sum
            Customer_DetailsTableAdapter1.UpdateRewards(newReward, custID, custID)


        Else
            Dim sum2 As Decimal = sum - rewards
            rewards = 0
            Customer_DetailsTableAdapter1.UpdateRewards(rewards, custID, custID)
            TextBox2.Text = sum2
        End If
        Customer_DetailsTableAdapter1.Fill(DSsale.Customer_Details)
        TextBox4.Clear()


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim saleReward = sum * 0.1
        sum = sum * 0.14




        Product_SaleTableAdapter1.UpdateQuery(sum, saleId, saleId)
        StaffTableAdapter1.UpdateCommission(saleReward, Login.staffId, Login.staffId)
        Customer_DetailsTableAdapter1.UpdateRewards((rewards + saleReward), custID, custID)



        TextBox3.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        DSsale.Sale_Line.Rows.Clear()
        TextBox3.Enabled = True
        MsgBox("Sale Completed!")
        Me.Close()







    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        ViewCust2.Show()



    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text <> "" Then

            Button1.Enabled = True


        End If



    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back) Then
            e.Handled = True



        End If
    End Sub
End Class