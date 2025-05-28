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

#Region "Méthodes"

        Console.WriteLine("****************** Méthodes:")
        ' Méthode: est un ensemble d'instructions réutilisable
        ' 2 types de méthodes:
        ' Procédure: méthode qui ne renvoie aucun résultat (sub)
        ' Fonction: méthode qui renvoie un résultat (function)

        ' Pour créer une méthode, vous aurez besoin d'un module ou d'une classe.
        ' La notion de module est spécifique à vb

        Afficher()
        Call Afficher()

        'Le mot clé Call n'est pas nécessaire pour appeler une méthode.
        'Call ne s'applique qu'aux procédures

        Dim result = Add(10, 5)

        Console.WriteLine($"résultat = {result}")

        'Dim r2 = Call Add(15,15) -> erreur car Call s'applique qu'aux procédures

        Dim myTab() As Integer = {10, 2, 5, 25, 32}

        Afficher(myTab)

        Print(99) ' la méthode prend en compte les valeurs par défaut de alpha et beta
        Print(77, 11, 42) ' On peut en cas de besoin modifier les valeurs initiales des params optionnels

        Print(55,, 66)

        'Appel d'une méthode avec des paramètres nommés sans tenir compte de leur position dans la méthode

        Print(beta:=44, x:=55, alpha:=66)

        Console.WriteLine(PrixTTC(80))
        Console.WriteLine(PrixTTC(90))
        Console.WriteLine(PrixTTC(120))

        'Les params optionnels, permettent de fournir un code facile à étendre, qui ne nécessite pas bcp
        'de modifications dessus.
        Console.WriteLine(PrixTTC(80, tva:=0.35))


        Dim val1 As Integer = 10, val2 As Integer = 15

        Console.WriteLine($"Avant permutation: val1 = {val1} - val2 = {val2}")

        Permuter(val1, val2)

        Console.WriteLine($"Après permutation: val1 = {val1} - val2 = {val2}")

        Dim monTableau() As Integer = {5, 6}

        ModifierTableau(monTableau)

        Afficher(monTableau)

        Dim produit = 0

        Dim somme1 = Calculs(10, 5, produit)

        Console.WriteLine($"somme = {somme1} - produit = {produit}")

        Console.WriteLine(Soustraction(1, 2))
        Console.WriteLine(Soustraction(1, 2, 3))
        Console.WriteLine(Soustraction(1, 2, 3, 4))

        Dim FuncProduit As Func(Of Integer, Integer, Integer) = Function(a, b) a * b

        Dim AfficherChaine As Action(Of String) = Sub(texte) Console.WriteLine(texte)

        AfficherChaine("Dawan")

        Dim IsPositif As Predicate(Of Integer) = Function(number) number > 0

        'Func: pour les fonctions
        'Action: pour les Sub
        'Predicate: pour les fonctions qui renvoient un boolean

        TestMethode(5, 6, Function(a, b) a * b, Sub(rs) Console.WriteLine(rs))
        TestMethode(5, 6, Function(a, b) a + b, Sub(rs) Console.WriteLine($"somme= {rs} save in file"))
        TestMethode(5, 6, Function(a, b) a - b, Sub(rs) Console.WriteLine(rs))

        Dim t() As Integer = {11, 7}

        Console.WriteLine($"Somme tableau = {SommeTableau(t)}")
        Console.WriteLine($"Moyenne tableau = {MoyenneTableau(t)}")
        Console.WriteLine($"Min tableau = {MinTableau(t)}")

        Console.WriteLine($"min = {t.Min()}")






#End Region

