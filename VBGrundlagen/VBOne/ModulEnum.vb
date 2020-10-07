Module ModulEnum

    Enum Wochentag As Integer
        Montag = 12
        Dienstag = 23
        Mittwoch
        Donerstag
        Freitag
        Samstag
        Sonntag
    End Enum
    Sub main()
        Dim geburtsTag As Wochentag
        geburtsTag = Wochentag.Mittwoch
        geburtsTag = Wochentag.Donerstag
        Console.WriteLine(geburtsTag)

        geburtsTag = 5
        Console.WriteLine(geburtsTag)

        Dim eingabe As String = "Mittwoch"

        Dim erg As Wochentag
        erg = [Enum].Parse(geburtsTag.GetType(), eingabe)

        Dim werte() As String

        werte = [Enum].GetNames(GetType(Wochentag))

        For Each i As String In werte
            Console.WriteLine(i)
        Next


    End Sub
End Module
