<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewStaff))
        Me.StaffTableAdapter1 = New TestMenu.group7DataSetTableAdapters.StaffTableAdapter()
        Me.BS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group7DataSet1 = New TestMenu.group7DataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullSalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtCommision = New System.Windows.Forms.TextBox()
        Me.txtStPassword = New System.Windows.Forms.TextBox()
        Me.cmbJobt = New System.Windows.Forms.ComboBox()
        Me.txtStTelephone = New System.Windows.Forms.TextBox()
        Me.txtStEmailAddress = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtStName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.BS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group7DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffTableAdapter1
        '
        Me.StaffTableAdapter1.ClearBeforeFill = True
        '
        'BS
        '
        Me.BS.DataMember = "Staff"
        Me.BS.DataSource = Me.Group7DataSet1
        '
        'Group7DataSet1
        '
        Me.Group7DataSet1.DataSetName = "group7DataSet"
        Me.Group7DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.TelephoneDataGridViewTextBoxColumn, Me.EmailAddressDataGridViewTextBoxColumn, Me.JobTitleDataGridViewTextBoxColumn, Me.CommisionDataGridViewTextBoxColumn, Me.FullSalaryDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.CurrentStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BS
        Me.DataGridView1.Location = New System.Drawing.Point(15, 50)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1257, 457)
        Me.DataGridView1.TabIndex = 0
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "StaffID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        Me.StaffIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'TelephoneDataGridViewTextBoxColumn
        '
        Me.TelephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.HeaderText = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.Name = "TelephoneDataGridViewTextBoxColumn"
        '
        'EmailAddressDataGridViewTextBoxColumn
        '
        Me.EmailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress"
        Me.EmailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress"
        Me.EmailAddressDataGridViewTextBoxColumn.Name = "EmailAddressDataGridViewTextBoxColumn"
        '
        'JobTitleDataGridViewTextBoxColumn
        '
        Me.JobTitleDataGridViewTextBoxColumn.DataPropertyName = "Job_Title"
        Me.JobTitleDataGridViewTextBoxColumn.HeaderText = "Job_Title"
        Me.JobTitleDataGridViewTextBoxColumn.Name = "JobTitleDataGridViewTextBoxColumn"
        '
        'CommisionDataGridViewTextBoxColumn
        '
        Me.CommisionDataGridViewTextBoxColumn.DataPropertyName = "Commision"
        Me.CommisionDataGridViewTextBoxColumn.HeaderText = "Commision"
        Me.CommisionDataGridViewTextBoxColumn.Name = "CommisionDataGridViewTextBoxColumn"
        '
        'FullSalaryDataGridViewTextBoxColumn
        '
        Me.FullSalaryDataGridViewTextBoxColumn.DataPropertyName = "Full_Salary"
        Me.FullSalaryDataGridViewTextBoxColumn.HeaderText = "Full_Salary"
        Me.FullSalaryDataGridViewTextBoxColumn.Name = "FullSalaryDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'CurrentStatusDataGridViewTextBoxColumn
        '
        Me.CurrentStatusDataGridViewTextBoxColumn.DataPropertyName = "Current_Status"
        Me.CurrentStatusDataGridViewTextBoxColumn.HeaderText = "Current_Status"
        Me.CurrentStatusDataGridViewTextBoxColumn.Name = "CurrentStatusDataGridViewTextBoxColumn"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1399, 336)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(212, 53)
        Me.Button6.TabIndex = 80
        Me.Button6.Text = "Last"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1399, 229)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(212, 53)
        Me.Button5.TabIndex = 79
        Me.Button5.Text = "Previous"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1399, 130)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(212, 53)
        Me.Button4.TabIndex = 78
        Me.Button4.Text = "Next"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1399, 50)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(212, 53)
        Me.Button3.TabIndex = 77
        Me.Button3.Text = "First"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtStaffID
        '
        Me.txtStaffID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "StaffID", True))
        Me.txtStaffID.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BS, "StaffID", True))
        Me.txtStaffID.Enabled = False
        Me.txtStaffID.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffID.Location = New System.Drawing.Point(23, 546)
        Me.txtStaffID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(168, 31)
        Me.txtStaffID.TabIndex = 76
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 519)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 25)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Staff ID"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1399, 688)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(212, 64)
        Me.btnBack.TabIndex = 74
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1399, 566)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(212, 64)
        Me.btnClear.TabIndex = 73
        Me.btnClear.Text = "Clear "
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(1399, 443)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(212, 64)
        Me.btnUpdate.TabIndex = 72
        Me.btnUpdate.Text = "Update Staff Member"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'cmbStatus
        '
        Me.cmbStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "Current_Status", True))
        Me.cmbStatus.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BS, "Current_Status", True))
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Active", "Not Active"})
        Me.cmbStatus.Location = New System.Drawing.Point(641, 719)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(169, 33)
        Me.cmbStatus.TabIndex = 71
        '
        'txtSalary
        '
        Me.txtSalary.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BS, "Full_Salary", True))
        Me.txtSalary.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "Full_Salary", True))
        Me.txtSalary.Enabled = False
        Me.txtSalary.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(947, 719)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(169, 31)
        Me.txtSalary.TabIndex = 70
        '
        'txtCommision
        '
        Me.txtCommision.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BS, "Commision", True))
        Me.txtCommision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "Commision", True))
        Me.txtCommision.Enabled = False
        Me.txtCommision.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommision.Location = New System.Drawing.Point(24, 719)
        Me.txtCommision.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCommision.Name = "txtCommision"
        Me.txtCommision.Size = New System.Drawing.Size(169, 31)
        Me.txtCommision.TabIndex = 69
        '
        'txtStPassword
        '
        Me.txtStPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "Password", True))
        Me.txtStPassword.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BS, "Password", True))
        Me.txtStPassword.Enabled = False
        Me.txtStPassword.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStPassword.Location = New System.Drawing.Point(641, 633)
        Me.txtStPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStPassword.Name = "txtStPassword"
        Me.txtStPassword.Size = New System.Drawing.Size(217, 31)
        Me.txtStPassword.TabIndex = 68
        '
        'cmbJobt
        '
        Me.cmbJobt.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BS, "Job_Title", True))
        Me.cmbJobt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "Job_Title", True))
        Me.cmbJobt.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJobt.FormattingEnabled = True
        Me.cmbJobt.Items.AddRange(New Object() {"Sales Assistant", "Manager"})
        Me.cmbJobt.Location = New System.Drawing.Point(320, 719)
        Me.cmbJobt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbJobt.Name = "cmbJobt"
        Me.cmbJobt.Size = New System.Drawing.Size(169, 33)
        Me.cmbJobt.TabIndex = 67
        '
        'txtStTelephone
        '
        Me.txtStTelephone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "Telephone", True))
        Me.txtStTelephone.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BS, "Telephone", True))
        Me.txtStTelephone.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStTelephone.Location = New System.Drawing.Point(23, 633)
        Me.txtStTelephone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStTelephone.Name = "txtStTelephone"
        Me.txtStTelephone.Size = New System.Drawing.Size(168, 31)
        Me.txtStTelephone.TabIndex = 66
        '
        'txtStEmailAddress
        '
        Me.txtStEmailAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "EmailAddress", True))
        Me.txtStEmailAddress.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BS, "EmailAddress", True))
        Me.txtStEmailAddress.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStEmailAddress.Location = New System.Drawing.Point(320, 633)
        Me.txtStEmailAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStEmailAddress.Name = "txtStEmailAddress"
        Me.txtStEmailAddress.Size = New System.Drawing.Size(243, 31)
        Me.txtStEmailAddress.TabIndex = 65
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BS, "Address", True))
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "Address", True))
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(947, 546)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(217, 142)
        Me.txtAddress.TabIndex = 64
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "Last_Name", True))
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BS, "Last_Name", True))
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(641, 546)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(187, 31)
        Me.txtLastName.TabIndex = 63
        '
        'txtStName
        '
        Me.txtStName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS, "First_Name", True))
        Me.txtStName.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BS, "First_Name", True))
        Me.txtStName.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStName.Location = New System.Drawing.Point(328, 546)
        Me.txtStName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStName.Name = "txtStName"
        Me.txtStName.Size = New System.Drawing.Size(169, 31)
        Me.txtStName.TabIndex = 62
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(636, 692)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 25)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Status"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(636, 606)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 25)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(957, 692)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 25)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Full Salary"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 692)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 25)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Commision"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(323, 692)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 25)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Job Title"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(323, 606)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 25)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Email Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 606)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 25)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Telephone Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(941, 519)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 25)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(640, 519)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(323, 519)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "First Name"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(565, 6)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(245, 37)
        Me.TextBox2.TabIndex = 114
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(315, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(223, 25)
        Me.Label12.TabIndex = 113
        Me.Label12.Text = "Search For Staff By Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(897, 722)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 25)
        Me.Label13.TabIndex = 133
        Me.Label13.Text = "R"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(-5, 719)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(23, 25)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "R"
        '
        'ViewStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1625, 786)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtStaffID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtCommision)
        Me.Controls.Add(Me.txtStPassword)
        Me.Controls.Add(Me.cmbJobt)
        Me.Controls.Add(Me.txtStTelephone)
        Me.Controls.Add(Me.txtStEmailAddress)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtStName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ViewStaff"
        Me.Text = "View Staff"
        CType(Me.BS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group7DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StaffTableAdapter1 As group7DataSetTableAdapters.StaffTableAdapter
    Friend WithEvents BS As BindingSource
    Friend WithEvents Group7DataSet1 As group7DataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtCommision As TextBox
    Friend WithEvents txtStPassword As TextBox
    Friend WithEvents cmbJobt As ComboBox
    Friend WithEvents txtStTelephone As TextBox
    Friend WithEvents txtStEmailAddress As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtStName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JobTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommisionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullSalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
