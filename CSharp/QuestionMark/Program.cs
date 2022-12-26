// format code ctrl + k + d
using ListAndLINQ;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

double a = 0.1;
double b = 0.2;
Console.WriteLine(a + b == 0.3 ? "True" : "Flase");

float c = 0.6f;
decimal d = 0.1M;
decimal e = 0.2M;
Console.WriteLine(d + e == 0.3M ? "True" : "Flase");

// ?: => ternary operator

// ? nullable value type
string? fullname = null;
//int i = null;
//c# cũ
//Nullable<int> i = null;
//c# mới
bool? check = null;

//int lenght = fullname != null ? fullname.Length : 0;

//int? lenght = fullname is not null ? fullname.Length : null;

//null-conditional operator ?
//tương tự != , fullname mà khác null thì trả về vế sau
int? lenght = fullname?.Length;

//null-coalescing ??
//tương tự dấu ==, fullname bằng null thì trả về vế sau

int? chieudai = fullname?.Length ?? 0;



using ListAndLINQ;
using System.Collections;
using System.Diagnostics;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
List<Student> list = new() {
    new Student(){RollNumber = 1 ,FullName ="Trung Nghĩa",Section = "Dãy số 1",HostelNumber = 1},
    new Student(){RollNumber = 2 ,FullName ="Vuongw",Section = "Dãy số 1",HostelNumber = 1},
    new Student(){RollNumber = 3 ,FullName ="Phú",Section = "Dãy số 1",HostelNumber = 1},
    new Student(){RollNumber = 4 ,FullName ="Việt",Section = "Dãy số 1",HostelNumber = 1},
    new Student(){RollNumber = 5 ,FullName ="Nguyên",Section = "Dãy số 1",HostelNumber = 1},
    new Student(){RollNumber = 6 ,FullName ="Hùng",Section = "Dãy số 2",HostelNumber = 2},
    new Student(){RollNumber = 7 ,FullName ="Lâm",Section = "Dãy số 2",HostelNumber = 2},
    new Student(){RollNumber = 8 ,FullName ="Huân",Section = "Dãy số 2",HostelNumber = 2},
    new Student(){RollNumber = 9 ,FullName ="Lợi",Section = "Dãy số 2",HostelNumber = 2},
    new Student(){RollNumber = 10 ,FullName ="Thảo",Section = "Dãy số 2",HostelNumber = 2}
};


//stopwatch 
//Stopwatch sw = new();
//sw.Restart();


//dùng IEnumerator
//IEnumerator<Student> e = list.GetEnumerator();
//while (e.MoveNext())
//{
//    Console.WriteLine(e.Current);
//}

//foreach (var stu in list)
//{
//    Console.WriteLine(stu);
//}

//Console.WriteLine($"foreach time: {sw.ElapsedMilliseconds}");
//sw.Restart();

//tất cả các dạng của collection đều có mẫu để duyệt qua dữ liệu mà không dùng for hay foreach => ienumarator
//nếu dùng foreach nó sẽ về ienumerator r mới chạy


//LINQ => Language Intergrate Query
//Query là truy vấn

//lINQ to sql
//LINQ to Object
//LINQ to xml, json
//parallel linq => plinq { cho các luồng chạy cùng thời điểm} luồng không tranh giành

//select from where group by having order
//from where group by having order => select

//LINQ To Object
//Có 2 dạng: 
//Style 1 theo trường phái sql => query syntax, dễ học, dễ hiểu
//Style 2 theo trường phái lamda => methord syntax, khó học, rất khó để hiểu

//liệt kê tất cả sinh viên với mã sinh viên phải lớn hơn 2
IEnumerator<Student> e = list.GetEnumerator();
while (e.MoveNext())
{
    if (e.Current.RollNumber > 2)
        Console.WriteLine(e.Current);
}

//IEnumerator dùng để duyệt thường
//IEnumerable dùng để duyệt cho LINQ
Console.WriteLine("============================");
//linq to object stye 1
//tìm tổng số sinh viên qua list
//IEnumerable<Student> t = from s in list
//                         where s.RollNumber > 2
//                         select s;
//foreach (var st in t)
//{
//    Console.WriteLine(st);
//}
//Console.WriteLine(t.Count());

//linq object style 1 rút gọn
foreach (var st in from s in list
                   where s.RollNumber > 2
                   select s)
{
    Console.WriteLine(st);
}

////linq to object style 2
//var l = list.Where(stu => stu.RollNumber > 2);
//foreach (var s in l)
//{
//    Console.WriteLine(l);
//}
//LinQ to Object style 2 rút gọn
foreach (var s in list.Where(stu => stu.RollNumber > 2))
{
    Console.WriteLine(s);
}

//các phương thức có sẳn trong list
//list.ForEach(Console.WriteLine);

//list.ForEach(stu => {
//    if (stu.RollNumber > 2)
//        Console.WriteLine(stu);
//});

//kết hợp lambda với phương thứ có sẵn của list
//list.Where(stu => stu.RollNumber > 2)
//    .ToList()
//    .ForEach(Console.WriteLine);

//var r = from stu in list
//        where stu.RollNumber > 2
//        select new //anonymous type
//        {
//            stu.RollNumber,
//            stu.FullName
//        };
//r.ToList().ForEach(Console.WriteLine);  

//var r = from stu in list
//        where stu.RollNumber > 2
//        select new
//        {
//            StudentDetail = $"{stu.RollNumber} : {stu.FullName}",
//            StudentRoom = $"{stu.Section} = {stu.HostelNumber}"
//        };
//r.ToList().ForEach(Console.WriteLine);

list.Select(stu => new
{
    StudentDetail = $"{stu.RollNumber} : {stu.FullName}",
    StudentRoom = $"{stu.Section} = {stu.HostelNumber}"
}).ToList().ForEach(Console.WriteLine);

foreach (var stu in list)
{
    Console.WriteLine(stu);
}

IEnumerable enu = list.GetEnumerator();
while (enu.MoveNext())
{

}

//từ khi có linq
var t = from stu in list
        select stu;

// lần đầu tiên thực thi trên server và trả về bộ nhớ 

// select * from list where rillnumber > 2  
IEnumerable<Student> i = from stu in list
                         select stu;
// là vào bộ nhớ loại bỏ chỉ lấy 2 dòng đầu tiên  
i = i.Take(2);
//=================================================
// lần đầu tiên thực thi trên server và trả về bộ nhớ 
//select*from list where rollnumber > 2
IQueryable<Student> u = from stu in list.AsQueryable()
                        where stu.RollNumber > 2
                        select stu;

// select top(2) * from list where rollnumber >2 
//sẽ chạy e=lên server lần nữa

//u = u.Take(2);

//var k = from stu in list 
//        where stu.RollNumber > 2
//        select stu;
//k.ToList().ForEach(Console.WriteLine);

//sắp xếp


var obj1 = from stu in list
           where stu.RollNumber > 5
           orderby stu.Section descending, stu.HostelNumber ascending
           select stu;

var obj2 = list.Where(stu => stu.RollNumber > 5)
                .OrderByDescending(stu => stu.Section)
                .ThenBy(stu => stu.HostelNumber);