Module ejercicio6
    Sub main()

        Console.Title = ("Aprobado o suspenso")

        Dim numero, numero2, numero3, media As Double

        Console.WriteLine("introduzca un numero : ")
        numero = Convert.ToInt32(Console.ReadLine)

        Console.WriteLine("introduzca un numero : ")
        numero2 = Convert.ToInt32(Console.ReadLine)

        Console.WriteLine("introduzca un numero : ")
        numero3 = Convert.ToInt32(Console.ReadLine)

        media = (numero + numero2 + numero3) / 3


        If media > 5 Then

            Console.WriteLine("Estas aprobado")

        Else
            Console.WriteLine("Estas suspenso")

        End If

        Console.ReadLine()
    End Sub
End Module
