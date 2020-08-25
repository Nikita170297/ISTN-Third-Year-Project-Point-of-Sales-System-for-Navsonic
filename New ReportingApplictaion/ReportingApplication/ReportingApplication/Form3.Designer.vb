<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductIDVsSalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffIDVsSalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutsourceAgentTableAdapter1 = New ReportingApplication.group7DataSetTableAdapters.OutsourceAgentTableAdapter()
        Me.Group7DataSet1 = New ReportingApplication.group7DataSet()
        Me.OutsourceAgentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New ReportingApplication.group7DataSetTableAdapters.TableAdapterManager()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.OutsourceAgentsFeeReport1 = New ReportingApplication.OutsourceAgentsFeeReport()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Group7DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutsourceAgentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportsToolStripMenuItem, Me.ReportsToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(869, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ReportsToolStripMenuItem.Text = "Home"
        '
        'ReportsToolStripMenuItem1
        '
        Me.ReportsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventoryReportToolStripMenuItem, Me.ProductIDVsSalesReportToolStripMenuItem, Me.StaffIDVsSalesReportToolStripMenuItem, Me.OrdersReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem1.Name = "ReportsToolStripMenuItem1"
        Me.ReportsToolStripMenuItem1.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem1.Text = "Reports"
        '
        'InventoryReportToolStripMenuItem
        '
        Me.InventoryReportToolStripMenuItem.Name = "InventoryReportToolStripMenuItem"
        Me.InventoryReportToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.InventoryReportToolStripMenuItem.Text = "Products Repaired Report"
        '
        'ProductIDVsSalesReportToolStripMenuItem
        '
        Me.ProductIDVsSalesReportToolStripMenuItem.Name = "ProductIDVsSalesReportToolStripMenuItem"
        Me.ProductIDVsSalesReportToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ProductIDVsSalesReportToolStripMenuItem.Text = "Staff Sales Report"
        '
        'StaffIDVsSalesReportToolStripMenuItem
        '
        Me.StaffIDVsSalesReportToolStripMenuItem.Name = "StaffIDVsSalesReportToolStripMenuItem"
        Me.StaffIDVsSalesReportToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.StaffIDVsSalesReportToolStripMenuItem.Text = "Inventory Report"
        '
        'OrdersReportToolStripMenuItem
        '
        Me.OrdersReportToolStripMenuItem.Name = "OrdersReportToolStripMenuItem"
        Me.OrdersReportToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.OrdersReportToolStripMenuItem.Text = "Orders Report"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OutsourceAgentTableAdapter1
        '
        Me.OutsourceAgentTableAdapter1.ClearBeforeFill = True
        '
        'Group7DataSet1
        '
        Me.Group7DataSet1.DataSetName = "group7DataSet"
        Me.Group7DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OutsourceAgentBindingSource
        '
        Me.OutsourceAgentBindingSource.DataMember = "OutsourceAgent"
        Me.OutsourceAgentBindingSource.DataSource = Me.Group7DataSet1
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Order_LineTableAdapter = Nothing
        Me.TableAdapterManager.OutsourceAgentTableAdapter = Me.OutsourceAgentTableAdapter1
        Me.TableAdapterManager.Product_SaleTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
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
        Me.CrystalReportViewer1.ReportSource = Me.OutsourceAgentsFeeReport1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(869, 376)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 400)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form3"
        Me.Text = "Outsourced Agent Report"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Group7DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutsourceAgentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InventoryReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductIDVsSalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffIDVsSalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutsourceAgentTableAdapter1 As group7DataSetTableAdapters.OutsourceAgentTableAdapter
    Friend WithEvents Group7DataSet1 As group7DataSet
    Friend WithEvents OutsourceAgentBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As group7DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents OutsourceAgentsFeeReport1 As OutsourceAgentsFeeReport
End Class
