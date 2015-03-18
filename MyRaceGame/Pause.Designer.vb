<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPause
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPause))
        Me.btnOptions = New System.Windows.Forms.Button
        Me.btnResume = New System.Windows.Forms.Button
        Me.btnQuit = New System.Windows.Forms.Button
        Me.lblPaused = New System.Windows.Forms.Label
        Me.btnMainMenu = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'btnOptions
        '
        Me.btnOptions.BackColor = System.Drawing.Color.AliceBlue
        Me.btnOptions.Location = New System.Drawing.Point(105, 119)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(75, 23)
        Me.btnOptions.TabIndex = 0
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = False
        '
        'btnResume
        '
        Me.btnResume.BackColor = System.Drawing.Color.AliceBlue
        Me.btnResume.Location = New System.Drawing.Point(105, 90)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(75, 23)
        Me.btnResume.TabIndex = 0
        Me.btnResume.Text = "Resume"
        Me.btnResume.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.AliceBlue
        Me.btnQuit.Location = New System.Drawing.Point(105, 177)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lblPaused
        '
        Me.lblPaused.AutoSize = True
        Me.lblPaused.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaused.Location = New System.Drawing.Point(68, 30)
        Me.lblPaused.Name = "lblPaused"
        Me.lblPaused.Size = New System.Drawing.Size(148, 25)
        Me.lblPaused.TabIndex = 3
        Me.lblPaused.Text = "Game Paused"
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(105, 148)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMainMenu.TabIndex = 4
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 270)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(275, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 270)
        Me.Panel2.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(284, 10)
        Me.Panel3.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(4, 251)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(284, 10)
        Me.Panel4.TabIndex = 8
        '
        'frmPause
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblPaused)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnResume)
        Me.Controls.Add(Me.btnOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPause"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pauseed"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents btnResume As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblPaused As System.Windows.Forms.Label
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
End Class
