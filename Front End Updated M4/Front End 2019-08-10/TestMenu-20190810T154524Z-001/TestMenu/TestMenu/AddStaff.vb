Public Class addStaffMember
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCommision.Clear()
        txtLastName.Clear()
        txtSalary.Clear()
        txtStEmailAddress.Clear()
        txtStName.Clear()
        txtStPassword.Clear()
        MaskedTextBox1.Clear()
        txtAddress.Clear()
        cmbJobt.Text = ""
        cmbStatus.Text = ""
    End Sub

    Private Sub addStaffMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStatus.Text = "Active"
        cmbStatus.Enabled = False

        Dim com As Decimal = 0.00
        txtCommision.Text = com
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        Try

            If (txtStName.Text <> "" And txtLastName.Text <> "" And txtSalary.Text <> "" And txtStEmailAddress.Text <> "" And txtCommision.Text <> "" And txtLastName.Text <> "" And txtStPassword.Text <> "" And MaskedTextBox1.Text <> "" And txtAddress.Text <> "") Then


                StaffTableAdapter1.Insert(txtStName.Text, txtLastName.Text, txtAddress.Text, MaskedTextBox1.Text, txtStEmailAddress.Text, cmbJobt.Text, txtCommision.Text, txtSalary.Text, txtStPassword.Text, cmbStatus.Text)
                MessageBox.Show("Staff Member Added!")
                Me.Close()




            Else
                MessageBox.Show("Please Fill in all details")
            End If

        Catch ex As Exception
            MessageBox.Show("Please ensure all details are correct")
        Finally
            txtCommision.Clear()
            txtLastName.Clear()
            txtSalary.Clear()
            txtStEmailAddress.Clear()
            txtStName.Clear()
            txtStPassword.Clear()
            MaskedTextBox1.Clear()
            txtAddress.Clear()
            cmbJobt.Text = ""
            cmbStatus.Text = ""
        End Try



    End Sub

    Private Sub txtStName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStName.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then

            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then

            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbJobt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbJobt.KeyPress
        If e.KeyChar <> "" Then



            e.Handled = True

        End If
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub
End Class