namespace Fingle

type Operation =
    {
        id: Id
        deps: Set<Id>
        cur: ICursor
        mut: Mutation
    }