Module VilaNicolásJorgeEjercicio5
    Sub main()

        Const impuestoreval As Double = 3.4

        Dim preciofinal, importe, CI, antiguedad, preciocatastral As Double

        Console.WriteLine("introduzca el importe : ")
        importe = Convert.ToDouble(Console.ReadLine)

        Console.WriteLine("introduzca el precio catastral : ")
        preciocatastral = Convert.ToDouble(Console.ReadLine)

        Console.WriteLine("introduzca los años que tiene el piso : ")
        antiguedad = Convert.ToDouble(Console.ReadLine)

        CI = (importe * 3) / 100

        preciofinal = importe + CI + (impuestoreval * antiguedad / 100) * preciocatastral


        Console.WriteLine("El precio de venta es de : " & preciofinal)
        Console.ReadLine()

    End Sub
End Module
