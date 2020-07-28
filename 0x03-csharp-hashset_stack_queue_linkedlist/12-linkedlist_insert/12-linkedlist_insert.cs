using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        var currentNode = myLList.First;
        for (; currentNode != null; currentNode = currentNode.Next)
        {
            if (n > currentNode.Value)
            {
                myLList.AddAfter(currentNode, n);
                break;
            }
        }
        return currentNode;
    }
}
