Module Rechtecksberechnung

    Sub Main()
        Console.WriteLine("Willkommen zur Rechnecksberechnung")

        Dim laenge As Integer, breite As Integer
        Dim flaeche As Integer, umfang As Integer

        Console.WriteLine("Bitte geben Sie die Breite ein")
        breite = Console.ReadLine()

        Console.WriteLine("Bitte geben Sie die Laenge ein")
        laenge = Console.ReadLine()

        ' flaeche = laenge * breite
        'umfang = (2 * laenge) + (breite * 2)
        umfang = CalculateUmfang(laenge, breite)
        flaeche = CalculateFlaeche(laenge, breite)


        Console.WriteLine("Das Rechteck mit der Laenge {0} und der Breite {1} " &
                          " hat einen Umfang von {2} und eine Flaeche von {3} " _
                          , laenge, breite, umfang, flaeche)

        Console.WriteLine("Das Rechteck mit der Laenge {3} und der Breite {0} " &
                          " hat einen Umfang von {1} und eine Flaeche von {2} " _
                          , breite, umfang, flaeche, laenge)

    End Sub

    Function CalculateUmfang(laenge As Integer, breite As Integer) As Integer
        Return (2 * laenge) + (breite * 2)
    End Function

    Function CalculateFlaeche(laenge As Integer, breite As Integer) As Integer
        Return laenge * breite
    End Function





End Module
