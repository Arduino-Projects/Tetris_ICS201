<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstructions
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
        Me.lblInstructionsHeader = New System.Windows.Forms.Label()
        Me.lblInstructionsCaption = New System.Windows.Forms.Label()
        Me.btnExitInstructions = New System.Windows.Forms.Button()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.lblInstruction = New System.Windows.Forms.Label()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInstructionsHeader
        '
        Me.lblInstructionsHeader.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInstructionsHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblInstructionsHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInstructionsHeader.Font = New System.Drawing.Font("Segoe Script", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblInstructionsHeader.Location = New System.Drawing.Point(12, 9)
        Me.lblInstructionsHeader.Name = "lblInstructionsHeader"
        Me.lblInstructionsHeader.Size = New System.Drawing.Size(939, 93)
        Me.lblInstructionsHeader.TabIndex = 1
        Me.lblInstructionsHeader.Text = "    How To Play Tetris!"
        Me.lblInstructionsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInstructionsCaption
        '
        Me.lblInstructionsCaption.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblInstructionsCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInstructionsCaption.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsCaption.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblInstructionsCaption.Location = New System.Drawing.Point(12, 96)
        Me.lblInstructionsCaption.Name = "lblInstructionsCaption"
        Me.lblInstructionsCaption.Size = New System.Drawing.Size(939, 473)
        Me.lblInstructionsCaption.TabIndex = 2
        Me.lblInstructionsCaption.Text = "Press UP Key or X Key to Rotate the Piece"
        Me.lblInstructionsCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnExitInstructions
        '
        Me.btnExitInstructions.Font = New System.Drawing.Font("Segoe Script", 22.8!, System.Drawing.FontStyle.Bold)
        Me.btnExitInstructions.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExitInstructions.Image = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnExitInstructions.Location = New System.Drawing.Point(693, 23)
        Me.btnExitInstructions.Name = "btnExitInstructions"
        Me.btnExitInstructions.Size = New System.Drawing.Size(241, 67)
        Me.btnExitInstructions.TabIndex = 5
        Me.btnExitInstructions.Text = "Exit"
        Me.btnExitInstructions.UseVisualStyleBackColor = True
        '
        'picMain
        '
        Me.picMain.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picMain.Image = Global.TetrisFinalProject.My.Resources.Resources.DemoPiece
        Me.picMain.Location = New System.Drawing.Point(207, 168)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(504, 341)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMain.TabIndex = 6
        Me.picMain.TabStop = False
        '
        'btnRight
        '
        Me.btnRight.BackgroundImage = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnRight.Font = New System.Drawing.Font("MV Boli", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRight.Location = New System.Drawing.Point(857, 101)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(89, 53)
        Me.btnRight.TabIndex = 7
        Me.btnRight.Text = "->"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.BackgroundImage = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnLeft.Font = New System.Drawing.Font("MV Boli", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLeft.Location = New System.Drawing.Point(24, 104)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(89, 53)
        Me.btnLeft.TabIndex = 7
        Me.btnLeft.Text = "<-"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'lblInstruction
        '
        Me.lblInstruction.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblInstruction.Font = New System.Drawing.Font("Segoe Print", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.Location = New System.Drawing.Point(33, 168)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(901, 363)
        Me.lblInstruction.TabIndex = 8
        Me.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.ClientSize = New System.Drawing.Size(963, 578)
        Me.ControlBox = False
        Me.Controls.Add(Me.picMain)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnExitInstructions)
        Me.Controls.Add(Me.lblInstructionsCaption)
        Me.Controls.Add(Me.lblInstructionsHeader)
        Me.Name = "frmInstructions"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instructions"
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblInstructionsHeader As Label
    Friend WithEvents lblInstructionsCaption As Label
    Friend WithEvents btnExitInstructions As Button
    Friend WithEvents picMain As PictureBox
    Friend WithEvents btnRight As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents lblInstruction As Label
End Class
