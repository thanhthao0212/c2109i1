using GenericClass;

ClassOne<int> one = new ClassOne<int>();
one.Field = 10;
one.Show();

ClassTwo<string,int> two= new();
two.Field1 = "Thao";
two.Field2= 10;
two.Show();