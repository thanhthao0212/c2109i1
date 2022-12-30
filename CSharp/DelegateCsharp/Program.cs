
using DelegateCsharp;
//c1
//Mathems ma = new();
//ma.Add(10, 5);

//c2
//new Mathems().Div(10, 5);

//c3
//Mathems.Multi(10, 5);

Abc dele = new Mathems().Div;
dele += new Mathems().Sub;
dele(5, 10); //safe thread
