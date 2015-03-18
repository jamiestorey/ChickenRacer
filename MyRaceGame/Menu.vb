Public Class frmMenu
    'Update the leaderboard options and open the options form.
    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click
        frmOptions.lblPlayer1TotalWins.Update()
        frmOptions.lblPlayer2TotalWins.Update()
        frmOptions.lblPlayer3TotalWins.Update()
        frmOptions.lblPlayer4TotalWins.Update()
        frmOptions.Show()
    End Sub
    'Exits the game.
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        frmGame.Close()
        frmOptions.Close()
        Me.Close()
    End Sub
    'Opens the game and closes any other open form.
    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        frmGame.Show()
        frmOptions.Close()
        Me.Close()
    End Sub
    'Open the about page and show what the game is about.
    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        MsgBox("Chicken racer is a chicken racing game where 4 players bet on their chickens and try become the champion.", MsgBoxStyle.OkOnly, "Chicken Racer")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        frmHowTo.Show()
    End Sub
End Class