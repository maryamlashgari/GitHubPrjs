using System;
// در اينجا اعلان مي‌گردد. delegate
public delegate int Comparer(object obj1, object obj2);
public class Name
{
    public string FirstName = null;
    public string LastName = null;
    public Name(string first, string last)
    {
        FirstName = first;
        LastName = last;
    }
    // delegate method handler
    public static int CompareFirstNames(object name1, object name2)
    {
        string n1 = ((Name)name1).FirstName;
        string n2 = ((Name)name2).LastName;
        if (String.Compare(n1, n2) > 0)
        {
            return 1;
        }
        else if (String.Compare(n1, n2) < 0)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
    public override string ToString()
    {
        return FirstName + " " + LastName;
    }
}//End of Class Name





class SimpleDelegate
{
    Name[] names = new Name[5];
    public SimpleDelegate()
    {
        names[0] = new Name("Meysam", "Ghazvini");
        names[1] = new Name("C#‎‎", "Persian");
        names[2] = new Name("Csharp", "Persian");
        names[3] = new Name("Xname", "Xfamily");
        names[4] = new Name("Yname", "Yfamily");
    }
    static void Main(string[] args)
    {
        SimpleDelegate sd = new SimpleDelegate();
        // delegate ساخت نمونه‌اي جديد از
        Comparer cmp = new Comparer(Name.CompareFirstNames);
        Console.WriteLine("\nBefore Sort: \n");
        sd.PrintNames();
        sd.Sort(cmp);
        Console.WriteLine("\nAfter Sort: \n");
        sd.PrintNames();
    }
    public void Sort(Comparer compare)
    {
        object temp;
        for (int i = 0; i < names.Length; i++)
        {
            for (int j = i; j < names.Length; j++)
            {
                //همانند يك متد استفاده مي‌شود compare از
                if (compare(names[i], names[j]) > 0)
                {
                    temp = names[i];
                    names[i] = names[j];
                    names[j] = (Name)temp;
                }
            }
        }
    }
    public void PrintNames()
    {
        Console.WriteLine("Names: \n");
        foreach (Name name in names)
        {
            Console.WriteLine(name.ToString());
        }
    }
}