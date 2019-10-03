Module Module1

    Sub Main()
        Console.WriteLine("Sum of a and b = " & Addition())

    End Sub


    Function Addition() As Integer

        Dim a, b, sum As Integer

        Console.WriteLine("Enter number a")
        a = Console.ReadLine()
        Console.WriteLine("Enter number b")
        b = Console.ReadLine()
        sum = a + b
        Return sum
    End Function

End Module
