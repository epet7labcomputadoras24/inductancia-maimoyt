Imports System
Imports System.Security.Cryptography.X509Certificates

Module Program
    Sub Main(args As String())
        Dim fr As Double
        Dim ind As Double
        Dim imp As Double
        Console.WriteLine("escribir el valor de inductancia")
        ind = Console.ReadLine()
        Console.WriteLine("escribir el valor de frecuencia")
        fr = Console.ReadLine()
        imp = 2 * Math.PI * fr * ind
        Console.WriteLine("la impedancia es en total" & imp)
        Console.ReadLine()
    End Sub
End Module
