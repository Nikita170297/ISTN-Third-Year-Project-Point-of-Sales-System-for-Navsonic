Public Class SubmitRepair
    Public friReID As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs)

        RepairPayment.Show()
        Me.Close()

    End Sub

    Private Sub txtSaleID_TextChanged(sender As Object, e As EventArgs) Handles txtSaleID.TextChanged
        If txtSaleID.Text = "" Then
            DataTable2TableAdapter1.Fill(Group7DataSet1.DataTable2)
        Else
            DataTable2TableAdapter1.FillBy(Group7DataSet1.DataTable2, txtSaleID.Text)
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub SubmitRepair_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataTable2TableAdapter1.Fill(Group7DataSet1.DataTable2)
        Me.WindowState = FormWindowState.Maximized


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        SearchProduct.Show()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtSaleID.Text = "" Then
            MsgBox("Please enter SaleID In the SaleID Textbox")
            Exit Sub

        End If
        If txtRepairP.Text <> "" Then

            Dim dat As Date
            For i = 0 To Group7DataSet1.Product_Sale.Rows.Count - 1

                If Group7DataSet1.Product_Sale.Rows(i).Item(0) = txtSaleID.Text Then

                    dat = Group7DataSet1.Product_Sale.Rows(i).Item(4)



                End If
            Next

            Dim year As Integer = dat.Year + 2
            Dim mont As Integer = dat.Month
            Dim day As Integer = dat.Day

            Dim WarrDate As Date = New Date(year, mont, day)
            Dim todayDate As Date = Date.Today


            If DateTime.Compare(todayDate, WarrDate) > 0 Then
                Repair_DetailsTableAdapter1.Insert(txtSaleID.Text, txtCustomerID.Text, "NOT COMPLETED", txtRepairP.Text, txtReDesc.Text)
                MsgBox("Repair Logged!")
                Repair_DetailsTableAdapter1.Fill(Group7DataSet1.Repair_Details)
                BindingSource2.MoveLast()
                friReID = CInt(txtRepairID.Text)
            Else
                MsgBox("Cant Log Repair! Warranty Expired!")
            End If

            RepairPayment.Show()
            Me.Close()

        Else
            MsgBox("Repair Price Cannot Be Empty!")

        End If




    End Sub

    Private Sub txtSaleID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaleID.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub

    Private Sub txtRepairP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRepairP.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class