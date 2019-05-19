Imports System

Module Nueva_fecha
    Public nuevafecha, fecha As Date
    Public dia As Integer
    Sub Main(args As String())
        Console.Write("Ingrese una fecha(dia/mes/anio): ")
        fecha = Console.ReadLine()
        Console.Write("Ingrese los dias a agregar: ")
        dia = Console.ReadLine()
        Console.Write("La fecha es: " & fecha & vbLf & "La nueva fecha es: " & fechas())
    End Sub
    Function fechas() As Date
        nuevafecha = fecha.AddDays(dia)
        Return nuevafecha

    End Function

End Module
'Crear un proyecto y un módulo llamado “Nueva_fecha” con una función que reciba un valor
'fecha y un valor entero que representa una cantidad de días y retorne a la fecha sumada la
'cantidad de días. En el módulo principal ingresar una fecha y la cantidad de días, invocar a la
'función creada y mostrar el valor obtenido.