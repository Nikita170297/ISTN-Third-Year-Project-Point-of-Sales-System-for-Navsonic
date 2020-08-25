<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutsourcedAgentReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductIDVsSalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffIDVsSalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Group7DataSet = New ReportingApplication.group7DataSet()
        Me.Customer_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_DetailsTableAdapter = New ReportingApplication.group7DataSetTableAdapters.Customer_DetailsTableAdapter()
        Me.TableAdapterManager = New ReportingApplication.group7DataSetTableAdapters.TableAdapterManager()
        Me.Repair_DetailsTableAdapter = New ReportingApplication.group7DataSetTableAdapters.Repair_DetailsTableAdapter()
        Me.Repair_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.repairsReport1 = New ReportingApplication.RepairsReport()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Group7DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repair_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(914, 24)
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
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OutsourcedAgentReportToolStripMenuItem, Me.ProductIDVsSalesReportToolStripMenuItem, Me.StaffIDVsSalesReportToolStripMenuItem, Me.OrdersReportToolStripMenuItem})
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
        'ProductIDVsSalesReportToolStripMenuItem
        '
        Me.ProductIDVsSalesReportToolStripMenuItem.Name = "ProductIDVsSalesReportToolStripMenuItem"
        Me.ProductIDVsSalesReportToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ProductIDVsSalesReportToolStripMenuItem.Text = "Staff Sales Report"
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
        'Group7DataSet
        '
        Me.Group7DataSet.DataSetName = "group7DataSet"
        Me.Group7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Customer_DetailsBindingSource
        '
        Me.Customer_DetailsBindingSource.DataMember = "Customer_Details"
        Me.Customer_DetailsBindingSource.DataSource = Me.Group7DataSet
        '
        'Customer_DetailsTableAdapter
        '
        Me.Customer_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_DetailsTableAdapter = Me.Customer_DetailsTableAdapter
        Me.TableAdapterManager.Order_LineTableAdapter = Nothing
        Me.TableAdapterManager.OutsourceAgentTableAdapter = Nothing
        Me.TableAdapterManager.Product_SaleTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.Repair_DetailsTableAdapter = Me.Repair_DetailsTableAdapter
        Me.TableAdapterManager.Sale_LineTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.Supplier_OrderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ReportingApplication.group7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Repair_DetailsTableAdapter
        '
        Me.Repair_DetailsTableAdapter.ClearBeforeFill = True
        '
        'Repair_DetailsBindingSource
        '
        Me.Repair_DetailsBindingSource.DataMember = "Repair_Details"
        Me.Repair_DetailsBindingSource.DataSource = Me.Group7DataSet
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 24)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.repairsReport1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(914, 509)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 533)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form4"
        Me.Text = "Product Sales Report"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Group7DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repair_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutsourcedAgentReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductIDVsSalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffIDVsSalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Group7DataSet As group7DataSet
    Friend WithEvents Customer_DetailsBindingSource As BindingSource
    Friend WithEvents Customer_DetailsTableAdapter As group7DataSetTableAdapters.Customer_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As group7DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Repair_DetailsTableAdapter As group7DataSetTableAdapters.Repair_DetailsTableAdapter
    Friend WithEvents Repair_DetailsBindingSource As BindingSource
    Friend WithEvents repairsReport1 As RepairsReport
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
