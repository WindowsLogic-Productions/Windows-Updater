Public Class Win2000

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Navigate("https://dl.dropboxusercontent.com/u/93134108/Windows%20Updater%20Packages/Windows%202000%20Updates.zip")
    End Sub
End Class