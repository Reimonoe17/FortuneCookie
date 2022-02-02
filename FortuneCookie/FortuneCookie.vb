'Jamison Burton
'RCET0265
'Spring 2022
'Fortune Cookie
'https://github.com/Reimonoe17/FortuneCookie

Option Explicit On
Option Strict On
Option Compare Text

Module FortuneCookie

    Sub Main()
        Dim number As Integer = CInt(Int((10 * Rnd()) + 1))

        Console.WriteLine("Your fortune cookie reads:")

        Select Case number
            Case 1
                Console.WriteLine("The only thing we have to fear is fear itself... And weasels (those little suckers will get you everytime!)")
            Case 2
                Console.WriteLine("You will find $20 in the pocket of your jacket back at home")
            Case 3
                Console.WriteLine("Your car is currently getting carjacked (sorry)")
            Case 4
                Console.WriteLine("Every snowflake is unique and so are you")
            Case 5
                Console.WriteLine("Neither can live while the other survives")
            Case 6
                Console.WriteLine("You will find romance in an unexpected place")
            Case 7
                Console.WriteLine("Pineapple pizza has a special place in Hades waiting for it")
            Case 8
                Console.WriteLine("Don't drink the orange juice")
            Case 9
                Console.WriteLine("The monsters under the bed give great advice, listen sometime")
            Case 10
                Console.WriteLine("You are the Chosen One: Your order for chow mein is also ready ;)")
        End Select

        Console.Read()
    End Sub

End Module
