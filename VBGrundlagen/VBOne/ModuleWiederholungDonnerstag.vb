
Module ModuleWiederholungDonnerstag
	'Access Modifier - Zugriff
	Public Oeffentlich As String
	Private PrivateVariable As String
	Public Const Pi As Decimal = 3.14 'Literal --> Fix

	Sub Main()

		Dim i As Integer 'Local Scope
		Dim i2 As Int32

		Dim s As Short
		Dim s1 As Int16 'CTS -- Common Type System

		If i > 10 Then
			Dim l As Long
			l = 20
		End If
		Demo(i)

	End Sub

	Sub Demo(eineZahl As Integer)
		Select Case eineZahl
			Case 1
			Case 2
			Case 3
			Case Else

		End Select

		If eineZahl < 10 Then
		ElseIf eineZahl < 100 Then
		Else

		End If

		'nachprüfend
		Do

		Loop While eineZahl < 100

		'Vorprüfende Schleife
		While eineZahl < 100

		End While


		For i As Int16 = -10 To 10 Step +2

		Next i

		Dim zz As Int16

		zz = GetRandomNumber(100)
		zz = GetRandomNumber()
		zz = GetRandomNumber(5, 200)
	End Sub

	Function GetRandomNumber() As Int16
		Return GetRandomNumber(9)
	End Function

	'overload - überladung
	Function GetRandomNumber(upper As Int16) As Int16
		Return CInt(Rnd() * upper) + 1
	End Function

	Function GetRandomNumber(lower As Int16, upper As Int16) As Int16
		Return GetRandomNumber(upper) + lower
	End Function



End Module
