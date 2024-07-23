using AbstractDemoLibrary;
internal class Program
{
    private static void Main(string[] args)
    {
        ElectronicProducts ep=new ElectronicProducts();
        ep.ProdID = 1;
        ep.ProductName = "Test";
        ep.Price= 100;
        ep.MfgDate = new DateOnly(2024, 7, 22);
        ep.PrintProductDescription();
        Console.WriteLine(ep.Description);

        GlassProducts gp=new GlassProducts();
        gp.ProdID = 101;
        gp.ProductName = "Glass1";
        gp.Price = 100;
        gp.PrintProductDescription();
        Console.WriteLine(gp.Note);
        Console.Read();

    }
}