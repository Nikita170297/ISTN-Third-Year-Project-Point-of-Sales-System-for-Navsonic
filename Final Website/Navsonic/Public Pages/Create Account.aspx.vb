
Partial Class Public_Pages_Page1
    Inherits System.Web.UI.Page

    Protected Sub SqlDataSource1_Inserted(sender As Object, e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles SqlDataSource1.Inserted
        Label6.Visible = True
        TextBox7.Visible = True
        Button2.Visible = True
        TextBox7.Text = Convert.ToString(e.Command.Parameters("@id").Value)


    End Sub

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Try

            SqlDataSource1.Insert()

        Catch ex As Exception
            MsgBox("Please Ensure All Details Are Correct")
        End Try


    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click

    End Sub
End Class
