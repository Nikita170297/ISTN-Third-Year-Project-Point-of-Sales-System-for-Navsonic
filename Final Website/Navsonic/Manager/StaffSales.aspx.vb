
Partial Class Manager_StaffSales
    Inherits System.Web.UI.Page
    Dim Sum As Decimal = 0

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Label3.Text = GridView1.SelectedRow.Cells(1).Text
        GridView2.DataBind()
        GridView2.Visible = True
        For i As Integer = 0 To GridView2.Rows.Count - 1
            Sum += CDec(GridView2.Rows(i).Cells(1).Text)

        Next
        TextBox1.Text = String.Format("{0:c}", Sum)


    End Sub
End Class