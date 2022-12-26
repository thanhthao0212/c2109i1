using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass;
internal class ClassTwo<T,F>
{
    public T Field1 { get; set; }
    public F Field2 { get; set; }

    public void Show() => Console.WriteLine($"{Field1},{Field2}");
}
