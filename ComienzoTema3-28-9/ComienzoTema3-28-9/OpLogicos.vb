Module OpLogicos
    Sub main()
        'operadores logicos --->  AND , OR , Not
        'AND ---> Y logico --->Devuelve true si las dos condiciones son True
        Dim x As Boolean = True
        Dim y As Boolean = False

        Dim condicionAND As Boolean = x And y
        Dim condicionAND2 As Boolean = True And True
        Dim condicionAND3 As Boolean = False And True
        Dim condicionAND4 As Boolean = False And False

        'programa que lea un numero entre 1 y 10 , sino error

        Dim numero As Integer
        Dim correcto As Boolean
        Console.WriteLine("introduzca un numero entre 1 y 10(Incluidos): ")
        numero = Convert.ToInt32(Console.ReadLine)

        correcto = numero >= 1 And numero <= 10

        Console.WriteLine("Correcto : " & correcto)


        'Or ---> Devuelve true si una de las condiciones es True

        'los niños deben llevar silla si son menores de 8 años o miden menos de 1.35m
        Dim altura As Single = 1.2
        Dim edad As Byte = 8
        Dim silla As Boolean = altura < 1.35 Or edad < 8

        Console.WriteLine("silla : " & silla)

        Console.ReadLine()


        'Not ---> Devuelve lo contrario de lo que tiene a su derecha
        'programa que lee numero y la condicion es true si no par
        Dim numero2 As Integer
        Dim impar As Boolean
        Console.WriteLine("introduzca un numero impar : ")
        numero2 = Convert.ToInt32(Console.ReadLine)

        impar = Not numero2 Mod 2 = 0
        'impar numero impar Mod 2 <> 0
        Console.WriteLine(numero & "  impar?  " & impar)

        Console.ReadLine()

    End Sub
End Module
