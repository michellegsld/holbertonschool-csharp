using System;

/// <summary> The generic Queue class. </summary>
class Queue<T>
{
    /// <summary> Must be an object of type Node. First in queue. </summary>
    public Node head = null;
    /// <summary> Must be an object of type Node. Last in queue. </summary>
    public Node tail = null;
    /// <summary> Keeps track of amount of nodes in queue. </summary>
    int count = 0;

    /// <summary> Method that returns the Queue's type. </summary>
    /// <returns>The type of whatever T is.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary> A public class to reguarding a Node. </summary>
    public class Node
    {
        /// <summary> Can be of any type, initially set to null. </summary>
        T value;
        /// <summary> Must be an object of type Node, initally set to null. </summary>
        public Node next = null;

        /// <summary> Constructor for new Node. </summary>
        /// <param name="val">What to set value to.</param>
        public Node(T val)
        {
            value = val;
        }
    }

    /// <summary> A public method. Creates a new Node to add at end of queue. </summary>
    /// <param name="val"> The value of the node. </param>
    public void Enqueue(T val)
    {
        Node newNode = new Node(val);

        if (head == null)
        {
            tail = head = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    /// <summary> A public method to return the count. </summary>
    /// <returns> The number of nodes in the queue. </returns>
    public int Count()
    {
        return count;
    }
}
