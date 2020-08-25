Public Class AddNewOutsourceAgent
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        Try
            If (txtName.Text <> "" And txtSurname.Text <> "" And txtAgentFee.Text <> "" And txtTelephoneNumber.Text <> "" And txtEmailAddress.Text <> "") Then

                OutsourceAgentTableAdapter1.Insert(txtName.Text, txtSurname.Text, txtAgentFee.Text, txtTelephoneNumber.Text, txtEmailAddress.Text)
                MsgBox("Outsource Agent Added!")
                Me.Close()

            Else
                MessageBox.Show("Please fill in all details")

            End If
        Catch ex As Exception
            MessageBox.Show("Please ensure details are correct")
        Finally
            txtAgentFee.Clear()
            txtEmailAddress.Clear()
            txtName.Clear()
            txtSurname.Clear()
            txtTelephoneNumber.Clear()


        End Try



    End Sub

    Private Sub AddNewOutsourceAgent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OutsourceAgentTableAdapter1.Fill(Group7DataSet1.OutsourceAgent)
    End Sub

    Private Sub txtAgentFee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAgentFee.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub

    Private Sub txtSurname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSurname.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then
            e.Handled = False



        Else
            e.Handled = True

        End If

    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then
            e.Handled = False



        Else
            e.Handled = True

        End If
    End Sub
End Class