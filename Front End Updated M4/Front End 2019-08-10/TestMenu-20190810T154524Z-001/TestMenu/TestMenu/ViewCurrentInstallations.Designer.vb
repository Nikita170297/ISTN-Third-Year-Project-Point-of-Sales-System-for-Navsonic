<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewCurrentInstallations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewCurrentInstallations))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtInstallartionID = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.InstallationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutsourceAgentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipmentCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NavsonicChargesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstallationStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstallationPaymentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceOfPaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group7DataSet1 = New TestMenu.group7DataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataTable1TableAdapter1 = New TestMenu.group7DataSetTableAdapters.DataTable1TableAdapter()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtAmtpaid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAmntowed = New System.Windows.Forms.TextBox()
        Me.Install_PaymentTableAdapter1 = New TestMenu.group7DataSetTableAdapters.Install_PaymentTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group7DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtInstallartionID)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1477, 809)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Installation Payment Installments"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1291, 737)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 57)
        Me.Button1.TabIndex = 106
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtInstallartionID
        '
        Me.txtInstallartionID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstallartionID.Location = New System.Drawing.Point(390, 58)
        Me.txtInstallartionID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtInstallartionID.Name = "txtInstallartionID"
        Me.txtInstallartionID.Size = New System.Drawing.Size(165, 34)
        Me.txtInstallartionID.TabIndex = 104
        Me.ToolTip1.SetToolTip(Me.txtInstallartionID, "click on an installation ID")
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InstallationIDDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.OutsourceAgentIDDataGridViewTextBoxColumn, Me.EquipmentCostDataGridViewTextBoxColumn, Me.NavsonicChargesDataGridViewTextBoxColumn, Me.TotalCostDataGridViewTextBoxColumn, Me.InstallationStatusDataGridViewTextBoxColumn, Me.InstallationPaymentIDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.AmountPaidDataGridViewTextBoxColumn, Me.BalanceOfPaymentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DataTable1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1465, 626)
        Me.DataGridView1.TabIndex = 100
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
        'InstallationPaymentIDDataGridViewTextBoxColumn
        '
        Me.InstallationPaymentIDDataGridViewTextBoxColumn.DataPropertyName = "Installation_PaymentID"
        Me.InstallationPaymentIDDataGridViewTextBoxColumn.HeaderText = "Installation_PaymentID"
        Me.InstallationPaymentIDDataGridViewTextBoxColumn.Name = "InstallationPaymentIDDataGridViewTextBoxColumn"
        Me.InstallationPaymentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'AmountPaidDataGridViewTextBoxColumn
        '
        Me.AmountPaidDataGridViewTextBoxColumn.DataPropertyName = "Amount_Paid"
        Me.AmountPaidDataGridViewTextBoxColumn.HeaderText = "Amount_Paid"
        Me.AmountPaidDataGridViewTextBoxColumn.Name = "AmountPaidDataGridViewTextBoxColumn"
        '
        'BalanceOfPaymentDataGridViewTextBoxColumn
        '
        Me.BalanceOfPaymentDataGridViewTextBoxColumn.DataPropertyName = "BalanceOfPayment"
        Me.BalanceOfPaymentDataGridViewTextBoxColumn.HeaderText = "BalanceOfPayment"
        Me.BalanceOfPaymentDataGridViewTextBoxColumn.Name = "BalanceOfPaymentDataGridViewTextBoxColumn"
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.Group7DataSet1
        '
        'Group7DataSet1
        '
        Me.Group7DataSet1.DataSetName = "DSD"
        Me.Group7DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(380, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 25)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Installation Payments"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(6, 747)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 57)
        Me.Button2.TabIndex = 105
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 25)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "View  Installations By Installation ID"
        '
        'DataTable1TableAdapter1
        '
        Me.DataTable1TableAdapter1.ClearBeforeFill = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "DataTable1"
        Me.BindingSource1.DataSource = Me.Group7DataSet1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtDate)
        Me.GroupBox3.Controls.Add(Me.txtAmtpaid)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtAmntowed)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(1520, 234)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(402, 322)
        Me.GroupBox3.TabIndex = 141
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Additions To Payment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(166, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 25)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "R"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(164, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 25)
        Me.Label11.TabIndex = 142
        Me.Label11.Text = "R"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(154, 233)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(180, 57)
        Me.Button4.TabIndex = 141
        Me.Button4.Text = "Update Payment"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 25)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "Date"
        '
        'txtDate
        '
        Me.txtDate.Enabled = False
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(196, 96)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(165, 34)
        Me.txtDate.TabIndex = 138
        '
        'txtAmtpaid
        '
        Me.txtAmtpaid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmtpaid.Location = New System.Drawing.Point(196, 158)
        Me.txtAmtpaid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmtpaid.Multiline = True
        Me.txtAmtpaid.Name = "txtAmtpaid"
        Me.txtAmtpaid.Size = New System.Drawing.Size(165, 32)
        Me.txtAmtpaid.TabIndex = 140
        Me.ToolTip1.SetToolTip(Me.txtAmtpaid, "Amount That Customer has paid")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 25)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "Amount Paid"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 25)
        Me.Label7.TabIndex = 136
        Me.Label7.Text = "Amount Owed"
        '
        'txtAmntowed
        '
        Me.txtAmntowed.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataTable1BindingSource, "BalanceOfPayment", True))
        Me.txtAmntowed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "BalanceOfPayment", True))
        Me.txtAmntowed.Enabled = False
        Me.txtAmntowed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmntowed.Location = New System.Drawing.Point(196, 39)
        Me.txtAmntowed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAmntowed.Name = "txtAmntowed"
        Me.txtAmntowed.Size = New System.Drawing.Size(165, 34)
        Me.txtAmntowed.TabIndex = 135
        '
        'Install_PaymentTableAdapter1
        '
        Me.Install_PaymentTableAdapter1.ClearBeforeFill = True
        '
        'ViewCurrentInstallations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1924, 910)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ViewCurrentInstallations"
        Me.Text = "Installation Payment Installments"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group7DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtInstallartionID As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataTable1TableAdapter1 As group7DataSetTableAdapters.DataTable1TableAdapter
    Friend WithEvents InstallationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OutsourceAgentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EquipmentCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NavsonicChargesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InstallationStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InstallationPaymentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountPaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BalanceOfPaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents Group7DataSet1 As group7DataSet
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAmntowed As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtAmtpaid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Install_PaymentTableAdapter1 As group7DataSetTableAdapters.Install_PaymentTableAdapter
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
End Class
