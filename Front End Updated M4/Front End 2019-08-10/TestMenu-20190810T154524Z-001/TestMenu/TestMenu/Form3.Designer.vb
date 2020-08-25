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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakeASaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakeASaleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateCustomerAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCustomerAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomerAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubmitRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCurrentInstallationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateInstallationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepairsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogAFaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCurrentRepairsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateRepairPaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffToolStripMenuItem, Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem1, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(729, 33)
        Me.MenuStrip1.TabIndex = 44
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MakeASaleToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.InstallationsToolStripMenuItem, Me.RepairsToolStripMenuItem, Me.SearchProductToolStripMenuItem})
        Me.StaffToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(55, 27)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'MakeASaleToolStripMenuItem
        '
        Me.MakeASaleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MakeASaleToolStripMenuItem1})
        Me.MakeASaleToolStripMenuItem.Name = "MakeASaleToolStripMenuItem"
        Me.MakeASaleToolStripMenuItem.Size = New System.Drawing.Size(202, 28)
        Me.MakeASaleToolStripMenuItem.Text = "Sales"
        '
        'MakeASaleToolStripMenuItem1
        '
        Me.MakeASaleToolStripMenuItem1.Name = "MakeASaleToolStripMenuItem1"
        Me.MakeASaleToolStripMenuItem1.Size = New System.Drawing.Size(181, 28)
        Me.MakeASaleToolStripMenuItem1.Text = "Make A Sale"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateCustomerAccountToolStripMenuItem, Me.EditCustomerAccountToolStripMenuItem, Me.ViewCustomerAccountsToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(202, 28)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'CreateCustomerAccountToolStripMenuItem
        '
        Me.CreateCustomerAccountToolStripMenuItem.Name = "CreateCustomerAccountToolStripMenuItem"
        Me.CreateCustomerAccountToolStripMenuItem.Size = New System.Drawing.Size(283, 28)
        Me.CreateCustomerAccountToolStripMenuItem.Text = "Create Customer Account"
        '
        'EditCustomerAccountToolStripMenuItem
        '
        Me.EditCustomerAccountToolStripMenuItem.Name = "EditCustomerAccountToolStripMenuItem"
        Me.EditCustomerAccountToolStripMenuItem.Size = New System.Drawing.Size(283, 28)
        Me.EditCustomerAccountToolStripMenuItem.Text = "Edit Customer Account"
        '
        'ViewCustomerAccountsToolStripMenuItem
        '
        Me.ViewCustomerAccountsToolStripMenuItem.Name = "ViewCustomerAccountsToolStripMenuItem"
        Me.ViewCustomerAccountsToolStripMenuItem.Size = New System.Drawing.Size(283, 28)
        Me.ViewCustomerAccountsToolStripMenuItem.Text = "View Customer Accounts"
        '
        'InstallationsToolStripMenuItem
        '
        Me.InstallationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubmitRequestToolStripMenuItem, Me.ViewCurrentInstallationsToolStripMenuItem, Me.UpdateInstallationsToolStripMenuItem})
        Me.InstallationsToolStripMenuItem.Name = "InstallationsToolStripMenuItem"
        Me.InstallationsToolStripMenuItem.Size = New System.Drawing.Size(202, 28)
        Me.InstallationsToolStripMenuItem.Text = "Installations"
        '
        'SubmitRequestToolStripMenuItem
        '
        Me.SubmitRequestToolStripMenuItem.Name = "SubmitRequestToolStripMenuItem"
        Me.SubmitRequestToolStripMenuItem.Size = New System.Drawing.Size(302, 28)
        Me.SubmitRequestToolStripMenuItem.Text = "Submit Request"
        '
        'ViewCurrentInstallationsToolStripMenuItem
        '
        Me.ViewCurrentInstallationsToolStripMenuItem.Name = "ViewCurrentInstallationsToolStripMenuItem"
        Me.ViewCurrentInstallationsToolStripMenuItem.Size = New System.Drawing.Size(302, 28)
        Me.ViewCurrentInstallationsToolStripMenuItem.Text = "Update Installation Payment"
        '
        'UpdateInstallationsToolStripMenuItem
        '
        Me.UpdateInstallationsToolStripMenuItem.Name = "UpdateInstallationsToolStripMenuItem"
        Me.UpdateInstallationsToolStripMenuItem.Size = New System.Drawing.Size(302, 28)
        Me.UpdateInstallationsToolStripMenuItem.Text = "Update Installations"
        '
        'RepairsToolStripMenuItem
        '
        Me.RepairsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogAFaultToolStripMenuItem, Me.ViewCurrentRepairsToolStripMenuItem, Me.UpdateRepairPaymentsToolStripMenuItem})
        Me.RepairsToolStripMenuItem.Name = "RepairsToolStripMenuItem"
        Me.RepairsToolStripMenuItem.Size = New System.Drawing.Size(202, 28)
        Me.RepairsToolStripMenuItem.Text = "Repairs"
        '
        'LogAFaultToolStripMenuItem
        '
        Me.LogAFaultToolStripMenuItem.Name = "LogAFaultToolStripMenuItem"
        Me.LogAFaultToolStripMenuItem.Size = New System.Drawing.Size(273, 28)
        Me.LogAFaultToolStripMenuItem.Text = "Log A Fault"
        '
        'ViewCurrentRepairsToolStripMenuItem
        '
        Me.ViewCurrentRepairsToolStripMenuItem.Name = "ViewCurrentRepairsToolStripMenuItem"
        Me.ViewCurrentRepairsToolStripMenuItem.Size = New System.Drawing.Size(273, 28)
        Me.ViewCurrentRepairsToolStripMenuItem.Text = "Update Repairs"
        '
        'UpdateRepairPaymentsToolStripMenuItem
        '
        Me.UpdateRepairPaymentsToolStripMenuItem.Name = "UpdateRepairPaymentsToolStripMenuItem"
        Me.UpdateRepairPaymentsToolStripMenuItem.Size = New System.Drawing.Size(273, 28)
        Me.UpdateRepairPaymentsToolStripMenuItem.Text = "Update Repair Payments"
        '
        'SearchProductToolStripMenuItem
        '
        Me.SearchProductToolStripMenuItem.Name = "SearchProductToolStripMenuItem"
        Me.SearchProductToolStripMenuItem.Size = New System.Drawing.Size(202, 28)
        Me.SearchProductToolStripMenuItem.Text = "Search Product"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(69, 27)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(57, 27)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(68, 27)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(729, 558)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Form3"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MakeASaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MakeASaleToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateCustomerAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditCustomerAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCustomerAccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstallationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubmitRequestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCurrentInstallationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateInstallationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RepairsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogAFaultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCurrentRepairsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateRepairPaymentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
End Class
