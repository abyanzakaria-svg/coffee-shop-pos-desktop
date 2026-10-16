<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tabel1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbInput = New System.Windows.Forms.GroupBox()
        Me.numJumlah = New System.Windows.Forms.NumericUpDown()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.cmbMenu = New System.Windows.Forms.ComboBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.tabel9 = New System.Windows.Forms.Label()
        Me.tabel10 = New System.Windows.Forms.Label()
        Me.dgvPesanan = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gbInput.SuspendLayout()
        CType(Me.numJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 670)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(35, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 76)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "☕ KOPI KITA"
        '
        'gbInput
        '
        Me.gbInput.Controls.Add(Me.numJumlah)
        Me.gbInput.Controls.Add(Me.txtHarga)
        Me.gbInput.Controls.Add(Me.cmbMenu)
        Me.gbInput.Controls.Add(Me.btnTambah)
        Me.gbInput.Controls.Add(Me.label4)
        Me.gbInput.Controls.Add(Me.tabel9)
        Me.gbInput.Controls.Add(Me.tabel10)
        Me.gbInput.Location = New System.Drawing.Point(236, 0)
        Me.gbInput.Name = "gbInput"
        Me.gbInput.Size = New System.Drawing.Size(854, 248)
        Me.gbInput.TabIndex = 2
        Me.gbInput.TabStop = False
        Me.gbInput.Text = "Input Pesanan"
        '
        'numJumlah
        '
        Me.numJumlah.Location = New System.Drawing.Point(187, 150)
        Me.numJumlah.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numJumlah.Name = "numJumlah"
        Me.numJumlah.Size = New System.Drawing.Size(206, 35)
        Me.numJumlah.TabIndex = 6
        Me.numJumlah.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(187, 94)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(206, 35)
        Me.txtHarga.TabIndex = 5
        '
        'cmbMenu
        '
        Me.cmbMenu.FormattingEnabled = True
        Me.cmbMenu.Location = New System.Drawing.Point(187, 46)
        Me.cmbMenu.Name = "cmbMenu"
        Me.cmbMenu.Size = New System.Drawing.Size(206, 38)
        Me.cmbMenu.TabIndex = 4
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.LightGray
        Me.btnTambah.Location = New System.Drawing.Point(327, 195)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(182, 47)
        Me.btnTambah.TabIndex = 3
        Me.btnTambah.Text = "Tambah Menu"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(6, 154)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(161, 31)
        Me.label4.TabIndex = 2
        Me.label4.Text = "Jumlah      :"
        '
        'tabel9
        '
        Me.tabel9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabel9.Location = New System.Drawing.Point(6, 94)
        Me.tabel9.Name = "tabel9"
        Me.tabel9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabel9.Size = New System.Drawing.Size(127, 30)
        Me.tabel9.TabIndex = 1
        Me.tabel9.Text = "Harga        :"
        '
        'tabel10
        '
        Me.tabel10.AutoSize = True
        Me.tabel10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabel10.Location = New System.Drawing.Point(6, 46)
        Me.tabel10.Name = "tabel10"
        Me.tabel10.Size = New System.Drawing.Size(123, 30)
        Me.tabel10.TabIndex = 0
        Me.tabel10.Text = "Pilih Menu :"
        '
        'dgvPesanan
        '
        Me.dgvPesanan.BackgroundColor = System.Drawing.Color.White
        Me.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPesanan.Location = New System.Drawing.Point(236, 248)
        Me.dgvPesanan.Name = "dgvPesanan"
        Me.dgvPesanan.RowHeadersWidth = 72
        Me.dgvPesanan.RowTemplate.Height = 31
        Me.dgvPesanan.Size = New System.Drawing.Size(854, 189)
        Me.dgvPesanan.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBayar)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnExport)
        Me.GroupBox1.Controls.Add(Me.btnBayar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(239, 443)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(851, 227)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pembayaran"
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(163, 96)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(197, 35)
        Me.txtBayar.TabIndex = 6
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(158, 50)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(71, 37)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Rp 0"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Silver
        Me.btnReset.Location = New System.Drawing.Point(589, 166)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(181, 49)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Transaksi Baru"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.Silver
        Me.btnExport.Location = New System.Drawing.Point(317, 166)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(177, 49)
        Me.btnExport.TabIndex = 3
        Me.btnExport.Text = "Simpan Struk"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'btnBayar
        '
        Me.btnBayar.BackColor = System.Drawing.Color.Silver
        Me.btnBayar.Location = New System.Drawing.Point(18, 166)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(225, 49)
        Me.btnBayar.TabIndex = 2
        Me.btnBayar.Text = "Proses Pembayaran"
        Me.btnBayar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(13, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 37)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Uang Bayar  :"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total             : "
        '
        'tabel1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1094, 670)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvPesanan)
        Me.Controls.Add(Me.gbInput)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "tabel1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coffee Shop POS & Cashier System"
        Me.Panel1.ResumeLayout(False)
        Me.gbInput.ResumeLayout(False)
        Me.gbInput.PerformLayout()
        CType(Me.numJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPesanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents gbInput As GroupBox
    Friend WithEvents tabel10 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents tabel9 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents cmbMenu As ComboBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents numJumlah As NumericUpDown
    Friend WithEvents dgvPesanan As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnBayar As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtBayar As TextBox
End Class
