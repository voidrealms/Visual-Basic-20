Module Module1

    Sub Main()
        'class is a blue print for an object. 
        Dim myfreind As Person = New Person(35)

        myfreind.Name = "chad"

        Console.WriteLine(myfreind.Name)
        Console.WriteLine(myfreind.GetAge)
        Console.ReadLine()
    End Sub

End Module
