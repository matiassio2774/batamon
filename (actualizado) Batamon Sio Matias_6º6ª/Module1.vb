Module Module1

    Function batamon(pHechicera() As Integer, pRival() As Integer, enfrentamientos() As Integer) As Integer
        Dim cont As Integer = 0
        Dim aux As Integer = 0
        Dim aux2 As Integer = 0
        Dim victoriaH As Integer = 0
        For i = 0 To pHechicera.Length - 1
            enfrentamientos(i) = i + 1
        Next

        For i = 1 To pHechicera.Length - 1 Step 1   'Metodo burbujeo para ordenar arrays
            For k = 0 To pHechicera.Length - 2 Step 1
                If pHechicera(k) > pRival(i) Or pHechicera(k) = pRival(i) Then
                    aux = pHechicera(k + 1)
                    pHechicera(k + 1) = pHechicera(k)
                    pHechicera(k) = aux

                    aux2 = enfrentamientos(k + 1)
                    enfrentamientos(k + 1) = enfrentamientos(k)
                    enfrentamientos(k) = aux2

                End If
            Next
        Next


        For i = 0 To pHechicera.Length - 1 Step 1
            Console.Write(Str(pHechicera(i)) + ",")
        Next

        Console.WriteLine(" ")

        For i = 0 To pRival.Length - 1 Step 1
            Console.Write(Str(pRival(i)) + ",")
        Next

        Console.WriteLine(" ")

        For i = 0 To pHechicera.Length - 1  'Comparacion para sacar las victorias de la hechicera
            If pHechicera(i) > pRival(i) Or pHechicera(i) = pRival(i) Then

                victoriaH += 1

            End If

        Next

        Return victoriaH
    End Function

    Sub cargaDatos(cantMonstruos As Integer, pHechicera() As Integer, pRival() As Integer)
        For i = 0 To cantMonstruos Step 1
            Console.Write("Ingrese poder de monstruo " + Str(i + 1) + " (H): ")
            pHechicera(i) = Console.ReadLine
        Next
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        For i = 0 To cantMonstruos Step 1
            Console.Write("Ingrese poder de monstruo " + Str(i + 1) + " (R): ")
            pRival(i) = Console.ReadLine
        Next

    End Sub

    Sub Main()
        Dim cantMonstruos As Integer = 0

        Console.Write("Ingrese la cantidad de monstruos: ")
        cantMonstruos = Console.ReadLine
        cantMonstruos -= 1

        Dim pHechicera(cantMonstruos) As Integer
        Dim pRival(cantMonstruos) As Integer
        Dim enfrentamientos(cantMonstruos) As Integer

        cargaDatos(cantMonstruos, pHechicera, pRival)
        Console.WriteLine(" ")

        Console.WriteLine("Enfrentamientos ganados: " + Str(batamon(pHechicera, pRival, enfrentamientos)))


        Console.WriteLine("-----Listado de enfrentamientos-----")
        For i = 0 To cantMonstruos
            Console.Write(enfrentamientos(i))
            Console.Write("  ")
        Next
        Console.WriteLine(" ")
        Console.WriteLine("------------------------------------")
        For i = 0 To cantMonstruos
            Console.Write(Str(pHechicera(enfrentamientos(i) - 1)) + " vs" + Str(pRival(i)))
            Console.Write("  ")
        Next

        Console.ReadKey()
    End Sub

End Module
