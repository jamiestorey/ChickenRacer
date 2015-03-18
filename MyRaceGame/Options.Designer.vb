<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblPlayer1TotalWins = New System.Windows.Forms.Label()
        Me.lblPlayer2TotalWins = New System.Windows.Forms.Label()
        Me.lblPlayer3TotalWins = New System.Windows.Forms.Label()
        Me.lblPlayer4TotalWins = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabAppearance = New System.Windows.Forms.TabPage()
        Me.lblToolStripColour = New System.Windows.Forms.Label()
        Me.pnlToolStripColour = New System.Windows.Forms.Panel()
        Me.lblBackgroundColour = New System.Windows.Forms.Label()
        Me.pnlBackgroundColour = New System.Windows.Forms.Panel()
        Me.tabLeader = New System.Windows.Forms.TabPage()
        Me.pnlPlayer4Leader = New System.Windows.Forms.Panel()
        Me.pnlPlayer3Leader = New System.Windows.Forms.Panel()
        Me.pnlPlayer2Leader = New System.Windows.Forms.Panel()
        Me.pnlPlayer1Leader = New System.Windows.Forms.Panel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.tabAppearance.SuspendLayout()
        Me.tabLeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(518, 535)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 44)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblPlayer1TotalWins
        '
        Me.lblPlayer1TotalWins.AutoSize = True
        Me.lblPlayer1TotalWins.ForeColor = System.Drawing.Color.Red
        Me.lblPlayer1TotalWins.Location = New System.Drawing.Point(302, 75)
        Me.lblPlayer1TotalWins.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer1TotalWins.Name = "lblPlayer1TotalWins"
        Me.lblPlayer1TotalWins.Size = New System.Drawing.Size(24, 25)
        Me.lblPlayer1TotalWins.TabIndex = 2
        Me.lblPlayer1TotalWins.Text = "0"
        '
        'lblPlayer2TotalWins
        '
        Me.lblPlayer2TotalWins.AutoSize = True
        Me.lblPlayer2TotalWins.ForeColor = System.Drawing.Color.Blue
        Me.lblPlayer2TotalWins.Location = New System.Drawing.Point(392, 75)
        Me.lblPlayer2TotalWins.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer2TotalWins.Name = "lblPlayer2TotalWins"
        Me.lblPlayer2TotalWins.Size = New System.Drawing.Size(24, 25)
        Me.lblPlayer2TotalWins.TabIndex = 3
        Me.lblPlayer2TotalWins.Text = "0"
        '
        'lblPlayer3TotalWins
        '
        Me.lblPlayer3TotalWins.AutoSize = True
        Me.lblPlayer3TotalWins.ForeColor = System.Drawing.Color.Green
        Me.lblPlayer3TotalWins.Location = New System.Drawing.Point(482, 75)
        Me.lblPlayer3TotalWins.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer3TotalWins.Name = "lblPlayer3TotalWins"
        Me.lblPlayer3TotalWins.Size = New System.Drawing.Size(24, 25)
        Me.lblPlayer3TotalWins.TabIndex = 4
        Me.lblPlayer3TotalWins.Text = "0"
        '
        'lblPlayer4TotalWins
        '
        Me.lblPlayer4TotalWins.AutoSize = True
        Me.lblPlayer4TotalWins.ForeColor = System.Drawing.Color.Yellow
        Me.lblPlayer4TotalWins.Location = New System.Drawing.Point(572, 75)
        Me.lblPlayer4TotalWins.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPlayer4TotalWins.Name = "lblPlayer4TotalWins"
        Me.lblPlayer4TotalWins.Size = New System.Drawing.Size(24, 25)
        Me.lblPlayer4TotalWins.TabIndex = 5
        Me.lblPlayer4TotalWins.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(264, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 44)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Player 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Wins"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(366, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 44)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Player 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Wins"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(468, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 44)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Player 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Wins"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(556, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 44)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Player 4 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wins"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabAppearance)
        Me.TabControl1.Controls.Add(Me.tabLeader)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(10, 23)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(658, 500)
        Me.TabControl1.TabIndex = 10
        '
        'tabAppearance
        '
        Me.tabAppearance.Controls.Add(Me.lblToolStripColour)
        Me.tabAppearance.Controls.Add(Me.pnlToolStripColour)
        Me.tabAppearance.Controls.Add(Me.lblBackgroundColour)
        Me.tabAppearance.Controls.Add(Me.pnlBackgroundColour)
        Me.tabAppearance.ImageKey = "tools.png"
        Me.tabAppearance.Location = New System.Drawing.Point(4, 34)
        Me.tabAppearance.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabAppearance.Name = "tabAppearance"
        Me.tabAppearance.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabAppearance.Size = New System.Drawing.Size(650, 462)
        Me.tabAppearance.TabIndex = 2
        Me.tabAppearance.Text = "Appearance"
        Me.tabAppearance.UseVisualStyleBackColor = True
        '
        'lblToolStripColour
        '
        Me.lblToolStripColour.AutoSize = True
        Me.lblToolStripColour.Location = New System.Drawing.Point(12, 69)
        Me.lblToolStripColour.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblToolStripColour.Name = "lblToolStripColour"
        Me.lblToolStripColour.Size = New System.Drawing.Size(179, 25)
        Me.lblToolStripColour.TabIndex = 5
        Me.lblToolStripColour.Text = "Tool Strip Colour:"
        '
        'pnlToolStripColour
        '
        Me.pnlToolStripColour.BackColor = System.Drawing.SystemColors.Control
        Me.pnlToolStripColour.Location = New System.Drawing.Point(226, 60)
        Me.pnlToolStripColour.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pnlToolStripColour.Name = "pnlToolStripColour"
        Me.pnlToolStripColour.Size = New System.Drawing.Size(48, 44)
        Me.pnlToolStripColour.TabIndex = 4
        '
        'lblBackgroundColour
        '
        Me.lblBackgroundColour.AutoSize = True
        Me.lblBackgroundColour.Location = New System.Drawing.Point(12, 15)
        Me.lblBackgroundColour.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblBackgroundColour.Name = "lblBackgroundColour"
        Me.lblBackgroundColour.Size = New System.Drawing.Size(202, 25)
        Me.lblBackgroundColour.TabIndex = 3
        Me.lblBackgroundColour.Text = "Background Colour:"
        '
        'pnlBackgroundColour
        '
        Me.pnlBackgroundColour.BackColor = System.Drawing.SystemColors.Control
        Me.pnlBackgroundColour.Location = New System.Drawing.Point(226, 6)
        Me.pnlBackgroundColour.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pnlBackgroundColour.Name = "pnlBackgroundColour"
        Me.pnlBackgroundColour.Size = New System.Drawing.Size(48, 44)
        Me.pnlBackgroundColour.TabIndex = 2
        '
        'tabLeader
        '
        Me.tabLeader.Controls.Add(Me.pnlPlayer4Leader)
        Me.tabLeader.Controls.Add(Me.pnlPlayer3Leader)
        Me.tabLeader.Controls.Add(Me.pnlPlayer2Leader)
        Me.tabLeader.Controls.Add(Me.pnlPlayer1Leader)
        Me.tabLeader.Controls.Add(Me.Label1)
        Me.tabLeader.Controls.Add(Me.Label4)
        Me.tabLeader.Controls.Add(Me.lblPlayer1TotalWins)
        Me.tabLeader.Controls.Add(Me.Label3)
        Me.tabLeader.Controls.Add(Me.lblPlayer2TotalWins)
        Me.tabLeader.Controls.Add(Me.Label2)
        Me.tabLeader.Controls.Add(Me.lblPlayer3TotalWins)
        Me.tabLeader.Controls.Add(Me.lblPlayer4TotalWins)
        Me.tabLeader.ImageIndex = 2
        Me.tabLeader.Location = New System.Drawing.Point(4, 34)
        Me.tabLeader.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabLeader.Name = "tabLeader"
        Me.tabLeader.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabLeader.Size = New System.Drawing.Size(650, 462)
        Me.tabLeader.TabIndex = 1
        Me.tabLeader.Text = "Leaderboards"
        Me.tabLeader.UseVisualStyleBackColor = True
        '
        'pnlPlayer4Leader
        '
        Me.pnlPlayer4Leader.BackColor = System.Drawing.Color.Yellow
        Me.pnlPlayer4Leader.Location = New System.Drawing.Point(560, 125)
        Me.pnlPlayer4Leader.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pnlPlayer4Leader.Name = "pnlPlayer4Leader"
        Me.pnlPlayer4Leader.Size = New System.Drawing.Size(38, 35)
        Me.pnlPlayer4Leader.TabIndex = 14
        '
        'pnlPlayer3Leader
        '
        Me.pnlPlayer3Leader.BackColor = System.Drawing.Color.Green
        Me.pnlPlayer3Leader.Location = New System.Drawing.Point(480, 125)
        Me.pnlPlayer3Leader.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pnlPlayer3Leader.Name = "pnlPlayer3Leader"
        Me.pnlPlayer3Leader.Size = New System.Drawing.Size(38, 35)
        Me.pnlPlayer3Leader.TabIndex = 13
        '
        'pnlPlayer2Leader
        '
        Me.pnlPlayer2Leader.BackColor = System.Drawing.Color.Blue
        Me.pnlPlayer2Leader.Location = New System.Drawing.Point(380, 125)
        Me.pnlPlayer2Leader.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pnlPlayer2Leader.Name = "pnlPlayer2Leader"
        Me.pnlPlayer2Leader.Size = New System.Drawing.Size(38, 35)
        Me.pnlPlayer2Leader.TabIndex = 12
        '
        'pnlPlayer1Leader
        '
        Me.pnlPlayer1Leader.BackColor = System.Drawing.Color.Red
        Me.pnlPlayer1Leader.Location = New System.Drawing.Point(290, 125)
        Me.pnlPlayer1Leader.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pnlPlayer1Leader.Name = "pnlPlayer1Leader"
        Me.pnlPlayer1Leader.Size = New System.Drawing.Size(38, 35)
        Me.pnlPlayer1Leader.TabIndex = 11
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "close.png")
        Me.ImageList1.Images.SetKeyName(1, "helpQuestion.png")
        Me.ImageList1.Images.SetKeyName(2, "leaderboard.png")
        Me.ImageList1.Images.SetKeyName(3, "pause.png")
        Me.ImageList1.Images.SetKeyName(4, "resume.png")
        Me.ImageList1.Images.SetKeyName(5, "tools.png")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 602)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.TabControl1.ResumeLayout(False)
        Me.tabAppearance.ResumeLayout(False)
        Me.tabAppearance.PerformLayout()
        Me.tabLeader.ResumeLayout(False)
        Me.tabLeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblPlayer1TotalWins As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2TotalWins As System.Windows.Forms.Label
    Friend WithEvents lblPlayer3TotalWins As System.Windows.Forms.Label
    Friend WithEvents lblPlayer4TotalWins As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabLeader As System.Windows.Forms.TabPage
    Friend WithEvents pnlPlayer4Leader As System.Windows.Forms.Panel
    Friend WithEvents pnlPlayer3Leader As System.Windows.Forms.Panel
    Friend WithEvents pnlPlayer2Leader As System.Windows.Forms.Panel
    Friend WithEvents pnlPlayer1Leader As System.Windows.Forms.Panel
    Friend WithEvents tabAppearance As System.Windows.Forms.TabPage
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents pnlBackgroundColour As System.Windows.Forms.Panel
    Friend WithEvents lblBackgroundColour As System.Windows.Forms.Label
    Friend WithEvents lblToolStripColour As System.Windows.Forms.Label
    Friend WithEvents pnlToolStripColour As System.Windows.Forms.Panel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
