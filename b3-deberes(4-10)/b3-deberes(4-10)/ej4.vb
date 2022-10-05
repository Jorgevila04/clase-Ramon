Module ej4
    Sub main()

        Console.Title = ("Numero Menor")

        Console.ForegroundColor = Console.ForegroundColor.Cyan

        Dim a, b, c, d, menor As Double

        Console.WriteLine("introduzca un numero : ")
        a = Convert.ToDouble(Console.ReadLine)

        Console.WriteLine("

introduzca un numero : ")
        b = Convert.ToDouble(Console.ReadLine)

        Console.WriteLine("

introduzca un numero : ")
        c = Convert.ToDouble(Console.ReadLine)

        Console.WriteLine("

introduzca un numero : ")
        d = Convert.ToDouble(Console.ReadLine)


        If a > b Then

            menor = b

        Else

            menor = a

        End If


        If menor > c Then

            menor = c

        End If

        If menor > d Then

            menor = d

        End If

        Console.ForegroundColor = Console.ForegroundColor.Green

        Console.WriteLine("


El numero menor es " & menor)

        Console.ReadLine()

    End Sub
End Module
