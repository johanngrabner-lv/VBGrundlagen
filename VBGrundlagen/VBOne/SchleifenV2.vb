

Module SchleifenV2
    Sub main()

        Console.BackgroundColor = ConsoleColor.Red
        'int i=12 --> C#
        'Int32 i = 12 --> vb.net

        '-2Mrd
        Dim i1 As Integer
        Dim i2 As Int32

        '-32000 ...
        Dim i3 As Int16
        Dim i4 As Short

        '
        Dim i5 As Int64
        Dim i6 As Long



        Dim counter As Int16 = 0
        Dim index As Int16
        While counter < 10
            Console.WriteLine(counter)
            counter += 1
        End While

        For index = 1 To 9 Step 3
            Console.WriteLine(index)
        Next

        For i As Integer = 10 To 0 Step -2

            If i = 10 Then
                Continue For
            End If

            Console.WriteLine(i)
            If i = 8 Then
                Exit For
            End If
        Next
        Console.WriteLine(counter)
        Console.WriteLine(index)

    End Sub

End Module
