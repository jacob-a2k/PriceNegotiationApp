namespace PriceNegotiationApp.Entities
{
    public class Negotiation
    {
        private const int TotalTrys = 3;

        public int Id { get; set; }
        public Product Item { get; set; }
        public DateTime BetDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ActualTry { get; set; }
        public decimal ActualPrice { get; set; }
    }
}
