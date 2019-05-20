Imports System.Math

Module Potencias
    Sub Main(args As String())
        potencia()
    End Sub
    Function potencia() As Integer
        Dim a, r2, r3, r5 As Integer
        Console.Write("Ingrese un valor: ")
        a = Console.ReadLine()
        r2 = Pow(a, 2)
        r3 = Pow(a, 3)
        r5 = Pow(a, 5)
        Console.WriteLine("Al cuadrado: " & r2 & " Al cubo: " & r3 & " A la quinta: " & r5)

    End Function

End Module
'Crear un proyecto y un módulo llamado “Potencias” que implemente una función que
'retornará la primera vez que es invocada el valor al cuadrado, la siguiente vez el valor al
'cubo y así sucesivamente. Ingresar por teclado un valor numérico y mostrar ese valor
'elevado a la 2°, 3° y 5° potencias. Por ejemplo, ingresando 3 mostrar: 9, 27 y 243.