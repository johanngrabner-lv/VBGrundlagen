Module Zahelnraten
    Sub Main()
        Randomize() 'initialisierung des Zufallszahlengenerators mit Systemzeit
        Dim zuffalszahl As Single
        Dim eingabe As Integer
        Dim upperBound As Integer = 10
        Dim ausgabe As String
        zuffalszahl = Int(Rnd() * upperBound - 1) + 1 ' cast to int + 1 ,, 1...10

        Console.WriteLine("bitte geben Sie Ihren Tipp ab")
        eingabe = CInt(Console.ReadLine())

        If eingabe < zuffalszahl Then
            ausgabe = String.Format("Kleiner ZZ{0} Eingabe{1}", zuffalszahl, eingabe)
        ElseIf eingabe = zuffalszahl Then
            ausgabe = String.Format("gleich ZZ{0} Eingabe{1}", zuffalszahl, eingabe)
        Else

            ausgabe = String.Format("Größer ZZ{0} Eingabe{1}", zuffalszahl, eingabe)
        End If
        Console.WriteLine(ausgabe)
    End Sub
End Module
