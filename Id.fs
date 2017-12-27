namespace Fingle

open System

type Id(opsCounter: bigint, replicaId: ReplicaId) =

    member __.OpsCounter = opsCounter

    member __.ReplicaId = replicaId

    override this.Equals(o) =
        match o with
        | :? Id as id -> this.ReplicaId = id.ReplicaId && this.OpsCounter = id.OpsCounter
        | _ -> false

    override this.GetHashCode() =
        this.ReplicaId.GetHashCode() + this.OpsCounter.GetHashCode()

    interface IComparable with
        member this.CompareTo(o) =
            match o with
            | :? Id as id -> compare this.ReplicaId id.ReplicaId + compare this.OpsCounter id.OpsCounter
            | _ -> -1