
using System;
using System.Collections;


//problem1.2
#region
/* class Program
{
    static void Main()
    {
        ArrayList numbers = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8 };
        ArrayList middleElements = FindMiddleElements(numbers);
        Console.WriteLine("Original List: " + string.Join(", ", numbers.ToArray()));

        if (middleElements.Count == 0)
        {
            Console.WriteLine("The list is empty or has no middle element.");
        }
        else
        {
            Console.WriteLine("Middle Element(s): " + string.Join(", ", middleElements.ToArray()));
        }
    }

    static ArrayList FindMiddleElements(ArrayList list)
    {
        ArrayList result = new ArrayList();

        if (list.Count == 0)
        {
            return result;
        }

        int middleIndex = list.Count / 2;

        if (list.Count % 2 == 1)
        {
            result.Add(list[middleIndex]);
        }
        else
        {
            result.Add(list[middleIndex - 1]);
            result.Add(list[middleIndex]);
        }

        return result;
    }
}
*/
#endregion

//problem1.2
#region
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 34, 12, 67, 91, 23, 56, 78 };
        int largestElement = FindLargestElement(numbers);
        Console.WriteLine("Original List: " + string.Join(", ", numbers));

        if (largestElement != int.MinValue)
        {
            Console.WriteLine("Largest Element: " + largestElement);
        }
        else
        {
            Console.WriteLine("The list is empty.");
        }
    }

    static int FindLargestElement(List<int> list)
    {
        int count = list.Count;
        if (count == 0)
        {
            return int.MinValue;
        }

        int largestElement = list[0];
        for (int i = 1; i < count; i++)
        {
            int currentElement = list[i];
            if (currentElement > largestElement)
            {
                largestElement = currentElement;
            }
        }
        return largestElement;
    }
}
#endregion2