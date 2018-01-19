namespace Fingle

type Key =
    | DocK
    | HeadK
    | IdK of Id: Id
    | StrK of Str: string