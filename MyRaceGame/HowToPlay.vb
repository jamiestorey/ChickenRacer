Public Class frmHowTo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FontDialog1.ShowColor = True
        FontDialog1.ShowDialog()

        lblHowTo.Font = FontDialog1.Font
        lblHowTo.ForeColor = FontDialog1.Color


    End Sub

    

    Private Sub frmHowTo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Focus()
    End Sub

    Private Sub Panel1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel1.MouseEnter, lblHowTo.MouseEnter
        Panel1.Focus()
    End Sub
End Class