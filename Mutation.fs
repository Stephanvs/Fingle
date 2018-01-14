namespace Fingle

type Mutation = interface end

type AssignM =
    {
        Value: Val
    }
    interface Mutation

type InsertM =
    {
        Value: Val
    }
    interface Mutation

type MoveVerticalM =
    {
        TargetCursor: ICursor
        BeforeAfter: BeforeAfter
    }
    interface Mutation

type DeleteM() =
    interface Mutation