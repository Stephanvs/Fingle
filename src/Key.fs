namespace Fingle

type IKey =
    interface end

type IdK =
    {
        Id: Id
    }
    interface IKey

type StrK =
    {
        Str: string
    }
    interface IKey

type HeadK() = interface IKey
type DocK() = interface IKey

//type Key =
//    | DocK
//    | HeadK
//    | IdK of IdK
//    | StrK of StrK
//    interface IKey