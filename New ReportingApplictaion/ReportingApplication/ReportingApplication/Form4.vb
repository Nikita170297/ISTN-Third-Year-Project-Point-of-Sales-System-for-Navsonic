Public Class Form4
    Private Sub OutsourcedAgentReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutsourcedAgentReportToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub ProductIDVsSalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductIDVsSalesReportToolStripMenuItem.Click
        Form5.Show()
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

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        'Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group7DataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group7DataSet.Repair_Details' table. You can move, or remove it, as needed.
        Me.Repair_DetailsTableAdapter.Fill(Me.Group7DataSet.Repair_Details)
        'TODO: This line of code loads data into the 'Group7DataSet.Customer_Details' table. You can move, or remove it, as needed.
        Me.Customer_DetailsTableAdapter.Fill(Me.Group7DataSet.Customer_Details)
        'TODO: This line of code loads data into the 'Group7DataSet.Sale_Line' table. You can move, or remove it, as needed.
        ' Me.Sale_LineTableAdapter.Fill(Me.Group7DataSet.Sale_Line)
        'TODO: This line of code loads data into the 'Group7DataSet.Products' table. You can move, or remove it, as needed.
        ' Me.ProductsTableAdapter.Fill(Me.Group7DataSet.Products)
        'TODO: This line of code loads data into the 'Group7DataSet.Products' table. You can move, or remove it, as needed.
        'Me.ProductsTableAdapter.Fill(Me.Group7DataSet.Products)
        repairsReport1.SetDataSource(Group7DataSet)
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub ProductsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        'Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group7DataSet)

    End Sub

    Private Sub Customer_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Customer_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group7DataSet)

    End Sub
End Class