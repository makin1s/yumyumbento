<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menuform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menuform))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelLogout = New System.Windows.Forms.Label()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.SearchMenuItemNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MenuCancelButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.MenuCheckBox = New System.Windows.Forms.CheckBox()
        Me.MenuIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.CategoryIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.ItemNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.MenuLastUpdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.MenuClearButton = New System.Windows.Forms.Button()
        Me.MenuDeleteButton = New System.Windows.Forms.Button()
        Me.MenuHomeButton = New System.Windows.Forms.Button()
        Me.MenuEditSaveButton = New System.Windows.Forms.Button()
        Me.NewMenuButton = New System.Windows.Forms.Button()
        Me.MenuCount1 = New System.Windows.Forms.Label()
        Me.MenuDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.MenuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(905, 72)
        Me.Panel2.TabIndex = 6
        '
        'LabelLogout
        '
        Me.LabelLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelLogout.AutoSize = True
        Me.LabelLogout.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.LabelLogout.ForeColor = System.Drawing.Color.LavenderBlush
        Me.LabelLogout.Image = Global.YumYumBento_OrderingSystem.My.Resources.Resources.strip
        Me.LabelLogout.Location = New System.Drawing.Point(820, 26)
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
        Me.UserNameLabel.Location = New System.Drawing.Point(687, 26)
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
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.MenuCount1)
        Me.Panel1.Controls.Add(Me.MenuDataGridView)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, 73)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 513)
        Me.Panel1.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label87)
        Me.GroupBox2.Controls.Add(Me.SearchMenuItemNameTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(341, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(522, 55)
        Me.GroupBox2.TabIndex = 149
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Menu Search"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(70, 20)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(61, 13)
        Me.Label87.TabIndex = 1
        Me.Label87.Text = "Item Name:"
        '
        'SearchMenuItemNameTextBox
        '
        Me.SearchMenuItemNameTextBox.Location = New System.Drawing.Point(147, 18)
        Me.SearchMenuItemNameTextBox.Name = "SearchMenuItemNameTextBox"
        Me.SearchMenuItemNameTextBox.Size = New System.Drawing.Size(106, 20)
        Me.SearchMenuItemNameTextBox.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.MenuCancelButton)
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.MenuClearButton)
        Me.Panel3.Controls.Add(Me.MenuDeleteButton)
        Me.Panel3.Controls.Add(Me.MenuHomeButton)
        Me.Panel3.Controls.Add(Me.MenuEditSaveButton)
        Me.Panel3.Controls.Add(Me.NewMenuButton)
        Me.Panel3.Location = New System.Drawing.Point(5, 30)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(316, 464)
        Me.Panel3.TabIndex = 10
        '
        'MenuCancelButton
        '
        Me.MenuCancelButton.BackColor = System.Drawing.Color.MediumAquamarine
        Me.MenuCancelButton.BackgroundImage = CType(resources.GetObject("MenuCancelButton.BackgroundImage"), System.Drawing.Image)
        Me.MenuCancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuCancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuCancelButton.FlatAppearance.BorderSize = 3
        Me.MenuCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuCancelButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuCancelButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.MenuCancelButton.Location = New System.Drawing.Point(201, 400)
        Me.MenuCancelButton.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuCancelButton.Name = "MenuCancelButton"
        Me.MenuCancelButton.Size = New System.Drawing.Size(83, 50)
        Me.MenuCancelButton.TabIndex = 149
        Me.MenuCancelButton.Text = "Cancel"
        Me.MenuCancelButton.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label102)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.MenuCheckBox)
        Me.GroupBox3.Controls.Add(Me.MenuIDTextBox)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.CategoryIDTextBox)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.ItemNameTextBox)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.PriceTextBox)
        Me.GroupBox3.Controls.Add(Me.DescriptionTextBox)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.MenuLastUpdateDateTimePicker)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(299, 327)
        Me.GroupBox3.TabIndex = 148
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Menu Details"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label102.ForeColor = System.Drawing.Color.Red
        Me.Label102.Location = New System.Drawing.Point(182, 105)
        Me.Label102.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(11, 13)
        Me.Label102.TabIndex = 154
        Me.Label102.Text = "*"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(11, 160)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(40, 13)
        Me.Label31.TabIndex = 149
        Me.Label31.Text = "Active:"
        '
        'MenuCheckBox
        '
        Me.MenuCheckBox.AutoSize = True
        Me.MenuCheckBox.Checked = True
        Me.MenuCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MenuCheckBox.Location = New System.Drawing.Point(88, 159)
        Me.MenuCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuCheckBox.Name = "MenuCheckBox"
        Me.MenuCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.MenuCheckBox.TabIndex = 150
        Me.MenuCheckBox.UseVisualStyleBackColor = True
        '
        'MenuIDTextBox
        '
        Me.MenuIDTextBox.Location = New System.Drawing.Point(81, 18)
        Me.MenuIDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuIDTextBox.Name = "MenuIDTextBox"
        Me.MenuIDTextBox.Size = New System.Drawing.Size(62, 20)
        Me.MenuIDTextBox.TabIndex = 148
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label32.ForeColor = System.Drawing.Color.Red
        Me.Label32.Location = New System.Drawing.Point(167, 135)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(11, 13)
        Me.Label32.TabIndex = 146
        Me.Label32.Text = "*"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(11, 21)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 13)
        Me.Label21.TabIndex = 147
        Me.Label21.Text = "Item ID:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(11, 48)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(66, 13)
        Me.Label37.TabIndex = 114
        Me.Label37.Text = "Category ID:"
        '
        'CategoryIDTextBox
        '
        Me.CategoryIDTextBox.Location = New System.Drawing.Point(81, 44)
        Me.CategoryIDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CategoryIDTextBox.Name = "CategoryIDTextBox"
        Me.CategoryIDTextBox.Size = New System.Drawing.Size(83, 20)
        Me.CategoryIDTextBox.TabIndex = 115
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label36.ForeColor = System.Drawing.Color.Red
        Me.Label36.Location = New System.Drawing.Point(167, 48)
        Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(11, 13)
        Me.Label36.TabIndex = 116
        Me.Label36.Text = "*"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(11, 77)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(61, 13)
        Me.Label35.TabIndex = 117
        Me.Label35.Text = "Item Name:"
        '
        'ItemNameTextBox
        '
        Me.ItemNameTextBox.Location = New System.Drawing.Point(81, 73)
        Me.ItemNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ItemNameTextBox.Name = "ItemNameTextBox"
        Me.ItemNameTextBox.Size = New System.Drawing.Size(83, 20)
        Me.ItemNameTextBox.TabIndex = 118
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label34.ForeColor = System.Drawing.Color.Red
        Me.Label34.Location = New System.Drawing.Point(167, 77)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(11, 13)
        Me.Label34.TabIndex = 119
        Me.Label34.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(149, 21)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(11, 13)
        Me.Label22.TabIndex = 140
        Me.Label22.Text = "*"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(11, 105)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(34, 13)
        Me.Label33.TabIndex = 120
        Me.Label33.Text = "Price:"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(81, 101)
        Me.PriceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(97, 20)
        Me.PriceTextBox.TabIndex = 121
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(81, 131)
        Me.DescriptionTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DescriptionTextBox.MaxLength = 3276798
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(83, 20)
        Me.DescriptionTextBox.TabIndex = 136
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(11, 192)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(68, 13)
        Me.Label30.TabIndex = 126
        Me.Label30.Text = "Last Update:"
        '
        'MenuLastUpdateDateTimePicker
        '
        Me.MenuLastUpdateDateTimePicker.Location = New System.Drawing.Point(83, 192)
        Me.MenuLastUpdateDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuLastUpdateDateTimePicker.Name = "MenuLastUpdateDateTimePicker"
        Me.MenuLastUpdateDateTimePicker.Size = New System.Drawing.Size(196, 20)
        Me.MenuLastUpdateDateTimePicker.TabIndex = 127
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(149, 192)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(0, 13)
        Me.Label29.TabIndex = 128
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(11, 133)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(63, 13)
        Me.Label27.TabIndex = 131
        Me.Label27.Text = "Description:"
        '
        'MenuClearButton
        '
        Me.MenuClearButton.BackColor = System.Drawing.Color.LightBlue
        Me.MenuClearButton.BackgroundImage = CType(resources.GetObject("MenuClearButton.BackgroundImage"), System.Drawing.Image)
        Me.MenuClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuClearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuClearButton.FlatAppearance.BorderSize = 3
        Me.MenuClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuClearButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuClearButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.MenuClearButton.Location = New System.Drawing.Point(104, 400)
        Me.MenuClearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuClearButton.Name = "MenuClearButton"
        Me.MenuClearButton.Padding = New System.Windows.Forms.Padding(8)
        Me.MenuClearButton.Size = New System.Drawing.Size(83, 50)
        Me.MenuClearButton.TabIndex = 8
        Me.MenuClearButton.Text = "Clear"
        Me.MenuClearButton.UseVisualStyleBackColor = False
        '
        'MenuDeleteButton
        '
        Me.MenuDeleteButton.BackColor = System.Drawing.Color.LightBlue
        Me.MenuDeleteButton.BackgroundImage = CType(resources.GetObject("MenuDeleteButton.BackgroundImage"), System.Drawing.Image)
        Me.MenuDeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuDeleteButton.FlatAppearance.BorderSize = 3
        Me.MenuDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuDeleteButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuDeleteButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.MenuDeleteButton.Location = New System.Drawing.Point(5, 400)
        Me.MenuDeleteButton.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuDeleteButton.Name = "MenuDeleteButton"
        Me.MenuDeleteButton.Padding = New System.Windows.Forms.Padding(8)
        Me.MenuDeleteButton.Size = New System.Drawing.Size(83, 50)
        Me.MenuDeleteButton.TabIndex = 7
        Me.MenuDeleteButton.Text = "Delete"
        Me.MenuDeleteButton.UseVisualStyleBackColor = False
        '
        'MenuHomeButton
        '
        Me.MenuHomeButton.BackColor = System.Drawing.Color.MediumAquamarine
        Me.MenuHomeButton.BackgroundImage = CType(resources.GetObject("MenuHomeButton.BackgroundImage"), System.Drawing.Image)
        Me.MenuHomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuHomeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuHomeButton.FlatAppearance.BorderSize = 3
        Me.MenuHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuHomeButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuHomeButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.MenuHomeButton.Location = New System.Drawing.Point(201, 333)
        Me.MenuHomeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuHomeButton.Name = "MenuHomeButton"
        Me.MenuHomeButton.Size = New System.Drawing.Size(83, 50)
        Me.MenuHomeButton.TabIndex = 5
        Me.MenuHomeButton.Text = "Home"
        Me.MenuHomeButton.UseVisualStyleBackColor = False
        '
        'MenuEditSaveButton
        '
        Me.MenuEditSaveButton.BackColor = System.Drawing.Color.LightBlue
        Me.MenuEditSaveButton.BackgroundImage = CType(resources.GetObject("MenuEditSaveButton.BackgroundImage"), System.Drawing.Image)
        Me.MenuEditSaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuEditSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuEditSaveButton.FlatAppearance.BorderSize = 3
        Me.MenuEditSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuEditSaveButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuEditSaveButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.MenuEditSaveButton.Location = New System.Drawing.Point(104, 333)
        Me.MenuEditSaveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuEditSaveButton.Name = "MenuEditSaveButton"
        Me.MenuEditSaveButton.Padding = New System.Windows.Forms.Padding(8)
        Me.MenuEditSaveButton.Size = New System.Drawing.Size(83, 50)
        Me.MenuEditSaveButton.TabIndex = 6
        Me.MenuEditSaveButton.Text = "Edit"
        Me.MenuEditSaveButton.UseVisualStyleBackColor = False
        '
        'NewMenuButton
        '
        Me.NewMenuButton.BackColor = System.Drawing.Color.LightBlue
        Me.NewMenuButton.BackgroundImage = CType(resources.GetObject("NewMenuButton.BackgroundImage"), System.Drawing.Image)
        Me.NewMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NewMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewMenuButton.FlatAppearance.BorderSize = 3
        Me.NewMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewMenuButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewMenuButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.NewMenuButton.Location = New System.Drawing.Point(5, 333)
        Me.NewMenuButton.Margin = New System.Windows.Forms.Padding(2)
        Me.NewMenuButton.Name = "NewMenuButton"
        Me.NewMenuButton.Padding = New System.Windows.Forms.Padding(8)
        Me.NewMenuButton.Size = New System.Drawing.Size(83, 50)
        Me.NewMenuButton.TabIndex = 0
        Me.NewMenuButton.Text = "New"
        Me.NewMenuButton.UseVisualStyleBackColor = False
        '
        'MenuCount1
        '
        Me.MenuCount1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MenuCount1.AutoSize = True
        Me.MenuCount1.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.MenuCount1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuCount1.Location = New System.Drawing.Point(2, 496)
        Me.MenuCount1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MenuCount1.Name = "MenuCount1"
        Me.MenuCount1.Size = New System.Drawing.Size(90, 14)
        Me.MenuCount1.TabIndex = 8
        Me.MenuCount1.Text = "Record #: Menu"
        '
        'MenuDataGridView
        '
        Me.MenuDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MenuDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MenuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuDataGridView.Location = New System.Drawing.Point(341, 94)
        Me.MenuDataGridView.Name = "MenuDataGridView"
        Me.MenuDataGridView.Size = New System.Drawing.Size(551, 400)
        Me.MenuDataGridView.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(16, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Menu"
        '
        'Menuform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 589)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Menuform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.MenuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelLogout As Label
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label87 As Label
    Friend WithEvents SearchMenuItemNameTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MenuCancelButton As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label102 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents MenuCheckBox As CheckBox
    Friend WithEvents MenuIDTextBox As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents CategoryIDTextBox As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents ItemNameTextBox As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents MenuLastUpdateDateTimePicker As DateTimePicker
    Friend WithEvents Label29 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents MenuClearButton As Button
    Friend WithEvents MenuDeleteButton As Button
    Friend WithEvents MenuHomeButton As Button
    Friend WithEvents MenuEditSaveButton As Button
    Friend WithEvents NewMenuButton As Button
    Friend WithEvents MenuCount1 As Label
    Friend WithEvents MenuDataGridView As DataGridView
    Friend WithEvents Label2 As Label
End Class
