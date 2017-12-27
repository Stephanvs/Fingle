namespace Fingle

[<Sealed>]
type Cursor(keys: list<BranchTag>, finalKey: Key) =

    member __.Keys = keys

    member __.FinalKey = finalKey

    member __.Append(tag: (Key -> BranchTag), newFinalKey: Key) =
        Cursor(__.Keys, newFinalKey)

    // member __.View(): IView =
    //     Leaf(DocK()) :> IView
        // match __.Keys with
        // | h -> Branch(h, Cursor(kn, finalKey)) :> IView
        // | _ -> Leaf(finalKey) :> IView

    static member Doc() =
        Cursor.WithFinalKey(DocK())

    static member WithFinalKey(finalKey: Key) =
        Cursor(list.Empty, finalKey)

type View = interface end

type Leaf(finalKey: Key) =
    interface View
    member __.FinalKey = finalKey

type Branch(head: BranchTag, tail: Cursor) =
    interface View
    member __.Head = head
    member __.Tail = tail
