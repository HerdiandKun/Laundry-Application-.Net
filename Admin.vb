Imports System.Data.OleDb
Public Class Admin
    Dim user As String
    Dim enkrip, out, inp As String
    Private Sub Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        TextBox1.Focus()
    End Sub
    Sub encry()
        Dim pj, i As Integer
        user = TextBox1.Text
        inp = TextBox2.Text
        pj = inp.Length
        For i = 1 To pj
            enkrip = Mid(inp, i, 1)
            enkrip = Asc(enkrip)
            enkrip = (enkrip + 87) - 50
            enkrip = Chr(enkrip)
            out = out & enkrip
        Next i
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        encry()
        If (user = "" Or inp = "") Then
            MsgBox("Mohon isi dengan Benar")
            Exit Sub
        Else
            'da = New OleDbDataAdapter
            'Dim rd As OleDbDataReader
            cmd = New OleDbCommand("SELECT * FROM Admin where username='" & user & "' AND password ='" & out & "'", Conn)
            'da.SelectCommand = cmd
            rd = cmd.ExecuteReader()
            If rd.HasRows = 0 Then
                MsgBox("Username atau password salah", MsgBoxStyle.Exclamation, "Error Login")
            Else
                MsgBox("Login Berhasil", MsgBoxStyle.Information, "Successfull Login")
                MenuUtama.Show()
                Me.Hide()
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        End If
        out = ""
    End Sub

    Private Sub btntmbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntmbah.Click
        Me.Hide()
        ownerlogin.Show()
    End Sub
End Class