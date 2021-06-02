Option Explicit On
'Date set to per record save = today
'Dim var1 As String
'Dim var2 As String
'Dim var3 As String

Public Class Manage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub Manage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click, cmdOpen.Click, cmdDelete.Click
        Dim filenum As Integer
        Dim strFileName As String
        Dim filenum2 As Integer
        Dim var1 As String
        Dim var2 As String
        Dim var3 As String
        filenum = FreeFile()
        filenum2 = FreeFile()

        If Not ValidaNumber(txtStock.Text) Then
            MsgBox("Numbers are expected", vbCritical, "Error in data")
        Else
            'Open(strFileName) For append As filenum
            'Write #filenum  
            'var1 = txtName
            'var2 = txtStock
            'var3 = date1
            'Print() #fileNum, var1, var2
        End If


        If MsgBox("Product Saved. Do you want to add more/modify stock?", vbInformation + vbYesNo) = DialogResult.Yes Then
            txtName.ResetText()
            txtStock.ResetText()
            date1.ResetText()
            Return
        Else
            Main.Show()
            Hide()

        End If
        'Close #fileNum
    End Sub

    Public Function ValidaNumber(item As String) As Boolean
        ValidaNumber = IsNumeric(item)

    End Function

End Class