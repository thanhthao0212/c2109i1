using System.Collections;
using System.Collections.Generic;

string[] arrs = { "ho", "thanh", "thao" };

foreach (var i in arrs)
{
    Console.WriteLine($"{i} chieu dai {i.Length}");
}

//int i = 0;
//lenght = arrs.Length ;
//while(i <lenght)
//{
//    Console.WriteLine($"{arrs[i]} chieu dai {arrs[i].Length}");
//    i++;
//}

IEnumerator e = arrs.GetEnumerator();
while(e.MoveNext())
{
    string s = (string)e.Current;
    Console.WriteLine($"{s} chieu dai {s.Length}");
}