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
        txtStTelephone.Clear()
        txtAddress.Clear()
        cmbJobt.Text = ""
        cmbStatus.Text = ""
    End Sub

    Private Sub addStaffMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim com As Decimal = 0.00
        txtCommision.Text = com
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If (txtStName.Text <> "" And txtLastName.Text <> "" And txtSalary.Text <> "" And txtStEmailAddress.Text <> "" And txtCommision.Text <> "" And txtLastName.Text <> "" And txtStPassword.Text <> "" And txtStTelephone.Text <> "" And txtAddress.Text <> "") Then


            StaffTableAdapter1.Insert(txtStName.Text, txtLastName.Text, txtAddress.Text, txtStTelephone.Text, txtStEmailAddress.Text, cmbJobt.Text, txtCommision.Text, txtSalary.Text, txtStPassword.Text, cmbStatus.Text)
        Else
            MessageBox.Show("Please Fill in all details")
        End If



    End Sub
End Class