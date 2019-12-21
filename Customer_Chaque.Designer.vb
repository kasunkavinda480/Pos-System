<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Chaque
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
        Dim Chq_NoLabel As System.Windows.Forms.Label
        Dim C_NameLabel As System.Windows.Forms.Label
        Dim BankLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim Issue_dateLabel As System.Windows.Forms.Label
        Dim Close_dateLabel As System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chq_NoTextBox = New System.Windows.Forms.TextBox()
        Me.ChaquereceivedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbsdatabaseDataSet = New WindowsApp1.dbsdatabaseDataSet()
        Me.C_NameTextBox = New System.Windows.Forms.TextBox()
        Me.BankTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Issue_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Close_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ChaquereceivedTableAdapter = New WindowsApp1.dbsdatabaseDataSetTableAdapters.chaquereceivedTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.dbsdatabaseDataSetTableAdapters.TableAdapterManager()
        Me.CustomerTableAdapter = New WindowsApp1.dbsdatabaseDataSetTableAdapters.customerTableAdapter()
        Me.ChaquereceivedDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Chq_NoLabel = New System.Windows.Forms.Label()
        C_NameLabel = New System.Windows.Forms.Label()
        BankLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Issue_dateLabel = New System.Windows.Forms.Label()
        Close_dateLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ChaquereceivedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbsdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChaquereceivedDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chq_NoLabel
        '
        Chq_NoLabel.AutoSize = True
        Chq_NoLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Chq_NoLabel.Location = New System.Drawing.Point(11, 19)
        Chq_NoLabel.Name = "Chq_NoLabel"
        Chq_NoLabel.Size = New System.Drawing.Size(75, 20)
        Chq_NoLabel.TabIndex = 0
        Chq_NoLabel.Text = "Chq No:"
        '
        'C_NameLabel
        '
        C_NameLabel.AutoSize = True
        C_NameLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C_NameLabel.Location = New System.Drawing.Point(11, 52)
        C_NameLabel.Name = "C_NameLabel"
        C_NameLabel.Size = New System.Drawing.Size(79, 20)
        C_NameLabel.TabIndex = 2
        C_NameLabel.Text = "C Name:"
        '
        'BankLabel
        '
        BankLabel.AutoSize = True
        BankLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BankLabel.Location = New System.Drawing.Point(11, 85)
        BankLabel.Name = "BankLabel"
        BankLabel.Size = New System.Drawing.Size(56, 20)
        BankLabel.TabIndex = 4
        BankLabel.Text = "Bank:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AmountLabel.Location = New System.Drawing.Point(11, 123)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(77, 20)
        AmountLabel.TabIndex = 6
        AmountLabel.Text = "Amount:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.Location = New System.Drawing.Point(20, 308)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(66, 20)
        StatusLabel.TabIndex = 8
        StatusLabel.Text = "Status:"
        '
        'Issue_dateLabel
        '
        Issue_dateLabel.AutoSize = True
        Issue_dateLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Issue_dateLabel.Location = New System.Drawing.Point(11, 153)
        Issue_dateLabel.Name = "Issue_dateLabel"
        Issue_dateLabel.Size = New System.Drawing.Size(98, 20)
        Issue_dateLabel.TabIndex = 10
        Issue_dateLabel.Text = "Issue date:"
        '
        'Close_dateLabel
        '
        Close_dateLabel.AutoSize = True
        Close_dateLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Close_dateLabel.Location = New System.Drawing.Point(11, 192)
        Close_dateLabel.Name = "Close_dateLabel"
        Close_dateLabel.Size = New System.Drawing.Size(102, 20)
        Close_dateLabel.TabIndex = 12
        Close_dateLabel.Text = "Close date:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(529, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(414, 296)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seach"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Cyan
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(169, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 36)
        Me.Label7.TabIndex = 16
        Me.Label7.Tag = ""
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Yellow
        Me.Button8.Location = New System.Drawing.Point(351, 125)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(52, 45)
        Me.Button8.TabIndex = 15
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Chartreuse
        Me.Button7.Location = New System.Drawing.Point(352, 74)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(52, 45)
        Me.Button7.TabIndex = 14
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Red
        Me.Button6.Location = New System.Drawing.Point(352, 23)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(52, 45)
        Me.Button6.TabIndex = 13
        Me.Button6.UseVisualStyleBackColor = False
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Maroon
        Me.TextBox6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox6.Location = New System.Drawing.Point(133, 184)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(213, 27)
        Me.TextBox6.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Chq No:"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Maroon
        Me.TextBox5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox5.Location = New System.Drawing.Point(132, 152)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(213, 27)
        Me.TextBox5.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Bank:"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Maroon
        Me.TextBox4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox4.Location = New System.Drawing.Point(132, 119)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(213, 27)
        Me.TextBox4.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Close Date:"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Maroon
        Me.TextBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox3.Location = New System.Drawing.Point(132, 86)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(213, 27)
        Me.TextBox3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Chaq Date:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Maroon
        Me.TextBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox2.Location = New System.Drawing.Point(133, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(213, 27)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Status:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Maroon
        Me.TextBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Yellow
        Me.TextBox1.Location = New System.Drawing.Point(133, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 27)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Chq_NoLabel)
        Me.GroupBox1.Controls.Add(Me.Chq_NoTextBox)
        Me.GroupBox1.Controls.Add(C_NameLabel)
        Me.GroupBox1.Controls.Add(Me.C_NameTextBox)
        Me.GroupBox1.Controls.Add(BankLabel)
        Me.GroupBox1.Controls.Add(Me.BankTextBox)
        Me.GroupBox1.Controls.Add(AmountLabel)
        Me.GroupBox1.Controls.Add(Me.AmountTextBox)
        Me.GroupBox1.Controls.Add(StatusLabel)
        Me.GroupBox1.Controls.Add(Me.StatusTextBox)
        Me.GroupBox1.Controls.Add(Issue_dateLabel)
        Me.GroupBox1.Controls.Add(Me.Issue_dateDateTimePicker)
        Me.GroupBox1.Controls.Add(Close_dateLabel)
        Me.GroupBox1.Controls.Add(Me.Close_dateDateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 296)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(189, 238)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(178, 34)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Mark as Returned"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(427, 125)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 46)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Lime
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(5, 238)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(178, 34)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Mark as Paid"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(325, 125)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 46)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(325, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 34)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Chq_NoTextBox
        '
        Me.Chq_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChaquereceivedBindingSource, "Chq_No", True))
        Me.Chq_NoTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chq_NoTextBox.Location = New System.Drawing.Point(92, 16)
        Me.Chq_NoTextBox.Name = "Chq_NoTextBox"
        Me.Chq_NoTextBox.Size = New System.Drawing.Size(410, 27)
        Me.Chq_NoTextBox.TabIndex = 1
        '
        'ChaquereceivedBindingSource
        '
        Me.ChaquereceivedBindingSource.DataMember = "chaquereceived"
        Me.ChaquereceivedBindingSource.DataSource = Me.DbsdatabaseDataSet
        '
        'DbsdatabaseDataSet
        '
        Me.DbsdatabaseDataSet.DataSetName = "dbsdatabaseDataSet"
        Me.DbsdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'C_NameTextBox
        '
        Me.C_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChaquereceivedBindingSource, "C_Name", True))
        Me.C_NameTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_NameTextBox.Location = New System.Drawing.Point(92, 49)
        Me.C_NameTextBox.Name = "C_NameTextBox"
        Me.C_NameTextBox.Size = New System.Drawing.Size(410, 27)
        Me.C_NameTextBox.TabIndex = 3
        '
        'BankTextBox
        '
        Me.BankTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChaquereceivedBindingSource, "Bank", True))
        Me.BankTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BankTextBox.Location = New System.Drawing.Point(92, 82)
        Me.BankTextBox.Name = "BankTextBox"
        Me.BankTextBox.Size = New System.Drawing.Size(227, 27)
        Me.BankTextBox.TabIndex = 5
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChaquereceivedBindingSource, "Amount", True))
        Me.AmountTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTextBox.Location = New System.Drawing.Point(92, 115)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(227, 27)
        Me.AmountTextBox.TabIndex = 7
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChaquereceivedBindingSource, "Status", True))
        Me.StatusTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTextBox.Location = New System.Drawing.Point(101, 305)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 27)
        Me.StatusTextBox.TabIndex = 9
        '
        'Issue_dateDateTimePicker
        '
        Me.Issue_dateDateTimePicker.CalendarFont = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Issue_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ChaquereceivedBindingSource, "Issue_date", True))
        Me.Issue_dateDateTimePicker.Location = New System.Drawing.Point(115, 153)
        Me.Issue_dateDateTimePicker.Name = "Issue_dateDateTimePicker"
        Me.Issue_dateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Issue_dateDateTimePicker.TabIndex = 11
        '
        'Close_dateDateTimePicker
        '
        Me.Close_dateDateTimePicker.CalendarFont = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ChaquereceivedBindingSource, "Close_date", True))
        Me.Close_dateDateTimePicker.Location = New System.Drawing.Point(115, 192)
        Me.Close_dateDateTimePicker.Name = "Close_dateDateTimePicker"
        Me.Close_dateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Close_dateDateTimePicker.TabIndex = 13
        '
        'ChaquereceivedTableAdapter
        '
        Me.ChaquereceivedTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.allitemsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.banksTableAdapter = Nothing
        Me.TableAdapterManager.brandTableAdapter = Nothing
        Me.TableAdapterManager.chaque_issueTableAdapter = Nothing
        Me.TableAdapterManager.chaquereceivedTableAdapter = Me.ChaquereceivedTableAdapter
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
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'ChaquereceivedDataGridView
        '
        Me.ChaquereceivedDataGridView.AllowUserToAddRows = False
        Me.ChaquereceivedDataGridView.AutoGenerateColumns = False
        Me.ChaquereceivedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ChaquereceivedDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ChaquereceivedDataGridView.DataSource = Me.ChaquereceivedBindingSource
        Me.ChaquereceivedDataGridView.Location = New System.Drawing.Point(12, 317)
        Me.ChaquereceivedDataGridView.Name = "ChaquereceivedDataGridView"
        Me.ChaquereceivedDataGridView.Size = New System.Drawing.Size(1138, 353)
        Me.ChaquereceivedDataGridView.TabIndex = 17
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(962, 115)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(188, 36)
        Me.Button11.TabIndex = 21
        Me.Button11.Text = "Show All Chaques"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(962, 67)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(188, 44)
        Me.Button10.TabIndex = 20
        Me.Button10.Text = "Report"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(962, 12)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(188, 44)
        Me.Button9.TabIndex = 19
        Me.Button9.Text = "Customer"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.DbsdatabaseDataSet
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AutoGenerateColumns = False
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9})
        Me.CustomerDataGridView.DataSource = Me.CustomerBindingSource
        Me.CustomerDataGridView.Location = New System.Drawing.Point(949, 161)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.Size = New System.Drawing.Size(316, 209)
        Me.CustomerDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 250
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Chq_No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Chq_No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 120
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "C_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "C_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Bank"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Bank"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 120
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Issue_date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Issue_date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 140
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Close_date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Close_date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 140
        '
        'Customer_Chaque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1157, 682)
        Me.Controls.Add(Me.CustomerDataGridView)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.ChaquereceivedDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Customer_Chaque"
        Me.Text = "Customer_Chaque"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ChaquereceivedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbsdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChaquereceivedDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DbsdatabaseDataSet As dbsdatabaseDataSet
    Friend WithEvents ChaquereceivedBindingSource As BindingSource
    Friend WithEvents ChaquereceivedTableAdapter As dbsdatabaseDataSetTableAdapters.chaquereceivedTableAdapter
    Friend WithEvents TableAdapterManager As dbsdatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ChaquereceivedDataGridView As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Chq_NoTextBox As TextBox
    Friend WithEvents C_NameTextBox As TextBox
    Friend WithEvents BankTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents Issue_dateDateTimePicker As DateTimePicker
    Friend WithEvents Close_dateDateTimePicker As DateTimePicker
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents CustomerTableAdapter As dbsdatabaseDataSetTableAdapters.customerTableAdapter
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
