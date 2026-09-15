Imports System.Windows.Forms.VisualStyles

Module ModArray

    Function hitung(panjang As Integer, lebar As Integer, ByRef jenisPerhitungan As String) As Integer
        If panjang > 50 Then
            Return panjang * lebar
        Else
            Return 2 * (panjang + lebar)
        End If
    End Function

    Public nilai() As Integer = {50, 60, 70, 80, 90, 100}
    Public nilai2D(,) As Integer = {
        {55, 53, 65},
        {70, 72, 78},
        {80, 85, 90}
    }
End Module
