Public Class Game

    ' Here we declare all of the different colors used for the tetris pieces
    Public gray As Color = Color.LightGray
    Public red As Color = My.Settings.Red
    Public yellow As Color = My.Settings.Yellow
    Public lightBlue As Color = My.Settings.LightBlue
    Public green As Color = My.Settings.Green
    Public orange As Color = My.Settings.Orange
    Public purple As Color = My.Settings.Purple
    Public blue As Color = My.Settings.Blue
    Public border As BorderStyle = My.Settings.Border

    ' Here we declare the dimensions of the grid
    Const sizeX As Integer = 10
    Const sizeY As Integer = 22

    ' Here we declare the actual grid, next piece grid, and hold piece grid that we are using as - PictureBox
    ' We subtract 1 because the array starts at 0 and goes to the size value, which will give us 1 extr- row and Columnn
    Public gridMain(sizeY - 1, sizeX - 1) As PictureBox
    Public gridNext(3, 3) As PictureBox
    Public gridHold(3, 3) As PictureBox

    ' These are the variables in which the leaderboard dat- is read and stored in
    Dim leaderName(4) As String
    Dim leaderScore(4) As String
    Dim leaderScoreNum(4) As Integer

    Dim leaderNameSrvl(4) As String
    Dim leaderScoreSrvl(4) As String
    Dim leaderScoreNumSrvl(4) As Integer

    ' These are variables used to read the leaderboard text file
    Dim fileReader As String
    Dim refIndex As Integer
    Dim paused As Boolean

    'These variables hold the coordinates for the grid, and the other data of the pieces
    Dim CoordinateX(3) As Integer
    Dim CoordinateY(3) As Integer

    Dim CoordinateNextX(3) As Integer
    Dim CoordinateNextY(3) As Integer

    Dim CoordinateHoldX(3) As Integer
    Dim CoordinateHoldY(3) As Integer

    Dim held As Boolean
    Dim currentPiece As Integer
    Dim currentRotation As Integer
    Dim nextPiece As Integer
    Dim holdPiece As Integer
    Dim firstHold As Boolean
    Public lose As Boolean
    Dim score As Long
    Dim tetris As Boolean
    Dim triple As Boolean
    Dim clearInfo As Integer
    Dim level As Integer
    Dim dropSpeed As Integer = 500


    'These are all of the subs that occur when this Sub is called
    Public Sub loadGame()

        Randomize()
        createMap()
        createNextMap()
        createHoldMap()
        readLeaderboard()
        'setBackground()


    End Sub




    Public Sub hold()
        If Not lose Then
            If held = 0 Then
                If holdPiece = 0 Then
                    firstHold = True
                    held = True
                    eraseMainPiece()
                    holdPiece = currentPiece
                    createNewPiece()


                Else
                    held = True
                    eraseHoldPiece()
                    firstHold = False
                    eraseMainPiece()
                    Dim holder As Integer
                    holder = currentPiece
                    currentPiece = holdPiece
                    holdPiece = holder

                    createNewPiece()
                End If

                drawHoldPiece()
            End If
        End If
    End Sub

    Public Function pauseGame()
        If Not lose Then
            If paused Then
                paused = 0
                Return 0
            Else
                paused = 1
                Return 1

            End If
        End If
    End Function

    Public Function returnPause()
        Return paused
    End Function
    Public Sub startGame()
        If frmMain.survivalMode Then
            frmMain.lblScoreValue.Text = "1"
        End If
        paused = True
        frmMain.lblHelpPrompt.Visible = True
        nextPiece = pseudoRandomizePiece()
        frmMain.btnStyles.Enabled = False
        frmMain.btnMode.Enabled = False
        frmMain.btnResetLeaderBrds.Enabled = False
        frmMain.btnHowToPlay.Enabled = False
        frmMain.btnPlay.Enabled = False
        countdownTimer()
        paused = False
        frmMain.btnStimulatePrgFocus.Enabled = False
        drawNextPiece()
        frmMain.grpNext.SendToBack()
        frmMain.grpHold.SendToBack()
        createNewPiece()

        frmMain.tmrMain.Enabled = True
    End Sub

    Public Sub countdownTimer()
        frmMain.lblInfo.Text = "3"

        My.Application.DoEvents()
        System.Threading.Thread.Sleep(1000)
        frmMain.lblInfo.Text = "2"

        My.Application.DoEvents()
        System.Threading.Thread.Sleep(1000)
        frmMain.lblInfo.Text = "1"



        My.Application.DoEvents()
        System.Threading.Thread.Sleep(1000)
        startMusic()
        frmMain.lblInfo.Font = New Font("Segoe Script", 50, FontStyle.Bold)
        frmMain.lblInfo.Text = "START!"
    End Sub

    Public Sub removeInfoText()
        frmMain.lblInfo.Text = ""
    End Sub

    Public Sub tick()


        If frmMain.lblInfo.Text <> "" And clearInfo = 4 Then
            removeInfoText()
        End If
        clearInfo += 1
        If lose Then
        Else
            eraseMainPiece()
            For counter = 0 To 3
                CoordinateY(counter) += 1
            Next
            If piecesCollide() Then
                For counter = 0 To 3
                    CoordinateY(counter) -= 1
                Next
                drawMainPiece()
                occupyLocations()
                checkRowClear()
                createNewPiece()
            End If
            drawMainPiece()
        End If
    End Sub

    Public Sub spacePress()
        If Not lose Then
            Dim reachedBottom As Boolean
            Do
                eraseMainPiece()
                For counter = 0 To 3
                    CoordinateY(counter) += 1
                Next
                If piecesCollide() Then
                    For counter = 0 To 3
                        CoordinateY(counter) -= 1
                    Next
                    reachedBottom = True
                    drawMainPiece()
                    occupyLocations()
                    checkRowClear()
                    createNewPiece()
                End If
                drawMainPiece()
            Loop Until reachedBottom
        End If
    End Sub


    Public Sub rotateClockwise()
        If Not lose Then
            eraseMainPiece()
            Select Case currentPiece
                Case 1

                Case 2

                    If currentRotation = 1 Then
                        CoordinateX(1) = CoordinateX(0)
                        CoordinateY(1) = CoordinateY(0) + 1
                        CoordinateX(2) = CoordinateX(0)
                        CoordinateY(2) = CoordinateY(0) - 1
                        CoordinateX(3) = CoordinateX(0)
                        CoordinateY(3) = CoordinateY(0) - 2

                    ElseIf currentRotation = 2 Then
                        CoordinateX(0) = CoordinateX(3) + 3
                        CoordinateY(0) = CoordinateY(3)
                        CoordinateX(1) = CoordinateX(3) + 2
                        CoordinateY(1) = CoordinateY(3)
                        CoordinateX(2) = CoordinateX(3) + 1
                        CoordinateY(2) = CoordinateY(3)


                    ElseIf currentRotation = 3 Then
                        CoordinateX(1) = CoordinateX(0)
                        CoordinateX(2) = CoordinateX(0)
                        CoordinateX(3) = CoordinateX(0)
                        CoordinateY(1) = CoordinateY(0) + 1
                        CoordinateY(2) = CoordinateY(0) + 2
                        CoordinateY(3) = CoordinateY(0) + 3

                    ElseIf currentRotation = 4 Then
                        CoordinateX(0) = CoordinateX(2) - 3
                        CoordinateX(1) = CoordinateX(2) - 2
                        CoordinateX(2) = CoordinateX(1) + 1
                        CoordinateX(3) = CoordinateX(2) + 1
                        CoordinateY(0) = CoordinateY(2)
                        CoordinateY(1) = CoordinateY(2)
                        CoordinateY(3) = CoordinateY(2)
                    End If


                    sideCheck()

                    If piecesCollide() Then

                        If currentRotation = 1 Then
                            CoordinateX(1) = CoordinateX(0)
                            CoordinateY(1) = CoordinateY(0) - 1
                            CoordinateX(2) = CoordinateX(0)
                            CoordinateY(2) = CoordinateY(0) + 1
                            CoordinateX(3) = CoordinateX(0)
                            CoordinateY(3) = CoordinateY(0) + 2

                        ElseIf currentRotation = 2 Then
                            CoordinateX(0) = CoordinateX(3) - 3
                            CoordinateY(0) = CoordinateY(3)
                            CoordinateX(1) = CoordinateX(3) - 2
                            CoordinateY(1) = CoordinateY(3)
                            CoordinateX(2) = CoordinateX(3) - 1
                            CoordinateY(2) = CoordinateY(3)


                        ElseIf currentRotation = 3 Then
                            CoordinateX(1) = CoordinateX(0)
                            CoordinateX(2) = CoordinateX(0)
                            CoordinateX(3) = CoordinateX(0)
                            CoordinateY(1) = CoordinateY(0) - 1
                            CoordinateY(2) = CoordinateY(0) - 2
                            CoordinateY(3) = CoordinateY(0) - 3

                        ElseIf currentRotation = 4 Then
                            CoordinateX(0) = CoordinateX(2) + 3
                            CoordinateX(1) = CoordinateX(2) + 2
                            CoordinateX(2) = CoordinateX(1) - 1
                            CoordinateX(3) = CoordinateX(2) - 1
                            CoordinateY(0) = CoordinateY(2)
                            CoordinateY(1) = CoordinateY(2)
                            CoordinateY(3) = CoordinateY(2)
                        End If

                    End If

                Case 3

                    If currentRotation = 1 Then
                        CoordinateX(2) = CoordinateX(2) - 1
                        CoordinateX(3) = CoordinateX(3) - 1
                        CoordinateY(3) = CoordinateY(3) - 2
                    ElseIf currentRotation = 2 Then
                        CoordinateX(2) = CoordinateX(2) + 1
                        CoordinateX(3) = CoordinateX(3) + 1
                        CoordinateY(3) = CoordinateY(3) + 2
                    ElseIf currentRotation = 3 Then
                        CoordinateX(2) = CoordinateX(2) - 1
                        CoordinateX(3) = CoordinateX(3) - 1
                        CoordinateY(3) = CoordinateY(3) - 2
                    ElseIf currentRotation = 4 Then
                        CoordinateX(2) = CoordinateX(2) + 1
                        CoordinateX(3) = CoordinateX(3) + 1
                        CoordinateY(3) = CoordinateY(3) + 2
                    End If

                    sideCheck()
                    If piecesCollide() Then

                        If currentRotation = 1 Then
                            CoordinateX(2) = CoordinateX(2) + 1
                            CoordinateX(3) = CoordinateX(3) + 1
                            CoordinateY(3) = CoordinateY(3) + 2
                        ElseIf currentRotation = 2 Then
                            CoordinateX(2) = CoordinateX(2) - 1
                            CoordinateX(3) = CoordinateX(3) - 1
                            CoordinateY(3) = CoordinateY(3) - 2
                        ElseIf currentRotation = 3 Then
                            CoordinateX(2) = CoordinateX(2) + 1
                            CoordinateX(3) = CoordinateX(3) + 1
                            CoordinateY(3) = CoordinateY(3) + 2
                        ElseIf currentRotation = 4 Then
                            CoordinateX(2) = CoordinateX(2) - 1
                            CoordinateX(3) = CoordinateX(3) - 1
                            CoordinateY(3) = CoordinateY(3) - 2
                        End If

                    End If

                Case 4

                    If currentRotation = 1 Then
                        CoordinateX(0) = CoordinateX(0) - 2
                        CoordinateY(0) = CoordinateY(0) - 1
                        CoordinateY(3) = CoordinateY(3) - 1
                    ElseIf currentRotation = 2 Then
                        CoordinateX(0) = CoordinateX(0) + 2
                        CoordinateY(0) = CoordinateY(0) + 1
                        CoordinateY(3) = CoordinateY(3) + 1
                    ElseIf currentRotation = 3 Then
                        CoordinateX(0) = CoordinateX(0) - 2
                        CoordinateY(0) = CoordinateY(0) - 1
                        CoordinateY(3) = CoordinateY(3) - 1
                    ElseIf currentRotation = 4 Then
                        CoordinateX(0) = CoordinateX(0) + 2
                        CoordinateY(0) = CoordinateY(0) + 1
                        CoordinateY(3) = CoordinateY(3) + 1
                    End If


                    sideCheck()

                    If piecesCollide() Then

                        If currentRotation = 1 Then
                            CoordinateX(0) = CoordinateX(0) + 2
                            CoordinateY(0) = CoordinateY(0) + 1
                            CoordinateY(3) = CoordinateY(3) + 1
                        ElseIf currentRotation = 2 Then
                            CoordinateX(0) = CoordinateX(0) - 2
                            CoordinateY(0) = CoordinateY(0) - 1
                            CoordinateY(3) = CoordinateY(3) - 1
                        ElseIf currentRotation = 3 Then
                            CoordinateX(0) = CoordinateX(0) + 2
                            CoordinateY(0) = CoordinateY(0) + 1
                            CoordinateY(3) = CoordinateY(3) + 1
                        ElseIf currentRotation = 4 Then
                            CoordinateX(0) = CoordinateX(0) - 2
                            CoordinateY(0) = CoordinateY(0) - 1
                            CoordinateY(3) = CoordinateY(3) - 1
                        End If

                    End If



                Case 5

                    If currentRotation = 1 Then
                        CoordinateX(2) = CoordinateX(2) - 1
                        CoordinateX(3) = CoordinateX(3) - 2
                        CoordinateY(2) = CoordinateY(2) - 1
                        CoordinateY(3) = CoordinateY(3) - 2
                    ElseIf currentRotation = 2 Then
                        CoordinateX(1) = CoordinateX(1) + 2
                        CoordinateY(1) = CoordinateY(1) - 2
                        CoordinateX(2) = CoordinateX(2) + 1
                        CoordinateY(2) = CoordinateY(2) - 1

                    ElseIf currentRotation = 3 Then
                        CoordinateX(2) = CoordinateX(2) + 1
                        CoordinateY(2) = CoordinateY(2) + 1
                        CoordinateX(3) = CoordinateX(3) + 2
                        CoordinateY(3) = CoordinateY(3) + 2
                    ElseIf currentRotation = 4 Then
                        CoordinateX(2) = CoordinateX(2) - 1
                        CoordinateY(2) = CoordinateY(2) + 1
                        CoordinateX(1) = CoordinateX(1) - 2
                        CoordinateY(1) = CoordinateY(1) + 2

                    End If

                    sideCheck()
                    If piecesCollide() Then

                        If currentRotation = 1 Then
                            CoordinateX(2) = CoordinateX(2) + 1
                            CoordinateX(3) = CoordinateX(3) + 2
                            CoordinateY(2) = CoordinateY(2) + 1
                            CoordinateY(3) = CoordinateY(3) + 2
                        ElseIf currentRotation = 2 Then
                            CoordinateX(1) = CoordinateX(1) - 2
                            CoordinateY(1) = CoordinateY(1) + 2
                            CoordinateX(2) = CoordinateX(2) - 1
                            CoordinateY(2) = CoordinateY(2) + 1

                        ElseIf currentRotation = 3 Then
                            CoordinateX(2) = CoordinateX(2) - 1
                            CoordinateY(2) = CoordinateY(2) - 1
                            CoordinateX(3) = CoordinateX(3) - 2
                            CoordinateY(3) = CoordinateY(3) - 2
                        ElseIf currentRotation = 4 Then
                            CoordinateX(2) = CoordinateX(2) + 1
                            CoordinateY(2) = CoordinateY(2) - 1
                            CoordinateX(1) = CoordinateX(1) + 2
                            CoordinateY(1) = CoordinateY(1) - 2

                        End If

                    End If

                Case 6


                    If currentRotation = 1 Then
                        CoordinateY(0) = CoordinateY(0) + 1
                        CoordinateX(1) = CoordinateX(1) - 1
                        CoordinateY(2) = CoordinateY(2) - 1
                        CoordinateX(3) = CoordinateX(3) + 1
                        CoordinateY(3) = CoordinateY(3) - 2
                    ElseIf currentRotation = 2 Then
                        CoordinateX(0) = CoordinateX(0) - 2
                        CoordinateX(1) = CoordinateX(1) - 1
                        CoordinateY(1) = CoordinateY(1) - 1
                        CoordinateX(3) = CoordinateX(3) + 1
                        CoordinateY(3) = CoordinateY(3) + 1


                    ElseIf currentRotation = 3 Then

                        CoordinateY(3) = CoordinateY(3) + 1
                        CoordinateX(2) = CoordinateX(2) + 1
                        CoordinateX(1) = CoordinateX(1) + 2
                        CoordinateY(1) = CoordinateY(1) - 1
                        CoordinateX(0) = CoordinateX(0) + 1
                        CoordinateY(0) = CoordinateY(0) - 2

                    ElseIf currentRotation = 4 Then

                        CoordinateX(0) = CoordinateX(0) + 1
                        CoordinateY(0) = CoordinateY(0) + 1
                        CoordinateY(1) = CoordinateY(1) + 2
                        CoordinateX(2) = CoordinateX(2) - 1
                        CoordinateY(2) = CoordinateY(2) + 1
                        CoordinateX(3) = CoordinateX(3) - 2

                    End If

                    sideCheck()
                    If piecesCollide() Then

                        If currentRotation = 1 Then
                            CoordinateY(0) = CoordinateY(0) - 1
                            CoordinateX(1) = CoordinateX(1) + 1
                            CoordinateY(2) = CoordinateY(2) + 1
                            CoordinateX(3) = CoordinateX(3) - 1
                            CoordinateY(3) = CoordinateY(3) + 2
                        ElseIf currentRotation = 2 Then
                            CoordinateX(0) = CoordinateX(0) + 2
                            CoordinateX(1) = CoordinateX(1) + 1
                            CoordinateY(1) = CoordinateY(1) + 1
                            CoordinateX(3) = CoordinateX(3) - 1
                            CoordinateY(3) = CoordinateY(3) - 1


                        ElseIf currentRotation = 3 Then

                            CoordinateY(3) = CoordinateY(3) - 1
                            CoordinateX(2) = CoordinateX(2) - 1
                            CoordinateX(1) = CoordinateX(1) - 2
                            CoordinateY(1) = CoordinateY(1) + 1
                            CoordinateX(0) = CoordinateX(0) - 1
                            CoordinateY(0) = CoordinateY(0) + 2

                        ElseIf currentRotation = 4 Then

                            CoordinateX(0) = CoordinateX(0) - 1
                            CoordinateY(0) = CoordinateY(0) - 1
                            CoordinateY(1) = CoordinateY(1) - 2
                            CoordinateX(2) = CoordinateX(2) + 1
                            CoordinateY(2) = CoordinateY(2) - 1
                            CoordinateX(3) = CoordinateX(3) + 2

                        End If

                    End If
                Case 7

                    If currentRotation = 1 Then
                        CoordinateX(0) = CoordinateX(0) + 2
                        CoordinateY(0) = CoordinateY(0) - 1
                        CoordinateX(1) = CoordinateX(1) + 1
                        CoordinateY(1) = CoordinateY(1) - 2
                        CoordinateY(2) = CoordinateY(2) - 1
                        CoordinateX(3) = CoordinateX(3) - 1

                    ElseIf currentRotation = 2 Then
                        CoordinateY(0) = CoordinateY(0) + 2
                        CoordinateX(1) = CoordinateX(1) + 1
                        CoordinateY(1) = CoordinateY(1) + 1
                        CoordinateX(3) = CoordinateX(3) - 1
                        CoordinateY(3) = CoordinateY(3) - 1


                    ElseIf currentRotation = 3 Then

                        CoordinateX(0) = CoordinateX(0) - 2
                        CoordinateX(1) = CoordinateX(1) - 1
                        CoordinateY(1) = CoordinateY(1) + 1
                        CoordinateX(3) = CoordinateX(3) + 1
                        CoordinateY(3) = CoordinateY(3) - 1

                    ElseIf currentRotation = 4 Then

                        CoordinateY(0) = CoordinateY(0) - 1
                        CoordinateX(1) = CoordinateX(1) - 1
                        CoordinateY(2) = CoordinateY(2) + 1
                        CoordinateX(3) = CoordinateX(3) + 1
                        CoordinateY(3) = CoordinateY(3) + 2

                    End If
                    sideCheck()
                    If piecesCollide() Then


                        If currentRotation = 1 Then
                            CoordinateX(0) = CoordinateX(0) - 2
                            CoordinateY(0) = CoordinateY(0) + 1
                            CoordinateX(1) = CoordinateX(1) - 1
                            CoordinateY(1) = CoordinateY(1) + 2
                            CoordinateY(2) = CoordinateY(2) + 1
                            CoordinateX(3) = CoordinateX(3) + 1

                        ElseIf currentRotation = 2 Then
                            CoordinateY(0) = CoordinateY(0) - 2
                            CoordinateX(1) = CoordinateX(1) - 1
                            CoordinateY(1) = CoordinateY(1) - 1
                            CoordinateX(3) = CoordinateX(3) + 1
                            CoordinateY(3) = CoordinateY(3) + 1


                        ElseIf currentRotation = 3 Then

                            CoordinateX(0) = CoordinateX(0) + 2
                            CoordinateX(1) = CoordinateX(1) + 1
                            CoordinateY(1) = CoordinateY(1) - 1
                            CoordinateX(3) = CoordinateX(3) - 1
                            CoordinateY(3) = CoordinateY(3) + 1

                        ElseIf currentRotation = 4 Then

                            CoordinateY(0) = CoordinateY(0) + 1
                            CoordinateX(1) = CoordinateX(1) + 1
                            CoordinateY(2) = CoordinateY(2) - 1
                            CoordinateX(3) = CoordinateX(3) - 1
                            CoordinateY(3) = CoordinateY(3) - 2

                        End If

                    End If
            End Select


            drawMainPiece()
            currentRotation += 1
            If currentRotation = 5 Then
                currentRotation = 1
            End If
        End If
    End Sub

    Private Sub startMusic()
        My.Computer.Audio.Play(My.Resources.BGMusic, AudioPlayMode.BackgroundLoop)
    End Sub


    Public Sub moveLeft()
        If Not lose Then
            eraseMainPiece()

            For counter = 0 To 3

                CoordinateX(counter) -= 1

            Next

            sideCheck()
            If piecesCollide() Then
                For counter = 0 To 3

                    CoordinateX(counter) += 1

                Next
            End If
            drawMainPiece()
        End If
    End Sub

    Public Sub moveRight()
        If Not lose Then
            eraseMainPiece()
            For counter = 0 To 3

                CoordinateX(counter) += 1

            Next

            sideCheck()
            If piecesCollide() Then
                Do
                    For counter = 0 To 3

                        CoordinateX(counter) -= 1

                    Next
                Loop While piecesCollide()
            End If
            drawMainPiece()
        End If
    End Sub

    ' This Sub displays all of the leaderboard dat- on the form
    Public Sub readLeaderboard()

        fileReader = My.Settings.TopScores


        For counter As Integer = 0 To 4
            readEncodedLeaderboard(counter)
        Next counter



        frmMain.lblLeaderName1.Text = leaderName(0)
        frmMain.lblLeaderScore1.Text = leaderScore(0)
        frmMain.lblLeaderName2.Text = leaderName(1)
        frmMain.lblLeaderScore2.Text = leaderScore(1)
        frmMain.lblLeaderName3.Text = leaderName(2)
        frmMain.lblLeaderScore3.Text = leaderScore(2)
        frmMain.lblLeaderName4.Text = leaderName(3)
        frmMain.lblLeaderScore4.Text = leaderScore(3)
        frmMain.lblLeaderName5.Text = leaderName(4)
        frmMain.lblLeaderScore5.Text = leaderScore(4)

        For counter As Integer = 0 To 4
            leaderScoreNum(counter) = Val(leaderScore(counter))
        Next

    End Sub


    Public Sub readLeaderboardSrvl()
        fileReader = My.Settings.TopScoresSrvl


        For counter As Integer = 0 To 4
            readSrvlEncodedLeaderboard(counter)
        Next counter



        frmMain.lblLeaderName1.Text = leaderNameSrvl(0)
        frmMain.lblLeaderScore1.Text = leaderScoreSrvl(0)
        frmMain.lblLeaderName2.Text = leaderNameSrvl(1)
        frmMain.lblLeaderScore2.Text = leaderScoreSrvl(1)
        frmMain.lblLeaderName3.Text = leaderNameSrvl(2)
        frmMain.lblLeaderScore3.Text = leaderScoreSrvl(2)
        frmMain.lblLeaderName4.Text = leaderNameSrvl(3)
        frmMain.lblLeaderScore4.Text = leaderScoreSrvl(3)
        frmMain.lblLeaderName5.Text = leaderNameSrvl(4)
        frmMain.lblLeaderScore5.Text = leaderScoreSrvl(4)

        For counter As Integer = 0 To 4
            leaderScoreNumSrvl(counter) = Val(leaderScoreSrvl(counter))
        Next
    End Sub



    ' This Sub reads the encoded leaderBoard file and assigns it to the values which hold the leaderboard details
    Private Sub readEncodedLeaderboard(ByVal value As Integer)
        fileReader = fileReader.Trim()
        refIndex = fileReader.IndexOf(" ")
        leaderName(value) = fileReader
        leaderName(value) = leaderName(value).Replace(fileReader.Substring(refIndex), "")
        fileReader = fileReader.Remove(0, leaderName(value).Length())
        fileReader = fileReader.Trim()
        leaderScore(value) = fileReader
        refIndex = fileReader.IndexOf(",")
        leaderScore(value) = leaderScore(value).Replace(fileReader.Substring(refIndex), "")
        fileReader = fileReader.Remove(0, leaderScore(value).Length() + 1)
    End Sub

    Private Sub readSrvlEncodedLeaderboard(ByVal value As Integer)
        fileReader = fileReader.Trim()
        refIndex = fileReader.IndexOf(" ")
        leaderNameSrvl(value) = fileReader
        leaderNameSrvl(value) = leaderNameSrvl(value).Replace(fileReader.Substring(refIndex), "")
        fileReader = fileReader.Remove(0, leaderNameSrvl(value).Length())
        fileReader = fileReader.Trim()
        leaderScoreSrvl(value) = fileReader
        refIndex = fileReader.IndexOf(",")
        leaderScoreSrvl(value) = leaderScoreSrvl(value).Replace(fileReader.Substring(refIndex), "")
        fileReader = fileReader.Remove(0, leaderScoreSrvl(value).Length() + 1)
    End Sub

    Private Sub drawNextPiece()
        If Not lose Then
            For row As Integer = 0 To 3
                For Column As Integer = 0 To 3
                    gridNext(row, Column).BackColor = gray
                    gridNext(row, Column).Visible = False
                Next Column
            Next row
            Select Case nextPiece
                Case 1
                    gridNext(1, 1).Visible = True
                    gridNext(1, 2).Visible = True
                    gridNext(2, 1).Visible = True
                    gridNext(2, 2).Visible = True
                    gridNext(1, 1).BackColor = yellow
                    gridNext(1, 2).BackColor = yellow
                    gridNext(2, 1).BackColor = yellow
                    gridNext(2, 2).BackColor = yellow

                Case 2
                    gridNext(2, 0).Visible = True
                    gridNext(2, 1).Visible = True
                    gridNext(2, 2).Visible = True
                    gridNext(2, 3).Visible = True
                    gridNext(2, 0).BackColor = lightBlue
                    gridNext(2, 1).BackColor = lightBlue
                    gridNext(2, 2).BackColor = lightBlue
                    gridNext(2, 3).BackColor = lightBlue

                Case 3
                    gridNext(1, 1).Visible = True
                    gridNext(1, 2).Visible = True
                    gridNext(2, 2).Visible = True
                    gridNext(2, 3).Visible = True
                    gridNext(1, 1).BackColor = red
                    gridNext(1, 2).BackColor = red
                    gridNext(2, 2).BackColor = red
                    gridNext(2, 3).BackColor = red

                Case 4
                    gridNext(1, 2).Visible = True
                    gridNext(1, 1).Visible = True
                    gridNext(2, 1).Visible = True
                    gridNext(2, 0).Visible = True
                    gridNext(1, 2).BackColor = green
                    gridNext(1, 1).BackColor = green
                    gridNext(2, 1).BackColor = green
                    gridNext(2, 0).BackColor = green

                Case 5
                    gridNext(2, 0).Visible = True
                    gridNext(2, 1).Visible = True
                    gridNext(2, 2).Visible = True
                    gridNext(1, 1).Visible = True
                    gridNext(2, 0).BackColor = purple
                    gridNext(2, 1).BackColor = purple
                    gridNext(2, 2).BackColor = purple
                    gridNext(1, 1).BackColor = purple

                Case 6
                    gridNext(2, 0).Visible = True
                    gridNext(2, 1).Visible = True
                    gridNext(2, 2).Visible = True
                    gridNext(1, 2).Visible = True
                    gridNext(2, 0).BackColor = orange
                    gridNext(2, 1).BackColor = orange
                    gridNext(2, 2).BackColor = orange
                    gridNext(1, 2).BackColor = orange

                Case 7
                    gridNext(1, 0).Visible = True
                    gridNext(2, 0).Visible = True
                    gridNext(2, 1).Visible = True
                    gridNext(2, 2).Visible = True
                    gridNext(1, 0).BackColor = blue
                    gridNext(2, 0).BackColor = blue
                    gridNext(2, 1).BackColor = blue
                    gridNext(2, 2).BackColor = blue

            End Select
        End If
    End Sub

    Private Sub drawHoldPiece()
        For row As Integer = 0 To 3
            For Column As Integer = 0 To 3
                gridHold(row, Column).BackColor = gray
                gridHold(row, Column).Visible = False
            Next Column
        Next row
        Select Case holdPiece
            Case 1
                gridHold(1, 1).Visible = True
                gridHold(1, 2).Visible = True
                gridHold(2, 1).Visible = True
                gridHold(2, 2).Visible = True
                gridHold(1, 1).BackColor = yellow
                gridHold(1, 2).BackColor = yellow
                gridHold(2, 1).BackColor = yellow
                gridHold(2, 2).BackColor = yellow

            Case 2
                gridHold(2, 0).Visible = True
                gridHold(2, 1).Visible = True
                gridHold(2, 2).Visible = True
                gridHold(2, 3).Visible = True
                gridHold(2, 0).BackColor = lightBlue
                gridHold(2, 1).BackColor = lightBlue
                gridHold(2, 2).BackColor = lightBlue
                gridHold(2, 3).BackColor = lightBlue

            Case 3
                gridHold(1, 1).Visible = True
                gridHold(1, 2).Visible = True
                gridHold(2, 2).Visible = True
                gridHold(2, 3).Visible = True
                gridHold(1, 1).BackColor = red
                gridHold(1, 2).BackColor = red
                gridHold(2, 2).BackColor = red
                gridHold(2, 3).BackColor = red

            Case 4
                gridHold(1, 2).Visible = True
                gridHold(1, 1).Visible = True
                gridHold(2, 1).Visible = True
                gridHold(2, 0).Visible = True
                gridHold(1, 2).BackColor = green
                gridHold(1, 1).BackColor = green
                gridHold(2, 1).BackColor = green
                gridHold(2, 0).BackColor = green

            Case 5
                gridHold(2, 0).Visible = True
                gridHold(2, 1).Visible = True
                gridHold(2, 2).Visible = True
                gridHold(1, 1).Visible = True
                gridHold(2, 0).BackColor = purple
                gridHold(2, 1).BackColor = purple
                gridHold(2, 2).BackColor = purple
                gridHold(1, 1).BackColor = purple

            Case 6
                gridHold(2, 0).Visible = True
                gridHold(2, 1).Visible = True
                gridHold(2, 2).Visible = True
                gridHold(1, 2).Visible = True
                gridHold(2, 0).BackColor = orange
                gridHold(2, 1).BackColor = orange
                gridHold(2, 2).BackColor = orange
                gridHold(1, 2).BackColor = orange

            Case 7
                gridHold(1, 0).Visible = True
                gridHold(2, 0).Visible = True
                gridHold(2, 1).Visible = True
                gridHold(2, 2).Visible = True
                gridHold(1, 0).BackColor = blue
                gridHold(2, 0).BackColor = blue
                gridHold(2, 1).BackColor = blue
                gridHold(2, 2).BackColor = blue

        End Select
        frmMain.grpHold.SendToBack()
    End Sub

    Public Sub createNewPiece()
        If Not lose Then
            Static unhold As Boolean
            Static ignoreFirstAttempt As Integer


            If unhold = True Then
                held = False
                unhold = False
            End If
            If held = True Then
                unhold = True
                If firstHold Then
                    currentPiece = nextPiece
                    nextPiece = pseudoRandomizePiece()
                Else

                End If
            Else
                currentPiece = nextPiece
                nextPiece = pseudoRandomizePiece()
                If ignoreFirstAttempt > 3 Then

                    For counter As Integer = 0 To 3

                        If CoordinateY(counter) = 1 Then
                            frmMain.tmrMain.Enabled = False
                            pauseGame()
                            currentPiece = 0
                            lose = True
                        End If

                    Next counter
                End If


            End If
            ignoreFirstAttempt += 1


            currentRotation = 1

            Select Case currentPiece
                Case 1
                    createPiece1()
                Case 2
                    createPiece2()
                Case 3
                    createPiece3()
                Case 4
                    createPiece4()
                Case 5
                    createPiece5()
                Case 6
                    createPiece6()
                Case 7
                    createPiece7()
                Case Else

            End Select
            If Not lose Then
                drawNextPiece()
                drawMainPiece()
            Else
                gameOver()
            End If
        End If
    End Sub


    Private Sub playDeathSound()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.GameOverSoundEffect, AudioPlayMode.Background)
    End Sub

    Private Sub playClearSound()
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.GameClearSoundEffect, AudioPlayMode.Background)
    End Sub


    Public Sub gameClear()
        frmMain.lblInfo.Text = ""
        playClearSound()
        frmMain.lblInfo.Image = My.Resources.GameClearImage

        For y As Integer = 21 To 1 Step -1
            For x As Integer = 0 To 9

                gridMain(y, x).BackColor = Color.White()
                gridMain(y, x).Tag = ""
            Next x
            My.Application.DoEvents()
            System.Threading.Thread.Sleep(75)

        Next y

        For counter As Integer = 0 To 3
            CoordinateX(counter) = -1
            CoordinateY(counter) = -1
        Next counter
        updateLeaderboards()
        frmMain.btnPlay.Font = New Font("Segoe Script", 32, FontStyle.Bold)
        frmMain.btnPlay.Enabled = True
        frmMain.btnPlay.Text = "Restart!"
    End Sub

    Public Sub gameOver()
        playDeathSound()
        frmMain.lblInfo.Image = My.Resources.GameOverImage
        For y As Integer = 1 To 21
            For x As Integer = 0 To 9
                gridMain(y, x).BackColor = Color.Black
                gridMain(y, x).Tag = ""
            Next x
            My.Application.DoEvents()
            System.Threading.Thread.Sleep(75)

        Next y

        For counter As Integer = 0 To 3
            CoordinateX(counter) = -1
            CoordinateY(counter) = -1
        Next counter
        updateLeaderboards()

        frmMain.btnPlay.Font = New Font("Segoe Script", 32, FontStyle.Bold)
        frmMain.btnPlay.Enabled = True
        frmMain.btnPlay.Text = "Restart!"

    End Sub

    Private Sub updateLeaderboards()
        If frmMain.endlessMode Then
            If score > leaderScoreNum(0) Then
                leaderScoreNum(4) = leaderScoreNum(3)
                leaderName(4) = leaderName(3)
                leaderScoreNum(3) = leaderScoreNum(2)
                leaderName(3) = leaderName(2)
                leaderScoreNum(2) = leaderScoreNum(1)
                leaderName(2) = leaderName(1)
                leaderScoreNum(1) = leaderScoreNum(0)
                leaderName(1) = leaderName(0)

                leaderScoreNum(0) = score

                leaderName(0) = InputBox("Congradulations! You scored" & Str(score) & " points and made it onto the leaderboard! Please enter your name so it can be saved:", "New Highscore!", "Anonymous")
                leaderName(0) = leaderName(0).Trim
                If leaderName(0) = Nothing Then
                    leaderName(0) = "Anonymous"
                End If
                If leaderName(0).IndexOf(" ") <> -1 Then
                    leaderName(0) = leaderName(0).Replace(leaderName(0).Substring(leaderName(0).IndexOf(" ")), "")
                End If
            ElseIf score > leaderScoreNum(1) Then
                leaderScoreNum(4) = leaderScoreNum(3)
                leaderName(4) = leaderName(3)
                leaderScoreNum(3) = leaderScoreNum(2)
                leaderName(3) = leaderName(2)
                leaderScoreNum(2) = leaderScoreNum(1)
                leaderName(2) = leaderName(1)

                leaderScoreNum(1) = score
                leaderName(1) = InputBox("Congradulations! You scored" & Str(score) & " points and made it onto the leaderboard! Please enter your name so it can be saved:", "New Highscore!", "Anonymous")
                leaderName(1) = leaderName(1).Trim
                If leaderName(1) = Nothing Then
                    leaderName(1) = "Anonymous"
                End If
                If leaderName(1).IndexOf(" ") <> -1 Then
                    leaderName(1) = leaderName(1).Replace(leaderName(1).Substring(leaderName(1).IndexOf(" ")), "")
                End If
            ElseIf score > leaderScoreNum(2) Then
                leaderScoreNum(4) = leaderScoreNum(3)
                leaderName(4) = leaderName(3)
                leaderScoreNum(3) = leaderScoreNum(2)
                leaderName(3) = leaderName(2)

                leaderScoreNum(2) = score
                leaderName(2) = InputBox("Congradulations! You scored" & Str(score) & " points and made it onto the leaderboard! Please enter your name so it can be saved:", "New Highscore!", "Anonymous")
                leaderName(2) = leaderName(2).Trim
                If leaderName(2) = Nothing Then
                    leaderName(2) = "Anonymous"
                End If
                If leaderName(2).IndexOf(" ") <> -1 Then
                    leaderName(2) = leaderName(2).Replace(leaderName(2).Substring(leaderName(2).IndexOf(" ")), "")
                End If

            ElseIf score > leaderScoreNum(3) Then
                leaderScoreNum(4) = leaderScoreNum(3)
                leaderName(4) = leaderName(3)


                leaderScoreNum(3) = score
                leaderName(3) = InputBox("Congradulations! You scored" & Str(score) & " points and made it onto the leaderboard! Please enter your name so it can be saved:", "New Highscore!", "Anonymous")

                leaderName(3) = leaderName(3).Trim
                If leaderName(3) = Nothing Then
                    leaderName(3) = "Anonymous"
                End If
                If leaderName(3).IndexOf(" ") <> -1 Then
                    leaderName(3) = leaderName(3).Replace(leaderName(3).Substring(leaderName(3).IndexOf(" ")), "")
                End If
            ElseIf score > leaderScoreNum(4) Then
                leaderScoreNum(4) = score
                leaderName(4) = InputBox("Congradulations! You scored" & Str(score) & " points and made it onto the leaderboard! Please enter your name so it can be saved:", "New Highscore!", "Anonymous")
                leaderName(4) = leaderName(4).Trim
                If leaderName(4) = Nothing Then
                    leaderName(4) = "Anonymous"
                End If
                If leaderName(4).IndexOf(" ") <> -1 Then
                    leaderName(4) = leaderName(4).Replace(leaderName(4).Substring(leaderName(4).IndexOf(" ")), "")
                End If




            End If
            For counter As Integer = 0 To 4
                leaderScore(counter) = leaderScoreNum(counter)
            Next counter
            My.Settings.TopScores = ""

            For counter As Integer = 0 To 4
                My.Settings.TopScores += leaderName(counter) & Space(1) & leaderScore(counter) & ","
            Next
            readLeaderboard()
        Else
            If level > leaderScoreNumSrvl(0) Then
                leaderScoreNumSrvl(4) = leaderScoreNumSrvl(3)
                leaderNameSrvl(4) = leaderNameSrvl(3)
                leaderScoreNumSrvl(3) = leaderScoreNumSrvl(2)
                leaderNameSrvl(3) = leaderNameSrvl(2)
                leaderScoreNumSrvl(2) = leaderScoreNumSrvl(1)
                leaderNameSrvl(2) = leaderNameSrvl(1)
                leaderScoreNumSrvl(1) = leaderScoreNumSrvl(0)
                leaderNameSrvl(1) = leaderNameSrvl(0)

                leaderScoreNumSrvl(0) = level

                leaderNameSrvl(0) = InputBox("Congradulations! You got to level" & Str(level) & " and made it onto the leaderboard! Please enter your nameSrvl so it can be saved:", "New Highscore!", "Anonymous")
                leaderNameSrvl(0) = leaderNameSrvl(0).Trim
                If leaderNameSrvl(0) = Nothing Then
                    leaderNameSrvl(0) = "Anonymous"
                End If
                If leaderNameSrvl(0).IndexOf(" ") <> -1 Then
                    leaderNameSrvl(0) = leaderNameSrvl(0).Replace(leaderNameSrvl(0).Substring(leaderNameSrvl(0).IndexOf(" ")), "")
                End If
            ElseIf level > leaderScoreNumSrvl(1) Then
                leaderScoreNumSrvl(4) = leaderScoreNumSrvl(3)
                leaderNameSrvl(4) = leaderNameSrvl(3)
                leaderScoreNumSrvl(3) = leaderScoreNumSrvl(2)
                leaderNameSrvl(3) = leaderNameSrvl(2)
                leaderScoreNumSrvl(2) = leaderScoreNumSrvl(1)
                leaderNameSrvl(2) = leaderNameSrvl(1)

                leaderScoreNumSrvl(1) = level
                leaderNameSrvl(1) = InputBox("Congradulations! You got to level" & Str(level) & " and made it onto the leaderboard! Please enter your nameSrvl so it can be saved:", "New Highscore!", "Anonymous")
                leaderNameSrvl(1) = leaderNameSrvl(1).Trim
                If leaderNameSrvl(1) = Nothing Then
                    leaderNameSrvl(1) = "Anonymous"
                End If
                If leaderNameSrvl(1).IndexOf(" ") <> -1 Then
                    leaderNameSrvl(1) = leaderNameSrvl(1).Replace(leaderNameSrvl(1).Substring(leaderNameSrvl(1).IndexOf(" ")), "")
                End If
            ElseIf level > leaderScoreNumSrvl(2) Then
                leaderScoreNumSrvl(4) = leaderScoreNumSrvl(3)
                leaderNameSrvl(4) = leaderNameSrvl(3)
                leaderScoreNumSrvl(3) = leaderScoreNumSrvl(2)
                leaderNameSrvl(3) = leaderNameSrvl(2)

                leaderScoreNumSrvl(2) = level
                leaderNameSrvl(2) = InputBox("Congradulations! You got to level" & Str(level) & " and made it onto the leaderboard! Please enter your nameSrvl so it can be saved:", "New Highscore!", "Anonymous")
                leaderNameSrvl(2) = leaderNameSrvl(2).Trim
                If leaderNameSrvl(2) = Nothing Then
                    leaderNameSrvl(2) = "Anonymous"
                End If
                If leaderNameSrvl(2).IndexOf(" ") <> -1 Then
                    leaderNameSrvl(2) = leaderNameSrvl(2).Replace(leaderNameSrvl(2).Substring(leaderNameSrvl(2).IndexOf(" ")), "")
                End If
            ElseIf level > leaderScoreNumSrvl(3) Then
                leaderScoreNumSrvl(4) = leaderScoreNumSrvl(3)
                leaderNameSrvl(4) = leaderNameSrvl(3)


                leaderScoreNumSrvl(3) = level
                leaderNameSrvl(3) = InputBox("Congradulations! You got to level" & Str(level) & " and made it onto the leaderboard! Please enter your nameSrvl so it can be saved:", "New Highscore!", "Anonymous")

                leaderNameSrvl(3) = leaderNameSrvl(3).Trim
                If leaderNameSrvl(3) = Nothing Then
                    leaderNameSrvl(3) = "Anonymous"
                End If
                If leaderNameSrvl(3).IndexOf(" ") <> -1 Then
                    leaderNameSrvl(3) = leaderNameSrvl(3).Replace(leaderNameSrvl(3).Substring(leaderNameSrvl(3).IndexOf(" ")), "")
                End If
            ElseIf level > leaderScoreNumSrvl(4) Then
                leaderScoreNumSrvl(4) = level
                leaderNameSrvl(4) = InputBox("Congradulations! You got to level" & Str(level) & " and made it onto the leaderboard! Please enter your nameSrvl so it can be saved:", "New Highscore!", "Anonymous")
                leaderNameSrvl(4) = leaderNameSrvl(4).Trim
                If leaderNameSrvl(4) = Nothing Then
                    leaderNameSrvl(4) = "Anonymous"
                End If
                If leaderNameSrvl(4).IndexOf(" ") <> -1 Then
                    leaderNameSrvl(4) = leaderNameSrvl(4).Replace(leaderNameSrvl(4).Substring(leaderNameSrvl(4).IndexOf(" ")), "")
                End If
            End If
            For counter As Integer = 0 To 4
                leaderScoreSrvl(counter) = leaderScoreNumSrvl(counter)
            Next counter

            My.Settings.TopScoresSrvl = ""

            For counter As Integer = 0 To 4
                My.Settings.TopScoresSrvl += leaderNameSrvl(counter) & Space(1) & leaderScoreSrvl(counter) & ","
            Next


            readLeaderboardSrvl()
        End If
    End Sub
    ' These subs basically create new pieces
    Public Sub createPiece1()

        CoordinateX(0) = 5
        CoordinateY(0) = -1
        CoordinateX(1) = 6
        CoordinateY(1) = -1
        CoordinateX(2) = 5
        CoordinateY(2) = 0
        CoordinateX(3) = 6
        CoordinateY(3) = 0

    End Sub


    Public Sub createPiece2()

        CoordinateX(0) = 4
        CoordinateY(0) = 1
        CoordinateX(1) = 5
        CoordinateY(1) = 1
        CoordinateX(2) = 6
        CoordinateY(2) = 1
        CoordinateX(3) = 7
        CoordinateY(3) = 1

    End Sub


    Public Sub createPiece3()

        CoordinateX(0) = 4
        CoordinateY(0) = 0
        CoordinateX(1) = 5
        CoordinateY(1) = 0
        CoordinateX(2) = 5
        CoordinateY(2) = 1
        CoordinateX(3) = 6
        CoordinateY(3) = 1

    End Sub


    Public Sub createPiece4()

        CoordinateX(0) = 6
        CoordinateY(0) = 0
        CoordinateX(1) = 5
        CoordinateY(1) = 0
        CoordinateX(2) = 5
        CoordinateY(2) = 1
        CoordinateX(3) = 4
        CoordinateY(3) = 1

    End Sub


    Public Sub createPiece5()

        CoordinateX(0) = 5
        CoordinateY(0) = 0
        CoordinateX(1) = 4
        CoordinateY(1) = 1
        CoordinateX(2) = 5
        CoordinateY(2) = 1
        CoordinateX(3) = 6
        CoordinateY(3) = 1

    End Sub


    Public Sub createPiece6()

        CoordinateX(0) = 6
        CoordinateY(0) = 0
        CoordinateX(1) = 6
        CoordinateY(1) = 1
        CoordinateX(2) = 5
        CoordinateY(2) = 1
        CoordinateX(3) = 4
        CoordinateY(3) = 1

    End Sub


    Public Sub createPiece7()

        CoordinateX(0) = 4
        CoordinateY(0) = 0
        CoordinateX(1) = 4
        CoordinateY(1) = 1
        CoordinateX(2) = 5
        CoordinateY(2) = 1
        CoordinateX(3) = 6
        CoordinateY(3) = 1

    End Sub





    ' This Sub basically creates the grid
    Private Sub createMap()

        For row = 0 To sizeY - 1
            For Column = 0 To sizeX - 1

                drawMap(row, Column)

            Next Column
        Next row

    End Sub


    ' This Sub basically creates the next grid
    Private Sub createNextMap()

        For row = 0 To 3
            For Column = 0 To 3

                drawMapNext(row, Column)

            Next Column
        Next row

    End Sub


    ' This Sub basically creates the hold grid
    Private Sub createHoldMap()

        For row = 0 To 3
            For Column = 0 To 3

                drawMapHold(row, Column)

            Next Column
        Next row

    End Sub


    ' This function checks if pieces are overlapping
    Private Function piecesCollide()
        Dim collision As Boolean

        For counter As Integer = 0 To 3

            If CoordinateY(counter) = 21 Then
                collision = True
            End If

        Next counter



        For counter As Integer = 0 To 3

            If Not collision Then
                If gridMain(CoordinateY(counter) + 1, CoordinateX(counter)).Tag = "O" Then
                    collision = True
                End If
            End If

        Next counter

        Return collision
    End Function


    ' Check if the Coordinate is overflowing from the side
    Public Sub sideCheck()
        For counter As Integer = 0 To 3
            Do Until Not CoordinateX(counter) > 9
                For counter2 As Integer = 0 To 3
                    CoordinateX(counter2) -= 1
                Next counter2
            Loop
        Next counter


        For counter As Integer = 0 To 3
            Do While CoordinateX(counter) < 0
                For counter2 As Integer = 0 To 3
                    CoordinateX(counter2) += 1
                Next counter2
            Loop
        Next counter

    End Sub


    ' This Sub tags the Coordinates as occupied
    Private Sub occupyLocations()

        For counter As Integer = 0 To 3
            gridMain(CoordinateY(counter) + 1, CoordinateX(counter)).Tag = "O"
        Next counter

    End Sub







    ' This is what actually creates the individual pieces
    Private Sub drawMap(row As Integer, Column As Integer)
        gridMain(row, Column) = New PictureBox
        gridMain(row, Column).Size = New Point(32, 32)
        gridMain(row, Column).BorderStyle = border
        gridMain(row, Column).BackColor = Color.LightGray
        gridMain(row, Column).Location = New Point((gridMain(row, Column).Width * Column) + 99, (gridMain(row, Column).Height * row) + 36)
        frmMain.Controls.Add(gridMain(row, Column))
    End Sub





    ' This is what actually creates the individual pieces for the next piece grid
    Private Sub drawMapNext(row As Integer, Column As Integer)
        gridNext(row, Column) = New PictureBox
        gridNext(row, Column).Size = New Point(30, 30)
        gridNext(row, Column).BorderStyle = border
        gridNext(row, Column).BackColor = Color.LightGray
        gridNext(row, Column).Location = New Point((gridNext(row, Column).Width * Column) + 545, (gridNext(row, Column).Height * row) + 287)
        gridNext(row, Column).Visible = False
        frmMain.Controls.Add(gridNext(row, Column))
    End Sub




    ' This is what actually creates the individual pieces for the hold piece grid
    Private Sub drawMapHold(row As Integer, Column As Integer)
        gridHold(row, Column) = New PictureBox
        gridHold(row, Column).Size = New Point(30, 30)
        gridHold(row, Column).BorderStyle = border
        gridHold(row, Column).BackColor = Color.LightGray
        gridHold(row, Column).Location = New Point((gridHold(row, Column).Width * Column) + 551, (gridHold(row, Column).Height * row) + 486)
        gridHold(row, Column).Visible = False
        frmMain.Controls.Add(gridHold(row, Column))
    End Sub









    ' This Sub will draw - piece based on coordinates and colors
    Private Sub drawMainPiece()
        If Not lose Then
            For counter As Integer = 0 To 3
                If CoordinateX(counter) > 9 Then
                    CoordinateX(counter) = 9
                End If
                If CoordinateX(counter) < 0 Then
                    CoordinateX(counter) = 0
                End If
                gridMain(CoordinateY(counter) + 1, CoordinateX(counter)).BackColor = colorRetriever()

            Next counter
        End If
    End Sub




    ' This Sub will draw - next piece based on coordinates and colors
    Private Sub drawgridNext()
        For counter As Integer = 0 To 3
            gridNext(CoordinateNextY(counter), CoordinateNextX(counter)).BackColor = colorRetriever()
            gridNext(CoordinateNextY(counter), CoordinateNextX(counter)).Visible = True
        Next counter

    End Sub




    ' This Sub will draw - piece based on coordinates and colors
    Private Sub drawgridHold()
        For counter As Integer = 0 To 3
            gridHold(CoordinateHoldY(counter), CoordinateHoldX(counter)).BackColor = colorRetriever()
            gridHold(CoordinateHoldY(counter), CoordinateHoldX(counter)).Visible = True
        Next counter
    End Sub







    'This Sub will erase the main piece based on coordinates
    Private Sub eraseMainPiece()
        For counter As Integer = 0 To 3
            gridMain(CoordinateY(counter) + 1, CoordinateX(counter)).BackColor = gray
        Next counter
    End Sub




    'This Sub will erase the next piece based on coordinates
    Private Sub erasegridNext()
        For counter As Integer = 0 To 3
            gridNext(CoordinateNextY(counter), CoordinateNextX(counter)).BackColor = gray
            gridNext(CoordinateNextY(counter), CoordinateNextX(counter)).Visible = False
        Next counter
    End Sub




    'This Sub will erase the hold piece based on coordinates
    Private Sub eraseHoldPiece()
        For counter As Integer = 0 To 3
            gridHold(CoordinateHoldY(counter), CoordinateHoldX(counter)).BackColor = gray
            gridHold(CoordinateHoldY(counter), CoordinateHoldX(counter)).Visible = False
        Next counter
    End Sub









    ' This function returns the value of the color of current piece
    Private Function colorRetriever() As Color
        Select Case currentPiece
            Case 1
                Return yellow
            Case 2
                Return lightBlue
            Case 3
                Return red
            Case 4
                Return green
            Case 5
                Return purple
            Case 6
                Return orange
            Case 7
                Return blue
            Case Else
                Return Nothing
        End Select
    End Function



    Private Sub checkRowClear()

        Dim clear(21) As Boolean
        Dim checkMark As Boolean
        Dim scoreAdder As Integer

        For k As Integer = 2 To 21

            For i As Integer = 0 To 9

                If gridMain(k, i).Tag = "O" Then
                    checkMark = True
                Else
                    checkMark = False
                    i = 9
                End If

            Next i
            clear(k) = checkMark
            checkMark = False
        Next k

        For k As Integer = 2 To 21

            If clear(k) = True Then

                For i As Integer = 0 To 9
                    gridMain(k, i).BackColor = gray
                    gridMain(k, i).Tag = ""
                Next i

                For h As Integer = 0 To 9

                    For l As Integer = k To 1 Step -1
                        gridMain(l, h).BackColor = gridMain(l - 1, h).BackColor
                        gridMain(l, h).Tag = gridMain(l - 1, h).Tag
                    Next l


                Next h
                scoreAdder += 1

            End If



        Next k
        If frmMain.endlessMode Then
            If scoreAdder = 4 Then
                tetris = True
                frmMain.lblInfo.Text = "Tetris!"
                clearInfo = 2
            ElseIf scoreAdder = 3 Then
                frmMain.lblInfo.Text = "Triple!"
                clearInfo = 2
                triple = True
            ElseIf scoreAdder = 2 Then
                frmMain.lblInfo.Text = "Double!"
                clearInfo = 2
            ElseIf scoreAdder = 1 Then
                frmMain.lblInfo.Text = "Single!"
                clearInfo = 2
            End If
        End If


        score += scoreAdder * 167
        If tetris Then
            score += 252
        End If
        If triple Then
            score += 157
        End If
        tetris = False
        triple = False

        If frmMain.endlessMode Then
            frmMain.lblScoreValue.Text = score
        Else
            Dim prevLevel As Integer = level
            level = (score / 500) + 1
            frmMain.lblScoreValue.Text = level
            dropSpeed = 500 - (20 * level)

            frmMain.tmrMain.Interval = dropSpeed
            If prevLevel - level <> 0 Then
                frmMain.lblInfo.Font = New Font("Segoe Script", 36, FontStyle.Bold)
                frmMain.lblInfo.Text = "Level Up!"
                clearInfo = 2
            End If
            If level > 19 Then

                frmMain.tmrMain.Enabled = False
                pauseGame()
                currentPiece = 0
                lose = True
                gameClear()
            End If
        End If


    End Sub



    ' Here is - function which will return - random number based on - lower and higher value
    Private Function Random(min As Integer, max As Integer) As Integer
        max = max - 1
        Return (max - min + 1) * Rnd() + min
    End Function


    Private Function pseudoRandomizePiece() As Integer
        Static pieceUsed(6) As Boolean
        Dim allUsed As Boolean = True
        Dim returner As Integer

        For counter As Integer = 0 To 6

            If pieceUsed(counter) = False Then
                allUsed = False
            End If

        Next counter


        If allUsed Then
            For counter As Integer = 0 To 6

                pieceUsed(counter) = False

            Next counter
        End If


        Do
            returner = Random(1, 7)
        Loop Until pieceUsed(returner - 1) = False

        pieceUsed(returner - 1) = True
        Return returner

    End Function
End Class

' 1 - Square
' 2 - Line
' 3 - Red Tetris
' 4 - Green Tetris
' 5 - T Shape
' 6 - L Shape
' 7 - Inverted L Shape
