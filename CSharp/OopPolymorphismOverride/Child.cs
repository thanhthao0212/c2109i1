﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverride;
internal class Child :Parent
{
    public override void Display()
    {
        //base.Display();
        Console.WriteLine("child display");
    }
    public new void Show()
    {
        Console.WriteLine("child Show");
    }
}
