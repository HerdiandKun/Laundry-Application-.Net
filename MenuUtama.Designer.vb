<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.KeanggotaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LihatAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManipulasiAnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CucianMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PengambilanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DaftarAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lbluser = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeanggotaanToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.AdminToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(832, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KeanggotaanToolStripMenuItem
        '
        Me.KeanggotaanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatAnggotaToolStripMenuItem, Me.ManipulasiAnggotaToolStripMenuItem})
        Me.KeanggotaanToolStripMenuItem.Name = "KeanggotaanToolStripMenuItem"
        Me.KeanggotaanToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.KeanggotaanToolStripMenuItem.Text = "Keanggotaan"
        '
        'LihatAnggotaToolStripMenuItem
        '
        Me.LihatAnggotaToolStripMenuItem.Name = "LihatAnggotaToolStripMenuItem"
        Me.LihatAnggotaToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LihatAnggotaToolStripMenuItem.Text = "Lihat Semua Anggota"
        '
        'ManipulasiAnggotaToolStripMenuItem
        '
        Me.ManipulasiAnggotaToolStripMenuItem.Name = "ManipulasiAnggotaToolStripMenuItem"
        Me.ManipulasiAnggotaToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ManipulasiAnggotaToolStripMenuItem.Text = "Manipulasi Anggota"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CucianMasukToolStripMenuItem, Me.PengambilanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'CucianMasukToolStripMenuItem
        '
        Me.CucianMasukToolStripMenuItem.Name = "CucianMasukToolStripMenuItem"
        Me.CucianMasukToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.CucianMasukToolStripMenuItem.Text = "Cucian Masuk"
        '
        'PengambilanToolStripMenuItem
        '
        Me.PengambilanToolStripMenuItem.Name = "PengambilanToolStripMenuItem"
        Me.PengambilanToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PengambilanToolStripMenuItem.Text = "Pengambilan"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.AdminToolStripMenuItem.Text = "Edit Kasir"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CeToolStripMenuItem, Me.LaporanToolStripMenuItem1, Me.DaftarAdminToolStripMenuItem, Me.LaporanPelangganToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.LaporanToolStripMenuItem.Text = " Laporan"
        '
        'CeToolStripMenuItem
        '
        Me.CeToolStripMenuItem.Name = "CeToolStripMenuItem"
        Me.CeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CeToolStripMenuItem.Text = "Laporan Cucian Masuk"
        '
        'LaporanToolStripMenuItem1
        '
        Me.LaporanToolStripMenuItem1.Name = "LaporanToolStripMenuItem1"
        Me.LaporanToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.LaporanToolStripMenuItem1.Text = "Laporan Pengambilan"
        '
        'DaftarAdminToolStripMenuItem
        '
        Me.DaftarAdminToolStripMenuItem.Name = "DaftarAdminToolStripMenuItem"
        Me.DaftarAdminToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DaftarAdminToolStripMenuItem.Text = "Laporan Admin"
        '
        'LaporanPelangganToolStripMenuItem
        '
        Me.LaporanPelangganToolStripMenuItem.Name = "LaporanPelangganToolStripMenuItem"
        Me.LaporanPelangganToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.LaporanPelangganToolStripMenuItem.Text = "Laporan Pelanggan"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.BackColor = System.Drawing.Color.Transparent
        Me.lbluser.Location = New System.Drawing.Point(727, 9)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(55, 13)
        Me.lbluser.TabIndex = 1
        Me.lbluser.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(778, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "| Keluar"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(832, 379)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtama"
        Me.Text = "Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KeanggotaanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LihatAnggotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManipulasiAnggotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CucianMasukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengambilanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DaftarAdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPelangganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
