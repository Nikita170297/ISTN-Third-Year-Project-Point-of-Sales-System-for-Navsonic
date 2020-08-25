<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutsourcedAgentReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffIDVsSalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsTableAdapter = New ReportingApplication.group7DataSetTableAdapters.ProductsTableAdapter()
        Me.Group7DataSet = New ReportingApplication.group7DataSet()
        Me.Product_SaleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Product_SaleTableAdapter = New ReportingApplication.group7DataSetTableAdapters.Product_SaleTableAdapter()
        Me.TableAdapterManager = New ReportingApplication.group7DataSetTableAdapters.TableAdapterManager()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sale_LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sale_LineTableAdapter = New ReportingApplication.group7DataSetTableAdapters.Sale_LineTableAdapter()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New ReportingApplication.group7DataSetTableAdapters.StaffTableAdapter()
        Me.staffSalesReportNew11 = New ReportingApplication.StaffSalesReportNew1()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Group7DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Product_SaleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sale_LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(852, 24)
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
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OutsourcedAgentReportToolStripMenuItem, Me.InventoryReportToolStripMenuItem, Me.StaffIDVsSalesReportToolStripMenuItem, Me.OrdersReportToolStripMenuItem})
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
        'InventoryReportToolStripMenuItem
        '
        Me.InventoryReportToolStripMenuItem.Name = "InventoryReportToolStripMenuItem"
        Me.InventoryReportToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.InventoryReportToolStripMenuItem.Text = "Products Repaired Report"
        '
        'StaffIDVsSalesReportToolStripMenuItem
        '
        Me.StaffIDVsSalesReportToolStripMenuItem.Name = "StaffIDVsSalesReportToolStripMenuItem"
        Me.StaffIDVsSalesReportToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.StaffIDVsSalesReportToolStripMenuItem.Text = "Inventory Report"
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
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'Group7DataSet
        '
        Me.Group7DataSet.DataSetName = "group7DataSet"
        Me.Group7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Product_SaleBindingSource
        '
        Me.Product_SaleBindingSource.DataMember = "Product_Sale"
        Me.Product_SaleBindingSource.DataSource = Me.Group7DataSet
        '
        'Product_SaleTableAdapter
        '
        Me.Product_SaleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Order_LineTableAdapter = Nothing
        Me.TableAdapterManager.OutsourceAgentTableAdapter = Nothing
        Me.TableAdapterManager.Product_SaleTableAdapter = Me.Product_SaleTableAdapter
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.Repair_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Sale_LineTableAdapter = Me.Sale_LineTableAdapter
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.Supplier_OrderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ReportingApplication.group7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.Group7DataSet
        '
        'Sale_LineBindingSource
        '
        Me.Sale_LineBindingSource.DataMember = "Sale_Line"
        Me.Sale_LineBindingSource.DataSource = Me.Group7DataSet
        '
        'Sale_LineTableAdapter
        '
        Me.Sale_LineTableAdapter.ClearBeforeFill = True
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.Group7DataSet
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 24)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.staffSalesReportNew11
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(852, 387)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 411)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form5"
        Me.Text = "Staff Sales Report"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Group7DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Product_SaleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sale_LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutsourcedAgentReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffIDVsSalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsTableAdapter As group7DataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents Group7DataSet As group7DataSet
    Friend WithEvents Product_SaleBindingSource As BindingSource
    Friend WithEvents Product_SaleTableAdapter As group7DataSetTableAdapters.Product_SaleTableAdapter
    Friend WithEvents TableAdapterManager As group7DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sale_LineTableAdapter As group7DataSetTableAdapters.Sale_LineTableAdapter
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents Sale_LineBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As group7DataSetTableAdapters.StaffTableAdapter
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents staffSalesReportNew11 As StaffSalesReportNew1
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
