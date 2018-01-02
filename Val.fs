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

type EmptyMap = inherit IBranchVal

type EmptyList = inherit IBranchVal

type Val =
    | Num of Num
    | Str of Str
    | True
    | False
    | Null
    | EmptyMap of EmptyMap
    | EmptyList of EmptyList
    interface IVal