Module Module1

    Sub Main()

        Dim choix As String = ""
        Dim nb1 As Double = 0
        Dim nb2 As Double = 0
        Dim v1 As String = ""
        Dim v2 As String = ""

        While True

            'Affichage d'un menu

            Console.WriteLine(">>>>>>>>>>>>> Calculatrice <<<<<<<<<<<<<")
            Console.WriteLine("- Addition: tapez a")
            Console.WriteLine("- Soustraction: tapez s")
            Console.WriteLine("- Multiplication: tapez m")
            Console.WriteLine("- Division: tapez d")
            Console.WriteLine("- Quitter: tapez q")

            ' Tant que le choix est différent de q: le menu s'affiche (l'application continue son exécution)
            ' Tant que le choix saisi n'est pas valide, redemandez la saisie d'un autre

            Console.WriteLine("Votre choix: ")

            choix = Console.ReadLine()

            If choix = "q" Then
                Console.WriteLine("Fin du programme...........")
                Exit While
            End If

            'Gestion d'un choix saisi invalide
            While Not (choix = "a" Or choix = "s" Or choix = "m" Or choix = "d")
                Console.WriteLine("Choix invalide.........")
                Console.WriteLine("Autre choix: ")
                choix = Console.ReadLine()
            End While


            ' Si choix est valide, demandez la saisie de 2 nombres réels valides
            ' Le prgramme doit gérer le cas d'une division par 0

            Do
                Console.WriteLine("Premier nombre: ")
                v1 = Console.ReadLine()
            Loop Until IsNumeric(v1)

            nb1 = CDbl(v1)

            Do
                Console.WriteLine("Second nombre: ")
                v2 = Console.ReadLine()
            Loop Until IsNumeric(v2)

            nb2 = CDbl(v2)

            'Division par zéro

            If choix = "d" And nb2 = 0 Then
                Console.WriteLine("Attention, division par 0")
                While True
                    Console.WriteLine("Second nombre différent de 0: ")
                    v2 = Console.ReadLine()
                    If IsNumeric(v2) And Not (v2 = "0") Then
                        nb2 = CDbl(v2)
                        Exit While
                    End If
                End While
            End If



            'Affichez le résultat

            Select Case choix
                Case "a"
                    Console.WriteLine($"{nb1} + {nb2} = {nb1 + nb2}")

                Case "s"
                    Console.WriteLine($"{nb1} - {nb2} = {nb1 - nb2}")

                Case "m"
                    Console.WriteLine($"{nb1} x {nb2} = {nb1 * nb2}")

                Case "d"
                    Console.WriteLine($"{nb1} / {nb2} = {nb1 / nb2}")
            End Select



        End While





        'Maintenir la console active
        Console.ReadKey()

    End Sub

End Module
