namespace AlgoAssessment1;

public class LinearSearch
{
    public static int LinearSearching(List<int> list, int value)
    {
        int index = 0;
        int variance = list[0];
        int List_count = list.Count;

        for (int x=0; x < List_count; x++)
        {
            int subtract = value - list[x];
            int i = Math.Abs(subtract);
            if (i <= variance)
            {
                variance = Math.Abs(subtract);
                index = x;
            }
        }
        return index;
    }
}