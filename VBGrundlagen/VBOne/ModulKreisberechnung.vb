Module ModulKreisberechnung

    Public Const PI As Double = 3.14
    Sub main()
        Dim umfang As Double, flaeche As Double, radius As Double

        Console.WriteLine("Bitte geben Sie den Radius ein")

        radius = CDbl(Console.ReadLine())

        umfang = 2 * radius * PI
        umfang = CalcUmfang(radius)

        flaeche = CalcFlaeche(radius)

        Dim ausgabe As String
        ausgabe = String.Format("Radius {0} Umfang {1:0.00} Flaeche {2:0.00}",
                    radius, umfang, flaeche)
        Console.WriteLine(ausgabe)

    End Sub

    Private Function CalcUmfang(radius As Double) As Double
        Return 2 * radius * Math.PI
    End Function

    Private Function CalcFlaeche(radius As Double) As Double
        Return Math.Pow(radius, 2) * PI
    End Function
End Module
