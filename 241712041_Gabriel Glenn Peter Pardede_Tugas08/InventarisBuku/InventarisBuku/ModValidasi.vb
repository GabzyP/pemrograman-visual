Option Strict On

Imports System.Text

' Module berisi fungsi pemeriksaan dan pengaman teks yang dipakai form
Public Module ModValidasi

    ' Mengembalikan True jika teks kosong atau hanya berisi spasi
    Public Function Kosong(teks As String) As Boolean
        Return String.IsNullOrWhiteSpace(teks)
    End Function

    ' Mengembalikan True jika teks tidak kosong dan seluruh karakternya angka 0 samoe 9
    Public Function SemuaDigit(teks As String) As Boolean
        If teks.Length = 0 Then Return False
        For Each c As Char In teks
            If c < "0"c OrElse c > "9"c Then Return False
        Next
        Return True
    End Function

    ' Mengembalikan True jika kode berformat BK diikuti 4 digit, huruf besar kecil diterima
    Public Function KodeBukuValid(kode As String) As Boolean
        Dim k As String = kode.Trim().ToUpperInvariant()
        If k.Length <> 6 Then Return False                      ' periksa panjang dulu agar Substring aman
        If Not k.StartsWith("BK", StringComparison.Ordinal) Then Return False
        Return SemuaDigit(k.Substring(2))
    End Function

    ' Mengamankan teks pengguna sebelum disisipkan ke ekspresi BindingSource.Filter.
    ' Tanda kutip digandakan; karakter [ ] * % ditaruh di dalam kurung siku agar dibaca apa adanya.
    Public Function AmankanTeksFilter(teks As String) As String
        Dim hasil As New StringBuilder()
        For Each c As Char In teks
            Select Case c
                Case "'"c
                    hasil.Append("''")
                Case "["c
                    hasil.Append("[[]")
                Case "]"c
                    hasil.Append("[]]")
                Case "*"c
                    hasil.Append("[*]")
                Case "%"c
                    hasil.Append("[%]")
                Case Else
                    hasil.Append(c)
            End Select
        Next
        Return hasil.ToString()
    End Function

End Module