#Region "Exceptions"

        Console.WriteLine("****************** Exceptions")
        ' Il existe 3 types d'erreurs possibles dans un code:
        ' Erreur de compilation: sont détectées automatiquement par l'IDE
        ' Exceptions: sont des erreurs qui provoquent l'arrêt de l'application
        ' Code fonctionnel qui renvoi un résultat -> faire du debuggage

        ' Pour éviter l'arrêt de l'application, l'exception doit être gérée
        ' Pour une exception, on utilise le bloc try/catch

        Dim value = 0
        Dim tb() As Integer = {10, 20}

        ' Il existe plusieurs types d'exceptions, chacune d'elle porte le nom de l'erreur qu'elle génère.
        ' Il existe aussi un type anonyme (type générique) qui est Exception

        Try
            Console.WriteLine(tb(2))
            Console.WriteLine(value \ 0)


        Catch ex As DivideByZeroException
            Console.WriteLine("Exception gérée")
            Console.WriteLine(ex.Message)
            Console.WriteLine(ex.StackTrace)

        Catch ex1 As IndexOutOfRangeException
            Console.WriteLine("Exception du tableau gérée............")
        End Try

        Console.WriteLine(">>>>>>>>>>>>>>>>> Exception générique:")

        Try

            Console.WriteLine(value \ 0)
            Console.WriteLine(tb(2))

        Catch ex1 As Exception
            Console.WriteLine("Exception gérée............")
            Console.WriteLine(ex1.Message)
        End Try

        'Obligation: une ressource (fichiers, base de données.....) doit être libérée à la fin de son utilisation

        'Bonne pratique: prévoir un try/catch lors de la manipulation de ressources

        Try
            ' Ouverture d'un fichier
            Console.WriteLine(value \ 2)
            Console.WriteLine(tb(0))


        Catch ' syntaxe simplifiée de l'utilisation du type générique
            Console.WriteLine(">>> catch générique.....")
        Finally
            'Bloc optionnel qui s'exécute tout le temps: exception ou pas
            Console.WriteLine("*********************** bloc finally")
            ' fermeture du fichier
            ' Ce bloc sert dans la pratique à libérer es ressources utilisées dans le try

        End Try

        Try
            Divide(0)
        Catch ex As Exception
            'Remplir un fichier de logs
            'Remplir une table de logs en BD

        End Try



        Console.WriteLine(">>>> suite du programme..........")

#End Region

