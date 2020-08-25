
Public Class Login
    Public login
    Public staffId As Integer
    Friend password As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ' If IsNumeric(TextBox1.Text) Then
        ' MsgBox("Username Okay!")
        staffId = CInt(TextBox2.Text)

        ' Else
        'MsgBox("Invalid Username: Error: Only Numbers As Username!")
        'TextBox1.Text = ""
        'TextBox2.Text = ""
        'End If

        password = TextBox1.Text




        TAStaff.Login(DSStaff.Staff, staffId, password)
        If (DSStaff.Staff.Rows.Count > 0) Then
            For i = 0 To DSStaff.Staff.Rows.Count - 1
                If (DSStaff.Staff.Rows(i).Item(6) = "Manager") Then
                    Me.Text = "Logged in as: " & DSStaff.Staff.Rows(0).Item(1) & "-" + DSStaff.Staff.Rows(0).Item(0).ToString
                    Form1.Text = "Logged in as: " & DSStaff.Staff.Rows(0).Item(1) & "-" + DSStaff.Staff.Rows(0).Item(0).ToString
                    Form1.Show()
                    TextBox1.Clear()
                    TextBox2.Clear()

                    Me.Hide()

                Else
                    Me.Text = "Logged in as: " & DSStaff.Staff.Rows(0).Item(1) & "-" + DSStaff.Staff.Rows(0).Item(0).ToString
                    Form3.Text = "Logged in as: " & DSStaff.Staff.Rows(0).Item(1) & "-" + DSStaff.Staff.Rows(0).Item(0).ToString
                    Form3.Show()
                    TextBox1.Clear()
                    TextBox2.Clear()
                    Me.Hide()

                End If


            Next

        Else
            MessageBox.Show("Invalid Login Details, Try Again")
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If














    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso (e.KeyChar <> ControlChars.Back) Then
            e.Handled = True



        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class