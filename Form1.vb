Public Class Form1

    Dim random As New Random
    Dim a(10) As Integer
    Dim i As Integer = 0
    Dim j As Integer = 0
    Dim menor As Integer
    Dim cadena As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()

        For i = 0 To 9
            a(i) = random.Next(0, 10)
            cadena = (cadena & a(i) & " ")
        Next
        cadena = (cadena & vbNewLine)
        menor = a(1)

        For j = 0 To 9

            If menor > a(j) Then
                menor = a(j)
            Else
                menor = menor
            End If

        Next

        cadena = (cadena & vbNewLine & " el menor es igual=" & menor)
        TextBox1.Text = cadena
    End Sub
End Class
