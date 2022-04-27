namespace AlgoAssessment1;

public class Values_10_and_50
{
    public static List<int> Get_Value(List<int> list)
    {
        List<int> List_of_values = new List<int>();
        int ListLength = list.Count;

        if (ListLength == 256)
        {
            for(int x = 0; x < ListLength; x = x+10)
            {
                List_of_values.Add(list[x]);
            }
        }
        
        else if (ListLength == 2048)
        {
            for(int x = 0; x < ListLength; x = x+50)
            {
                List_of_values.Add(list[x]);
            }
        }
        else
        {
            Console.WriteLine("Cannot read file due its size");
        }
        return List_of_values;
    }
}