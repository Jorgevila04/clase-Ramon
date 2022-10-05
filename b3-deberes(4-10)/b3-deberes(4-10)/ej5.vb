Module ej5

    Sub Main()

        Console.Title = ("Par o impar")

        Dim numero As Integer

        Console.WriteLine("introduzca un numero : ")
        numero = Convert.ToInt32(Console.ReadLine)

        If numero Mod 2 = 0 Then
            Console.WriteLine("El numero es par")
        Else
            Console.WriteLine("El numero es impar")

        End If
        Console.ReadLine()
    End Sub

End Module
