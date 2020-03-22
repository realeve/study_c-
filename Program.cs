using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
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
    // public static void Main()
    // {
    //     var p = new Person("li", "bin");
    //     WriteLine($"username:{p.AllCaps()}");
    //     WriteLine($"user:{p}");


    //     var phrase = "the quick brown fox jumps over the lazy dog";

    //     var wordLength = from word in phrase.Split(' ') select word.Length;
    //     var average = wordLength.Average();
    //     WriteLine($"{average:F3}");
    // }
    // public static void Main()
    // {
    //     string s = "nullss";
    //     WriteLine(s?.Length);
    //     WriteLine("end");

    //     char? c = s?[0];
    //     WriteLine(c.HasValue);

    //     bool hasMore = s?.ToCharArray()?.GetEnumerator()?.MoveNext() ?? false;
    //     WriteLine(hasMore);

    //     try
    //     {
    //         string a = null;
    //         WriteLine(a.Length);
    //     }
    //     catch (Exception e) when (LogExeption(e))
    //     {

    //     }
    //     WriteLine("this is end");

    // }

    private static bool LogExeption(Exception e)
    {
        WriteLine($"\t in the log routine,caught {e.GetType()}");
        WriteLine($"\t Message:{e.Message}");
        return true;
    }


    // public static void Main()
    // {
    //     WriteLine(nameof(System.String));
    //     int j = 5;
    //     WriteLine(nameof(j));

    //     var names = new List<string>();
    //     WriteLine(nameof(names));
    // }
    public static void Main()
    {
        var msg = new Dictionary<int, string>
        {
            [404] = "page not found",
            [302] = "page moved",
            [500] = "server error"
        };

        WriteLine(msg[302]);
    }

}