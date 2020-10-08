'Abfragen wie viele Mitarbeiter soll eingegeben werden
'Eingabe der jeweiligen Namen
'Ausgabe der Namen
' 3 Mitarbeiter
'Bitte geben Sie den 1. Mitarbeiter
' bitte geben Sie den 2.
' Mitarbeiter: Helmut, David, Ivan
'12:00 Uhr gemeinsame Auflösung
Module ModulMitarbeiterInnenVerwaltung
    Sub main()
        Dim mitarbeiterInnen() As String
        Dim anzahl As Int16
        Console.WriteLine("Bitte Anzahl")

        anzahl = Console.ReadLine()

        ReDim mitarbeiterInnen(anzahl - 1)


        Eingabe(mitarbeiterInnen)

        Ausgabe(mitarbeiterInnen)
    End Sub

    Sub Eingabe(m() As String)

        'For i As Int16 = m.GetLowerBound(0) To m.GetUpperBound(0)
        'Console.WriteLine("Bitte geben Sie den {0}. Namen ein", (i + 1))
        'm(i) = Console.ReadLine()
        'Next
        Dim counter As Integer = 0
        For Each mitarbeiter In m
            Console.WriteLine("Bitte geben Sie den Namen ein")
            m(counter) = Console.ReadLine()
            counter += 1
            'm=Console.ReadLine()
        Next
    End Sub

    Sub Ausgabe(mitarbeiterinnen() As String)
        For Each mitarbeiter In mitarbeiterinnen
            Console.WriteLine(mitarbeiter)
        Next

    End Sub

End Module
