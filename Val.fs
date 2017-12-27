namespace Fingle

type Val = interface end

type LeafVal =
    inherit Val

type BranchVal =
    inherit Val

type Num(value: decimal) =
    interface LeafVal
    member __.Value = value

type Str(value: string) =
    interface LeafVal
    member __.Value = value

type True() =
    interface LeafVal

type False() =
    interface LeafVal

type Null() =
    interface LeafVal

type EmptyMap() =
    interface BranchVal

type EmptyList() =
    interface BranchVal
