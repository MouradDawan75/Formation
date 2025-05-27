Module MesMethodes

    'Syntaxe pour déclarer une méthode:
    ' Visibilité (Public-Private) Sub-Function NomMethode(paramètres) as Type_Résultat_Si_Function

    'Exemple d'une procédure
    Public Sub Afficher()
        Console.WriteLine("méthode affichier............")
    End Sub


    Public Sub Afficher(t As Integer())
        For Each e In t
            Console.WriteLine(e)
        Next
    End Sub

    'Exemple d'une fonction


    ''' <summary>
    ''' Fonction qui renvoie la somme de 2 entiers
    ''' </summary>
    ''' <param name="x">est un entier</param>
    ''' <param name="y">est un entier</param>
    ''' <returns>renvoie somme de x et y</returns>

    Public Function Add(x As Integer, y As Integer) As Integer
        Return x + y
    End Function

    'Surcharge de méthode (overload): c'est pouvoir définir la méthode méthde, dans le mm module en modifiant
    'la liste des paramètres soit en type, soit en nombre

    Public Function Add(x As Integer, y As Integer, z As Integer) As Integer
        Return x + y + z
    End Function
    Public Function Add(x As Double, y As Double) As Double
        Return x + y
    End Function

    'Méthode avec des params optionnels
    ' Les params optionnels possèdent une valeur intiale et sont définis à la suite des params obligatoires

    Public Sub Print(x As Integer, Optional alpha As Integer = 10, Optional beta As Integer = 15)
        Console.WriteLine($"x = {x} - Alpha = {alpha} - Beta = {beta}")
    End Sub

    Public Function PrixTTC(prixHT As Double, Optional tva As Double = 0.2) As Double
        Return prixHT * (1 + tva)
    End Function

    'Passage de paramètres par réference: ByRef ne concerne que les types simples. Car les types complèxes, 
    'par définition sont des types réference.
    Public Sub Permuter(ByRef x As Integer, ByRef y As Integer)
        Dim tmp = x
        x = y
        y = tmp
    End Sub

    Public Sub ModifierTableau(t As Integer())
        t(0) = 100
    End Sub

    ' On peut aussi utiliser ByRef pour des paramètres en sortie d'une méthode

    Public Function Calculs(x As Integer, y As Integer, ByRef prod As Integer) As Integer
        Dim somme = x + y
        prod = x * y
        Return somme
        'Return produit
    End Function

    'Public Function Soustraction(x As Integer, y As Integer) As Integer
    '    Return x - y
    'End Function

    'Public Function Soustraction(x As Integer, y As Integer, z As Integer) As Integer
    '    Return x - y - z
    'End Function

    'ParamArray: permet de définir une méthode avec un nombre variable de params
    Public Function Soustraction(ParamArray t As Integer()) As Integer

        Dim r = t(0)
        For index = 1 To t.Length - 1
            r -= t(index) ' r = r - t(index)
        Next

        Return r

    End Function

    'Méthode récursive
    Public Function Factoriel(x As Integer) As Integer
        If x = 0 Then
            Return 1
        Else
            Return x * Factoriel(x - 1)
        End If
    End Function

    'Méthode qui prend en param d'autres méthodes

    Public Sub TestMethode(x As Integer, y As Integer, traitement As Func(Of Integer, Integer, Integer), print As Action(Of Integer))
        Dim r = traitement(x, y)
        print(r)
    End Sub

    'Méthode qui renvoie la somme des éléments d'un tableau d'entiers

    Public Function SommeTableau(tab As Integer()) As Integer

        Dim resultat = 0

        For Each e In tab
            resultat += e
        Next


        Return resultat

    End Function

    'Méthode qui renvoie la moyenne des éléments d'un tableau d'entiers

    Public Function MoyenneTableau(tab As Integer()) As Double
        Return SommeTableau(tab) / tab.Length
    End Function

    'Méthode qui renvoie l'élément le plus petit d'un tableau d'entiers

    Public Function MinTableau(tab As Integer()) As Integer
        Dim min = Integer.MaxValue

        For Each e In tab
            If e < min Then
                min = e
            End If
        Next

        Return min
    End Function

End Module
