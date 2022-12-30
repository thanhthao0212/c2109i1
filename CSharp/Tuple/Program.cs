using UsingTuple;

Person per = new()
{
    Id = 1,
    FirstName = "thao",
    LastName = "Ho"
};
Console.WriteLine(per.Id);
Console.WriteLine(per.FirstName);

//dùng tuple không cần đến class(struct)
ValueTuple<int, string, string> p1 = (1, "thao", "Ho");
Console.WriteLine(p1.Item3);

//mới hơn
(int, string, string) p2 = (1, "thao", "Ho");
Console.WriteLine(p2.Item3);

//dùng var
var p3 = (1, "thao", "Ho"); //value tuple

var p4 = (1); //variable int p4=1;

//net core dùng name thay thế cho các item1,item2,...

(int id, string firstname, string lastname) p5 = (1, "thao", "Ho");
Console.WriteLine(p5.lastname);

//hoặc dùng name phia trước
var p6 = (id: 1, firstname: "thao", lastname: "Ho");
Console.WriteLine(p6.lastname);
p6.firstname = "a";
Console.WriteLine(p6.firstname);

//không phải là tuple => anonymous type
var p7 = new { id = 1, firstname = "thao", lastname = "Ho" };
Console.WriteLine(p7.firstname);