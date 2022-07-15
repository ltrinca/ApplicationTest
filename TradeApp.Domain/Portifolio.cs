namespace TradeApp.Domain
{
    public class Portifolio
    {
        public DateTime ReferenceDate { get; set; }
        public int NumberOfTrades { get; set; }
        public List<Trade> TradeList { get; set; }
 
    }
}
