namespace Fingle

type Node =
    interface end

type BranchNode =
    inherit Node

type MapNode =
    {
        children: Map<TypeTag, Node>
        presSets: Map<Key, Set<Id>>
    }
    interface BranchNode

type ListNode =
    {
        children: Map<TypeTag, Node>
        presSets: Map<Key, Set<Id>>
        order: Map<ListRef, ListRef>
        orderArchive: Map<bigint, Map<ListRef, ListRef>>
    }
    interface BranchNode

type RegNode =
    {
        regValues: Map<Id, LeafVal>
    }
    interface Node

module Node =
    let emptyMap =
        { children = Map.empty; presSets = Map.empty }

    let emptyList =
        {
            children = Map.empty
            presSets = Map.empty
            order = Map.empty
            orderArchive = Map.empty
        }

    let emptyReg =
        {
            regValues = Map.empty
        }




//     let emptyList =
//         ListNode(
//             children = Map.empty,
//             presSets = Map.empty,
//             order = Map.empty,
//             orderArchive = Map.empty)

//     let emptyReg =
//         RegNode(regValues = Map.empty)