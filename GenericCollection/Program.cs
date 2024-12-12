using System.Collections;

class ArrayListProgram
{
    static void Main(string[] args)
    {
        List<string> arrayList = new List<string>(100);
        arrayList.Add("S1");
        arrayList.Add("S2");
        arrayList.Add("S3");
        arrayList.Add("S4");
        arrayList.Add("S5");
            arrayList.AddRange(new string[] { "A1 , A2" });
        arrayList.Insert(2, "I1");

        arrayList.Sort();
        arrayList.Reverse();
        foreach (string s in arrayList)
        {
            Console.WriteLine(s);
        }

        Console.ReadLine();
    }
}