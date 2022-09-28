Module OpMatematicos

    Sub Main()

        'operadores matematicos : Mod , / , \

        Dim x As Integer = 14
        Dim y As Integer = 4

        Dim resto As Integer = x Mod y
        Dim divisionreal As Double = x / y
        Dim divisionentera As Integer = x \ y

        Console.WriteLine("Resto: " & resto)
        Console.WriteLine("Division real: " & divisionreal)
        Console.WriteLine("division entera: " & divisionentera)
        Console.ReadLine()


    End Sub

End Module
