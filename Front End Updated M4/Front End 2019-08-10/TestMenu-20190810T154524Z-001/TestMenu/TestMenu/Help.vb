Imports TestMenu
Imports System.Net

Public Class Help
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        System.Windows.Forms.Help.ShowHelp(Me, HP1.HelpNamespace)
    End Sub

    
   
    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class