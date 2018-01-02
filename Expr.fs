namespace Fingle

type IExpr = interface end

type Var =
    {
        name: string
    }
    // interface IExpr

type DownField =
    {
        expr: IExpr
        key: string
    }
    // interface IExpr

type Iter =
    {
        expr: IExpr
    }
    // interface IExpr

type Next =
    {
        expr: IExpr
    }
    // interface IExpr

type Expr =
    | Doc
    | Var of Var
    | DownField of DownField
    | Iter of Iter
    | Next of Next
    interface IExpr


// type Expr =
//     interface end

// module Expr =
//     type Doc() =
//         interface Expr

//     type Var(name: string) =
//         interface Expr
//         member __.Name = name

//     type DownField(expr: Expr, key: string) =
//         interface Expr
//         member __.Expr = expr
//         member __.Key = key

//     type Iter(expr: Expr) =
//         interface Expr
//         member __.Expr = expr

//     type Next(expr: Expr) =
//         interface Expr
//         member __.Expr = expr