<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStyles
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
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnChangeColor = New System.Windows.Forms.Button()
        Me.clrMain = New System.Windows.Forms.ColorDialog()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnResetStyles = New System.Windows.Forms.Button()
        Me.btnBorderSwitcher = New System.Windows.Forms.Button()
        Me.lblBorder = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLeft
        '
        Me.btnLeft.BackgroundImage = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnLeft.Font = New System.Drawing.Font("MV Boli", 55.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLeft.Location = New System.Drawing.Point(30, 362)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(178, 120)
        Me.btnLeft.TabIndex = 0
        Me.btnLeft.Text = "<-"
        Me.btnLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.BackgroundImage = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnRight.Font = New System.Drawing.Font("MV Boli", 55.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRight.Location = New System.Drawing.Point(968, 362)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(180, 120)
        Me.btnRight.TabIndex = 0
        Me.btnRight.Text = "->"
        Me.btnRight.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnChangeColor
        '
        Me.btnChangeColor.BackgroundImage = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnChangeColor.Font = New System.Drawing.Font("MV Boli", 20.8!, System.Drawing.FontStyle.Bold)
        Me.btnChangeColor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnChangeColor.Location = New System.Drawing.Point(505, 371)
        Me.btnChangeColor.Name = "btnChangeColor"
        Me.btnChangeColor.Size = New System.Drawing.Size(188, 102)
        Me.btnChangeColor.TabIndex = 0
        Me.btnChangeColor.Text = "Change Color"
        Me.btnChangeColor.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnChangeColor.UseVisualStyleBackColor = True
        '
        'clrMain
        '
        Me.clrMain.SolidColorOnly = True
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnExit.Font = New System.Drawing.Font("MV Boli", 15.8!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(30, 28)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 43)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnResetStyles
        '
        Me.btnResetStyles.BackgroundImage = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnResetStyles.Font = New System.Drawing.Font("MV Boli", 15.8!, System.Drawing.FontStyle.Bold)
        Me.btnResetStyles.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnResetStyles.Location = New System.Drawing.Point(928, 28)
        Me.btnResetStyles.Name = "btnResetStyles"
        Me.btnResetStyles.Size = New System.Drawing.Size(220, 43)
        Me.btnResetStyles.TabIndex = 0
        Me.btnResetStyles.Text = "Reset Styles"
        Me.btnResetStyles.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnResetStyles.UseVisualStyleBackColor = True
        '
        'btnBorderSwitcher
        '
        Me.btnBorderSwitcher.BackgroundImage = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnBorderSwitcher.Font = New System.Drawing.Font("MV Boli", 15.8!, System.Drawing.FontStyle.Bold)
        Me.btnBorderSwitcher.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBorderSwitcher.Location = New System.Drawing.Point(414, 28)
        Me.btnBorderSwitcher.Name = "btnBorderSwitcher"
        Me.btnBorderSwitcher.Size = New System.Drawing.Size(153, 43)
        Me.btnBorderSwitcher.TabIndex = 0
        Me.btnBorderSwitcher.Text = "Borders:"
        Me.btnBorderSwitcher.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorderSwitcher.UseVisualStyleBackColor = True
        '
        'lblBorder
        '
        Me.lblBorder.AutoSize = True
        Me.lblBorder.Font = New System.Drawing.Font("MV Boli", 15.8!, System.Drawing.FontStyle.Bold)
        Me.lblBorder.Location = New System.Drawing.Point(582, 32)
        Me.lblBorder.Name = "lblBorder"
        Me.lblBorder.Size = New System.Drawing.Size(0, 34)
        Me.lblBorder.TabIndex = 1
        '
        'frmStyles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 507)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblBorder)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnChangeColor)
        Me.Controls.Add(Me.btnBorderSwitcher)
        Me.Controls.Add(Me.btnResetStyles)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLeft)
        Me.Name = "frmStyles"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Styles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLeft As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents btnChangeColor As Button
    Friend WithEvents clrMain As ColorDialog
    Friend WithEvents btnExit As Button
    Friend WithEvents btnResetStyles As Button
    Friend WithEvents btnBorderSwitcher As Button
    Friend WithEvents lblBorder As Label
End Class
