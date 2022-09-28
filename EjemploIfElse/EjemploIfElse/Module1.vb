Imports System.Reflection

Module Module1

    Sub Main()
        'Programa que lee la altura y edad de un niño
        'indica si debe llevar proteccion 
        'si mide menos de 1.35 o es de menor de  8 años debe llevar proteccion

        Dim edad As Byte
        Dim altura As Single
        Dim condicion As Boolean


        Console.WriteLine("Intro edad: ")
        edad = Convert.ToByte(Console.ReadLine)
        Console.WriteLine("intro altura: ")
        altura = Convert.ToSingle(Console.ReadLine)
        condicion = edad < 8 Or altura < 1.35

        If condicion Then

        End If
        If edad < 8 Or altura < 1.35 Then

            Console.WriteLine("Debe llevar silla de prteccion.")

        Else
            Console.WriteLine("No debe llevar silla de proteccion")
        End If
        Console.ReadLine()
    End Sub

End Module
