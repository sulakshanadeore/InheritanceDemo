namespace AbstractDemoLibrary
{
    public abstract class Products
    {
        //concrete member/s--- have body {}
        public int ProdID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        
        //abstract member---has no body {}
        //abstract members are virtual by default
        public abstract void PrintProductDescription();

        public DateOnly MfgDate { get; set; }
    }


    public class ElectronicProducts : Products
    {
        
        public string Description { get;  private set; }
        public override void PrintProductDescription()
        {

            Description = $"Electronic Product, has  a mfg date {base.MfgDate}";

           // throw new NotImplementedException();

        }

    }

    public class GlassProducts : Products
    {
        public string Note { get; set; }

        public override void PrintProductDescription()
        {
            Note = "As this is a glass product,no guarantee/warranty";
        //    throw new NotImplementedException();
        }

    }

}
