Namespace ConsoleUI
    Class Program
        Shared Sub Main(args As String())
            Try
                BadCall()
            Catch ex As Exception
                Console.WriteLine("There was an exception thrown in our app")
                Console.WriteLine(ex.Message)
            End Try

            Console.ReadLine()
        End Sub

        Private Shared Sub BadCall()
            Dim ages As Integer() = {1, 3, 5}

            For i As Integer = 0 To ages.Length
                Try
                    Console.WriteLine(ages(i))
                Catch ex As Exception
                    Console.WriteLine("We had an error")
                    Console.WriteLine(ex.Message)
                    Throw New Exception("There was an error handling our array", ex)
                End Try
            Next
        End Sub
    End Class
End Namespace
