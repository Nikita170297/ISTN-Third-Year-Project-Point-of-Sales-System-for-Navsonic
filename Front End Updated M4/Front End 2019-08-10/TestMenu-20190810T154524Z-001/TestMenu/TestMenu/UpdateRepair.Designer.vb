<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateRepair
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateRepair))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Repairs = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RepairIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group7DataSet1 = New TestMenu.group7DataSet()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Repair_DetailsTableAdapter1 = New TestMenu.group7DataSetTableAdapters.Repair_DetailsTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtRepairID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Repairs.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group7DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1723, 661)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 57)
        Me.Button1.TabIndex = 151
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(6, 208)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(222, 57)
        Me.Button4.TabIndex = 150
        Me.Button4.Text = "Update Repair"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Repairs
        '
        Me.Repairs.BackColor = System.Drawing.Color.Transparent
        Me.Repairs.Controls.Add(Me.TextBox2)
        Me.Repairs.Controls.Add(Me.Label2)
        Me.Repairs.Controls.Add(Me.DataGridView1)
        Me.Repairs.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Repairs.Location = New System.Drawing.Point(12, 12)
        Me.Repairs.Name = "Repairs"
        Me.Repairs.Size = New System.Drawing.Size(1326, 706)
        Me.Repairs.TabIndex = 149
        Me.Repairs.TabStop = False
        Me.Repairs.Text = "Repairs"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(370, 20)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(165, 34)
        Me.TextBox2.TabIndex = 148
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(157, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 25)
        Me.Label2.TabIndex = 147
        Me.Label2.Text = "Search By Repair ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RepairIDDataGridViewTextBoxColumn, Me.SaleIDDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.RepairPriceDataGridViewTextBoxColumn, Me.RepairDescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(6, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1245, 620)
        Me.DataGridView1.TabIndex = 0
        '
        'RepairIDDataGridViewTextBoxColumn
        '
        Me.RepairIDDataGridViewTextBoxColumn.DataPropertyName = "Repair_ID"
        Me.RepairIDDataGridViewTextBoxColumn.HeaderText = "Repair_ID"
        Me.RepairIDDataGridViewTextBoxColumn.Name = "RepairIDDataGridViewTextBoxColumn"
        Me.RepairIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaleIDDataGridViewTextBoxColumn
        '
        Me.SaleIDDataGridViewTextBoxColumn.DataPropertyName = "Sale_ID"
        Me.SaleIDDataGridViewTextBoxColumn.HeaderText = "Sale_ID"
        Me.SaleIDDataGridViewTextBoxColumn.Name = "SaleIDDataGridViewTextBoxColumn"
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'RepairPriceDataGridViewTextBoxColumn
        '
        Me.RepairPriceDataGridViewTextBoxColumn.DataPropertyName = "Repair_Price"
        Me.RepairPriceDataGridViewTextBoxColumn.HeaderText = "Repair_Price"
        Me.RepairPriceDataGridViewTextBoxColumn.Name = "RepairPriceDataGridViewTextBoxColumn"
        '
        'RepairDescriptionDataGridViewTextBoxColumn
        '
        Me.RepairDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Repair_Description"
        Me.RepairDescriptionDataGridViewTextBoxColumn.HeaderText = "Repair_Description"
        Me.RepairDescriptionDataGridViewTextBoxColumn.Name = "RepairDescriptionDataGridViewTextBoxColumn"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Repair_Details"
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
        Me.cmbStatus.Items.AddRange(New Object() {"COMPLETE", "NOT COMPLETE"})
        Me.cmbStatus.Location = New System.Drawing.Point(178, 150)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(165, 36)
        Me.cmbStatus.TabIndex = 148
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 25)
        Me.Label10.TabIndex = 147
        Me.Label10.Text = "Status"
        '
        'Repair_DetailsTableAdapter1
        '
        Me.Repair_DetailsTableAdapter1.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtRepairID)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cmbStatus)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1399, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(513, 316)
        Me.GroupBox2.TabIndex = 152
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Edit Repair"
        '
        'txtRepairID
        '
        Me.txtRepairID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Repair_ID", True))
        Me.txtRepairID.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BindingSource1, "Repair_ID", True))
        Me.txtRepairID.Enabled = False
        Me.txtRepairID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRepairID.Location = New System.Drawing.Point(178, 37)
        Me.txtRepairID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRepairID.Name = "txtRepairID"
        Me.txtRepairID.Size = New System.Drawing.Size(165, 34)
        Me.txtRepairID.TabIndex = 152
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 25)
        Me.Label3.TabIndex = 151
        Me.Label3.Text = "Repair ID"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Repair_Description", True))
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BindingSource1, "Repair_Description", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(178, 91)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(241, 34)
        Me.TextBox1.TabIndex = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Repair Description"
        '
        'UpdateRepair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1924, 795)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Repairs)
        Me.Name = "UpdateRepair"
        Me.Text = "Update Repair"
        Me.Repairs.ResumeLayout(False)
        Me.Repairs.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group7DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Repairs As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents RepairIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaleIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RepairPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RepairDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Group7DataSet1 As group7DataSet
    Friend WithEvents Repair_DetailsTableAdapter1 As group7DataSetTableAdapters.Repair_DetailsTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtRepairID As TextBox
    Friend WithEvents Label3 As Label
End Class
