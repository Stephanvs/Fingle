namespace Fingle

type Mutation = interface end

type AssignM(value: Val) =
    interface Mutation
    member __.Value = value

type InsertM(value: Val) =
    interface Mutation
    member __.Value = value

type MoveVerticalM(targetCursor: Cursor, aboveBelow: BeforeAfter) =
    interface Mutation
    member __.TargetCursor = targetCursor
    member __.AboveBelow = aboveBelow

type DeleteM() =
    interface Mutation