Imports System.Runtime.CompilerServices

Module ArrayListExtension

    'Le premier paramètre doit être du type à étendre

    <Extension>
    Public Sub Replace(tab As ArrayList, index As Integer, value As Object)
        tab(index) = value
    End Sub

    <Extension>
    Public Sub AfficherContenu(tab As ArrayList)
        For Each e In tab
            Console.WriteLine(e)
        Next
    End Sub

End Module
