namespace Fingle

[<StructuralComparison>]
[<StructuralEquality>]
type Id = {
        opsCounter: bigint;
        replicaId: ReplicaId 
    }