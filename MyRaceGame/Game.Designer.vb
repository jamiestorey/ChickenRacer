<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.tmrGameSpeed = New System.Windows.Forms.Timer(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.picPlayer1 = New System.Windows.Forms.PictureBox()
        Me.picPlayer2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer3 = New System.Windows.Forms.PictureBox()
        Me.picPlayer4 = New System.Windows.Forms.PictureBox()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.lblPlayer3 = New System.Windows.Forms.Label()
        Me.lblPlayer4 = New System.Windows.Forms.Label()
        Me.txtPlayer2Bet = New System.Windows.Forms.TextBox()
        Me.txtPlayer3Bet = New System.Windows.Forms.TextBox()
        Me.txtPlayer1Bet = New System.Windows.Forms.TextBox()
        Me.txtPlayer4Bet = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDoubleMoney = New System.Windows.Forms.Button()
        Me.lblP1X2 = New System.Windows.Forms.Label()
        Me.lblP2X2 = New System.Windows.Forms.Label()
        Me.lblP3X2 = New System.Windows.Forms.Label()
        Me.lblP4X2 = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.grpGamesToWin = New System.Windows.Forms.GroupBox()
        Me.optBestOf9 = New System.Windows.Forms.RadioButton()
        Me.optBestOf7 = New System.Windows.Forms.RadioButton()
        Me.optBestOf5 = New System.Windows.Forms.RadioButton()
        Me.optBestOf3 = New System.Windows.Forms.RadioButton()
        Me.optSpeedSlow = New System.Windows.Forms.RadioButton()
        Me.optSpeedNormal = New System.Windows.Forms.RadioButton()
        Me.optSpeedFast = New System.Windows.Forms.RadioButton()
        Me.optSpeedCustom = New System.Windows.Forms.RadioButton()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.tbarSpeed = New System.Windows.Forms.TrackBar()
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.lblPlayerBet = New System.Windows.Forms.Label()
        Me.lblPlayer4Bank = New System.Windows.Forms.Label()
        Me.lblPlayer3Bank = New System.Windows.Forms.Label()
        Me.lblPlayer2Bank = New System.Windows.Forms.Label()
        Me.lblPlayer1Bank = New System.Windows.Forms.Label()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.lblPlayer4Odds = New System.Windows.Forms.Label()
        Me.lblPlayer3Odds = New System.Windows.Forms.Label()
        Me.lblPlayer2Odds = New System.Windows.Forms.Label()
        Me.lblPlayer1Odds = New System.Windows.Forms.Label()
        Me.lblOdds = New System.Windows.Forms.Label()
        Me.lblPlayer4Won = New System.Windows.Forms.Label()
        Me.lblPlayer3Won = New System.Windows.Forms.Label()
        Me.lblPlayer2Won = New System.Windows.Forms.Label()
        Me.lblPlayer1Won = New System.Windows.Forms.Label()
        Me.lblRacesWon = New System.Windows.Forms.Label()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.toolStripGame = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolView = New System.Windows.Forms.ToolStripDropDownButton()
        Me.GameOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolBTNOptions = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.toolBTNPause = New System.Windows.Forms.ToolStripButton()
        Me.toolBTNResume = New System.Windows.Forms.ToolStripButton()
        Me.ProgressBar2 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.linFinish = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOptions.SuspendLayout()
        Me.grpGamesToWin.SuspendLayout()
        CType(Me.tbarSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContentPanel.SuspendLayout()
        Me.grpInfo.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.toolStripGame.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrGameSpeed
        '
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "Resources\help.html"
        '
        'picPlayer1
        '
        Me.HelpProvider1.SetHelpString(Me.picPlayer1, "These are the players.")
        Me.picPlayer1.Image = Global.MyRaceGame.My.Resources.Resources.RedChicken128
        Me.picPlayer1.Location = New System.Drawing.Point(24, 129)
        Me.picPlayer1.Margin = New System.Windows.Forms.Padding(6)
        Me.picPlayer1.Name = "picPlayer1"
        Me.HelpProvider1.SetShowHelp(Me.picPlayer1, True)
        Me.picPlayer1.Size = New System.Drawing.Size(200, 96)
        Me.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer1.TabIndex = 0
        Me.picPlayer1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picPlayer1, "These are the players.")
        '
        'picPlayer2
        '
        Me.HelpProvider1.SetHelpString(Me.picPlayer2, "These are the players.")
        Me.picPlayer2.Image = Global.MyRaceGame.My.Resources.Resources.BlueChicken128
        Me.picPlayer2.Location = New System.Drawing.Point(24, 237)
        Me.picPlayer2.Margin = New System.Windows.Forms.Padding(6)
        Me.picPlayer2.Name = "picPlayer2"
        Me.HelpProvider1.SetShowHelp(Me.picPlayer2, True)
        Me.picPlayer2.Size = New System.Drawing.Size(200, 96)
        Me.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer2.TabIndex = 1
        Me.picPlayer2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picPlayer2, "These are the players.")
        '
        'picPlayer3
        '
        Me.HelpProvider1.SetHelpString(Me.picPlayer3, "These are the players.")
        Me.picPlayer3.Image = Global.MyRaceGame.My.Resources.Resources.GreenChicken128
        Me.picPlayer3.Location = New System.Drawing.Point(24, 344)
        Me.picPlayer3.Margin = New System.Windows.Forms.Padding(6)
        Me.picPlayer3.Name = "picPlayer3"
        Me.HelpProvider1.SetShowHelp(Me.picPlayer3, True)
        Me.picPlayer3.Size = New System.Drawing.Size(200, 96)
        Me.picPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer3.TabIndex = 2
        Me.picPlayer3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picPlayer3, "These are the players.")
        '
        'picPlayer4
        '
        Me.HelpProvider1.SetHelpString(Me.picPlayer4, "These are the players.")
        Me.picPlayer4.Image = Global.MyRaceGame.My.Resources.Resources.YellowChicken128
        Me.picPlayer4.Location = New System.Drawing.Point(24, 452)
        Me.picPlayer4.Margin = New System.Windows.Forms.Padding(6)
        Me.picPlayer4.Name = "picPlayer4"
        Me.HelpProvider1.SetShowHelp(Me.picPlayer4, True)
        Me.picPlayer4.Size = New System.Drawing.Size(200, 96)
        Me.picPlayer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer4.TabIndex = 3
        Me.picPlayer4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picPlayer4, "These are the players.")
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayer1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1.ForeColor = System.Drawing.Color.Red
        Me.HelpProvider1.SetHelpString(Me.lblPlayer1, "Click to change a player name.")
        Me.lblPlayer1.Location = New System.Drawing.Point(110, 81)
        Me.lblPlayer1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.HelpProvider1.SetShowHelp(Me.lblPlayer1, True)
        Me.lblPlayer1.Size = New System.Drawing.Size(100, 26)
        Me.lblPlayer1.TabIndex = 0
        Me.lblPlayer1.Text = "Player 1"
        Me.ToolTip1.SetToolTip(Me.lblPlayer1, "Click to change a player name.")
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayer2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2.ForeColor = System.Drawing.Color.Blue
        Me.HelpProvider1.SetHelpString(Me.lblPlayer2, "Click to change a player name.")
        Me.lblPlayer2.Location = New System.Drawing.Point(212, 81)
        Me.lblPlayer2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.HelpProvider1.SetShowHelp(Me.lblPlayer2, True)
        Me.lblPlayer2.Size = New System.Drawing.Size(100, 26)
        Me.lblPlayer2.TabIndex = 1
        Me.lblPlayer2.Text = "Player 2"
        Me.ToolTip1.SetToolTip(Me.lblPlayer2, "Click to change a player name.")
        '
        'lblPlayer3
        '
        Me.lblPlayer3.AutoSize = True
        Me.lblPlayer3.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayer3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPlayer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer3.ForeColor = System.Drawing.Color.Green
        Me.HelpProvider1.SetHelpString(Me.lblPlayer3, "Click to change a player name.")
        Me.lblPlayer3.Location = New System.Drawing.Point(314, 81)
        Me.lblPlayer3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer3.Name = "lblPlayer3"
        Me.HelpProvider1.SetShowHelp(Me.lblPlayer3, True)
        Me.lblPlayer3.Size = New System.Drawing.Size(100, 26)
        Me.lblPlayer3.TabIndex = 2
        Me.lblPlayer3.Text = "Player 3"
        Me.ToolTip1.SetToolTip(Me.lblPlayer3, "Click to change a player name.")
        '
        'lblPlayer4
        '
        Me.lblPlayer4.AutoSize = True
        Me.lblPlayer4.BackColor = System.Drawing.Color.Black
        Me.lblPlayer4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPlayer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer4.ForeColor = System.Drawing.Color.Yellow
        Me.HelpProvider1.SetHelpString(Me.lblPlayer4, "Click to change a player name.")
        Me.lblPlayer4.Location = New System.Drawing.Point(416, 81)
        Me.lblPlayer4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer4.Name = "lblPlayer4"
        Me.HelpProvider1.SetShowHelp(Me.lblPlayer4, True)
        Me.lblPlayer4.Size = New System.Drawing.Size(92, 26)
        Me.lblPlayer4.TabIndex = 3
        Me.lblPlayer4.Text = "Player 4"
        Me.ToolTip1.SetToolTip(Me.lblPlayer4, "Click to change a player name.")
        '
        'txtPlayer2Bet
        '
        Me.HelpProvider1.SetHelpKeyword(Me.txtPlayer2Bet, "help")
        Me.HelpProvider1.SetHelpString(Me.txtPlayer2Bet, "This is a betting textbox. Type the amount you would like to bet here.")
        Me.txtPlayer2Bet.Location = New System.Drawing.Point(218, 296)
        Me.txtPlayer2Bet.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPlayer2Bet.MaxLength = 5
        Me.txtPlayer2Bet.Name = "txtPlayer2Bet"
        Me.txtPlayer2Bet.ShortcutsEnabled = False
        Me.HelpProvider1.SetShowHelp(Me.txtPlayer2Bet, True)
        Me.txtPlayer2Bet.Size = New System.Drawing.Size(80, 32)
        Me.txtPlayer2Bet.TabIndex = 20
        Me.txtPlayer2Bet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPlayer2Bet.WordWrap = False
        '
        'txtPlayer3Bet
        '
        Me.HelpProvider1.SetHelpKeyword(Me.txtPlayer3Bet, "help")
        Me.HelpProvider1.SetHelpString(Me.txtPlayer3Bet, "This is a betting textbox. Type the amount you would like to bet here.")
        Me.txtPlayer3Bet.Location = New System.Drawing.Point(320, 296)
        Me.txtPlayer3Bet.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPlayer3Bet.MaxLength = 5
        Me.txtPlayer3Bet.Name = "txtPlayer3Bet"
        Me.txtPlayer3Bet.ShortcutsEnabled = False
        Me.HelpProvider1.SetShowHelp(Me.txtPlayer3Bet, True)
        Me.txtPlayer3Bet.Size = New System.Drawing.Size(80, 32)
        Me.txtPlayer3Bet.TabIndex = 21
        Me.txtPlayer3Bet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPlayer3Bet.WordWrap = False
        '
        'txtPlayer1Bet
        '
        Me.HelpProvider1.SetHelpKeyword(Me.txtPlayer1Bet, "help")
        Me.HelpProvider1.SetHelpString(Me.txtPlayer1Bet, "This is a betting textbox. Type the amount you would like to bet here.")
        Me.txtPlayer1Bet.Location = New System.Drawing.Point(116, 296)
        Me.txtPlayer1Bet.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPlayer1Bet.MaxLength = 5
        Me.txtPlayer1Bet.Name = "txtPlayer1Bet"
        Me.txtPlayer1Bet.ShortcutsEnabled = False
        Me.HelpProvider1.SetShowHelp(Me.txtPlayer1Bet, True)
        Me.txtPlayer1Bet.Size = New System.Drawing.Size(80, 32)
        Me.txtPlayer1Bet.TabIndex = 19
        Me.txtPlayer1Bet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPlayer1Bet.WordWrap = False
        '
        'txtPlayer4Bet
        '
        Me.HelpProvider1.SetHelpKeyword(Me.txtPlayer4Bet, "help")
        Me.HelpProvider1.SetHelpString(Me.txtPlayer4Bet, "This is a betting textbox. Type the amount you would like to bet here.")
        Me.txtPlayer4Bet.Location = New System.Drawing.Point(422, 296)
        Me.txtPlayer4Bet.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPlayer4Bet.MaxLength = 5
        Me.txtPlayer4Bet.Name = "txtPlayer4Bet"
        Me.txtPlayer4Bet.ShortcutsEnabled = False
        Me.HelpProvider1.SetShowHelp(Me.txtPlayer4Bet, True)
        Me.txtPlayer4Bet.Size = New System.Drawing.Size(80, 32)
        Me.txtPlayer4Bet.TabIndex = 22
        Me.txtPlayer4Bet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPlayer4Bet.WordWrap = False
        '
        'btnStart
        '
        Me.HelpProvider1.SetHelpString(Me.btnStart, "Click this button to start the race.")
        Me.btnStart.Location = New System.Drawing.Point(608, 52)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(6)
        Me.btnStart.Name = "btnStart"
        Me.HelpProvider1.SetShowHelp(Me.btnStart, True)
        Me.btnStart.Size = New System.Drawing.Size(150, 44)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.ToolTip1.SetToolTip(Me.btnStart, "Click this button to start the race.")
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.HelpProvider1.SetHelpString(Me.btnReset, "Click this button to reset everything,")
        Me.btnReset.Location = New System.Drawing.Point(608, 112)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(6)
        Me.btnReset.Name = "btnReset"
        Me.HelpProvider1.SetShowHelp(Me.btnReset, True)
        Me.btnReset.Size = New System.Drawing.Size(150, 44)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Click this button to reset everything,")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDoubleMoney
        '
        Me.HelpProvider1.SetHelpString(Me.btnDoubleMoney, "Click this button to start the double money minigame.")
        Me.btnDoubleMoney.Location = New System.Drawing.Point(608, 171)
        Me.btnDoubleMoney.Margin = New System.Windows.Forms.Padding(6)
        Me.btnDoubleMoney.Name = "btnDoubleMoney"
        Me.HelpProvider1.SetShowHelp(Me.btnDoubleMoney, True)
        Me.btnDoubleMoney.Size = New System.Drawing.Size(150, 87)
        Me.btnDoubleMoney.TabIndex = 8
        Me.btnDoubleMoney.Text = "Double Money"
        Me.ToolTip1.SetToolTip(Me.btnDoubleMoney, "Click this button to start the double money minigame.")
        Me.btnDoubleMoney.UseVisualStyleBackColor = True
        '
        'lblP1X2
        '
        Me.lblP1X2.AutoSize = True
        Me.lblP1X2.BackColor = System.Drawing.Color.Transparent
        Me.lblP1X2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblP1X2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1X2.ForeColor = System.Drawing.Color.Red
        Me.HelpProvider1.SetHelpString(Me.lblP1X2, "Your player has the chance to win double money!")
        Me.lblP1X2.Location = New System.Drawing.Point(164, 52)
        Me.lblP1X2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblP1X2.Name = "lblP1X2"
        Me.HelpProvider1.SetShowHelp(Me.lblP1X2, True)
        Me.lblP1X2.Size = New System.Drawing.Size(37, 26)
        Me.lblP1X2.TabIndex = 23
        Me.lblP1X2.Text = "x2"
        Me.ToolTip1.SetToolTip(Me.lblP1X2, "Your player has the chance to win double money!")
        Me.lblP1X2.Visible = False
        '
        'lblP2X2
        '
        Me.lblP2X2.AutoSize = True
        Me.lblP2X2.BackColor = System.Drawing.Color.Transparent
        Me.lblP2X2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblP2X2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2X2.ForeColor = System.Drawing.Color.Blue
        Me.HelpProvider1.SetHelpString(Me.lblP2X2, "Your player has the chance to win double money!")
        Me.lblP2X2.Location = New System.Drawing.Point(266, 52)
        Me.lblP2X2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblP2X2.Name = "lblP2X2"
        Me.HelpProvider1.SetShowHelp(Me.lblP2X2, True)
        Me.lblP2X2.Size = New System.Drawing.Size(37, 26)
        Me.lblP2X2.TabIndex = 24
        Me.lblP2X2.Text = "x2"
        Me.ToolTip1.SetToolTip(Me.lblP2X2, "Your player has the chance to win double money!")
        Me.lblP2X2.Visible = False
        '
        'lblP3X2
        '
        Me.lblP3X2.AutoSize = True
        Me.lblP3X2.BackColor = System.Drawing.Color.Transparent
        Me.lblP3X2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblP3X2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP3X2.ForeColor = System.Drawing.Color.Green
        Me.HelpProvider1.SetHelpString(Me.lblP3X2, "Your player has the chance to win double money!")
        Me.lblP3X2.Location = New System.Drawing.Point(368, 52)
        Me.lblP3X2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblP3X2.Name = "lblP3X2"
        Me.HelpProvider1.SetShowHelp(Me.lblP3X2, True)
        Me.lblP3X2.Size = New System.Drawing.Size(37, 26)
        Me.lblP3X2.TabIndex = 25
        Me.lblP3X2.Text = "x2"
        Me.ToolTip1.SetToolTip(Me.lblP3X2, "Your player has the chance to win double money!")
        Me.lblP3X2.Visible = False
        '
        'lblP4X2
        '
        Me.lblP4X2.AutoSize = True
        Me.lblP4X2.BackColor = System.Drawing.Color.Black
        Me.lblP4X2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblP4X2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP4X2.ForeColor = System.Drawing.Color.Yellow
        Me.HelpProvider1.SetHelpString(Me.lblP4X2, "Your player has the chance to win double money!")
        Me.lblP4X2.Location = New System.Drawing.Point(470, 52)
        Me.lblP4X2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblP4X2.Name = "lblP4X2"
        Me.HelpProvider1.SetShowHelp(Me.lblP4X2, True)
        Me.lblP4X2.Size = New System.Drawing.Size(35, 26)
        Me.lblP4X2.TabIndex = 26
        Me.lblP4X2.Text = "x2"
        Me.ToolTip1.SetToolTip(Me.lblP4X2, "Your player has the chance to win double money!")
        Me.lblP4X2.Visible = False
        '
        'grpOptions
        '
        Me.grpOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpOptions.Controls.Add(Me.grpGamesToWin)
        Me.grpOptions.Controls.Add(Me.optSpeedSlow)
        Me.grpOptions.Controls.Add(Me.optSpeedNormal)
        Me.grpOptions.Controls.Add(Me.optSpeedFast)
        Me.grpOptions.Controls.Add(Me.optSpeedCustom)
        Me.grpOptions.Controls.Add(Me.lblSpeed)
        Me.grpOptions.Controls.Add(Me.tbarSpeed)
        Me.HelpProvider1.SetHelpString(Me.grpOptions, "here you can change the race options.")
        Me.grpOptions.Location = New System.Drawing.Point(806, 621)
        Me.grpOptions.Margin = New System.Windows.Forms.Padding(6)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Padding = New System.Windows.Forms.Padding(6)
        Me.HelpProvider1.SetShowHelp(Me.grpOptions, True)
        Me.grpOptions.Size = New System.Drawing.Size(554, 298)
        Me.grpOptions.TabIndex = 6
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Game Options:"
        '
        'grpGamesToWin
        '
        Me.grpGamesToWin.Controls.Add(Me.optBestOf9)
        Me.grpGamesToWin.Controls.Add(Me.optBestOf7)
        Me.grpGamesToWin.Controls.Add(Me.optBestOf5)
        Me.grpGamesToWin.Controls.Add(Me.optBestOf3)
        Me.grpGamesToWin.Location = New System.Drawing.Point(254, 52)
        Me.grpGamesToWin.Margin = New System.Windows.Forms.Padding(6)
        Me.grpGamesToWin.Name = "grpGamesToWin"
        Me.grpGamesToWin.Padding = New System.Windows.Forms.Padding(6)
        Me.grpGamesToWin.Size = New System.Drawing.Size(262, 231)
        Me.grpGamesToWin.TabIndex = 7
        Me.grpGamesToWin.TabStop = False
        Me.grpGamesToWin.Text = "Games to Win:"
        '
        'optBestOf9
        '
        Me.optBestOf9.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.optBestOf9, "Choose how many races are required to win overall.")
        Me.optBestOf9.Location = New System.Drawing.Point(12, 177)
        Me.optBestOf9.Margin = New System.Windows.Forms.Padding(6)
        Me.optBestOf9.Name = "optBestOf9"
        Me.HelpProvider1.SetShowHelp(Me.optBestOf9, True)
        Me.optBestOf9.Size = New System.Drawing.Size(138, 30)
        Me.optBestOf9.TabIndex = 9
        Me.optBestOf9.TabStop = True
        Me.optBestOf9.Text = "Best of 9"
        Me.ToolTip1.SetToolTip(Me.optBestOf9, "Choose how many races are required to win overall.")
        Me.optBestOf9.UseVisualStyleBackColor = True
        '
        'optBestOf7
        '
        Me.optBestOf7.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.optBestOf7, "Choose how many races are required to win overall.")
        Me.optBestOf7.Location = New System.Drawing.Point(12, 133)
        Me.optBestOf7.Margin = New System.Windows.Forms.Padding(6)
        Me.optBestOf7.Name = "optBestOf7"
        Me.HelpProvider1.SetShowHelp(Me.optBestOf7, True)
        Me.optBestOf7.Size = New System.Drawing.Size(138, 30)
        Me.optBestOf7.TabIndex = 10
        Me.optBestOf7.TabStop = True
        Me.optBestOf7.Text = "Best of 7"
        Me.ToolTip1.SetToolTip(Me.optBestOf7, "Choose how many races are required to win overall.")
        Me.optBestOf7.UseVisualStyleBackColor = True
        '
        'optBestOf5
        '
        Me.optBestOf5.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.optBestOf5, "Choose how many races are required to win overall.")
        Me.optBestOf5.Location = New System.Drawing.Point(12, 88)
        Me.optBestOf5.Margin = New System.Windows.Forms.Padding(6)
        Me.optBestOf5.Name = "optBestOf5"
        Me.HelpProvider1.SetShowHelp(Me.optBestOf5, True)
        Me.optBestOf5.Size = New System.Drawing.Size(138, 30)
        Me.optBestOf5.TabIndex = 9
        Me.optBestOf5.TabStop = True
        Me.optBestOf5.Text = "Best of 5"
        Me.ToolTip1.SetToolTip(Me.optBestOf5, "Choose how many races are required to win overall.")
        Me.optBestOf5.UseVisualStyleBackColor = True
        '
        'optBestOf3
        '
        Me.optBestOf3.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.optBestOf3, "Choose how many races are required to win overall.")
        Me.optBestOf3.Location = New System.Drawing.Point(12, 44)
        Me.optBestOf3.Margin = New System.Windows.Forms.Padding(6)
        Me.optBestOf3.Name = "optBestOf3"
        Me.HelpProvider1.SetShowHelp(Me.optBestOf3, True)
        Me.optBestOf3.Size = New System.Drawing.Size(138, 30)
        Me.optBestOf3.TabIndex = 8
        Me.optBestOf3.TabStop = True
        Me.optBestOf3.Text = "Best of 3"
        Me.ToolTip1.SetToolTip(Me.optBestOf3, "Choose how many races are required to win overall.")
        Me.optBestOf3.UseVisualStyleBackColor = True
        '
        'optSpeedSlow
        '
        Me.optSpeedSlow.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.optSpeedSlow, "Change the game speed")
        Me.optSpeedSlow.Location = New System.Drawing.Point(18, 229)
        Me.optSpeedSlow.Margin = New System.Windows.Forms.Padding(6)
        Me.optSpeedSlow.Name = "optSpeedSlow"
        Me.HelpProvider1.SetShowHelp(Me.optSpeedSlow, True)
        Me.optSpeedSlow.Size = New System.Drawing.Size(95, 30)
        Me.optSpeedSlow.TabIndex = 5
        Me.optSpeedSlow.TabStop = True
        Me.optSpeedSlow.Text = "Slow"
        Me.ToolTip1.SetToolTip(Me.optSpeedSlow, "Change the game speed")
        Me.optSpeedSlow.UseVisualStyleBackColor = True
        '
        'optSpeedNormal
        '
        Me.optSpeedNormal.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.optSpeedNormal, "Change the game speed")
        Me.optSpeedNormal.Location = New System.Drawing.Point(18, 185)
        Me.optSpeedNormal.Margin = New System.Windows.Forms.Padding(6)
        Me.optSpeedNormal.Name = "optSpeedNormal"
        Me.HelpProvider1.SetShowHelp(Me.optSpeedNormal, True)
        Me.optSpeedNormal.Size = New System.Drawing.Size(120, 30)
        Me.optSpeedNormal.TabIndex = 4
        Me.optSpeedNormal.TabStop = True
        Me.optSpeedNormal.Text = "Normal"
        Me.ToolTip1.SetToolTip(Me.optSpeedNormal, "Change the game speed")
        Me.optSpeedNormal.UseVisualStyleBackColor = True
        '
        'optSpeedFast
        '
        Me.optSpeedFast.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.optSpeedFast, "Change the game speed")
        Me.optSpeedFast.Location = New System.Drawing.Point(18, 140)
        Me.optSpeedFast.Margin = New System.Windows.Forms.Padding(6)
        Me.optSpeedFast.Name = "optSpeedFast"
        Me.HelpProvider1.SetShowHelp(Me.optSpeedFast, True)
        Me.optSpeedFast.Size = New System.Drawing.Size(89, 30)
        Me.optSpeedFast.TabIndex = 3
        Me.optSpeedFast.TabStop = True
        Me.optSpeedFast.Text = "Fast"
        Me.ToolTip1.SetToolTip(Me.optSpeedFast, "Change the game speed")
        Me.optSpeedFast.UseVisualStyleBackColor = True
        '
        'optSpeedCustom
        '
        Me.optSpeedCustom.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.optSpeedCustom, "Change the game speed")
        Me.optSpeedCustom.Location = New System.Drawing.Point(18, 96)
        Me.optSpeedCustom.Margin = New System.Windows.Forms.Padding(6)
        Me.optSpeedCustom.Name = "optSpeedCustom"
        Me.HelpProvider1.SetShowHelp(Me.optSpeedCustom, True)
        Me.optSpeedCustom.Size = New System.Drawing.Size(125, 30)
        Me.optSpeedCustom.TabIndex = 2
        Me.optSpeedCustom.TabStop = True
        Me.optSpeedCustom.Text = "Custom"
        Me.ToolTip1.SetToolTip(Me.optSpeedCustom, "Change the game speed")
        Me.optSpeedCustom.UseVisualStyleBackColor = True
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.lblSpeed, "Choose how many races are required to win overall.")
        Me.lblSpeed.Location = New System.Drawing.Point(12, 52)
        Me.lblSpeed.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSpeed.Name = "lblSpeed"
        Me.HelpProvider1.SetShowHelp(Me.lblSpeed, True)
        Me.lblSpeed.Size = New System.Drawing.Size(178, 26)
        Me.lblSpeed.TabIndex = 0
        Me.lblSpeed.Text = "Game Speed: 0"
        '
        'tbarSpeed
        '
        Me.tbarSpeed.BackColor = System.Drawing.Color.Salmon
        Me.HelpProvider1.SetHelpString(Me.tbarSpeed, "Change the game speed")
        Me.tbarSpeed.Location = New System.Drawing.Point(146, 81)
        Me.tbarSpeed.Margin = New System.Windows.Forms.Padding(6)
        Me.tbarSpeed.Maximum = 100
        Me.tbarSpeed.Minimum = 1
        Me.tbarSpeed.Name = "tbarSpeed"
        Me.tbarSpeed.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbarSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbarSpeed.RightToLeftLayout = True
        Me.HelpProvider1.SetShowHelp(Me.tbarSpeed, True)
        Me.tbarSpeed.Size = New System.Drawing.Size(90, 200)
        Me.tbarSpeed.TabIndex = 1
        Me.tbarSpeed.TickFrequency = 25
        Me.ToolTip1.SetToolTip(Me.tbarSpeed, "Change the game speed")
        Me.tbarSpeed.Value = 1
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 506)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(932, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(150, 25)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightToolStripPanel.Location = New System.Drawing.Point(150, 25)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 150)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 25)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 150)
        '
        'ContentPanel
        '
        Me.ContentPanel.AutoScroll = True
        Me.ContentPanel.BackgroundImage = Global.MyRaceGame.My.Resources.Resources.g11
        Me.ContentPanel.Controls.Add(Me.ProgressBar1)
        Me.ContentPanel.Size = New System.Drawing.Size(932, 506)
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(300, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(400, 100)
        Me.ProgressBar1.TabIndex = 0
        '
        'grpInfo
        '
        Me.grpInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpInfo.Controls.Add(Me.lblP4X2)
        Me.grpInfo.Controls.Add(Me.lblP3X2)
        Me.grpInfo.Controls.Add(Me.lblP2X2)
        Me.grpInfo.Controls.Add(Me.lblP1X2)
        Me.grpInfo.Controls.Add(Me.btnDoubleMoney)
        Me.grpInfo.Controls.Add(Me.btnReset)
        Me.grpInfo.Controls.Add(Me.lblPlayerBet)
        Me.grpInfo.Controls.Add(Me.btnStart)
        Me.grpInfo.Controls.Add(Me.txtPlayer4Bet)
        Me.grpInfo.Controls.Add(Me.lblPlayer4Bank)
        Me.grpInfo.Controls.Add(Me.txtPlayer1Bet)
        Me.grpInfo.Controls.Add(Me.txtPlayer3Bet)
        Me.grpInfo.Controls.Add(Me.lblPlayer3Bank)
        Me.grpInfo.Controls.Add(Me.txtPlayer2Bet)
        Me.grpInfo.Controls.Add(Me.lblPlayer2Bank)
        Me.grpInfo.Controls.Add(Me.lblPlayer1Bank)
        Me.grpInfo.Controls.Add(Me.lblBank)
        Me.grpInfo.Controls.Add(Me.lblPlayer4Odds)
        Me.grpInfo.Controls.Add(Me.lblPlayer3Odds)
        Me.grpInfo.Controls.Add(Me.lblPlayer2Odds)
        Me.grpInfo.Controls.Add(Me.lblPlayer1Odds)
        Me.grpInfo.Controls.Add(Me.lblOdds)
        Me.grpInfo.Controls.Add(Me.lblPlayer4Won)
        Me.grpInfo.Controls.Add(Me.lblPlayer3Won)
        Me.grpInfo.Controls.Add(Me.lblPlayer2Won)
        Me.grpInfo.Controls.Add(Me.lblPlayer1Won)
        Me.grpInfo.Controls.Add(Me.lblRacesWon)
        Me.grpInfo.Controls.Add(Me.lblPlayer4)
        Me.grpInfo.Controls.Add(Me.lblPlayer3)
        Me.grpInfo.Controls.Add(Me.lblPlayer2)
        Me.grpInfo.Controls.Add(Me.lblPlayer1)
        Me.grpInfo.Location = New System.Drawing.Point(24, 569)
        Me.grpInfo.Margin = New System.Windows.Forms.Padding(6)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Padding = New System.Windows.Forms.Padding(6)
        Me.grpInfo.Size = New System.Drawing.Size(770, 350)
        Me.grpInfo.TabIndex = 5
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Game Info:"
        '
        'lblPlayerBet
        '
        Me.lblPlayerBet.AutoSize = True
        Me.lblPlayerBet.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerBet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerBet.Location = New System.Drawing.Point(12, 285)
        Me.lblPlayerBet.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayerBet.Name = "lblPlayerBet"
        Me.lblPlayerBet.Size = New System.Drawing.Size(80, 52)
        Me.lblPlayerBet.TabIndex = 8
        Me.lblPlayerBet.Text = "Player" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bet:"
        '
        'lblPlayer4Bank
        '
        Me.lblPlayer4Bank.AutoSize = True
        Me.lblPlayer4Bank.Location = New System.Drawing.Point(440, 248)
        Me.lblPlayer4Bank.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer4Bank.Name = "lblPlayer4Bank"
        Me.lblPlayer4Bank.Size = New System.Drawing.Size(25, 26)
        Me.lblPlayer4Bank.TabIndex = 18
        Me.lblPlayer4Bank.Text = "0"
        Me.lblPlayer4Bank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer3Bank
        '
        Me.lblPlayer3Bank.AutoSize = True
        Me.lblPlayer3Bank.Location = New System.Drawing.Point(340, 248)
        Me.lblPlayer3Bank.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer3Bank.Name = "lblPlayer3Bank"
        Me.lblPlayer3Bank.Size = New System.Drawing.Size(25, 26)
        Me.lblPlayer3Bank.TabIndex = 17
        Me.lblPlayer3Bank.Text = "0"
        Me.lblPlayer3Bank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer2Bank
        '
        Me.lblPlayer2Bank.AutoSize = True
        Me.lblPlayer2Bank.Location = New System.Drawing.Point(240, 248)
        Me.lblPlayer2Bank.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer2Bank.Name = "lblPlayer2Bank"
        Me.lblPlayer2Bank.Size = New System.Drawing.Size(25, 26)
        Me.lblPlayer2Bank.TabIndex = 16
        Me.lblPlayer2Bank.Text = "0"
        Me.lblPlayer2Bank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer1Bank
        '
        Me.lblPlayer1Bank.AutoSize = True
        Me.lblPlayer1Bank.Location = New System.Drawing.Point(140, 248)
        Me.lblPlayer1Bank.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer1Bank.Name = "lblPlayer1Bank"
        Me.lblPlayer1Bank.Size = New System.Drawing.Size(25, 26)
        Me.lblPlayer1Bank.TabIndex = 15
        Me.lblPlayer1Bank.Text = "0"
        Me.lblPlayer1Bank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBank
        '
        Me.lblBank.AutoSize = True
        Me.lblBank.BackColor = System.Drawing.Color.Transparent
        Me.lblBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBank.Location = New System.Drawing.Point(12, 248)
        Me.lblBank.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(73, 26)
        Me.lblBank.TabIndex = 14
        Me.lblBank.Text = "Bank:"
        '
        'lblPlayer4Odds
        '
        Me.lblPlayer4Odds.AutoSize = True
        Me.lblPlayer4Odds.Location = New System.Drawing.Point(440, 190)
        Me.lblPlayer4Odds.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer4Odds.Name = "lblPlayer4Odds"
        Me.lblPlayer4Odds.Size = New System.Drawing.Size(25, 26)
        Me.lblPlayer4Odds.TabIndex = 13
        Me.lblPlayer4Odds.Text = "0"
        Me.lblPlayer4Odds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer3Odds
        '
        Me.lblPlayer3Odds.AutoSize = True
        Me.lblPlayer3Odds.Location = New System.Drawing.Point(340, 190)
        Me.lblPlayer3Odds.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer3Odds.Name = "lblPlayer3Odds"
        Me.lblPlayer3Odds.Size = New System.Drawing.Size(25, 26)
        Me.lblPlayer3Odds.TabIndex = 12
        Me.lblPlayer3Odds.Text = "0"
        Me.lblPlayer3Odds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer2Odds
        '
        Me.lblPlayer2Odds.AutoSize = True
        Me.lblPlayer2Odds.Location = New System.Drawing.Point(240, 190)
        Me.lblPlayer2Odds.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer2Odds.Name = "lblPlayer2Odds"
        Me.lblPlayer2Odds.Size = New System.Drawing.Size(25, 26)
        Me.lblPlayer2Odds.TabIndex = 11
        Me.lblPlayer2Odds.Text = "0"
        Me.lblPlayer2Odds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer1Odds
        '
        Me.lblPlayer1Odds.AutoSize = True
        Me.lblPlayer1Odds.Location = New System.Drawing.Point(140, 190)
        Me.lblPlayer1Odds.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer1Odds.Name = "lblPlayer1Odds"
        Me.lblPlayer1Odds.Size = New System.Drawing.Size(25, 26)
        Me.lblPlayer1Odds.TabIndex = 10
        Me.lblPlayer1Odds.Text = "0"
        Me.lblPlayer1Odds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOdds
        '
        Me.lblOdds.AutoSize = True
        Me.lblOdds.BackColor = System.Drawing.Color.Transparent
        Me.lblOdds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOdds.Location = New System.Drawing.Point(12, 190)
        Me.lblOdds.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblOdds.Name = "lblOdds"
        Me.lblOdds.Size = New System.Drawing.Size(75, 26)
        Me.lblOdds.TabIndex = 9
        Me.lblOdds.Text = "Odds:"
        '
        'lblPlayer4Won
        '
        Me.lblPlayer4Won.AutoSize = True
        Me.lblPlayer4Won.Location = New System.Drawing.Point(440, 133)
        Me.lblPlayer4Won.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer4Won.Name = "lblPlayer4Won"
        Me.lblPlayer4Won.Size = New System.Drawing.Size(25, 26)
        Me.lblPlayer4Won.TabIndex = 8
        Me.lblPlayer4Won.Text = "0"
        Me.lblPlayer4Won.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer3Won
        '
        Me.lblPlayer3Won.AutoSize = True
        Me.lblPlayer3Won.Location = New System.Drawing.Point(340, 133)
        Me.lblPlayer3Won.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer3Won.Name = "lblPlayer3Won"
        Me.lblPlayer3Won.Size = New System.Drawing.Size(25, 26)
        Me.lblPlayer3Won.TabIndex = 7
        Me.lblPlayer3Won.Text = "0"
        Me.lblPlayer3Won.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer2Won
        '
        Me.lblPlayer2Won.AutoSize = True
        Me.lblPlayer2Won.Location = New System.Drawing.Point(240, 133)
        Me.lblPlayer2Won.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer2Won.Name = "lblPlayer2Won"
        Me.lblPlayer2Won.Size = New System.Drawing.Size(25, 26)
        Me.lblPlayer2Won.TabIndex = 6
        Me.lblPlayer2Won.Text = "0"
        Me.lblPlayer2Won.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer1Won
        '
        Me.lblPlayer1Won.AutoSize = True
        Me.lblPlayer1Won.Location = New System.Drawing.Point(140, 133)
        Me.lblPlayer1Won.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer1Won.Name = "lblPlayer1Won"
        Me.lblPlayer1Won.Size = New System.Drawing.Size(25, 26)
        Me.lblPlayer1Won.TabIndex = 5
        Me.lblPlayer1Won.Text = "0"
        Me.lblPlayer1Won.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRacesWon
        '
        Me.lblRacesWon.AutoSize = True
        Me.lblRacesWon.BackColor = System.Drawing.Color.Transparent
        Me.lblRacesWon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRacesWon.Location = New System.Drawing.Point(12, 108)
        Me.lblRacesWon.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblRacesWon.Name = "lblRacesWon"
        Me.lblRacesWon.Size = New System.Drawing.Size(86, 52)
        Me.lblRacesWon.TabIndex = 4
        Me.lblRacesWon.Text = "Races " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Won:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.AutoScroll = True
        Me.ToolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripContainer1.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.toolStripGame)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.grpOptions)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.grpInfo)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.picPlayer4)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.picPlayer3)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.picPlayer2)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.picPlayer1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ShapeContainer1)
        Me.ToolStripContainer1.ContentPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1864, 973)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(6)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1864, 973)
        Me.ToolStripContainer1.TabIndex = 8
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'toolStripGame
        '
        Me.toolStripGame.AllowItemReorder = True
        Me.toolStripGame.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolStripGame.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.toolView, Me.toolBTNOptions, Me.ToolStripButton1, Me.ToolStripButton2, Me.toolBTNPause, Me.toolBTNResume, Me.ProgressBar2})
        Me.toolStripGame.Location = New System.Drawing.Point(0, 0)
        Me.toolStripGame.Name = "toolStripGame"
        Me.toolStripGame.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.toolStripGame.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.toolStripGame.Size = New System.Drawing.Size(1862, 45)
        Me.toolStripGame.TabIndex = 8
        Me.toolStripGame.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1})
        Me.ToolStripDropDownButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(67, 42)
        Me.ToolStripDropDownButton1.Text = "File"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem})
        Me.ExitToolStripMenuItem1.Image = CType(resources.GetObject("ExitToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.White
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(132, 36)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(221, 36)
        Me.MainMenuToolStripMenuItem.Text = "Main Menu"
        '
        'toolView
        '
        Me.toolView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameOptionsToolStripMenuItem, Me.GameInfoToolStripMenuItem})
        Me.toolView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolView.Image = CType(resources.GetObject("toolView.Image"), System.Drawing.Image)
        Me.toolView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolView.Name = "toolView"
        Me.toolView.Size = New System.Drawing.Size(83, 42)
        Me.toolView.Text = "View"
        '
        'GameOptionsToolStripMenuItem
        '
        Me.GameOptionsToolStripMenuItem.Checked = True
        Me.GameOptionsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GameOptionsToolStripMenuItem.Name = "GameOptionsToolStripMenuItem"
        Me.GameOptionsToolStripMenuItem.Size = New System.Drawing.Size(252, 36)
        Me.GameOptionsToolStripMenuItem.Text = "Game Options"
        '
        'GameInfoToolStripMenuItem
        '
        Me.GameInfoToolStripMenuItem.Checked = True
        Me.GameInfoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GameInfoToolStripMenuItem.Name = "GameInfoToolStripMenuItem"
        Me.GameInfoToolStripMenuItem.Size = New System.Drawing.Size(252, 36)
        Me.GameInfoToolStripMenuItem.Text = "Game Info"
        '
        'toolBTNOptions
        '
        Me.toolBTNOptions.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolBTNOptions.Image = Global.MyRaceGame.My.Resources.Resources.tools
        Me.toolBTNOptions.ImageTransparentColor = System.Drawing.Color.White
        Me.toolBTNOptions.Name = "toolBTNOptions"
        Me.toolBTNOptions.Size = New System.Drawing.Size(125, 42)
        Me.toolBTNOptions.Text = "Options"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = Global.MyRaceGame.My.Resources.Resources.leaderboard
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.White
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(190, 42)
        Me.ToolStripButton1.Text = "Leaderboards"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = Global.MyRaceGame.My.Resources.Resources.helpQuestion
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.White
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(88, 42)
        Me.ToolStripButton2.Text = "Help"
        '
        'toolBTNPause
        '
        Me.toolBTNPause.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolBTNPause.Image = Global.MyRaceGame.My.Resources.Resources.pause
        Me.toolBTNPause.ImageTransparentColor = System.Drawing.Color.White
        Me.toolBTNPause.Name = "toolBTNPause"
        Me.toolBTNPause.Size = New System.Drawing.Size(101, 42)
        Me.toolBTNPause.Text = "Pause"
        '
        'toolBTNResume
        '
        Me.toolBTNResume.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolBTNResume.Image = Global.MyRaceGame.My.Resources.Resources.play
        Me.toolBTNResume.ImageTransparentColor = System.Drawing.Color.White
        Me.toolBTNResume.Name = "toolBTNResume"
        Me.toolBTNResume.Size = New System.Drawing.Size(83, 42)
        Me.toolBTNResume.Text = "Play"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.AutoSize = False
        Me.ProgressBar2.BackColor = System.Drawing.SystemColors.Control
        Me.ProgressBar2.MergeIndex = 0
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(200, 42)
        Me.ProgressBar2.ToolTipText = "Progress of Games to Win"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.linFinish})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1862, 971)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'linFinish
        '
        Me.linFinish.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linFinish.Name = "linFinish"
        Me.linFinish.SelectionColor = System.Drawing.SystemColors.Control
        Me.linFinish.X1 = 1857
        Me.linFinish.X2 = 1857
        Me.linFinish.Y1 = 65
        Me.linFinish.Y2 = 299
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1864, 973)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MinimizeBox = False
        Me.Name = "frmGame"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chicken Racer"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpGamesToWin.ResumeLayout(False)
        Me.grpGamesToWin.PerformLayout()
        CType(Me.tbarSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContentPanel.ResumeLayout(False)
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.toolStripGame.ResumeLayout(False)
        Me.toolStripGame.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    ' Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    ' Friend WithEvents linDiv As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents tmrSpeed As System.Windows.Forms.Timer
    Friend WithEvents tmrGameSpeed As System.Windows.Forms.Timer
    Public WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents picPlayer1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer2 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer3 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer4 As System.Windows.Forms.PictureBox
    Friend WithEvents grpInfo As System.Windows.Forms.GroupBox
    Public WithEvents lblP4X2 As System.Windows.Forms.Label
    Public WithEvents lblP3X2 As System.Windows.Forms.Label
    Public WithEvents lblP2X2 As System.Windows.Forms.Label
    Public WithEvents lblP1X2 As System.Windows.Forms.Label
    Friend WithEvents btnDoubleMoney As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblPlayerBet As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txtPlayer4Bet As System.Windows.Forms.TextBox
    Public WithEvents lblPlayer4Bank As System.Windows.Forms.Label
    Friend WithEvents txtPlayer1Bet As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer3Bet As System.Windows.Forms.TextBox
    Public WithEvents lblPlayer3Bank As System.Windows.Forms.Label
    Friend WithEvents txtPlayer2Bet As System.Windows.Forms.TextBox
    Public WithEvents lblPlayer2Bank As System.Windows.Forms.Label
    Public WithEvents lblPlayer1Bank As System.Windows.Forms.Label
    Public WithEvents lblBank As System.Windows.Forms.Label
    Public WithEvents lblPlayer4Odds As System.Windows.Forms.Label
    Public WithEvents lblPlayer3Odds As System.Windows.Forms.Label
    Public WithEvents lblPlayer2Odds As System.Windows.Forms.Label
    Public WithEvents lblPlayer1Odds As System.Windows.Forms.Label
    Public WithEvents lblOdds As System.Windows.Forms.Label
    Public WithEvents lblPlayer4Won As System.Windows.Forms.Label
    Public WithEvents lblPlayer3Won As System.Windows.Forms.Label
    Public WithEvents lblPlayer2Won As System.Windows.Forms.Label
    Public WithEvents lblPlayer1Won As System.Windows.Forms.Label
    Public WithEvents lblRacesWon As System.Windows.Forms.Label
    Public WithEvents lblPlayer4 As System.Windows.Forms.Label
    Public WithEvents lblPlayer3 As System.Windows.Forms.Label
    Public WithEvents lblPlayer2 As System.Windows.Forms.Label
    Public WithEvents lblPlayer1 As System.Windows.Forms.Label
    Friend WithEvents grpOptions As System.Windows.Forms.GroupBox
    Friend WithEvents grpGamesToWin As System.Windows.Forms.GroupBox
    Friend WithEvents optBestOf9 As System.Windows.Forms.RadioButton
    Friend WithEvents optBestOf7 As System.Windows.Forms.RadioButton
    Friend WithEvents optBestOf5 As System.Windows.Forms.RadioButton
    Friend WithEvents optBestOf3 As System.Windows.Forms.RadioButton
    Friend WithEvents optSpeedSlow As System.Windows.Forms.RadioButton
    Friend WithEvents optSpeedNormal As System.Windows.Forms.RadioButton
    Friend WithEvents optSpeedFast As System.Windows.Forms.RadioButton
    Friend WithEvents optSpeedCustom As System.Windows.Forms.RadioButton
    Friend WithEvents tbarSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Private WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents toolStripGame As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolBTNPause As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolBTNResume As System.Windows.Forms.ToolStripButton
    Friend WithEvents MainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolView As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents GameOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GameInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolBTNOptions As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents linFinish As Microsoft.VisualBasic.PowerPacks.LineShape

End Class
