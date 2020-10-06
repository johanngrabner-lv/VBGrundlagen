Module Module1

    Sub Main()
        Console.WriteLine("Hello Andritz from Graz V2")

        Dim r1 As New Rechteck

        Dim r2 As New Rechteck

        r1.laenge = 10
        r1.breite = 20

        r2.laenge = 50
        r2.breite = 70

        Console.WriteLine(r1.ToString())
        Console.WriteLine(r2.ToString())


        Dim flaeche As Integer
        flaeche = r1.CalculateFlaeche()
        Console.WriteLine(flaeche)

        flaeche = r2.CalculateFlaeche()
        Console.WriteLine(flaeche)
    End Sub

End Module
