namespace AlgoAssessment1;

public class BubbleSort
{
    public static List<int> BubbleSortAscending(List<int> list)
    {
        for (int j = 0; j <= list.Count-2; j++)
        {
            for (int i = 0; i <= list.Count-2; i++)
            {
                if (list[i] > list[i+1])
                {
                    (list[i], list[i + 1]) = (list[i + 1], list[i]);
                }
            }
        }
        return list;
    }
    
    public static List<int> BubbleSortDescending(List<int> list)
    {
        for (int j = 0; j <= list.Count-2; j++)
        {
            for (int i = 0; i <= list.Count-2; i++)
            {
                if (list[i] < list[i+1])
                {
                    (list[i], list[i + 1]) = (list[i + 1], list[i]);
                }
            }
        }
        return list;
    }
}