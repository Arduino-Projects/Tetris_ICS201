<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblScorePrompt = New System.Windows.Forms.Label()
        Me.lblScoreValue = New System.Windows.Forms.Label()
        Me.lblNextPrompt = New System.Windows.Forms.Label()
        Me.lblHoldPrompt = New System.Windows.Forms.Label()
        Me.lblHelpPrompt = New System.Windows.Forms.Label()
        Me.lblLeaderboardPrompt = New System.Windows.Forms.Label()
        Me.lblLeaderName1 = New System.Windows.Forms.Label()
        Me.lblLeaderName2 = New System.Windows.Forms.Label()
        Me.lblLeaderName3 = New System.Windows.Forms.Label()
        Me.lblLeaderName4 = New System.Windows.Forms.Label()
        Me.lblLeaderName5 = New System.Windows.Forms.Label()
        Me.lblLeaderScore1 = New System.Windows.Forms.Label()
        Me.lblLeaderScore2 = New System.Windows.Forms.Label()
        Me.lblLeaderScore3 = New System.Windows.Forms.Label()
        Me.lblLeaderScore4 = New System.Windows.Forms.Label()
        Me.lblLeaderScore5 = New System.Windows.Forms.Label()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.tmrPause = New System.Windows.Forms.Timer(Me.components)
        Me.lblModePrompt = New System.Windows.Forms.Label()
        Me.btnMode = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblBorderL4 = New System.Windows.Forms.Label()
        Me.lblBorderR4 = New System.Windows.Forms.Label()
        Me.lblBorderL3 = New System.Windows.Forms.Label()
        Me.lblBorderR3 = New System.Windows.Forms.Label()
        Me.lblBorderL2 = New System.Windows.Forms.Label()
        Me.lblBorderR2 = New System.Windows.Forms.Label()
        Me.lblBorderL1 = New System.Windows.Forms.Label()
        Me.lblBorderR1 = New System.Windows.Forms.Label()
        Me.lblBorderBottom = New System.Windows.Forms.Label()
        Me.lblBorderTop = New System.Windows.Forms.Label()
        Me.btnHowToPlay = New System.Windows.Forms.Button()
        Me.btnStimulatePrgFocus = New System.Windows.Forms.Button()
        Me.btnStyles = New System.Windows.Forms.Button()
        Me.btnResetLeaderBrds = New System.Windows.Forms.Button()
        Me.ttpStart = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpStyles = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpResetLdb = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpMode = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpCurrentMode = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpHowToPlay = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpCurrentScore = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpNext = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpHold = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpLeaderBoard = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpLeaderBoard = New System.Windows.Forms.GroupBox()
        Me.grpHold = New System.Windows.Forms.GroupBox()
        Me.grpNext = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'lblScorePrompt
        '
        Me.lblScorePrompt.AutoSize = True
        Me.lblScorePrompt.BackColor = System.Drawing.Color.Transparent
        Me.lblScorePrompt.Font = New System.Drawing.Font("Segoe Script", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScorePrompt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblScorePrompt.Location = New System.Drawing.Point(558, 57)
        Me.lblScorePrompt.Name = "lblScorePrompt"
        Me.lblScorePrompt.Size = New System.Drawing.Size(138, 67)
        Me.lblScorePrompt.TabIndex = 0
        Me.lblScorePrompt.Text = "Score"
        '
        'lblScoreValue
        '
        Me.lblScoreValue.AutoSize = True
        Me.lblScoreValue.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreValue.Font = New System.Drawing.Font("Segoe Script", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreValue.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblScoreValue.Location = New System.Drawing.Point(594, 123)
        Me.lblScoreValue.Name = "lblScoreValue"
        Me.lblScoreValue.Size = New System.Drawing.Size(58, 67)
        Me.lblScoreValue.TabIndex = 0
        Me.lblScoreValue.Text = "0"
        Me.lblScoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNextPrompt
        '
        Me.lblNextPrompt.AutoSize = True
        Me.lblNextPrompt.BackColor = System.Drawing.Color.Transparent
        Me.lblNextPrompt.Font = New System.Drawing.Font("Segoe Script", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextPrompt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNextPrompt.Location = New System.Drawing.Point(564, 230)
        Me.lblNextPrompt.Name = "lblNextPrompt"
        Me.lblNextPrompt.Size = New System.Drawing.Size(129, 67)
        Me.lblNextPrompt.TabIndex = 0
        Me.lblNextPrompt.Text = "Next"
        '
        'lblHoldPrompt
        '
        Me.lblHoldPrompt.AutoSize = True
        Me.lblHoldPrompt.BackColor = System.Drawing.Color.Transparent
        Me.lblHoldPrompt.Font = New System.Drawing.Font("Segoe Script", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoldPrompt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHoldPrompt.Location = New System.Drawing.Point(567, 427)
        Me.lblHoldPrompt.Name = "lblHoldPrompt"
        Me.lblHoldPrompt.Size = New System.Drawing.Size(129, 67)
        Me.lblHoldPrompt.TabIndex = 0
        Me.lblHoldPrompt.Text = "Hold"
        '
        'lblHelpPrompt
        '
        Me.lblHelpPrompt.AutoSize = True
        Me.lblHelpPrompt.BackColor = System.Drawing.Color.Transparent
        Me.lblHelpPrompt.Font = New System.Drawing.Font("Segoe Print", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpPrompt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHelpPrompt.Location = New System.Drawing.Point(101, 795)
        Me.lblHelpPrompt.Name = "lblHelpPrompt"
        Me.lblHelpPrompt.Size = New System.Drawing.Size(390, 33)
        Me.lblHelpPrompt.TabIndex = 3
        Me.lblHelpPrompt.Text = "Press ESC the key to pause or for help"
        Me.lblHelpPrompt.Visible = False
        '
        'lblLeaderboardPrompt
        '
        Me.lblLeaderboardPrompt.AutoSize = True
        Me.lblLeaderboardPrompt.BackColor = System.Drawing.Color.Transparent
        Me.lblLeaderboardPrompt.Font = New System.Drawing.Font("Segoe Script", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaderboardPrompt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLeaderboardPrompt.Location = New System.Drawing.Point(848, 450)
        Me.lblLeaderboardPrompt.Name = "lblLeaderboardPrompt"
        Me.lblLeaderboardPrompt.Size = New System.Drawing.Size(295, 67)
        Me.lblLeaderboardPrompt.TabIndex = 0
        Me.lblLeaderboardPrompt.Text = "Leaderboard"
        '
        'lblLeaderName1
        '
        Me.lblLeaderName1.AutoSize = True
        Me.lblLeaderName1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaderName1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLeaderName1.Location = New System.Drawing.Point(830, 522)
        Me.lblLeaderName1.Name = "lblLeaderName1"
        Me.lblLeaderName1.Size = New System.Drawing.Size(0, 30)
        Me.lblLeaderName1.TabIndex = 0
        '
        'lblLeaderName2
        '
        Me.lblLeaderName2.AutoSize = True
        Me.lblLeaderName2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaderName2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLeaderName2.Location = New System.Drawing.Point(830, 558)
        Me.lblLeaderName2.Name = "lblLeaderName2"
        Me.lblLeaderName2.Size = New System.Drawing.Size(0, 30)
        Me.lblLeaderName2.TabIndex = 0
        '
        'lblLeaderName3
        '
        Me.lblLeaderName3.AutoSize = True
        Me.lblLeaderName3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaderName3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLeaderName3.Location = New System.Drawing.Point(830, 592)
        Me.lblLeaderName3.Name = "lblLeaderName3"
        Me.lblLeaderName3.Size = New System.Drawing.Size(0, 30)
        Me.lblLeaderName3.TabIndex = 0
        '
        'lblLeaderName4
        '
        Me.lblLeaderName4.AutoSize = True
        Me.lblLeaderName4.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaderName4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLeaderName4.Location = New System.Drawing.Point(830, 626)
        Me.lblLeaderName4.Name = "lblLeaderName4"
        Me.lblLeaderName4.Size = New System.Drawing.Size(0, 30)
        Me.lblLeaderName4.TabIndex = 0
        '
        'lblLeaderName5
        '
        Me.lblLeaderName5.AutoSize = True
        Me.lblLeaderName5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaderName5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLeaderName5.Location = New System.Drawing.Point(830, 659)
        Me.lblLeaderName5.Name = "lblLeaderName5"
        Me.lblLeaderName5.Size = New System.Drawing.Size(0, 30)
        Me.lblLeaderName5.TabIndex = 0
        '
        'lblLeaderScore1
        '
        Me.lblLeaderScore1.AutoSize = True
        Me.lblLeaderScore1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaderScore1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLeaderScore1.Location = New System.Drawing.Point(1060, 522)
        Me.lblLeaderScore1.Name = "lblLeaderScore1"
        Me.lblLeaderScore1.Size = New System.Drawing.Size(0, 30)
        Me.lblLeaderScore1.TabIndex = 0
        '
        'lblLeaderScore2
        '
        Me.lblLeaderScore2.AutoSize = True
        Me.lblLeaderScore2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaderScore2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLeaderScore2.Location = New System.Drawing.Point(1060, 558)
        Me.lblLeaderScore2.Name = "lblLeaderScore2"
        Me.lblLeaderScore2.Size = New System.Drawing.Size(0, 30)
        Me.lblLeaderScore2.TabIndex = 0
        '
        'lblLeaderScore3
        '
        Me.lblLeaderScore3.AutoSize = True
        Me.lblLeaderScore3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaderScore3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLeaderScore3.Location = New System.Drawing.Point(1060, 592)
        Me.lblLeaderScore3.Name = "lblLeaderScore3"
        Me.lblLeaderScore3.Size = New System.Drawing.Size(0, 30)
        Me.lblLeaderScore3.TabIndex = 0
        '
        'lblLeaderScore4
        '
        Me.lblLeaderScore4.AutoSize = True
        Me.lblLeaderScore4.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaderScore4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLeaderScore4.Location = New System.Drawing.Point(1060, 625)
        Me.lblLeaderScore4.Name = "lblLeaderScore4"
        Me.lblLeaderScore4.Size = New System.Drawing.Size(0, 30)
        Me.lblLeaderScore4.TabIndex = 0
        '
        'lblLeaderScore5
        '
        Me.lblLeaderScore5.AutoSize = True
        Me.lblLeaderScore5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaderScore5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLeaderScore5.Location = New System.Drawing.Point(1060, 658)
        Me.lblLeaderScore5.Name = "lblLeaderScore5"
        Me.lblLeaderScore5.Size = New System.Drawing.Size(0, 30)
        Me.lblLeaderScore5.TabIndex = 0
        '
        'tmrMain
        '
        Me.tmrMain.Interval = 463
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Segoe Script", 70.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInfo.Location = New System.Drawing.Point(505, 612)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(295, 157)
        Me.lblInfo.TabIndex = 6
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrPause
        '
        '
        'lblModePrompt
        '
        Me.lblModePrompt.BackColor = System.Drawing.Color.Transparent
        Me.lblModePrompt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblModePrompt.Font = New System.Drawing.Font("Sitka Small", 27.0!, System.Drawing.FontStyle.Bold)
        Me.lblModePrompt.ForeColor = System.Drawing.SystemColors.Control
        Me.lblModePrompt.Image = Global.TetrisFinalProject.My.Resources.Resources.modeButton
        Me.lblModePrompt.Location = New System.Drawing.Point(1218, 268)
        Me.lblModePrompt.Name = "lblModePrompt"
        Me.lblModePrompt.Size = New System.Drawing.Size(221, 142)
        Me.lblModePrompt.TabIndex = 0
        Me.lblModePrompt.Text = "Endless Mode"
        Me.lblModePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMode
        '
        Me.btnMode.Font = New System.Drawing.Font("Segoe Script", 34.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMode.Image = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnMode.Location = New System.Drawing.Point(860, 268)
        Me.btnMode.Name = "btnMode"
        Me.btnMode.Size = New System.Drawing.Size(221, 140)
        Me.btnMode.TabIndex = 4
        Me.btnMode.Text = "Mode"
        Me.btnMode.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Segoe Script", 34.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPlay.Image = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnPlay.Location = New System.Drawing.Point(860, 55)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(221, 133)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.Text = "Play!"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'lblBorderL4
        '
        Me.lblBorderL4.Image = Global.TetrisFinalProject.My.Resources.Resources.BorderImage
        Me.lblBorderL4.Location = New System.Drawing.Point(32, 569)
        Me.lblBorderL4.Name = "lblBorderL4"
        Me.lblBorderL4.Size = New System.Drawing.Size(65, 174)
        Me.lblBorderL4.TabIndex = 1
        '
        'lblBorderR4
        '
        Me.lblBorderR4.Image = Global.TetrisFinalProject.My.Resources.Resources.BorderImage
        Me.lblBorderR4.Location = New System.Drawing.Point(419, 567)
        Me.lblBorderR4.Name = "lblBorderR4"
        Me.lblBorderR4.Size = New System.Drawing.Size(65, 174)
        Me.lblBorderR4.TabIndex = 1
        '
        'lblBorderL3
        '
        Me.lblBorderL3.Image = Global.TetrisFinalProject.My.Resources.Resources.BorderImage
        Me.lblBorderL3.Location = New System.Drawing.Point(32, 381)
        Me.lblBorderL3.Name = "lblBorderL3"
        Me.lblBorderL3.Size = New System.Drawing.Size(65, 188)
        Me.lblBorderL3.TabIndex = 1
        '
        'lblBorderR3
        '
        Me.lblBorderR3.Image = Global.TetrisFinalProject.My.Resources.Resources.BorderImage
        Me.lblBorderR3.Location = New System.Drawing.Point(419, 379)
        Me.lblBorderR3.Name = "lblBorderR3"
        Me.lblBorderR3.Size = New System.Drawing.Size(65, 188)
        Me.lblBorderR3.TabIndex = 1
        '
        'lblBorderL2
        '
        Me.lblBorderL2.Image = Global.TetrisFinalProject.My.Resources.Resources.BorderImage
        Me.lblBorderL2.Location = New System.Drawing.Point(32, 222)
        Me.lblBorderL2.Name = "lblBorderL2"
        Me.lblBorderL2.Size = New System.Drawing.Size(65, 188)
        Me.lblBorderL2.TabIndex = 1
        '
        'lblBorderR2
        '
        Me.lblBorderR2.Image = Global.TetrisFinalProject.My.Resources.Resources.BorderImage
        Me.lblBorderR2.Location = New System.Drawing.Point(420, 220)
        Me.lblBorderR2.Name = "lblBorderR2"
        Me.lblBorderR2.Size = New System.Drawing.Size(65, 188)
        Me.lblBorderR2.TabIndex = 1
        '
        'lblBorderL1
        '
        Me.lblBorderL1.Image = Global.TetrisFinalProject.My.Resources.Resources.BorderImage
        Me.lblBorderL1.Location = New System.Drawing.Point(32, 29)
        Me.lblBorderL1.Name = "lblBorderL1"
        Me.lblBorderL1.Size = New System.Drawing.Size(65, 191)
        Me.lblBorderL1.TabIndex = 1
        '
        'lblBorderR1
        '
        Me.lblBorderR1.Image = Global.TetrisFinalProject.My.Resources.Resources.BorderImage
        Me.lblBorderR1.Location = New System.Drawing.Point(419, 29)
        Me.lblBorderR1.Name = "lblBorderR1"
        Me.lblBorderR1.Size = New System.Drawing.Size(65, 190)
        Me.lblBorderR1.TabIndex = 1
        '
        'lblBorderBottom
        '
        Me.lblBorderBottom.Image = Global.TetrisFinalProject.My.Resources.Resources.BorderImage
        Me.lblBorderBottom.Location = New System.Drawing.Point(31, 741)
        Me.lblBorderBottom.Name = "lblBorderBottom"
        Me.lblBorderBottom.Size = New System.Drawing.Size(454, 49)
        Me.lblBorderBottom.TabIndex = 1
        '
        'lblBorderTop
        '
        Me.lblBorderTop.Image = Global.TetrisFinalProject.My.Resources.Resources.BorderImage
        Me.lblBorderTop.Location = New System.Drawing.Point(35, 29)
        Me.lblBorderTop.Name = "lblBorderTop"
        Me.lblBorderTop.Size = New System.Drawing.Size(450, 61)
        Me.lblBorderTop.TabIndex = 1
        '
        'btnHowToPlay
        '
        Me.btnHowToPlay.Font = New System.Drawing.Font("Segoe Script", 22.8!, System.Drawing.FontStyle.Bold)
        Me.btnHowToPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnHowToPlay.Image = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnHowToPlay.Location = New System.Drawing.Point(1218, 55)
        Me.btnHowToPlay.Name = "btnHowToPlay"
        Me.btnHowToPlay.Size = New System.Drawing.Size(221, 140)
        Me.btnHowToPlay.TabIndex = 4
        Me.btnHowToPlay.Text = "How To Play"
        Me.btnHowToPlay.UseVisualStyleBackColor = True
        '
        'btnStimulatePrgFocus
        '
        Me.btnStimulatePrgFocus.Location = New System.Drawing.Point(454, 400)
        Me.btnStimulatePrgFocus.Name = "btnStimulatePrgFocus"
        Me.btnStimulatePrgFocus.Size = New System.Drawing.Size(18, 24)
        Me.btnStimulatePrgFocus.TabIndex = 8
        Me.btnStimulatePrgFocus.UseVisualStyleBackColor = True
        '
        'btnStyles
        '
        Me.btnStyles.Font = New System.Drawing.Font("Segoe Script", 30.8!, System.Drawing.FontStyle.Bold)
        Me.btnStyles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStyles.Image = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnStyles.Location = New System.Drawing.Point(1218, 457)
        Me.btnStyles.Name = "btnStyles"
        Me.btnStyles.Size = New System.Drawing.Size(221, 140)
        Me.btnStyles.TabIndex = 4
        Me.btnStyles.Text = "Styles"
        Me.btnStyles.UseVisualStyleBackColor = True
        '
        'btnResetLeaderBrds
        '
        Me.btnResetLeaderBrds.Font = New System.Drawing.Font("Segoe Script", 15.8!, System.Drawing.FontStyle.Bold)
        Me.btnResetLeaderBrds.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnResetLeaderBrds.Image = Global.TetrisFinalProject.My.Resources.Resources.ButtonImage
        Me.btnResetLeaderBrds.Location = New System.Drawing.Point(1218, 639)
        Me.btnResetLeaderBrds.Name = "btnResetLeaderBrds"
        Me.btnResetLeaderBrds.Size = New System.Drawing.Size(221, 140)
        Me.btnResetLeaderBrds.TabIndex = 4
        Me.btnResetLeaderBrds.Text = "Reset Leaderboards"
        Me.btnResetLeaderBrds.UseVisualStyleBackColor = True
        '
        'grpLeaderBoard
        '
        Me.grpLeaderBoard.Location = New System.Drawing.Point(801, 470)
        Me.grpLeaderBoard.Name = "grpLeaderBoard"
        Me.grpLeaderBoard.Size = New System.Drawing.Size(327, 253)
        Me.grpLeaderBoard.TabIndex = 9
        Me.grpLeaderBoard.TabStop = False
        '
        'grpHold
        '
        Me.grpHold.Location = New System.Drawing.Point(514, 443)
        Me.grpHold.Name = "grpHold"
        Me.grpHold.Size = New System.Drawing.Size(212, 170)
        Me.grpHold.TabIndex = 9
        Me.grpHold.TabStop = False
        '
        'grpNext
        '
        Me.grpNext.BackColor = System.Drawing.SystemColors.GrayText
        Me.grpNext.Location = New System.Drawing.Point(514, 254)
        Me.grpNext.Name = "grpNext"
        Me.grpNext.Size = New System.Drawing.Size(212, 170)
        Me.grpNext.TabIndex = 9
        Me.grpNext.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(1592, 835)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnHowToPlay)
        Me.Controls.Add(Me.btnResetLeaderBrds)
        Me.Controls.Add(Me.btnStyles)
        Me.Controls.Add(Me.btnMode)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblHelpPrompt)
        Me.Controls.Add(Me.lblBorderL4)
        Me.Controls.Add(Me.lblBorderR4)
        Me.Controls.Add(Me.lblBorderL3)
        Me.Controls.Add(Me.lblBorderR3)
        Me.Controls.Add(Me.lblBorderL2)
        Me.Controls.Add(Me.lblBorderR2)
        Me.Controls.Add(Me.lblBorderL1)
        Me.Controls.Add(Me.lblBorderR1)
        Me.Controls.Add(Me.lblBorderBottom)
        Me.Controls.Add(Me.lblBorderTop)
        Me.Controls.Add(Me.lblScoreValue)
        Me.Controls.Add(Me.lblLeaderName5)
        Me.Controls.Add(Me.lblLeaderName4)
        Me.Controls.Add(Me.lblLeaderName3)
        Me.Controls.Add(Me.lblLeaderName2)
        Me.Controls.Add(Me.lblLeaderScore5)
        Me.Controls.Add(Me.lblLeaderScore4)
        Me.Controls.Add(Me.lblLeaderScore3)
        Me.Controls.Add(Me.lblLeaderScore2)
        Me.Controls.Add(Me.lblLeaderScore1)
        Me.Controls.Add(Me.lblLeaderName1)
        Me.Controls.Add(Me.lblModePrompt)
        Me.Controls.Add(Me.lblLeaderboardPrompt)
        Me.Controls.Add(Me.lblHoldPrompt)
        Me.Controls.Add(Me.lblNextPrompt)
        Me.Controls.Add(Me.lblScorePrompt)
        Me.Controls.Add(Me.btnStimulatePrgFocus)
        Me.Controls.Add(Me.grpLeaderBoard)
        Me.Controls.Add(Me.grpHold)
        Me.Controls.Add(Me.grpNext)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.Text = "TETRIS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblScorePrompt As Label
    Public WithEvents lblScoreValue As Label
    Friend WithEvents lblNextPrompt As Label
    Friend WithEvents lblHoldPrompt As Label
    Friend WithEvents lblBorderTop As Label
    Friend WithEvents lblBorderR1 As Label
    Friend WithEvents lblBorderR2 As Label
    Friend WithEvents lblBorderR3 As Label
    Friend WithEvents lblBorderR4 As Label
    Friend WithEvents lblBorderL1 As Label
    Friend WithEvents lblBorderL2 As Label
    Friend WithEvents lblBorderL3 As Label
    Friend WithEvents lblBorderL4 As Label
    Friend WithEvents lblBorderBottom As Label
    Friend WithEvents lblHelpPrompt As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnMode As Button
    Friend WithEvents lblLeaderboardPrompt As Label
    Friend WithEvents lblLeaderName1 As Label
    Friend WithEvents lblLeaderName2 As Label
    Friend WithEvents lblLeaderName3 As Label
    Friend WithEvents lblLeaderName4 As Label
    Friend WithEvents lblLeaderName5 As Label
    Friend WithEvents lblLeaderScore1 As Label
    Friend WithEvents lblLeaderScore2 As Label
    Friend WithEvents lblLeaderScore3 As Label
    Friend WithEvents lblLeaderScore4 As Label
    Friend WithEvents lblLeaderScore5 As Label
    Friend WithEvents tmrMain As Timer
    Friend WithEvents lblInfo As Label
    Friend WithEvents tmrPause As Timer
    Friend WithEvents lblModePrompt As Label
    Friend WithEvents btnHowToPlay As Button
    Friend WithEvents btnStimulatePrgFocus As Button
    Friend WithEvents btnStyles As Button
    Friend WithEvents btnResetLeaderBrds As Button
    Friend WithEvents ttpStart As ToolTip
    Friend WithEvents ttpStyles As ToolTip
    Friend WithEvents ttpResetLdb As ToolTip
    Friend WithEvents ttpMode As ToolTip
    Friend WithEvents ttpCurrentMode As ToolTip
    Friend WithEvents ttpHowToPlay As ToolTip
    Friend WithEvents ttpCurrentScore As ToolTip
    Friend WithEvents ttpNext As ToolTip
    Friend WithEvents ttpHold As ToolTip
    Friend WithEvents ttpLeaderBoard As ToolTip
    Friend WithEvents grpLeaderBoard As GroupBox
    Friend WithEvents grpHold As GroupBox
    Friend WithEvents grpNext As GroupBox
End Class
