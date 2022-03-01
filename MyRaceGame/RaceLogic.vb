Module RaceLogic

    Public movement, speed, playerToMove, gamesToWin, racesWon, defaultBank As Integer
    Public gamePaused, raceCanStart, wasTimerRunning As Boolean
    ''' <summary>
    ''' Makes each race random. Assings player name variables equal to Player label text.
    ''' Calls a Sub Routine that checks if the race can start.
    ''' </summary>
    Public Sub CheckRaceConditions()
        Randomize()
        Player1Name = frmGame.lblPlayer1.Text
        Player2Name = frmGame.lblPlayer2.Text
        Player3Name = frmGame.lblPlayer3.Text
        Player4Name = frmGame.lblPlayer4.Text
        Call CanRaceStart()
    End Sub
    ''' <summary>
    ''' Checks to see if the race can start. Checks if each Player bet textBox contains a value.
    ''' Calls 3 other subs that check other conditions before the race can start.
    ''' </summary>
    Public Sub CanRaceStart()
        If frmGame.txtPlayer1Bet.Text = "" Or frmGame.txtPlayer2Bet.Text = "" Or frmGame.txtPlayer3Bet.Text = "" _
            Or frmGame.txtPlayer4Bet.Text = "" Then
            MessageBox.Show("Each Player must enter a Bet")
            raceCanStart = False
            frmGame.tmrGameSpeed.Enabled = False
        Else : Call CanAffordBet()
            Call PlayersReady()
            Call BeginRace()
        End If
    End Sub
    ''' <summary>
    ''' Checks the value of Each Player Bet from the bet textboxes. If a player bet is greater than the amount
    ''' in their bank then display a message box informing the player they can't afford the bet. Also sets 
    ''' each PlayerStart boolean to true if their bet amount is lower or equal to the amount in their bank.
    ''' </summary>
    Public Sub CanAffordBet()
        Try
            If Val(frmGame.txtPlayer1Bet.Text) > Val(frmGame.lblPlayer1Bank.Text) Then
                MsgBox(Player1Name & " can't afford that bet!")
                Player1Start = False
            Else : Player1Start = True
            End If
            If Val(frmGame.txtPlayer2Bet.Text) > Val(frmGame.lblPlayer2Bank.Text) Then
                MsgBox(Player2Name & " can't afford that bet!")
                Player2Start = False
            Else : Player2Start = True
            End If
            If Val(frmGame.txtPlayer3Bet.Text) > Val(frmGame.lblPlayer3Bank.Text) Then
                MsgBox(Player3Name & " can't afford that bet!")
                Player3Start = False
            Else : Player3Start = True
            End If
            If Val(frmGame.txtPlayer4Bet.Text) > Val(frmGame.lblPlayer4Bank.Text) Then
                MsgBox(Player4Name & " can't afford that bet!")
                Player4Start = False
            Else : Player4Start = True
            End If
        Catch ex As Exception
            Debug.Print(ex.ToString())
        End Try
    End Sub
    ''' <summary>
    ''' Checks each PlayerStart boolean value. If all equal true then set raceCanStart boolean value to true.
    ''' If not all values equal true then display a message box informing that not all players are ready.
    ''' The raceCanStartBoolean is used to start the race.
    ''' </summary>
    Public Sub PlayersReady()
        If Player1Start = False Or Player2Start = False Or Player3Start = False Or Player4Start = False Then
            MsgBox("Not all players are ready")
            raceCanStart = False
        Else : raceCanStart = True
        End If
    End Sub
    'Public Sub PlayersReady()
    '    If Player1Start = True Then
    '        If Player2Start = True Then
    '            If Player3Start = True Then
    '                If Player4Start = True Then
    '                    raceCanStart = True
    '                Else : MsgBox("Not all players are ready")
    '                    raceCanStart = False
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub
    
    ''' <summary>
    ''' Checks if the amount of races needed to win is less than the number of races that
    ''' have took place. If true then disables the radio buttons that change the number of races
    ''' needed to win. If not then enable the radio buttons so the user can change the value.
    ''' </summary>
    Public Sub DisableOptions()
        If racesWon < gamesToWin And frmGame.tmrGameSpeed.Enabled Then
            frmGame.optBestOf3.Enabled = False
            frmGame.optBestOf5.Enabled = False
            frmGame.optBestOf7.Enabled = False
            frmGame.optBestOf9.Enabled = False
        Else : frmGame.optBestOf3.Enabled = True
            frmGame.optBestOf5.Enabled = True
            frmGame.optBestOf7.Enabled = True
            frmGame.optBestOf9.Enabled = True
        End If
    End Sub
    ''' <summary>
    ''' Checks each GamesToWin radio button and changes the gamesToWin variable accordingly.
    ''' </summary>
    Public Sub CheckWinAmount()
        If frmGame.optBestOf3.Checked = True Then
            gamesToWin = 3
        ElseIf frmGame.optBestOf5.Checked = True Then
            gamesToWin = 5
        ElseIf frmGame.optBestOf7.Checked = True Then
            gamesToWin = 7
        ElseIf frmGame.optBestOf9.Checked = True Then
            gamesToWin = 9
        End If
    End Sub
    ''' <summary>
    ''' Begins the race only if the raceCanStart boolean value equals true.
    ''' </summary>
    Public Sub BeginRace()
        If raceCanStart = True Then
            frmGame.tmrGameSpeed.Interval = 100 / frmGame.tbarSpeed.Value
            frmGame.tmrGameSpeed.Enabled = True
            frmGame.lblPlayer1Bank.Text -= frmGame.txtPlayer1Bet.Text
            frmGame.lblPlayer2Bank.Text -= frmGame.txtPlayer2Bet.Text
            frmGame.lblPlayer3Bank.Text -= frmGame.txtPlayer3Bet.Text
            frmGame.lblPlayer4Bank.Text -= frmGame.txtPlayer4Bet.Text
            Call CheckWinAmount()
            Call NoMoreBets()
            Call DisableOptions()
            Call SetOdds()
        Else : frmGame.tmrGameSpeed.Enabled = False
            MsgBox("Race Can Not Start")
        End If
    End Sub
    ''' <summary>
    ''' Checks to see if the amount of races won is equal to the number of races needed to win overall.
    ''' Checks if each players win count is higher than the other players.
    ''' Displays a messagebox informing players which player won.
    ''' If no players won then it was a tie and shows players how many wins each player achieved.
    ''' </summary>
    Public Sub GamesWon()
        If racesWon = gamesToWin Then
            'Check if Player 1 is the overall Winner.
            If player1Wins > player2Wins And player1Wins > player3Wins And player1Wins > player4Wins Then
                frmGame.lblRacesWon.Text = "Races" & vbCrLf & "Won: " & racesWon.ToString()
                MsgBox(Player1Name & " wins overall with " & player1Wins & " wins")
                Call ResetWins()
                Call DisableOptions()
                'Check if Player 2 is the overall Winner.
            ElseIf player2Wins > player1Wins And player2Wins > player3Wins And player2Wins > player4Wins Then
                frmGame.lblRacesWon.Text = "Races" & vbCrLf & "Won: " & racesWon.ToString()
                MsgBox(Player2Name & " wins overall with " & player2Wins & " wins")
                Call ResetWins()
                Call DisableOptions()
                'Check if Player 3 is the overall Winner.
            ElseIf player3Wins > player1Wins And player3Wins > player2Wins And player3Wins > player4Wins Then
                frmGame.lblRacesWon.Text = "Races" & vbCrLf & "Won: " & racesWon.ToString()
                MsgBox(Player3Name & " wins overall with " & player3Wins & " wins")
                Call ResetWins()
                Call DisableOptions()
                'Check if Player 4 is the overall Winner.
            ElseIf player4Wins > player1Wins And player4Wins > player2Wins And player4Wins > player3Wins Then
                frmGame.lblRacesWon.Text = "Races" & vbCrLf & "Won: " & racesWon.ToString()
                MsgBox(Player4Name & " wins overall with " & player4Wins & " wins")
                Call ResetWins()
                Call DisableOptions()
                'Check if nobody won overall and announce it's a tie.
            Else : frmGame.lblRacesWon.Text = "Races" & vbCrLf & "Won: " & racesWon.ToString()
                MsgBox("No winner:" & vbCrLf & vbCrLf & Player1Name & " : " & player1Wins & " win(s)" _
                          & vbCrLf & _
                          Player2Name & " : " & player2Wins & " win(s)" & vbCrLf & _
                          Player3Name & " : " & player3Wins & " win(s)" & vbCrLf & _
                          Player4Name & " : " & player4Wins & " win(s)" & vbCrLf)
                Call ResetWins()
                Call DisableOptions()
            End If
        End If
    End Sub
    ''' <summary>
    ''' The Sub Routine that is called when a player wins a race.
    ''' Calls various Sub Routines that check if players are bankrupt, sets players odds,
    ''' Resets Players locations for the next race and checks if players have raced the 
    ''' amount of races specified from the BestOf X radio buttons
    ''' </summary>
    Public Sub AfterWin()
        Call ShowRaceProgress()
        Call ResetPlayerLocation()
        Call SetOdds()
        Call NoMoreBets()
        Call Bankrupt()
        Call IsBettingEnabled()
        Call GamesWon()
        Call ResetGuesses()
    End Sub
    ''' <summary>
    ''' This is the Sub Routine that contains the logic while a race is in progress.
    ''' It should be called in the tmrGameSpeed_Tick Event
    ''' It sets the players position on screen and moves each player randomly.
    ''' It also checks if a player has crossed the finished line and if so declares
    ''' that player the winner and then updates the labels that display race win info.
    ''' </summary>
    Public Sub RaceRunning()
        player1Pos = frmGame.picPlayer1.Left + frmGame.picPlayer1.Width
        player2Pos = frmGame.picPlayer2.Left + frmGame.picPlayer2.Width
        player3Pos = frmGame.picPlayer3.Left + frmGame.picPlayer3.Width
        player4Pos = frmGame.picPlayer4.Left + frmGame.picPlayer4.Width
        Try
            frmGame.tmrGameSpeed.Interval = 100 - frmGame.tbarSpeed.Value + 1
            If frmGame.tmrGameSpeed.Interval <= 0 Then
                frmGame.tmrGameSpeed.Interval = 1
            End If
            frmGame.lblSpeed.Text = "Game Speed: " & frmGame.tbarSpeed.Value.ToString()
        Catch ex As Exception
            Debug.Print(ex.ToString())
        End Try
        '---Start of player movement. Set the players speed and which player to move.
        speed = 25
        playerToMove = Int(4 * Rnd() + 1)
        movement = Int(speed * Rnd(132) + 2)
        'Chooses which player to move.
        Select Case playerToMove
            Case 1
                frmGame.picPlayer1.Left += movement
            Case 2
                frmGame.picPlayer2.Left += movement
            Case 3
                frmGame.picPlayer3.Left += movement
            Case 4
                frmGame.picPlayer4.Left += movement
        End Select
        'Checks if player 1 won the race.
        If player1Pos >= frmGame.linFinish.X1 Then
            frmGame.tmrGameSpeed.Enabled = False
            racesWon += 1
            Call ShowRaceProgress()
            player1Wins += 1
            Player1TotalWins += 1
            Player1Leader += 5
            frmGame.lblPlayer1Won.Text = player1Wins.ToString()
            MsgBox(Player1Name & " won!")
            'Checks if player 1 has double money. If so award them their double money.
            If Player1Double = False Then
                frmGame.lblPlayer1Bank.Text = Val(frmGame.lblPlayer1Bank.Text) + Val(frmGame.txtPlayer1Bet.Text * player1Odds) _
                    + Val(frmGame.txtPlayer1Bet.Text)
                Call IsBettingEnabled()
                Call AfterWin()
            Else
                frmGame.lblPlayer1Bank.Text = Val(frmGame.lblPlayer1Bank.Text) + Val(frmGame.txtPlayer1Bet.Text * player1Odds) _
                    + Val(frmGame.txtPlayer1Bet.Text) * 2
                Player1Double = False
                Call IsBettingEnabled()
                Call AfterWin()
            End If

            'Checks if player 2 won the race.
        ElseIf player2Pos >= frmGame.linFinish.X1 Then
            frmGame.tmrGameSpeed.Enabled = False
            racesWon += 1
            Call ShowRaceProgress()
            player2Wins += 1
            Player2TotalWins += 1
            Player2Leader += 5
            frmGame.lblPlayer2Won.Text = player2Wins.ToString()
            MsgBox(Player2Name & " won!")
            
            'Checks if player 2 has double money. If so award them their double money.
            If Player2Double = False Then
                frmGame.lblPlayer2Bank.Text = Val(frmGame.lblPlayer2Bank.Text) + Val(frmGame.txtPlayer2Bet.Text * player2Odds) _
                    + Val(frmGame.txtPlayer2Bet.Text)
                Call IsBettingEnabled()
                Call AfterWin()
            Else
                frmGame.lblPlayer2Bank.Text = Val(frmGame.lblPlayer2Bank.Text) + Val(frmGame.txtPlayer2Bet.Text * player2Odds) _
                    + Val(frmGame.txtPlayer2Bet.Text) * 2
                Player2Double = False
                Call IsBettingEnabled()
                Call AfterWin()
            End If


            'Checks if player 3 won the race.
            ElseIf player3Pos >= frmGame.linFinish.X1 Then
                frmGame.tmrGameSpeed.Enabled = False
            racesWon += 1
            Call ShowRaceProgress()
                player3Wins += 1
                Player3TotalWins += player3Wins
                Player3Leader += 5
            frmGame.lblPlayer3Won.Text = player3Wins.ToString()
            MsgBox(Player3Name & " won!")
            
            'Checks if player 3 has double money. If so award them their double money.
                If Player3Double = False Then
                frmGame.lblPlayer3Bank.Text = Val(frmGame.lblPlayer3Bank.Text) + Val(frmGame.txtPlayer3Bet.Text * player3Odds) _
                        + Val(frmGame.txtPlayer3Bet.Text)
                Call IsBettingEnabled()
                Call AfterWin()
                Else
                    frmGame.lblPlayer3Bank.Text = Val(frmGame.lblPlayer3Bank.Text) + Val(frmGame.txtPlayer3Bet.Text * player3Odds) _
                        + Val(frmGame.txtPlayer3Bet.Text) * 2
                Player3Double = False
                Call IsBettingEnabled()
                Call AfterWin()
            End If


            'Checks if player 4 won the race.
        ElseIf player4Pos >= frmGame.linFinish.X1 Then
            frmGame.tmrGameSpeed.Enabled = False
            racesWon += 1
            Call ShowRaceProgress()
            player4Wins += 1
            Player4TotalWins += 1
            Player4Leader += 5
            frmGame.lblPlayer4Won.Text = player4Wins.ToString()
            MsgBox(Player4Name & " won!")
            'Checks if player 4 has double money. If so award them their double money.
            If Player4Double = False Then
                frmGame.lblPlayer4Bank.Text = Val(frmGame.lblPlayer4Bank.Text) + Val(frmGame.txtPlayer4Bet.Text * player4Odds) _
                     + Val(frmGame.txtPlayer4Bet.Text)
                Call IsBettingEnabled()
                Call AfterWin()
            Else
                frmGame.lblPlayer4Bank.Text = Val(frmGame.lblPlayer4Bank.Text) + Val(frmGame.txtPlayer4Bet.Text * player4Odds) _
                     + Val(frmGame.txtPlayer4Bet.Text) * 2
                Player4Double = False
                Call IsBettingEnabled()
                Call AfterWin()
            End If
        End If
        'Update the races won label.
        frmGame.lblRacesWon.Text = "Races" & vbCrLf & "Won: " & racesWon.ToString()
    End Sub

    Public Sub PauseGame()
        frmPause.Show()
        gamePaused = True
        'If the race was in progress before being paused then continue the race.
        If frmGame.tmrGameSpeed.Enabled = True Then
            wasTimerRunning = True
        Else : wasTimerRunning = False
        End If
        frmGame.tmrGameSpeed.Enabled = False
        frmGame.btnStart.Enabled = False
    End Sub

    Public Sub ResumeGame()
        frmOptions.Close()
        frmPause.Close()
        gamePaused = False
        If wasTimerRunning = True Then
            frmGame.tmrGameSpeed.Enabled = True
        Else : frmGame.btnStart.Enabled = True
        End If
    End Sub

    Public Sub ShowRaceProgress()
        Select Case gamesToWin
            Case 3
                With frmGame.ProgressBar2
                    .Maximum = 30
                    If racesWon = 1 Then
                        .Value = 10
                        .ToolTipText = "2 more races to go!"
                    ElseIf racesWon = 2 Then
                        .Value = 20
                        .ToolTipText = "1 more race to go!"
                    ElseIf racesWon = 3 Then
                        .Value = 30
                        .ToolTipText = "3 Races Complete!"
                    End If
                End With
            Case 5
                With frmGame.ProgressBar2
                    .Maximum = 50
                    If racesWon = 1 Then
                        .Value = 10
                        .ToolTipText = "4 more races to go!"
                    ElseIf racesWon = 2 Then
                        .Value = 20
                        .ToolTipText = "3 more races to go!"
                    ElseIf racesWon = 3 Then
                        .Value = 30
                        .ToolTipText = "2 more races to go!"
                    ElseIf racesWon = 4 Then
                        .Value = 40
                        .ToolTipText = "1 more race to go!"
                    ElseIf racesWon = 5 Then
                        .Value = 50
                        .ToolTipText = "5 Races!"
                    End If
                End With
            Case 7
                With frmGame.ProgressBar2
                    .Maximum = 70
                    If racesWon = 1 Then
                        .Value = 10
                        .ToolTipText = "6 more races to go!"
                    ElseIf racesWon = 2 Then
                        .Value = 20
                        .ToolTipText = "5 more races to go!"
                    ElseIf racesWon = 3 Then
                        .Value = 30
                        .ToolTipText = "4 more races to go!"
                    ElseIf racesWon = 4 Then
                        .Value = 40
                        .ToolTipText = "3 more races to go!"
                    ElseIf racesWon = 5 Then
                        .Value = 50
                        .ToolTipText = "2 more races to go!"
                    ElseIf racesWon = 6 Then
                        .Value = 60
                        .ToolTipText = "1 more race to go!"
                    ElseIf racesWon = 7 Then
                        .Value = 70
                        .ToolTipText = "7 Races Complete!"
                    End If
                End With
            Case 9
                With frmGame.ProgressBar2
                    .Maximum = 90
                    If racesWon = 1 Then
                        .Value = 10
                        .ToolTipText = "8 more races to go!"
                    ElseIf racesWon = 2 Then
                        .Value = 20
                        .ToolTipText = "7 more races to go!"
                    ElseIf racesWon = 3 Then
                        .Value = 30
                        .ToolTipText = "6 more races to go!"
                    ElseIf racesWon = 4 Then
                        .Value = 40
                        .ToolTipText = "5 more races to go!"
                    ElseIf racesWon = 5 Then
                        .Value = 50
                        .ToolTipText = "4 more races to go!"
                    ElseIf racesWon = 6 Then
                        .Value = 60
                        .ToolTipText = "3 more races to go!"
                    ElseIf racesWon = 7 Then
                        .Value = 70
                        .ToolTipText = "2 more races to go!"
                    ElseIf racesWon = 8 Then
                        .Value = 80
                        .ToolTipText = "1 more race to go!"
                    ElseIf racesWon = 9 Then
                        .Value = 90
                        .ToolTipText = "9 Races Complete!"
                    End If
                End With
        End Select
    End Sub

End Module