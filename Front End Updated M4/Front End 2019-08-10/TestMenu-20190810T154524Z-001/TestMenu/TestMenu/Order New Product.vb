Public Class Order_New_Product

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Order_Stock.Show()
        Me.Close()


    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text <> "") Then
            Dim name As String = TextBox1.Text
            If (TextBox2.Text <> "") Then
                Dim price As Decimal = CDec(TextBox2.Text)

                If (TextBox3.Text <> "") Then
                    Dim description As String = TextBox3.Text
                    Dim type As String = ComboBox1.SelectedItem
                    TAProd.Insert(name, price, 0, description, type, "LOW")
                    TAProd.Fill(DSProd.Products)



                Else
                    MessageBox.Show("Please Enter Product Description")

                End If


            Else
                MessageBox.Show("Please Enter Product price")

            End If

        Else
            MessageBox.Show("Please Enter Product Name")


        End If

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub

  

    Private Sub Order_New_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TAProd.Fill(DSProd.Products)
    End Sub


End Class