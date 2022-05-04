<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.ButtonDiscountHome = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelLogout = New System.Windows.Forms.Label()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.ButtonStaffHome = New System.Windows.Forms.Button()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonDiscountHome
        '
        Me.ButtonDiscountHome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonDiscountHome.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ButtonDiscountHome.BackgroundImage = CType(resources.GetObject("ButtonDiscountHome.BackgroundImage"), System.Drawing.Image)
        Me.ButtonDiscountHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonDiscountHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonDiscountHome.FlatAppearance.BorderSize = 0
        Me.ButtonDiscountHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDiscountHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDiscountHome.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonDiscountHome.Location = New System.Drawing.Point(538, 144)
        Me.ButtonDiscountHome.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDiscountHome.Name = "ButtonDiscountHome"
        Me.ButtonDiscountHome.Size = New System.Drawing.Size(200, 68)
        Me.ButtonDiscountHome.TabIndex = 1
        Me.ButtonDiscountHome.Text = "Discounts"
        Me.ButtonDiscountHome.UseVisualStyleBackColor = False
        '
        'btnCustomer
        '
        Me.btnCustomer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCustomer.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnCustomer.BackgroundImage = CType(resources.GetObject("btnCustomer.BackgroundImage"), System.Drawing.Image)
        Me.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCustomer.FlatAppearance.BorderSize = 0
        Me.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomer.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnCustomer.Location = New System.Drawing.Point(435, 241)
        Me.btnCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(200, 68)
        Me.btnCustomer.TabIndex = 5
        Me.btnCustomer.Text = "Customers"
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMenu.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnMenu.BackgroundImage = CType(resources.GetObject("btnMenu.BackgroundImage"), System.Drawing.Image)
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnMenu.Location = New System.Drawing.Point(296, 344)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(200, 68)
        Me.btnMenu.TabIndex = 7
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Panel2.BackgroundImage = Global.YumYumBento_OrderingSystem.My.Resources.Resources.logo
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.LabelLogout)
        Me.Panel2.Controls.Add(Me.UserNameLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(796, 72)
        Me.Panel2.TabIndex = 1
        '
        'LabelLogout
        '
        Me.LabelLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelLogout.AutoSize = True
        Me.LabelLogout.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.LabelLogout.ForeColor = System.Drawing.Color.LavenderBlush
        Me.LabelLogout.Image = Global.YumYumBento_OrderingSystem.My.Resources.Resources.strip
        Me.LabelLogout.Location = New System.Drawing.Point(707, 26)
        Me.LabelLogout.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelLogout.Name = "LabelLogout"
        Me.LabelLogout.Size = New System.Drawing.Size(57, 19)
        Me.LabelLogout.TabIndex = 1
        Me.LabelLogout.Text = "Log out"
        '
        'UserNameLabel
        '
        Me.UserNameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.UserNameLabel.ForeColor = System.Drawing.Color.LavenderBlush
        Me.UserNameLabel.Image = Global.YumYumBento_OrderingSystem.My.Resources.Resources.strip
        Me.UserNameLabel.Location = New System.Drawing.Point(608, 27)
        Me.UserNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(94, 19)
        Me.UserNameLabel.TabIndex = 0
        Me.UserNameLabel.Text = "<Login User>"
        '
        'btnOrder
        '
        Me.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOrder.BackColor = System.Drawing.Color.LightBlue
        Me.btnOrder.BackgroundImage = CType(resources.GetObject("btnOrder.BackgroundImage"), System.Drawing.Image)
        Me.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOrder.FlatAppearance.BorderSize = 0
        Me.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnOrder.Location = New System.Drawing.Point(59, 144)
        Me.btnOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Padding = New System.Windows.Forms.Padding(8)
        Me.btnOrder.Size = New System.Drawing.Size(200, 68)
        Me.btnOrder.TabIndex = 0
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'ButtonStaffHome
        '
        Me.ButtonStaffHome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonStaffHome.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ButtonStaffHome.BackgroundImage = CType(resources.GetObject("ButtonStaffHome.BackgroundImage"), System.Drawing.Image)
        Me.ButtonStaffHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonStaffHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonStaffHome.FlatAppearance.BorderSize = 0
        Me.ButtonStaffHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStaffHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStaffHome.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonStaffHome.Location = New System.Drawing.Point(161, 241)
        Me.ButtonStaffHome.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonStaffHome.Name = "ButtonStaffHome"
        Me.ButtonStaffHome.Size = New System.Drawing.Size(200, 68)
        Me.ButtonStaffHome.TabIndex = 6
        Me.ButtonStaffHome.Text = "Staff"
        Me.ButtonStaffHome.UseVisualStyleBackColor = False
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffID.Location = New System.Drawing.Point(12, 83)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(89, 38)
        Me.lblStaffID.TabIndex = 50
        Me.lblStaffID.Text = "Staff ID:  , " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Welcome!"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 458)
        Me.Controls.Add(Me.lblStaffID)
        Me.Controls.Add(Me.ButtonDiscountHome)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.ButtonStaffHome)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YumYumBento Ordering System"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents ButtonDiscountHome As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents ButtonStaffHome As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents LabelLogout As Label
    Friend WithEvents lblStaffID As Label
End Class
