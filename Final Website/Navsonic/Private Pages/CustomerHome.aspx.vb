
Partial Class Private_Pages_CustomerHome
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If (Context.User.Identity.IsAuthenticated) Then

            Session("Customer") = Context.User.Identity.Name


        End If
    End Sub
End Class
