<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExitWindows
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExitWindows))
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblDeveloper = New System.Windows.Forms.Label()
        Me.pnlTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.pnlTitle.BackgroundImage = CType(resources.GetObject("pnlTitle.BackgroundImage"), System.Drawing.Image)
        Me.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlTitle.Controls.Add(Me.lblDeveloper)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(483, 93)
        Me.pnlTitle.TabIndex = 14
        '
        'lblDeveloper
        '
        Me.lblDeveloper.AutoSize = True
        Me.lblDeveloper.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblDeveloper.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeveloper.ForeColor = System.Drawing.Color.White
        Me.lblDeveloper.Location = New System.Drawing.Point(483, 0)
        Me.lblDeveloper.Name = "lblDeveloper"
        Me.lblDeveloper.Size = New System.Drawing.Size(0, 19)
        Me.lblDeveloper.TabIndex = 0
        '
        'frmExitWindows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 360)
        Me.Controls.Add(Me.pnlTitle)
        Me.Name = "frmExitWindows"
        Me.Text = "frmExitWindows"
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblDeveloper As Label
End Class
