
Partial Class Account_Register2
    Inherits System.Web.UI.Page

    Protected Sub CreateUserWizard1_CreatedUser(sender As Object, e As System.EventArgs) Handles CreateUserWizard1.CreatedUser

    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox1.TextChanged
        GridView1.DataBind()

    End Sub

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        If GridView1.Rows.Count > 0 Then
            Panel1.Visible = True
            CreateUserWizard1.UserName = TextBox1.Text
            CreateUserWizard1.Email = GridView1.Rows(0).Cells(6).Text





        End If
    End Sub
End Class
