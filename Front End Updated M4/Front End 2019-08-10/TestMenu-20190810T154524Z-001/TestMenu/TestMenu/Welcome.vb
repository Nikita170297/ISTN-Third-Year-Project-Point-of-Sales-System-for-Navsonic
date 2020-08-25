Public Class Welcome


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Login.Show()
        Me.Hide()
    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtUpdateSu_Click(sender As Object, e As EventArgs) Handles txtUpdateSu.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class
