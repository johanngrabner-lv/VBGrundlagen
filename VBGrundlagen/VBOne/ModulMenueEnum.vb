'1.) Enum 3 Varianten: Vegetarisch, Fleisch, FuenfSinne
'2.) Ausgabe der möglichen Variante: Es steht zur Auswahl: Vegetarisch, .... - GetNames, for each
'3.) Eingabe welches wollen Sie --> Enum.Parse(GetType(MenueEnum),eingabe)
'4.) Vegetarich = 5 euro, Fleisch = 7, FuenfSinne = 10 Euro (if, select case )

Module ModulMenueEnum

    Enum MenueVariante
        Vegetarisch = 0
        Fleisch = 1
        FuenfSinne = 2
    End Enum
    Sub main()
        Dim eingabe As String
        Dim eingabeAsMenueEnum As MenueVariante

        Console.WriteLine("Bitte wählen Sie aus folgenden Menüs aus")
        For Each i As String In [Enum].GetNames(GetType(MenueVariante))
            Console.WriteLine(i)
        Next

        eingabe = Console.ReadLine()

        eingabeAsMenueEnum = [Enum].Parse(GetType(MenueVariante), eingabe)

        Dim price As Decimal

        Select Case eingabeAsMenueEnum
            Case 0
                price = 5
            Case MenueVariante.Fleisch
                price = 7
            Case MenueVariante.FuenfSinne
                price = 12
        End Select

        Console.WriteLine("Sie haben gewählt {0} {2}  der Preis ist {1:0.00}", eingabeAsMenueEnum,
                          price, CInt(eingabeAsMenueEnum))




    End Sub
End Module
