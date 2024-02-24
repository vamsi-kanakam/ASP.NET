namespace StarterProject.Models
{
    public class TaxCalculator
    {
        public decimal Subtotal { get; set; }
        public decimal TaxRate { get; set; }

        public decimal CalculateTotal()
        {
            return Subtotal * (1 + TaxRate);
        }
    }
}
