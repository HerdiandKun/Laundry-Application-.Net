Imports System.Data.OleDb
Public Class pengambilan
    Dim nota, nama As String
    Dim sisa As Integer
    Dim member As Boolean
    Dim tgljadi, waktu As Date
    Sub tampilnotamember()
        cmbnota.Items.Clear()
        cmd = New OleDbCommand("Select * From transaksi", Conn)
        rd = cmd.ExecuteReader
        While rd.Read

            cmbnota.Items.Add(rd.GetString(0))
        End While
    End Sub
    Sub tampilnotanonmember()
        cmd = New OleDbCommand("Select * From NonMember", Conn)
        rd = cmd.ExecuteReader
        While rd.Read
            cmbnota.Items.Add(rd.GetString(0))
        End While
    End Sub
    Private Sub pengambilan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        tampilnotamember()
        tampilnotanonmember()
        waktu = Date.Today
        lbltgl.Text = waktu
    End Sub
    Private Sub btnproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproses.Click
        tgljadi = Date.Parse(txttgl.Text)
        nota = cmbnota.Text
        If waktu > tgljadi Then
            cmd = New OleDbCommand("select * from Pengambilan where ID_transaksi = '" & nota & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim ubahjadi As String
                ubahjadi = "Update Pengambilan SET tanggal_Ambil ='" & lbltgl.Text & "' WHERE ID_transaksi = '" & Me.nota & "'"
                cmd = New OleDbCommand(ubahjadi, Conn)
                cmd.ExecuteNonQuery()
                Dim ubahsisa As String
                ubahsisa = "Update Pengambilan SET sisa = 0 WHERE ID_transaksi = '" & Me.nota & "'"
                cmd = New OleDbCommand(ubahsisa, Conn)
                cmd.ExecuteNonQuery()
                Dim ubahsisa1 As String
                ubahsisa1 = "Update Transaksi SET sisa = 0 WHERE ID_transaksi = '" & Me.nota & "'"
                cmd = New OleDbCommand(ubahsisa1, Conn)
                cmd.ExecuteNonQuery()
                Dim ubahsisa2 As String
                ubahsisa2 = "Update NonMember SET sisa = 0 WHERE ID_transaksi = '" & Me.nota & "'"
                cmd = New OleDbCommand(ubahsisa2, Conn)
                cmd.ExecuteNonQuery()
                Dim ubahket As String
                ubahket = "Update Pengambilan SET Keterangan ='Telah diambil' WHERE ID_transaksi = '" & Me.nota & "'"
                cmd = New OleDbCommand(ubahket, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diubah")
            Else
                MsgBox("Data Gagal Diubah")
            End If
        Else
            MsgBox("Maaf Laundry Belum Selesai")
        End If

    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub cmbnota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbnota.KeyPress
        nota = cmbnota.Text
        If e.KeyChar = Chr(Keys.Enter) Then
            If e.KeyChar = Chr(13) Then
                Try
                    cmd = New OleDbCommand("Select * From Pengambilan where ID_transaksi = '" & nota & "'", Conn)
                    rd = cmd.ExecuteReader
                    rd.Read()
                    If rd.HasRows = True Then
                        txtnama.Text = (rd("nama").ToString)
                        txtsisa.Text = (rd("sisa"))
                        txttgl.Text = (rd("Tanggal_Jadi"))
                        txtnama.Focus()
                    Else
                    End If
                Catch ex As Exception
                End Try
            End If
            If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
                e.Handled() = True
            End If
        End If

    End Sub

    Private Sub cmbnota_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnota.SelectedIndexChanged
        nota = cmbnota.Text
                Try
            cmd = New OleDbCommand("Select * From Pengambilan where ID_transaksi = '" & nota & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                txtnama.Text = (rd("nama").ToString)
                txtsisa.Text = (rd("sisa"))
                txttgl.Text = (rd("Tanggal_Jadi"))
                txtnama.Focus()
            Else
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class