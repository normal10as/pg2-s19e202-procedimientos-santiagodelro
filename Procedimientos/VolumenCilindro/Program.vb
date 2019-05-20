Imports System
Imports System.Math
Module VolumenCilindro
    Sub Main(args As String())
        volumen()

    End Sub

    Function volumen() As Single
        Dim v, p, r, h As Single
        Console.Write("Ingrese el Radio: ")
        r = Console.ReadLine()
        Console.Write("Ingrese la Altura: ")
        h = Console.ReadLine()
        p = 3.14159265
        v = p * (Pow(r, 2) * h)
        Console.WriteLine("El volumen es: " & v)
        Return v

    End Function
End Module
'Crear un proyecto y un módulo llamado “VolumenCilindro” que implemente una función
'que lea el radio de la base y la altura de un cilindro y que calcule y devuelva el volumen. El
'volumen de un cilindro se calcula multiplicando la constante Pi (π=3.14159265) por el
'cuadrado del radio de la base(r) por la altura(h) de lo que se da la siguiente fórmula: v =
'πr²h. Ingresar los valores por teclado y mostrar el resultado en consola.