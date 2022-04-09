namespace AlgoAssessment1;

public class MergeSort
{
    public static void Msort(Span<int> listvalue)
    {
        int middle = listvalue.Length / 2;
        if (listvalue.Length > 1)
        {
            Msort(listvalue.Slice(0,middle));
            Msort(listvalue.Slice(middle));
            Merge(listvalue, middle);
        }

        
        Console.WriteLine(middle);
        
    }

    private static void Merge(Span<int> result, int StartOfTheRightHalf)
    {
        var unsorted = result.ToArray();
        var left = 0;
        var right = StartOfTheRightHalf;
        var offset = 0;
        while (left <StartOfTheRightHalf && right < unsorted.Length)
        {
            if (unsorted[left] <= unsorted[right])
            {
                result[offset] = unsorted[left];
                left++;
            }
            else
            {
                result[offset] = unsorted[right];
                right++;
            }

            offset++;

        }

        while (left < StartOfTheRightHalf)
        {
            result[offset] = unsorted[left];
            left++;
            offset++;
        }
        while (right < unsorted.Length)
        {
            result[offset] = unsorted[right];
            right++;
            offset++;
        }
        
        
    }
    
}