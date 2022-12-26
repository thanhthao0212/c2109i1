using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndLINQ;
internal class Student
{
    public int RollNumber { get; set; }
    //prop+ tab
    public string FullName { get; set; }
    public string Section { get; set; }
    public int HostelNumber { get; set; }

    public override string ToString()
    {
        return $"{{{nameof(RollNumber)}={RollNumber.ToString()}, {nameof(FullName)}={FullName}, {nameof(Section)}={Section}, {nameof(HostelNumber)}={HostelNumber.ToString()}}}";
    }
}