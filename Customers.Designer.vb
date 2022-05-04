<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customers))
        Me.LabelLogout = New System.Windows.Forms.Label()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CustomerCount = New System.Windows.Forms.Label()
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.SearchCusLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.SearchCusFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CusCancelButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.CusCheckBox = New System.Windows.Forms.CheckBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.CusFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.CusLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.CusEmailTextBox = New System.Windows.Forms.TextBox()
        Me.CusAddressTextBox = New System.Windows.Forms.TextBox()
        Me.CusPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.CusZipcodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.CusLastUpdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.CusClearButton = New System.Windows.Forms.Button()
        Me.CusDeleteButton = New System.Windows.Forms.Button()
        Me.CusHomeButton = New System.Windows.Forms.Button()
        Me.CusEditSaveButton = New System.Windows.Forms.Button()
        Me.NewCusButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel2.Location = New System.Drawing.Point(-3, -2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(905, 72)
        Me.Panel2.TabIndex = 5
        '
        'CustomerCount
        '
        Me.CustomerCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CustomerCount.AutoSize = True
        Me.CustomerCount.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.CustomerCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CustomerCount.Location = New System.Drawing.Point(2, 494)
        Me.CustomerCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CustomerCount.Name = "CustomerCount"
        Me.CustomerCount.Size = New System.Drawing.Size(116, 14)
        Me.CustomerCount.TabIndex = 8
        Me.CustomerCount.Text = "Record #: Customers"
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomerDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CustomerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Location = New System.Drawing.Point(341, 94)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.Size = New System.Drawing.Size(522, 398)
        Me.CustomerDataGridView.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(16, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customers"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.CustomerCount)
        Me.Panel1.Controls.Add(Me.CustomerDataGridView)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(11, 69)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(876, 511)
        Me.Panel1.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.SearchCusLastNameTextBox)
        Me.GroupBox2.Controls.Add(Me.Label87)
        Me.GroupBox2.Controls.Add(Me.SearchCusFirstNameTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(341, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(522, 55)
        Me.GroupBox2.TabIndex = 149
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Search"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(289, 21)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(61, 13)
        Me.Label39.TabIndex = 3
        Me.Label39.Text = "Last Name:"
        '
        'SearchCusLastNameTextBox
        '
        Me.SearchCusLastNameTextBox.Location = New System.Drawing.Point(375, 18)
        Me.SearchCusLastNameTextBox.Name = "SearchCusLastNameTextBox"
        Me.SearchCusLastNameTextBox.Size = New System.Drawing.Size(119, 20)
        Me.SearchCusLastNameTextBox.TabIndex = 2
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(70, 20)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(60, 13)
        Me.Label87.TabIndex = 1
        Me.Label87.Text = "First Name:"
        '
        'SearchCusFirstNameTextBox
        '
        Me.SearchCusFirstNameTextBox.Location = New System.Drawing.Point(147, 18)
        Me.SearchCusFirstNameTextBox.Name = "SearchCusFirstNameTextBox"
        Me.SearchCusFirstNameTextBox.Size = New System.Drawing.Size(106, 20)
        Me.SearchCusFirstNameTextBox.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.CusCancelButton)
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.CusClearButton)
        Me.Panel3.Controls.Add(Me.CusDeleteButton)
        Me.Panel3.Controls.Add(Me.CusHomeButton)
        Me.Panel3.Controls.Add(Me.CusEditSaveButton)
        Me.Panel3.Controls.Add(Me.NewCusButton)
        Me.Panel3.Location = New System.Drawing.Point(5, 30)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(316, 464)
        Me.Panel3.TabIndex = 10
        '
        'CusCancelButton
        '
        Me.CusCancelButton.BackColor = System.Drawing.Color.MediumAquamarine
        Me.CusCancelButton.BackgroundImage = CType(resources.GetObject("CusCancelButton.BackgroundImage"), System.Drawing.Image)
        Me.CusCancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CusCancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CusCancelButton.FlatAppearance.BorderSize = 3
        Me.CusCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CusCancelButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CusCancelButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CusCancelButton.Location = New System.Drawing.Point(201, 400)
        Me.CusCancelButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CusCancelButton.Name = "CusCancelButton"
        Me.CusCancelButton.Size = New System.Drawing.Size(83, 50)
        Me.CusCancelButton.TabIndex = 149
        Me.CusCancelButton.Text = "Cancel"
        Me.CusCancelButton.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label102)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.CusCheckBox)
        Me.GroupBox3.Controls.Add(Me.CustomerIDTextBox)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.CusFirstNameTextBox)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.CusLastNameTextBox)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.CusEmailTextBox)
        Me.GroupBox3.Controls.Add(Me.CusAddressTextBox)
        Me.GroupBox3.Controls.Add(Me.CusPhoneTextBox)
        Me.GroupBox3.Controls.Add(Me.CusZipcodeTextBox)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.CusLastUpdateDateTimePicker)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(299, 327)
        Me.GroupBox3.TabIndex = 148
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Details"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label102.ForeColor = System.Drawing.Color.Red
        Me.Label102.Location = New System.Drawing.Point(235, 105)
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
        'CusCheckBox
        '
        Me.CusCheckBox.AutoSize = True
        Me.CusCheckBox.Checked = True
        Me.CusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CusCheckBox.Location = New System.Drawing.Point(88, 159)
        Me.CusCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CusCheckBox.Name = "CusCheckBox"
        Me.CusCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.CusCheckBox.TabIndex = 150
        Me.CusCheckBox.UseVisualStyleBackColor = True
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(81, 18)
        Me.CustomerIDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(62, 20)
        Me.CustomerIDTextBox.TabIndex = 148
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
        Me.Label21.Size = New System.Drawing.Size(68, 13)
        Me.Label21.TabIndex = 147
        Me.Label21.Text = "Customer ID:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(11, 48)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(60, 13)
        Me.Label37.TabIndex = 114
        Me.Label37.Text = "First Name:"
        '
        'CusFirstNameTextBox
        '
        Me.CusFirstNameTextBox.Location = New System.Drawing.Point(81, 44)
        Me.CusFirstNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CusFirstNameTextBox.Name = "CusFirstNameTextBox"
        Me.CusFirstNameTextBox.Size = New System.Drawing.Size(83, 20)
        Me.CusFirstNameTextBox.TabIndex = 115
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
        Me.Label35.Text = "Last Name:"
        '
        'CusLastNameTextBox
        '
        Me.CusLastNameTextBox.Location = New System.Drawing.Point(81, 73)
        Me.CusLastNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CusLastNameTextBox.Name = "CusLastNameTextBox"
        Me.CusLastNameTextBox.Size = New System.Drawing.Size(83, 20)
        Me.CusLastNameTextBox.TabIndex = 118
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
        Me.Label22.Location = New System.Drawing.Point(149, 222)
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
        Me.Label33.Size = New System.Drawing.Size(35, 13)
        Me.Label33.TabIndex = 120
        Me.Label33.Text = "Email:"
        '
        'CusEmailTextBox
        '
        Me.CusEmailTextBox.Location = New System.Drawing.Point(81, 101)
        Me.CusEmailTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CusEmailTextBox.Name = "CusEmailTextBox"
        Me.CusEmailTextBox.Size = New System.Drawing.Size(151, 20)
        Me.CusEmailTextBox.TabIndex = 121
        '
        'CusAddressTextBox
        '
        Me.CusAddressTextBox.Location = New System.Drawing.Point(81, 188)
        Me.CusAddressTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CusAddressTextBox.Name = "CusAddressTextBox"
        Me.CusAddressTextBox.Size = New System.Drawing.Size(151, 20)
        Me.CusAddressTextBox.TabIndex = 137
        '
        'CusPhoneTextBox
        '
        Me.CusPhoneTextBox.Location = New System.Drawing.Point(81, 131)
        Me.CusPhoneTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CusPhoneTextBox.MaxLength = 10
        Me.CusPhoneTextBox.Name = "CusPhoneTextBox"
        Me.CusPhoneTextBox.Size = New System.Drawing.Size(83, 20)
        Me.CusPhoneTextBox.TabIndex = 136
        '
        'CusZipcodeTextBox
        '
        Me.CusZipcodeTextBox.Location = New System.Drawing.Point(81, 222)
        Me.CusZipcodeTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CusZipcodeTextBox.MaxLength = 5
        Me.CusZipcodeTextBox.Name = "CusZipcodeTextBox"
        Me.CusZipcodeTextBox.Size = New System.Drawing.Size(62, 20)
        Me.CusZipcodeTextBox.TabIndex = 135
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(11, 249)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(68, 13)
        Me.Label30.TabIndex = 126
        Me.Label30.Text = "Last Update:"
        '
        'CusLastUpdateDateTimePicker
        '
        Me.CusLastUpdateDateTimePicker.Location = New System.Drawing.Point(81, 246)
        Me.CusLastUpdateDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.CusLastUpdateDateTimePicker.Name = "CusLastUpdateDateTimePicker"
        Me.CusLastUpdateDateTimePicker.Size = New System.Drawing.Size(196, 20)
        Me.CusLastUpdateDateTimePicker.TabIndex = 127
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(11, 226)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(49, 13)
        Me.Label26.TabIndex = 132
        Me.Label26.Text = "Zipcode:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(196, 188)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(11, 13)
        Me.Label29.TabIndex = 128
        Me.Label29.Text = "*"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(11, 133)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(41, 13)
        Me.Label27.TabIndex = 131
        Me.Label27.Text = "Phone:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(11, 192)
        Me.Label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(48, 13)
        Me.Label38.TabIndex = 130
        Me.Label38.Text = "Address:"
        '
        'CusClearButton
        '
        Me.CusClearButton.BackColor = System.Drawing.Color.LightBlue
        Me.CusClearButton.BackgroundImage = CType(resources.GetObject("CusClearButton.BackgroundImage"), System.Drawing.Image)
        Me.CusClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CusClearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CusClearButton.FlatAppearance.BorderSize = 3
        Me.CusClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CusClearButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CusClearButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CusClearButton.Location = New System.Drawing.Point(104, 400)
        Me.CusClearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CusClearButton.Name = "CusClearButton"
        Me.CusClearButton.Padding = New System.Windows.Forms.Padding(8)
        Me.CusClearButton.Size = New System.Drawing.Size(83, 50)
        Me.CusClearButton.TabIndex = 8
        Me.CusClearButton.Text = "Clear"
        Me.CusClearButton.UseVisualStyleBackColor = False
        '
        'CusDeleteButton
        '
        Me.CusDeleteButton.BackColor = System.Drawing.Color.LightBlue
        Me.CusDeleteButton.BackgroundImage = CType(resources.GetObject("CusDeleteButton.BackgroundImage"), System.Drawing.Image)
        Me.CusDeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CusDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CusDeleteButton.FlatAppearance.BorderSize = 3
        Me.CusDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CusDeleteButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CusDeleteButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CusDeleteButton.Location = New System.Drawing.Point(5, 400)
        Me.CusDeleteButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CusDeleteButton.Name = "CusDeleteButton"
        Me.CusDeleteButton.Padding = New System.Windows.Forms.Padding(8)
        Me.CusDeleteButton.Size = New System.Drawing.Size(83, 50)
        Me.CusDeleteButton.TabIndex = 7
        Me.CusDeleteButton.Text = "Delete"
        Me.CusDeleteButton.UseVisualStyleBackColor = False
        '
        'CusHomeButton
        '
        Me.CusHomeButton.BackColor = System.Drawing.Color.MediumAquamarine
        Me.CusHomeButton.BackgroundImage = CType(resources.GetObject("CusHomeButton.BackgroundImage"), System.Drawing.Image)
        Me.CusHomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CusHomeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CusHomeButton.FlatAppearance.BorderSize = 3
        Me.CusHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CusHomeButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CusHomeButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CusHomeButton.Location = New System.Drawing.Point(201, 333)
        Me.CusHomeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CusHomeButton.Name = "CusHomeButton"
        Me.CusHomeButton.Size = New System.Drawing.Size(83, 50)
        Me.CusHomeButton.TabIndex = 5
        Me.CusHomeButton.Text = "Home"
        Me.CusHomeButton.UseVisualStyleBackColor = False
        '
        'CusEditSaveButton
        '
        Me.CusEditSaveButton.BackColor = System.Drawing.Color.LightBlue
        Me.CusEditSaveButton.BackgroundImage = CType(resources.GetObject("CusEditSaveButton.BackgroundImage"), System.Drawing.Image)
        Me.CusEditSaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CusEditSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CusEditSaveButton.FlatAppearance.BorderSize = 3
        Me.CusEditSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CusEditSaveButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CusEditSaveButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CusEditSaveButton.Location = New System.Drawing.Point(104, 333)
        Me.CusEditSaveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CusEditSaveButton.Name = "CusEditSaveButton"
        Me.CusEditSaveButton.Padding = New System.Windows.Forms.Padding(8)
        Me.CusEditSaveButton.Size = New System.Drawing.Size(83, 50)
        Me.CusEditSaveButton.TabIndex = 6
        Me.CusEditSaveButton.Text = "Edit"
        Me.CusEditSaveButton.UseVisualStyleBackColor = False
        '
        'NewCusButton
        '
        Me.NewCusButton.BackColor = System.Drawing.Color.LightBlue
        Me.NewCusButton.BackgroundImage = CType(resources.GetObject("NewCusButton.BackgroundImage"), System.Drawing.Image)
        Me.NewCusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NewCusButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewCusButton.FlatAppearance.BorderSize = 3
        Me.NewCusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewCusButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewCusButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.NewCusButton.Location = New System.Drawing.Point(5, 333)
        Me.NewCusButton.Margin = New System.Windows.Forms.Padding(2)
        Me.NewCusButton.Name = "NewCusButton"
        Me.NewCusButton.Padding = New System.Windows.Forms.Padding(8)
        Me.NewCusButton.Size = New System.Drawing.Size(83, 50)
        Me.NewCusButton.TabIndex = 0
        Me.NewCusButton.Text = "New"
        Me.NewCusButton.UseVisualStyleBackColor = False
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 583)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(914, 622)
        Me.Name = "Customers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelLogout As Label
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CustomerCount As Label
    Friend WithEvents CustomerDataGridView As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label39 As Label
    Friend WithEvents SearchCusLastNameTextBox As TextBox
    Friend WithEvents Label87 As Label
    Friend WithEvents SearchCusFirstNameTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CusClearButton As Button
    Friend WithEvents CusDeleteButton As Button
    Friend WithEvents CusEditSaveButton As Button
    Friend WithEvents NewCusButton As Button
    Friend WithEvents CusHomeButton As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label102 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents CusCheckBox As CheckBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents CusFirstNameTextBox As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents CusLastNameTextBox As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents CusEmailTextBox As TextBox
    Friend WithEvents CusAddressTextBox As TextBox
    Friend WithEvents CusPhoneTextBox As TextBox
    Friend WithEvents CusZipcodeTextBox As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents CusLastUpdateDateTimePicker As DateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents CusCancelButton As Button
End Class
