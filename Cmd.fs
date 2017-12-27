namespace Fingle

[<AbstractClass>]
type BeforeAfter() =
    class end

type Before() =
    inherit BeforeAfter()

type After() =
    inherit BeforeAfter()

type Cmd =
    interface end

module Cmd =
    type Let(x: Expr.Var, expr: Expr) =
        interface Cmd
        member __.X = x
        member __.Expr = expr

    type Assign(expr: Expr, value: Val) =
        interface Cmd
        member __.Expr = expr
        member __.Value = value

    type Insert(expr: Expr, value: Val) =
        interface Cmd
        member __.Expr = expr
        member __.Value = value

    type Delete(expr: Expr) =
        interface Cmd
        member __.Expr = expr

    type MoveVertical(moveExpr: Expr, targetExpr: Expr, beforeAfter: BeforeAfter) =
        interface Cmd
        member __.MoveExpr = moveExpr
        member __.TargetExpr = targetExpr
        member __.BeforeAfter = beforeAfter

    type Sequence(cmd1: Cmd, cmd2: Cmd) =
        interface Cmd
        member __.Cmd1 = cmd1
        member __.Cmd2 = cmd2