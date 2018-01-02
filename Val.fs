namespace Fingle

type IVal = interface end

type ILeafVal =
    inherit IVal

type IBranchVal =
    inherit IVal

type Num =
    {
        value: decimal
    }
    interface ILeafVal

type Str =
    {
        value: string
    }
    interface ILeafVal

type Val =
    | Num of Num
    | Str of Str
    | True of ILeafVal
    | False of ILeafVal
    | Null of ILeafVal
    | EmptyMap of IBranchVal
    | EmptyList of IBranchVal
    interface IVal