Imports System.IO

Public Class tabel1
    ' Variabel global penyimpan total transaksi
    Dim totalBayar As Integer = 0
    Dim riwayatStruk As String = ""

    ' 1. Event Saat Form Pertama Kali Terbuka
    Private Sub tabel1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mengisi pilihan menu cafe ke ComboBox
        cmbMenu.Items.Clear()
        cmbMenu.Items.Add("Espresso Single")
        cmbMenu.Items.Add("Kopi Susu Aren")
        cmbMenu.Items.Add("Caramel Macchiato")
        cmbMenu.Items.Add("Matcha Green Tea")
        cmbMenu.Items.Add("Croissant Butter")
        cmbMenu.Items.Add("Roti Bakar Keju")

        ' Mengatur kolom tabel DataGridView otomatis
        dgvPesanan.Columns.Clear()
        dgvPesanan.Columns.Add("Menu", "Nama Menu")
        dgvPesanan.Columns.Add("Harga", "Harga Satuan")
        dgvPesanan.Columns.Add("Qty", "Jumlah")
        dgvPesanan.Columns.Add("Subtotal", "Subtotal")
        dgvPesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPesanan.AllowUserToAddRows = False

        ' Nilai awal total
        lblTotal.Text = "Rp 0"
    End Sub

    ' 2. Event Saat Menu Dipilih (Harga otomatis keluar di TextBox)
    Private Sub cmbMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMenu.SelectedIndexChanged
        If cmbMenu.SelectedItem Is Nothing Then Exit Sub

        Select Case cmbMenu.SelectedItem.ToString()
            Case "Espresso Single"
                txtHarga.Text = "15000"
            Case "Kopi Susu Aren"
                txtHarga.Text = "20000"
            Case "Caramel Macchiato"
                txtHarga.Text = "28000"
            Case "Matcha Green Tea"
                txtHarga.Text = "25000"
            Case "Croissant Butter"
                txtHarga.Text = "22000"
            Case "Roti Bakar Keju"
                txtHarga.Text = "18000"
            Case Else
                txtHarga.Text = "0"
        End Select
    End Sub

    ' 3. Tombol Tambah Menu ke Tabel Pesanan
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If cmbMenu.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih menu minuman/makanan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim harga As Integer = 0
        Integer.TryParse(txtHarga.Text, harga)

        Dim qty As Integer = CInt(numJumlah.Value)
        Dim subtotal As Integer = harga * qty

        ' Masukkan data baris ke tabel DataGridView
        dgvPesanan.Rows.Add(cmbMenu.SelectedItem.ToString(), "Rp " & harga.ToString("N0"), qty, "Rp " & subtotal.ToString("N0"))

        ' Akumulasi total belanja
        totalBayar += subtotal
        lblTotal.Text = "Rp " & totalBayar.ToString("N0")

        ' Reset input pilihan menu
        cmbMenu.SelectedIndex = -1
        txtHarga.Clear()
        numJumlah.Value = 1
    End Sub

    ' 4. Tombol Proses Pembayaran & Buat Struk
    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        If totalBayar = 0 Then
            MessageBox.Show("Belum ada menu yang dipesan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim uangDiterima As Integer
        If Not Integer.TryParse(txtBayar.Text, uangDiterima) Then
            MessageBox.Show("Masukkan nominal pembayaran berupa angka!", "Error Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If uangDiterima < totalBayar Then
            Dim kekurangan As Integer = totalBayar - uangDiterima
            MessageBox.Show("Uang tidak mencukupi!" & vbCrLf & "Kekurangan: Rp " & kekurangan.ToString("N0"), "Pembayaran Kurang", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim kembalian As Integer = uangDiterima - totalBayar

            ' Rancang teks struk pembayaran
            riwayatStruk = "====================================" & vbCrLf &
                           "          KOPI KITA CAFE            " & vbCrLf &
                           "      Jl. Mahasiswa No. 1 UTS       " & vbCrLf &
                           "====================================" & vbCrLf &
                           "Waktu Transaksi : " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & vbCrLf &
                           "------------------------------------" & vbCrLf

            For Each row As DataGridViewRow In dgvPesanan.Rows
                riwayatStruk &= row.Cells(0).Value.ToString() & " x" & row.Cells(2).Value.ToString() & " : " & row.Cells(3).Value.ToString() & vbCrLf
            Next

            riwayatStruk &= "------------------------------------" & vbCrLf &
                           "TOTAL BELANJA   : Rp " & totalBayar.ToString("N0") & vbCrLf &
                           "UANG DITERIMA   : Rp " & uangDiterima.ToString("N0") & vbCrLf &
                           "KEMBALIAN       : Rp " & kembalian.ToString("N0") & vbCrLf &
                           "====================================" & vbCrLf &
                           "       Terima Kasih & Datang Lagi!   " & vbCrLf &
                           "===================================="

            MessageBox.Show(riwayatStruk, "Transaksi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' 5. Tombol Simpan Struk ke File TXT di Desktop
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If String.IsNullOrEmpty(riwayatStruk) Then
            MessageBox.Show("Belum ada transaksi sukses yang bisa disimpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            Dim pathDesktop As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Struk_Pembayaran.txt")
            File.WriteAllText(pathDesktop, riwayatStruk)
            MessageBox.Show("Struk transaksi berhasil disimpan di Desktop:" & vbCrLf & pathDesktop, "Export Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 6. Tombol Transaksi Baru / Reset
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        dgvPesanan.Rows.Clear()
        totalBayar = 0
        riwayatStruk = ""
        lblTotal.Text = "Rp 0"
        txtBayar.Clear()
        txtHarga.Clear()
        cmbMenu.SelectedIndex = -1
        numJumlah.Value = 1
    End Sub
End Class