Public Class InstallationPayment

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 0 To Group7DataSet1.Details_Installation.Rows.Count - 1

            If Group7DataSet1.Details_Installation.Rows(i).Item(0) = txtID.Text Then

                Dim tot As Decimal = Group7DataSet1.Details_Installation.Rows(i).Item(5)

                txtTotCost.Text = Group7DataSet1.Details_Installation.Rows(i).Item(5)

            End If
        Next
    End Sub

    Private Sub InstallationPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Details_InstallationTableAdapter1.Fill(Group7DataSet1.Details_Installation)
        txtDate.Enabled = False
        Dim date2 As Date = Date.Today

        txtDate.Text = date2
        txtID.Text = SubmitInstallationReq.friInID

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim owe As Decimal = Convert.ToDecimal(txtTotCost.Text)
        If txtAmtpaid.Text <> "" Then
            Dim paid As Decimal = Convert.ToDecimal(txtAmtpaid.Text)
            If paid > owe Then
                MsgBox("You cannot pay more than you owe!")
            Else
                txtAmntowed.Text = txtTotCost.Text - txtAmtpaid.Text
                Install_PaymentTableAdapter1.Insert(txtID.Text, txtAmtpaid.Text, txtDate.Text, txtAmntowed.Text)
                MsgBox("Payment Logged!")
                Me.Close()

            End If

        Else
            MsgBox("The Value of Amount Paid cannot be null!")
        End If



    End Sub

    Private Sub txtDate_TextChanged(sender As Object, e As EventArgs) Handles txtDate.TextChanged

    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub

    Private Sub txtAmtpaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmtpaid.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class