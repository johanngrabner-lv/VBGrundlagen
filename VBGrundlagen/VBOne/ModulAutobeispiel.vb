'dim a1 as new Auto()
'a1.Farbe = "Grau"
'a1.AktuelleGeschwindigkeite=20
'a1.GasGeben()
'a1.Bremsen()
'a1.PrintInfo() -- Das Auto ist Grau und fährt aktuell 17 kmH
'14:30 Uhr Auflösung

Imports System.Data.SqlClient

Module ModulAutobeispiel
    Sub MainOld()

        Dim a1 As New Auto

        'Properties Schutz vor Aussen, Encapsulation
        a1.Farbe = "Red"
        ' a1.AktuellerSpeed = 20 -- nicht möglich, da readonly


        Dim eingabe As ConsoleKeyInfo
        eingabe = Console.ReadKey()

        If eingabe.KeyChar = "+" Then
            a1.GasGeben()
        Else
            a1.Bremsen()
        End If

        a1.PrintInfo()

        '<Vorname>Helmut</Vorname>
        '{"Vorname":"Helmut"}

        Dim am As New Amphibienfahrzeug
        am.Tauchtiefe = 120
        am.Tauchen()
        am.PrintInfo() 'Polymorpher Aufruf - Polymorphismus

        Dim a2 As Auto
        a2 = am 'UpCast -- Konvertieren in Basis-Klasse 


        Dim a3 As Amphibienfahrzeug
        a3 = am 'nicht jedes Auto ist ein Amphibienfahrzeug - Downcast

        Dim l As New List(Of Auto)
        l.Add(a1)
        l.Add(am)

        For Each auto As Auto In l
            auto.PrintInfo() 'Polymorphismus
        Next

        For Each auto In l
            auto.PrintInfo() 'Polymorphismus
        Next

        Dim zahlen(2) As Int16
        zahlen(0) = 12
        zahlen(1) = 20
        For Each z As Integer In zahlen
            Console.WriteLine(z)
        Next



    End Sub

    Sub Main()
        Dim a As New Auto
        a.Farbe = "Grau"
        Dim p As New Person()

        Dim listeDruckebareObjekte As New List(Of IDruckbar)
        listeDruckebareObjekte.Add(a)
        listeDruckebareObjekte.Add(p)

        For Each d In listeDruckebareObjekte
            d.Drucken()
        Next

        Dim listeXML As New List(Of IXMLSerializable)
        listeXML.Add(a)
        listeXML.Add(p)

        For Each d In listeXML
            d.ToXML()
        Next

        Dim verbindung As New SqlConnection()
        verbindung.Open()
        verbindung.CreateCommand()



    End Sub

    'Spezialisierung
    Class Amphibienfahrzeug
        Inherits Auto ', Boot Mehrfachvererbung nur in C++

        Private pTauchtife As Double
        Public Property Tauchtiefe() As Double
            Get
                Return pTauchtife
            End Get
            Set(ByVal value As Double)
                pTauchtife = value
            End Set
        End Property

        Sub Tauchen()
            Tauchtiefe -= 1
        End Sub

        Public Overrides Sub PrintInfo()
            Console.WriteLine("Tauchtiefe {0}", Tauchtiefe)
        End Sub
    End Class

    Class AmpUltra
        Inherits Amphibienfahrzeug 'Multilevel

    End Class

    Class Druckbar
        Overridable Sub Drucken()

        End Sub

    End Class

    Class Persistenz
        Overridable Sub Speichern()

        End Sub
    End Class

    Interface IDruckbar
        Sub Drucken()

    End Interface

    Interface IXMLSerializable
        Sub ToXML()

    End Interface
    Class Person
        'Inherits Druckbar
        Implements IDruckbar, IXMLSerializable

        Public Sub Drucken() Implements IDruckbar.Drucken
            Console.WriteLine("Drucken von Person")
        End Sub

        Public Sub ToXML() Implements IXMLSerializable.ToXML
            Throw New NotImplementedException()
        End Sub
    End Class

    Class Auto
        'Inherits Druckbar
        Implements IDruckbar, IXMLSerializable
        'Public Felder / Fields
        ' Public Farbe As String
        ' Public AktuellerSpeed As Double

        'Encapsulation --> Properties -- Getter / Setter 

        Sub WechselFarbePerZufall()
            Farbe = "Grün"
            'pFarbe= "Grün"
        End Sub
        Private pFarbe As String
        Public Property Farbe() As String
            Get
                Return pFarbe
            End Get
            Set(ByVal value As String)
                If value <> "Red" AndAlso value <> "Green" Then
                    Throw New Exception("Farbe nicht gültig")
                End If
                pFarbe = value
            End Set
        End Property

        Private pAktuellerSpeed As Double
        Public ReadOnly Property AktuellerSpeed() As Double
            Get
                Return pAktuellerSpeed
            End Get

        End Property

        Public Sub GasGeben()
            pAktuellerSpeed += 5
        End Sub
        Public Sub Bremsen()
            pAktuellerSpeed -= 7
        End Sub


        Overridable Sub PrintInfo()
            Console.WriteLine("Das Auto ist {0} fährt aktuell {1}", Farbe, AktuellerSpeed)
        End Sub

        Public Sub Drucken() Implements IDruckbar.Drucken
            Console.WriteLine("auto")
        End Sub

        Public Sub ToXML() Implements IXMLSerializable.ToXML
            Throw New NotImplementedException()
        End Sub
    End Class



End Module
