Public Class Form7
    Private Sub Order_LineBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Order_LineBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group7DataSet)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group7DataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.Group7DataSet.Products)
        'TODO: This line of code loads data into the 'Group7DataSet.Supplier_Order' table. You can move, or remove it, as needed.
        Me.Supplier_OrderTableAdapter.Fill(Me.Group7DataSet.Supplier_Order)
        'TODO: This line of code loads data into the 'Group7DataSet.Order_Line' table. You can move, or remove it, as needed.
        Me.Order_LineTableAdapter.Fill(Me.Group7DataSet.Order_Line)
        cryOrderRepo1.SetDataSource(Group7DataSet)
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub OutsourcedAgentReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutsourcedAgentReportToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub ProductsRepairedReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsRepairedReportToolStripMenuItem.Click
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub StaffSalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffSalesReportToolStripMenuItem.Click
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub InventoryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryReportToolStripMenuItem.Click
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class