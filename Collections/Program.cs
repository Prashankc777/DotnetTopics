

using System.Collections;

#region -------- Array List Program ------- 
//class ArrayListProgram
//{
//    static void Main(string[] args)
//    {
//        ArrayList arrayList = new ArrayList(100);
//        arrayList.Add("S1");
//        arrayList.Add("S2");
//        arrayList.Add("S3");
//        arrayList.Add("S4");
//        arrayList.Add("S5");
//        Console.WriteLine(arrayList.Capacity);
//        Console.WriteLine(arrayList.Count);
//        arrayList.AddRange(new string[] { "A1 , A2" });
//        arrayList.Insert(2, "I1");

//        arrayList.Sort();
//        arrayList.Reverse();
//        foreach (string s in arrayList)
//        {
//            Console.WriteLine(s);
//        }

//        string[] ar = (string[])arrayList.ToArray(typeof(string));



//        Console.ReadLine();
//    }
//} 
#endregion

class HashTableProgram
{
    static void Main(string[] args)
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add(101, "S1");
        hashtable.Add(102, "S2");
        hashtable.Add(103, "S3");
        hashtable.Add(104, "S4");
        hashtable.Add(105, "S5");
        foreach (DictionaryEntry de in hashtable)
        {
            Console.WriteLine(de.Key + " " + de.Value);
        }
        Console.ReadLine();
    }
}
