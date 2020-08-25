Public Class AddRepairPayments
    Private Sub AddRepairPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataTable3TableAdapter1.Fill(Group7DataSet1.DataTable3)
        Dim dd As Date = Date.Today
        txtDate.Text = dd
    End Sub

    Private Sub txtInstallartionID_TextChanged(sender As Object, e As EventArgs) Handles txtRepairID.TextChanged
        If txtRepairID.Text = "" Then
            DataTable3TableAdapter1.Fill(Group7DataSet1.DataTable3)
        Else
            DataTable3TableAdapter1.FillBy(Group7DataSet1.DataTable3, txtRepairID.Text)
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataTable3TableAdapter1.Fill(Group7DataSet1.DataTable3)

    End Sub

    Private Sub txtAmntowed_TextChanged(sender As Object, e As EventArgs) Handles txtAmntowed.TextChanged
        BindingSource1.MoveLast()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim owe As Decimal = Convert.ToDecimal(txtAmntowed.Text)
        If txtAmtpaid.Text <> "" Then
            Dim paid As Decimal = Convert.ToDecimal(txtAmntowed.Text)
            If paid > owe Then
                Dim BalanceOfpay As Decimal = txtAmntowed.Text - txtAmtpaid.Text
                Repair_PaymentTableAdapter1.Insert(txtRepairID.Text, txtDate.Text, txtAmtpaid.Text, BalanceOfpay, TxtWarranty.Text)
                DataTable3TableAdapter1.Fill(Group7DataSet1.DataTable3)
                txtAmtpaid.Clear()
                MsgBox("Add Repair Payments Successful!")
                Me.Close()
            Else
                MsgBox("You cannot pay more than you owe!")

            End If


        Else
            MsgBox("Repair Payment Installations cannot be null!")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub txtRepairID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRepairID.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub

    Private Sub txtAmtpaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmtpaid.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class