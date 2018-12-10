using System.Collections.Generic;

public static class LinkedListExtensions
{
    public static bool RemoveAt(int index, LinkedList<object> List1)
    {
        //set current index and node to 0, and first node
        int currentIndex = 0;
        LinkedListNode<object> currentNode = List1.First;

        while (currentNode != null)
        {

            //remove if current index matches passed in index, and end function returning true
            if (currentIndex == index)
            {
                List1.Remove(currentNode);
                return true;
            }

            //set currentnode to next in collection, set currentindex to increment by one
            currentNode = currentNode.Next;
            currentIndex += 1;
        }
        //return false if never matched passed in index
        return false;
    }
    public static bool InsertAt(int index, object o, LinkedList<object> List1)
    {

    //set current index and node to 0, and first node
        int currentIndex = 0;
        LinkedListNode<object> currentNode = List1.First;

        while (currentNode != null)
        {

            //remove if current index matches passed in index, and end function returning true
            if (currentIndex == index)
            {
                List1.AddBefore(currentNode,o);
                return true;
            }

            //set currentnode to next in collection, set currentindex to increment by one
            currentNode = currentNode.Next;
            currentIndex += 1;
        }
        //return false if never matched passed in index
        return false;
    }
    public static void PrintReverse(LinkedList<object> List1)
    {
        LinkedListNode<object> currentNode = List1.Last;
        string Results = null;
        while (currentNode != null)
        {
            Results += currentNode.Value;
            currentNode = currentNode.Previous;

        }

        System.Console.WriteLine(Results);

    }

}
