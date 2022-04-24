namespace AlgoAssessment1;

public class InsertionSort
{
    public static List<int> InsertionSortAscend(List<int> list)
    {
        int List_Count = list.Count;
        for (int val_x = 0; val_x <= List_Count - 2; val_x++)
        {
            for (int val_y = val_x + 1; val_y > 0; val_y--)
            {
                if (list[val_y - 1] > list[val_y])
                {
                    int temp = list[val_y - 1];
                    list[val_y - 1] = list[val_y];
                    //(list[val_y - 1], list[val_y]) = (list[val_y], list[val_y - 1]);
                    list[val_x] = temp;
                }
            }
        }
        return list;
    }
    
    public static List<int> InsertionSortDescend(List<int> list)
    {
        int List_Count = list.Count;
        for (int val_x = 0; val_x <= List_Count - 2; val_x++)
        {
            for (int val_y = val_x + 1; val_y > 0; val_y--)
            {
                if (list[val_y - 1] < list[val_y])
                {
                    int temp = list[val_y - 1];
                    list[val_y - 1] = list[val_y];
                    //(list[val_y - 1], list[val_y]) = (list[val_y], list[val_y - 1]);
                    list[val_x] = temp;
                }
            }
        }
        return list;
    }
}