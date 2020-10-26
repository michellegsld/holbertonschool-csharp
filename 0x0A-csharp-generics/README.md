## README for 0x0A-csharp-generics ##
### A directory within the holbertonschool-csharp repo ###

| File Name | Description |
| --------- | ----------- |
| 0-queue/ <br> 0-queue/0-queue.csproj <br> 0-queue/queue.cs | **Task: 0. Queue** <br> A method that returns the Queue's type. The class name is `Queue<T>` with a prototype of `CheckType()`, without using `System.Collections` or `System.Collections.Generic`. |
| 1-enqueue/ <br> 1-enqueue/1-enqueue.csproj <br> 1-enqueue/queue.cs | **Task: 1. Enqueue** <br> Builds off the previous task by adding a public class called `Node` within `Queue<T>`. `Node` contains the properties `value` and `next`, while `Queue<T>` contains `head`, `tail`, and `count`. The method `Enqueue()` was added to `Queue` with the intent of creating a new `Node` and adding it to the end of the queue and updating `count` each time. The method `Count()` was also added to return the number of nodes in Queue. |
| 2-dequeue/ <br> 2-dequeue/2-dequeue.csproj <br> 2-dequeue/queue.cs | **Task: 2. Dequeue** <br> Builds off the previous task, adding a method called `Dequeue()` to `Queue<T>` in order to remove the first node in the queue while returning its value. |
| 3-peek/ <br> 3-peek/3-peek.csproj <br> 3-peek/queue.cs | **Task: 3. Peek** <br> Builds off the previous task and adds a method called `Peek()` to the class `Queue<T>`, which returns the value of the first node of the queue without removing the node. |
| 4-print/ <br> 4-print/4-print.csproj <br> 4-print/queue.cs | **Task: 4. Print** <br> Builds off the previous task by adding a method called `Print()` to the class `Queue<T>`, which prints the queue from the head. |
| 5-concatenate/ <br> 5-concatenate/5-concatenate.csproj <br> 5-concatenate/queue.cs | **Task: 5. Concatenate** <br> Builds off the previous task by adding a method called `Concatenate()`, which concatenates all the values in the queue if it is of type `String` or `Char`. |
