Module ModulDivisionDurchNullFehler
    Sub main()
        Division()
    End Sub

    Sub Division()
        Dim z1 As Integer, z2 As Integer
        Dim d As Integer

        Console.WriteLine("Bitt1 Zahl 1 und 2 eingeben")


        Try
            z1 = Console.ReadLine()
            z2 = Console.ReadLine()
            d = z1 / z2
        Catch eingabfehler As InvalidCastException

        Catch ex As DivideByZeroException
            Throw
        Catch ex As Exception

        Finally

        End Try


        Console.WriteLine("Ergebnis {0}", d)
    End Sub

End Module
