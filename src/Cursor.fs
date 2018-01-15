﻿namespace Fingle

type ICursor =
    interface end

type IView =
    interface end

type Leaf =
    {
        FinalKey: Key
    }
    interface IView

type Branch =
    {
        head: BranchTag
        tail: ICursor
    }
    interface IView

type Cursor =
    {
        Keys: list<BranchTag>
        FinalKey: Key
    }
    interface ICursor

    member __.Append(tag: Key -> BranchTag, newFinalKey: Key): Cursor =
        {
            Keys = List.append __.Keys [tag(__.FinalKey)]
            FinalKey = newFinalKey
        }

    member __.View(): IView =
        match __.Keys with
        | x :: xs ->
            {
                head = x
                tail = { Keys = xs; FinalKey = __.FinalKey }
            } :> IView
        | _ ->
            {
                FinalKey = __.FinalKey
            } :> IView

    static member Doc() =
        Cursor.WithFinalKey(Key.DocK)

    static member WithFinalKey(finalKey: Key) =
        {
            Keys = List.empty
            FinalKey = finalKey
        } :> ICursor
