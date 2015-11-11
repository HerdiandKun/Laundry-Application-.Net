Imports System.Data.OleDb
Public Class ownerlogin
    Private Sub ownerlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (txtid.Text = "" Or txtpass.Text = "") Then
            MsgBox("Mohon isi dengan Benar")
            Exit Sub
        Else
            da = New OleDbDataAdapter
            Dim rd As OleDbDataReader
            cmd = New OleDbCommand("SELECT * FROM Owner where username='" + txtid.Text + "' AND password ='" + txtpass.Text + "'", Conn)
            da.SelectCommand = cmd
            rd = cmd.ExecuteReader()
            If rd.HasRows = 0 Then
                MsgBox("Username ata password salah", MsgBoxStyle.Exclamation, "Error Login")
            Else
                MsgBox("Login Berhasil", MsgBoxStyle.Information, "Successfull Login")
                tambah_admin.Show()
                Me.Hide()
                txtid.Clear()
                txtpass.Clear()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Admin.Show()
        Me.Hide()
    End Sub
End Class