// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open ClassLibrary1

let bla = Typey()

[<EntryPoint>]
let main argv = 

    //Class1.Funny(bla)
    bla.Funny()
    0 // return an integer exit code
