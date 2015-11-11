Imports System.Data.OleDb
Public Class lihatpelanggan
    Sub TampilPencarian()
        cmd = New OleDbCommand("Select * from Pelanggan where Nama like '%" & cbCari.Text & "%'", Conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbCari.Items.Add(rd.GetString(1))
        Loop
        If rd.HasRows Then
            Call TampilData()
        Else
            MsgBox("Pelanggan tidak ditemukan")
            cbCari.Text = ""
            DataGridView1.DataSource = ds.Tables()
        End If
        cbCari.Focus()
    End Sub
    Sub TampilData()
        da = New OleDbDataAdapter("Select * from Pelanggan where Nama like '%" & cbCari.Text & "%'", Conn)
        ds = New DataSet
        da.Fill(ds, "Pelanggan")
        DataGridView1.DataSource = ds.Tables("Pelanggan")
        DataGridView1.ReadOnly = True
        cbCari.Focus()
    End Sub
    Private Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from Pelanggan", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Pelanggan")
        DataGridView1.DataSource = (ds.Tables("Pelanggan"))
    End Sub
    Private Sub lihatpelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        Tampilkan()
    End Sub

    Private Sub cbCari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbCari.KeyPress
        If e.KeyChar = Chr(13) Then
            Call TampilPencarian()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        MenuUtama.Show()
    End Sub
End Class