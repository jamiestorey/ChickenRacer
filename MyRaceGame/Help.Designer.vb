<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabTutorial = New System.Windows.Forms.TabPage()
        Me.tabOfflineHelp = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tabOffHome = New System.Windows.Forms.TabPage()
        Me.tabOffFAQ = New System.Windows.Forms.TabPage()
        Me.tabOffBetting = New System.Windows.Forms.TabPage()
        Me.tabPlayerNames = New System.Windows.Forms.TabPage()
        Me.tabOffPausing = New System.Windows.Forms.TabPage()
        Me.tabOffBankrupt = New System.Windows.Forms.TabPage()
        Me.tabOffLeaderboards = New System.Windows.Forms.TabPage()
        Me.tabOffDoubleMoney = New System.Windows.Forms.TabPage()
        Me.tabOffOverview = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.tabOfflineHelp.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabTutorial)
        Me.TabControl1.Controls.Add(Me.tabOfflineHelp)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1760, 1079)
        Me.TabControl1.TabIndex = 0
        '
        'tabTutorial
        '
        Me.tabTutorial.Location = New System.Drawing.Point(4, 34)
        Me.tabTutorial.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabTutorial.Name = "tabTutorial"
        Me.tabTutorial.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabTutorial.Size = New System.Drawing.Size(1752, 1041)
        Me.tabTutorial.TabIndex = 0
        Me.tabTutorial.Text = "Tutorial"
        Me.tabTutorial.ToolTipText = "Complete A tutorial of the game."
        Me.tabTutorial.UseVisualStyleBackColor = True
        '
        'tabOfflineHelp
        '
        Me.tabOfflineHelp.Controls.Add(Me.TabControl2)
        Me.tabOfflineHelp.Controls.Add(Me.WebBrowser1)
        Me.tabOfflineHelp.Location = New System.Drawing.Point(4, 34)
        Me.tabOfflineHelp.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOfflineHelp.Name = "tabOfflineHelp"
        Me.tabOfflineHelp.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOfflineHelp.Size = New System.Drawing.Size(1752, 1041)
        Me.tabOfflineHelp.TabIndex = 1
        Me.tabOfflineHelp.Text = "Offline Help"
        Me.tabOfflineHelp.ToolTipText = "Recieve help when you're not connected to the internet."
        Me.tabOfflineHelp.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TabControl2.Controls.Add(Me.tabOffHome)
        Me.TabControl2.Controls.Add(Me.tabOffFAQ)
        Me.TabControl2.Controls.Add(Me.tabOffBetting)
        Me.TabControl2.Controls.Add(Me.tabPlayerNames)
        Me.TabControl2.Controls.Add(Me.tabOffPausing)
        Me.TabControl2.Controls.Add(Me.tabOffBankrupt)
        Me.TabControl2.Controls.Add(Me.tabOffLeaderboards)
        Me.TabControl2.Controls.Add(Me.tabOffDoubleMoney)
        Me.TabControl2.Controls.Add(Me.tabOffOverview)
        Me.TabControl2.Location = New System.Drawing.Point(-8, 2)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.ShowToolTips = True
        Me.TabControl2.Size = New System.Drawing.Size(1774, 40)
        Me.TabControl2.TabIndex = 3
        '
        'tabOffHome
        '
        Me.tabOffHome.Location = New System.Drawing.Point(4, 34)
        Me.tabOffHome.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOffHome.Name = "tabOffHome"
        Me.tabOffHome.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOffHome.Size = New System.Drawing.Size(1766, 2)
        Me.tabOffHome.TabIndex = 0
        Me.tabOffHome.Text = "Home"
        Me.tabOffHome.ToolTipText = "Get Help Here"
        Me.tabOffHome.UseVisualStyleBackColor = True
        '
        'tabOffFAQ
        '
        Me.tabOffFAQ.Location = New System.Drawing.Point(4, 34)
        Me.tabOffFAQ.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOffFAQ.Name = "tabOffFAQ"
        Me.tabOffFAQ.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOffFAQ.Size = New System.Drawing.Size(1766, 2)
        Me.tabOffFAQ.TabIndex = 1
        Me.tabOffFAQ.Text = "FAQ"
        Me.tabOffFAQ.ToolTipText = "Frequently Asked Questions"
        Me.tabOffFAQ.UseVisualStyleBackColor = True
        '
        'tabOffBetting
        '
        Me.tabOffBetting.Location = New System.Drawing.Point(4, 34)
        Me.tabOffBetting.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOffBetting.Name = "tabOffBetting"
        Me.tabOffBetting.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOffBetting.Size = New System.Drawing.Size(1766, 2)
        Me.tabOffBetting.TabIndex = 2
        Me.tabOffBetting.Text = "Betting"
        Me.tabOffBetting.ToolTipText = "All about Betting"
        Me.tabOffBetting.UseVisualStyleBackColor = True
        '
        'tabPlayerNames
        '
        Me.tabPlayerNames.Location = New System.Drawing.Point(4, 34)
        Me.tabPlayerNames.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabPlayerNames.Name = "tabPlayerNames"
        Me.tabPlayerNames.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabPlayerNames.Size = New System.Drawing.Size(1766, 2)
        Me.tabPlayerNames.TabIndex = 3
        Me.tabPlayerNames.Text = "Changing Names"
        Me.tabPlayerNames.ToolTipText = "How to change a name of a player"
        Me.tabPlayerNames.UseVisualStyleBackColor = True
        '
        'tabOffPausing
        '
        Me.tabOffPausing.Location = New System.Drawing.Point(4, 34)
        Me.tabOffPausing.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOffPausing.Name = "tabOffPausing"
        Me.tabOffPausing.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOffPausing.Size = New System.Drawing.Size(1766, 2)
        Me.tabOffPausing.TabIndex = 4
        Me.tabOffPausing.Text = "Pausing"
        Me.tabOffPausing.ToolTipText = "Pasuing the Game"
        Me.tabOffPausing.UseVisualStyleBackColor = True
        '
        'tabOffBankrupt
        '
        Me.tabOffBankrupt.Location = New System.Drawing.Point(4, 34)
        Me.tabOffBankrupt.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOffBankrupt.Name = "tabOffBankrupt"
        Me.tabOffBankrupt.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOffBankrupt.Size = New System.Drawing.Size(1766, 2)
        Me.tabOffBankrupt.TabIndex = 5
        Me.tabOffBankrupt.Text = "Bankrupt"
        Me.tabOffBankrupt.ToolTipText = "Becoming Bankrupt"
        Me.tabOffBankrupt.UseVisualStyleBackColor = True
        '
        'tabOffLeaderboards
        '
        Me.tabOffLeaderboards.Location = New System.Drawing.Point(4, 34)
        Me.tabOffLeaderboards.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOffLeaderboards.Name = "tabOffLeaderboards"
        Me.tabOffLeaderboards.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOffLeaderboards.Size = New System.Drawing.Size(1766, 2)
        Me.tabOffLeaderboards.TabIndex = 6
        Me.tabOffLeaderboards.Text = "Leaderboards"
        Me.tabOffLeaderboards.ToolTipText = "Viewing the Leaderboards"
        Me.tabOffLeaderboards.UseVisualStyleBackColor = True
        '
        'tabOffDoubleMoney
        '
        Me.tabOffDoubleMoney.Location = New System.Drawing.Point(4, 34)
        Me.tabOffDoubleMoney.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOffDoubleMoney.Name = "tabOffDoubleMoney"
        Me.tabOffDoubleMoney.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOffDoubleMoney.Size = New System.Drawing.Size(1766, 2)
        Me.tabOffDoubleMoney.TabIndex = 7
        Me.tabOffDoubleMoney.Text = "Double Money"
        Me.tabOffDoubleMoney.ToolTipText = "The Double Money Mini-Game"
        Me.tabOffDoubleMoney.UseVisualStyleBackColor = True
        '
        'tabOffOverview
        '
        Me.tabOffOverview.Location = New System.Drawing.Point(4, 34)
        Me.tabOffOverview.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOffOverview.Name = "tabOffOverview"
        Me.tabOffOverview.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabOffOverview.Size = New System.Drawing.Size(1766, 2)
        Me.tabOffOverview.TabIndex = 8
        Me.tabOffOverview.Text = "Overview"
        Me.tabOffOverview.ToolTipText = "An Overview of the Game"
        Me.tabOffOverview.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(6, 54)
        Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(40, 38)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1722, 963)
        Me.WebBrowser1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(853, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(859, 352)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tutorial"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1760, 1079)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmHelp"
        Me.Text = "Help"
        Me.TabControl1.ResumeLayout(False)
        Me.tabOfflineHelp.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabTutorial As System.Windows.Forms.TabPage
    Friend WithEvents tabOfflineHelp As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents tabOffHome As System.Windows.Forms.TabPage
    Friend WithEvents tabOffFAQ As System.Windows.Forms.TabPage
    Friend WithEvents tabOffBetting As System.Windows.Forms.TabPage
    Friend WithEvents tabPlayerNames As System.Windows.Forms.TabPage
    Friend WithEvents tabOffPausing As System.Windows.Forms.TabPage
    Friend WithEvents tabOffBankrupt As System.Windows.Forms.TabPage
    Friend WithEvents tabOffLeaderboards As System.Windows.Forms.TabPage
    Friend WithEvents tabOffDoubleMoney As System.Windows.Forms.TabPage
    Friend WithEvents tabOffOverview As System.Windows.Forms.TabPage
End Class
