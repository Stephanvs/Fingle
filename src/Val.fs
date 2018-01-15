namespace Fingle

type IVal = interface end

type LeafVal =
    inherit IVal

type BranchVal =
    inherit IVal

type Num =
    {
        value: decimal
    }
    interface LeafVal

type Str =
    {
        value: string
    }
    interface LeafVal

type Val =
    | Num of Num
    | Str of Str
    | True of LeafVal
    | False of LeafVal
    | Null of LeafVal
    | EmptyMap of BranchVal
    | EmptyList of BranchVal
    interface IVal