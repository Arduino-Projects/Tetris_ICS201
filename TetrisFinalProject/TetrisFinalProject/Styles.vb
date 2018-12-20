Public Class frmStyles
    Dim gridStyles(3, 3) As PictureBox
    Dim currentPiece As Integer = 1
    Dim CoX(3), CoY(3) As Integer

    Private Sub frmStyles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createStylesMap()
        drawStylesPiece()
        If frmMain.gameMain.border <> Nothing Then
            lblBorder.Text = "ON"

        Else
            lblBorder.Text = "OFF"
        End If
    End Sub

    Private Sub createStylesMap()

        For row = 0 To 3
            For Column = 0 To 3

                drawMapStyles(row, Column)

            Next Column
        Next row

    End Sub



    Private Sub drawBorderStyles()
        For row As Integer = 0 To 3
            For column As Integer = 0 To 3
                gridStyles(row, column).BorderStyle = frmMain.gameMain.border
            Next column
        Next row
        For row As Integer = 0 To 3
            For column As Integer = 0 To 3
                frmMain.gameMain.gridNext(row, column).BorderStyle = frmMain.gameMain.border
            Next column
        Next row
        For row As Integer = 0 To 3
            For column As Integer = 0 To 3
                frmMain.gameMain.gridHold(row, column).BorderStyle = frmMain.gameMain.border
            Next column
        Next row
        For row As Integer = 0 To 21
            For column As Integer = 0 To 9
                frmMain.gameMain.gridMain(row, column).BorderStyle = frmMain.gameMain.border
            Next column
        Next row
    End Sub



    Private Sub drawMapStyles(row As Integer, Column As Integer)
        gridStyles(row, Column) = New PictureBox
        gridStyles(row, Column).Size = New Point(80, 80)
        gridStyles(row, Column).BorderStyle = frmMain.gameMain.border
        gridStyles(row, Column).BackColor = Color.LightGray
        gridStyles(row, Column).Location = New Point((gridStyles(row, Column).Width * Column) + 260, (gridStyles(row, Column).Height * row) + 40)
        gridStyles(row, Column).Visible = False
        Me.Controls.Add(gridStyles(row, Column))
    End Sub

    Private Function colorReader() As Color
        Select Case currentPiece
            Case 1
                Return frmMain.gameMain.yellow

            Case 2
                Return frmMain.gameMain.lightBlue

            Case 3
                Return frmMain.gameMain.red

            Case 4
                Return frmMain.gameMain.green

            Case 5
                Return frmMain.gameMain.purple

            Case 6
                Return frmMain.gameMain.orange

            Case 7
                Return frmMain.gameMain.blue

        End Select
    End Function

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        currentPiece += 1
        If currentPiece = 8 Then
            currentPiece = 1
        End If
        drawStylesPiece()
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        currentPiece -= 1
        If currentPiece = 0 Then
            currentPiece = 7
        End If
        drawStylesPiece()
    End Sub

    Private Sub btnChangeColor_Click(sender As Object, e As EventArgs) Handles btnChangeColor.Click
        clrMain.ShowDialog()
        Select Case currentPiece
            Case 1
                frmMain.gameMain.yellow = clrMain.Color()

            Case 2
                frmMain.gameMain.lightBlue = clrMain.Color()

            Case 3
                frmMain.gameMain.red = clrMain.Color()

            Case 4
                frmMain.gameMain.green = clrMain.Color()

            Case 5
                frmMain.gameMain.purple = clrMain.Color()

            Case 6
                frmMain.gameMain.orange = clrMain.Color()

            Case 7
                frmMain.gameMain.blue = clrMain.Color()

        End Select
        drawStylesPiece()
        My.Settings.Blue = frmMain.gameMain.blue
        My.Settings.Red = frmMain.gameMain.red
        My.Settings.Green = frmMain.gameMain.green
        My.Settings.LightBlue = frmMain.gameMain.lightBlue
        My.Settings.Orange = frmMain.gameMain.orange
        My.Settings.Purple = frmMain.gameMain.purple
        My.Settings.Yellow = frmMain.gameMain.yellow
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnResetStyles_Click(sender As Object, e As EventArgs) Handles btnResetStyles.Click
        frmMain.gameMain.blue = Color.DarkBlue
        frmMain.gameMain.red = Color.Red
        frmMain.gameMain.green = Color.Green
        frmMain.gameMain.lightBlue = Color.SkyBlue
        frmMain.gameMain.orange = Color.Orange
        frmMain.gameMain.purple = Color.Purple
        frmMain.gameMain.yellow = Color.Yellow
        frmMain.gameMain.border = BorderStyle.Fixed3D

        My.Settings.Blue = frmMain.gameMain.blue
        My.Settings.Red = frmMain.gameMain.red
        My.Settings.Green = frmMain.gameMain.green
        My.Settings.LightBlue = frmMain.gameMain.lightBlue
        My.Settings.Orange = frmMain.gameMain.orange
        My.Settings.Purple = frmMain.gameMain.purple
        My.Settings.Yellow = frmMain.gameMain.yellow
        My.Settings.Border = frmMain.gameMain.border
        drawStylesPiece()
        drawBorderStyles()
    End Sub

    Private Sub btnBorderSwitcher_Click(sender As Object, e As EventArgs) Handles btnBorderSwitcher.Click
        If lblBorder.Text = "ON" Then
            lblBorder.Text = "OFF"
            frmMain.gameMain.border = Nothing

        Else
            lblBorder.Text = "ON"
            frmMain.gameMain.border = BorderStyle.Fixed3D
        End If
        My.Settings.Border = frmMain.gameMain.border
        drawBorderStyles()
    End Sub

    Private Sub drawStylesPiece()
        For row As Integer = 0 To 3
            For Column As Integer = 0 To 3
                gridStyles(row, Column).BackColor = frmMain.gameMain.gray
                gridStyles(row, Column).Visible = False
            Next Column
        Next row
        Select Case currentPiece
            Case 1
                gridStyles(1, 1).Visible = True
                gridStyles(1, 2).Visible = True
                gridStyles(2, 1).Visible = True
                gridStyles(2, 2).Visible = True
                gridStyles(1, 1).BackColor = frmMain.gameMain.yellow
                gridStyles(1, 2).BackColor = frmMain.gameMain.yellow
                gridStyles(2, 1).BackColor = frmMain.gameMain.yellow
                gridStyles(2, 2).BackColor = frmMain.gameMain.yellow

            Case 2
                gridStyles(2, 0).Visible = True
                gridStyles(2, 1).Visible = True
                gridStyles(2, 2).Visible = True
                gridStyles(2, 3).Visible = True
                gridStyles(2, 0).BackColor = frmMain.gameMain.lightBlue
                gridStyles(2, 1).BackColor = frmMain.gameMain.lightBlue
                gridStyles(2, 2).BackColor = frmMain.gameMain.lightBlue
                gridStyles(2, 3).BackColor = frmMain.gameMain.lightBlue

            Case 3
                gridStyles(1, 1).Visible = True
                gridStyles(1, 2).Visible = True
                gridStyles(2, 2).Visible = True
                gridStyles(2, 3).Visible = True
                gridStyles(1, 1).BackColor = frmMain.gameMain.red
                gridStyles(1, 2).BackColor = frmMain.gameMain.red
                gridStyles(2, 2).BackColor = frmMain.gameMain.red
                gridStyles(2, 3).BackColor = frmMain.gameMain.red

            Case 4
                gridStyles(1, 2).Visible = True
                gridStyles(1, 1).Visible = True
                gridStyles(2, 1).Visible = True
                gridStyles(2, 0).Visible = True
                gridStyles(1, 2).BackColor = frmMain.gameMain.green
                gridStyles(1, 1).BackColor = frmMain.gameMain.green
                gridStyles(2, 1).BackColor = frmMain.gameMain.green
                gridStyles(2, 0).BackColor = frmMain.gameMain.green

            Case 5
                gridStyles(2, 0).Visible = True
                gridStyles(2, 1).Visible = True
                gridStyles(2, 2).Visible = True
                gridStyles(1, 1).Visible = True
                gridStyles(2, 0).BackColor = frmMain.gameMain.purple
                gridStyles(2, 1).BackColor = frmMain.gameMain.purple
                gridStyles(2, 2).BackColor = frmMain.gameMain.purple
                gridStyles(1, 1).BackColor = frmMain.gameMain.purple

            Case 6
                gridStyles(2, 0).Visible = True
                gridStyles(2, 1).Visible = True
                gridStyles(2, 2).Visible = True
                gridStyles(1, 2).Visible = True
                gridStyles(2, 0).BackColor = frmMain.gameMain.orange
                gridStyles(2, 1).BackColor = frmMain.gameMain.orange
                gridStyles(2, 2).BackColor = frmMain.gameMain.orange
                gridStyles(1, 2).BackColor = frmMain.gameMain.orange

            Case 7
                gridStyles(1, 0).Visible = True
                gridStyles(2, 0).Visible = True
                gridStyles(2, 1).Visible = True
                gridStyles(2, 2).Visible = True
                gridStyles(1, 0).BackColor = frmMain.gameMain.blue
                gridStyles(2, 0).BackColor = frmMain.gameMain.blue
                gridStyles(2, 1).BackColor = frmMain.gameMain.blue
                gridStyles(2, 2).BackColor = frmMain.gameMain.blue

        End Select

    End Sub


End Class