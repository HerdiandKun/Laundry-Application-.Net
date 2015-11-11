Imports System.Data.OleDb
Public Class EditAdmin
    Dim inp, enkrip, out, nama, no_telp, user As String
    Private Sub EditAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        txtuser.Text = MenuUtama.lbluser.Text
    End Sub
    Sub encrypt()
        Dim pj, i As Integer
        inp = txtpass.Text
        pj = inp.Length
        For i = 1 To pj
            enkrip = Mid(inp, i, 1)
            enkrip = Asc(enkrip)
            enkrip = (enkrip + 87) - 50
            enkrip = Chr(enkrip)
            out = out & enkrip
        Next i
    End Sub
    Sub kosongkan()
        txtnama.Clear()
        txtuser.Clear()
        txtpass.Clear()
        txtno.Clear()
        txtuser.Focus()
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        encrypt()
        nama = txtnama.Text
        no_telp = txtno.Text
        user = txtuser.Text
        If txtuser.Text = "" Or txtnama.Text = "" Or txtpass.Text = "" Or txtno.Text = "" Then
            MsgBox("Data belum lengkap")
            Exit Sub
        Else
            cmd = New OleDbCommand("Select * from Admin where Username = '" & txtuser.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim editNm As String
                editNm = "Update Admin set Nama = '" & Me.nama & "' where [Username] = '" & Me.txtuser.Text & "'"
                cmd = New OleDbCommand(editNm, Conn)
                cmd.ExecuteNonQuery()
                Dim edital As String
                edital = "Update Admin set [Password] = '" & Me.out & "' where [Username] = '" & Me.txtuser.Text & "'"
                cmd = New OleDbCommand(edital, Conn)
                cmd.ExecuteNonQuery()
                Dim editno As String
                editno = "Update Admin set No_telp = '" & Me.no_telp & "' where [Username] = '" & Me.txtuser.Text & "'"
                cmd = New OleDbCommand(editno, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil di edit")
                Call kosongkan()
            Else
                MsgBox("Data gagal di edit")

            End If

        End If
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub
End Class