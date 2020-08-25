Public Class ViewStaff
    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        txtCommision.Clear()
        txtLastName.Clear()
        txtSalary.Clear()
        txtStEmailAddress.Clear()
        txtStName.Clear()

        txtStTelephone.Clear()
        txtAddress.Clear()
        cmbJobt.Text = ""
        cmbStatus.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub ViewStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StaffTableAdapter1.Fill(Group7DataSet1.Staff)
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub txtStName_TextChanged(sender As Object, e As EventArgs) Handles txtStName.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BS.MoveFirst()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BS.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        BS.MovePrevious()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        BS.MoveLast()
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()

    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStName.Clear()
        txtLastName.Clear()
        txtStTelephone.Clear()
        txtAddress.Clear()
        txtStEmailAddress.Clear()
        cmbJobt.Text = ""
        cmbStatus.Text = ""


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        StaffTableAdapter1.FillBy(Group7DataSet1.Staff, TextBox2.Text)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        StaffTableAdapter1.UpdateQuery(txtStName.Text, txtLastName.Text, txtAddress.Text, txtStTelephone.Text, txtStEmailAddress.Text, cmbJobt.Text, cmbStatus.Text, txtStaffID.Text, txtStaffID.Text)
        MsgBox("Staff Member Updated!")
        StaffTableAdapter1.Fill(Group7DataSet1.Staff)
    End Sub

    Private Sub txtStTelephone_TextChanged(sender As Object, e As EventArgs) Handles txtStTelephone.TextChanged

    End Sub
End Class