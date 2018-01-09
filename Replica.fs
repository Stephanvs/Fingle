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
        failwithf "Not implemented"

    static member ApplyCmds(replica: Replica, cmds: List<Cmd>): Replica =
        match cmds with
        | cmd :: rest ->
            match cmd with
            | Let { Let.X = x; Let.Expr = expr; } -> // todo: cast Let to Cmd or change type definition of Cmd. maybe something like type Cmd = | x | y
                let cur = replica.EvalExpr(expr)
                let newReplica = { replica with variables = replica.variables.Add(x, cur) }
                Replica.ApplyCmds(newReplica, rest)
            | Sequence { Sequence.Cmd1 = cmd1; Cmd2 = cmd2 } ->
                Replica.ApplyCmds(replica, [cmd1] :: [cmd2] :: rest)
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