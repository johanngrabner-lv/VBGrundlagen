Module ModulWiederholung
    'Hier werden die Grundlagen behandelt
    '07.10.2020

    'überall sichtbar und nicht veränderbar
    Public Const rabattsatz As Decimal = 0.05
    Sub Main() 'Einstiegspunkt
        'Const rabattsatz As Decimal = 0.05 - lokale Variable
        ' Public x As Integer - syntaktisch nicht möglich
        Console.BackgroundColor = ConsoleColor.Blue
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Herzlich Willkommen")
        Console.WriteLine("Hier werden die Grundlagen " &
            "von {0} behandelt, Frameworkversion {1} ",
                          "VB.NET",
                           "4.6.1")
        'Aufruf der Sub WiederholungVariablen
        WiederholungVariablen()
        Console.ReadKey()

    End Sub

    'Wiederverwendbarer Codeteil, ohne Rückgabewert
    'es könnte Übergabeparameter geben
    'Procedure / OOP --> Method
    Sub WiederholungVariablen()
        Dim produktbezeichnung As String = "unbekannt"
        Dim preis As Decimal, ustSatz As Decimal, brutto As Decimal
        Dim rabattierterBetrag As Decimal
        Dim isGwg As Boolean
        Dim ausgabe As String
        Console.WriteLine("Bitte geben Sie die Produktbezeichnung ein")
        produktbezeichnung = Console.ReadLine()

        Console.WriteLine("Bitte geben Sie den Preis ein")
        preis = CDec(Console.ReadLine())
        ' preis = Console.ReadLine() -- wäre auch möglich, implizierte Konvertierung
        '12.5 ----> "12.5"

        Console.WriteLine("Bitte geben Sie den Ust-Satz ein")
        ustSatz = CDec(Console.ReadLine())

        brutto = CalculateBrutto(preis, ustSatz)

        isGwg = checkIfisGwg(produktbezeichnung, preis)

        rabattierterBetrag = CalcRabattierterBetrag(brutto)
        ausgabe = CalcAusgabe(produktbezeichnung, brutto, rabattierterBetrag, isGwg)

        Console.WriteLine(ausgabe)
    End Sub

    Private Function CalcRabattierterBetrag(brutto As Decimal) As Decimal
        Return brutto * (1 - rabattsatz)
    End Function

    Private Function CalcAusgabe(produktbezeichnung As String, brutto As Decimal, rabattierterBetrag As Decimal, isGwg As Boolean) As String
        Return String.Format("Das Produkt {0} hat einen Bruttopreis von " &
                                        "{1} und die Eigenscheift gwg ist {2} " &
                                        " Rabattiert {3} ",
                        produktbezeichnung, brutto, isGwg, rabattierterBetrag)
    End Function

    Private Function checkIfisGwg(produktbezeichnung As String, preis As Decimal) As Boolean
        Return preis < 400 AndAlso produktbezeichnung = "gwg"
    End Function

    Private Function CalculateBrutto(preis As Decimal, ustSatz As Decimal) As Decimal
        Return preis * (1 + ustSatz / 100)
    End Function

    ''' <summary>
    ''' Das ist eine Demoberechnung
    ''' </summary>
    ''' <param name="i">bitte den Wert eingeben</param>
    Sub Berechne(i As Int16)

    End Sub


End Module
