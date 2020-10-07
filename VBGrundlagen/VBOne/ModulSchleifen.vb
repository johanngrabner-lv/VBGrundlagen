Module ModulSchleifen
    Sub main()
        Dim eingabe As String

        Do
            Console.WriteLine("Herzlich Willkommen")
            eingabe = Console.ReadLine()

        Loop Until eingabe = "Ende"
        'Loop while eingabe <> "Ende"
    End Sub

End Module
