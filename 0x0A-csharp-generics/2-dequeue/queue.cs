using System;

/// <summary>
/// The generic Queue class.
/// </summary>
/// <typeparam name="T">The generic type parameter.</typeparam>
class Queue<T>
{
    /// <summary>
    /// Must be an object of type Node.
    /// </summary>
    public Node head = null;
    /// <summary>
    /// Must be an object of type Node.
    /// </summary>
    public Node tail = null;
    /// <summary>
    /// Keeps track of amount of nodes.
    /// </summary>
    int count = 0;

    /// <summary>
    /// Method that returns the Queue's type.
    /// </summary>
    /// <returns>The type of whatever T is.</returns>
    public Type CheckType() {
        return typeof(T);
    }

    /// <summary>
    /// A public class with a couple of properties.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Can be of any type, initially set to null.
        /// </summary>
        T value;
        /// <summary>
        /// Must be an object of type Node, initally set to null.
        /// </summary>
        public Node next = null;

        /// <summary>
        /// Constructor for new Node.
        /// </summary>
        /// <param name="val">What to set value to.</param>
        public Node (T val) {
            value = val;
        }
    }

    /// <summary>
    /// A public method.
    /// </summary>
    /// <returns>The number of nodes in the queue.</returns>
    public int Count() {
        return count;
    }

    /// <summary>
    /// Creates a new node and adds it to the end of queue.
    /// </summary>
    /// <param name="val">The value of the node.</param>
    public void Enqueue(T val)
    {
        Node newNode = new Node(val);

        if (head == null) {
            tail = head = newNode;
        } else {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    /// <summary>
    /// Removes the null at the head of the queue.
    /// </summary>
    /// <returns>Returns value.</returns>
    public T Dequeue()
    {
        if (head == null) {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = head.value;
        head = head.next;
        count--;
        return value;
    }
}
