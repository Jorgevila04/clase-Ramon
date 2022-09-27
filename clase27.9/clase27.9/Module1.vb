Module Module1

    Sub Main()
        Dim a, b, c, mayor, menor As Integer
        Dim resultado As Double


        Console.WriteLine("porfavor introduzca el valor de a: ")
        a = Convert.ToInt32(Console.ReadLine)


        Console.WriteLine("porfavor introduzca el valor de b: ")
        b = Convert.ToInt32(Console.ReadLine)


        Console.WriteLine("porfavor introduzca el valor de c: ")
        c = Convert.ToInt32(Console.ReadLine)


        mayor = Math.Max(a, b)
        mayor = Math.Max(mayor, c)

        menor = Math.Min(a, b)
        menor = Math.Min(menor, c)


        'resultado = raiz(mayormenor) + a5


        resultado = Math.Sqrt(mayor ^ menor) + Math.Pow(a, 5)





    End Sub

End Module
