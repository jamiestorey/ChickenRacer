Public Class frmPause

    Dim Window As String

    'Resumes the game when the resume button is clicked.
    Private Sub btnResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResume.Click
        frmOptions.Close()
        Me.Close()
        gamePaused = False
        If wasTimerRunning = True Then
            frmGame.tmrGameSpeed.Enabled = True
        Else : frmGame.btnStart.Enabled = True
        End If
        If gamePaused = True Then
            frmGame.toolBTNPause.Visible = False
            frmGame.toolBTNResume.Visible = True
        Else : frmGame.toolBTNPause.Visible = True
            frmGame.toolBTNResume.Visible = False
        End If
    End Sub
    'Displays the options menu when the options button is clicked.
    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click
        frmOptions.Show()
    End Sub
    'Quits the game when the quit button is clicked. Asks the player if they are sure first.
    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Window = MsgBox("Are you sure you want to quit?", MessageBoxButtons.OKCancel)
        If Window = vbOK Then
            frmGame.Close()
            Me.Close()
            End
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Window = MsgBox("Are you sure you want to quit to Main Menu?", MessageBoxButtons.OKCancel)
        If Window = vbOK Then
            frmMenu.Show()
            frmGame.Close()
            Me.Close()
        End If
    End Sub

    Private Sub frmPause_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(27) Then
            Call ResumeGame()
        End If
    End Sub
End Class