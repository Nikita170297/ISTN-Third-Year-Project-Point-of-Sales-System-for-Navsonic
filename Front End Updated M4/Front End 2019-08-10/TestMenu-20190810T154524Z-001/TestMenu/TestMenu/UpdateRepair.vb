Public Class UpdateRepair
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If cmbStatus.Text = "COMPLETE" Or cmbStatus.Text = "NOT COMPLETE" Then
            Repair_DetailsTableAdapter1.UpdateQuery(cmbStatus.Text, txtRepairID.Text, txtRepairID.Text)
            Repair_DetailsTableAdapter1.Fill(Group7DataSet1.Repair_Details)
            cmbStatus.Text = ""
            MsgBox("Status Updated Successfully!")

        Else
            MsgBox("Incorrect/Empty Values!")

        End If


    End Sub

    Private Sub UpdateRepair_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Repair_DetailsTableAdapter1.Fill(Group7DataSet1.Repair_Details)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            Repair_DetailsTableAdapter1.Fill(Group7DataSet1.Repair_Details)
        Else
            Repair_DetailsTableAdapter1.FillBy(Group7DataSet1.Repair_Details, TextBox2.Text)
        End If

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub cmbStatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbStatus.KeyPress
        If e.KeyChar <> "" Then



            e.Handled = True

        End If
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged

    End Sub
End Class