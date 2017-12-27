namespace Fingle

type Id(opsCounter: bigint, replicaId: ReplicaId) =

    member __.OpsCounter = opsCounter

    member __.ReplicaId = replicaId