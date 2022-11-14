namespace ProductExpiryCalculator.Models
{
    public class Product
    {
        public string ProductName;
        public int DaysUntilExpiry;
        public DateTime DateOfExpiry => DateTime.Now.AddDays(DaysUntilExpiry);

        public Product(string name, int daysUntilExpiry)
        {
            ProductName = name;
            DaysUntilExpiry = daysUntilExpiry;
        }
    }
}
