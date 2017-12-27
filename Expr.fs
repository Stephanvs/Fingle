namespace Fingle

type Expr =
    interface end

module Expr =
    type Doc() =
        interface Expr

    type Var(name: string) =
        interface Expr
        member __.Name = name

    type DownField(expr: Expr, key: string) =
        interface Expr
        member __.Expr = expr
        member __.Key = key

    type Iter(expr: Expr) =
        interface Expr
        member __.Expr = expr

    type Next(expr: Expr) =
        interface Expr
        member __.Expr = expr