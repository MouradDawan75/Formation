Public Module MyMethods

    Public Sub Test()
        Console.WriteLine("Méthode test du module du projet DLL")
    End Sub

    Public Function SommePositive(x As Integer, y As Integer) As Integer
        If IsPositif(x) And IsPositif(y) Then
            Return x + y
        Else
            Return 0

        End If
    End Function

    Private Function IsPositif(x As Integer) As Boolean
        Return x > 0
    End Function

End Module
