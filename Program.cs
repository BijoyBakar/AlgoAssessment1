// See https://aka.ms/new-console-template for more information

using AlgoAssessment1;



List<int> intShare_1_256 = FileReading.Read_File("Share_1_256.txt");
List<int> intShare_2_256 = FileReading.Read_File("Share_2_256.txt");
List<int> intShare_3_256 = FileReading.Read_File("Share_3_256.txt");
List<int> intShare_1_2048 = FileReading.Read_File("Share_1_2048.txt");
List<int> intShare_2_2048 = FileReading.Read_File("Share_2_2048.txt");
List<int> intShare_3_2048 = FileReading.Read_File("Share_3_2048.txt");



List<int> list = new List<int>{};

double amount;

// get the user to choose the file
while (true)
{
    Console.WriteLine(@"
Please select the file you wish to perform algorithms on :
1) Share_1_256.txt      
2) Share_2_256.txt      
3) Share_3_256.txt  
4) Share_1_2048.txt      
5) Share_2_2048.txt      
6) Share_3_2048.txt 
    
Enter: ");


    int Userinput = Convert.ToInt32(Console.ReadLine());
    if (Userinput == 1)
    {
        list = intShare_1_256;
    }
    else if (Userinput == 2)
    {
        list = intShare_2_256;
    }
    else if (Userinput == 3)
    {
        list = intShare_3_256;
    }
    else if (Userinput == 4)
    {
        list = intShare_1_2048;
    }
    else if (Userinput == 5)
    {
        list = intShare_2_2048;
    }
    else if (Userinput == 6)
    {
        list = intShare_3_2048;
    }


    Console.Write(@"
Please choose which algorithm you wish to use:
1) Sorting Algorithms           
2) Searching Algorithms

Enter: ");
    



    int algorithm_userinput = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");
    

    if (algorithm_userinput == 1)
    {
        
        Console.WriteLine("Merge Sort Ascending ");
        List<int> Mergesorting1 = MergeSort.MergeSortAscending(list);
        List<int> merge = Values_10_and_50.Get_Value(Mergesorting1);

        foreach (int num in merge)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine(" ");
        Console.WriteLine(" ");

        Console.WriteLine("Bubble Sort Ascending");
        List<int> Bubblesorting1 = BubbleSort.BubbleSortAscending(list);
        List<int> bubble10 = Values_10_and_50.Get_Value(Bubblesorting1);
        foreach (int num in bubble10)
        {
            Console.Write(num + " ");
        }



        Console.WriteLine(" ");
        Console.WriteLine(" ");

        List<int> Insertionsorting1 = InsertionSort.InsertionSortAscend(list);
        List<int> Insertion10 = Values_10_and_50.Get_Value(Insertionsorting1);
        Console.WriteLine("Insertion Sort Ascending ");

        foreach (int num in Insertion10)
        {
            Console.Write(num + " ");
        }
        
        Console.WriteLine(" ");
        Console.WriteLine(" ");

        List<int> MergeSorting2 = MergeSort.MergeSortDescending(list);
        List<int> merge2 = Values_10_and_50.Get_Value(MergeSorting2);
        Console.WriteLine("Merge Sort Descending ");

        foreach (int num in merge2)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine(" ");
        Console.WriteLine(" ");

        List<int> Bubblesorting2 = BubbleSort.BubbleSortDescending(list);
        List<int> bubble2 = Values_10_and_50.Get_Value(Bubblesorting2);
        Console.WriteLine("Bubble Sort Descending ");

        foreach (int num in bubble2)
        {
            Console.Write(num + " ");
        }


        Console.WriteLine(" ");
        Console.WriteLine(" ");

        List<int> Insertionsorting2 = InsertionSort.InsertionSortDescend(list);
        List<int> insertion2 = Values_10_and_50.Get_Value(Insertionsorting2);
        Console.WriteLine("Insertion Sort Descending");

        foreach (int num in insertion2)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine(" ");
        
        
    }
    

    else if (algorithm_userinput == 2)
    {
            MergeSort.MergeSortAscending(list);
            BubbleSort.BubbleSortAscending(list);
            InsertionSort.InsertionSortAscend(list);
            Console.WriteLine("The list: ");
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            
            Console.WriteLine("Please enter the number you would like to find index for");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(Linear Search) The index is: " + LinearSearch.LinearSearching(list, index));
            Console.WriteLine("(Binary Search) The index is: " + BinarySearch.Binary_Search(list, index));

    }
    else
    {
        
        
    }

        

}


































/*
Console.WriteLine("Merge Sort Ascending ");
List<int> Mergesorting1 = MergeSort.MergeSortAscending(intShare_1_256);
List<int> merge = Values_10_and_50.Get_Value(Mergesorting1);

foreach (int num in merge)
{
   Console.Write(num + " ");
}

Console.WriteLine(" ");
Console.WriteLine(" ");

Console.WriteLine("Bubble Sort Ascending");
List<int> Bubblesorting1 = BubbleSort.BubbleSortAscending(intShare_1_256);
List<int> bubble10 = Values_10_and_50.Get_Value(Bubblesorting1);
foreach (int num in bubble10)
{
   Console.Write(num + " ");
}



Console.WriteLine(" ");
Console.WriteLine(" ");

List<int> Insertionsorting1 = InsertionSort.InsertionSortAscend(intShare_1_256);
List<int> Insertion10 = Values_10_and_50.Get_Value(Insertionsorting1);
Console.WriteLine("Insertion Sort Ascending ");

foreach (int num in Insertion10)
{
   Console.Write(num + " ");
}


Console.WriteLine("\n");
Console.WriteLine("Please enter the number you would like to find index for");
int index = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Linear Search - The index is: "+LinearSearch.LinearSearching(Mergesorting1,index));
Console.WriteLine("Binary Search - The index is: "+BinarySearch.Binary_Search(Mergesorting1,index));

Console.WriteLine(" ");
Console.WriteLine(" ");

/*

List<int> MergeSorting2 = MergeSort.MergeSortDescending(IntNumbers1);

Console.WriteLine("Merge Sort Descending ");

foreach (int num in MergeSorting2)
{
   Console.Write(num + " ");
}

Console.WriteLine(" ");
Console.WriteLine(" ");

List<int> Bubblesorting2 = BubbleSort.BubbleSortDescending(IntNumbers1);

Console.WriteLine("Bubble Sort Descending ");

foreach (int num in Bubblesorting2)
{
   Console.Write(num + " ");
}


Console.WriteLine(" ");
Console.WriteLine(" ");

List<int> Insertionsorting2 = InsertionSort.InsertionSortDescend(IntNumbers1);

Console.WriteLine("Insertion Sort Descending");

foreach (int num in Insertionsorting2)
{
   Console.Write(num + " ");
}


*/





/*
Console.WriteLine("\n");
Console.WriteLine("Please enter the number you would like to find index for");
int index = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The index is: "+LinearSearch.LinearSearching(Bubblesorting1,index));
Console.WriteLine("The index is: "+BinarySearch.Binary_Search(Insertionsorting1,index));
*/
//var arr = new[] {IntNumbers1};
//var lol = ("The index is: "+BinarySearch.IntArrayBinarySearch(arr,index));
//Console.WriteLine("The index is: "+BinarySearch.IntArrayBinarySearch(IntNumbers1,index));


