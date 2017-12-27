namespace Fingle

type TypeTag =
    abstract member Key: Key with get

type BranchTag =
    inherit TypeTag

type MapT(key: Key) =
    interface BranchTag
    interface TypeTag with
        member __.Key = key

type ListT(key: Key) =
    interface BranchTag
    interface TypeTag with
        member __.Key = key

type RegT(key: Key) =
    interface TypeTag with
        member __.Key = key