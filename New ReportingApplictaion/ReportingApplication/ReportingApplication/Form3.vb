Public Class Form3
    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub InventoryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryReportToolStripMenuItem.Click
        Form4.Show()
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

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OutsourceAgentTableAdapter1.Fill(Group7DataSet1.OutsourceAgent)
        OutsourceAgentsFeeReport1.SetDataSource(Group7DataSet1)
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub OutsourceAgentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OutsourceAgentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group7DataSet1)

    End Sub

    Private Sub crystalReport11_InitReport(sender As Object, e As EventArgs)

    End Sub
End Class