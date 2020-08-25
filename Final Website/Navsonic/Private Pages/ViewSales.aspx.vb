
Partial Class Private_Pages_ViewSales
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If (Context.User.Identity.IsAuthenticated) Then

            Session("User") = Context.User.Identity.Name


        End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Label9.Text = GridView1.SelectedRow.Cells(1).Text
        GridView2.DataBind()

    End Sub
End Class
