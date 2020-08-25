<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubmitInstallationReq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubmitInstallationReq))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtInstallationID = New System.Windows.Forms.TextBox()
        Me.InstallBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSInstall = New TestMenu.group7DataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbAgent = New System.Windows.Forms.ComboBox()
        Me.OutsourceAgentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSOutsourceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSOutsource = New TestMenu.group7DataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOutFee = New System.Windows.Forms.TextBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbEquipName = New System.Windows.Forms.ComboBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtECost = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEquipName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNavCharges = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.OutsourceAgentTableAdapter1 = New TestMenu.group7DataSetTableAdapters.OutsourceAgentTableAdapter()
        Me.Details_InstallationTableAdapter1 = New TestMenu.group7DataSetTableAdapters.Details_InstallationTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.InstallationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutsourceAgentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EquipmentCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NavsonicChargesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstallationStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtequipCOst = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.InstallBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSInstall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutsourceAgentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSOutsourceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSOutsource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 25)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Installation ID"
        '
        'txtInstallationID
        '
        Me.txtInstallationID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InstallBS, "Installation_ID", True))
        Me.txtInstallationID.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.InstallBS, "Installation_ID", True))
        Me.txtInstallationID.Enabled = False
        Me.txtInstallationID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstallationID.Location = New System.Drawing.Point(245, 9)
        Me.txtInstallationID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtInstallationID.Name = "txtInstallationID"
        Me.txtInstallationID.Size = New System.Drawing.Size(165, 34)
        Me.txtInstallationID.TabIndex = 95
        '
        'InstallBS
        '
        Me.InstallBS.DataMember = "Details_Installation"
        Me.InstallBS.DataSource = Me.DSInstall
        '
        'DSInstall
        '
        Me.DSInstall.DataSetName = "group7DataSet"
        Me.DSInstall.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 25)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Outsource Agent"
        '
        'cmbAgent
        '
        Me.cmbAgent.DataSource = Me.OutsourceAgentBindingSource
        Me.cmbAgent.DisplayMember = "Name"
        Me.cmbAgent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgent.FormattingEnabled = True
        Me.cmbAgent.Location = New System.Drawing.Point(245, 139)
        Me.cmbAgent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbAgent.Name = "cmbAgent"
        Me.cmbAgent.Size = New System.Drawing.Size(165, 36)
        Me.cmbAgent.TabIndex = 100
        Me.ToolTip1.SetToolTip(Me.cmbAgent, "Choose an outsource agent")
        Me.cmbAgent.ValueMember = "Name"
        '
        'OutsourceAgentBindingSource
        '
        Me.OutsourceAgentBindingSource.DataMember = "OutsourceAgent"
        Me.OutsourceAgentBindingSource.DataSource = Me.DSOutsourceBindingSource
        '
        'DSOutsourceBindingSource
        '
        Me.DSOutsourceBindingSource.DataSource = Me.DSOutsource
        Me.DSOutsourceBindingSource.Position = 0
        '
        'DSOutsource
        '
        Me.DSOutsource.DataSetName = "group7DataSet"
        Me.DSOutsource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 25)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Equipment Cost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 25)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Total Cost"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 25)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "OutSource Agent Fee"
        '
        'txtOutFee
        '
        Me.txtOutFee.Enabled = False
        Me.txtOutFee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutFee.Location = New System.Drawing.Point(245, 251)
        Me.txtOutFee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOutFee.Name = "txtOutFee"
        Me.txtOutFee.Size = New System.Drawing.Size(165, 34)
        Me.txtOutFee.TabIndex = 105
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Enabled = False
        Me.txtTotalCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCost.Location = New System.Drawing.Point(245, 345)
        Me.txtTotalCost.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(165, 34)
        Me.txtTotalCost.TabIndex = 106
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbEquipName)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.txtECost)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtEquipName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtArea)
        Me.GroupBox1.Location = New System.Drawing.Point(627, 27)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(806, 400)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Equipment Quote"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(114, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 25)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "R"
        '
        'cmbEquipName
        '
        Me.cmbEquipName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEquipName.FormattingEnabled = True
        Me.cmbEquipName.Items.AddRange(New Object() {"Wiring", "Capacitors", "Subwoofer Cable", "Power Cable", "Speaker Cable", "RCA Cable", "Processors", "Crossovers", "Line Drivers", "Amplifiers", "Head Units(Single Fit)", "Head Units(Double Fit)", "Head Units(Factory Fit)", "Mid Bass Drivers", "Split Kits", "Fuse Holders", "Various Terminals", "Line Out Converters", "Vehicle Specific Radio Trims", "Wiring Kits", "Sound Deadening", "Sleeving", "Subwoofer Boxes", "Screens", "Reverse Cameras", "Batteries"})
        Me.cmbEquipName.Location = New System.Drawing.Point(120, 33)
        Me.cmbEquipName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbEquipName.Name = "cmbEquipName"
        Me.cmbEquipName.Size = New System.Drawing.Size(278, 36)
        Me.cmbEquipName.TabIndex = 113
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(416, 19)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(213, 57)
        Me.Button8.TabIndex = 112
        Me.Button8.Text = "Other "
        Me.ToolTip1.SetToolTip(Me.Button8, "Click for other equipment not found in list.")
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(416, 91)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(213, 57)
        Me.Button4.TabIndex = 103
        Me.Button4.Text = "Add Equipment"
        Me.ToolTip1.SetToolTip(Me.Button4, "Add Equipment name and cost")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'txtECost
        '
        Me.txtECost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtECost.Location = New System.Drawing.Point(143, 89)
        Me.txtECost.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtECost.Name = "txtECost"
        Me.txtECost.Size = New System.Drawing.Size(255, 34)
        Me.txtECost.TabIndex = 102
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 25)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Equip Cost"
        '
        'txtEquipName
        '
        Me.txtEquipName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEquipName.Location = New System.Drawing.Point(635, 33)
        Me.txtEquipName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEquipName.Name = "txtEquipName"
        Me.txtEquipName.Size = New System.Drawing.Size(165, 34)
        Me.txtEquipName.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 25)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Equip Name"
        '
        'txtArea
        '
        Me.txtArea.Enabled = False
        Me.txtArea.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(77, 170)
        Me.txtArea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtArea.Multiline = True
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(456, 208)
        Me.txtArea.TabIndex = 96
        '
        'txtCustID
        '
        Me.txtCustID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustID.Location = New System.Drawing.Point(245, 72)
        Me.txtCustID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.ReadOnly = True
        Me.txtCustID.Size = New System.Drawing.Size(165, 34)
        Me.txtCustID.TabIndex = 108
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(35, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 25)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Navsonic Charges"
        '
        'txtNavCharges
        '
        Me.txtNavCharges.Enabled = False
        Me.txtNavCharges.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNavCharges.Location = New System.Drawing.Point(245, 300)
        Me.txtNavCharges.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNavCharges.Name = "txtNavCharges"
        Me.txtNavCharges.Size = New System.Drawing.Size(165, 34)
        Me.txtNavCharges.TabIndex = 110
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1488, 370)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(213, 57)
        Me.Button1.TabIndex = 111
        Me.Button1.Text = "Log Installation"
        Me.ToolTip1.SetToolTip(Me.Button1, "Submit installation request")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 388)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 25)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Status"
        '
        'cmbStatus
        '
        Me.cmbStatus.Enabled = False
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Complete", "Not Complete"})
        Me.cmbStatus.Location = New System.Drawing.Point(245, 388)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(165, 36)
        Me.cmbStatus.TabIndex = 113
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1488, 897)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 57)
        Me.Button2.TabIndex = 114
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(427, 66)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(180, 57)
        Me.Button5.TabIndex = 116
        Me.Button5.Text = "View Customer"
        Me.ToolTip1.SetToolTip(Me.Button5, "Find Customer")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'OutsourceAgentTableAdapter1
        '
        Me.OutsourceAgentTableAdapter1.ClearBeforeFill = True
        '
        'Details_InstallationTableAdapter1
        '
        Me.Details_InstallationTableAdapter1.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 445)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(916, 412)
        Me.GroupBox2.TabIndex = 118
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Updated Installation"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InstallationIDDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.OutsourceAgentIDDataGridViewTextBoxColumn, Me.EquipmentCostDataGridViewTextBoxColumn, Me.NavsonicChargesDataGridViewTextBoxColumn, Me.TotalCostDataGridViewTextBoxColumn, Me.InstallationStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InstallBS
        Me.DataGridView1.Location = New System.Drawing.Point(6, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(895, 375)
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
        'txtequipCOst
        '
        Me.txtequipCOst.Enabled = False
        Me.txtequipCOst.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtequipCOst.Location = New System.Drawing.Point(245, 197)
        Me.txtequipCOst.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtequipCOst.Name = "txtequipCOst"
        Me.txtequipCOst.Size = New System.Drawing.Size(165, 34)
        Me.txtequipCOst.TabIndex = 119
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(974, 461)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(694, 372)
        Me.PictureBox1.TabIndex = 120
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(216, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 25)
        Me.Label12.TabIndex = 133
        Me.Label12.Text = "R"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(216, 257)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 25)
        Me.Label13.TabIndex = 134
        Me.Label13.Text = "R"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(216, 306)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(23, 25)
        Me.Label14.TabIndex = 135
        Me.Label14.Text = "R"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(216, 351)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 25)
        Me.Label15.TabIndex = 136
        Me.Label15.Text = "R"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(691, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 20)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "*Required Field"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(292, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 20)
        Me.Label17.TabIndex = 138
        Me.Label17.Text = "*Required Field"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(292, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 20)
        Me.Label18.TabIndex = 139
        Me.Label18.Text = "*Required Field"
        '
        'SubmitInstallationReq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1924, 945)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtequipCOst)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNavCharges)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.txtOutFee)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbAgent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtInstallationID)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "SubmitInstallationReq"
        Me.Text = "Installation"
        CType(Me.InstallBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSInstall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutsourceAgentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSOutsourceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSOutsource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtInstallationID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbAgent As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtOutFee As TextBox
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtECost As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEquipName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtArea As TextBox
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNavCharges As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents OutsourceAgentTableAdapter1 As group7DataSetTableAdapters.OutsourceAgentTableAdapter
    Friend WithEvents DSOutsource As group7DataSet
    Friend WithEvents OutsourceAgentBindingSource As BindingSource
    Friend WithEvents DSOutsourceBindingSource As BindingSource
    Friend WithEvents Details_InstallationTableAdapter1 As group7DataSetTableAdapters.Details_InstallationTableAdapter
    Friend WithEvents DSInstall As group7DataSet
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents InstallationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OutsourceAgentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EquipmentCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NavsonicChargesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InstallationStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InstallBS As BindingSource
    Friend WithEvents txtequipCOst As TextBox
    Friend WithEvents Button8 As Button
    Friend WithEvents cmbEquipName As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
