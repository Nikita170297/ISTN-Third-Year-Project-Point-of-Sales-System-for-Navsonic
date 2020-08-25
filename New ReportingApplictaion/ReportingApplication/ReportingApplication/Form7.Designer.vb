<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.IdcucyucgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Group7DataSet = New ReportingApplication.group7DataSet()
        Me.Order_LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_LineTableAdapter = New ReportingApplication.group7DataSetTableAdapters.Order_LineTableAdapter()
        Me.TableAdapterManager = New ReportingApplication.group7DataSetTableAdapters.TableAdapterManager()
        Me.ProductsTableAdapter = New ReportingApplication.group7DataSetTableAdapters.ProductsTableAdapter()
        Me.Supplier_OrderTableAdapter = New ReportingApplication.group7DataSetTableAdapters.Supplier_OrderTableAdapter()
        Me.Supplier_OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cryOrderRepo1 = New ReportingApplication.cryOrderRepo()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutsourcedAgentReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsRepairedReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffSalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Group7DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Supplier_OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdcucyucgToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IdcucyucgToolStripMenuItem
        '
        Me.IdcucyucgToolStripMenuItem.Name = "IdcucyucgToolStripMenuItem"
        Me.IdcucyucgToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.IdcucyucgToolStripMenuItem.Text = "Home"
        '
        'Group7DataSet
        '
        Me.Group7DataSet.DataSetName = "group7DataSet"
        Me.Group7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Order_LineBindingSource
        '
        Me.Order_LineBindingSource.DataMember = "Order_Line"
        Me.Order_LineBindingSource.DataSource = Me.Group7DataSet
        '
        'Order_LineTableAdapter
        '
        Me.Order_LineTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Order_LineTableAdapter = Me.Order_LineTableAdapter
        Me.TableAdapterManager.OutsourceAgentTableAdapter = Nothing
        Me.TableAdapterManager.Product_SaleTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.Repair_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Sale_LineTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.Supplier_OrderTableAdapter = Me.Supplier_OrderTableAdapter
        Me.TableAdapterManager.UpdateOrder = ReportingApplication.group7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'Supplier_OrderTableAdapter
        '
        Me.Supplier_OrderTableAdapter.ClearBeforeFill = True
        '
        'Supplier_OrderBindingSource
        '
        Me.Supplier_OrderBindingSource.DataMember = "Supplier_Order"
        Me.Supplier_OrderBindingSource.DataSource = Me.Group7DataSet
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.Group7DataSet
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 24)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.cryOrderRepo1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(900, 464)
        Me.CrystalReportViewer1.TabIndex = 1
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OutsourcedAgentReportToolStripMenuItem, Me.ProductsRepairedReportToolStripMenuItem, Me.StaffSalesReportToolStripMenuItem, Me.InventoryReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
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
        'InventoryReportToolStripMenuItem
        '
        Me.InventoryReportToolStripMenuItem.Name = "InventoryReportToolStripMenuItem"
        Me.InventoryReportToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.InventoryReportToolStripMenuItem.Text = "Inventory Report"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 488)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form7"
        Me.Text = "Order Reports"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Group7DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Supplier_OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IdcucyucgToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Group7DataSet As group7DataSet
    Friend WithEvents Order_LineBindingSource As BindingSource
    Friend WithEvents Order_LineTableAdapter As group7DataSetTableAdapters.Order_LineTableAdapter
    Friend WithEvents TableAdapterManager As group7DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Supplier_OrderTableAdapter As group7DataSetTableAdapters.Supplier_OrderTableAdapter
    Friend WithEvents Supplier_OrderBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As group7DataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents cryOrderRepo1 As cryOrderRepo
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutsourcedAgentReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsRepairedReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffSalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
