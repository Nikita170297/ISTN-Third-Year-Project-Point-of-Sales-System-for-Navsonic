Public Class UpdateInstallation
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If cmbStatus.Text = "Complete" Or cmbStatus.Text = "Not Complete" Then
            Details_InstallationTableAdapter1.UpdateQuery(cmbStatus.Text, txtInstallationID.Text, txtInstallationID.Text)
            MsgBox("Installation Updated!")
            Details_InstallationTableAdapter1.Fill(Group7DataSet1.Details_Installation)
            cmbStatus.Text = ""
        Else
            MsgBox("Invalid Status Value!")
            cmbStatus.Text = ""
        End If

    End Sub

    Private Sub UpdateInstallation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Details_InstallationTableAdapter1.Fill(Group7DataSet1.Details_Installation)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub txtInstallationID_TextChanged(sender As Object, e As EventArgs) Handles txtInstallationID.TextChanged

    End Sub

    Private Sub cmbStatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbStatus.KeyPress
        If e.KeyChar <> "" Then



            e.Handled = True

        End If
    End Sub
End Class