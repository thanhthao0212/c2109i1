
internal class Program
{
    public static void Add(int a, int b) => Console.WriteLine(a + b);
    public static void Show() => Console.WriteLine("c2109i1");
    public static int Sub(int a, int b) => a - b;
    public static int ReturnNumber() => 5;

    private static void Main(string[] args)
    {
        //local function
        void Sb(int a, int b) => Console.WriteLine(a + b);

        // func và action => đều là delegate
        //action dùng cho các phương thức là void
        //func dùng cho các phương thức khác void

        Action act = Show;
        act();
        

        Action<int, int> ac = Add;
        ac(8, 9);

        Func<int> fun = ReturnNumber;
        Console.WriteLine(fun());

        Func<int, int, int> sb = Sub;
        Console.WriteLine(sb(10,5));

        Action action = () =>
        {
            Console.WriteLine("hiii");
        };
        action();

    }
}