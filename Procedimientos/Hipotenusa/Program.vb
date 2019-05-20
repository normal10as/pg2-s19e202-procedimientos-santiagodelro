Imports System
Imports System.Math
Module Hipotenusa
    Sub Main(args As String())
        Console.WriteLine(hipotenusa())
    End Sub
    Function hipotenusa() As Integer
        Dim a, b, c As Integer
        Console.Write("Ingrese el lado A: ")
        a = Console.ReadLine()
        Console.Write("Ingrese el lado B: ")
        b = Console.ReadLine()
        c = Pow(a, 2) + Pow(b, 2)
        c = Pow(c, 2)
        Return ("La hipotenusa el triangulo es: " & c)
    End Function

End Module

'Crear un proyecto y un módulo llamado “Hipotenusa” que implemente una función que
'reciba el tamaño de los lados A y B, calcule y devuelva C (hipotenusa). Dados los lados A y
'B de un triángulo rectángulo, según el teorema de Pitágoras, el cuadrado de la hipotenusa
'(C), es igual a la suma del cuadrado de los catetos (lados) de lo que se da la siguiente
'fórmula: c² = a² + b². Ingresar los valores por teclado y mostrar el resultado en consola.
