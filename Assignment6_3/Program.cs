using System.Collections;

namespace Assignment6_3;

class Program
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList();

        //Adding all values
        list.Add(100); //Adding Integer
        list.Add("Ramu"); //Adding String
        list.Add(true); //Adding Boolean
        list.Add(DateTime.Now); //Adding Date
        list.Add(92.33); //Adding Double

        //Displaying all elements of list
        Console.WriteLine("Displaying all elements of list - ");
        Display(list);

        //Modifying the list by adding another value
        list.Add("C-DAC Acts");

        //Display After Modify
        Console.WriteLine("\nAfter Adding C-DAC Acts\n");
        Display(list);

        //Removing by value
        list.Remove(true);

        //After Romval Display
        Console.WriteLine("\nAfter removing true\n");
        Display(list);

        //Removing By Index
        list.RemoveAt(3);

        //After Removing 3rd element
        Console.WriteLine("\nAfter removing from position 3\n");
        Display(list);
    }

    static void Display(ArrayList list)
    {
        foreach(object item in list)
        {
            Console.WriteLine(item);
        }
    }
}

