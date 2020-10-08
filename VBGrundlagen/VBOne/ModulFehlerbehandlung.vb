Imports System.IO




Module ModulFehlerbehandlung

    Sub main()
        Dim f1 As String

        f1 = "c:\lvs\Andritz.txt"
        f1 = "c:\uebung\andritz.txt"

        Try

            Throw New MaschineUeberhitztException

        Catch ex As MaschineUeberhitztException
            Console.WriteLine(ex.Message)
        Catch ex As DivideByZeroException
        End Try



        Try
            FileCreate(f1)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Try
            Throw New OutOfMemoryException
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


    End Sub


    Sub FileCreate(filename As String)

        Dim konnteErstelltWerden As Boolean = True
        Dim success As Boolean = False
        Dim counter As Integer = 1
        Do
            counter += 1
            Try
                File.Create(filename)
                success = True
            Catch ex As DirectoryNotFoundException
                Console.WriteLine("Ordner nciht vorhanden")
                filename = "c:\tempx\andritz.txt"
                If counter = 3 Then
                    Throw
                End If
            Finally
                If success = True Then
                    Console.WriteLine("Wird immer ausgeführt - z.B Datenbank schliessen")
                End If
            End Try

        Loop While success = False AndAlso counter <= 3

        Console.WriteLine("Db schliessen")


    End Sub
End Module
