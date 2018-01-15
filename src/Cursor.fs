namespace Fingle

type ICursor =
    interface end

type IView =
    interface end

type Leaf =
    {
        FinalKey: IKey
    }
    interface IView

type Branch =
    {
        head: IBranchTag
        tail: ICursor
    }
    interface IView

type Cursor =
    {
        Keys: list<IBranchTag>
        FinalKey: IKey
    }
    interface ICursor

    member __.Append(tag: IKey -> IBranchTag, newFinalKey: IKey) =
        {
            Keys = List.append __.Keys [tag(__.FinalKey)]
            FinalKey = newFinalKey
        }

    member __.View(): IView =
        match __.Keys with
        | x :: xs ->
            {
                head = x
                tail = { Keys = xs; FinalKey = __.FinalKey }
            } :> IView
        | _ ->
            {
                FinalKey = __.FinalKey
            } :> IView

    static member Doc() =
        Cursor.WithFinalKey(DocK())

    static member WithFinalKey(finalKey: IKey) =
        {
            Keys = List.empty
            FinalKey = finalKey
        }
