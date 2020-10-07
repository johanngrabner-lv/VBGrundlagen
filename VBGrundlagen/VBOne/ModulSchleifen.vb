Module ModulSchleifen
    Sub main()
        Dim eingabe As Integer
        Dim zuffalszahl As Single
        Randomize() 'initialisierung des Zufallszahlengenerators mit Systemzeit
        Dim counter As Int16
        Dim nocheinmal As String

        If 1 = 1 Then
            Dim i As Int16 'nur sichtbar in Then-Block
        End If
        Dim upperBound As Integer = 10

        Do
            counter = 0
            zuffalszahl = Int(Rnd() * upperBound - 1) + 1 ' cast to int + 1 ,, 1...10

            Do
                counter += 1
                Dim ausgabe As String

                Console.WriteLine("bitte geben Sie Ihren {0}. Tipp ab", counter)
                eingabe = CInt(Console.ReadLine())
                ausgabe = CalcAusgabe(eingabe, zuffalszahl)

                Console.WriteLine(ausgabe)
            Loop While eingabe <> zuffalszahl AndAlso counter < 5

            CalcErratenOderNicht(eingabe, zuffalszahl, counter)
            Console.WriteLine("Wollen Sie noch einen Versuch")
            nocheinmal = Console.ReadLine()
        Loop While nocheinmal = "Ja"


    End Sub

    Private Sub CalcErratenOderNicht(eingabe As Integer, zuffalszahl As Single, counter As Short)
        If counter = 5 AndAlso eingabe <> zuffalszahl Then
            Console.WriteLine("Sie haben es nicht geschafft")
        Else

            Console.WriteLine("sie haben insgesamt {0} Versuche benötigt", counter)
        End If
    End Sub

    Private Function CalcAusgabe(eingabe As Integer, zuffalszahl As Single) As String
        Dim ausgabe As String

        If eingabe < zuffalszahl Then
            ausgabe = String.Format("Kleiner ZZ{0} Eingabe{1}", zuffalszahl, eingabe)
        ElseIf eingabe = zuffalszahl Then
            ausgabe = String.Format("gleich ZZ{0} Eingabe{1}", zuffalszahl, eingabe)
        Else

            ausgabe = String.Format("Größer ZZ{0} Eingabe{1}", zuffalszahl, eingabe)
        End If

        Return ausgabe
    End Function
End Module
