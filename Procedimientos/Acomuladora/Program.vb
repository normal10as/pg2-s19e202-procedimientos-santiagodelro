Imports System

Module Acumuladora
    Friend numero As Decimal
    Sub Main(args As String())
        Dim aco As Integer
        Call Acomulador()
        aco += numero
        Console.WriteLine(aco)
        Call Acomulador()
        aco += numero
        Console.WriteLine(aco)
        Call Acomulador()
        aco += numero
        Console.WriteLine(aco)
    End Sub
    Sub Acomulador()

        Console.Write("Ingrese un Numero: ")
        numero = Console.ReadLine



    End Sub


End Module
'Crear un proyecto y un módulo llamado “Acumuladora” que implemente una subrutina que
'recibe un valor Decimal y lo va acumulando. Invocar por lo menos tres veces la subrutina
'desde el main y mostrar luego de cada llamada mostrar el valor acumulado.