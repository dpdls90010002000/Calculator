namespace Yein_A1;
//Yein An 301316062
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("301316062 Yein AN");
        Console.WriteLine("Product Category");
        foreach (string vl in Enum.GetNames(typeof(ProductCategory)))
        {
            
        }

        Console.WriteLine("");

        Purchase shop1 = new Purchase(ProductCategory.Electronics, 2);

        shop1.CalculateCost();

        Console.WriteLine($"{shop1}");


        Purchase shop2 = new Purchase(ProductCategory.Beverages, 4);
        shop2.CalculateCost();

        Console.WriteLine($"{shop2}");




        Purchase shop3 = new Purchase(ProductCategory.Electronics, 3);
        shop3.CalculateCost();

        Console.WriteLine($"{shop3}");


    }

    public enum ProductCategory
    {
        Grocery, Electronics, Beverages, CleaningSupplies, Miscellaneous
    }

    

    public class Purchase
    {
        public static int Purchase_ID = 1;
        public ProductCategory Category;
        public int Quantities;
        double Cost;
        double Discount;
        double DiscountPrice;
        double DiscountRate;


    public Purchase(ProductCategory category,int quantities =1)
           
        {
            this.Quantities = quantities;
            this.Cost = 0;
            this.Category = category;
            
            Purchase_ID = ++Purchase_ID;
        }

        

        public void CalculateCost()
        {
            
            double DiscountRate = 0;
            int Price = 0;
            double taxRate = 1.13;

            switch (Category)
            {

                
                case ProductCategory.Grocery:
                    Price = 1;
                    DiscountRate = 0.2;
                    break;
                case ProductCategory.Electronics:
                    Price = 15;
                    DiscountRate = 0.1;
                    break;
                case ProductCategory.Beverages:
                    Price = 10;
                    DiscountRate = 0.05;
                    break;
                case ProductCategory.CleaningSupplies:
                    Price = 5;
                    DiscountRate = 0.15;
                    break;
                case ProductCategory.Miscellaneous:
                    Price = 20;
                    DiscountRate = 0;
                    break;

            }

            this.Cost = Price * this.Quantities * (1 - DiscountRate) * taxRate;

        }

        public override string ToString()
        {
            return $"--------------------------------------------------\n" +
                $"Purchase ID : {Purchase_ID}\n{Category} Quantities : {Quantities} \n Total Cost [Price - Discount + Tax (13%)] : {Cost:C}";
        }
    }
}
