Imports System

Module Program

    Sub Main(args As String())
        Dim a, b, c, d As Integer
        Console.Write("Ingrese un Valor: ")
        a = Console.ReadLine
        Console.Write("Ingrese otro valor: ")
        b = Console.ReadLine
        Console.Write("Ingrese otro valor: ")
        c = Console.ReadLine
        Console.Write("Ingrese otro valor: ")
        d = Console.ReadLine
        Console.WriteLine("Suma de 2 valores: " & suma1(a, b))
        Console.WriteLine("Suma de 3 valores: " & suma2(a, b, c))
        Console.WriteLine("Suma de 4 valores: " & suma3(a, b, c, d))


    End Sub
    Function suma1(a, b) As Integer
        Dim suma As Integer
        suma = a + b
        Return suma
    End Function
    Function suma2(a, b, c) As Integer
        Dim suma As Integer
        suma = a + b + c
        Return suma
    End Function
    Function suma3(a, b, c, d) As Integer
        Dim suma As Integer
        suma = a + b + c + d
        Return suma
    End Function



End Module
