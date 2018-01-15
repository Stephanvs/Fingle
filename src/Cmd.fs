namespace Fingle

type BeforeAfter =
    interface end

type Before =
    inherit BeforeAfter

type After =
    inherit BeforeAfter

type Cmd =
    interface end

type Let =
    {
        X: Var
        Expr: IExpr
    }
    interface Cmd

type Assign =
    {
        Expr: IExpr
        Value: Val
    }
    interface Cmd

type Insert =
    {
        Expr: IExpr
        Value: Val
    }
    interface Cmd

type Delete =
    {
        Expr: IExpr
    }
    interface Cmd

type MoveVertical =
    {
        MoveExpr: IExpr
        TargetExpr: IExpr
        BeforeAfter: BeforeAfter
    }
    interface Cmd

type Sequence =
    {
        Cmd1: Cmd
        Cmd2: Cmd
    }
    interface Cmd
