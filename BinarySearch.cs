namespace AlgoAssessment1;

public class BinarySearch
{
    public static int Binary_Search(List<int> list, int value)
    {
        int lower = 0;
        int upper = list.Count-1;
        int middle = 0;
        int position = 0;

        while (lower <= upper)
        {
            middle = (lower + upper) / 2;
            if (value < list[middle])
            {
                upper = middle - 1;
            }
            else if (value > list[middle])
            {
                lower = middle + 1;
            }
            else return middle;
        }
        
        /*
        if (list[middle] != value)
        {
            string errormessage = ("The number entered cannot be found in the list");
            Console.WriteLine(errormessage);
            Console.Write("This value " + value + " shows up 0 times and the closest index are:  " + middle);
            Console.WriteLine(" ");
        }
        */




        return middle;
    }
}