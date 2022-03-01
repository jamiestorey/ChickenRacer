Public Class frmGame

    Public xRandom, Player1Guess, Player2Guess, Player3Guess, Player4Guess As Integer

    'Pauses the game when the Escape Key is pressed.
    Private Sub Pause(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(27) Then
            Call PauseGame()
        End If
    End Sub
    'Called when the form Loads
    Private Sub frmGame_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call InitialiseBanks()
        optBestOf3.Checked = True
        optSpeedNormal.Checked = True
        toolBTNResume.Visible = False
    End Sub
#Region "Change Game Speed"
    'Sets the timer interval to the value of the speed track bar allowing players to change the speed of the game.
    'Also changes the speed radio buttons if the trackbar value is specific to the value the radio buttons represent.
    Private Sub tbarSpeed_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbarSpeed.Scroll
        If tbarSpeed.Value = 75 Then
            optSpeedFast.Checked = True
        ElseIf tbarSpeed.Value = 50 Then
            optSpeedNormal.Checked = True
        ElseIf tbarSpeed.Value = 1 Then
            optSpeedSlow.Checked = True
        Else : optSpeedCustom.Checked = True
        End If
        Try
            tmrGameSpeed.Interval = 100 - tbarSpeed.Value + 1
            If tmrGameSpeed.Interval <= 0 Then
                tmrGameSpeed.Interval = 1
            End If
            lblSpeed.Text = "Game Speed: " & tbarSpeed.Value.ToString()
        Catch ex As Exception
            Debug.Print(ex.ToString())
        End Try
    End Sub
    'If the slow speed radio button is checked then set the speed bar value to 1 and update the label displaying the game speed.
    Private Sub optSpeedSlow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSpeedSlow.CheckedChanged
        tbarSpeed.Value = 1
        lblSpeed.Text = "Game Speed: " & tbarSpeed.Value.ToString()
    End Sub
    'If the normal speed radio button is checked then set the speed bar value to 50 and update the label displaying the game speed.
    Private Sub optSpeedNormal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSpeedNormal.CheckedChanged
        tbarSpeed.Value = 50
        lblSpeed.Text = "Game Speed: " & tbarSpeed.Value.ToString()
    End Sub
    'If the fast speed radio button is checked then set the speed bar value to 75 and update the label displaying the game speed.
    Private Sub optSpeedFast_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSpeedFast.CheckedChanged
        tbarSpeed.Value = 75
        lblSpeed.Text = "Game Speed: " & tbarSpeed.Value.ToString()
    End Sub
    'If the custom speed radio button is checked then set the speed bar value to 20 and update the label displaying the game speed.
    Private Sub optSpeedCustom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSpeedCustom.CheckedChanged
        tbarSpeed.Value = 20
        lblSpeed.Text = "Game Speed: " & tbarSpeed.Value.ToString()
    End Sub
#End Region

#Region "ChangePlayerNames"
    'If the user clicks the Player1 label. Display an input box allowing them to change the player name and update the player string variable.
    Private Sub lblPlayer1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPlayer1.Click
        Player1Name = InputBox("Enter name for Player1", "Enter new name", "Player1")
        If Player1Name.Trim() = "" Then
            Dim p1InvalidName As Boolean = True
            Do While p1InvalidName = True
                Player1Name = InputBox("Names may not be blank", "Enter a new name", "Player1")
                If Player1Name.Trim() <> "" Then
                    lblPlayer1.Text = Player1Name
                    p1InvalidName = False
                End If
            Loop
        Else : lblPlayer1.Text = Player1Name
        End If

    End Sub
    'If the user clicks the Player2 label. Display an input box allowing them to change the player name and update the player string variable.
    Private Sub lblPlayer2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPlayer2.Click
        Player2Name = InputBox("Enter name for Player2", "Enter new name", "Player2")
        If Player2Name.Trim() = "" Then
            Dim p2InvalidName As Boolean = True
            Do While p2InvalidName = True
                Player2Name = InputBox("Names may not be blank", "Enter a new name", "Player2")
                If Player2Name.Trim() <> "" Then
                    lblPlayer2.Text = Player2Name
                    p2InvalidName = False
                End If
            Loop
        Else : lblPlayer2.Text = Player2Name
        End If
    End Sub
    'If the user clicks the Player3 label. Display an input box allowing them to change the player name and update the player string variable.
    Private Sub lblPlayer3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPlayer3.Click
        Player3Name = InputBox("Enter name for Player3", "Enter new name", "Player3")
        If Player3Name.Trim() = "" Then
            Dim p3InvalidName As Boolean = True
            Do While p3InvalidName = True
                Player3Name = InputBox("Names may not be blank", "Enter a new name", "Player3")
                If Player3Name.Trim() <> "" Then
                    lblPlayer3.Text = Player3Name
                    p3InvalidName = False
                End If
            Loop
        Else : lblPlayer3.Text = Player3Name
        End If
    End Sub
    'If the user clicks the Player4 label. Display an input box allowing them to change the player name and update the player string variable.
    Private Sub lblPlayer4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPlayer4.Click
        Player4Name = InputBox("Enter name for Player4", "Enter new name", "Player4")
        If Player4Name.Trim() = "" Then
            Dim p4InvalidName As Boolean = True
            Do While p4InvalidName = True
                Player4Name = InputBox("Names may not be blank", "Enter a new name", "Player4")
                If Player4Name.Trim() <> "" Then
                    lblPlayer4.Text = Player4Name
                    p4InvalidName = False
                End If
            Loop
        Else : lblPlayer4.Text = Player4Name
        End If
    End Sub
#End Region
#Region "Games to Win"
    'If BestOf3 Radio Button is checked then gamestoWin variable = 3
    Private Sub optBestOf3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles optBestOf3.CheckedChanged
        gamesToWin = 3
    End Sub
    'If BestOf5 Radio Button is checked then gamestoWin variable = 5
    Private Sub optBestOf5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles optBestOf5.CheckedChanged
        gamesToWin = 5
    End Sub
    'If BestOf7 Radio Button is checked then gamestoWin variable = 7
    Private Sub optBestOf7_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles optBestOf7.CheckedChanged
        gamesToWin = 7
    End Sub
    'If BestOf9 Radio Button is checked then gamestoWin variable = 9
    Private Sub optBestOf9_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles optBestOf9.CheckedChanged
        gamesToWin = 9
    End Sub
#End Region
    'When the user clicks the start race button, the CheckRaceConditions Sub Routine is called to check if the race can start.
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Call CheckRaceConditions()
    End Sub
    'When the user presses keys while a Betting textbox is active. Checks the ascii code for each key the user presses.
    'Only allows for numbers 0-9 to be pressed with their ascii codes being from 48 to 57.
    'Also allows users to delete their bet by using the backspace key which has the ascii code of 8.
    Private Sub Dissalow_illigal_Characters(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) _
 Handles txtPlayer4Bet.KeyPress, txtPlayer3Bet.KeyPress, txtPlayer2Bet.KeyPress, txtPlayer1Bet.KeyPress
        If (Asc(e.KeyChar) < 48) Or (Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
    'Calls the ResetEveything Sub Routine when the user clicks the reset button. All money and race wins will be reset.
    Private Sub btnReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReset.Click
        Call ResetEverything()
    End Sub
    'When the game timer is enabled it will tick. Each time it ticks it will call the RaceRunning Sub Routine if the game isn't pasued.
    Private Sub tmrGameSpeed_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrGameSpeed.Tick
        If gamePaused = False Then
            Call RaceRunning()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoubleMoney.Click
        Player1Name = lblPlayer1.Text
        Player2Name = lblPlayer2.Text
        Player3Name = lblPlayer3.Text
        Player4Name = lblPlayer4.Text
        'Set xRandom equal to a random number.
        xRandom = Int(12 * Rnd())
        'Print the value of xRandom to Visual Studio window for debug purposes.
        Debug.Print(xRandom)
        'Try to run the mini game. Catch any exceptions thrown. Used so the program won't crash if a player enters anything other than a number as their guess.
        Try
            'Start of double money minigame. For loop, loops through the 4 players.
            For index As Integer = 1 To 3
                'Check to see if the player has already guessed.
                If Player1Guessed = False Then
                    Player1Guess = InputBox("Player 1 Guess The Number", )
                    Player1Guessed = True
                End If
                If Player2Guessed = False Then
                    Player2Guess = InputBox("Player 2 Guess The Number")
                    Player2Guessed = True
                End If
                If Player3Guessed = False Then
                    Player3Guess = InputBox("Player 3 Guess The Number")
                    Player3Guessed = True
                End If
                If Player4Guessed = False Then
                    Player4Guess = InputBox("Player 4 Guess The Number")
                    Player4Guessed = True
                End If
                'Check if players guessed the random number.
                If Player1Guess = xRandom Then
                    MsgBox(Player1Name & " Guessed Correctly")
                    Player1Double = True
                    lblP1X2.Visible = True
                    index = 4
                End If
                If Player2Guess = xRandom Then
                    MsgBox(Player2Name & " Guessed Correctly")
                    Player2Double = True
                    lblP2X2.Visible = True
                    index = 4
                End If
                If Player3Guess = xRandom Then
                    MsgBox(Player3Name & " Guessed Correctly")
                    Player3Double = True
                    lblP3X2.Visible = True
                    index = 4
                End If
                If Player4Guess = xRandom Then
                    MsgBox(Player4Name & " Guessed Correctly")
                    Player4Double = True
                    lblP4X2.Visible = True
                    index = 4
                End If
                'Check if no players guessed correctly.
                If Player4Guess <> xRandom And Player3Guess <> xRandom And Player2Guess <> xRandom And Player1Guess <> xRandom Then
                    MsgBox("No Player Guessed Correctly")
                    index = 4
                    Call ResetGuesses()
                End If
            Next
            ' Call ResetGuesses()
        Catch ex As Exception
            Debug.Print(ex.ToString())
        End Try
    End Sub  
    Private Sub frmGame_ResizeBegin(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd, MyBase.ResizeBegin, MyBase.Resize
        Me.Size = New Size(948, 545)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim quit As String
        quit = MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "Quit Game?")
        If quit = vbYes Then
            Me.Close()
            End
        End If
    End Sub

    

    Private Sub ToolStripContainer1_ContentPanel_Load(sender As Object, e As EventArgs) Handles ToolStripContainer1.ContentPanel.Load
        player1DefaultPos = picPlayer1.Location
        player2DefaultPos = picPlayer2.Location
        player3DefaultPos = picPlayer3.Location
        player4DefaultPos = picPlayer4.Location
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles toolBTNPause.Click

        Call PauseGame()
        If gamePaused = True Then
            toolBTNPause.Visible = False
            toolBTNResume.Visible = True
        Else : toolBTNPause.Visible = True
            toolBTNResume.Visible = False
        End If

    End Sub

    Private Sub toolBTNResume_Click(sender As Object, e As EventArgs) Handles toolBTNResume.Click
        Call ResumeGame()
        If gamePaused = True Then
            toolBTNPause.Visible = False
            toolBTNResume.Visible = True
        Else : toolBTNPause.Visible = True
            toolBTNResume.Visible = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Dim quit As String
        quit = MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "Quit Game?")
        If quit = vbYes Then
            Me.Close()
            frmOptions.Close()
            frmPause.Close()
            frmHelp.Close()
            End
        End If
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainMenuToolStripMenuItem.Click
        Dim quit As String
        quit = MsgBox("Are you sure you want to exit to the Main Menu?", MsgBoxStyle.YesNo, "Exit Game?")
        If quit = vbYes Then
            frmMenu.Show()
            Me.Close()
            frmOptions.Close()
            frmHelp.Close()
            frmPause.Close()
        End If
    End Sub

    Private Sub GameOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GameInfoToolStripMenuItem.Click
        If GameInfoToolStripMenuItem.Checked = True Then
            GameInfoToolStripMenuItem.Checked = False
        Else : GameInfoToolStripMenuItem.Checked = False
            GameInfoToolStripMenuItem.Checked = True
        End If
        If GameInfoToolStripMenuItem.Checked = True Then
            grpInfo.Visible = True
        End If
        If GameInfoToolStripMenuItem.Checked = False Then
            grpInfo.Visible = False
        End If
    End Sub

    Private Sub GameOptionsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles GameOptionsToolStripMenuItem.Click
        If GameOptionsToolStripMenuItem.Checked = True Then
            GameOptionsToolStripMenuItem.Checked = False
        Else : GameOptionsToolStripMenuItem.Checked = False
            GameOptionsToolStripMenuItem.Checked = True
        End If
        If GameOptionsToolStripMenuItem.Checked = True Then
            grpOptions.Visible = True
        End If
        If GameOptionsToolStripMenuItem.Checked = False Then
            grpOptions.Visible = False
        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles toolBTNOptions.Click
        frmOptions.Show()
    End Sub

    Private Sub ToolStripButton1_Click_2(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmOptions.Show()
        frmOptions.TabControl1.SelectedTab = frmOptions.tabLeader
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmHelp.Show()
    End Sub
End Class