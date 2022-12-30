namespace ExeciseOop.ExtentionMethod;
internal static class ExtMethod
{
    public static void ChangColor<T>(this T item, params ConsoleColor[] cw)
    {
        Console.BackgroundColor = cw[0];
        Console.ForegroundColor = cw[1];
    }
    
    public static bool In<T>(this T obj ,params T[] items)
    {
        return items.Contains(obj);
    }
}
