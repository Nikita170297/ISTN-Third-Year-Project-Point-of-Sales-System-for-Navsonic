<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRepairPayments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddRepairPayments))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRepairID = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RepairIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairPaymentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceOfPaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WarrantyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group7DataSet1 = New TestMenu.group7DataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtWarranty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtAmtpaid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAmntowed = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataTable3TableAdapter1 = New TestMenu.group7DataSetTableAdapters.DataTable3TableAdapter()
        Me.Repair_PaymentTableAdapter1 = New TestMenu.group7DataSetTableAdapters.Repair_PaymentTableAdapter()
        Me.Product_SaleTableAdapter1 = New TestMenu.group7DataSetTableAdapters.Product_SaleTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group7DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtRepairID)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1191, 441)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Repair Payment Installments"
        '
        'txtRepairID
        '
        Me.txtRepairID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRepairID.Location = New System.Drawing.Point(608, 58)
        Me.txtRepairID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRepairID.Name = "txtRepairID"
        Me.txtRepairID.Size = New System.Drawing.Size(165, 34)
        Me.txtRepairID.TabIndex = 104
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RepairIDDataGridViewTextBoxColumn, Me.SaleIDDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.RepairPriceDataGridViewTextBoxColumn, Me.RepairDescriptionDataGridViewTextBoxColumn, Me.RepairPaymentIDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.AmountPaidDataGridViewTextBoxColumn, Me.BalanceOfPaymentDataGridViewTextBoxColumn, Me.WarrantyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(6, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1179, 261)
        Me.DataGridView1.TabIndex = 100
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
        'RepairPaymentIDDataGridViewTextBoxColumn
        '
        Me.RepairPaymentIDDataGridViewTextBoxColumn.DataPropertyName = "RepairPayment_ID"
        Me.RepairPaymentIDDataGridViewTextBoxColumn.HeaderText = "RepairPayment_ID"
        Me.RepairPaymentIDDataGridViewTextBoxColumn.Name = "RepairPaymentIDDataGridViewTextBoxColumn"
        Me.RepairPaymentIDDataGridViewTextBoxColumn.ReadOnly = True
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
        'WarrantyDataGridViewTextBoxColumn
        '
        Me.WarrantyDataGridViewTextBoxColumn.DataPropertyName = "Warranty"
        Me.WarrantyDataGridViewTextBoxColumn.HeaderText = "Warranty"
        Me.WarrantyDataGridViewTextBoxColumn.Name = "WarrantyDataGridViewTextBoxColumn"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "DataTable3"
        Me.BindingSource1.DataSource = Me.Group7DataSet1
        '
        'Group7DataSet1
        '
        Me.Group7DataSet1.DataSetName = "group7DataSet"
        Me.Group7DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(504, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 25)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Repair Payments"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 368)
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
        Me.Label1.Location = New System.Drawing.Point(332, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 25)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "View  Repairs By Repair ID"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtWarranty)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtDate)
        Me.GroupBox3.Controls.Add(Me.txtAmtpaid)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtAmntowed)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 459)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1200, 169)
        Me.GroupBox3.TabIndex = 142
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Additions To Payment"
        '
        'TxtWarranty
        '
        Me.TxtWarranty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Warranty", True))
        Me.TxtWarranty.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BindingSource1, "Warranty", True))
        Me.TxtWarranty.Enabled = False
        Me.TxtWarranty.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWarranty.Location = New System.Drawing.Point(547, 99)
        Me.TxtWarranty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtWarranty.Name = "TxtWarranty"
        Me.TxtWarranty.Size = New System.Drawing.Size(165, 34)
        Me.TxtWarranty.TabIndex = 143
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(375, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "Warranty"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(832, 45)
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
        Me.txtDate.Location = New System.Drawing.Point(169, 96)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(165, 34)
        Me.txtDate.TabIndex = 138
        '
        'txtAmtpaid
        '
        Me.txtAmtpaid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmtpaid.Location = New System.Drawing.Point(547, 55)
        Me.txtAmtpaid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmtpaid.Multiline = True
        Me.txtAmtpaid.Name = "txtAmtpaid"
        Me.txtAmtpaid.Size = New System.Drawing.Size(165, 32)
        Me.txtAmtpaid.TabIndex = 140
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(375, 51)
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
        Me.txtAmntowed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "BalanceOfPayment", True))
        Me.txtAmntowed.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BindingSource1, "BalanceOfPayment", True))
        Me.txtAmntowed.Enabled = False
        Me.txtAmntowed.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmntowed.Location = New System.Drawing.Point(169, 45)
        Me.txtAmntowed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAmntowed.Name = "txtAmntowed"
        Me.txtAmntowed.Size = New System.Drawing.Size(165, 34)
        Me.txtAmntowed.TabIndex = 135
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1023, 644)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 57)
        Me.Button1.TabIndex = 143
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataTable3TableAdapter1
        '
        Me.DataTable3TableAdapter1.ClearBeforeFill = True
        '
        'Repair_PaymentTableAdapter1
        '
        Me.Repair_PaymentTableAdapter1.ClearBeforeFill = True
        '
        'Product_SaleTableAdapter1
        '
        Me.Product_SaleTableAdapter1.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(517, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 25)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "R"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(145, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 25)
        Me.Label8.TabIndex = 145
        Me.Label8.Text = "R"
        '
        'AddRepairPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1222, 720)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AddRepairPayments"
        Me.Text = "Repair Payment Installments"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group7DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtRepairID As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtAmtpaid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAmntowed As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataTable3TableAdapter1 As group7DataSetTableAdapters.DataTable3TableAdapter
    Friend WithEvents Group7DataSet1 As group7DataSet
    Friend WithEvents RepairIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SaleIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RepairPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RepairDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RepairPaymentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountPaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BalanceOfPaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WarrantyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Repair_PaymentTableAdapter1 As group7DataSetTableAdapters.Repair_PaymentTableAdapter
    Friend WithEvents TxtWarranty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Product_SaleTableAdapter1 As group7DataSetTableAdapters.Product_SaleTableAdapter
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
End Class
