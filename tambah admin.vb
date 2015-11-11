Imports System.Data.OleDb
Public Class tambah_admin
    Dim enkrip, out, inp, user As String
 
    Private Sub tambah_admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        Tampilkan()
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
    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from Admin", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Admin")
        DataGridView1.DataSource = (ds.Tables("Admin"))
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        encrypt()
        If txtuser.Text = "" Or txtpass.Text = "" Or txtnama.Text = "" Or txtno.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            'out = txtpass.Text
            Dim tambah As String
            tambah = "Insert into Admin values('" & txtuser.Text & "', '" & out & "', '" & txtnama.Text & "', '" & txtno.Text & "')"
            cmd = New OleDbCommand(tambah, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Ditambah")
            kosongkan()
            Tampilkan()
        End If
        out = ""
    End Sub
    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        user = txtuser.Text
        If user = "" Then
            MsgBox("Isi Username terlebih dahulu")
            txtuser.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin akan menghapus data?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete * from Admin where Username = '" & user & "'", Conn)
                cmd.ExecuteNonQuery()
            Else
                MsgBox("Data Tidak Jadi di Hapus")
            End If
            Call Tampilkan()
            Call kosongkan()
        End If
    End Sub

    Private Sub txtuser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuser.KeyPress
        user = txtuser.Text
        If e.KeyChar = Chr(Keys.Enter) Then
            If e.KeyChar = Chr(13) Then
                Try
                    cmd = New OleDbCommand("Select * from Admin where Username= '" & user & "'", Conn)
                    rd = cmd.ExecuteReader
                    rd.Read()
                    If rd.HasRows = True Then
                        txtpass.Text = rd.GetString(1)
                        txtnama.Text = rd.GetValue(2)
                        txtno.Text = rd.GetValue(3)
                        txtnama.Focus()
                    Else
                        Call kosongkan()
                        txtnama.Focus()
                    End If
                Catch ex As Exception
                End Try
            End If
            If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
                e.Handled() = True
            End If

        End If
    End Sub

    Private Sub btnkembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkembali.Click
        Me.Hide()
        Admin.Show()
    End Sub

   
End Class