Module Enum_month
    Enum Monthname 'Enumeration name  
        January = 1
        February
        march
        April
        May
        June
        July
        August
        September = 10 'Set value to 10  
        October
        November
        December
    End Enum
    Sub Main()
        Dim x As Integer = CInt(Monthname.June)
        Dim y As Integer = CInt(Monthname.August)
        Dim p As Integer = CInt(Monthname.September)
        Dim q As Integer = CInt(Monthname.October)
        Dim r As Integer = CInt(Monthname.December)

        Console.WriteLine(" Month name is {0}", Monthname.January)
        Console.WriteLine(" Index number is  " & Monthname.January)
        Console.WriteLine(" June Month name is in {0}", x & " Position")
        Console.WriteLine(" August Month name is in {0}", y & vbCrLf & "Position")

        Console.WriteLine(" After Setting a new value at the middle")
        Console.WriteLine(" September Month name is {0}", p & " Position")
        Console.WriteLine(" October Month name is {0}", q & " Position")
        Console.WriteLine(" December Month name is {0}", r & " Position")
        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()

    End Sub
End Module