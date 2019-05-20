Imports System

Module Acumuladora

    Sub Main(args As String())
        Acomulador()

    End Sub
    Friend Sub Acomulador()
        Dim numero As Decimal
        Console.Write("Ingrese un Numero: ")
        numero = Console.ReadLine()
        numero += numero
        Console.WriteLine(numero)
        numero += numero
        Console.WriteLine(numero)
        numero += numero
        Console.WriteLine(numero)
    End Sub


End Module
'Crear un proyecto y un módulo llamado “Acumuladora” que implemente una subrutina que
'recibe un valor Decimal y lo va acumulando. Invocar por lo menos tres veces la subrutina
'desde el main y mostrar luego de cada llamada mostrar el valor acumulado.