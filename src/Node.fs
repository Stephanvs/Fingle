namespace Fingle

type Node =
    | MapNode of children: Map<TypeTag, Node> * presSets: Map<Key, Set<Id>>
    | ListNode of children: Map<TypeTag, Node> * presSets: Map<Key, Set<Id>> * order: Map<ListRef, ListRef> * orderArchive: Map<bigint, Map<ListRef, ListRef>>
    | RegNode of regValues: Map<Id, LeafVal>

    static member Next(cursor: Cursor): ICursor =
        match cursor.View() with
        | Leaf(k) ->
        | Branch()

module Node =
    let emptyMap =
        MapNode(
            children = Map.empty,
            presSets = Map.empty)

    let emptyList =
        ListNode(
            children = Map.empty,
            presSets = Map.empty,
            order = Map.empty,
            orderArchive = Map.empty)

    let emptyReg =
        RegNode(regValues = Map.empty)