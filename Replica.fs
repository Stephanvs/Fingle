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

    member __.Empty(replicaId) =
        {
            replicaId = replicaId
            opsCounter = bigint.Zero
            document = Node.emptyMap
            variables = Map.empty
            processedOps = Set.empty
            generatedOps = List.Empty
            receivedOps = List.Empty
        }



// module Replica =
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