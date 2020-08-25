Imports System.Data

Partial Class Private_Pages_OnlineSale
    Inherits System.Web.UI.Page
    Dim myCart As DataTable



    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not (IsPostBack) Then
            Session("cart") = makeCart()
            viewCart()
        End If



    End Sub


    Function makeCart() As DataTable
        myCart = New DataTable
        With myCart
            .Columns.Add("ItemID")
            .Columns.Add("Item Name")
            .Columns.Add("Item Price")
            .Columns.Add("Item Quantity")
            .Columns.Add("Item Subtotal")

        End With
        Return myCart
    End Function
    Sub AddToCart()
        Dim dropDown1 As DropDownList
        Dim prodName As String
        Dim Qty As Integer
        Dim cartRow As DataRow
        Dim prodPrice, subTotal As Decimal
        Dim itemMatch As Boolean = False

        myCart = Session("Cart")
        prodName = DetailsView1.Rows(1).Cells(1).Text
        dropDown1 = DetailsView1.Rows(6).FindControl("DropDownList2")
        Qty = dropDown1.SelectedValue
        prodPrice = DetailsView1.Rows(2).Cells(1).Text
        subTotal = prodPrice * Qty

        For i As Integer = 0 To myCart.Rows.Count - 1
            cartRow = myCart.Rows(i)
            If (cartRow("Item Name") = prodName) Then
                itemMatch = True
                myCart.Rows(i).Item("Item Quantity") = Qty
                myCart.Rows(i).Item("Item Subtotal") = String.Format("{0:c}", subTotal)
                Exit For

            End If
        Next
        If Not itemMatch Then
            cartRow = myCart.NewRow
            cartRow("ItemID") = DetailsView1.Rows(0).Cells(1).Text
            cartRow("Item Name") = DetailsView1.Rows(1).Cells(1).Text
            cartRow("Item Price") = DetailsView1.Rows(2).Cells(1).Text
            cartRow("Item Quantity") = Qty
            cartRow("Item Subtotal") = String.Format("{0:c}", subTotal)
            myCart.Rows.Add(cartRow)



        End If
    End Sub

    Sub viewCart()
        Session("Cart") = myCart
        GridView1.DataSource = myCart
        GridView1.AutoGenerateColumns = True
        GridView1.ShowFooter = True
        GridView1.Columns(0).FooterText = "Final Total: " & String.Format("{0:c}", getItemTotal())
        GridView1.DataBind()



    End Sub
    Function getItemTotal() As Decimal
        Dim sum As Decimal
        For i As Integer = 0 To myCart.Rows.Count - 1
            sum += CDbl(myCart.Rows(i).Item("Item Subtotal"))
        Next
        Session("TotalSales") = sum
        Return sum
    End Function

    Protected Sub GridView1_RowDeleting(sender As Object, e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles GridView1.RowDeleting
        myCart = Session("Cart")
        myCart.Rows(e.RowIndex).Delete()
        viewCart()

    End Sub

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        If DropDownList3.SelectedValue <> "Select Type" Then

            AddToCart()
            viewCart()
            Label1.Visible = False
        Else
            Label1.Visible = True

        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        myCart = Session("cart")
        myCart.Clear()
        viewCart()

    End Sub

    Protected Sub Button3_Click(sender As Object, e As System.EventArgs) Handles Button3.Click
        Response.Redirect("~\Private Pages\Checkout.aspx")

    End Sub
End Class
