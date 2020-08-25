<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateInstallation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateInstallation))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtInstallationID = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group7DataSet1 = New TestMenu.group7DataSet()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.InstallationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutsourceAgentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipmentCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NavsonicChargesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstallationStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Details_InstallationTableAdapter1 = New TestMenu.group7DataSetTableAdapters.Details_InstallationTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group7DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 25)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Installation ID"
        '
        'txtInstallationID
        '
        Me.txtInstallationID.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BindingSource1, "Installation_ID", True))
        Me.txtInstallationID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Installation_ID", True))
        Me.txtInstallationID.Enabled = False
        Me.txtInstallationID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstallationID.Location = New System.Drawing.Point(241, 19)
        Me.txtInstallationID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtInstallationID.Name = "txtInstallationID"
        Me.txtInstallationID.Size = New System.Drawing.Size(165, 34)
        Me.txtInstallationID.TabIndex = 97
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Details_Installation"
        Me.BindingSource1.DataSource = Me.Group7DataSet1
        '
        'Group7DataSet1
        '
        Me.Group7DataSet1.DataSetName = "group7DataSet"
        Me.Group7DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbStatus
        '
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Complete", "Not Complete"})
        Me.cmbStatus.Location = New System.Drawing.Point(241, 71)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(165, 36)
        Me.cmbStatus.TabIndex = 115
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 25)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "Status"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(36, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1472, 668)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View Updated Installation"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InstallationIDDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.OutsourceAgentIDDataGridViewTextBoxColumn, Me.EquipmentCostDataGridViewTextBoxColumn, Me.NavsonicChargesDataGridViewTextBoxColumn, Me.TotalCostDataGridViewTextBoxColumn, Me.InstallationStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(6, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1460, 633)
        Me.DataGridView1.TabIndex = 0
        '
        'InstallationIDDataGridViewTextBoxColumn
        '
        Me.InstallationIDDataGridViewTextBoxColumn.DataPropertyName = "Installation_ID"
        Me.InstallationIDDataGridViewTextBoxColumn.HeaderText = "Installation_ID"
        Me.InstallationIDDataGridViewTextBoxColumn.Name = "InstallationIDDataGridViewTextBoxColumn"
        Me.InstallationIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'OutsourceAgentIDDataGridViewTextBoxColumn
        '
        Me.OutsourceAgentIDDataGridViewTextBoxColumn.DataPropertyName = "OutsourceAgent_ID"
        Me.OutsourceAgentIDDataGridViewTextBoxColumn.HeaderText = "OutsourceAgent_ID"
        Me.OutsourceAgentIDDataGridViewTextBoxColumn.Name = "OutsourceAgentIDDataGridViewTextBoxColumn"
        '
        'EquipmentCostDataGridViewTextBoxColumn
        '
        Me.EquipmentCostDataGridViewTextBoxColumn.DataPropertyName = "Equipment_Cost"
        Me.EquipmentCostDataGridViewTextBoxColumn.HeaderText = "Equipment_Cost"
        Me.EquipmentCostDataGridViewTextBoxColumn.Name = "EquipmentCostDataGridViewTextBoxColumn"
        '
        'NavsonicChargesDataGridViewTextBoxColumn
        '
        Me.NavsonicChargesDataGridViewTextBoxColumn.DataPropertyName = "Navsonic_Charges"
        Me.NavsonicChargesDataGridViewTextBoxColumn.HeaderText = "Navsonic_Charges"
        Me.NavsonicChargesDataGridViewTextBoxColumn.Name = "NavsonicChargesDataGridViewTextBoxColumn"
        '
        'TotalCostDataGridViewTextBoxColumn
        '
        Me.TotalCostDataGridViewTextBoxColumn.DataPropertyName = "Total_Cost"
        Me.TotalCostDataGridViewTextBoxColumn.HeaderText = "Total_Cost"
        Me.TotalCostDataGridViewTextBoxColumn.Name = "TotalCostDataGridViewTextBoxColumn"
        '
        'InstallationStatusDataGridViewTextBoxColumn
        '
        Me.InstallationStatusDataGridViewTextBoxColumn.DataPropertyName = "Installation_Status"
        Me.InstallationStatusDataGridViewTextBoxColumn.HeaderText = "Installation_Status"
        Me.InstallationStatusDataGridViewTextBoxColumn.Name = "InstallationStatusDataGridViewTextBoxColumn"
        '
        'Details_InstallationTableAdapter1
        '
        Me.Details_InstallationTableAdapter1.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(892, 50)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(222, 57)
        Me.Button4.TabIndex = 136
        Me.Button4.Text = "Update Installation"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1732, 734)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 57)
        Me.Button1.TabIndex = 137
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'UpdateInstallation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1924, 887)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtInstallationID)
        Me.Name = "UpdateInstallation"
        Me.Text = "UpdateInstallation"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group7DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtInstallationID As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents InstallationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OutsourceAgentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EquipmentCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NavsonicChargesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InstallationStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Group7DataSet1 As group7DataSet
    Friend WithEvents Details_InstallationTableAdapter1 As group7DataSetTableAdapters.Details_InstallationTableAdapter
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
End Class
