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
        Expr: Expr
    }
    interface Cmd

type Assign =
    {
        Expr: Expr
        Value: Val
    }
    interface Cmd

type Insert =
    {
        Expr: Expr
        Value: Val
    }
    interface Cmd

type Delete =
    {
        Expr: Expr
    }
    interface Cmd

type MoveVertical =
    {
        MoveExpr: Expr
        TargetExpr: Expr
        BeforeAfter: BeforeAfter
    }
    interface Cmd

type Sequence =
    {
        Cmd1: Cmd
        Cmd2: Cmd
    }
    interface Cmd
