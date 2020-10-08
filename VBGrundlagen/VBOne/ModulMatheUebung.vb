'Sub Begruessung()
'Function ZufälligeZahlzwischen0Und10()
'Function RichtigOderFalsch(richtig, falschezahl) As Boolean
'Sub ErgebnisAnzeigen(rechnung als String, eingabe, richtige Ergebnis, richtig / falsch)
' 7 + 3 --- 2 + 4

Module ModulMatheUebung
	Sub main()

		Randomize()

		Dim eingabe As Integer
		Do


			Dim z1 As Integer, z2 As Integer, ergebnis As Integer
			Begruessung()

			z1 = GetRandomNumber(10)
			z2 = GetRandomNumber(10)
			ergebnis = z1 + z2

			Console.WriteLine("Aufgabe {0} + {1} = {2}", z1, z2, "?")

			eingabe = Console.ReadLine()

			Dim isEingabeKorrekt = RichtigOderFalsch(ergebnis, eingabe)

			Ausgabe(z1 & " + " & z2, ergebnis, eingabe, isEingabeKorrekt)
		Loop While eingabe <> -1
		'Loop Until eingabe = -1


	End Sub

	Sub Ausgabe(rechnenaufgabe As String, richtig As Integer, eingabe As Integer, richtigOderFalsch As Boolean)
		Console.WriteLine("Die Aufgabe war {0} " &
						  " Ihre Eingabe {1} Richtig wäre: {2} Ergebnis {3} ",
						  rechnenaufgabe, eingabe, richtig, richtigOderFalsch)

	End Sub
	Sub Begruessung()
		Console.WriteLine("Willkommen zum Mathe-Rätsel")
	End Sub
	Function GetRandomNumber(ByVal upper As Int16) As Int16
		Return CInt(Rnd() * upper) + 1
	End Function

	Function RichtigOderFalsch(richtig As Integer, eingabe As Integer) As Boolean
		Return richtig = eingabe
	End Function
End Module
