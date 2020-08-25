Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StaffTableAdapter1.Fill(Me.Group7DataSet1.Staff)
        txtPassword.Text = ""
        txtusername.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim i As Integer


        If txtusername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Username or password fields cannot be empty!")

        Else

            Dim userno As Integer = txtusername.Text
            Dim password As String = txtPassword.Text

            For i = 0 To Group7DataSet1.Staff.Rows.Count - 1

                If Group7DataSet1.Staff.Rows(i).Item(0) = userno And Group7DataSet1.Staff.Rows(i).Item(9) = password Then

                    If Group7DataSet1.Staff.Rows(i).Item("Job_Title") = "Manager" Or Group7DataSet1.Staff.Rows(i).Item("Job_Title") = "manager" Then
                        MessageBox.Show("You will now be directed to the menu.")
                        Form2.Show()
                        Me.Hide()

                        Exit Sub







                    Else
                        MessageBox.Show("Access Denied!")
                        txtusername.Text = ""
                        txtPassword.Text = ""
                        Exit Sub

                    End If
                Else
                    MessageBox.Show("Incorrect password for StaffID " & userno)
                    txtPassword.Text = ""
                    Exit Sub

                End If


            Next



        End If

    End Sub

    Private Sub txtusername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusername.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ",") Then
            e.Handled = True



        End If
    End Sub
End Class
