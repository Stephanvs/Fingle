namespace Fingle

type ITypeTag = interface end

type MapT =
    {
        key: Key
    }

type ListT =
    {
        key: Key
    }

type RegT =
    {
        key: Key
    }

type BranchTag =
    | MapT of MapT
    | ListT of ListT
    interface ITypeTag

type TypeTag =
    | RegT of RegT
    interface ITypeTag
