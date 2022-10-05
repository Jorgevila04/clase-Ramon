Module VilaNicolásJorgeEjercicio4

    Sub Main()

        Dim a, b As Integer

        Dim x, y, z As Double

        Console.WriteLine("introduzca el valor de A : ")
        a = Convert.ToInt32(Console.ReadLine)

        Console.WriteLine("introduzca el valor de B : ")
        b = Convert.ToInt32(Console.ReadLine)


        x = Math.Pow(a, 4) / Math.Pow(a, 3)

        y = Math.Sqrt(a + Math.Pow(b, 2))

        z = Math.Sqrt(3 - a)

        Console.WriteLine("x = " & x)
        Console.WriteLine("y = " & y)
        Console.WriteLine("z = " & z)
        Console.ReadLine()

    End Sub

End Module
