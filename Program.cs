using static System.Console;
public class Person
{
    public string strFirst { get; }
    public string strLast { get; }

    public Person(string first, string last)
    {
        strFirst = first;
        strLast = last;
    }

    public override string ToString() => $"{strFirst} {strLast}";
    public string AllCaps() => ToString().ToUpper();

}

public class Program
{
    public static void Main()
    {
        var p = new Person("li", "bin");
        WriteLine("username:" + p.AllCaps());
        WriteLine("user:" + p);
    }
}