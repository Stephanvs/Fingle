namespace Fingle

type Replica =
    {
        replicaId: ReplicaId
        opsCounter: bigint
        document: Node
        variables: Map<Var, ICursor>
        processedOps: Set<Id>
        generatedOps: List<Operation>
        receivedOps: List<Operation>
    }

    member __.EvalExpr(expr: Expr): ICursor =
        failwith "Not implemented"

    member __.MakeOp(cursor, mutation): Replica =
        failwith "Not implemented"

    static member ApplyCmds(replica: Replica, cmds: Cmd list) =
        match cmds with
        | cmd :: rest ->
            match box cmd with
            | :? Let as c ->
                let cur = replica.EvalExpr(c.Expr)
                let newReplica = { replica with variables = replica.variables.Add(c.X, cur) }
                Replica.ApplyCmds(newReplica, rest)
            | :? Assign as c ->
                let newReplica = replica.MakeOp(replica.EvalExpr(c.Expr), { AssignM.Value = c.Value })
                Replica.ApplyCmds(newReplica, rest)
            | :? Insert as c ->
                let newReplica = replica.MakeOp(replica.EvalExpr(c.Expr), { InsertM.Value = c.Value })
                Replica.ApplyCmds(newReplica, rest)
            | :? Delete as c ->
                let newReplica = replica.MakeOp(replica.EvalExpr(c.Expr), DeleteM)
                Replica.ApplyCmds(newReplica, rest)
            | :? MoveVertical as c ->
                let newReplica = replica.MakeOp(replica.EvalExpr(c.MoveExpr), { MoveVerticalM.TargetCursor = replica.EvalExpr(c.TargetExpr); MoveVerticalM.BeforeAfter = c.BeforeAfter })
                Replica.ApplyCmds(newReplica, rest)
            | :? Sequence as c ->
                Replica.ApplyCmds(replica, c.Cmd1 :: c.Cmd2 :: rest)
            | _ ->
                replica
        | _ ->
            replica

    static member Empty(replicaId: ReplicaId): Replica =
        {
            replicaId = replicaId
            opsCounter = bigint.Zero
            document = Node.emptyMap
            variables = Map.empty
            processedOps = Set.empty
            generatedOps = List.Empty
            receivedOps = List.Empty
        }



 //module Replica =
    // let hello name =
    //     printfn "%s", { Str.value = name }

    // let str = { Num.value = 0.3m }
    // let id = { replicaId = "abc"; opsCounter = bigint(2) }
    // let idKey = Key.IdK { id = id }
    // let stringKey = Key.StrK { str = "abc" }
    // let docK = Key.DocK
    // let headK = Key.HeadK

    // let listTT = BranchTag.ListT { key = docK }

    // let regTT = TypeTag.RegT { key = headK }

    // let c = { head = listTT; tail = { keys = List.empty; finalKey = headK } }

    // let eln = Node.emptyList
    // let emn = Node.emptyMap
    // let ern = Node.emptyReg