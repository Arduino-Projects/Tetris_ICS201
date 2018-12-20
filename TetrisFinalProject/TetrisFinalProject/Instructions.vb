Public Class frmInstructions
    Dim currentInstruction As Integer = 1
    Private Sub btnExitInstructions_Click(sender As Object, e As EventArgs) Handles btnExitInstructions.Click

        Me.Close()
    End Sub

    Private Sub frmInstructions_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Dim position As Point = picMain.Location

        Select Case e.KeyCode

                Case Keys.Up, Keys.X
                If currentInstruction = 1 Then
                    picMain.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                    picMain.Refresh()
                End If
            Case Keys.Left
                    If currentInstruction = 2 Then
                        position.X -= 40
                        If position.X < 20 Then
                            position.X = 20
                        End If
                        picMain.Location = position
                    End If
                Case Keys.Right
                    If currentInstruction = 2 Then
                        position.X += 40
                        If position.X > 300 Then
                            position.X = 300

                        End If
                        picMain.Location = position
                    End If
            End Select

        e.Handled = True
        e.SuppressKeyPress = True

    End Sub

    Private Sub frmInstructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        currentInstruction -= 1
        If currentInstruction = 0 Then
            currentInstruction = 1
        End If

        Select Case currentInstruction
            Case 1
                picMain.Image = My.Resources.DemoPiece
                picMain.Visible = True
                lblInstruction.Text = ""
                lblInstructionsCaption.Text = "Press UP Key or X Key to Rotate the Piece"
            Case 2
                picMain.Image = My.Resources.DemoPiece
                picMain.Visible = True
                lblInstruction.Text = ""
                lblInstructionsCaption.Text = "Press the Arrow Keys to Move the Piece Left/Right"
            Case 3
                picMain.Image = My.Resources.ClearingDemo
                picMain.Visible = True
                lblInstruction.Text = ""
                lblInstructionsCaption.Text = "Fill Rows to Make Lines Disappear and gain Score"
            Case 4
                picMain.Image = Nothing
                picMain.Visible = False

                lblInstruction.Text = "In Endless Mode, you have to clear lines to increase your score. The game does NOT speed up and will go on infinitely. Gettig the highest score will get you onto the leaderboard"
                lblInstructionsCaption.Text = "Endless Mode"
            Case 5
                picMain.Image = Nothing
                picMain.Visible = False
                lblInstruction.Text = "In Survival Mode, there are 20 levels. You have to clear lines to progress in levels but the game does speed up. Get the highest level to get onto the leaderboard."
                lblInstructionsCaption.Text = "Survival Mode"
        End Select
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        currentInstruction += 1
        If currentInstruction = 6 Then
            currentInstruction = 1
        End If
        Select Case currentInstruction
            Case 1
                picMain.Image = My.Resources.DemoPiece
                picMain.Visible = True
                lblInstruction.Text = ""
                lblInstructionsCaption.Text = "Press UP Key or X Key to Rotate the Piece"
            Case 2
                picMain.Image = My.Resources.DemoPiece
                picMain.Visible = True
                lblInstruction.Text = ""
                lblInstructionsCaption.Text = "Press the Arrow Keys to Move the Piece Left/Right"
            Case 3
                picMain.Image = My.Resources.ClearingDemo
                picMain.Visible = True
                lblInstruction.Text = ""
                lblInstructionsCaption.Text = "Fill Rows to Make Lines Disappear and gain Score"
            Case 4
                picMain.Image = Nothing
                picMain.Visible = False

                lblInstruction.Text = "In Endless Mode, you have to clear lines to increase your score. The game does NOT speed up and will go on infinitely. Getting the highest score will get you onto the leaderboard"
                lblInstructionsCaption.Text = "Endless Mode"
            Case 5
                picMain.Image = Nothing
                picMain.Visible = False
                lblInstruction.Text = "In Survival Mode, there are 20 levels. You have to clear lines to progress in levels but the game does speed up. Get the highest level to get onto the leaderboard."
                lblInstructionsCaption.Text = "Survival Mode"
        End Select

    End Sub
End Class