Module ModulOOPGrundlungen

    Class Person
        Public vorname As String 'Eigenschaf

        Private nachname As String

        'Constructor 
        Public Sub New()
            nachname = "unbekannt"
        End Sub

        Public Sub New(v As String, n As String)
            nachname = n
            vorname = v
        End Sub

        'Funktionalität
        Public Sub SayHello()
            Console.WriteLine("Hello {0}", vorname)
        End Sub

        Public Sub setVorname(v As String)
            vorname = v
        End Sub

        Public Sub setNachname(n As String)
            nachname = n
        End Sub

        Public Function getNachname() As String
            Return nachname
        End Function
    End Class

    Sub main()

        'P1 ist eine Objektvariable
        Dim p1 As New Person 'Erstellt eine konkrete Instanz vom Typ Person, Objekt

        Dim p2 As New Person("Ivan", "Stanojevic")
        p2.setVorname("Ivan")
        p2.vorname = "Ivan"
        'p2.nachname = "Stanojevic"
        p2.setNachname("Stanojevic") 'Encapsulation -- keine Zugriff auf Private Members

        p1.vorname = "David"
        p1.SayHello()

        With p1 'verkürzte Schreibweise 
            .vorname = "Helmut"
            .SayHello()
        End With

        Dim personen As New List(Of Person)

        personen.Add(p1)
        personen.Add(p2)

        For Each p As Person In personen
            Console.WriteLine("{0} {1}", p.vorname, p.getNachname())
        Next

        Dim meineMitarbeiter(1) As Person
        meineMitarbeiter(0) = p1
        meineMitarbeiter(1) = p2

        Dim m As Maschine
        m.Bezeichnung = ""
        m.Typ = ""
        m.gewicht = 12

        m.Start()
        m.BerechneWatt()



    End Sub
    Class Maschine
        Public bezeichnung As String
        Public typ As String
        Public gewicht As Double
        Sub start()

        End Sub
        Function BerechneWatt() As Double
            Return 0
        End Function
    End Class



End Module
