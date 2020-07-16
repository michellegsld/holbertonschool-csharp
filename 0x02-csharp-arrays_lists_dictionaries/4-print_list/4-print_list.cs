using System;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> new_list;

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }

        for (int i = 0; i < size; i++)
            new_list.Insert(i, i);

        return new_list;
    }
}
