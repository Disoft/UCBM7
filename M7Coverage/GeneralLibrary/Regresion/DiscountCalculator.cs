namespace GeneralLibrary.Regresion
{
    public class DiscountCalculator
    {
        private readonly IDiscountRepository repository;

        public DiscountCalculator(IDiscountRepository repository)
        {
            this.repository = repository;
        }

        public decimal ApplyDiscount(string customerId, decimal totalAmount)
        {
            var customDiscount = repository.GetPersonalizedDiscount(customerId);
            if (customDiscount.HasValue)
            {
                return totalAmount * (1 - customDiscount.Value);
            }

            if (totalAmount >= 1000)
                return totalAmount * 0.9m;

            if (totalAmount >= 500)
                return totalAmount * 0.95m;

            return totalAmount;
        }
    }
}
