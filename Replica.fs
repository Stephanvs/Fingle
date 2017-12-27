namespace Fingle

module Replica =

    let hello name =
        printfn "%s", Val.Str(name).ToString()