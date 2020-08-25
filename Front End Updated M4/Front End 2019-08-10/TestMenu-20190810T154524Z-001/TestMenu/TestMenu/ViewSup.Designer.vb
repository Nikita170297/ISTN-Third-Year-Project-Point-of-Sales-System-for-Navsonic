<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewSup))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelephoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSupplier = New TestMenu.group7DataSet()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtUpdateSu = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtSuAddress = New System.Windows.Forms.TextBox()
        Me.txtSuEmail = New System.Windows.Forms.TextBox()
        Me.txtSuNumber = New System.Windows.Forms.TextBox()
        Me.txtSuName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SupplierTableAdapter1 = New TestMenu.group7DataSetTableAdapters.SupplierTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.TelephoneNumberDataGridViewTextBoxColumn, Me.CompanyEmailDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SupplierBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(714, 504)
        Me.DataGridView1.TabIndex = 0
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'TelephoneNumberDataGridViewTextBoxColumn
        '
        Me.TelephoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Telephone_Number"
        Me.TelephoneNumberDataGridViewTextBoxColumn.HeaderText = "Telephone_Number"
        Me.TelephoneNumberDataGridViewTextBoxColumn.Name = "TelephoneNumberDataGridViewTextBoxColumn"
        '
        'CompanyEmailDataGridViewTextBoxColumn
        '
        Me.CompanyEmailDataGridViewTextBoxColumn.DataPropertyName = "Company_Email"
        Me.CompanyEmailDataGridViewTextBoxColumn.HeaderText = "Company_Email"
        Me.CompanyEmailDataGridViewTextBoxColumn.Name = "CompanyEmailDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.DSSupplier
        '
        'DSSupplier
        '
        Me.DSSupplier.DataSetName = "group7DataSet"
        Me.DSSupplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1246, 500)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(144, 53)
        Me.Button6.TabIndex = 50
        Me.Button6.Text = "Last"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1086, 500)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(144, 53)
        Me.Button5.TabIndex = 49
        Me.Button5.Text = "Previous"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(918, 500)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 53)
        Me.Button4.TabIndex = 48
        Me.Button4.Text = "Next"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(743, 500)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 53)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "First"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(754, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 25)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Supplier ID"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Supplier_ID", True))
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.SupplierBindingSource, "Supplier_ID", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(759, 156)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(206, 31)
        Me.TextBox1.TabIndex = 45
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1222, 391)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(181, 55)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1222, 585)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 55)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtUpdateSu
        '
        Me.txtUpdateSu.BackColor = System.Drawing.Color.Transparent
        Me.txtUpdateSu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtUpdateSu.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateSu.Location = New System.Drawing.Point(1222, 269)
        Me.txtUpdateSu.Name = "txtUpdateSu"
        Me.txtUpdateSu.Size = New System.Drawing.Size(181, 53)
        Me.txtUpdateSu.TabIndex = 42
        Me.txtUpdateSu.Text = "Update Supplier"
        Me.txtUpdateSu.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.SupplierBindingSource, "Status", True))
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Status", True))
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Active", "Not Active"})
        Me.ComboBox1.Location = New System.Drawing.Point(759, 385)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(206, 33)
        Me.ComboBox1.TabIndex = 41
        '
        'txtSuAddress
        '
        Me.txtSuAddress.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.SupplierBindingSource, "Address", True))
        Me.txtSuAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Address", True))
        Me.txtSuAddress.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuAddress.Location = New System.Drawing.Point(1011, 291)
        Me.txtSuAddress.Multiline = True
        Me.txtSuAddress.Name = "txtSuAddress"
        Me.txtSuAddress.Size = New System.Drawing.Size(168, 136)
        Me.txtSuAddress.TabIndex = 40
        '
        'txtSuEmail
        '
        Me.txtSuEmail.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.SupplierBindingSource, "Company_Email", True))
        Me.txtSuEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Company_Email", True))
        Me.txtSuEmail.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuEmail.Location = New System.Drawing.Point(759, 291)
        Me.txtSuEmail.Name = "txtSuEmail"
        Me.txtSuEmail.Size = New System.Drawing.Size(206, 31)
        Me.txtSuEmail.TabIndex = 39
        '
        'txtSuNumber
        '
        Me.txtSuNumber.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.SupplierBindingSource, "Telephone_Number", True))
        Me.txtSuNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Telephone_Number", True))
        Me.txtSuNumber.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuNumber.Location = New System.Drawing.Point(1222, 156)
        Me.txtSuNumber.Name = "txtSuNumber"
        Me.txtSuNumber.Size = New System.Drawing.Size(168, 31)
        Me.txtSuNumber.TabIndex = 38
        '
        'txtSuName
        '
        Me.txtSuName.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.SupplierBindingSource, "Name", True))
        Me.txtSuName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Name", True))
        Me.txtSuName.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuName.Location = New System.Drawing.Point(1011, 156)
        Me.txtSuName.Name = "txtSuName"
        Me.txtSuName.Size = New System.Drawing.Size(168, 31)
        Me.txtSuName.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(770, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 25)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(754, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 25)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Supplier Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1217, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 25)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Telephone Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1006, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1006, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Supplier Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(374, 6)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(245, 37)
        Me.TextBox2.TabIndex = 112
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(97, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(256, 25)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "Search For Supplier By Name"
        '
        'SupplierTableAdapter1
        '
        Me.SupplierTableAdapter1.ClearBeforeFill = True
        '
        'ViewSup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1429, 836)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtUpdateSu)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtSuAddress)
        Me.Controls.Add(Me.txtSuEmail)
        Me.Controls.Add(Me.txtSuNumber)
        Me.Controls.Add(Me.txtSuName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewSup"
        Me.Text = "View Suppliers"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtUpdateSu As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtSuAddress As TextBox
    Friend WithEvents txtSuEmail As TextBox
    Friend WithEvents txtSuNumber As TextBox
    Friend WithEvents txtSuName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents SupplierTableAdapter1 As group7DataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents DSSupplier As group7DataSet
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelephoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanyEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierBindingSource As BindingSource
End Class
