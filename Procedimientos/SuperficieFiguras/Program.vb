Imports System

Module SuperficieFiguras
    Sub Main(args As String())
        Dim Lado, Altura, h, BaseMayor, BaseMenor, Base As Integer

        Console.WriteLine("CUADRADO")
        Console.Write("Ingrese el Lado: ")
        Lado = Console.ReadLine
        Console.WriteLine("Superficie Cuadrado: " & cuadrado(Lado))

        Console.WriteLine("RECTANGULO")
        Console.Write("Ingrese la Base: ")
        Base = Console.ReadLine
        Console.Write("Ingrese la Altura: ")
        Altura = Console.ReadLine
        Console.WriteLine("Superficie Rectangulo: " & rectangulo(Base, Altura))

        Console.WriteLine("TRAPECIO")
        Console.Write("Ingrese la Base Mayor: ")
        BaseMayor = Console.ReadLine
        Console.Write("Ingrese la Base Menor: ")
        BaseMenor = Console.ReadLine
        Console.Write("Ingrese la Altura: ")
        h = Console.ReadLine
        Console.WriteLine("Superficie Trapecio: " & trapecio(BaseMenor, BaseMayor, h))

    End Sub

    Function cuadrado(Lado) As Integer
        Dim SupCuadrado As Integer
        SupCuadrado = Lado * Lado
        Return SupCuadrado
    End Function

    Function rectangulo(Base, Altura) As Integer
        Dim SupRectangulo As Integer
        SupRectangulo = Base * Altura
        Return SupRectangulo
    End Function

    Function trapecio(BaseMayor, BaseMenor, h) As Integer
        Dim SupTrapecio As Integer
        SupTrapecio = ((BaseMayor + BaseMenor) / 2) * h
        Return SupTrapecio
    End Function

End Module
