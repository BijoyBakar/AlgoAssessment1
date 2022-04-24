namespace AlgoAssessment1;

public class Values_10_and_50
{
    public static List<int> Get_Value(List<int> list)
    {
        List<int> values = new List<int>();

        if (list.Count == 256)
        {
            for(int i = 0; i < list.Count; i = i+10)
            {
                values.Add(list[i]);
            }
        }
        else if (list.Count == 2048)
        {
            for(int i = 0; i < list.Count; i = i+50)
            {
                values.Add(list[i]);
            }
        }
        return values;
    }
}