Module ArrayBeispiel

    'Abfragen wie viele Mitarbeiter soll eingegeben werden
    'Eingabe der jeweiligen Namen
    'Ausgabe der Namen
    ' 3 Mitarbeiter
    'Bitte geben Sie den 1. Mitarbeiter
    ' bitte geben Sie den 2.
    ' Mitarbeiter: Helmut, David, Ivan
    Sub main()
        Dim zahlen() As Integer
        ReDim zahlen(5)
        zahlen(0) = 12
        zahlen(1) = 15
        zahlen(2) = 30

        Console.WriteLine("normale For")
        For i As Integer = 0 To 2
            Console.WriteLine("{0}", zahlen(i))
        Next

        Console.WriteLine("For each")
        For Each i2 As Integer In zahlen
            Console.WriteLine("{0}", i2)
        Next

    End Sub

End Module
