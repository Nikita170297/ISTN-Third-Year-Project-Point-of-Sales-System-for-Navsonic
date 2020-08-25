Public Class ViewCurrentInstallations
    Private Sub ViewCurrentInstallations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataTable1TableAdapter1.Fill(Group7DataSet1.DataTable1)
        Dim dt As Date
        dt = Date.Today
        txtDate.Text = dt
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub txtInstallartionID_TextChanged(sender As Object, e As EventArgs) Handles txtInstallartionID.TextChanged
        If txtInstallartionID.Text = "" Then
            DataTable1TableAdapter1.Fill(Group7DataSet1.DataTable1)
        Else
            DataTable1TableAdapter1.FillBy(Group7DataSet1.DataTable1, txtInstallartionID.Text)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataTable1TableAdapter1.Fill(Group7DataSet1.DataTable1)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub txtAmtpaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmtpaid.TextChanged

    End Sub

    Private Sub txtDate_TextChanged(sender As Object, e As EventArgs) Handles txtDate.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim amtowed = Convert.ToDecimal(txtAmntowed.Text)
        If txtInstallartionID.Text <> "" Then
            If txtAmtpaid.Text <> "" Then
                Dim amtpaid = Convert.ToDecimal(txtAmtpaid.Text)
                If amtpaid > amtowed Then
                    MsgBox("You cannot submit a payment more than the amount owed!")
                Else
                    Dim amt As Decimal = txtAmntowed.Text - txtAmtpaid.Text

                    Install_PaymentTableAdapter1.Insert(txtInstallartionID.Text, txtAmtpaid.Text, txtDate.Text, amt)
                    MsgBox("Payment Updated Successfully!")
                    DataTable1TableAdapter1.Fill(Group7DataSet1.DataTable1)
                    txtAmntowed.Clear()
                    txtAmtpaid.Clear()
                End If


            Else
                MsgBox("Amount Paid Is not Allowed To be Empty!")
            End If
        Else
            MsgBox("Please use the search to select an Installation ID!")
        End If



    End Sub

    Private Sub txtAmntowed_TextChanged(sender As Object, e As EventArgs) Handles txtAmntowed.TextChanged
        DataTable1BindingSource.MoveLast()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtAmtpaid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmtpaid.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub

    Private Sub txtInstallartionID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInstallartionID.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick

    End Sub
End Class