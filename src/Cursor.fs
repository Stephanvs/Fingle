namespace Fingle

//type ICursor =
//    interface end

//type IView =
//    interface end

//type Leaf =
//    {
//        FinalKey: Key
//    }
//    interface IView

//type Branch =
//    {
//        head: IBranchTag
//        tail: ICursor
//    }
//    interface IView

//type Cursor =
    //{
    //    Keys: list<IBranchTag>
    //    FinalKey: Key
    //}
    //interface ICursor

    //member __.Append(tag: Key -> IBranchTag, newFinalKey: Key) =
    //    {
    //        Keys = List.append __.Keys [tag(__.FinalKey)]
    //        FinalKey = newFinalKey
    //    }

    //member __.View(): IView =
    //    match __.Keys with
    //    | x :: xs ->
    //        {
    //            head = x
    //            tail = { Keys = xs; FinalKey = __.FinalKey }
    //        } :> IView
    //    | _ ->
    //        {
    //            FinalKey = __.FinalKey
    //        } :> IView

    //static member Doc() =
    //    Cursor.WithFinalKey(DocK)

    //static member WithFinalKey(finalKey: Key) =
        //{
        //    Keys = List.empty
        //    FinalKey = finalKey
        //}
//type View = interface end

type Cursor(keys: BranchTag list, finalKey: Key) =
    member Append(tag: Key): Cursor =


//module Cursor =
    type Cursor =
        | Leaf of finalKey: Key
        | Branch of head: BranchTag * tail: Cursor
        //interface View



        static member Doc() =
            __.WithFinalKey(Key.DocK)

        static member WithFinalKey(finalKey: Key): Cursor =
            Cursor(List.empty, finalKey)



//type Product (code:string, price:float) = 
   //let isFree = price=0.0 
   //new (code) = Product(code,0.0)
   //member this.Code = code 
   //member this.IsFree = isFree