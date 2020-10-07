Module ModulSubAndFunctions

    Sub main()
        Dim antwort As Integer

        antwort = GetUnviversumAntwort()
        Console.WriteLine("Die Antwort ist {0}", antwort)

        Dim l As Integer = 10, b As Integer = 20

        Console.WriteLine(GetUmfangRechteckt(l, b))

        Dim user As String = "Ivan"

        SayHelloToByVal(user)
        SayHelloToByRef(user)


    End Sub
    Sub SayHelloToByVal(username As String)
        username = "Johann"
        Console.WriteLine("Hello {0}", username)
    End Sub
    Sub SayHelloToByRef(ByRef username As String)
        username = "Johann"
        Console.WriteLine("Hello {0}", username)
    End Sub

    Function GetUnviversumAntwort() As Integer
        Return 42
    End Function

    'laenge und breite sind parameter --> werden zu lokalen Variablen in der Funktion
    Function GetUmfangRechteckt(laenge As Integer, breite As Integer) As Integer
        Dim erg As Integer
        laenge = 37
        erg = (2 * laenge) + (2 * breite)
        Return erg

    End Function


End Module
