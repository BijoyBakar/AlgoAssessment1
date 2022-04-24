namespace AlgoAssessment1;

public class FileReading
{
    public static List<int> Read_File(string filename)
    {
        string[] strList = File.ReadAllLines("../../../Textfiles/" + filename);
        List<int> intList = new List<int>();

        foreach (string num in strList)
        {
            intList.Add(Int32.Parse(num));
        }
        return intList;
    }

}

