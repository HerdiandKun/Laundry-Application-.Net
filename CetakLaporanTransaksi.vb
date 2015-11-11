Imports System.Data.OleDb
Public Class CetakLaporanTransaksi
    Public tgl1 As Date
    Public tgl2 As Date
    Private Sub CetakLaporanTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tgl1 = DateTimePicker1.Text
        'tgl2 = DateTimePicker2.Text
    End Sub
   
    Private Sub btnMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMember.Click
        LaporanTransaksiMember.Show()
    End Sub

    Private Sub btnNonMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNonMember.Click
        laporantransaksinonmember.Show()
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        Me.Close()
    End Sub
End Class