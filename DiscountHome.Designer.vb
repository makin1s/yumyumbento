<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiscountHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiscountHome))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DiscountSearchDescrTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DiscountSearchTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountCount = New System.Windows.Forms.Label()
        Me.DiscountDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DiscountCreatedOn = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DiscountUpdatedOn = New System.Windows.Forms.DateTimePicker()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.DiscountActiveCheckbox = New System.Windows.Forms.CheckBox()
        Me.DiscountIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DiscountStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DiscountEndDate = New System.Windows.Forms.DateTimePicker()
        Me.DiscountDescrTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ButtonCancelDiscount = New System.Windows.Forms.Button()
        Me.ButtonDeleteDiscount = New System.Windows.Forms.Button()
        Me.ButtonEditDiscount = New System.Windows.Forms.Button()
        Me.ButtonAddDiscount = New System.Windows.Forms.Button()
        Me.ButtonDiscountHome = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelLogout = New System.Windows.Forms.Label()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DiscountDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.DiscountCount)
        Me.Panel1.Controls.Add(Me.DiscountDataGridView)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(11, 71)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1002, 515)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DiscountSearchDescrTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DiscountSearchTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(354, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 56)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'DiscountSearchDescrTextBox
        '
        Me.DiscountSearchDescrTextBox.Location = New System.Drawing.Point(328, 21)
        Me.DiscountSearchDescrTextBox.Name = "DiscountSearchDescrTextBox"
        Me.DiscountSearchDescrTextBox.Size = New System.Drawing.Size(221, 22)
        Me.DiscountSearchDescrTextBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(252, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Discount:"
        '
        'DiscountSearchTextBox
        '
        Me.DiscountSearchTextBox.Location = New System.Drawing.Point(81, 20)
        Me.DiscountSearchTextBox.Name = "DiscountSearchTextBox"
        Me.DiscountSearchTextBox.Size = New System.Drawing.Size(125, 22)
        Me.DiscountSearchTextBox.TabIndex = 0
        '
        'DiscountCount
        '
        Me.DiscountCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DiscountCount.AutoSize = True
        Me.DiscountCount.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.DiscountCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DiscountCount.Location = New System.Drawing.Point(2, 496)
        Me.DiscountCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DiscountCount.Name = "DiscountCount"
        Me.DiscountCount.Size = New System.Drawing.Size(156, 14)
        Me.DiscountCount.TabIndex = 8
        Me.DiscountCount.Text = "Discount #: No of Discounts"
        '
        'DiscountDataGridView
        '
        Me.DiscountDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiscountDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.DiscountDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DiscountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DiscountDataGridView.Location = New System.Drawing.Point(354, 99)
        Me.DiscountDataGridView.Name = "DiscountDataGridView"
        Me.DiscountDataGridView.Size = New System.Drawing.Size(632, 394)
        Me.DiscountDataGridView.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(16, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Discounts"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.DiscountCreatedOn)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.DiscountUpdatedOn)
        Me.Panel3.Controls.Add(Me.Label31)
        Me.Panel3.Controls.Add(Me.DiscountActiveCheckbox)
        Me.Panel3.Controls.Add(Me.DiscountIDTextBox)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.DiscountStartDate)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.DiscountEndDate)
        Me.Panel3.Controls.Add(Me.DiscountDescrTextBox)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.DiscountTextBox)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.ButtonCancelDiscount)
        Me.Panel3.Controls.Add(Me.ButtonDeleteDiscount)
        Me.Panel3.Controls.Add(Me.ButtonEditDiscount)
        Me.Panel3.Controls.Add(Me.ButtonAddDiscount)
        Me.Panel3.Controls.Add(Me.ButtonDiscountHome)
        Me.Panel3.Location = New System.Drawing.Point(14, 43)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(335, 450)
        Me.Panel3.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(15, 155)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 14)
        Me.Label19.TabIndex = 161
        Me.Label19.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(17, 124)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 14)
        Me.Label18.TabIndex = 160
        Me.Label18.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(9, 95)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 14)
        Me.Label17.TabIndex = 159
        Me.Label17.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(21, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 14)
        Me.Label16.TabIndex = 158
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(12, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 14)
        Me.Label15.TabIndex = 157
        Me.Label15.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(17, 215)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 14)
        Me.Label13.TabIndex = 156
        Me.Label13.Text = "Created On:"
        '
        'DiscountCreatedOn
        '
        Me.DiscountCreatedOn.Enabled = False
        Me.DiscountCreatedOn.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.DiscountCreatedOn.Location = New System.Drawing.Point(107, 210)
        Me.DiscountCreatedOn.Margin = New System.Windows.Forms.Padding(2)
        Me.DiscountCreatedOn.Name = "DiscountCreatedOn"
        Me.DiscountCreatedOn.Size = New System.Drawing.Size(215, 22)
        Me.DiscountCreatedOn.TabIndex = 155
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label14.Location = New System.Drawing.Point(16, 246)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 14)
        Me.Label14.TabIndex = 154
        Me.Label14.Text = "Updated On:"
        '
        'DiscountUpdatedOn
        '
        Me.DiscountUpdatedOn.Enabled = False
        Me.DiscountUpdatedOn.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.DiscountUpdatedOn.Location = New System.Drawing.Point(107, 243)
        Me.DiscountUpdatedOn.Margin = New System.Windows.Forms.Padding(2)
        Me.DiscountUpdatedOn.Name = "DiscountUpdatedOn"
        Me.DiscountUpdatedOn.Size = New System.Drawing.Size(215, 22)
        Me.DiscountUpdatedOn.TabIndex = 153
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label31.Location = New System.Drawing.Point(43, 185)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(41, 14)
        Me.Label31.TabIndex = 151
        Me.Label31.Text = "Active:"
        '
        'DiscountActiveCheckbox
        '
        Me.DiscountActiveCheckbox.AutoSize = True
        Me.DiscountActiveCheckbox.Checked = True
        Me.DiscountActiveCheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DiscountActiveCheckbox.Enabled = False
        Me.DiscountActiveCheckbox.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.DiscountActiveCheckbox.Location = New System.Drawing.Point(108, 185)
        Me.DiscountActiveCheckbox.Margin = New System.Windows.Forms.Padding(2)
        Me.DiscountActiveCheckbox.Name = "DiscountActiveCheckbox"
        Me.DiscountActiveCheckbox.Size = New System.Drawing.Size(15, 14)
        Me.DiscountActiveCheckbox.TabIndex = 152
        Me.DiscountActiveCheckbox.UseVisualStyleBackColor = True
        '
        'DiscountIDTextBox
        '
        Me.DiscountIDTextBox.Enabled = False
        Me.DiscountIDTextBox.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.DiscountIDTextBox.Location = New System.Drawing.Point(107, 28)
        Me.DiscountIDTextBox.Name = "DiscountIDTextBox"
        Me.DiscountIDTextBox.ReadOnly = True
        Me.DiscountIDTextBox.Size = New System.Drawing.Size(71, 22)
        Me.DiscountIDTextBox.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(26, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 14)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Discount ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(32, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 14)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Start Date:"
        '
        'DiscountStartDate
        '
        Me.DiscountStartDate.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.DiscountStartDate.Location = New System.Drawing.Point(107, 119)
        Me.DiscountStartDate.Margin = New System.Windows.Forms.Padding(2)
        Me.DiscountStartDate.Name = "DiscountStartDate"
        Me.DiscountStartDate.Size = New System.Drawing.Size(215, 22)
        Me.DiscountStartDate.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(31, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 14)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "End Date:"
        '
        'DiscountEndDate
        '
        Me.DiscountEndDate.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.DiscountEndDate.Location = New System.Drawing.Point(107, 152)
        Me.DiscountEndDate.Margin = New System.Windows.Forms.Padding(2)
        Me.DiscountEndDate.Name = "DiscountEndDate"
        Me.DiscountEndDate.Size = New System.Drawing.Size(215, 22)
        Me.DiscountEndDate.TabIndex = 17
        '
        'DiscountDescrTextBox
        '
        Me.DiscountDescrTextBox.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.DiscountDescrTextBox.Location = New System.Drawing.Point(107, 89)
        Me.DiscountDescrTextBox.Name = "DiscountDescrTextBox"
        Me.DiscountDescrTextBox.Size = New System.Drawing.Size(176, 22)
        Me.DiscountDescrTextBox.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label11.Location = New System.Drawing.Point(24, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 14)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Description:"
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.DiscountTextBox.Location = New System.Drawing.Point(107, 59)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(112, 22)
        Me.DiscountTextBox.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label12.Location = New System.Drawing.Point(36, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 14)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Discount:"
        '
        'ButtonCancelDiscount
        '
        Me.ButtonCancelDiscount.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonCancelDiscount.BackgroundImage = CType(resources.GetObject("ButtonCancelDiscount.BackgroundImage"), System.Drawing.Image)
        Me.ButtonCancelDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonCancelDiscount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonCancelDiscount.FlatAppearance.BorderSize = 3
        Me.ButtonCancelDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancelDiscount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelDiscount.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonCancelDiscount.Location = New System.Drawing.Point(123, 386)
        Me.ButtonCancelDiscount.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonCancelDiscount.Name = "ButtonCancelDiscount"
        Me.ButtonCancelDiscount.Size = New System.Drawing.Size(83, 50)
        Me.ButtonCancelDiscount.TabIndex = 9
        Me.ButtonCancelDiscount.Text = "Cancel"
        Me.ButtonCancelDiscount.UseVisualStyleBackColor = False
        '
        'ButtonDeleteDiscount
        '
        Me.ButtonDeleteDiscount.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonDeleteDiscount.BackgroundImage = CType(resources.GetObject("ButtonDeleteDiscount.BackgroundImage"), System.Drawing.Image)
        Me.ButtonDeleteDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonDeleteDiscount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonDeleteDiscount.FlatAppearance.BorderSize = 3
        Me.ButtonDeleteDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDeleteDiscount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDeleteDiscount.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonDeleteDiscount.Location = New System.Drawing.Point(20, 386)
        Me.ButtonDeleteDiscount.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonDeleteDiscount.Name = "ButtonDeleteDiscount"
        Me.ButtonDeleteDiscount.Size = New System.Drawing.Size(83, 50)
        Me.ButtonDeleteDiscount.TabIndex = 7
        Me.ButtonDeleteDiscount.Text = "Disable"
        Me.ButtonDeleteDiscount.UseVisualStyleBackColor = False
        '
        'ButtonEditDiscount
        '
        Me.ButtonEditDiscount.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonEditDiscount.BackgroundImage = CType(resources.GetObject("ButtonEditDiscount.BackgroundImage"), System.Drawing.Image)
        Me.ButtonEditDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditDiscount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonEditDiscount.FlatAppearance.BorderSize = 3
        Me.ButtonEditDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditDiscount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditDiscount.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonEditDiscount.Location = New System.Drawing.Point(123, 322)
        Me.ButtonEditDiscount.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditDiscount.Name = "ButtonEditDiscount"
        Me.ButtonEditDiscount.Size = New System.Drawing.Size(83, 50)
        Me.ButtonEditDiscount.TabIndex = 6
        Me.ButtonEditDiscount.Text = "Edit"
        Me.ButtonEditDiscount.UseVisualStyleBackColor = False
        '
        'ButtonAddDiscount
        '
        Me.ButtonAddDiscount.BackColor = System.Drawing.Color.LightBlue
        Me.ButtonAddDiscount.BackgroundImage = CType(resources.GetObject("ButtonAddDiscount.BackgroundImage"), System.Drawing.Image)
        Me.ButtonAddDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonAddDiscount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonAddDiscount.FlatAppearance.BorderSize = 3
        Me.ButtonAddDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddDiscount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddDiscount.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonAddDiscount.Location = New System.Drawing.Point(20, 322)
        Me.ButtonAddDiscount.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAddDiscount.Name = "ButtonAddDiscount"
        Me.ButtonAddDiscount.Size = New System.Drawing.Size(83, 50)
        Me.ButtonAddDiscount.TabIndex = 0
        Me.ButtonAddDiscount.Text = "New"
        Me.ButtonAddDiscount.UseVisualStyleBackColor = False
        '
        'ButtonDiscountHome
        '
        Me.ButtonDiscountHome.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ButtonDiscountHome.BackgroundImage = CType(resources.GetObject("ButtonDiscountHome.BackgroundImage"), System.Drawing.Image)
        Me.ButtonDiscountHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonDiscountHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonDiscountHome.FlatAppearance.BorderSize = 3
        Me.ButtonDiscountHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDiscountHome.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDiscountHome.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonDiscountHome.Location = New System.Drawing.Point(228, 322)
        Me.ButtonDiscountHome.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDiscountHome.Name = "ButtonDiscountHome"
        Me.ButtonDiscountHome.Size = New System.Drawing.Size(83, 50)
        Me.ButtonDiscountHome.TabIndex = 5
        Me.ButtonDiscountHome.Text = "Home"
        Me.ButtonDiscountHome.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.BackgroundImage = Global.YumYumBento_OrderingSystem.My.Resources.Resources.strip
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.LabelLogout)
        Me.Panel2.Controls.Add(Me.UserNameLabel)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(-4, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1030, 72)
        Me.Panel2.TabIndex = 3
        '
        'LabelLogout
        '
        Me.LabelLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelLogout.AutoSize = True
        Me.LabelLogout.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.LabelLogout.ForeColor = System.Drawing.Color.LavenderBlush
        Me.LabelLogout.Image = Global.YumYumBento_OrderingSystem.My.Resources.Resources.strip
        Me.LabelLogout.Location = New System.Drawing.Point(960, 21)
        Me.LabelLogout.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelLogout.Name = "LabelLogout"
        Me.LabelLogout.Size = New System.Drawing.Size(57, 19)
        Me.LabelLogout.TabIndex = 3
        Me.LabelLogout.Text = "Log out"
        '
        'UserNameLabel
        '
        Me.UserNameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.UserNameLabel.ForeColor = System.Drawing.Color.LavenderBlush
        Me.UserNameLabel.Image = Global.YumYumBento_OrderingSystem.My.Resources.Resources.strip
        Me.UserNameLabel.Location = New System.Drawing.Point(862, 21)
        Me.UserNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(94, 19)
        Me.UserNameLabel.TabIndex = 2
        Me.UserNameLabel.Text = "<Login User>"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.BackgroundImage = Global.YumYumBento_OrderingSystem.My.Resources.Resources.strip
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.YumYumBento_OrderingSystem.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(29, 8)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DiscountHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 583)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "DiscountHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discounts"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DiscountDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonDiscountHome As Button
    Friend WithEvents ButtonAddDiscount As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DiscountDataGridView As DataGridView
    Friend WithEvents DiscountCount As Label
    Friend WithEvents ButtonDeleteDiscount As Button
    Friend WithEvents ButtonEditDiscount As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DiscountSearchDescrTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DiscountSearchTextBox As TextBox
    Friend WithEvents LabelLogout As Label
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents ButtonCancelDiscount As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents DiscountActiveCheckbox As CheckBox
    Friend WithEvents DiscountIDTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DiscountStartDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents DiscountEndDate As DateTimePicker
    Friend WithEvents DiscountDescrTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DiscountCreatedOn As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents DiscountUpdatedOn As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
End Class
