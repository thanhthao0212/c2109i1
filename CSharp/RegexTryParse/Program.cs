
using System.Text.RegularExpressions;

//string? str = null;
//Console.WriteLine("vui long nhap so :");
//str = Console.ReadLine();

//var formula = new Regex("^[0,9]+$");

//if (formula.IsMatch(str))
//{
//    //int resul = int.Parse(str);
//    int resul = Convert.ToInt32(str);
//    Console.WriteLine(++resul);
//}

//if (int.TryParse(str, out int i))
//{
//    Console.WriteLine($"i la so :{i}");
//}

Console.WriteLine("vui long nhap so luong");
string? amount = Console.ReadLine();
//dùng try catch
//mệnh đề guard clause
//====================================
if (string.IsNullOrEmpty(amount))
{
    return;
}

// làm cái gì đó 
//====================================
if (amount != null)
{
    // lam gi do 
}

try
{
    int total = int.Parse(amount);
    if (total <= 0) throw new Exception("phai lon hon 0");
    Console.WriteLine($"{nameof(total)}={total}");
}
catch (Exception) when (amount.Contains("$"))
{
    Console.WriteLine("chuoi ko duoc co dau $");
}
catch (Exception e)
{
    Console.WriteLine($"{e.GetType()},{e.Message}");
}