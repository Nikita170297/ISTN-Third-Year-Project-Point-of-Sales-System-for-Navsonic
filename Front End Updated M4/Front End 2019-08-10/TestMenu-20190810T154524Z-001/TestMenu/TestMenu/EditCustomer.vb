Public Class EditCustomer
    Private Sub btnClear_Click(sender As Object, e As EventArgs) 
        txtName.Clear()
        txtEmailAddress.Clear()
        txtLastNam.Clear()
        txtTelephone.Clear()
        txtAddress.Clear()
        cmbStatus.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) 
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub EditCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Customer_DetailsTableAdapter1.Fill(DSCustomer.Customer_Details)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Customer_DetailsTableAdapter1.Fillby2(DSCustomer.Customer_Details, txtSearch.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            ' CustomerDetailsBindingSource1.EndEdit()
            'CustomerDetailsBindingSource1.Update(DSCustomer.Customer_Details)
            Customer_DetailsTableAdapter1.UpdateQuery2(txtName.Text, txtLastNam.Text, txtAddress.Text, txtTelephone.Text, txtCustRewards.Text, cmbStatus.Text, txtCustID.Text, txtCustID.Text, txtCustID.Text)
            ' Customer_DetailsTableAdapter1.UpdateQuery(txtName.Text, txtLastNam.Text, txtAddress.Text, txtTelephone.Text, txtCustRewards.Text, cmbStatus.Text)
            Customer_DetailsTableAdapter1.Fill(DSCustomer.Customer_Details)
            MsgBox("Customer Details Edited!")
        Catch ex As Exception
            MessageBox.Show("Please ensure details are correct")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CustomerDetailsBindingSource1.MoveFirst()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CustomerDetailsBindingSource1.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CustomerDetailsBindingSource1.MovePrevious()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CustomerDetailsBindingSource1.MoveLast()

    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()

    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCustID.Clear()
        txtName.Clear()
        txtLastNam.Clear()
        txtAddress.Clear()
        txtEmailAddress.Clear()
        txtCustRewards.Clear()
        txtTelephone.Clear()
        cmbStatus.Text = ""
    End Sub

    Private Sub txtCustRewards_TextChanged(sender As Object, e As EventArgs) Handles txtCustRewards.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtCustID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustID.KeyPress

    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then
            e.Handled = False



        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtLastNam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastNam.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then
            e.Handled = False



        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtTelephone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelephone.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub

    Private Sub txtCustRewards_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustRewards.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub

    Private Sub cmbStatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbStatus.KeyPress
        If e.KeyChar <> "" Then



            e.Handled = True

        End If
    End Sub
End Class