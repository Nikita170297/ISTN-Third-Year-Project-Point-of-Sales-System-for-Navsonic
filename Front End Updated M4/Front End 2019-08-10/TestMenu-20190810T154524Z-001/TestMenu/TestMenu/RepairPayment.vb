Public Class RepairPayment
    Dim date2 As Date
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtAmountOwed.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dat As Date


        For i = 0 To Group7DataSet1.Repair_Details.Rows.Count - 1

            If Group7DataSet1.Repair_Details.Rows(i).Item(0) = txtRepairID.Text Then

                txtRepairPrice.Text = Group7DataSet1.Repair_Details.Rows(i).Item(4)
                txtSaleID.Text = Group7DataSet1.Repair_Details.Rows(i).Item(1)
            End If
        Next

        For i = 0 To Group7DataSet1.Product_Sale.Rows.Count - 1

            If Group7DataSet1.Product_Sale.Rows(i).Item(0) = txtSaleID.Text Then

                dat = Group7DataSet1.Product_Sale.Rows(i).Item(4)

                txtSaleDate.Text = dat

            End If
        Next

        Dim year As Integer = dat.Year + 2
        Dim mont As Integer = dat.Month
        Dim day As Integer = dat.Day

        Dim WarrDate As Date = New Date(year, mont, day)
        txtWexpirydate.Text = WarrDate



    End Sub

    Private Sub RepairPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Repair_DetailsTableAdapter1.Fill(Group7DataSet1.Repair_Details)
        Product_SaleTableAdapter1.Fill(Group7DataSet1.Product_Sale)
        Dim date2 As Date = Date.Today
        txtRepairID.Text = SubmitRepair.friReID

        Me.WindowState = FormWindowState.Maximized


        txtDate.Text = date2

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim owe As Decimal = Convert.ToDecimal(txtRepairPrice.Text)

        If txtamtPaid.Text <> "" Then
            Dim paid As Decimal = Convert.ToDecimal(txtamtPaid.Text)
            If paid > owe Then
                MsgBox("You cannot pay more than you owe!")
            Else
                Dim balance As Decimal = txtRepairPrice.Text - txtamtPaid.Text
                Repair_PaymentTableAdapter1.Insert(txtRepairID.Text, txtDate.Text, CDec(txtamtPaid.Text), balance, txtWexpirydate.Text)
                MsgBox("Payment Logged!")
                MsgBox("First Installment Paid R" & txtamtPaid.Text)
                txtAmountOwed.Text = balance
                Me.Close()

            End If

        Else
            MsgBox("Amount Paid Cannot Be Null!")
        End If



    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub txtamtPaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamtPaid.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub

    Private Sub txtRepairID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRepairID.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class