<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPause
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnResume = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnStyles = New System.Windows.Forms.Button()
        Me.lblVolumePrompt = New System.Windows.Forms.Label()
        Me.btnVolUp = New System.Windows.Forms.Button()
        Me.btnVolDown = New System.Windows.Forms.Button()
        Me.btnHowToPlay = New System.Windows.Forms.Button()
        Me.tmrLoadDelay = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TetrisFinalProject.My.Resources.Resources.KeyboardDirections
        Me.PictureBox1.Location = New System.Drawing.Point(100, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(902, 269)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnRestart
        '
        Me.btnRestart.Font = New System.Drawing.Font("Segoe Script", 25.2!, System.Drawing.FontStyle.Bold)
        Me.btnRestart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRestart.Image = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnRestart.Location = New System.Drawing.Point(661, 302)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(268, 102)
        Me.btnRestart.TabIndex = 5
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnResume
        '
        Me.btnResume.Font = New System.Drawing.Font("Segoe Script", 25.2!, System.Drawing.FontStyle.Bold)
        Me.btnResume.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnResume.Image = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnResume.Location = New System.Drawing.Point(12, 302)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(252, 102)
        Me.btnResume.TabIndex = 6
        Me.btnResume.Text = "Resume"
        Me.btnResume.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe Script", 25.2!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Image = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnExit.Location = New System.Drawing.Point(332, 302)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(258, 102)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Quit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnStyles
        '
        Me.btnStyles.Font = New System.Drawing.Font("Segoe Script", 25.2!, System.Drawing.FontStyle.Bold)
        Me.btnStyles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStyles.Image = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnStyles.Location = New System.Drawing.Point(12, 434)
        Me.btnStyles.Name = "btnStyles"
        Me.btnStyles.Size = New System.Drawing.Size(252, 102)
        Me.btnStyles.TabIndex = 6
        Me.btnStyles.Text = "Styles"
        Me.btnStyles.UseVisualStyleBackColor = True
        '
        'lblVolumePrompt
        '
        Me.lblVolumePrompt.AutoSize = True
        Me.lblVolumePrompt.Font = New System.Drawing.Font("MV Boli", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolumePrompt.Location = New System.Drawing.Point(715, 486)
        Me.lblVolumePrompt.Name = "lblVolumePrompt"
        Me.lblVolumePrompt.Size = New System.Drawing.Size(156, 50)
        Me.lblVolumePrompt.TabIndex = 9
        Me.lblVolumePrompt.Text = "Volume"
        '
        'btnVolUp
        '
        Me.btnVolUp.Font = New System.Drawing.Font("MV Boli", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolUp.Location = New System.Drawing.Point(877, 479)
        Me.btnVolUp.Name = "btnVolUp"
        Me.btnVolUp.Size = New System.Drawing.Size(64, 60)
        Me.btnVolUp.TabIndex = 10
        Me.btnVolUp.Text = "+"
        Me.btnVolUp.UseVisualStyleBackColor = True
        '
        'btnVolDown
        '
        Me.btnVolDown.Font = New System.Drawing.Font("MV Boli", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolDown.Location = New System.Drawing.Point(644, 478)
        Me.btnVolDown.Name = "btnVolDown"
        Me.btnVolDown.Size = New System.Drawing.Size(65, 63)
        Me.btnVolDown.TabIndex = 10
        Me.btnVolDown.Text = "-"
        Me.btnVolDown.UseVisualStyleBackColor = True
        '
        'btnHowToPlay
        '
        Me.btnHowToPlay.Font = New System.Drawing.Font("Segoe Script", 17.2!, System.Drawing.FontStyle.Bold)
        Me.btnHowToPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnHowToPlay.Image = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnHowToPlay.Location = New System.Drawing.Point(332, 434)
        Me.btnHowToPlay.Name = "btnHowToPlay"
        Me.btnHowToPlay.Size = New System.Drawing.Size(258, 102)
        Me.btnHowToPlay.TabIndex = 7
        Me.btnHowToPlay.Text = "How To Play"
        Me.btnHowToPlay.UseVisualStyleBackColor = True
        '
        'tmrLoadDelay
        '
        Me.tmrLoadDelay.Interval = 200
        '
        'frmPause
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(956, 593)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVolDown)
        Me.Controls.Add(Me.btnVolUp)
        Me.Controls.Add(Me.lblVolumePrompt)
        Me.Controls.Add(Me.btnHowToPlay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStyles)
        Me.Controls.Add(Me.btnResume)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPause"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pause"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRestart As Button
    Friend WithEvents btnResume As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnStyles As Button
    Friend WithEvents lblVolumePrompt As Label
    Friend WithEvents btnVolUp As Button
    Friend WithEvents btnVolDown As Button
    Friend WithEvents btnHowToPlay As Button
    Friend WithEvents tmrLoadDelay As Timer
End Class
