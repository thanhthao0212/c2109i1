
using ArgumentAndParams;

//pure oop
//ArgumentClass argu = new ArgumentClass();

//dùng var
//var argu =new ArgumentClass();

//target-type
ArgumentClass argu = new();

//named argument
argu.Display(4, 5, 6);
argu.Display(a: 4, b: 5, c: 6);
argu.Display(a: 4, b: 5, 6);
argu.Display(a: 4,    5, 6);
argu.Display(b: 4, c: 5, a: 6);
argu.Display(c: 4, a: 5, b: 6);
//argu.Display(b:4, 5, 6->erro);

ArgumentClass.Show(10);
