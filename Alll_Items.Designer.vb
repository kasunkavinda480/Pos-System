<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alll_Items
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
        Dim Item_CodeLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Dim WholesaleLabel As System.Windows.Forms.Label
        Dim RetailLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.DbsdatabaseDataSet = New WindowsApp1.dbsdatabaseDataSet()
        Me.AllitemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllitemsTableAdapter = New WindowsApp1.dbsdatabaseDataSetTableAdapters.allitemsTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.dbsdatabaseDataSetTableAdapters.TableAdapterManager()
        Me.AllitemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.BrandTextBox = New System.Windows.Forms.TextBox()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.WholesaleTextBox = New System.Windows.Forms.TextBox()
        Me.RetailTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrandTableAdapter = New WindowsApp1.dbsdatabaseDataSetTableAdapters.brandTableAdapter()
        Me.BrandDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Item_CodeLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        WholesaleLabel = New System.Windows.Forms.Label()
        RetailLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DbsdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllitemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllitemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Item_CodeLabel
        '
        Item_CodeLabel.AutoSize = True
        Item_CodeLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Item_CodeLabel.Location = New System.Drawing.Point(8, 9)
        Item_CodeLabel.Name = "Item_CodeLabel"
        Item_CodeLabel.Size = New System.Drawing.Size(98, 20)
        Item_CodeLabel.TabIndex = 2
        Item_CodeLabel.Text = "Item Code:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(168, 9)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(110, 20)
        DescriptionLabel.TabIndex = 4
        DescriptionLabel.Text = "Description:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BrandLabel.Location = New System.Drawing.Point(776, 9)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(64, 20)
        BrandLabel.TabIndex = 6
        BrandLabel.Text = "Brand:"
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CostLabel.Location = New System.Drawing.Point(11, 68)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(52, 20)
        CostLabel.TabIndex = 8
        CostLabel.Text = "Cost:"
        '
        'WholesaleLabel
        '
        WholesaleLabel.AutoSize = True
        WholesaleLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WholesaleLabel.Location = New System.Drawing.Point(314, 68)
        WholesaleLabel.Name = "WholesaleLabel"
        WholesaleLabel.Size = New System.Drawing.Size(99, 20)
        WholesaleLabel.TabIndex = 10
        WholesaleLabel.Text = "Wholesale:"
        '
        'RetailLabel
        '
        RetailLabel.AutoSize = True
        RetailLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RetailLabel.Location = New System.Drawing.Point(668, 68)
        RetailLabel.Name = "RetailLabel"
        RetailLabel.Size = New System.Drawing.Size(62, 20)
        RetailLabel.TabIndex = 12
        RetailLabel.Text = "Retail:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(131, 100)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 6
        NameLabel.Text = "Name:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(419, 16)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(105, 20)
        Label4.TabIndex = 7
        Label4.Text = "Total Items:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(193, 16)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(110, 20)
        Label2.TabIndex = 5
        Label2.Text = "Description:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(4, 16)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(98, 20)
        Label1.TabIndex = 3
        Label1.Text = "Item Code:"
        '
        'DbsdatabaseDataSet
        '
        Me.DbsdatabaseDataSet.DataSetName = "dbsdatabaseDataSet"
        Me.DbsdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AllitemsBindingSource
        '
        Me.AllitemsBindingSource.DataMember = "allitems"
        Me.AllitemsBindingSource.DataSource = Me.DbsdatabaseDataSet
        '
        'AllitemsTableAdapter
        '
        Me.AllitemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.allitemsTableAdapter = Me.AllitemsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.banksTableAdapter = Nothing
        Me.TableAdapterManager.brandTableAdapter = Nothing
        Me.TableAdapterManager.chaque_issueTableAdapter = Nothing
        Me.TableAdapterManager.chaquereceivedTableAdapter = Nothing
        Me.TableAdapterManager.customer_creditTableAdapter = Nothing
        Me.TableAdapterManager.customer_paymentsTableAdapter = Nothing
        Me.TableAdapterManager.customerTableAdapter = Nothing
        Me.TableAdapterManager.invno2TableAdapter = Nothing
        Me.TableAdapterManager.invnoTableAdapter = Nothing
        Me.TableAdapterManager.purchasingTableAdapter = Nothing
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
        'AllitemsDataGridView
        '
        Me.AllitemsDataGridView.AutoGenerateColumns = False
        Me.AllitemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AllitemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.AllitemsDataGridView.DataSource = Me.AllitemsBindingSource
        Me.AllitemsDataGridView.Location = New System.Drawing.Point(12, 98)
        Me.AllitemsDataGridView.Name = "AllitemsDataGridView"
        Me.AllitemsDataGridView.Size = New System.Drawing.Size(969, 425)
        Me.AllitemsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Item_Code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item_Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Brand"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Brand"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cost"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cost"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Wholesale"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Wholesale"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Retail"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Retail"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Stock"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Avcost"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Avcost"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Item_CodeTextBox
        '
        Me.Item_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllitemsBindingSource, "Item_Code", True))
        Me.Item_CodeTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item_CodeTextBox.Location = New System.Drawing.Point(12, 32)
        Me.Item_CodeTextBox.Name = "Item_CodeTextBox"
        Me.Item_CodeTextBox.Size = New System.Drawing.Size(154, 27)
        Me.Item_CodeTextBox.TabIndex = 3
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllitemsBindingSource, "Description", True))
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(172, 32)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(602, 27)
        Me.DescriptionTextBox.TabIndex = 5
        '
        'BrandTextBox
        '
        Me.BrandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllitemsBindingSource, "Brand", True))
        Me.BrandTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrandTextBox.Location = New System.Drawing.Point(780, 32)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.Size = New System.Drawing.Size(201, 27)
        Me.BrandTextBox.TabIndex = 7
        '
        'CostTextBox
        '
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllitemsBindingSource, "Cost", True))
        Me.CostTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostTextBox.Location = New System.Drawing.Point(80, 65)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(208, 27)
        Me.CostTextBox.TabIndex = 9
        '
        'WholesaleTextBox
        '
        Me.WholesaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllitemsBindingSource, "Wholesale", True))
        Me.WholesaleTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WholesaleTextBox.Location = New System.Drawing.Point(419, 65)
        Me.WholesaleTextBox.Name = "WholesaleTextBox"
        Me.WholesaleTextBox.Size = New System.Drawing.Size(229, 27)
        Me.WholesaleTextBox.TabIndex = 11
        '
        'RetailTextBox
        '
        Me.RetailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AllitemsBindingSource, "Retail", True))
        Me.RetailTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetailTextBox.Location = New System.Drawing.Point(737, 65)
        Me.RetailTextBox.Name = "RetailTextBox"
        Me.RetailTextBox.Size = New System.Drawing.Size(244, 27)
        Me.RetailTextBox.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(NameLabel)
        Me.GroupBox2.Controls.Add(Me.NameTextBox)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(626, 529)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 81)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(175, 97)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 7
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(244, 48)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 27)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Print"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(146, 48)
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
        Me.Button3.Size = New System.Drawing.Size(134, 27)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(217, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 27)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(107, 16)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(104, 27)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Add New"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(6, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox3.Size = New System.Drawing.Size(95, 27)
        Me.TextBox3.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 529)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 81)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(535, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 23)
        Me.Label3.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(194, 42)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(408, 27)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(4, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 27)
        Me.TextBox1.TabIndex = 0
        '
        'BrandBindingSource
        '
        Me.BrandBindingSource.DataMember = "brand"
        Me.BrandBindingSource.DataSource = Me.DbsdatabaseDataSet
        '
        'BrandTableAdapter
        '
        Me.BrandTableAdapter.ClearBeforeFill = True
        '
        'BrandDataGridView
        '
        Me.BrandDataGridView.AutoGenerateColumns = False
        Me.BrandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BrandDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11})
        Me.BrandDataGridView.DataSource = Me.BrandBindingSource
        Me.BrandDataGridView.Location = New System.Drawing.Point(780, 65)
        Me.BrandDataGridView.Name = "BrandDataGridView"
        Me.BrandDataGridView.Size = New System.Drawing.Size(194, 150)
        Me.BrandDataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 130
        '
        'Alll_Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(989, 619)
        Me.Controls.Add(Me.BrandDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Item_CodeLabel)
        Me.Controls.Add(Me.Item_CodeTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(BrandLabel)
        Me.Controls.Add(Me.BrandTextBox)
        Me.Controls.Add(CostLabel)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(WholesaleLabel)
        Me.Controls.Add(Me.WholesaleTextBox)
        Me.Controls.Add(RetailLabel)
        Me.Controls.Add(Me.RetailTextBox)
        Me.Controls.Add(Me.AllitemsDataGridView)
        Me.Name = "Alll_Items"
        Me.Text = "Alll_Items"
        CType(Me.DbsdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllitemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllitemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbsdatabaseDataSet As dbsdatabaseDataSet
    Friend WithEvents AllitemsBindingSource As BindingSource
    Friend WithEvents AllitemsTableAdapter As dbsdatabaseDataSetTableAdapters.allitemsTableAdapter
    Friend WithEvents TableAdapterManager As dbsdatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AllitemsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Item_CodeTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents BrandTextBox As TextBox
    Friend WithEvents CostTextBox As TextBox
    Friend WithEvents WholesaleTextBox As TextBox
    Friend WithEvents RetailTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BrandBindingSource As BindingSource
    Friend WithEvents BrandTableAdapter As dbsdatabaseDataSetTableAdapters.brandTableAdapter
    Friend WithEvents BrandDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
End Class
