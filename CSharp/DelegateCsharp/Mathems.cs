﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCsharp;
delegate void Abc(int a, int b );
internal class Mathems
{
    public void Add(int a, int b) => Console.WriteLine(a + b);
    public void Sub(int a, int b) => Console.WriteLine(a - b);
    public static void Multi(int a, int b) => Console.WriteLine(a * b);
    public void Div(int a, int b) => Console.WriteLine(a / b);
}
