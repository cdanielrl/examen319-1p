Imports System

Module Program
    Sub Main(args As String())
        Dim num1 As Integer = Nothing
        Dim num2 As Integer = Nothing
        Dim num3 As Integer = Nothing
        Dim aux As Integer = Nothing
Numero1:
        Console.WriteLine("Ingrese el primer número")
        Dim s1 = Console.ReadLine()
        If Not Integer.TryParse(s1, num1) Then
            GoTo Numero1
        End If
Numero2:
        Console.WriteLine("Ingrese el segundo número")
        Dim s2 = Console.ReadLine()
        If Not Integer.TryParse(s2, num2) Then
            GoTo Numero2
        End If
Numero3:
        Console.WriteLine("Ingrese el tercer número")
        Dim s3 = Console.ReadLine()
        If Not Integer.TryParse(s3, num3) Then
            GoTo Numero3
        End If
Inicio:
        If (num1 > num2) Then
            aux = num1
            num1 = num2
            num2 = aux
        End If
        If (num2 > num3) Then
            aux = num2
            num2 = num3
            num3 = aux
        End If
        If Not (num1 <= num2 And num2 <= num3) Then
            GoTo Inicio
        End If
        Console.WriteLine("Números Ordenados Ascendentemente:")
        Console.WriteLine(num1)
        Console.WriteLine(num2)
        Console.WriteLine(num3)
    End Sub
End Module
