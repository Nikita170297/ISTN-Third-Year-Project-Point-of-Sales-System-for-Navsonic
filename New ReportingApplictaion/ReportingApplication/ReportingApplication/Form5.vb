Public Class Form5
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub OutsourcedAgentReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutsourcedAgentReportToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub InventoryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryReportToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub StaffIDVsSalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffIDVsSalesReportToolStripMenuItem.Click
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub OrdersReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersReportToolStripMenuItem.Click
        Form7.Show()
        Me.Hide()

    End Sub

    Private Sub Product_SaleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Product_SaleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group7DataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group7DataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.Group7DataSet.Staff)
        'TODO: This line of code loads data into the 'Group7DataSet.Sale_Line' table. You can move, or remove it, as needed.
        Me.Sale_LineTableAdapter.Fill(Me.Group7DataSet.Sale_Line)
        'TODO: This line of code loads data into the 'Group7DataSet.Product_Sale' table. You can move, or remove it, as needed.
        Me.Product_SaleTableAdapter.Fill(Me.Group7DataSet.Product_Sale)
        'TODO: This line of code loads data into the 'Group7DataSet.Sale_Line' table. You can move, or remove it, as needed.
        Me.Sale_LineTableAdapter.Fill(Me.Group7DataSet.Sale_Line)
        'TODO: This line of code loads data into the 'Group7DataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.Group7DataSet.Products)
        'TODO: This line of code loads data into the 'Group7DataSet.Product_Sale' table. You can move, or remove it, as needed.
        Me.Product_SaleTableAdapter.Fill(Me.Group7DataSet.Product_Sale)
        staffSalesReportNew11.SetDataSource(Group7DataSet)
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Product_SaleBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Product_SaleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group7DataSet)

    End Sub
End Class