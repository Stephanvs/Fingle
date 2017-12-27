namespace Fingle

type Key = interface end

type DocK() = interface Key

type HeadK() = interface Key

type IdK(id: Id) =
    interface Key
    member __.Id = id

type StrK(str: string) =
    interface Key
    member __.Str = str