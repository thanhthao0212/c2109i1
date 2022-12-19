

namespace OopEncapsulationProperty;
internal class HumanBeing
{
    //fields các field phải là private
    private string fullname;
    // thuộc tính address theo c# mới
    public string Address { get; set; }
    public int Age { get; set; }

    //Property theo c# cũ
    public string FullName
    {
        set => fullname = value;
        get => fullname;
        
    }

    public void ShowProper()
    {
        Console.WriteLine($"{nameof(Address)}={Address}");
        Console.WriteLine($"{nameof(fullname)}={fullname}");
    }
}
