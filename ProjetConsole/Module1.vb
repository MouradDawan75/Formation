Imports ProjetDLL

Module Module1

    ' Ceci est un commentaire: ligne de code ignorée à l'exécution
    ' main: est le point d'entrée d'une application console
    ' Les bases d'un langage:
    ' 1- Connaitre la syntaxe
    ' 2- Connaitre les types de données
    ' 3- Savoir faire des contrôles (conditions if/else - select/case)
    ' 4- Savoir gérer les traitements répététifs
    ' 5- Savoir gérer les erreurs
    ' 6- Savoir faire du debuggage
    ' 7- Savoir utiliser les collections

    Sub Main()

        'Appeler la méthode Afficher du projet DLL
        Tools.Afficher()

#Region "Variables et types de données"
        ' Variable: est une zone mémoire contenant une valeur typée 

        'Types de bases (élémentaires - types valeur): possèdent une taille prédéfinie
        'Entiers: byte(1 octet), short(2 octets), integer(4 octets), long(8 octets)
        'Réels: single (4 o), double (8 o), decimal (16 o)
        'Boolean: 1 octet
        'Caractères: 2 octets

        Console.WriteLine("=========================Variables")

        Dim myInt As Integer = 15
        Dim myChar As Char = "A"c ' simple

        Dim s As String = "ceci est une chaine" ' complèxe
        Dim myBool As Boolean = True

        'Convention de nommage des variables:
        ' PascalCase: classes et méthodes
        ' camelCase: myInt: les variables
        ' snake_case: my_int -> convention utilisée par Python  

        'Afficher à a console
        Console.WriteLine(myInt)

        'Lecture à partir de la console
        Console.WriteLine("Votre nom: ")
        Dim nom As String = Console.ReadLine()
        Console.WriteLine(nom)

        'Constante: est une variable dont le contenu ne peut être modifié
        'Convention de nommage: le nom d'une constante est en majuscule
        Const MY_CONSTANTE As Double = 11.5
        ' MY_CONSTANTE = 15.6

        ' Variables nulles: pouvoir mentionner que la variable n'a pas de valeur
        ' Les types simples par définition ne sont pas nullables

        ' ? concerne uniquement les types simples

        Dim x? As Integer = Nothing

        If x.HasValue Then
            Console.WriteLine(x)
        Else
            Console.WriteLine("x est nulle")
        End If

        ' Générer des nombres aléatoires
        Dim r As Random = New Random()
        Dim i = r.Next(1, 100)

        Console.WriteLine(i)


        'Types complèxes (types réferences): leur taille est variable -> chaine de caractères, tableau, dates, classes et objets

#End Region

#Region "Conversions de types"

        Console.WriteLine("=========================Conversions de types")

        'Conversion implicite: concerne le passage d'un inférieur à un type supérieur

        Dim myByte As Byte = 15
        Dim myInt2 As Integer = myByte


        'Conversion explicite: pour faire des conversions explicites:

        ' Option1: utiliser le cast

        Dim myInt3 As Integer = 255
        Dim myByte3 As Byte = CByte(myInt3)

        'CInt, CDouble........

        Console.WriteLine(myByte3)

        ' Option 2: utiliser la classe Convert
        Dim myByte4 As Byte = Convert.ToByte(myInt3)

        Dim chaine As String = "55xxx"

        ' fonction isNumeric
        Dim resultat = IsNumeric(chaine)

        If resultat = True Then
            Dim z As Integer = CInt(chaine)
            Console.WriteLine(z)
        Else
            Console.WriteLine("La chaine n'est pas numérique")

        End If

        'Fonction CType
        Dim y = CType("25", Integer)
        Console.WriteLine(y)

        Console.WriteLine("Premier nombre: ")

        Dim nb1 As Double = CDbl(Console.ReadLine())

        Console.WriteLine("Second nombre: ")

        Dim nb2 As Double = CDbl(Console.ReadLine())

        Dim somme = nb1 + nb2

        Console.WriteLine("Somme = " & somme) 'concaténation




#End Region

#Region "Formattage de chaines"
        Console.WriteLine("=========================Formattage de chaines")
        Dim age As Integer = 30
        Dim prenom As String = "Jean"

        'Concaténation:
        Console.WriteLine("Prénom: " & prenom & " Age: " & age)

        'Interpolation:

        'v1:
        Console.WriteLine("Prénom: {0} Age: {1}", prenom, age)

        'v2: syntaxe simplifiée de la v1:
        'entre accolades: on peut soit insérer des variables, soit des expressions
        'Une expression est un traitement qui renvoi un résultat: calcul, appel d'une fonction...ect
        Console.WriteLine($"Prénom: {prenom} Age: {age}")
        Console.WriteLine($"exemple d'une expression: {5 * 6}")
        Console.WriteLine($"55x est une chaine numérique: {IsNumeric("55x")}")


#End Region

