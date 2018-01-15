namespace Fingle

type ITypeTag = interface end

type IBranchTag = inherit ITypeTag

type MapT =
    {
        key: IKey
    }
    interface IBranchTag

type ListT =
    {
        key: IKey
    }
    interface IBranchTag

type RegT =
    {
        key: IKey
    }

type BranchTag =
    | MapT of MapT
    | ListT of ListT
    interface ITypeTag

type TypeTag =
    | RegT of RegT
    interface ITypeTag
