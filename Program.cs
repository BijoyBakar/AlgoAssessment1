// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information

// reading the file from the text file and storing it as a string 
string [] stringnumbers1 = File.ReadAllLines("../../../Textfiles/Share_1_256.txt");
string [] stringnumbers2 = File.ReadAllLines("../../../Textfiles/Share_2_256.txt");
string [] stringnumbers3 = File.ReadAllLines("../../../Textfiles/Share_3_256.txt");
// creating a new integer list 
List<int> IntNumbers1 = new List<int>();
List<int> IntNumbers2 = new List<int>();
List<int> IntNumbers3 = new List<int>();
// iterating through the string number list
foreach (string i in stringnumbers1)
{
    // adding number to the int number list 
    IntNumbers1.Add(Int32.Parse(i));

}
foreach (string i in stringnumbers2)
{
    // adding number to the int number list 
    IntNumbers2.Add(Int32.Parse(i));

}
foreach (string i in stringnumbers3)
{
    // adding number to the int number list 
    IntNumbers3.Add(Int32.Parse(i));

}



foreach (int j in IntNumbers1)
{
    Console.WriteLine(j);
}