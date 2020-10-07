Module ModulKontrollfluss

    Sub Main()


        Dim note As Int16 = 2
        Dim ausgabe As String

        If note < 3 Then
            ausgabe = "Absolut OK und toll"
        ElseIf note = 3 Then
            ausgabe = "Ok"
        ElseIf note = 4 Then
            ausgabe = " Noch OK"
        Else
            ausgabe = "nicht mehr ok"
        End If

        Select Case note
            Case 1, 2
                ausgabe = "Absolut OK"
            Case 3
                ausgabe = "OK"
            Case 4
                ausgabe = "noch ok"
            Case 5
                ausgabe = "nicht ork"

            Case Else
                ausgabe = "keine gültige note"
        End Select


        Console.WriteLine(ausgabe)

    End Sub

End Module
