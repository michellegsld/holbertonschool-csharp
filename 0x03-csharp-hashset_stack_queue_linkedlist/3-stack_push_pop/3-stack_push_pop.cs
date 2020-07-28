using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);

        if (aStack.Count == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine("Top item: {0}", aStack.Peek());

        Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));

        if (aStack.Contains(search))
        {
            List<String> removeElements = new List<String>();

            foreach (String element in aStack)
            {
                removeElements.Add(element);
                if (element == search)
                    break;
            }
            foreach (String element in removeElements)
                aStack.Pop();
        }

        aStack.Push(newItem);

        return aStack;
    }
}
