<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laundry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laundry))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbidpel = New System.Windows.Forms.ComboBox
        Me.txtno = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btn_nonmember = New System.Windows.Forms.Button
        Me.btn_member = New System.Windows.Forms.Button
        Me.txtalamat = New System.Windows.Forms.TextBox
        Me.txtnamapel = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbnota = New System.Windows.Forms.ComboBox
        Me.txttgljadi = New System.Windows.Forms.Label
        Me.txttglmasuk = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnjenis = New System.Windows.Forms.Button
        Me.lblsatuan = New System.Windows.Forms.Label
        Me.lblitem = New System.Windows.Forms.Label
        Me.btnhitung = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.rbekspress = New System.Windows.Forms.RadioButton
        Me.rbreguler = New System.Windows.Forms.RadioButton
        Me.txtjumlah = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lbljumlah = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rbkarpet = New System.Windows.Forms.RadioButton
        Me.rbpotong = New System.Windows.Forms.RadioButton
        Me.rbkilo = New System.Windows.Forms.RadioButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txttotbayar = New System.Windows.Forms.TextBox
        Me.txtdiskon = New System.Windows.Forms.TextBox
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.txtbiaya = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnproses = New System.Windows.Forms.Button
        Me.txtsisa = New System.Windows.Forms.TextBox
        Me.txtumuk = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Struk = New System.Windows.Forms.Button
        Me.Bayar = New System.Windows.Forms.Button
        Me.lbluser = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbidpel)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btn_nonmember)
        Me.GroupBox1.Controls.Add(Me.btn_member)
        Me.GroupBox1.Controls.Add(Me.txtalamat)
        Me.GroupBox1.Controls.Add(Me.txtnamapel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(19, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 148)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pelanggan"
        '
        'cmbidpel
        '
        Me.cmbidpel.FormattingEnabled = True
        Me.cmbidpel.Location = New System.Drawing.Point(115, 44)
        Me.cmbidpel.Name = "cmbidpel"
        Me.cmbidpel.Size = New System.Drawing.Size(121, 21)
        Me.cmbidpel.TabIndex = 11
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(115, 119)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(167, 20)
        Me.txtno.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(58, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "No Telp :"
        '
        'btn_nonmember
        '
        Me.btn_nonmember.Location = New System.Drawing.Point(207, 15)
        Me.btn_nonmember.Name = "btn_nonmember"
        Me.btn_nonmember.Size = New System.Drawing.Size(136, 23)
        Me.btn_nonmember.TabIndex = 8
        Me.btn_nonmember.Text = "Bukan Member"
        Me.btn_nonmember.UseVisualStyleBackColor = True
        '
        'btn_member
        '
        Me.btn_member.Location = New System.Drawing.Point(115, 15)
        Me.btn_member.Name = "btn_member"
        Me.btn_member.Size = New System.Drawing.Size(75, 23)
        Me.btn_member.TabIndex = 7
        Me.btn_member.Text = "Member"
        Me.btn_member.UseVisualStyleBackColor = True
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(115, 95)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(167, 20)
        Me.txtalamat.TabIndex = 5
        '
        'txtnamapel
        '
        Me.txtnamapel.Location = New System.Drawing.Point(115, 69)
        Me.txtnamapel.Name = "txtnamapel"
        Me.txtnamapel.Size = New System.Drawing.Size(167, 20)
        Me.txtnamapel.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Pelanggan :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmbnota)
        Me.GroupBox2.Controls.Add(Me.txttgljadi)
        Me.GroupBox2.Controls.Add(Me.txttglmasuk)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Location = New System.Drawing.Point(403, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi"
        '
        'cmbnota
        '
        Me.cmbnota.FormattingEnabled = True
        Me.cmbnota.Location = New System.Drawing.Point(136, 17)
        Me.cmbnota.Name = "cmbnota"
        Me.cmbnota.Size = New System.Drawing.Size(121, 21)
        Me.cmbnota.TabIndex = 6
        '
        'txttgljadi
        '
        Me.txttgljadi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txttgljadi.Location = New System.Drawing.Point(136, 65)
        Me.txttgljadi.Name = "txttgljadi"
        Me.txttgljadi.Size = New System.Drawing.Size(100, 23)
        Me.txttgljadi.TabIndex = 5
        '
        'txttglmasuk
        '
        Me.txttglmasuk.Location = New System.Drawing.Point(136, 43)
        Me.txttglmasuk.Name = "txttglmasuk"
        Me.txttglmasuk.Size = New System.Drawing.Size(100, 20)
        Me.txttglmasuk.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tanggal Selesai :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Tanggal Masuk :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "No Nota :"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnjenis)
        Me.GroupBox3.Controls.Add(Me.lblsatuan)
        Me.GroupBox3.Controls.Add(Me.lblitem)
        Me.GroupBox3.Controls.Add(Me.btnhitung)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.txtjumlah)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.lbljumlah)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Location = New System.Drawing.Point(19, 269)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(677, 168)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detail"
        '
        'btnjenis
        '
        Me.btnjenis.Location = New System.Drawing.Point(22, 90)
        Me.btnjenis.Name = "btnjenis"
        Me.btnjenis.Size = New System.Drawing.Size(87, 23)
        Me.btnjenis.TabIndex = 14
        Me.btnjenis.Text = "Masukkan"
        Me.btnjenis.UseVisualStyleBackColor = True
        '
        'lblsatuan
        '
        Me.lblsatuan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblsatuan.Location = New System.Drawing.Point(237, 120)
        Me.lblsatuan.Name = "lblsatuan"
        Me.lblsatuan.Size = New System.Drawing.Size(100, 23)
        Me.lblsatuan.TabIndex = 13
        '
        'lblitem
        '
        Me.lblitem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblitem.Location = New System.Drawing.Point(237, 90)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(100, 29)
        Me.lblitem.TabIndex = 12
        '
        'btnhitung
        '
        Me.btnhitung.Location = New System.Drawing.Point(568, 88)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(75, 23)
        Me.btnhitung.TabIndex = 10
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbekspress)
        Me.GroupBox6.Controls.Add(Me.rbreguler)
        Me.GroupBox6.Location = New System.Drawing.Point(464, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 65)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tipe"
        '
        'rbekspress
        '
        Me.rbekspress.AutoSize = True
        Me.rbekspress.Location = New System.Drawing.Point(104, 31)
        Me.rbekspress.Name = "rbekspress"
        Me.rbekspress.Size = New System.Drawing.Size(68, 17)
        Me.rbekspress.TabIndex = 1
        Me.rbekspress.TabStop = True
        Me.rbekspress.Text = "Ekspress"
        Me.rbekspress.UseVisualStyleBackColor = True
        '
        'rbreguler
        '
        Me.rbreguler.AutoSize = True
        Me.rbreguler.Location = New System.Drawing.Point(13, 31)
        Me.rbreguler.Name = "rbreguler"
        Me.rbreguler.Size = New System.Drawing.Size(62, 17)
        Me.rbreguler.TabIndex = 0
        Me.rbreguler.TabStop = True
        Me.rbreguler.Text = "Reguler"
        Me.rbreguler.UseVisualStyleBackColor = True
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(433, 90)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(100, 20)
        Me.txtjumlah.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(184, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Satuan :"
        '
        'lbljumlah
        '
        Me.lbljumlah.AutoSize = True
        Me.lbljumlah.Location = New System.Drawing.Point(371, 93)
        Me.lbljumlah.Name = "lbljumlah"
        Me.lbljumlah.Size = New System.Drawing.Size(46, 13)
        Me.lbljumlah.TabIndex = 3
        Me.lbljumlah.Text = "Jumlah :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(167, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nama Item :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbkarpet)
        Me.GroupBox4.Controls.Add(Me.rbpotong)
        Me.GroupBox4.Controls.Add(Me.rbkilo)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(447, 65)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Jenis"
        '
        'rbkarpet
        '
        Me.rbkarpet.AutoSize = True
        Me.rbkarpet.Location = New System.Drawing.Point(226, 29)
        Me.rbkarpet.Name = "rbkarpet"
        Me.rbkarpet.Size = New System.Drawing.Size(79, 17)
        Me.rbkarpet.TabIndex = 2
        Me.rbkarpet.TabStop = True
        Me.rbkarpet.Text = "Karpet (m2)"
        Me.rbkarpet.UseVisualStyleBackColor = True
        '
        'rbpotong
        '
        Me.rbpotong.AutoSize = True
        Me.rbpotong.Location = New System.Drawing.Point(92, 29)
        Me.rbpotong.Name = "rbpotong"
        Me.rbpotong.Size = New System.Drawing.Size(128, 17)
        Me.rbpotong.TabIndex = 1
        Me.rbpotong.TabStop = True
        Me.rbpotong.Text = "Satuan/Potong (PCS)"
        Me.rbpotong.UseVisualStyleBackColor = True
        '
        'rbkilo
        '
        Me.rbkilo.AutoSize = True
        Me.rbkilo.Location = New System.Drawing.Point(8, 29)
        Me.rbkilo.Name = "rbkilo"
        Me.rbkilo.Size = New System.Drawing.Size(78, 17)
        Me.rbkilo.TabIndex = 0
        Me.rbkilo.TabStop = True
        Me.rbkilo.Text = "Kiloan (KG)"
        Me.rbkilo.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.txttotbayar)
        Me.GroupBox5.Controls.Add(Me.txtdiskon)
        Me.GroupBox5.Controls.Add(Me.txttotal)
        Me.GroupBox5.Controls.Add(Me.txtbiaya)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox5.Location = New System.Drawing.Point(30, 437)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(312, 146)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detail Biaya"
        '
        'txttotbayar
        '
        Me.txttotbayar.Location = New System.Drawing.Point(136, 99)
        Me.txttotbayar.Name = "txttotbayar"
        Me.txttotbayar.Size = New System.Drawing.Size(100, 20)
        Me.txttotbayar.TabIndex = 7
        '
        'txtdiskon
        '
        Me.txtdiskon.Location = New System.Drawing.Point(136, 73)
        Me.txtdiskon.Name = "txtdiskon"
        Me.txtdiskon.Size = New System.Drawing.Size(100, 20)
        Me.txtdiskon.TabIndex = 6
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(136, 47)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 20)
        Me.txttotal.TabIndex = 5
        '
        'txtbiaya
        '
        Me.txtbiaya.Location = New System.Drawing.Point(136, 21)
        Me.txtbiaya.Name = "txtbiaya"
        Me.txtbiaya.Size = New System.Drawing.Size(100, 20)
        Me.txtbiaya.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(35, 99)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Total Bayar :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(60, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Diskon :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(69, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Total :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(67, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Biaya :"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(175, 90)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Keluar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(94, 90)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Batal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnproses
        '
        Me.btnproses.Location = New System.Drawing.Point(13, 90)
        Me.btnproses.Name = "btnproses"
        Me.btnproses.Size = New System.Drawing.Size(75, 23)
        Me.btnproses.TabIndex = 13
        Me.btnproses.Text = "Proses"
        Me.btnproses.UseVisualStyleBackColor = True
        '
        'txtsisa
        '
        Me.txtsisa.Location = New System.Drawing.Point(136, 58)
        Me.txtsisa.Name = "txtsisa"
        Me.txtsisa.Size = New System.Drawing.Size(100, 20)
        Me.txtsisa.TabIndex = 12
        '
        'txtumuk
        '
        Me.txtumuk.Location = New System.Drawing.Point(136, 19)
        Me.txtumuk.Name = "txtumuk"
        Me.txtumuk.Size = New System.Drawing.Size(100, 20)
        Me.txtumuk.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(69, 61)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 13)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Sisa :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(33, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Uang Muka :"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.Struk)
        Me.GroupBox7.Controls.Add(Me.Button4)
        Me.GroupBox7.Controls.Add(Me.Bayar)
        Me.GroupBox7.Controls.Add(Me.Button3)
        Me.GroupBox7.Controls.Add(Me.txtumuk)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.btnproses)
        Me.GroupBox7.Controls.Add(Me.txtsisa)
        Me.GroupBox7.Controls.Add(Me.Label17)
        Me.GroupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox7.Location = New System.Drawing.Point(348, 441)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(354, 142)
        Me.GroupBox7.TabIndex = 4
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Bayar"
        '
        'Struk
        '
        Me.Struk.Location = New System.Drawing.Point(256, 90)
        Me.Struk.Name = "Struk"
        Me.Struk.Size = New System.Drawing.Size(75, 23)
        Me.Struk.TabIndex = 16
        Me.Struk.Text = "Struk"
        Me.Struk.UseVisualStyleBackColor = True
        '
        'Bayar
        '
        Me.Bayar.Location = New System.Drawing.Point(260, 14)
        Me.Bayar.Name = "Bayar"
        Me.Bayar.Size = New System.Drawing.Size(75, 23)
        Me.Bayar.TabIndex = 13
        Me.Bayar.Text = "Bayar"
        Me.Bayar.UseVisualStyleBackColor = True
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.BackColor = System.Drawing.Color.Transparent
        Me.lbluser.Location = New System.Drawing.Point(681, 9)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(55, 13)
        Me.lbluser.TabIndex = 5
        Me.lbluser.Text = "Username"
        '
        'Laundry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(748, 562)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Laundry"
        Me.Text = "Sistem Administrasi Laundri"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtnamapel As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttglmasuk As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbljumlah As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rbkarpet As System.Windows.Forms.RadioButton
    Friend WithEvents rbpotong As System.Windows.Forms.RadioButton
    Friend WithEvents rbkilo As System.Windows.Forms.RadioButton
    Friend WithEvents txttotbayar As System.Windows.Forms.TextBox
    Friend WithEvents txtdiskon As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtbiaya As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnhitung As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbekspress As System.Windows.Forms.RadioButton
    Friend WithEvents rbreguler As System.Windows.Forms.RadioButton
    Friend WithEvents txttgljadi As System.Windows.Forms.Label
    Friend WithEvents txtsisa As System.Windows.Forms.TextBox
    Friend WithEvents txtumuk As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnproses As System.Windows.Forms.Button
    Friend WithEvents btn_nonmember As System.Windows.Forms.Button
    Friend WithEvents btn_member As System.Windows.Forms.Button
    Friend WithEvents lblitem As System.Windows.Forms.Label
    Friend WithEvents lblsatuan As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Bayar As System.Windows.Forms.Button
    Friend WithEvents btnjenis As System.Windows.Forms.Button
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents Struk As System.Windows.Forms.Button
    Friend WithEvents cmbidpel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbnota As System.Windows.Forms.ComboBox

End Class
