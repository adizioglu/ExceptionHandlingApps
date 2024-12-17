open System

module ConsoleUI =

    let badCall() =
        let ages = [| 1; 3; 5 |]

        for i in 0 .. ages.Length do
            try
                printfn "%d" ages.[i]
            with
            | ex ->
                printfn "We had an error"
                printfn "%s" ex.Message
                raise (Exception("There was an error handling our array", ex))

    [<EntryPoint>]
    let main argv =
        try
            badCall()
        with
        | ex ->
            printfn "There was an exception thrown in our app"
            printfn "%s" ex.Message

        Console.ReadLine() |> ignore
        0
