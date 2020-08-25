
Partial Class Reports
    Inherits System.Web.UI.Page

   
    
    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click

        If CrystalReportViewer2.Visible = True Then
            CrystalReportViewer2.Visible = False
        ElseIf CrystalReportViewer3.Visible = True Then
            CrystalReportViewer3.Visible = False
        End If

        Dim DatabaseInfo As CrystalDecisions.Shared.TableLogOnInfo
        For Each DatabaseInfo In CrystalReportViewer1.LogOnInfo
            DatabaseInfo.ConnectionInfo.ServerName = "146.230.177.46\ist3"
            DatabaseInfo.ConnectionInfo.DatabaseName = "group7"
            DatabaseInfo.ConnectionInfo.UserID = "group7"
            DatabaseInfo.ConnectionInfo.Password = "wd82h"
        Next
        CrystalReportViewer1.Visible = True
    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click

        If CrystalReportViewer1.Visible = True Then
            CrystalReportViewer1.Visible = False
        ElseIf CrystalReportViewer3.Visible = True Then
            CrystalReportViewer3.Visible = False
        End If

        Dim DatabaseInfo As CrystalDecisions.Shared.TableLogOnInfo
        For Each DatabaseInfo In CrystalReportViewer2.LogOnInfo
            DatabaseInfo.ConnectionInfo.ServerName = "146.230.177.46\ist3"
            DatabaseInfo.ConnectionInfo.DatabaseName = "group7"
            DatabaseInfo.ConnectionInfo.UserID = "group7"
            DatabaseInfo.ConnectionInfo.Password = "wd82h"
        Next
        CrystalReportViewer2.Visible = True

    End Sub

    Protected Sub Button3_Click(sender As Object, e As System.EventArgs) Handles Button3.Click

        If CrystalReportViewer1.Visible = True Then
            CrystalReportViewer1.Visible = False
        ElseIf CrystalReportViewer2.Visible = True Then
            CrystalReportViewer2.Visible = False
        End If

        Dim DatabaseInfo As CrystalDecisions.Shared.TableLogOnInfo
        For Each DatabaseInfo In CrystalReportViewer3.LogOnInfo
            DatabaseInfo.ConnectionInfo.ServerName = "146.230.177.46\ist3"
            DatabaseInfo.ConnectionInfo.DatabaseName = "group7"
            DatabaseInfo.ConnectionInfo.UserID = "group7"
            DatabaseInfo.ConnectionInfo.Password = "wd82h"
        Next
        CrystalReportViewer3.Visible = True
    End Sub

End Class
