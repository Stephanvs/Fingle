namespace Fingle

type ITypeTag = interface end

type IBranchTag = inherit ITypeTag

type MapT =
    {
        key: Key
    }
    interface IBranchTag

type ListT =
    {
        key: Key
    }
    interface IBranchTag

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
    //interface ITypeTag
