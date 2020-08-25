<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrossTabReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParameterizedReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffIDVsSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(702, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralReportToolStripMenuItem, Me.CrossTabReportToolStripMenuItem, Me.ParameterizedReportToolStripMenuItem, Me.StaffIDVsSalesToolStripMenuItem, Me.OrdersReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'GeneralReportToolStripMenuItem
        '
        Me.GeneralReportToolStripMenuItem.Name = "GeneralReportToolStripMenuItem"
        Me.GeneralReportToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.GeneralReportToolStripMenuItem.Text = "Outsourced Agent Report"
        '
        'CrossTabReportToolStripMenuItem
        '
        Me.CrossTabReportToolStripMenuItem.Name = "CrossTabReportToolStripMenuItem"
        Me.CrossTabReportToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CrossTabReportToolStripMenuItem.Text = "Products Repaired Report"
        '
        'ParameterizedReportToolStripMenuItem
        '
        Me.ParameterizedReportToolStripMenuItem.Name = "ParameterizedReportToolStripMenuItem"
        Me.ParameterizedReportToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ParameterizedReportToolStripMenuItem.Text = "Staff Sales Report"
        '
        'StaffIDVsSalesToolStripMenuItem
        '
        Me.StaffIDVsSalesToolStripMenuItem.Name = "StaffIDVsSalesToolStripMenuItem"
        Me.StaffIDVsSalesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.StaffIDVsSalesToolStripMenuItem.Text = "Inventory Report"
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(634, 448)
        Me.Label1.TabIndex = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        '        Me.BackgroundImage = Global.ReportingApplication.My.Resources.Resources.blue_moving_flowing_abstract_waves_on_white_background_blurred_smooth_graphic_motion_design_video_animation_1920x1080_vhhueydte__F0000
        Me.ClientSize = New System.Drawing.Size(702, 495)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneralReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrossTabReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParameterizedReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffIDVsSalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
