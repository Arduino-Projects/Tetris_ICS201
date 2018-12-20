' Name: Araad and Daniyaal
' Date: 12/19/18
' Description: Play our unique game of tetris which is similar to the game of original tetris however with more features

Public Class frmMain

    Public quit As Boolean
    Public restart As Boolean
    Public resumeGame As Boolean
    Dim gamePlaying As Boolean
    Public survivalMode As Boolean = False
    Public endlessMode As Boolean = True

    ' Here we declare a new Game as gameMain
    ' This will allow us to use all of the subs inside the game.vb class
    Public gameMain As New Game
    Dim paused As Boolean




    ' This is everything that takes place when the form loads
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gameMain.loadGame()
        ttpStart.SetToolTip(btnPlay, "Start the game")
        ttpHowToPlay.SetToolTip(btnHowToPlay, "Basic rules of Tetris")
        ttpCurrentScore.SetToolTip(lblScoreValue, "Your current Score")
        ttpCurrentMode.SetToolTip(lblModePrompt, "Your current mode")
        ttpHold.SetToolTip(grpHold, "The piece you are currently holding")
        ttpNext.SetToolTip(grpNext, "The piece coming up next")
        ttpResetLdb.SetToolTip(btnResetLeaderBrds, "Reset the leaderboards for both endless and survival mode")
        ttpStyles.SetToolTip(btnStyles, "Change the style of you tetris game such as piece colors and borders")
        ttpMode.SetToolTip(btnMode, "Switch the current mode")
        ttpLeaderBoard.SetToolTip(grpLeaderBoard, "The leaderboard for the current selected mode")
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If Not gamePlaying Then
            gameMain.startGame()
            gamePlaying = True
        Else
            Application.Restart()
        End If


    End Sub

    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        gameMain.tick()
    End Sub

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        paused = gameMain.returnPause
        Select Case e.KeyCode
            Case Keys.Left
                If Not paused Then
                    gameMain.moveLeft()
                End If
            Case Keys.Right
                If Not paused Then
                    gameMain.moveRight()
                End If
            Case Keys.Down
                If Not paused Then
                    gameMain.tick()
                End If
            Case Keys.ShiftKey, Keys.C
                gameMain.hold()
            Case Keys.Space
                If Not paused Then
                    gameMain.spacePress()
                End If
            Case Keys.Up, Keys.X
                If Not paused Then
                    gameMain.rotateClockwise()
                End If
            Case Keys.Escape
                If gameMain.lose = True Then

                Else
                    Dim myForm As New frmPause
                    myForm.Show()
                    My.Computer.Audio.Stop()
                    paused = gameMain.pauseGame()
                    If paused Then
                        tmrMain.Enabled = False
                    Else
                        tmrMain.Enabled = True
                    End If
                End If
        End Select
        e.SuppressKeyPress = True
        e.Handled = True
    End Sub

    Private Sub tmrPause_Tick(sender As Object, e As EventArgs) Handles tmrPause.Tick
        If quit = True Then
            Application.Exit()
        ElseIf restart = True Then
            Application.Restart()
        ElseIf resumeGame = True Then
            resumeGame = False
            My.Computer.Audio.Play(My.Resources.BGMusic, AudioPlayMode.BackgroundLoop)
            tmrMain.Enabled = True
            paused = gameMain.pauseGame()

        End If
        tmrPause.Enabled = False
    End Sub

    Private Sub btnMode_Click(sender As Object, e As EventArgs) Handles btnMode.Click
        If endlessMode Then
            endlessMode = False
            survivalMode = True
        Else
            endlessMode = True
            survivalMode = False
        End If

        If endlessMode Then
            lblModePrompt.Text = "Endless Mode"
            gameMain.readLeaderboard()
            lblScorePrompt.Text = "Score"
            lblScoreValue.Text = "0"
        Else
            lblModePrompt.Text = "Survival Mode"
            gameMain.readLeaderboardSrvl()
            lblScorePrompt.Text = "Level"
            lblScoreValue.Text = ""
        End If
    End Sub

    Private Sub btnHowToPlay_Click(sender As Object, e As EventArgs) Handles btnHowToPlay.Click
        Dim myForm As New frmInstructions
        myForm.Show()
    End Sub

    Private Sub btnStyles_Click(sender As Object, e As EventArgs) Handles btnStyles.Click
        Dim myForm As New frmStyles
        myForm.Show()
    End Sub

    Private Sub btnResetLeaderBrds_Click(sender As Object, e As EventArgs) Handles btnResetLeaderBrds.Click
        My.Settings.TopScores = "Anonymous 0,Anonymous 0,Anonymous 0,Anonymous 0,Anonymous 0,"
        My.Settings.TopScoresSrvl = "Anonymous 0,Anonymous 0,Anonymous 0,Anonymous 0,Anonymous 0,"
        If endlessMode = True Then
            gameMain.readLeaderboard()
        Else
            gameMain.readLeaderboardSrvl()
        End If
    End Sub
End Class
