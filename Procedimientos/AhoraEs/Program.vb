Imports System.DateTime

Module AhoraEs
    Sub Main(args As String())
        ImprimirHora()
        Console.WriteLine("La hora es: " & OptenerHora())
    End Sub

    Sub ImprimirHora()
        Console.WriteLine("Ahora es: " & Now.Date)
    End Sub

    Function OptenerHora() As String
        Return Now.Hour & ":" & Now.Minute
    End Function
End Module
