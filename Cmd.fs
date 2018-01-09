namespace Fingle

type BeforeAfter =
    interface end

type Before =
    inherit BeforeAfter

type After =
    inherit BeforeAfter

type ICmd =
    interface end

type Let =
    {
        X: Var
        Expr: Expr
    }

type Assign =
    {
        Expr: Expr
        Value: Val
    }

type Insert =
    {
        Expr: Expr
        Value: Val
    }

type Delete =
    {
        Expr: Expr
    }

type MoveVertical =
    {
        MoveExpr: Expr
        TargetExpr: Expr
        BeforeAfter: BeforeAfter
    }

type Sequence =
    {
        Cmd1: ICmd
        Cmd2: ICmd
    }

type Cmd =
    | Let of Let
    | Assign of Assign
    | Insert of Insert
    | Delete of Delete
    | MoveVertical of MoveVertical
    | Sequence of Sequence
    interface ICmd