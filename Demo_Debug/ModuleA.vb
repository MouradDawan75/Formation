Module ModuleA

    Public Sub MethodeA(ByRef x As Integer)
        x = 123

        For index = 0 To 200
            x += 1
        Next
        MethodeB(x)
    End Sub

End Module
