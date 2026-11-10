Option Strict On

' Module berisi fungsi pemeriksaan yang bisa dipake oleh form mana pun
Public Module ModValidasi

    ' Mengembalikan True jika teks kosong atau hanya berisi spasi
    Public Function Kosong(teks As String) As Boolean
        Return String.IsNullOrWhiteSpace(teks)
    End Function

    ' Mengembalikan True jika teks tidak kosong dan seluruh karakternya angka 0-9
    Public Function SemuaDigit(teks As String) As Boolean
        If teks.Length = 0 Then Return False
        For Each c As Char In teks
            If c < "0"c OrElse c > "9"c Then Return False
        Next
        Return True
    End Function

    ' Mengembalikan True jika kode berformat BK diikuti 4 digit, huruf besar maupun kecil diterima
    Public Function KodeBukuValid(kode As String) As Boolean
        Dim k As String = kode.Trim().ToUpperInvariant()
        If k.Length <> 6 Then Return False                      ' periksa panjang dulu agar Substring aman
        If Not k.StartsWith("BK", StringComparison.Ordinal) Then Return False
        Return SemuaDigit(k.Substring(2))                       ' 4 karakter setelah BK harus angka
    End Function

End Module
