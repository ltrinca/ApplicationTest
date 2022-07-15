namespace TradeApp.Domain
{
    public class Trade : ITrade
    {
        private const string PUBLIC = "PUBLIC";
        private const string PRIVATE = "PRIVATE";
        private const int VALUE = 1000000;

        public double Value { get ; }

        public string ClientSector { get; }

        public DateTime NextPaymentDate { get; }

        public Trade(double value, string clientSector, DateTime nextPaymentDate)
        {
            Value = value;
            ClientSector = clientSector;
            NextPaymentDate = nextPaymentDate;
        }

        public Categoria TradeCategoryVerification(Trade trade,DateTime referenceDate)
        {
            if ((referenceDate - trade.NextPaymentDate).TotalDays > 30)
            {
                return Categoria.EXPIRED;
            }
            else if (trade.Value > VALUE & trade.ClientSector == PRIVATE)
            {
                return Categoria.HIGHRISK;
            }
            else if (trade.Value > VALUE & trade.ClientSector == PUBLIC)
            {
                return Categoria.MEDIUMRISK;
            }
            else
            {
                return Categoria.NA;
            }
        }
    }
}
