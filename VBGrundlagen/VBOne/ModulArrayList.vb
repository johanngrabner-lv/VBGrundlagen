Module ModulArrayList

    Class Person

    End Class
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

        Dim kunden As New Dictionary(Of Integer, String)
        kunden.Add(12, "Johann")
        kunden.Add(7, "David")



        Dim personen As New Dictionary(Of Integer, Person)

    End Sub

End Module
