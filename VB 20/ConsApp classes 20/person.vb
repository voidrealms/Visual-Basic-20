Public Class Person
    Public Name As String 'access from outside
    Private age As Integer 'access from inside 

    Public Sub New()
        Console.WriteLine("new person created")

        Console.ReadLine()
    End Sub

    Public Sub New(ByVal mAge As Integer)
        Me.age = mage
        Console.WriteLine("new person created with age")

        Console.ReadLine()
    End Sub

    Public Function GetAge() As Integer 'this makes the private knowledge publicly veiwable. 
        Return Me.age
    End Function

End Class
