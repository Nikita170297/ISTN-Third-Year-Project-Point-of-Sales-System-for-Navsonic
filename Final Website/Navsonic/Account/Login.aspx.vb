﻿
Partial Class Account_Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString("ReturnUrl"))
    End Sub

    Protected Sub LoginButton_Click(sender As Object, e As System.EventArgs)
        'Session("UserID") = LoginUser.UserName

    End Sub

    Protected Sub LoginButton_Click1(sender As Object, e As System.EventArgs)

    End Sub
End Class