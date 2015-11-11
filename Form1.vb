Imports System.Data.OleDb
Public Class Laundry
    Dim idpel, nota, tipe, nama, alamat, no_tlp, user As String
    Dim waktu, jadi, masa As Date
    Dim jumlah, biaya, total, totbay, umuk, sisa As Integer
    Dim disc As Single
    Dim member As Boolean
    Sub tampilidpel()
        cmd = New OleDbCommand("Select * From Pelanggan", Conn)
        rd = cmd.ExecuteReader
        While rd.Read
            cmbidpel.Items.Add(rd.GetString(0))
        End While
    End Sub
    Sub notamember()
        cmd = New OleDbCommand("Select * From transaksi", Conn)
        rd = cmd.ExecuteReader
        While rd.Read
            cmbnota.Items.Add(rd.GetString(0))
        End While
    End Sub
    Sub notanonmember()
        cmd = New OleDbCommand("Select * From nonmember", Conn)
        rd = cmd.ExecuteReader
        While rd.Read
            cmbnota.Items.Add(rd.GetString(0))
        End While
    End Sub
    Private Sub Kosongkan()
        cmbidpel.Text = ""
        txtnamapel.Text = ""
        txtalamat.Text = ""
        txtno.Text = ""
        cmbnota.Text = ""
        txttgljadi.Text = ""
        rbekspress.Checked = False
        rbreguler.Checked = False
        rbkilo.Checked = False
        rbpotong.Checked = False
        rbkarpet.Checked = False
        lblitem.Text = ""
        lbljumlah.Text = ""
        lblsatuan.Text = ""
        txtjumlah.Text = ""
        txtbiaya.Text = ""
        txttotal.Text = ""
        txtdiskon.Text = ""
        txttotbayar.Text = ""
        txtumuk.Text = ""
        txtsisa.Text = ""
        cmbidpel.Focus()
    End Sub
    Private Sub Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        tampilidpel()
        waktu = Date.Today
        txttglmasuk.Text = waktu
        lbluser.Text = MenuUtama.lbluser.Text
        user = lbluser.Text
    End Sub

    Private Sub cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nama As String
        nama = txtnamapel.Text
        If (nama = "") Then
            MsgBox("Mohon isi dengan Benar")
            Exit Sub
        Else

            Dim rd As OleDbDataReader
            cmd = New OleDbCommand("SELECT * FROM Pelanggan where Nama like '%" + nama + "%'", Conn)
            da = New OleDbDataAdapter("SELECT * FROM Pelanggan where Nama like '%" + nama + "%'", Conn)
            rd = cmd.ExecuteReader()
            If rd.HasRows = 0 Then
                MsgBox("Pencarian gagal", MsgBoxStyle.Exclamation, "Error Searching")
            Else
                ds = New DataSet
                ds.Clear()
                da.Fill(ds, "Pelanggan")
                'DGV.DataSource = (ds.Tables("Pelanggan"))
                MsgBox("Login Berhasil", MsgBoxStyle.Information, "Successfull Login")
            End If
        End If

    End Sub
    Private Sub btn_nonmember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nonmember.Click
        idpel = "Non Member"
        cmbidpel.Enabled = False
        Kosongkan()
        cmbnota.Items.Clear()
        member = False
        'txtnota.Text = "N"
        notanonmember()
    End Sub

    Private Sub btn_member_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_member.Click
        cmbidpel.Enabled = True
        idpel = cmbidpel.Text
        member = True
        'txtnota.Text = "M"
        cmbnota.Items.Clear()
        notamember()
    End Sub
    Private Sub btnhitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhitung.Click
        If rbreguler.Checked = False And rbekspress.Checked = False Then
            MsgBox("Mohon Pilih tipe dengan benar")
        ElseIf rbkilo.Checked = False And rbpotong.Checked = False And rbkarpet.Checked = False Then
            MsgBox("Mohon Pilih Jenis Cucian dengan benar")
        Else
            If rbreguler.Checked Then
                jadi = DateAdd("d", 3, waktu)
                txttgljadi.Text = jadi
                tipe = "Reguler"
                If rbkilo.Checked Then
                    biaya = 3500
                    jumlah = txtjumlah.Text
                    total = biaya * jumlah
                    If member = True Then
                        disc = total * 0.2
                    Else
                        disc = 0
                    End If
                    totbay = total - disc
                    txtbiaya.Text = biaya
                    txttotal.Text = total
                    txtdiskon.Text = disc
                    txttotbayar.Text = totbay
                End If
                If rbpotong.Checked Then
                    biaya = 500
                    jumlah = txtjumlah.Text
                    total = biaya * jumlah
                    If member = True Then
                        disc = total * 0.2
                    Else
                        disc = 0
                    End If
                    totbay = total - disc
                    txtbiaya.Text = biaya
                    txttotal.Text = total
                    txtdiskon.Text = disc
                    txttotbayar.Text = totbay
                End If
                If rbkarpet.Checked Then
                    biaya = 7500
                    jumlah = txtjumlah.Text
                    total = biaya * jumlah
                    If member = True Then
                        disc = total * 0.2
                    Else
                        disc = 0
                    End If
                    totbay = total - disc
                    txtbiaya.Text = biaya
                    txttotal.Text = total
                    txtdiskon.Text = disc
                    txttotbayar.Text = totbay
                End If
            End If
            If rbekspress.Checked Then
                jadi = DateAdd("d", 1, waktu)
                txttgljadi.Text = jadi
                tipe = "Ekspress"
                If rbkilo.Checked Then
                    biaya = 5000
                    jumlah = txtjumlah.Text
                    total = biaya * jumlah
                    If member = True Then
                        disc = total * 0.2
                    Else
                        disc = 0
                    End If
                    totbay = total - disc
                    txtbiaya.Text = biaya
                    txttotal.Text = total
                    txtdiskon.Text = disc
                    txttotbayar.Text = totbay
                End If
                If rbpotong.Checked Then
                    biaya = 1000
                    jumlah = txtjumlah.Text
                    total = biaya * jumlah
                    If member = True Then
                        disc = total * 0.2
                    Else
                        disc = 0
                    End If
                    totbay = total - disc
                    txtbiaya.Text = biaya
                    txttotal.Text = total
                    txtdiskon.Text = disc
                    txttotbayar.Text = totbay
                End If
                If rbkarpet.Checked Then
                    biaya = 10000
                    jumlah = txtjumlah.Text
                    total = biaya * jumlah
                    If member = True Then
                        disc = total * 0.2
                    Else
                        disc = 0
                    End If
                    totbay = total - disc
                    txtbiaya.Text = biaya
                    txttotal.Text = total
                    txtdiskon.Text = disc
                    txttotbayar.Text = totbay
                End If
            End If
            sisa = totbay
            txtsisa.Text = sisa
        End If

    End Sub

    Private Sub btnjenis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnjenis.Click
        If rbreguler.Checked = False And rbekspress.Checked = False Then
            MsgBox("Mohon Pilih tipe dengan benar")
        ElseIf rbkilo.Checked = False And rbpotong.Checked = False And rbkarpet.Checked = False Then
            MsgBox("Mohon Pilih Jenis Cucian dengan benar")
        Else
            If rbreguler.Checked Or rbekspress.Checked Then
                If rbkilo.Checked Then
                    lblitem.Text = "Cuci Kiloan"
                    lblsatuan.Text = "KG"
                    lbljumlah.Text = "Berat :"

                End If
                If rbpotong.Checked Then
                    lblitem.Text = "Cuci Perpotong"
                    lblsatuan.Text = "PCS"
                    txtjumlah.Enabled = True
                    lbljumlah.Text = "Jumlah :"
                End If
                If rbkarpet.Checked Then
                    lblitem.Text = "Karpet"
                    lblsatuan.Text = "M2"
                    txtjumlah.Enabled = True
                    lbljumlah.Text = "Luas :"
                End If
            End If
        End If
    End Sub

    Private Sub Bayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bayar.Click
        umuk = txtumuk.Text
        sisa = totbay - umuk
        txtsisa.Text = sisa
    End Sub

    Private Sub btnproses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproses.Click
        nama = txtnamapel.Text
        alamat = txtalamat.Text
        no_tlp = txtno.Text
        cmbnota.Items.Add(cmbnota.Text)
        nota = cmbnota.Text
        If member = True Then
            If waktu > masa Then
                MsgBox("Maaf Member Anda Kadaluarsa")
            Else
                nota = cmbnota.Text
                cmd = New OleDbCommand("Select * from Pelanggan Where ID_Pelanggan = '" & idpel & "'", Conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    cmd = New OleDbCommand("select * from Transaksi where ID_transaksi = '" & nota & "'", Conn)
                    rd = cmd.ExecuteReader
                    rd.Read()
                    If Not rd.HasRows Then
                        Dim tambah As String
                        tambah = "Insert into Transaksi(ID_transaksi, ID_Pelanggan, Tgl_masuk, Tgl_keluar, Tipe, Satuan, Nama_item, nominal , Biaya, Diskon, Total_bayar, DP, sisa, Username_Kasir)" & " VALUES ('" & nota & "', '" & idpel & "', '" & waktu & "','" & jadi & "','" & tipe & "','" & lblsatuan.Text & "','" & lblitem.Text & "'," & jumlah & "," & total & "," & disc & "," & totbay & "," & umuk & "," & sisa & ",'" & lbluser.Text & "')"
                        cmd = New OleDbCommand(tambah, Conn)
                        cmd.ExecuteNonQuery()
                    End If
                End If
            End If
        Else
            nota = cmbnota.Text
            cmd = New OleDbCommand("select * from NonMember where ID_transaksi = '" & nota & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim tambah As String
                tambah = "Insert into NonMember(ID_transaksi, Nama, Alamat, No_telp, Tgl_masuk, Tgl_keluar, Tipe, Satuan, Nama_item, nominal , Biaya, Diskon, Total_bayar, DP, sisa, Username_Kasir)" & " VALUES ('" & nota & "', '" & nama & "', '" & alamat & "', '" & no_tlp & "', '" & waktu & "','" & jadi & "','" & tipe & "','" & lblsatuan.Text & "','" & lblitem.Text & "'," & jumlah & "," & total & "," & disc & "," & totbay & "," & umuk & "," & sisa & ",'" & lbluser.Text & "')"
                cmd = New OleDbCommand(tambah, Conn)
                cmd.ExecuteNonQuery()
            End If

        End If
        If member = True Then
            If waktu > masa Then
                MsgBox("Maaf Member Anda Kadaluarsa")
            Else
                nota = cmbnota.Text
                cmd = New OleDbCommand("Select * from Pelanggan Where ID_Pelanggan = '" & idpel & "'", Conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    cmd = New OleDbCommand("select * from Pengambilan where ID_transaksi = '" & nota & "'", Conn)
                    rd = cmd.ExecuteReader
                    rd.Read()
                    If Not rd.HasRows Then
                        Dim tambah As String
                        tambah = "Insert into Pengambilan(ID_transaksi, Nama , Tanggal_Masuk, Tanggal_Jadi, sisa,Total_Bayar, keterangan)" & " VALUES ('" & nota & "', '" & nama & "', '" & waktu & "', '" & jadi & "', " & sisa & ", " & totbay & ", 'Belum diambil'" & ")"
                        cmd = New OleDbCommand(tambah, Conn)
                        cmd.ExecuteNonQuery()
                        MsgBox("Data berhasil ditambah")
                        'Call Kosongkan()
                    Else
                        MsgBox("Data Gagal Ditambah")
                    End If

                End If
            End If
        Else
            cmd = New OleDbCommand("select * from Pengambilan where ID_transaksi = '" & nota & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim tambah As String
                tambah = "Insert into Pengambilan(ID_transaksi, Nama , Tanggal_Masuk, Tanggal_Jadi, sisa,Total_Bayar, keterangan)" & " VALUES ('" & nota & "', '" & nama & "', '" & waktu & "', '" & jadi & "', " & sisa & "," & totbay & ", 'Belum diambil'" & ")"
                cmd = New OleDbCommand(tambah, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil ditambah")
                'Call Kosongkan()
            Else
                MsgBox("Data Gagal Ditambah")
            End If
        End If


    End Sub
    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Kosongkan()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Struk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Struk.Click
        nota = cmbnota.Text
        If nota = "" Then
            MsgBox("Maaf Transaksi Belum Selesai", MsgBoxStyle.Critical, "Error")
        Else
            cetakstruk.CrystalReport11.SetParameterValue("ID_Transaksi", nota)
            cetakstruk.CrystalReport11.SetParameterValue("KAsir", lbluser.Text)
            cetakstruk.Show()
        End If
    End Sub

    Private Sub cmbidpel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbidpel.SelectedIndexChanged
        idpel = cmbidpel.Text
        Try
            cmd = New OleDbCommand("Select * from Pelanggan where ID_Pelanggan= '" & idpel & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                txtnamapel.Text = rd.GetString(1)
                txtalamat.Text = rd.GetValue(2)
                txtno.Text = rd.GetValue(3)
                masa = rd.GetValue(4)
                txtnamapel.Focus()
            Else
                Call Kosongkan()
                txtnamapel.Focus()
            End If
        Catch ex As Exception
        End Try

    End Sub


End Class
