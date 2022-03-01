Module Player

    Public player1DefaultPos, player2DefaultPos, player3DefaultPos, player4DefaultPos As Point
    Public player1Pos, player2Pos, player3Pos, player4Pos As Integer
    Public player1Wins, player2Wins, player3Wins, player4Wins, player1Odds, player2Odds, player3Odds, player4Odds As Integer
    Public Player1Bank, Player2Bank, Player3Bank, Player4Bank As Integer
    Public Player1TotalWins, Player2TotalWins, Player3TotalWins, Player4TotalWins As Integer
    Public Player1Leader, Player2Leader, Player3Leader, Player4Leader As Integer
    Public Player1Name, Player2Name, Player3Name, Player4Name As String
    Public Player1Start, Player2Start, Player3Start, Player4Start As Boolean
    Public Player1Guessed, Player2Guessed, Player3Guessed, Player4Guessed As Boolean
    Public Player1Double, Player2Double, Player3Double, Player4Double As Boolean

    ''' <summary>
    ''' Sets the players default bank balance and initialises each PlayerBank Variables.
    ''' </summary>
    Public Sub InitialiseBanks()
        'Sets each players bank balance to 50.
        defaultBank = 300
        frmGame.lblPlayer1Bank.Text = defaultBank
        frmGame.lblPlayer2Bank.Text = defaultBank
        frmGame.lblPlayer3Bank.Text = defaultBank
        frmGame.lblPlayer4Bank.Text = defaultBank
        'Sets the value of variables for bank calculations.
        Player1Bank = Val(frmGame.lblPlayer1Bank.Text)
        Player2Bank = Val(frmGame.lblPlayer2Bank.Text)
        Player3Bank = Val(frmGame.lblPlayer3Bank.Text)
        Player4Bank = Val(frmGame.lblPlayer4Bank.Text)
        'Sets the text of each betting textbox to 0.
        frmGame.txtPlayer1Bet.Text = 0
        frmGame.txtPlayer2Bet.Text = 0
        frmGame.txtPlayer3Bet.Text = 0
        frmGame.txtPlayer4Bet.Text = 0
    End Sub
    ''' <summary>
    ''' Checks each players bank balance. If they're bankrupt then disable their controls.
    ''' </summary>
    Public Sub Bankrupt()
        'Check if Player 1 is bankrupt.
        If Val(frmGame.lblPlayer1Bank.Text) <= 0 And frmGame.lblPlayer1Bank.Enabled = True Then
            MsgBox(Player1Name & " is Bankrupt")
            frmGame.lblPlayer1.Enabled = False
            frmGame.lblPlayer1Won.Enabled = False
            frmGame.lblPlayer1Odds.Enabled = False
            frmGame.lblPlayer1Bank.Enabled = False
            frmGame.txtPlayer1Bet.Text = "0"
            frmGame.txtPlayer1Bet.Enabled = False
            Call IsBettingEnabled()
        End If
        'Check if Player 2 is bankrupt.
        If Val(frmGame.lblPlayer2Bank.Text) <= 0 And frmGame.lblPlayer2Bank.Enabled = True Then
            MsgBox(Player2Name & " is Bankrupt")
            frmGame.lblPlayer2.Enabled = False
            frmGame.lblPlayer2Won.Enabled = False
            frmGame.lblPlayer2Odds.Enabled = False
            frmGame.lblPlayer2Bank.Enabled = False
            frmGame.txtPlayer2Bet.Text = "0"
            frmGame.txtPlayer2Bet.Enabled = False
            Call IsBettingEnabled()
        End If
        'Check if Player 3 is bankrupt.
        If Val(frmGame.lblPlayer3Bank.Text) <= 0 And frmGame.lblPlayer3Bank.Enabled = True Then
            MsgBox(Player3Name & " is Bankrupt")
            frmGame.lblPlayer3.Enabled = False
            frmGame.lblPlayer3Won.Enabled = False
            frmGame.lblPlayer3Odds.Enabled = False
            frmGame.lblPlayer3Bank.Enabled = False
            frmGame.txtPlayer3Bet.Text = "0"
            frmGame.txtPlayer3Bet.Enabled = False
            Call IsBettingEnabled()
        End If
        'Check if Player 4 is bankrupt.
        If Val(frmGame.lblPlayer4Bank.Text) <= 0 And frmGame.lblPlayer4Bank.Enabled = True Then
            MsgBox(Player4Name & " is Bankrupt")
            frmGame.lblPlayer4.Enabled = False
            frmGame.lblPlayer4Won.Enabled = False
            frmGame.lblPlayer4Odds.Enabled = False
            frmGame.lblPlayer4Bank.Enabled = False
            frmGame.txtPlayer4Bet.Text = "0"
            frmGame.txtPlayer4Bet.Enabled = False
            Call IsBettingEnabled()
        End If
        Call IsBettingEnabled()
    End Sub
    ''' <summary>
    ''' Checks each players bank balance. If a players balance is less than or equal to 0 then disable the players betting textbox, else enable them.
    ''' </summary>
    Public Sub IsBettingEnabled()
        If Val(frmGame.lblPlayer1Bank.Text) <= 0 Then
            frmGame.txtPlayer1Bet.Enabled = False
        Else : frmGame.txtPlayer1Bet.Enabled = True
        End If
        If Val(frmGame.lblPlayer2Bank.Text) <= 0 Then
            frmGame.txtPlayer2Bet.Enabled = False
        Else : frmGame.txtPlayer2Bet.Enabled = True
        End If
        If Val(frmGame.lblPlayer3Bank.Text) <= 0 Then
            frmGame.txtPlayer3Bet.Enabled = False
        Else : frmGame.txtPlayer3Bet.Enabled = True
        End If
        If Val(frmGame.lblPlayer4Bank.Text) <= 0 Then
            frmGame.txtPlayer4Bet.Enabled = False
        Else : frmGame.txtPlayer4Bet.Enabled = True
        End If
    End Sub
    ''' <summary>
    ''' If a race is in progress then disable the betting textboxes and 
    ''' disables the start race and reset buttons.
    ''' </summary>
    Public Sub NoMoreBets()
        If frmGame.tmrGameSpeed.Enabled Then
            frmGame.txtPlayer1Bet.Enabled = False
            frmGame.txtPlayer2Bet.Enabled = False
            frmGame.txtPlayer3Bet.Enabled = False
            frmGame.txtPlayer4Bet.Enabled = False
            frmGame.btnStart.Enabled = False
            frmGame.btnReset.Enabled = False
        Else : Call IsBettingEnabled()
            frmGame.btnStart.Enabled = True
            frmGame.btnReset.Enabled = True
        End If
    End Sub
    ''' <summary>
    ''' Initialises each players default Position and then sets the players location to those Positions.
    ''' </summary>
    Public Sub ResetPlayerLocation()
        player1DefaultPos = New Point(12, 46)
        player2DefaultPos = New Point(12, 103)
        player3DefaultPos = New Point(12, 159)
        player4DefaultPos = New Point(12, 215)
        frmGame.picPlayer1.Location = player1DefaultPos
        frmGame.picPlayer2.Location = player2DefaultPos
        frmGame.picPlayer3.Location = player3DefaultPos
        frmGame.picPlayer4.Location = player4DefaultPos
    End Sub
    ''' <summary>
    ''' Resets player locations, bank balances, race wins and also enables player controls if they were bankrupt.
    ''' </summary>
    Public Sub ResetEverything()
        frmGame.tmrGameSpeed.Enabled = False
        Call SetOdds()
        Call ResetPlayerLocation()
        Call InitialiseBanks()
        Call ResetWins()
        Call NoMoreBets()
        Call DisableOptions()
        Call EnablePlayers()
        Call ResetGuesses()
        Player1Leader = 0
        Player2Leader = 0
        Player3Leader = 0
        Player4Leader = 0

    End Sub
    ''' <summary>
    ''' Used to enable all Player Controls if they were disabled.
    ''' </summary>
    Public Sub EnablePlayers()
        'Enable Player 1's controls.
        frmGame.lblPlayer1.Enabled = True
        frmGame.lblPlayer1Bank.Enabled = True
        frmGame.lblPlayer1Odds.Enabled = True
        frmGame.lblPlayer1Won.Enabled = True
        'Enable Player 2's controls.
        frmGame.lblPlayer2.Enabled = True
        frmGame.lblPlayer2Bank.Enabled = True
        frmGame.lblPlayer2Odds.Enabled = True
        frmGame.lblPlayer2Won.Enabled = True
        'Enable Player 3's controls.
        frmGame.lblPlayer3.Enabled = True
        frmGame.lblPlayer3Bank.Enabled = True
        frmGame.lblPlayer3Odds.Enabled = True
        frmGame.lblPlayer3Won.Enabled = True
        'Enable Player 4's controls.
        frmGame.lblPlayer4.Enabled = True
        frmGame.lblPlayer4Bank.Enabled = True
        frmGame.lblPlayer4Odds.Enabled = True
        frmGame.lblPlayer4Won.Enabled = True
    End Sub
    ''' <summary>
    ''' Resets all race win variables to 0.
    ''' </summary>
    Public Sub ResetWins()
        player1Wins = 0
        player2Wins = 0
        player3Wins = 0
        player4Wins = 0
        gamesToWin = 0
        frmGame.ProgressBar2.Value = 0
        frmGame.ProgressBar2.ToolTipText = "Progress of Games to Win"
        racesWon = 0
        frmGame.lblPlayer1Won.Text = player1Wins
        frmGame.lblPlayer2Won.Text = player2Wins
        frmGame.lblPlayer3Won.Text = player3Wins
        frmGame.lblPlayer4Won.Text = player4Wins
        frmGame.lblRacesWon.Text = "Races" & vbCrLf & "Won: " & racesWon
    End Sub
    ''' <summary>
    ''' Sets the Odds of each player to 9.
    ''' </summary>
    Public Sub SetOdds()
        Dim odds As Int16 = 9
        player1Odds = odds
        player2Odds = odds
        player3Odds = odds
        player4Odds = odds
        frmGame.lblPlayer1Odds.Text = player1Odds
        frmGame.lblPlayer2Odds.Text = player2Odds
        frmGame.lblPlayer3Odds.Text = player3Odds
        frmGame.lblPlayer4Odds.Text = player4Odds
    End Sub
    ''' <summary>
    ''' Resets each players guess for the double money mini game.
    ''' </summary>
    Public Sub ResetGuesses()
        Player1Guessed = False
        Player2Guessed = False
        Player3Guessed = False
        Player4Guessed = False
        Player1Double = False
        Player2Double = False
        Player3Double = False
        Player4Double = False
        frmGame.lblP1X2.Visible = False
        frmGame.lblP2X2.Visible = False
        frmGame.lblP3X2.Visible = False
        frmGame.lblP4X2.Visible = False
    End Sub
End Module