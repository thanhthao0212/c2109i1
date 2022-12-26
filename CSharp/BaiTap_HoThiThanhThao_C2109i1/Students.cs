

namespace BaiTap_HoThiThanhThao_C2109i1;
internal class Students
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsGender { get; set; }
    public DateTime BrithDay { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, GenDer={(IsGender?"Nam":"Nữ")}, {nameof(BrithDay)}={BrithDay.ToString("yyyy-MM-dd")}}}";
    }
}
