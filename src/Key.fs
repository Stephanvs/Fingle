namespace Fingle

type IKey =
    interface end

type IdK =
    {
        id: Id
    }
    interface IKey

type StrK =
    {
        str: string
    }
    interface IKey

type Key =
    | DocK
    | HeadK
    | IdK of IdK
    | StrK of StrK
    interface IKey