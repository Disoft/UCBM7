namespace GeneralLibrary.Regresion
{
    public class CalculadoraDeDescuentos
    {
        public decimal ApplyDiscount(decimal totalAmount)
        {
            if (totalAmount >= 1000)
                return totalAmount * 0.9m; // 10% de descuento
            if (totalAmount >= 500)
                return totalAmount * 0.95m; // 5% de descuento
            return totalAmount; // sin descuento
        }
    }
}
