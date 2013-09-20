Module Module1

    Sub Main()
        Dim Numero As Integer
        Dim Descuento, Final As Double

        Numero = LeeEntero("Ingrese numero ", "No a ingresado numero valido ", 1, 9000)

        If Numero < 795 Then
            Descuento = CDbl(Numero) * 0.08
        Else
            Descuento = CDbl(Numero) * 0.0983
        End If
        Final = CDbl(Numero) - Descuento

        Console.Clear()
        Console.WriteLine(vbCrLf & vbCrLf & "El numero ingresado es: " & Numero)
        Console.WriteLine("El descuento realizado es: " & Descuento)
        Console.WriteLine("Numero-Descuento: " & Final)
        Console.ReadLine()
    End Sub
    Public Function LeeEntero(ByVal Texto As String, ByVal Err As String, ByVal MIN As Integer, ByVal MAX As Integer) As Integer
        Dim Num As Integer
Leer:
        Console.Write(vbCrLf & vbCrLf & Texto)
        Num = CInt(Console.ReadLine)
        If Num >= MIN And Num <= MAX Then
            Return Num
        Else
            Console.WriteLine(vbCrLf & Err)
            Console.ReadLine()
            GoTo Leer
        End If
    End Function
End Module
