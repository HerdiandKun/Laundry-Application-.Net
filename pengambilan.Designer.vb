<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pengambilan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pengambilan))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtnama = New System.Windows.Forms.TextBox
        Me.txtsisa = New System.Windows.Forms.TextBox
        Me.btnproses = New System.Windows.Forms.Button
        Me.btnBatal = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbltgl = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txttgl = New System.Windows.Forms.TextBox
        Me.cmbnota = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(88, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Nota :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(100, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(78, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sisa Bayar :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pengambilan"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(147, 191)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(100, 20)
        Me.txtnama.TabIndex = 6
        '
        'txtsisa
        '
        Me.txtsisa.Location = New System.Drawing.Point(147, 249)
        Me.txtsisa.Name = "txtsisa"
        Me.txtsisa.Size = New System.Drawing.Size(100, 20)
        Me.txtsisa.TabIndex = 7
        '
        'btnproses
        '
        Me.btnproses.Location = New System.Drawing.Point(66, 290)
        Me.btnproses.Name = "btnproses"
        Me.btnproses.Size = New System.Drawing.Size(75, 23)
        Me.btnproses.TabIndex = 8
        Me.btnproses.Text = "Proses"
        Me.btnproses.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(172, 290)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 9
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(88, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tanggal :"
        '
        'lbltgl
        '
        Me.lbltgl.AutoSize = True
        Me.lbltgl.BackColor = System.Drawing.Color.Transparent
        Me.lbltgl.Location = New System.Drawing.Point(146, 123)
        Me.lbltgl.Name = "lbltgl"
        Me.lbltgl.Size = New System.Drawing.Size(0, 13)
        Me.lbltgl.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(67, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tanggal Jadi :"
        '
        'txttgl
        '
        Me.txttgl.Location = New System.Drawing.Point(147, 217)
        Me.txttgl.Name = "txttgl"
        Me.txttgl.Size = New System.Drawing.Size(100, 20)
        Me.txttgl.TabIndex = 13
        '
        'cmbnota
        '
        Me.cmbnota.FormattingEnabled = True
        Me.cmbnota.Location = New System.Drawing.Point(147, 158)
        Me.cmbnota.Name = "cmbnota"
        Me.cmbnota.Size = New System.Drawing.Size(111, 21)
        Me.cmbnota.TabIndex = 14
        '
        'pengambilan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(325, 323)
        Me.Controls.Add(Me.cmbnota)
        Me.Controls.Add(Me.txttgl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbltgl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnproses)
        Me.Controls.Add(Me.txtsisa)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pengambilan"
        Me.Text = "Pengambilan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtsisa As System.Windows.Forms.TextBox
    Friend WithEvents btnproses As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbltgl As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttgl As System.Windows.Forms.TextBox
    Friend WithEvents cmbnota As System.Windows.Forms.ComboBox
End Class
