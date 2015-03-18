Public Class frmHelp

   


    Private Sub TabControl2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl2.SelectedIndexChanged, TabControl2.Enter, TabControl2.MouseEnter

        Select Case TabControl2.SelectedIndex
            Case 0
                WebBrowser1.DocumentText = My.Resources.home
            Case 1
                WebBrowser1.DocumentText = My.Resources.faq
            Case 2
                WebBrowser1.DocumentText = My.Resources.betting
            Case 3
                WebBrowser1.DocumentText = My.Resources.playernames
            Case 4
                WebBrowser1.DocumentText = My.Resources.pausing
            Case 5
                WebBrowser1.DocumentText = My.Resources.bankrupt
            Case 6
                WebBrowser1.DocumentText = My.Resources.leaderboards
            Case 7
                WebBrowser1.DocumentText = My.Resources.double_money
            Case 8
                WebBrowser1.DocumentText = My.Resources.howtoplay
        End Select
    End Sub

    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.DocumentText = My.Resources.home
    End Sub

End Class