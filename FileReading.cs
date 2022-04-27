namespace AlgoAssessment1;

public class FileReading
{
    public static List<int> Read_File(string filename)
    {
        string[] stringList = File.ReadAllLines("../../../Textfiles/" + filename);
        List<int> intgerList = new List<int>();

        foreach (string x in stringList)
        {
            intgerList.Add(Int32.Parse(x));
        }
        return intgerList;
    }

}

