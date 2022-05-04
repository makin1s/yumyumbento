<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffForm
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
        Me.DBDataGridView = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.RecordToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StaffIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.InActiveButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelLogout = New System.Windows.Forms.Label()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonHome = New System.Windows.Forms.Button()
        CType(Me.DBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBDataGridView
        '
        Me.DBDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DBDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DBDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DBDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DBDataGridView.Location = New System.Drawing.Point(8, 153)
        Me.DBDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.DBDataGridView.Name = "DBDataGridView"
        Me.DBDataGridView.RowTemplate.Height = 28
        Me.DBDataGridView.Size = New System.Drawing.Size(901, 298)
        Me.DBDataGridView.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecordToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 451)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(924, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'RecordToolStripStatusLabel
        '
        Me.RecordToolStripStatusLabel.Name = "RecordToolStripStatusLabel"
        Me.RecordToolStripStatusLabel.Size = New System.Drawing.Size(119, 17)
        Me.RecordToolStripStatusLabel.Text = "ToolStripStatusLabel1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StaffIDTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(387, 91)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(497, 53)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'StaffIDTextBox
        '
        Me.StaffIDTextBox.Location = New System.Drawing.Point(58, 23)
        Me.StaffIDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.StaffIDTextBox.Name = "StaffIDTextBox"
        Me.StaffIDTextBox.Size = New System.Drawing.Size(32, 20)
        Me.StaffIDTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Staff ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(299, 24)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(371, 24)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(101, 20)
        Me.LastNameTextBox.TabIndex = 3
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(182, 23)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(101, 20)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(108, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "First Name:"
        '
        'InActiveButton
        '
        Me.InActiveButton.BackgroundImage = Global.YumYumBento_OrderingSystem.My.Resources.Resources.bg
        Me.InActiveButton.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InActiveButton.ForeColor = System.Drawing.Color.White
        Me.InActiveButton.Location = New System.Drawing.Point(193, 99)
        Me.InActiveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.InActiveButton.Name = "InActiveButton"
        Me.InActiveButton.Size = New System.Drawing.Size(90, 36)
        Me.InActiveButton.TabIndex = 10
        Me.InActiveButton.Text = "InActive"
        Me.InActiveButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.BackgroundImage = Global.YumYumBento_OrderingSystem.My.Resources.Resources.bg
        Me.EditButton.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.ForeColor = System.Drawing.Color.White
        Me.EditButton.Location = New System.Drawing.Point(102, 99)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(2)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(90, 36)
        Me.EditButton.TabIndex = 9
        Me.EditButton.Text = "Edit "
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(26, 76)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Staff Information"
        '
        'NewButton
        '
        Me.NewButton.BackColor = System.Drawing.Color.Chartreuse
        Me.NewButton.BackgroundImage = Global.YumYumBento_OrderingSystem.My.Resources.Resources.bg
        Me.NewButton.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewButton.ForeColor = System.Drawing.Color.White
        Me.NewButton.Location = New System.Drawing.Point(24, 99)
        Me.NewButton.Margin = New System.Windows.Forms.Padding(2)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(90, 36)
        Me.NewButton.TabIndex = 8
        Me.NewButton.Text = "New"
        Me.NewButton.UseVisualStyleBackColor = False
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
        Me.Panel2.Location = New System.Drawing.Point(0, -1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(924, 72)
        Me.Panel2.TabIndex = 15
        '
        'LabelLogout
        '
        Me.LabelLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelLogout.AutoSize = True
        Me.LabelLogout.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.LabelLogout.ForeColor = System.Drawing.Color.LavenderBlush
        Me.LabelLogout.Image = Global.YumYumBento_OrderingSystem.My.Resources.Resources.strip
        Me.LabelLogout.Location = New System.Drawing.Point(831, 25)
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
        Me.UserNameLabel.Location = New System.Drawing.Point(698, 25)
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
        'ButtonHome
        '
        Me.ButtonHome.BackgroundImage = Global.YumYumBento_OrderingSystem.My.Resources.Resources.bg
        Me.ButtonHome.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHome.ForeColor = System.Drawing.Color.White
        Me.ButtonHome.Location = New System.Drawing.Point(287, 99)
        Me.ButtonHome.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Size = New System.Drawing.Size(90, 36)
        Me.ButtonHome.TabIndex = 16
        Me.ButtonHome.Text = "Home"
        Me.ButtonHome.UseVisualStyleBackColor = True
        '
        'StaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 473)
        Me.Controls.Add(Me.ButtonHome)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.InActiveButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.NewButton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DBDataGridView)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "StaffForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff"
        CType(Me.DBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBDataGridView As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents RecordToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StaffIDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents InActiveButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents NewButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelLogout As Label
    Friend WithEvents UserNameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonHome As Button
End Class
