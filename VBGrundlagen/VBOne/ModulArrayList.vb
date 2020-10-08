Module ModulArrayList

    Sub main()
        Dim mitarbeiterListe As New ArrayList

        mitarbeiterListe.Add("Johann")
        mitarbeiterListe.Add("Ivan")
        mitarbeiterListe.Insert(1, "David")
        mitarbeiterListe.Add(12)
        mitarbeiterListe.Add(True)

        Dim salmons As New List(Of String)
        salmons.Add("chinook")
        salmons.Add("coho")
        salmons.Add("pink")
        salmons.Add("sockeye")

        salmons.Add(12)

    End Sub

End Module
