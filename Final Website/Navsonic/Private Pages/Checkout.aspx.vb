Imports System.Data

Partial Class Private_Pages_Checkout
    Inherits System.Web.UI.Page
    Dim myCart As DataTable
    Dim rewards As Double

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Label3.Text = Date.Now
        Label4.Text = String.Format("{0:C}", Session("TotalSales"))

        Label5.Text = "USER ID:"
        If (Context.User.Identity.IsAuthenticated) Then

            Label6.Text = Context.User.Identity.Name


        End If
        showCart()



    End Sub
    Sub showCart()
        myCart = New DataTable
        With myCart
            .Columns.Add("ItemID")
            .Columns.Add("Item Name")
            .Columns.Add("Item Price")
            .Columns.Add("Item Quantity")
            .Columns.Add("Item Subtotal")

        End With
        myCart = Session("cart")
        GridView1.DataSource = myCart
        GridView1.AutoGenerateColumns = True
        GridView1.DataBind()

    End Sub

    Protected Sub DetailsView1_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.DetailsViewPageEventArgs) Handles DetailsView1.PageIndexChanging

    End Sub

   

    Protected Sub SqlDataSource2_Inserted(sender As Object, e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles SqlDataSource2.Inserted
        Dim saleID As Integer = e.Command.Parameters("@SaleNumber").Value
        For i As Integer = 0 To myCart.Rows.Count - 1

            With SqlDataSource3

                .InsertParameters("Product_ID").DefaultValue = myCart.Rows(i).Item("ItemID")
                .InsertParameters("Sale_ID").DefaultValue = saleID
                .InsertParameters("Unit_Quantity").DefaultValue = myCart.Rows(i).Item("Item Quantity")
                .InsertParameters("Sale_Price").DefaultValue = myCart.Rows(i).Item("Item Price")

            End With



            SqlDataSource3.Insert()

        Next
        ' MsgBox("Inserted Successfully")
        Session("CustID") = Label6.Text

    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        rewards = CDec(DetailsView1.Rows(3).Cells(1).Text) + (Session("TotalSales") / 10)
        SqlDataSource2.Insert()
        For i As Integer = 0 To myCart.Rows.Count - 1

            With SqlDataSource4
                .UpdateParameters("Product_ID").DefaultValue = myCart.Rows(i).Item("ItemID")
                .UpdateParameters("Quantity").DefaultValue = myCart.Rows(i).Item("Item Quantity")
            End With

            SqlDataSource4.Update()

        Next
        With SqlDataSource1
            .UpdateParameters("Customer_ID").DefaultValue = CInt(Label6.Text)
            .UpdateParameters("Customer_Rewards").DefaultValue = CDec(rewards)

        End With
        SqlDataSource1.Update()
        ' Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('New Rewards =' + );</script>")
        Button2.Enabled = False
        Response.Redirect("~\Private Pages\ViewSales.aspx")




    End Sub

    Protected Sub Button4_Click(sender As Object, e As System.EventArgs) Handles Button4.Click
        Session("TotalSales") = Session("TotalSales") - CDec(DetailsView1.Rows(3).Cells(1).Text)
        Label4.Text = Session("TotalSales")
        ' rewards = 0
        With SqlDataSource1
            .UpdateParameters("Customer_ID").DefaultValue = Label6.Text
            .UpdateParameters("Customer_Rewards").DefaultValue = 0
            .Update()
        End With




        Button4.Enabled = False



    End Sub

    Protected Sub Button3_Click(sender As Object, e As System.EventArgs) Handles Button3.Click
        Response.Redirect("~\Private Pages\OnlineSale.aspx")
    End Sub
End Class
