namespace AlgoAssessment1;

public class LinearSearch
{
    public static int LinearSearching(List<int> list, int value)
    {
        int index = 0;
        int variance = list[0];
        int List_count = list.Count;
        int count = 0;
        for (int x=0; x < List_count; x++)
        {
            int subtract = value - list[x];
            int i = Math.Abs(subtract);
            
            if (i <= variance)
            {
                
                variance = Math.Abs(subtract);
                index = x;
                count++;

            }
            else if (value > list[x])
            {
                Math.Abs(value + list[1]);
                index = x + 1;
            }


        }
        Console.WriteLine("The number entered appears "+count+" times");
        if (count == 0)
        {
            Console.WriteLine("The closest index are: ");
            
        }
        
        return index;
    }
}