#Region "Les opérateurs"

        Console.WriteLine("******** Arithmétiques:")
        ' +,-,*,/ (\ division entière), Mod (reste de la division entière), ^(puissance)

        Console.WriteLine("****** De comparaison:")
        ' >,>=,<,<=,=,<>: renvient un boolean

        Console.WriteLine("******* Opérateurs combinés:")
        '+=, -=, *=, /=
        Dim c As Integer = 5

        c += 2 'syntaxe simplifiée de: c = c + 2

        Console.WriteLine("************* Logiques:")
        ' and,or,not,xor,andalso,orelse: renvoient un boolean
        'Table logique:
        ' A  B   A and B  A or B    A xor B
        ' v  v      v       v          f
        ' v  f      f       v          v
        ' f  f      f       f          f

        '********* andalso: il dit False quand la condition qui le précède
        ' est False, puis sinon True si les 2 sont True, sinon False
        ' Cet ordre s'appelle un circuit court logique.
        ' Fonctionne comme le and sauf qu'il économise du temps. 
        ' A     B       A andalso B
        ' f     -           f

        '********** orelse: est le circuit court logique de Or: : si le premier opérande est True, il renvoie True
        ' sans vérifier le second opérande

        ' A     B       A orelse B
        ' v     -           v


#End Region

#Region "Conditions"
        Console.WriteLine("=========================Conditions")
        'if/else

        If myInt > 0 Then
            Console.WriteLine("Positif")
        ElseIf myInt < 0 Then
            Console.WriteLine("Négatif")
        Else
            Console.WriteLine("Egale 0")

        End If

        'select/case
        Dim note As Integer = 5

        Select Case note
            Case 1 To 5
                Console.WriteLine("Notre entre 1 et 5")

            Case 6, 7, 8
                Console.WriteLine("Note égale à 6, 7 ou 8")

            Case 9, 10
                Console.WriteLine("Note égale 9 ou 10")

                'pour les autres cas:
            Case Else
                Console.WriteLine("Note non comprise entre 1 et 10")
        End Select

#End Region

#Region "Boucles"

        Console.WriteLine("=========================Boucles")

        'for: si le nombre d'itérations est connu d'avance
        'for each: permet de parcourir tous les éléments d'une collection
        'whie - do loop while - do loop until: si le nombre d'itérations n'est pas connu
        'et que le traitement répététif dépend d'une condition

        'Affichez hello 5 fois: nombre d'itérations connu
        'for:
        For index = 1 To 5
            Console.WriteLine("Hello")
        Next

        'while:
        Dim compteur As Integer = 0
        While compteur < 5
            Console.WriteLine("Hello")
            compteur += 1
        End While

        'Demandez la saisie d'un nombre compris entre 1 et 10.
        'Tant que le nombre saisi n'est pas valide, redemandez la saisie d'un autre

        'Boucle infinie avec un Exit
        While True
            Console.WriteLine("Un nombre entre 1 et 10:")
            Dim nb As Integer = CInt(Console.ReadLine())
            If nb >= 1 And nb <= 10 Then
                Exit While
            End If
        End While

        Dim v = 1

        Do
            Console.WriteLine(v)
            v += 1
        Loop While v < 5 ' fais tant que (condition est vraie)

        Do
            Console.WriteLine(v)
            v += 1
        Loop Until v > 10 ' fais jusqu'à 

        'La boucle Do s'exécute au moins une fois

        'for each:

        Dim entiers As Integer() = {10, 20, 30}

        For Each element As Integer In entiers
            Console.WriteLine(element)
        Next

        ' Exit Continue:

        Dim nombres As Integer() = {1, 2, 3, 4, 5, 6}

        For Each e In nombres

            If e Mod 2 = 0 Then
                Continue For ' continue force le passage à 'itération suivante -> le reste de la boucle n'est oas exécuté
            End If

            If e = 5 Then
                Exit For
            End If

            Console.WriteLine(e) '1 3
        Next


#End Region

#Region "Tableaux statiques"

        Console.WriteLine("****************** Tableaux statiques:")

        '1 dimension

        Dim tab(2) As Integer 'tableau de 3 cases - index commence à 0
        tab(0) = 10
        tab(1) = 20
        tab(2) = 30

        'Autre façon de déclarer un tableau: si le contenu est connu d'avance
        Dim tab2() As Integer = {10, 20, 30}

        'On peut redimensionner un tableau statique en preservabt son contenu
        ReDim Preserve tab2(4) ' tableau de 5 cases
        tab2(3) = 40
        tab2(4) = 50

        Dim taille As Integer = tab2.Length

        Console.WriteLine($"Taille = {taille}")

        For Each el In tab2
            Console.WriteLine(el)
        Next

        ' 2 dimensions
        Dim matrice(,) As Double = {{10.5, 11.6}, {12.7, 13.8}}
        Dim nbLignes As Integer = matrice.GetLength(0)
        Dim nbCoonnes As Integer = matrice.GetLength(1)


        Dim matrice2(2, 3) As Double ' si le contenu n'est pas connu d'avance -> la taille est obligatoire

        matrice2(0, 0) = 10
        matrice2(0, 1) = 10
        matrice2(0, 2) = 10

        ' plusieurs dimensions
        Dim cube(4, 4, 4) As Integer


#End Region


        'Maintenir la console active à l'exécution
        Console.ReadKey()

    End Sub

End Module
