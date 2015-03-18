Public Class frmOptions

    'Close the form when the close button is pressed.
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub UpdateLeaderboard()
        'Update the leaderboard labels to show each players number of wins.
        lblPlayer1TotalWins.Text = Player1TotalWins
        lblPlayer2TotalWins.Text = Player2TotalWins
        lblPlayer3TotalWins.Text = Player3TotalWins
        lblPlayer4TotalWins.Text = Player4TotalWins
        'Increase the height of the leaderboard panels.
        pnlPlayer1Leader.Height += Player1Leader
        pnlPlayer2Leader.Height += Player2Leader
        pnlPlayer3Leader.Height += Player3Leader
        pnlPlayer4Leader.Height += Player4Leader
    End Sub
    'When the form loads update the leaderboards.
    Private Sub frmOptions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call UpdateLeaderboard()
        lblBackgroundColour.BackColor = frmGame.BackColor
        pnlBackgroundColour.BackColor = frmGame.BackColor
        lblToolStripColour.BackColor = frmGame.BackColor
        pnlToolStripColour.BackColor = frmGame.BackColor
    End Sub

    Private Sub ChangeBackgroundColour(sender As Object, e As EventArgs) Handles pnlBackgroundColour.Click, lblBackgroundColour.Click
        ColorDialog1.ShowDialog()
        frmGame.BackColor = ColorDialog1.Color
        lblBackgroundColour.BackColor = ColorDialog1.Color
        pnlBackgroundColour.BackColor = ColorDialog1.Color
    End Sub

    Private Sub ChangeToolStripColour(sender As Object, e As EventArgs) Handles pnlToolStripColour.Click, lblToolStripColour.Click
        ColorDialog1.ShowDialog()
        frmGame.toolStripGame.BackColor = ColorDialog1.Color
        lblToolStripColour.BackColor = ColorDialog1.Color
        pnlToolStripColour.BackColor = ColorDialog1.Color
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGame.SuspendLayout()
    End Sub
End Class