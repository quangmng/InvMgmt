Public Class Main
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdExport.Click
        Export.Show()
        Hide()
    End Sub

    Private Sub cmdManage_Click(sender As Object, e As EventArgs) Handles cmdManage.Click
        Manage.Show()
        Hide()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Search.Show()
        Hide()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
