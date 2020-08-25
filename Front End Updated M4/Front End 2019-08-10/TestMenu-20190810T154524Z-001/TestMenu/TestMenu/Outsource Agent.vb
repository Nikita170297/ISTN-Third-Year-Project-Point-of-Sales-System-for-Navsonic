Public Class Outsource_Agent


    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        OutsourceAgentTableAdapter1.FillBy(Group7DataSet1.OutsourceAgent, txtSearch.Text)
    End Sub

    Private Sub Outsource_Agent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OutsourceAgentTableAdapter1.Fill(Group7DataSet1.OutsourceAgent)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (txtEmailAdd.Text = "") Or (txtName.Text = "") Or (txtSurname.Text = "") Or (txtAgentFee.Text = "") Or (txtTelephoneNumber.Text = "") Then
            MsgBox("Invalid Fields : Error : Fields cannot be empty!")
        Else
            OutsourceAgentTableAdapter1.UpdateQuery(txtName.Text, txtSurname.Text, txtAgentFee.Text, txtTelephoneNumber.Text, txtEmailAdd.Text, txtAgentID.Text, txtAgentID.Text)
            MsgBox("Outsource Agent Updated!")
            OutsourceAgentTableAdapter1.Fill(Group7DataSet1.OutsourceAgent)
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtName.Clear()
        txtSurname.Clear()
        'txtAgentID.Clear()
        txtTelephoneNumber.Clear()
        txtEmailAdd.Clear()
        txtAgentFee.Clear()


    End Sub

    Private Sub txtAgentFee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAgentFee.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub
End Class