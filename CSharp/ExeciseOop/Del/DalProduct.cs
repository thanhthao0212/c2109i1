

using ExeciseOop.ExtentionMethod;

namespace ExeciseOop.Del;
internal class DalProduct:IProduct
{
    public List<Product> ListPro { get; set; } = new();

    public void AddProduct()
    {
        ListPro.ChangColor(ConsoleColor.Black, ConsoleColor.Blue);
        Console.WriteLine("enter the number of product");
        var n = Validate<int>.CheckReadLine();

        for( int i = 0; i <n; i++ ) 
        {
            Product pro = new Product();
            Console.WriteLine($"product[{i+1}] => enter id product: ");
            pro.ProId = Validate<string>.CheckReadLine();

            ListPro.Add( pro );
        }

    }
}
