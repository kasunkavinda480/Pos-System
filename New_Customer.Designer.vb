<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Customer
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim NoLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim Tel_NoLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim RegisterDateLabel As System.Windows.Forms.Label
        Dim RefNameLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.NoTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Tel_NoTextBox = New System.Windows.Forms.TextBox()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.STypeTextBox1 = New System.Windows.Forms.TextBox()
        Me.RegisterDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RefNameTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Ref_detailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ref_detailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbsdatabaseDataSet = New WindowsApp1.dbsdatabaseDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerTableAdapter = New WindowsApp1.dbsdatabaseDataSetTableAdapters.customerTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.dbsdatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Ref_detailsTableAdapter = New WindowsApp1.dbsdatabaseDataSetTableAdapters.ref_detailsTableAdapter()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        NoLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        Tel_NoLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        RegisterDateLabel = New System.Windows.Forms.Label()
        RefNameLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Ref_detailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ref_detailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Yellow
        Label2.Location = New System.Drawing.Point(526, 525)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(47, 20)
        Label2.TabIndex = 29
        Label2.Text = "City:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Yellow
        Label1.Location = New System.Drawing.Point(13, 527)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(62, 20)
        Label1.TabIndex = 28
        Label1.Text = "Name:"
        '
        'NoLabel
        '
        NoLabel.AutoSize = True
        NoLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoLabel.Location = New System.Drawing.Point(6, 15)
        NoLabel.Name = "NoLabel"
        NoLabel.Size = New System.Drawing.Size(37, 20)
        NoLabel.TabIndex = 30
        NoLabel.Text = "No:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(127, 15)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(62, 20)
        NameLabel.TabIndex = 32
        NameLabel.Text = "Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(6, 48)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(83, 20)
        AddressLabel.TabIndex = 34
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.Location = New System.Drawing.Point(775, 15)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(47, 20)
        CityLabel.TabIndex = 36
        CityLabel.Text = "City:"
        '
        'Tel_NoLabel
        '
        Tel_NoLabel.AutoSize = True
        Tel_NoLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tel_NoLabel.Location = New System.Drawing.Point(6, 81)
        Tel_NoLabel.Name = "Tel_NoLabel"
        Tel_NoLabel.Size = New System.Drawing.Size(67, 20)
        Tel_NoLabel.TabIndex = 38
        Tel_NoLabel.Text = "Tel No:"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FaxLabel.Location = New System.Drawing.Point(292, 81)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(43, 20)
        FaxLabel.TabIndex = 40
        FaxLabel.Text = "Fax:"
        '
        'RegisterDateLabel
        '
        RegisterDateLabel.AutoSize = True
        RegisterDateLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RegisterDateLabel.Location = New System.Drawing.Point(991, 52)
        RegisterDateLabel.Name = "RegisterDateLabel"
        RegisterDateLabel.Size = New System.Drawing.Size(127, 20)
        RegisterDateLabel.TabIndex = 44
        RegisterDateLabel.Text = "Register Date:"
        '
        'RefNameLabel
        '
        RefNameLabel.AutoSize = True
        RefNameLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RefNameLabel.Location = New System.Drawing.Point(581, 81)
        RefNameLabel.Name = "RefNameLabel"
        RefNameLabel.Size = New System.Drawing.Size(94, 20)
        RefNameLabel.TabIndex = 46
        RefNameLabel.Text = "Ref Name:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(771, 48)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(55, 20)
        Label3.TabIndex = 48
        Label3.Text = "Type:"
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AllowUserToAddRows = False
        Me.CustomerDataGridView.AutoGenerateColumns = False
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.CustomerDataGridView.DataSource = Me.CustomerBindingSource
        Me.CustomerDataGridView.Location = New System.Drawing.Point(10, 111)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.Size = New System.Drawing.Size(1108, 385)
        Me.CustomerDataGridView.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(530, 550)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(233, 27)
        Me.TextBox2.TabIndex = 27
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 550)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(512, 27)
        Me.TextBox1.TabIndex = 26
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.RegisterDateDateTimePicker)
        Me.GroupBox2.Location = New System.Drawing.Point(769, 502)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 84)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(214, 48)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 27)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Print"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(116, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 27)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(6, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 27)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(187, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 27)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(77, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(6, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox3.Size = New System.Drawing.Size(63, 27)
        Me.TextBox3.TabIndex = 1
        '
        'NoTextBox
        '
        Me.NoTextBox.BackColor = System.Drawing.Color.Moccasin
        Me.NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "No", True))
        Me.NoTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoTextBox.Location = New System.Drawing.Point(49, 12)
        Me.NoTextBox.Name = "NoTextBox"
        Me.NoTextBox.Size = New System.Drawing.Size(73, 27)
        Me.NoTextBox.TabIndex = 31
        '
        'NameTextBox
        '
        Me.NameTextBox.BackColor = System.Drawing.Color.Moccasin
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(208, 12)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(555, 27)
        Me.NameTextBox.TabIndex = 33
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.Color.Moccasin
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(99, 45)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(664, 27)
        Me.AddressTextBox.TabIndex = 35
        '
        'CityTextBox
        '
        Me.CityTextBox.BackColor = System.Drawing.Color.Moccasin
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "City", True))
        Me.CityTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.Location = New System.Drawing.Point(856, 12)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(262, 27)
        Me.CityTextBox.TabIndex = 37
        '
        'Tel_NoTextBox
        '
        Me.Tel_NoTextBox.BackColor = System.Drawing.Color.Moccasin
        Me.Tel_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Tel_No", True))
        Me.Tel_NoTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tel_NoTextBox.Location = New System.Drawing.Point(89, 78)
        Me.Tel_NoTextBox.Name = "Tel_NoTextBox"
        Me.Tel_NoTextBox.Size = New System.Drawing.Size(200, 27)
        Me.Tel_NoTextBox.TabIndex = 39
        '
        'FaxTextBox
        '
        Me.FaxTextBox.BackColor = System.Drawing.Color.Moccasin
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Fax", True))
        Me.FaxTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FaxTextBox.Location = New System.Drawing.Point(341, 78)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(232, 27)
        Me.FaxTextBox.TabIndex = 41
        '
        'STypeTextBox1
        '
        Me.STypeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "SType", True))
        Me.STypeTextBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STypeTextBox1.Location = New System.Drawing.Point(662, 518)
        Me.STypeTextBox1.Name = "STypeTextBox1"
        Me.STypeTextBox1.Size = New System.Drawing.Size(101, 20)
        Me.STypeTextBox1.TabIndex = 43
        '
        'RegisterDateDateTimePicker
        '
        Me.RegisterDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerBindingSource, "RegisterDate", True))
        Me.RegisterDateDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterDateDateTimePicker.Location = New System.Drawing.Point(53, 87)
        Me.RegisterDateDateTimePicker.Name = "RegisterDateDateTimePicker"
        Me.RegisterDateDateTimePicker.Size = New System.Drawing.Size(231, 27)
        Me.RegisterDateDateTimePicker.TabIndex = 45
        '
        'RefNameTextBox
        '
        Me.RefNameTextBox.BackColor = System.Drawing.Color.Moccasin
        Me.RefNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "RefName", True))
        Me.RefNameTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefNameTextBox.Location = New System.Drawing.Point(681, 78)
        Me.RefNameTextBox.Name = "RefNameTextBox"
        Me.RefNameTextBox.Size = New System.Drawing.Size(200, 27)
        Me.RefNameTextBox.TabIndex = 47
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ComboBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Wholesale", "Retail"})
        Me.ComboBox1.Location = New System.Drawing.Point(822, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(163, 28)
        Me.ComboBox1.TabIndex = 49
        Me.ComboBox1.Text = "Retail"
        '
        'Ref_detailsDataGridView
        '
        Me.Ref_detailsDataGridView.AllowUserToAddRows = False
        Me.Ref_detailsDataGridView.AllowUserToDeleteRows = False
        Me.Ref_detailsDataGridView.AutoGenerateColumns = False
        Me.Ref_detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Ref_detailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11})
        Me.Ref_detailsDataGridView.DataSource = Me.Ref_detailsBindingSource
        Me.Ref_detailsDataGridView.Location = New System.Drawing.Point(681, 108)
        Me.Ref_detailsDataGridView.Name = "Ref_detailsDataGridView"
        Me.Ref_detailsDataGridView.ReadOnly = True
        Me.Ref_detailsDataGridView.Size = New System.Drawing.Size(200, 187)
        Me.Ref_detailsDataGridView.TabIndex = 49
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(889, 79)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(228, 27)
        Me.DateTimePicker1.TabIndex = 50
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Ref_Name"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Ref_Name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 140
        '
        'Ref_detailsBindingSource
        '
        Me.Ref_detailsBindingSource.DataMember = "ref_details"
        Me.Ref_detailsBindingSource.DataSource = Me.DbsdatabaseDataSet
        '
        'DbsdatabaseDataSet
        '
        Me.DbsdatabaseDataSet.DataSetName = "dbsdatabaseDataSet"
        Me.DbsdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.DbsdatabaseDataSet
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn4.HeaderText = "City"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Tel_No"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tel_No"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Fax"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fax"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SType"
        Me.DataGridViewTextBoxColumn7.HeaderText = "SType"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "RegisterDate"
        Me.DataGridViewTextBoxColumn8.HeaderText = "RegisterDate"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "RefName"
        Me.DataGridViewTextBoxColumn9.HeaderText = "RefName"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.allitemsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.banksTableAdapter = Nothing
        Me.TableAdapterManager.brandTableAdapter = Nothing
        Me.TableAdapterManager.chaque_issueTableAdapter = Nothing
        Me.TableAdapterManager.chaquereceivedTableAdapter = Nothing
        Me.TableAdapterManager.customer_creditTableAdapter = Nothing
        Me.TableAdapterManager.customer_paymentsTableAdapter = Nothing
        Me.TableAdapterManager.customerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.invno2TableAdapter = Nothing
        Me.TableAdapterManager.invnoTableAdapter = Nothing
        Me.TableAdapterManager.purchasingTableAdapter = Nothing
        Me.TableAdapterManager.ref_detailsTableAdapter = Nothing
        Me.TableAdapterManager.sale_idTableAdapter = Nothing
        Me.TableAdapterManager.sellingTableAdapter = Nothing
        Me.TableAdapterManager.supplicer_creditTableAdapter = Nothing
        Me.TableAdapterManager.supplicer_paymentTableAdapter = Nothing
        Me.TableAdapterManager.suppliersTableAdapter = Nothing
        Me.TableAdapterManager.tem_sale1TableAdapter = Nothing
        Me.TableAdapterManager.tem_sale2TableAdapter = Nothing
        Me.TableAdapterManager.tem_sale3TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.dbsdatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Ref_detailsTableAdapter
        '
        Me.Ref_detailsTableAdapter.ClearBeforeFill = True
        '
        'New_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(1122, 591)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Ref_detailsDataGridView)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Label3)
        Me.Controls.Add(NoLabel)
        Me.Controls.Add(Me.NoTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Tel_NoLabel)
        Me.Controls.Add(Me.Tel_NoTextBox)
        Me.Controls.Add(FaxLabel)
        Me.Controls.Add(Me.FaxTextBox)
        Me.Controls.Add(Me.STypeTextBox1)
        Me.Controls.Add(RegisterDateLabel)
        Me.Controls.Add(RefNameLabel)
        Me.Controls.Add(Me.RefNameTextBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CustomerDataGridView)
        Me.Name = "New_Customer"
        Me.Text = "New_Customer"
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Ref_detailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ref_detailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbsdatabaseDataSet As dbsdatabaseDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As dbsdatabaseDataSetTableAdapters.customerTableAdapter
    Friend WithEvents TableAdapterManager As dbsdatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerDataGridView As DataGridView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents NoTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents Tel_NoTextBox As TextBox
    Friend WithEvents FaxTextBox As TextBox
    Friend WithEvents STypeTextBox1 As TextBox
    Friend WithEvents RegisterDateDateTimePicker As DateTimePicker
    Friend WithEvents RefNameTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Ref_detailsBindingSource As BindingSource
    Friend WithEvents Ref_detailsTableAdapter As dbsdatabaseDataSetTableAdapters.ref_detailsTableAdapter
    Friend WithEvents Ref_detailsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
