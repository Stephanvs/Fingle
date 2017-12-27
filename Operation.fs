namespace Fingle

type Operation(id: Id, deps: Set<Id>, cur: Cursor, mut: Mutation) =

    member __.Id = id

    member __.Deps = deps

    member __.Cursor = cur

    member __.Mutation = mut