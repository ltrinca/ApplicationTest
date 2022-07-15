namespace TradeApp.Domain
{
    public interface ITrade
        {
        double Value { get; }
        string ClientSector { get; }
        DateTime NextPaymentDate { get; }

        Categoria TradeCategoryVerification(Trade trade, DateTime referenceDate);
    }
}
