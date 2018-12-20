Imports System.Runtime.InteropServices
Public Class frmPause
    Dim allowedToExit As Boolean = False

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmMain.tmrPause.Enabled = True
        frmMain.quit = True
        Me.Close()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        frmMain.restart = True
        frmMain.tmrPause.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click
        frmMain.resumeGame = True
        frmMain.tmrPause.Enabled = True
        Me.Close()

    End Sub

    Private Sub btnStyles_Click(sender As Object, e As EventArgs) Handles btnStyles.Click
        Dim frm As New frmStyles
        frm.Show()
    End Sub


    <DllImport("user32.dll")> Public Shared Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    Private Sub btnVolDown_Click(sender As Object, e As EventArgs) Handles btnVolDown.Click
        SendMessageW(Me.Handle, &H319, Me.Handle, New IntPtr(&H90000))
    End Sub

    Private Sub btnVolUp_Click(sender As Object, e As EventArgs) Handles btnVolUp.Click
        SendMessageW(Me.Handle, &H319, Me.Handle, New IntPtr(&HA0000))
    End Sub

    Private Sub btnHowToPlay_Click(sender As Object, e As EventArgs) Handles btnHowToPlay.Click
        Dim myForm As New frmInstructions
        myForm.Show()
    End Sub

    Private Sub frmPause_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrLoadDelay.Enabled = True

        KeyPreview = True

    End Sub

    Private Sub frmPause_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then
            If allowedToExit Then
                frmMain.resumeGame = True
                frmMain.tmrPause.Enabled = True
                Me.Close()
            End If
        End If
    End Sub

    Private Sub tmrLoadDelay_Tick(sender As Object, e As EventArgs) Handles tmrLoadDelay.Tick
        allowedToExit = True
        tmrLoadDelay.Enabled = False
    End Sub
End Class