Public Class Rechteck

    Public laenge As Integer
    Public breite As Integer

    Function CalculateUmfang() As Integer
        Return (2 * laenge) + (breite * 2)
    End Function

    Function CalculateFlaeche() As Integer
        Return laenge * breite
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("Das Rechteck mit der Laenge {3} und der Breite {0} " &
                          " hat einen Umfang von {1} und eine Flaeche von {2} " _
                          , breite, CalculateUmfang(), CalculateFlaeche(), laenge)
    End Function

End Class