#Region "Collections"

        'Les tableaux permettent de gérer un nombre limités d'objets.
        'Les collections de .net, sont des tableaux dynamiques classés par type de stockage:
        ' Stockage tableau:
        ' ArrayList: tableau générique. Peut contenir tout type d'objet
        ' List(of type): tableau qui ne peut contenir qu'un seul type d'objet
        ' Stack (pile): stockage LIFO  Last In First Out
        ' Queue (file): stockage FIFO First In First Out

        ' Stockage cle:valeur
        ' Dictionary:

        Console.WriteLine(">>>>>>>>>>>>> ArrayList:")
        Dim myArrayList As ArrayList = New ArrayList()

        Console.WriteLine($" Taille = {myArrayList.Count}")

        ' Ajouts: Add, Insert, AddRange, InsertRange
        myArrayList.Add(10)
        myArrayList.Add("test") ' index  = 1
        myArrayList.Add(True)

        Dim index_test = myArrayList.IndexOf("test")

        myArrayList.Insert(index_test, 15.5)

        Console.WriteLine($"index de test: {myArrayList.IndexOf("test")}")

        Dim otherArray As New ArrayList()

        otherArray.Add("chaine1") '0
        otherArray.Add("chaine2")

        myArrayList.AddRange(otherArray)

        Console.WriteLine($"Index de chaine1 dans myArrayList: {myArrayList.IndexOf("chaine1")}") '4

        ' Modifications:
        myArrayList(0) = 99

        Console.WriteLine($"Modification index 0: {myArrayList(0)}")

        ' Suppressions:
        Console.WriteLine($"myArrayList contient test ? {myArrayList.Contains("test")}") 'true

        myArrayList.Remove("test")

        Console.WriteLine($"myArrayList contient test après remove ? {myArrayList.Contains("test")}") 'false

        myArrayList.Add(55)
        myArrayList.Add(55)
        myArrayList.Add(55)

        'myArrayList.Remove(55)

        ' Suppression de toutes les occurrences de 55

        'For Each e In myArrayList
        '    If TypeOf (e) Is Integer Then ' ArrayList contient d'autres types d'objets
        '        Dim convert As Integer = CInt(e)
        '        If convert = 55 Then
        '            myArrayList.Remove(convert)
        '        End If

        '    End If
        'Next

        ' Boucle for inversée

        For index = myArrayList.Count - 1 To 0

            If TypeOf (myArrayList(index)) Is Integer Then
                'conversion en Integer
                Dim conv As Integer = CInt(myArrayList(index))
                If conv = 55 Then
                    myArrayList.RemoveAt(index)
                End If
            End If

        Next

        myArrayList.AfficherContenu()

        'For Each e1 In myArrayList
        '    Console.WriteLine(e1)
        'Next

        'Pour définir une méthode d'exyension d'un type de données:
        '1- Créer un module (ArrayListExtension)
        '2- Définir une méthode dont le premier paramètre est du type qu'on souhaite étendre (type complèxe) 
        '3- Ajouter l'annotation <Extension> au dessus de la méthode

        'Enumerator est un objet permettant de faire des itérations sur une collection avec la possibilté
        ' de le positionner dans la collection: MoveNext() - Reset() -> c'est une sorte de curseur 
        ' qui pointe vers les éléments de la collection
        Dim enumerator = myArrayList.GetEnumerator()

        While enumerator.MoveNext()
            Console.WriteLine(enumerator.Current)
        End While

        'Utilisation des Enums définie dans le module: MesEnums

        Dim couleur = Couleurs.ROUGE
        Dim erreur = Erreurs.MINEURE

        Console.WriteLine(">>>>>>>>>>>> List:")

        Dim lst As New List(Of Integer)

        ' On a les même méthodes que celles d'un ArrayList à la seule différence qu'une ne peut contenir
        ' qu'un seul type d'objet

        Console.Write(">>>>>>>>>> Stack (pile):")
        ' Stockage: LIFO -> Last In First Out

        Dim pileGenerique As New Stack() ' tout type d'objets

        pileGenerique.Push(10)
        pileGenerique.Push("test")

        Dim pile As New Stack(Of String) ' 1 seul type d'objet

        pile.Push("chaine1")
        pile.Push("chaine2")
        pile.Push("chaine3")

        Console.WriteLine($"Taille: {pile.Count}")

        Console.WriteLine($"pile contient chaine3 ? {pile.Contains("chaine3")}") 'true

        pile.Pop() ' supprime le dernier élément par défaut

        Console.WriteLine($"pile contient chaine3 après pop ? {pile.Contains("chaine3")}") ' false

        Console.WriteLine($"Prochaine chaine à supprimer: {pile.Peek()}")

        Console.WriteLine(">>>>>>>>> Queue (file d'attente)")
        'Stockage FIFO: First In First Out

        Dim fileGenerique As New Queue() ' tout type d'objets
        Dim file As New Queue(Of Integer)

        'Ajout
        file.Enqueue(10)
        file.Enqueue(20)
        file.Enqueue(30)

        Console.WriteLine($"file contient 10 ? {file.Contains(10)}") ' true

        file.Dequeue()

        Console.WriteLine($"file contient 10 après dequeue ? {file.Contains(10)}") ' false

        Console.WriteLine($"Prochain élément à supprimer: {file.Peek()}")

        Console.WriteLine(">>>>>>>>>>>> Dictionary:")

        ' Un dictionary fonctionne par association clé:valeur

        Dim myDict As New Dictionary(Of String, String)

        myDict.Add("server", "192.168.10.55")
        myDict.Add("port", "8085")
        myDict.Add("user", "admin")
        myDict.Add("password", "@@pwd@@")

        If myDict.ContainsKey("user") Then
            Console.WriteLine(myDict.Item("user"))
        End If

        Console.WriteLine($"Taille: {myDict.Count}")

        Colorer(Couleurs.NOIR)



#End Region





        'Maintenir la console active à l'exécution
        Console.ReadKey()

    End Sub

    ''' <summary>
    ''' Méthode qui génère une exception si le param x = 0
    ''' </summary>
    ''' <param name="x"></param>
    ''' <exception cref="Exception"></exception>
    Sub Divide(x As Integer)
        'Option1: la méthode gère sa propre exception
        'Try
        '    Console.WriteLine(10 \ x)
        'Catch ex As Exception
        '    Console.WriteLine(">> exception gérée par la méthode......")
        'End Try

        'Option2: faire une remontée d'exception - c'est aux appelants de gérer l'eventuelle exception
        If x <> 0 Then
            Console.WriteLine(10 \ x)
        Else
            'Throw: mot clé permettant de déclencher une exception
            Throw New Exception("Attention, tentative de division par 0")
        End If

    End Sub
    Public Enum Couleurs
        BLANC = 10
        NOIR
        JAUNE
        ROUGE
    End Enum

    Public Sub Colorer(couleur As Couleurs)

        Select Case couleur
            Case Couleurs.BLANC
                Console.WriteLine("Blanc..........")

            Case Couleurs.NOIR
                Console.WriteLine("Noir..........")
        End Select

    End Sub


End Module
