namespace Fingle

type ICursor =
    interface end

type IView =
    interface end

type Leaf =
    {
        finalKey: Key
    }
    interface IView

type Branch =
    {
        head: BranchTag
        tail: ICursor
    }
    interface IView

type Cursor =
    {
        keys: list<BranchTag>
        finalKey: Key
    }
    interface ICursor

    member __.Append(tag: Key -> BranchTag, newFinalKey: Key): Cursor =
        {
            keys = List.append __.keys [tag(__.finalKey)]
            finalKey = newFinalKey
        }

    member __.View(): IView =
        match __.keys with
        | x :: xs ->
            {
                head = x
                tail = { keys = xs; finalKey = __.finalKey }
            } :> IView
        | _ ->
            {
                finalKey = __.finalKey
            } :> IView

    static member Doc(): Cursor =
        Cursor.WithFinalKey(Key.DocK)

    static member WithFinalKey(finalKey: Key): Cursor =
        {
            keys = List.empty
            finalKey = finalKey
        }
