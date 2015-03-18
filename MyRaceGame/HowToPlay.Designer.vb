<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHowTo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHowTo))
        Me.lblHowTo = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHowTo
        '
        Me.lblHowTo.AutoSize = True
        Me.lblHowTo.Location = New System.Drawing.Point(8, 5)
        Me.lblHowTo.Name = "lblHowTo"
        Me.lblHowTo.Size = New System.Drawing.Size(507, 312)
        Me.lblHowTo.TabIndex = 1
        Me.lblHowTo.Text = resources.GetString("lblHowTo.Text")
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Location = New System.Drawing.Point(507, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 272)
        Me.Button1.TabIndex = 13
        Me.Button1.TabStop = False
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.lblHowTo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 272)
        Me.Panel1.TabIndex = 1
        '
        'frmHowTo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(582, 272)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.KeyPreview = True
        Me.Name = "frmHowTo"
        Me.Text = "How To Play"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHowTo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
