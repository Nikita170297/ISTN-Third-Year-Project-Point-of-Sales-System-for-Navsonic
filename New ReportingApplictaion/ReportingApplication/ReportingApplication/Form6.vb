Public Class Form6
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub OutsourcedAgentReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub InventoryReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub ProductIDVsSalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub OrdersReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form7.Show()
        Me.Hide()

    End Sub

    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group7DataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutsourcedAgentReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsRepairedReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffSalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Group7DataSet = New ReportingApplication.group7DataSet()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New ReportingApplication.group7DataSetTableAdapters.ProductsTableAdapter()
        Me.TableAdapterManager = New ReportingApplication.group7DataSetTableAdapters.TableAdapterManager()
        Me.inventoryOfProductsNew1 = New ReportingApplication.inventoryOfProductsNew()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Group7DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(773, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OutsourcedAgentReportToolStripMenuItem, Me.ProductsRepairedReportToolStripMenuItem, Me.StaffSalesReportToolStripMenuItem, Me.OrdersReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'OutsourcedAgentReportToolStripMenuItem
        '
        Me.OutsourcedAgentReportToolStripMenuItem.Name = "OutsourcedAgentReportToolStripMenuItem"
        Me.OutsourcedAgentReportToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.OutsourcedAgentReportToolStripMenuItem.Text = "Outsourced Agent Report"
        '
        'ProductsRepairedReportToolStripMenuItem
        '
        Me.ProductsRepairedReportToolStripMenuItem.Name = "ProductsRepairedReportToolStripMenuItem"
        Me.ProductsRepairedReportToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ProductsRepairedReportToolStripMenuItem.Text = "Products Repaired Report"
        '
        'StaffSalesReportToolStripMenuItem
        '
        Me.StaffSalesReportToolStripMenuItem.Name = "StaffSalesReportToolStripMenuItem"
        Me.StaffSalesReportToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.StaffSalesReportToolStripMenuItem.Text = "Staff Sales Report"
        '
        'OrdersReportToolStripMenuItem
        '
        Me.OrdersReportToolStripMenuItem.Name = "OrdersReportToolStripMenuItem"
        Me.OrdersReportToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.OrdersReportToolStripMenuItem.Text = "Orders Report"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Group7DataSet
        '
        Me.Group7DataSet.DataSetName = "group7DataSet"
        Me.Group7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.Group7DataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Order_LineTableAdapter = Nothing
        Me.TableAdapterManager.OutsourceAgentTableAdapter = Nothing
        Me.TableAdapterManager.Product_SaleTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.Repair_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Sale_LineTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.Supplier_OrderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ReportingApplication.group7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 24)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.inventoryOfProductsNew1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(773, 385)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Form6
        '
        Me.ClientSize = New System.Drawing.Size(773, 409)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form6"
        Me.Text = "Inventory Report"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Group7DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub Form6_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group7DataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.Group7DataSet.Products)
        inventoryOfProductsNew1.SetDataSource(Group7DataSet)
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group7DataSet)

    End Sub

    Private Sub OutsourcedAgentReportToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OutsourcedAgentReportToolStripMenuItem.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub ProductsRepairedReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsRepairedReportToolStripMenuItem.Click
        Form4.Show()
        Me.Close()


    End Sub

    Private Sub StaffSalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffSalesReportToolStripMenuItem.Click
        Form5.Show()
        Me.Close()


    End Sub

    Private Sub OrdersReportToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OrdersReportToolStripMenuItem.Click
        Form7.Show()
        Me.Close()

    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class