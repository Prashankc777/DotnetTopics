

using System.Collections;

#region -------- Array List Program ------- 
class ArrayListProgram
{
    static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList(100);
        arrayList.Add("S1");
        arrayList.Add("S2");
        arrayList.Add("S3");
        arrayList.Add("S4");
        arrayList.Add("S5");
        Console.WriteLine(arrayList.Capacity);
        Console.WriteLine(arrayList.Count);
        arrayList.AddRange(new string[] { "A1 , A2" });
        arrayList.Insert(2, "I1");

        arrayList.Sort();
        arrayList.Reverse();
        foreach (string s in arrayList)
        {
            Console.WriteLine(s);
        }

        string[] ar = (string[])arrayList.ToArray(typeof(string));



        Console.ReadLine();
    }
}
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


public class Employee : IComparable
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return Id + " " + Name;
    }

    public int CompareTo(object? obj)
    {
        Employee other = (Employee)obj;
        if (obj is null) return 0;
        if (this.Id > other.Id)
        {
            return 1;
        }
        else if (this.Id < other.Id)
        {
            return -1;
        }
        else
        {
            return 0;
        }

       
    }
}


public class EmployeeComparer : IComparer
{
    public int Compare(object x, object y)
    {
        Employee first = (Employee)x;
        Employee second = (Employee)y;
        return second.Id - first.Id;
    }
}
class EmplyeeCollectionProgram
{
    private static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList
        {
            new Employee { Id = 101, Name = "E1" },
            new Employee { Id = 102, Name = "S2" },
            new Employee { Id = 103, Name = "S3" },
            new Employee { Id = 104, Name = "S4" },
            new Employee { Id = 105, Name = "S5" }
        };

        EmployeeComparer comparer = new EmployeeComparer();
        arrayList.Sort(comparer);

        foreach (Employee e in arrayList)
        {
            Console.WriteLine(e.ToString());
        }

        // This is how we can use IEnumerator to iterate through the collection
        IEnumerator enumerator = arrayList.GetEnumerator();
        enumerator.MoveNext(); // move to next element in the collection

        while (enumerator.MoveNext())
        {
            Employee employee = (Employee)enumerator.Current;
            Console.WriteLine(employee);
        }


        Console.ReadLine();
    }
}



