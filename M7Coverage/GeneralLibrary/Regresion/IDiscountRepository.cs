namespace GeneralLibrary.Regresion
{
    public interface IDiscountRepository
    {
        decimal? GetPersonalizedDiscount(string customerId);
    }
}
