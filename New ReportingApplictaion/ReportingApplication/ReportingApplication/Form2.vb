Public Class Form2
    Private Sub OutsourcedAgentReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralReportToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub InventoryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrossTabReportToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()


    End Sub

    Private Sub ProductIDVsSalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParameterizedReportToolStripMenuItem.Click
        Form5.Show()
        Me.Hide()


    End Sub

    Private Sub StaffIDVsSalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffIDVsSalesToolStripMenuItem.Click
        Form6.Show()
        Me.Hide()


    End Sub

    Private Sub OrdersReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersReportToolStripMenuItem.Click
        Form7.Show()
        Me.Hide()


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "In the Menu Tab above: 

The Outsourced Agent Report in the menu shows the price paid by the company for the outsourced agents.
The Products Repaired Report shows the products repaired. The rows display the names of the customers who sent in a product for repairs and the coloumns show the product that was sent in.
The Staff Sales shows the summary of staff sales. The rows show the Staff ID and the coloumns are the products.
The Inventory Report shows you the current inventory of the company.
The Orders Report shows the orders made by the company. Enter in the values for the months and year to be viewed."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Form1.Show()
        Form1.txtusername.Text = ""
        Form1.txtPassword.Text = ""

        Me.Close()

    End Sub
End Class