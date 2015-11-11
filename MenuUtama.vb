Imports System.Data.OleDb
Public Class MenuUtama

    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        lbluser.Text = Admin.TextBox1.Text
    End Sub

    Private Sub AdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminToolStripMenuItem.Click
        EditAdmin.Show()
    End Sub

    Private Sub CucianMasukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CucianMasukToolStripMenuItem.Click
        Laundry.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub ManipulasiAnggotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManipulasiAnggotaToolStripMenuItem.Click
        pelanggan.Show()
    End Sub

    Private Sub PengambilanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PengambilanToolStripMenuItem.Click
        pengambilan.Show()
    End Sub

    Private Sub LihatAnggotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LihatAnggotaToolStripMenuItem.Click
        lihatpelanggan.Show()
        Me.Visible = False
    End Sub

    Private Sub lbluser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbluser.Click

    End Sub

    Private Sub DaftarAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarAdminToolStripMenuItem.Click
        LaporanAdmin.Show()
    End Sub

    Private Sub LaporanPelangganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPelangganToolStripMenuItem.Click
        LaporanMemper.Show()
    End Sub

    Private Sub LaporanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanToolStripMenuItem1.Click
        LaporanPengambilan.Show()
    End Sub

    Private Sub CeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CeToolStripMenuItem.Click
        CetakLaporanTransaksi.Show()
    End Sub
End Class