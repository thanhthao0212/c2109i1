using System.Text.RegularExpressions;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
List<Students> list = new();
string? a = null;
var num = new Regex("^[0-9]+$");
var chars = new Regex("^([a-zA-Z]\\s*)+$");
var bools = new Regex("^[0-1]+$");
var day = new Regex("^\\d{4}[-|/]\\d{2}[-|/]\\d{2}$");
do
{
    Menu: Console.WriteLine("1: tạo sinh viên. ");
    Console.WriteLine("2: xóa sinh viên. ");
    Console.WriteLine("3: tìm kiếm sinh viên. ");
    Console.WriteLine("4: cập nhật sinh viên. ");
    Console.WriteLine("5: hiễn thị sinh viên. ");
    Console.WriteLine("6: hiễn thị sinh viên giảm dần. ");
    Console.WriteLine("7: thoát.");
    a = Console.ReadLine();
    if (!num.IsMatch(a))
    {
        goto Menu;
    }else if (Int32.Parse(a) > 7)
    {
        goto Menu;
    }
    else
    {
        switch (Int32.Parse(a))
        {
            case 1:
                {
                    Students stu = new();
                Id: Console.WriteLine("nhập id sinh viên:");
                    string? check_id = Console.ReadLine();
                    if (!num.IsMatch(check_id)) { goto Id; };
                    stu.Id = Int32.Parse(check_id);
                Name: Console.WriteLine("nhập tên sinh viên:");
                    stu.Name = Console.ReadLine();
                    if (!chars.IsMatch(stu.Name)) { goto Name; };
                Gender: Console.WriteLine("nhập giới tính sinh viên(1:Nam hoặc 0:Nữ):");
                    string? check_gender = Console.ReadLine();
                    if (!bools.IsMatch(check_gender)) { goto Gender; };
                    stu.IsGender = check_gender == "1" ? true : false;
                BrithDay: Console.WriteLine("nhập ngày sinh của sinh viên:");
                    string? check_brithday = Console.ReadLine();
                    if (!day.IsMatch(check_brithday)) { goto BrithDay; };
                    stu.BrithDay = DateTime.Parse(check_brithday);
                    list.Add(stu);
                    break;
                }
            case 2:
                {
                    var count = list.Select(x => x.Id).Count();
                Delete: Console.WriteLine("nhập id sinh viên:");
                    string id_delete = Console.ReadLine();
                    if (!num.IsMatch(id_delete)) { goto Delete; };
                    for (int i = 0; i < count; i++)
                    {
                        if (list[i].Id == Int32.Parse(id_delete))
                        {
                            list.RemoveAt(i);
                            Console.WriteLine("xóa thành công ");
                            break;
                        }
                    }

                    break;
                }
            case 3:
                {
                Search: Console.WriteLine("nhập id sinh viên:");
                    String id_search = Console.ReadLine();
                    if (!num.IsMatch(id_search.ToString())) { goto Search; };
                    list.Where(stu => stu.Id == Int32.Parse(id_search)).ToList().ForEach(Console.WriteLine);
                    break;
                }
            case 4:
                {
                Update: Console.WriteLine("nhập id sinh viên:");
                    string id_update = Console.ReadLine();
                    if (!num.IsMatch(id_update.ToString())) { goto Update; };
                    var resul = list.Where(stu => stu.Id == Int32.Parse(id_update));
                    resul.ToList().ForEach(Console.WriteLine);
                Name: Console.WriteLine("nhập tên sinh viên:");
                    resul.First().Name = Console.ReadLine();
                    if (!chars.IsMatch(resul.First().Name)) { goto Name; };
                Gender: Console.WriteLine("nhập giới tính sinh viên(1:Nam hoặc 0:Nữ):");
                    string? check_gender = Console.ReadLine();
                    if (!bools.IsMatch(check_gender)) { goto Gender; };
                    resul.First().IsGender = check_gender == "1" ? true : false;
                BrithDay: Console.WriteLine("nhập ngày sinh của sinh viên:");
                    string? check_brithday = Console.ReadLine();
                    if (!day.IsMatch(check_brithday)) { goto BrithDay; };
                    resul.First().BrithDay = DateTime.Parse(check_brithday);
                    break;
                }
            case 5:
                {
                    list.ForEach(Console.WriteLine);
                    break;
                }
            case 6:
                {
                    list.OrderByDescending(stu => stu.Id).ToList().ForEach(Console.WriteLine);
                    break;
                }
            default: return;
        }
    }
} while(Int32.Parse(a)<7);

