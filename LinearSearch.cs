namespace AlgoAssessment1;

public class LinearSearch
{
    public static int LinearSearching(List<int> list, int value)
    {

        List<int> list_of_index = new List<int>();
        int index = 0;
        int smallvariance = Math.Abs(list[0] - value);
        int List_count = list.Count;
        for (int x = 0; x < List_count; x++)
        {
            int i= value - list[x];
            int thedifference = Math.Abs(i);

            if (thedifference == 0)
            {

                list_of_index.Add(x);
                

            }
            else if (thedifference < smallvariance)
            {
                smallvariance = thedifference;
                index = x;
                
            }
            else if (value > list[x])
            {
                
                Math.Abs(value + list[1]);
                index = x + 1;
                
            }
            

        }

        int countofindex = list_of_index.Count;
        if (countofindex == 0)
        {
            string errormessage = ("The number entered cannot be found in the list");
            Console.WriteLine(errormessage);
            Console.Write("This value " + value + " shows up " + countofindex + " times and closest index are:  ");
        }
        else if (countofindex >= 1)
        {
            Console.Write("This value " + value + " shows up "+countofindex+" times at the following index: ");
        }
        
        foreach (var i in list_of_index)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine(" ");
        
        

        return index;
    }
}


    


// find the value of the index before the current index 
// if the counter is greater than 1 then check previous index and if they are the same number as the cuurent 
// index then print it out